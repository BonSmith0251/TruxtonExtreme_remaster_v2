namespace Steamworks;

[CallbackIdentity(3407)]
[Token(Token = "0x20000CE")]
public struct UserFavoriteItemsListChanged_t
{
	[Token(Token = "0x4000270")]
	public const int k_iCallback = 3407; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000271")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000272")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000273")]
	public bool m_bWasAddRequest; //Field offset: 0xC

}

