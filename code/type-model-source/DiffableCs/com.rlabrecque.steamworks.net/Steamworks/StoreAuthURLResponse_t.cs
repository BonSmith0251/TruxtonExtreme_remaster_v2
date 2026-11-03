namespace Steamworks;

[CallbackIdentity(165)]
[Token(Token = "0x20000E6")]
public struct StoreAuthURLResponse_t
{
	[Token(Token = "0x40002C2")]
	public const int k_iCallback = 165; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C3")]
	private Byte[] m_szURL_; //Field offset: 0x0

	[Token(Token = "0x17000016")]
	public string m_szURL
	{
		[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
		[Token(Token = "0x60008A1")]
		 get { } //Length: 125
		[Address(RVA = "0x6459E0", Offset = "0x644DE0", Length = "0xA8")]
		[Token(Token = "0x60008A2")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
	[Token(Token = "0x60008A1")]
	public string get_m_szURL() { }

	[Address(RVA = "0x6459E0", Offset = "0x644DE0", Length = "0xA8")]
	[Token(Token = "0x60008A2")]
	public void set_m_szURL(string value) { }

}

