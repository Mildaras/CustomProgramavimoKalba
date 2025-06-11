using Antlr4.Runtime;
using Frukt;

if (args.Length == 0)
{
    Console.WriteLine("Please provide the path to the .frkt file as a command-line argument.");
    return;
}

var fileName = args[0];

var fileContents = File.ReadAllText(fileName);

var inputStream = new AntlrInputStream(fileContents);
var FruktLexer = new FruktLexer(inputStream);
var commonTokenStream = new CommonTokenStream(FruktLexer);
var FruktParser = new FruktParser(commonTokenStream);
var fruktContext = FruktParser.program();
var visitor = new FruktVisitor();

visitor.Visit(fruktContext);