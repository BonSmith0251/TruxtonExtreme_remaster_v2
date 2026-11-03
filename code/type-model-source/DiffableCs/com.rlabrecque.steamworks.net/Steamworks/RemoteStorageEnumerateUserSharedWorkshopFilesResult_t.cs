namespace Steamworks;

[CallbackIdentity(1326)]
[Token(Token = "0x20000BE")]
public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
{
	[Token(Token = "0x4000232")]
	public const int k_iCallback = 1326; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000233")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000234")]
	public int m_nResultsReturned; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000235")]
	public int m_nTotalResultCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000236")]
	public PublishedFileId_t[] m_rgPublishedFileId; //Field offset: 0x10

}

