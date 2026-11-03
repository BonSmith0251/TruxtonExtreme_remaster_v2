namespace System.Xml.Serialization;

[Token(Token = "0x200013C")]
internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40006CC")]
	private int _flatArrayIndex; //Field offset: 0x78

	[Token(Token = "0x1700038B")]
	public int FlatArrayIndex
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x6000E02")]
		 get { } //Length: 4
		[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
		[Token(Token = "0x6000E03")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x25921A0", Offset = "0x25915A0", Length = "0x7")]
	[Token(Token = "0x6000E04")]
	public XmlTypeMapMemberExpandable() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x6000E02")]
	public int get_FlatArrayIndex() { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[Token(Token = "0x6000E03")]
	public void set_FlatArrayIndex(int value) { }

}

