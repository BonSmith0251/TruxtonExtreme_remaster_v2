namespace Steamworks;

[CallbackIdentity(164)]
[Token(Token = "0x20000E5")]
public struct GameWebCallback_t
{
	[Token(Token = "0x40002C0")]
	public const int k_iCallback = 164; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C1")]
	private Byte[] m_szURL_; //Field offset: 0x0

	[Token(Token = "0x17000015")]
	public string m_szURL
	{
		[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
		[Token(Token = "0x600089F")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x60008A0")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
	[Token(Token = "0x600089F")]
	public string get_m_szURL() { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x60008A0")]
	public void set_m_szURL(string value) { }

}

