namespace Steamworks;

[CallbackIdentity(1313)]
[Token(Token = "0x20000B1")]
public struct RemoteStorageSubscribePublishedFileResult_t
{
	[Token(Token = "0x40001E6")]
	public const int k_iCallback = 1313; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E7")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001E8")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8

}

