namespace Steamworks;

[CallbackIdentity(1222)]
[Token(Token = "0x20000A7")]
public struct SteamNetAuthenticationStatus_t
{
	[Token(Token = "0x40001C6")]
	public const int k_iCallback = 1222; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C7")]
	public ESteamNetworkingAvailability m_eAvail; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001C8")]
	private Byte[] m_debugMsg_; //Field offset: 0x8

	[Token(Token = "0x1700000A")]
	public string m_debugMsg
	{
		[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
		[Token(Token = "0x6000889")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x600088A")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
	[Token(Token = "0x6000889")]
	public string get_m_debugMsg() { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x600088A")]
	public void set_m_debugMsg(string value) { }

}

