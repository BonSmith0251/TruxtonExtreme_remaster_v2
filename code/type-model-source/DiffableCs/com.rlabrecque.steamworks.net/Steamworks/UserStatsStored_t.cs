namespace Steamworks;

[CallbackIdentity(1102)]
[Token(Token = "0x20000EB")]
public struct UserStatsStored_t
{
	[Token(Token = "0x40002DC")]
	public const int k_iCallback = 1102; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002DD")]
	public ulong m_nGameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002DE")]
	public EResult m_eResult; //Field offset: 0x8

}

