namespace Steamworks;

[CallbackIdentity(507)]
[Token(Token = "0x200007E")]
public struct LobbyChatMsg_t
{
	[Token(Token = "0x4000152")]
	public const int k_iCallback = 507; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000153")]
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000154")]
	public ulong m_ulSteamIDUser; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000155")]
	public byte m_eChatEntryType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000156")]
	public uint m_iChatID; //Field offset: 0x14

}

