namespace Steamworks;

[CallbackIdentity(1311)]
[Token(Token = "0x20000AF")]
public struct RemoteStorageDeletePublishedFileResult_t
{
	[Token(Token = "0x40001DE")]
	public const int k_iCallback = 1311; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DF")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001E0")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8

}

