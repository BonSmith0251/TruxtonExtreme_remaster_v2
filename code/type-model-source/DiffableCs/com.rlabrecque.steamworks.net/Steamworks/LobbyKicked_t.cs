namespace Steamworks;

[CallbackIdentity(512)]
[Token(Token = "0x2000081")]
public struct LobbyKicked_t
{
	[Token(Token = "0x400015E")]
	public const int k_iCallback = 512; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015F")]
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000160")]
	public ulong m_ulSteamIDAdmin; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000161")]
	public byte m_bKickedDueToDisconnect; //Field offset: 0x10

}

