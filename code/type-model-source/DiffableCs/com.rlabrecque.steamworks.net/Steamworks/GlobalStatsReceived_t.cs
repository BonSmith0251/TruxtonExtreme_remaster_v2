namespace Steamworks;

[CallbackIdentity(1112)]
[Token(Token = "0x20000F5")]
public struct GlobalStatsReceived_t
{
	[Token(Token = "0x4000303")]
	public const int k_iCallback = 1112; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000304")]
	public ulong m_nGameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000305")]
	public EResult m_eResult; //Field offset: 0x8

}

