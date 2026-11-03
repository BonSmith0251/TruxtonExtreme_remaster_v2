namespace System.Xml.Serialization;

[Token(Token = "0x200013D")]
internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40006CD")]
	private ListMap _listMap; //Field offset: 0x80

	[Token(Token = "0x1700038C")]
	public ListMap ListMap
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000E05")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x6000E06")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x25921A0", Offset = "0x25915A0", Length = "0x7")]
	[Token(Token = "0x6000E07")]
	public XmlTypeMapMemberFlatList() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000E05")]
	public ListMap get_ListMap() { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x6000E06")]
	public void set_ListMap(ListMap value) { }

}

