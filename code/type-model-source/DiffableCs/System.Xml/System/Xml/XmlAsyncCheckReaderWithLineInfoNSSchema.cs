namespace System.Xml;

[Token(Token = "0x2000047")]
internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000152")]
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; //Field offset: 0x30

	[Token(Token = "0x17000070")]
	private override bool System.Xml.Schema.IXmlSchemaInfo.IsDefault
	{
		[Address(RVA = "0x24ED770", Offset = "0x24ECB70", Length = "0x49")]
		[Token(Token = "0x6000234")]
		private get { } //Length: 73
	}

	[Token(Token = "0x17000071")]
	private override bool System.Xml.Schema.IXmlSchemaInfo.IsNil
	{
		[Address(RVA = "0x24ED7C0", Offset = "0x24ECBC0", Length = "0x49")]
		[Token(Token = "0x6000235")]
		private get { } //Length: 73
	}

	[Token(Token = "0x17000072")]
	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType
	{
		[Address(RVA = "0x24ED810", Offset = "0x24ECC10", Length = "0xBD")]
		[Token(Token = "0x6000236")]
		private get { } //Length: 189
	}

	[Token(Token = "0x17000075")]
	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute
	{
		[Address(RVA = "0x24ED8D0", Offset = "0x24ECCD0", Length = "0xBD")]
		[Token(Token = "0x6000239")]
		private get { } //Length: 189
	}

	[Token(Token = "0x17000074")]
	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement
	{
		[Address(RVA = "0x24ED990", Offset = "0x24ECD90", Length = "0xBD")]
		[Token(Token = "0x6000238")]
		private get { } //Length: 189
	}

	[Token(Token = "0x17000073")]
	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType
	{
		[Address(RVA = "0x24EDA50", Offset = "0x24ECE50", Length = "0xBD")]
		[Token(Token = "0x6000237")]
		private get { } //Length: 189
	}

	[Token(Token = "0x1700006F")]
	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity
	{
		[Address(RVA = "0x24EDB10", Offset = "0x24ECF10", Length = "0x46")]
		[Token(Token = "0x6000233")]
		private get { } //Length: 70
	}

	[Address(RVA = "0x24EDB60", Offset = "0x24ECF60", Length = "0xAD")]
	[Token(Token = "0x6000232")]
	public XmlAsyncCheckReaderWithLineInfoNSSchema(XmlReader reader) { }

	[Address(RVA = "0x24ED770", Offset = "0x24ECB70", Length = "0x49")]
	[Token(Token = "0x6000234")]
	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	[Address(RVA = "0x24ED7C0", Offset = "0x24ECBC0", Length = "0x49")]
	[Token(Token = "0x6000235")]
	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	[Address(RVA = "0x24ED810", Offset = "0x24ECC10", Length = "0xBD")]
	[Token(Token = "0x6000236")]
	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	[Address(RVA = "0x24ED8D0", Offset = "0x24ECCD0", Length = "0xBD")]
	[Token(Token = "0x6000239")]
	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	[Address(RVA = "0x24ED990", Offset = "0x24ECD90", Length = "0xBD")]
	[Token(Token = "0x6000238")]
	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	[Address(RVA = "0x24EDA50", Offset = "0x24ECE50", Length = "0xBD")]
	[Token(Token = "0x6000237")]
	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	[Address(RVA = "0x24EDB10", Offset = "0x24ECF10", Length = "0x46")]
	[Token(Token = "0x6000233")]
	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

}

