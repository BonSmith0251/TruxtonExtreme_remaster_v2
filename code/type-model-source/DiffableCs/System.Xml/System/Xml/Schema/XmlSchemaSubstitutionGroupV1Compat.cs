namespace System.Xml.Schema;

[Token(Token = "0x2000248")]
internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BED")]
	private XmlSchemaChoice choice; //Field offset: 0x48

	[Token(Token = "0x1700065A")]
	[XmlIgnore]
	internal XmlSchemaChoice Choice
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60016B5")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x24A2250", Offset = "0x24A1650", Length = "0xEE")]
	[Token(Token = "0x60016B6")]
	public XmlSchemaSubstitutionGroupV1Compat() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60016B5")]
	internal XmlSchemaChoice get_Choice() { }

}

