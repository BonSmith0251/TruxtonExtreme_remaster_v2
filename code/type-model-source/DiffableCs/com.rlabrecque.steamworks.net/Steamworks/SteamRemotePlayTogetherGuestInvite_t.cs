namespace Steamworks;

[CallbackIdentity(5703)]
[Token(Token = "0x20000AC")]
public struct SteamRemotePlayTogetherGuestInvite_t
{
	[Token(Token = "0x40001D4")]
	public const int k_iCallback = 5703; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D5")]
	private Byte[] m_szConnectURL_; //Field offset: 0x0

	[Token(Token = "0x1700000C")]
	public string m_szConnectURL
	{
		[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
		[Token(Token = "0x600088D")]
		 get { } //Length: 125
		[Address(RVA = "0x638F90", Offset = "0x638390", Length = "0xA8")]
		[Token(Token = "0x600088E")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
	[Token(Token = "0x600088D")]
	public string get_m_szConnectURL() { }

	[Address(RVA = "0x638F90", Offset = "0x638390", Length = "0xA8")]
	[Token(Token = "0x600088E")]
	public void set_m_szConnectURL(string value) { }

}

