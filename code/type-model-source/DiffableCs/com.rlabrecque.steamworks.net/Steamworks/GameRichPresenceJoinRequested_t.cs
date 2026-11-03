namespace Steamworks;

[CallbackIdentity(337)]
[Token(Token = "0x2000037")]
public struct GameRichPresenceJoinRequested_t
{
	[Token(Token = "0x4000034")]
	public const int k_iCallback = 337; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000035")]
	public CSteamID m_steamIDFriend; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000036")]
	private Byte[] m_rgchConnect_; //Field offset: 0x8

	[Token(Token = "0x17000004")]
	public string m_rgchConnect
	{
		[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
		[Token(Token = "0x600087D")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x600087E")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A3E0", Offset = "0x6097E0", Length = "0x7D")]
	[Token(Token = "0x600087D")]
	public string get_m_rgchConnect() { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x600087E")]
	public void set_m_rgchConnect(string value) { }

}

