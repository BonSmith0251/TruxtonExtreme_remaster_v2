namespace Steamworks;

[CallbackIdentity(509)]
[Token(Token = "0x200007F")]
public struct LobbyGameCreated_t
{
	[Token(Token = "0x4000157")]
	public const int k_iCallback = 509; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000158")]
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000159")]
	public ulong m_ulSteamIDGameServer; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015A")]
	public uint m_unIP; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400015B")]
	public ushort m_usPort; //Field offset: 0x14

}

