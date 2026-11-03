namespace Steamworks;

[CallbackIdentity(3402)]
[Token(Token = "0x20000C9")]
public struct SteamUGCRequestUGCDetailsResult_t
{
	[Token(Token = "0x400025C")]
	public const int k_iCallback = 3402; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400025D")]
	public SteamUGCDetails_t m_details; //Field offset: 0x0
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400025E")]
	public bool m_bCachedData; //Field offset: 0x90

}

