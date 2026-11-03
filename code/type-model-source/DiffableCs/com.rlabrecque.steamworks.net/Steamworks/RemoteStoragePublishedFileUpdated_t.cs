namespace Steamworks;

[CallbackIdentity(1330)]
[Token(Token = "0x20000C2")]
public struct RemoteStoragePublishedFileUpdated_t
{
	[Token(Token = "0x4000245")]
	public const int k_iCallback = 1330; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000246")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000247")]
	public AppId_t m_nAppID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000248")]
	public ulong m_ulUnused; //Field offset: 0x10

}

