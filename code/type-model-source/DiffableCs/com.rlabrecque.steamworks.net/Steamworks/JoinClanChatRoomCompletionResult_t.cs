namespace Steamworks;

[CallbackIdentity(342)]
[Token(Token = "0x200003C")]
public struct JoinClanChatRoomCompletionResult_t
{
	[Token(Token = "0x4000045")]
	public const int k_iCallback = 342; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000046")]
	public CSteamID m_steamIDClanChat; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000047")]
	public EChatRoomEnterResponse m_eChatRoomEnterResponse; //Field offset: 0x8

}

