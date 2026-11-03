namespace Steamworks;

[CallbackIdentity(1316)]
[Token(Token = "0x20000B4")]
public struct RemoteStorageUpdatePublishedFileResult_t
{
	[Token(Token = "0x40001F2")]
	public const int k_iCallback = 1316; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001F3")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001F4")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F5")]
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; //Field offset: 0x10

}

