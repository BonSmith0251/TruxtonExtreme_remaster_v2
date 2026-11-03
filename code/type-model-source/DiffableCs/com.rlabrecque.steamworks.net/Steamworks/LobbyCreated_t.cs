namespace Steamworks;

[CallbackIdentity(513)]
[Token(Token = "0x2000082")]
public struct LobbyCreated_t
{
	[Token(Token = "0x4000162")]
	public const int k_iCallback = 513; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000163")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000164")]
	public ulong m_ulSteamIDLobby; //Field offset: 0x8

}

