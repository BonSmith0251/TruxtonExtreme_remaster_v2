namespace System.Xml.Schema;

[Token(Token = "0x2000203")]
internal sealed class XmlSchemaCollectionNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B14")]
	private string namespaceUri; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B15")]
	private SchemaInfo schemaInfo; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B16")]
	private XmlSchema schema; //Field offset: 0x20

	[Token(Token = "0x17000597")]
	internal string NamespaceURI
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60014BC")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000599")]
	internal XmlSchema Schema
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60014BF")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60014C0")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000598")]
	internal SchemaInfo SchemaInfo
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60014BD")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60014BE")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60014C1")]
	public XmlSchemaCollectionNode() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60014BF")]
	internal XmlSchema get_Schema() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60014BD")]
	internal SchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60014BC")]
	internal void set_NamespaceURI(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60014C0")]
	internal void set_Schema(XmlSchema value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60014BE")]
	internal void set_SchemaInfo(SchemaInfo value) { }

}

