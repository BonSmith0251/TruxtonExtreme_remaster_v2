namespace Steamworks;

[CallbackIdentity(1328)]
[Token(Token = "0x20000C0")]
public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
{
	[Token(Token = "0x400023B")]
	public const int k_iCallback = 1328; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400023C")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400023D")]
	public EWorkshopFileAction m_eAction; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400023E")]
	public int m_nResultsReturned; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400023F")]
	public int m_nTotalResultCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000240")]
	public PublishedFileId_t[] m_rgPublishedFileId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000241")]
	public UInt32[] m_rgRTimeUpdated; //Field offset: 0x18

}

