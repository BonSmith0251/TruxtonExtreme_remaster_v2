namespace System.Data;

[Token(Token = "0x200005D")]
internal sealed class LikeNode : BinaryNode
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E4")]
	private int _kind; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001E5")]
	private string _pattern; //Field offset: 0x38

	[Address(RVA = "0x2332640", Offset = "0x2331A40", Length = "0x70")]
	[Token(Token = "0x600056E")]
	internal LikeNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	[Address(RVA = "0x233E8A0", Offset = "0x233DCA0", Length = "0x33F")]
	[Token(Token = "0x6000570")]
	internal string AnalyzePattern(string pat) { }

	[Address(RVA = "0x233EBE0", Offset = "0x233DFE0", Length = "0x5C5")]
	[Token(Token = "0x600056F")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

}

