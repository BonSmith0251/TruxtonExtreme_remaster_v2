namespace Steamworks;

[CallbackIdentity(1309)]
[Token(Token = "0x20000AE")]
public struct RemoteStoragePublishFileResult_t
{
	[Token(Token = "0x40001DA")]
	public const int k_iCallback = 1309; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DB")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001DC")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001DD")]
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; //Field offset: 0x10

}

