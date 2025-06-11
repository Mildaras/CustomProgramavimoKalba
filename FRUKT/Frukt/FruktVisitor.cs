using Antlr4.Runtime.Misc;


namespace Frukt;

public class FruktVisitor : FruktBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; set; } = new ();
    private Dictionary<string, object?[]> Arrays { get; set; } = new ();


    public FruktVisitor()
    {
        Variables["Print"] = new Func<object?[], object?>(Print);
        Variables["PrintTo"] = new Func<object?[], object?>(PrintTo);
    }
    
    public override object? VisitAssignment(FruktParser.AssignmentContext context)
    {   
        var varName = context.IDENTIFIER().GetText();
        
        var value = Visit(context.expression());

        Variables[varName] = value;
        
        return null;
    }
    
    private int Length(object?[] args)
    {   
        return args.Length;
    }

    private object? Print(object?[] args)
    {   
        foreach(object? arg in args)
        {   
            if( arg is not null)
                Console.WriteLine(arg);
        }
        return null;
    }

    private object? PrintTo(object?[] args)
    {   
        using(StreamWriter writer = new StreamWriter((string)args[0], append: true))
        {
            for( int i = 1; i < args.Length; i++ )
            {
                string? value = args[i]?.ToString();
                writer.WriteLine(value);
            }
        }
        return null;
    }
        
    public override object? VisitFunctionStatement(FruktParser.FunctionStatementContext context)
    {
        var functionName = context.IDENTIFIER().GetText();
        //var parameters = context.expression().Select(Visit).ToArray();
        
        // Define a new function in the Variables dictionary
        Variables[functionName] = new Func<object?[], object?>(parameters =>
        {   
            // Create a new dictionary to store local variables within the function scope
            var localVariables = new Dictionary<string, object?>();
            
            foreach (var variable in Variables){
                if(variable.Value is Func<object?[], object?> varfunc){
                    localVariables[variable.Key] = variable.Value;
                }
            }

            // Assign arguments to parameter names in the local variables dictionary
            if (context.expression() != null)
            {
                var paramList = context.expression();
                for (int i = 0; i < paramList.Length; i++)
                {
                    var paramName = paramList[i].GetText();
                    if (i < parameters.Length)
                        localVariables[paramName] = parameters[i];
                }
            }

            // Create a new visitor instance to visit the block within the function scope
            var visitor = new FruktVisitor();
            visitor.Variables = localVariables;
            visitor.Arrays = Arrays;

            // Visit the block and return the result
            return visitor.Visit(context.block());
        });

        return null;
    }

    public override object? VisitFunctionCall(FruktParser.FunctionCallContext context)
    { 
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).ToArray();

        if( !Variables.ContainsKey(name) )
            throw new Exception($"Function {name} is not defined");

        if( !(Variables[name] is Func<object?[], object?> varfunc) )
            throw new Exception($"Function {name} is not a function");  

        return varfunc(args);
    }
     

    public override object? VisitIfBlock(FruktParser.IfBlockContext context)
    {   
        if(Visit(context.expression()) is bool expression) 
        {   
            if (expression)
            {
                Visit(context.block());
            }   
            else
            {   
                if (context.elseifBlock() != null)
                {
                    Visit(context.elseifBlock());
                }
                else if (context.elseBlock() != null)
                {
                    Visit(context.elseBlock());
                }
            }
        }

        return null;
    }
         
    public override object? VisitElseifBlock(FruktParser.ElseifBlockContext context)
    {   
        if(Visit(context.expression()) is bool expression) 
        {
            if (expression)
            {
                Visit(context.block());
            }  
            else
            {
                if (context.elseifBlock() != null)
                {
                    Visit(context.elseifBlock());
                }
                else if (context.elseBlock() != null)
                {
                    Visit(context.elseBlock());
                }
            }
        }

        return null;
    }

    public override object? VisitElseBlock(FruktParser.ElseBlockContext context)
    {
        Visit(context.block());

        return null;
    }

    public override object? VisitWhileBlock(FruktParser.WhileBlockContext context)
    {
        while( Visit(context.expression()) is bool expression && expression )
        {
            Visit(context.block());
        }
        
        return null;
    }

    public override object? VisitConstant(FruktParser.ConstantContext context)
    {   
        if(context.NUMBER() is {} i)       // galima rasyt (context.NUMBER() != null)
            return int.Parse(i.GetText());  // int.Parse(context.NUMBER().GetText()) [sumazina calls]

        if(context.FLOAT() is {} f)
            return float.Parse(f.GetText());

        if(context.BOOL() is {} b)
            return Boolean.Parse(b.GetText());

        if(context.TEXT() is {} t)
            return t.GetText()[1..^1];

        throw new NotImplementedException();
    }
    
    public override object? VisitComparisonExpression(FruktParser.ComparisonExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        if( left == null || right == null ) 
            return null;
        
        var opSymbol = context.compareOp().GetText();

        return Compare(left, opSymbol, right);
    }

    public override object? VisitArrayDeclaration(FruktParser.ArrayDeclarationContext context)
    {
        var arrayName = context.IDENTIFIER().GetText();
        //var expressionList = context.expressionList()?.expression().Select(Visit).ToArray();
        var expressionList = new List<object>();
        
        // Evaluate the expressions in the array declaration
        foreach (var expressionContext in context.expressionList().expression())
        {
            var expressionValue = Visit(expressionContext);
            if(expressionValue is not null){
                expressionList.Add(expressionValue);
            }
        }
        Arrays[arrayName] = expressionList.ToArray();
        //Arrays[arrayName] = expressionList;
        
        return null;
    }   

    public override object? VisitArrayAccess(FruktParser.ArrayAccessContext context)
    {
        var arrayName = context.IDENTIFIER().GetText();
        var index = (int)Visit(context.expression());
        
        if (Arrays.TryGetValue(arrayName, out var array))
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else
            {
                throw new IndexOutOfRangeException($"Index '{index}' is out of range for array '{arrayName}'");
            }
        }
        else
        {
            throw new Exception($"Array '{arrayName}' is not defined");
        }
    }



    private bool Compare(object? left, string opSymbol, object? right){
        if (left is int leftInt && right is int rightInt)
        {
            return opSymbol switch
            {
                "<"  => leftInt < rightInt,
                ">"  => leftInt > rightInt,
                "<=" => leftInt <= rightInt,
                ">=" => leftInt >= rightInt,
                "==" => leftInt == rightInt,
                "!=" => leftInt != rightInt,
                _    => throw new NotImplementedException()
            };
        }
        else if (left is float leftFloat && right is float rightFloat)
        {
            return opSymbol switch
            {
                "<"  => leftFloat < rightFloat,
                ">"  => leftFloat > rightFloat,
                "<=" => leftFloat <= rightFloat,
                ">=" => leftFloat >= rightFloat,
                "==" => leftFloat == rightFloat,
                "!=" => leftFloat != rightFloat,
                _    => throw new NotImplementedException()
            };
        }
        else if (left is float leftfloat && right is int rightint)
        {
            return opSymbol switch
            {
                "<"  => leftfloat < rightint,
                ">"  => leftfloat > rightint,
                "<=" => leftfloat <= rightint,
                ">=" => leftfloat >= rightint,
                "==" => leftfloat == rightint,
                "!=" => leftfloat != rightint,
                _    => throw new NotImplementedException()
            };
        }
        else if (left is int leftint && right is float rightfloat)
        {
            return opSymbol switch
            {
                "<"  => leftint < rightfloat,
                ">"  => leftint > rightfloat,
                "<=" => leftint <= rightfloat,
                ">=" => leftint >= rightfloat,
                "==" => leftint == rightfloat,
                "!=" => leftint != rightfloat,
                _   => throw new NotImplementedException()
            };
        }
        return false;
    }

    public override object? VisitMultipleComparisonExpression(FruktParser.MultipleComparisonExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var mid = Visit(context.expression(1));
        var right = Visit(context.expression(2));

        if( left == null || right == null || mid == null) 
            return null;

        var leftOpSymbol = context.compareOp(0).GetText();
        var rightOpSymbol = context.compareOp(1).GetText();

        return (Compare(left, leftOpSymbol, mid) && Compare(mid, rightOpSymbol, right));
    }

    public override object? VisitIdentifierExpression(FruktParser.IdentifierExpressionContext context)
    {
        var varName = context.IDENTIFIER().GetText();

        if(!Variables.ContainsKey(varName) && !Arrays.ContainsKey(varName))
            throw new Exception($"Variable {varName} is not defined");
        
        return Variables[varName];
    }

    public override object? VisitAddsubExpression(FruktParser.AddsubExpressionContext context)
    {       
        var left = Visit(context.expression(0));

        var right = Visit(context.expression(1));

        var opSymbol = context.addsubOp().GetText();

        return opSymbol switch
        {
            "+" => Add(left, right),
            "-" => Subtract(left, right),
            _   => throw new NotImplementedException()
        };
    }

    private object? Add(object? left, object? right)
    {
        if (left is int l && right is int r)
            return l + r;
        if (left is float lf && right is float rf)
            return lf + rf;
        if (left is float lfloat && right is int rint)
            return lfloat + rint;
        if (left is int lint && right is float rfloat)
            return lint + rfloat;
        
        throw new Exception("cannot add values");
    }

    private object? Subtract(object? left, object? right)
    {   
        if (left is int l && right is int r)
            return l - r;
        if (left is float lf && right is float rf)
            return lf - rf;
        if (left is float lfloat && right is int rint)
            return lfloat - rint;
        if (left is int lint && right is float rfloat)
            return lint - rfloat;

        throw new Exception("cannot subtract values");
    }

    public override object? VisitMultdivExpression(FruktParser.MultdivExpressionContext context)
    {
        var left = Visit(context.expression(0));

        var right = Visit(context.expression(1));

        var opSymbol = context.multdivOp().GetText();

        return opSymbol switch
        {
            "*" => Multiply(left, right),
            "/" => Divide(left, right),
            _   => throw new NotImplementedException()
        };
    }

    private object? Multiply(object? left, object? right)
    {   
        if (left is int l && right is int r)
            return l * r;
        if (left is float lf && right is float rf)
            return lf * rf;
        if (left is float lfloat && right is int rint)
            return lfloat * rint;
        if (left is int lint && right is float rfloat)
            return lint * rfloat;
    
        throw new Exception("Cannot multiply values!");
    }

    private object? Divide(object? left, object? right)
    {   
        if (left is int l && right is int r){
            if(l % r != 0){
                return ((float)l / (float)r);
            }
            return l / r;
        }
        if (left is float lf && right is float rf)
            return lf / rf;
        if (left is float lfloat && right is int rint)
            return lfloat / rint;
        if (left is int lint && right is float rfloat)
            return lint / rfloat;
        throw new Exception("Cannot divide values!");
    }
}