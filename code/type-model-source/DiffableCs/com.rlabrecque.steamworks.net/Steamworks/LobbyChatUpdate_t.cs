namespace Steamworks;

[CallbackIdentity(506)]
[Token(Token = "0x200007D")]
public struct LobbyChatUpdate_t
{
	[Token(Token = "0x400014D")]
	public const int k_iCallback = 506; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014E")]
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400014F")]
	public ulong m_ulSteamIDUserChanged; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000150")]
	public ulong m_ulSteamIDMakingChange; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000151")]
	public uint m_rgfChatMemberStateChange; //Field offset: 0x18

}

