namespace Steamworks;

[CallbackIdentity(3405)]
[Token(Token = "0x20000CC")]
public struct ItemInstalled_t
{
	[Token(Token = "0x4000267")]
	public const int k_iCallback = 3405; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000268")]
	public AppId_t m_unAppID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000269")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400026A")]
	public UGCHandle_t m_hLegacyContent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400026B")]
	public ulong m_unManifestID; //Field offset: 0x18

}

