namespace TMPro;

[Token(Token = "0x20000AF")]
internal struct CharacterElement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000660")]
	private uint m_Unicode; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000661")]
	private TMP_TextElement m_TextElement; //Field offset: 0x8

	[Token(Token = "0x17000194")]
	public uint Unicode
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60006A9")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60006AA")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x2F03E40", Offset = "0x2F03240", Length = "0x24")]
	[Token(Token = "0x60006AB")]
	public CharacterElement(TMP_TextElement textElement) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60006A9")]
	public uint get_Unicode() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60006AA")]
	public void set_Unicode(uint value) { }

}

