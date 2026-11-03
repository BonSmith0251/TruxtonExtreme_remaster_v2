namespace Steamworks;

[CallbackIdentity(4611)]
[Token(Token = "0x20000FF")]
public struct GetVideoURLResult_t
{
	[Token(Token = "0x4000318")]
	public const int k_iCallback = 4611; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000319")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400031A")]
	public AppId_t m_unVideoAppID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400031B")]
	private Byte[] m_rgchURL_; //Field offset: 0x8

	[Token(Token = "0x17000019")]
	public string m_rgchURL
	{
		[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
		[Token(Token = "0x60008A7")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x60008A8")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
	[Token(Token = "0x60008A7")]
	public string get_m_rgchURL() { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x60008A8")]
	public void set_m_rgchURL(string value) { }

}

