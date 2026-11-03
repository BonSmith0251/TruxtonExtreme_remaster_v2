namespace System.Xml.Serialization;

[Token(Token = "0x2000144")]
internal class ListMap : ObjectMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006EA")]
	private XmlTypeMapElementInfoList _itemInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006EB")]
	private string _choiceMember; //Field offset: 0x18

	[Token(Token = "0x170003A6")]
	public string ChoiceMember
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000E37")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170003A7")]
	public XmlTypeMapElementInfoList ItemInfo
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E38")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000E39")]
		 set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000E40")]
	public ListMap() { }

	[Address(RVA = "0x2584050", Offset = "0x2583450", Length = "0x190")]
	[Token(Token = "0x6000E3E")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x25841F0", Offset = "0x25835F0", Length = "0x5DA")]
	[Token(Token = "0x6000E3A")]
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	[Address(RVA = "0x25847D0", Offset = "0x2583BD0", Length = "0x1DA")]
	[Token(Token = "0x6000E3B")]
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	[Address(RVA = "0x25849B0", Offset = "0x2583DB0", Length = "0x1DA")]
	[Token(Token = "0x6000E3C")]
	public XmlTypeMapElementInfo FindTextElement() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000E38")]
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	[Address(RVA = "0x2584B90", Offset = "0x2583F90", Length = "0x21D")]
	[Token(Token = "0x6000E3D")]
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x6000E3F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000E37")]
	public void set_ChoiceMember(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000E39")]
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

}

