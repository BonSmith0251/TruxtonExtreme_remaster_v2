namespace Steamworks;

[CallbackIdentity(505)]
[Token(Token = "0x200007C")]
public struct LobbyDataUpdate_t
{
	[Token(Token = "0x4000149")]
	public const int k_iCallback = 505; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014A")]
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400014B")]
	public ulong m_ulSteamIDMember; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014C")]
	public byte m_bSuccess; //Field offset: 0x10

}

