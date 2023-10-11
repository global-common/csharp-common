//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from JSON5.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Global.Parser.Json5 {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IJSON5Listener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class JSON5BaseListener : IJSON5Listener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSON5Parser.json5"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJson5([NotNull] JSON5Parser.Json5Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSON5Parser.json5"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJson5([NotNull] JSON5Parser.Json5Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSON5Parser.obj"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObj([NotNull] JSON5Parser.ObjContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSON5Parser.obj"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObj([NotNull] JSON5Parser.ObjContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSON5Parser.pair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPair([NotNull] JSON5Parser.PairContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSON5Parser.pair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPair([NotNull] JSON5Parser.PairContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSON5Parser.key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKey([NotNull] JSON5Parser.KeyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSON5Parser.key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKey([NotNull] JSON5Parser.KeyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSON5Parser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue([NotNull] JSON5Parser.ValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSON5Parser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue([NotNull] JSON5Parser.ValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSON5Parser.arr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArr([NotNull] JSON5Parser.ArrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSON5Parser.arr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArr([NotNull] JSON5Parser.ArrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="JSON5Parser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumber([NotNull] JSON5Parser.NumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="JSON5Parser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumber([NotNull] JSON5Parser.NumberContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Global.Parser.Json5
