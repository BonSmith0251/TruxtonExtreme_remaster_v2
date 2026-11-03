namespace System.Data;

[Token(Token = "0x2000070")]
internal sealed class ZeroOpNode : ExpressionNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400023D")]
	internal readonly int _op; //Field offset: 0x18

	[Address(RVA = "0x2357C90", Offset = "0x2357090", Length = "0x27")]
	[Token(Token = "0x600062B")]
	internal ZeroOpNode(int op) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600062C")]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0x2357C00", Offset = "0x2357000", Length = "0x89")]
	[Token(Token = "0x600062D")]
	internal virtual object Eval() { }

	[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
	[Token(Token = "0x600062E")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
	[Token(Token = "0x600062F")]
	internal virtual object Eval(Int32[] recordNos) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000632")]
	internal virtual bool HasLocalAggregate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000633")]
	internal virtual bool HasRemoteAggregate() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000630")]
	internal virtual bool IsConstant() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000631")]
	internal virtual bool IsTableConstant() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000634")]
	internal virtual ExpressionNode Optimize() { }

}

