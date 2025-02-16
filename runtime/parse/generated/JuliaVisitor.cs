//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Julia.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace HyperSphere {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="JuliaParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface IJuliaVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScript([NotNull] JuliaParser.ScriptContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.moduleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleExpr([NotNull] JuliaParser.ModuleExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.moduleVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleVariableDeclaration([NotNull] JuliaParser.ModuleVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule([NotNull] JuliaParser.ModuleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.moduleExprStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleExprStatement([NotNull] JuliaParser.ModuleExprStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.usingModule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUsingModule([NotNull] JuliaParser.UsingModuleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.moduleRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleRef([NotNull] JuliaParser.ModuleRefContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.moduleIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleIdentifier([NotNull] JuliaParser.ModuleIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.symbolIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSymbolIdentifier([NotNull] JuliaParser.SymbolIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.abstractStructure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAbstractStructure([NotNull] JuliaParser.AbstractStructureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.implementedStructure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImplementedStructure([NotNull] JuliaParser.ImplementedStructureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.structure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructure([NotNull] JuliaParser.StructureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.structField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructField([NotNull] JuliaParser.StructFieldContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.structItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructItem([NotNull] JuliaParser.StructItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.blockExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockExpr([NotNull] JuliaParser.BlockExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.blockExprStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockExprStatement([NotNull] JuliaParser.BlockExprStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.blockVariableInstatiation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockVariableInstatiation([NotNull] JuliaParser.BlockVariableInstatiationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.blockArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockArg([NotNull] JuliaParser.BlockArgContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.blockVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockVariableDeclaration([NotNull] JuliaParser.BlockVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] JuliaParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.functionHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionHeader([NotNull] JuliaParser.FunctionHeaderContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.functionItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionItem([NotNull] JuliaParser.FunctionItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] JuliaParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.shortFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShortFunction([NotNull] JuliaParser.ShortFunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.longFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLongFunction([NotNull] JuliaParser.LongFunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.tuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTuple([NotNull] JuliaParser.TupleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.namedTuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamedTuple([NotNull] JuliaParser.NamedTupleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.typetuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypetuple([NotNull] JuliaParser.TypetupleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.tupleList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTupleList([NotNull] JuliaParser.TupleListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] JuliaParser.TypeNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.parameterizedType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterizedType([NotNull] JuliaParser.ParameterizedTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] JuliaParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JuliaParser.endExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndExpr([NotNull] JuliaParser.EndExprContext context);
}
} // namespace HyperSphere
