namespace System.Data;

[Token(Token = "0x200006F")]
internal sealed class UnaryNode : ExpressionNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400023B")]
	internal readonly int _op; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400023C")]
	internal ExpressionNode _right; //Field offset: 0x20

	[Address(RVA = "0x234F6A0", Offset = "0x234EAA0", Length = "0x42")]
	[Token(Token = "0x600061F")]
	internal UnaryNode(DataTable table, int op, ExpressionNode right) { }

	[Address(RVA = "0x234EA70", Offset = "0x234DE70", Length = "0x5C")]
	[Token(Token = "0x6000620")]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0x234EAD0", Offset = "0x234DED0", Length = "0x2A")]
	[Token(Token = "0x6000629")]
	internal virtual bool DependsOn(DataColumn column) { }

	[Address(RVA = "0x230DA20", Offset = "0x230CE20", Length = "0x1C")]
	[Token(Token = "0x6000621")]
	internal virtual object Eval() { }

	[Address(RVA = "0x234F4A0", Offset = "0x234E8A0", Length = "0x4B")]
	[Token(Token = "0x6000622")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x234F470", Offset = "0x234E870", Length = "0x2A")]
	[Token(Token = "0x6000623")]
	internal virtual object Eval(Int32[] recordNos) { }

	[Address(RVA = "0x234EB00", Offset = "0x234DF00", Length = "0x324")]
	[Token(Token = "0x6000624")]
	private object EvalUnaryOp(int op, object vl) { }

	[Address(RVA = "0x234F4F0", Offset = "0x234E8F0", Length = "0x2A")]
	[Token(Token = "0x6000627")]
	internal virtual bool HasLocalAggregate() { }

	[Address(RVA = "0x234F520", Offset = "0x234E920", Length = "0x2A")]
	[Token(Token = "0x6000628")]
	internal virtual bool HasRemoteAggregate() { }

	[Address(RVA = "0x234F550", Offset = "0x234E950", Length = "0x2A")]
	[Token(Token = "0x6000625")]
	internal virtual bool IsConstant() { }

	[Address(RVA = "0x234F580", Offset = "0x234E980", Length = "0x2A")]
	[Token(Token = "0x6000626")]
	internal virtual bool IsTableConstant() { }

	[Address(RVA = "0x234F5B0", Offset = "0x234E9B0", Length = "0xE8")]
	[Token(Token = "0x600062A")]
	internal virtual ExpressionNode Optimize() { }

}

