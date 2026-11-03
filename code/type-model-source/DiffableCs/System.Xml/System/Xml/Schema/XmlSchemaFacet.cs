namespace System.Xml.Schema;

[Token(Token = "0x2000215")]
public abstract class XmlSchemaFacet : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B79")]
	private string value; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B7A")]
	private bool isFixed; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000B7B")]
	private FacetType facetType; //Field offset: 0x5C

	[Token(Token = "0x170005F0")]
	internal FacetType FacetType
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x600158C")]
		internal get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[Token(Token = "0x600158D")]
		internal set { } //Length: 4
	}

	[DefaultValue(False)]
	[Token(Token = "0x170005EF")]
	[XmlAttribute("fixed")]
	public override bool IsFixed
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x600158A")]
		 get { } //Length: 5
		[Address(RVA = "0x248EA30", Offset = "0x248DE30", Length = "0x9F")]
		[Token(Token = "0x600158B")]
		 set { } //Length: 159
	}

	[Token(Token = "0x170005EE")]
	[XmlAttribute("value")]
	public string Value
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001588")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6001589")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600158E")]
	protected XmlSchemaFacet() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x600158C")]
	internal FacetType get_FacetType() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x600158A")]
	public override bool get_IsFixed() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001588")]
	public string get_Value() { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[Token(Token = "0x600158D")]
	internal void set_FacetType(FacetType value) { }

	[Address(RVA = "0x248EA30", Offset = "0x248DE30", Length = "0x9F")]
	[Token(Token = "0x600158B")]
	public override void set_IsFixed(bool value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6001589")]
	public void set_Value(string value) { }

}

