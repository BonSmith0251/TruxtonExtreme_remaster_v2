namespace System.Data;

[Token(Token = "0x2000095")]
internal sealed class ConstraintTable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002DC")]
	public DataTable table; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002DD")]
	public XmlSchemaIdentityConstraint constraint; //Field offset: 0x18

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000790")]
	public ConstraintTable(DataTable t, XmlSchemaIdentityConstraint c) { }

}

