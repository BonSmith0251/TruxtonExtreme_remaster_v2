namespace Steamworks;

[CallbackIdentity(1314)]
[Token(Token = "0x20000B2")]
public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
{
	[Token(Token = "0x40001E9")]
	public const int k_iCallback = 1314; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001EA")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001EB")]
	public int m_nResultsReturned; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001EC")]
	public int m_nTotalResultCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001ED")]
	public PublishedFileId_t[] m_rgPublishedFileId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001EE")]
	public UInt32[] m_rgRTimeSubscribed; //Field offset: 0x18

}

