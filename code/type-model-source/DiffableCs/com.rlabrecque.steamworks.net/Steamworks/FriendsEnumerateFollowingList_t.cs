namespace Steamworks;

[CallbackIdentity(346)]
[Token(Token = "0x2000040")]
public struct FriendsEnumerateFollowingList_t
{
	[Token(Token = "0x4000053")]
	public const int k_iCallback = 346; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000054")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000055")]
	public CSteamID[] m_rgSteamID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000056")]
	public int m_nResultsReturned; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000057")]
	public int m_nTotalResultCount; //Field offset: 0x14

}

