namespace System.Xml.Schema;

[Token(Token = "0x20001D0")]
internal class RedefineEntry
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008A9")]
	internal XmlSchemaRedefine redefine; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008AA")]
	internal XmlSchema schemaToUpdate; //Field offset: 0x18

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60011CF")]
	public RedefineEntry(XmlSchemaRedefine external, XmlSchema schema) { }

}

