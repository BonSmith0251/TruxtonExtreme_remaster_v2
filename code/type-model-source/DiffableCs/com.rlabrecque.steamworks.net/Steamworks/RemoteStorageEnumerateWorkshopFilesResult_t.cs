namespace Steamworks;

[CallbackIdentity(1319)]
[Token(Token = "0x20000B7")]
public struct RemoteStorageEnumerateWorkshopFilesResult_t
{
	[Token(Token = "0x4000213")]
	public const int k_iCallback = 1319; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000214")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000215")]
	public int m_nResultsReturned; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000216")]
	public int m_nTotalResultCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000217")]
	public PublishedFileId_t[] m_rgPublishedFileId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000218")]
	public Single[] m_rgScore; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000219")]
	public AppId_t m_nAppId; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400021A")]
	public uint m_unStartIndex; //Field offset: 0x24

}

