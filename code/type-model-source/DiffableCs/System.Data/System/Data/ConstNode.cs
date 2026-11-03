namespace System.Data;

[Token(Token = "0x200005E")]
internal sealed class ConstNode : ExpressionNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E6")]
	internal readonly object _val; //Field offset: 0x18

	[Address(RVA = "0x2332F80", Offset = "0x2332380", Length = "0x1C")]
	[Token(Token = "0x6000571")]
	internal ConstNode(DataTable table, ValueType type, object constant) { }

	[Address(RVA = "0x2332C30", Offset = "0x2332030", Length = "0x328")]
	[Token(Token = "0x6000572")]
	internal ConstNode(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000573")]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000574")]
	internal virtual object Eval() { }

	[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
	[Token(Token = "0x6000575")]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
	[Token(Token = "0x6000576")]
	internal virtual object Eval(Int32[] recordNos) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000579")]
	internal virtual bool HasLocalAggregate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600057A")]
	internal virtual bool HasRemoteAggregate() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000577")]
	internal virtual bool IsConstant() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000578")]
	internal virtual bool IsTableConstant() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600057B")]
	internal virtual ExpressionNode Optimize() { }

	[Address(RVA = "0x23326D0", Offset = "0x2331AD0", Length = "0x270")]
	[Token(Token = "0x600057C")]
	private object SmallestDecimal(object constant) { }

	[Address(RVA = "0x2332940", Offset = "0x2331D40", Length = "0x2EA")]
	[Token(Token = "0x600057D")]
	private object SmallestNumeric(object constant) { }

}

