namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
[Token(Token = "0x200007A")]
public class DebugInfoExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000103")]
	private readonly SymbolDocumentInfo <Document>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700007A")]
	public SymbolDocumentInfo Document
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002FD")]
		 get { } //Length: 5
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000079")]
	public override int EndLine
	{
		[Address(RVA = "0x2255D60", Offset = "0x2255160", Length = "0x27")]
		[Token(Token = "0x60002FC")]
		 get { } //Length: 39
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x1700007B")]
	public override bool IsClear
	{
		[Address(RVA = "0x2255D90", Offset = "0x2255190", Length = "0x27")]
		[Token(Token = "0x60002FE")]
		 get { } //Length: 39
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000078")]
	public override int StartLine
	{
		[Address(RVA = "0x2255DC0", Offset = "0x22551C0", Length = "0x27")]
		[Token(Token = "0x60002FB")]
		 get { } //Length: 39
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002FD")]
	public SymbolDocumentInfo get_Document() { }

	[Address(RVA = "0x2255D60", Offset = "0x2255160", Length = "0x27")]
	[Token(Token = "0x60002FC")]
	public override int get_EndLine() { }

	[Address(RVA = "0x2255D90", Offset = "0x2255190", Length = "0x27")]
	[Token(Token = "0x60002FE")]
	public override bool get_IsClear() { }

	[Address(RVA = "0x2255DC0", Offset = "0x22551C0", Length = "0x27")]
	[Token(Token = "0x60002FB")]
	public override int get_StartLine() { }

}

