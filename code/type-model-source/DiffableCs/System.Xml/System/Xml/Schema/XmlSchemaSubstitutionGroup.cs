namespace System.Xml.Schema;

[Token(Token = "0x2000247")]
internal class XmlSchemaSubstitutionGroup : XmlSchemaObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BEB")]
	private ArrayList membersList; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BEC")]
	private XmlQualifiedName examplar; //Field offset: 0x40

	[Token(Token = "0x17000659")]
	[XmlIgnore]
	internal XmlQualifiedName Examplar
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60016B2")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x60016B3")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000658")]
	[XmlIgnore]
	internal ArrayList Members
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60016B1")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x24A2340", Offset = "0x24A1740", Length = "0xA9")]
	[Token(Token = "0x60016B4")]
	public XmlSchemaSubstitutionGroup() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60016B2")]
	internal XmlQualifiedName get_Examplar() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60016B1")]
	internal ArrayList get_Members() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x60016B3")]
	internal void set_Examplar(XmlQualifiedName value) { }

}

