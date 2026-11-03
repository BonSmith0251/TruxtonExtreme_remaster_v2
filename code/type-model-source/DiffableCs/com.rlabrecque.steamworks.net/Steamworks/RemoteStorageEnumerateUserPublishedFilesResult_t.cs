namespace Steamworks;

[CallbackIdentity(1312)]
[Token(Token = "0x20000B0")]
public struct RemoteStorageEnumerateUserPublishedFilesResult_t
{
	[Token(Token = "0x40001E1")]
	public const int k_iCallback = 1312; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E2")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001E3")]
	public int m_nResultsReturned; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001E4")]
	public int m_nTotalResultCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E5")]
	public PublishedFileId_t[] m_rgPublishedFileId; //Field offset: 0x10

}

