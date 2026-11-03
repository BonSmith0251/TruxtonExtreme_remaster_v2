namespace Steamworks;

[CallbackIdentity(3403)]
[Token(Token = "0x20000CA")]
public struct CreateItemResult_t
{
	[Token(Token = "0x400025F")]
	public const int k_iCallback = 3403; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000260")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000261")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000262")]
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; //Field offset: 0x10

}

