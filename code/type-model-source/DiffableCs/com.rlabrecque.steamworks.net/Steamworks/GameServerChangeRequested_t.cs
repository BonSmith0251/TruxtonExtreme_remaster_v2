namespace Steamworks;

[CallbackIdentity(332)]
[Token(Token = "0x2000032")]
public struct GameServerChangeRequested_t
{
	[Token(Token = "0x4000022")]
	public const int k_iCallback = 332; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000023")]
	private Byte[] m_rgchServer_; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000024")]
	private Byte[] m_rgchPassword_; //Field offset: 0x8

	[Token(Token = "0x17000003")]
	public string m_rgchPassword
	{
		[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
		[Token(Token = "0x600087B")]
		 get { } //Length: 125
		[Address(RVA = "0x60A640", Offset = "0x609A40", Length = "0xA8")]
		[Token(Token = "0x600087C")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000002")]
	public string m_rgchServer
	{
		[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
		[Token(Token = "0x6000879")]
		 get { } //Length: 125
		[Address(RVA = "0x60A640", Offset = "0x609A40", Length = "0xA8")]
		[Token(Token = "0x600087A")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
	[Token(Token = "0x600087B")]
	public string get_m_rgchPassword() { }

	[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
	[Token(Token = "0x6000879")]
	public string get_m_rgchServer() { }

	[Address(RVA = "0x60A640", Offset = "0x609A40", Length = "0xA8")]
	[Token(Token = "0x600087C")]
	public void set_m_rgchPassword(string value) { }

	[Address(RVA = "0x60A640", Offset = "0x609A40", Length = "0xA8")]
	[Token(Token = "0x600087A")]
	public void set_m_rgchServer(string value) { }

}

