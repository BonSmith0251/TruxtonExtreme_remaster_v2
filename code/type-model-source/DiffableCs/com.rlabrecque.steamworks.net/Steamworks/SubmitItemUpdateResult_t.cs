namespace Steamworks;

[CallbackIdentity(3404)]
[Token(Token = "0x20000CB")]
public struct SubmitItemUpdateResult_t
{
	[Token(Token = "0x4000263")]
	public const int k_iCallback = 3404; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000264")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000265")]
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000266")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8

}

