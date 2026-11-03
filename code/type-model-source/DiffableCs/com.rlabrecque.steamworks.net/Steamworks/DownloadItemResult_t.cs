namespace Steamworks;

[CallbackIdentity(3406)]
[Token(Token = "0x20000CD")]
public struct DownloadItemResult_t
{
	[Token(Token = "0x400026C")]
	public const int k_iCallback = 3406; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400026D")]
	public AppId_t m_unAppID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400026E")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400026F")]
	public EResult m_eResult; //Field offset: 0x10

}

