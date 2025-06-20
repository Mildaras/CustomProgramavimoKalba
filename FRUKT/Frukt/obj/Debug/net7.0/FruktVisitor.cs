﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\milda\OneDrive\Stalinis kompiuteris\pktProjektas\projektas2023\Frukt\Frukt.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Frukt {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="FruktParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IFruktVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpression([NotNull] FruktParser.ConstantExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] FruktParser.IdentifierExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallExpression([NotNull] FruktParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>arrayAccessExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayAccessExpression([NotNull] FruktParser.ArrayAccessExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesesExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesesExpression([NotNull] FruktParser.ParenthesesExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multdivExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultdivExpression([NotNull] FruktParser.MultdivExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>addsubExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddsubExpression([NotNull] FruktParser.AddsubExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multipleComparisonExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultipleComparisonExpression([NotNull] FruktParser.MultipleComparisonExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparisonExpression([NotNull] FruktParser.ComparisonExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] FruktParser.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] FruktParser.LineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] FruktParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] FruktParser.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] FruktParser.AssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] FruktParser.ConstantContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] FruktParser.IfBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.elseifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseifBlock([NotNull] FruktParser.ElseifBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseBlock([NotNull] FruktParser.ElseBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileBlock([NotNull] FruktParser.WhileBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.functionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionStatement([NotNull] FruktParser.FunctionStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] FruktParser.FunctionCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayAccess([NotNull] FruktParser.ArrayAccessContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.arrayDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDeclaration([NotNull] FruktParser.ArrayDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.expressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionList([NotNull] FruktParser.ExpressionListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] FruktParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.multdivOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultdivOp([NotNull] FruktParser.MultdivOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.addsubOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddsubOp([NotNull] FruktParser.AddsubOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="FruktParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareOp([NotNull] FruktParser.CompareOpContext context);
}
} // namespace Frukt
