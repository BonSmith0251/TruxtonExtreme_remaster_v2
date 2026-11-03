namespace Steamworks;

[CallbackIdentity(3412)]
[Token(Token = "0x20000D3")]
public struct AddUGCDependencyResult_t
{
	[Token(Token = "0x4000282")]
	public const int k_iCallback = 3412; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000283")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000284")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000285")]
	public PublishedFileId_t m_nChildPublishedFileId; //Field offset: 0x10

}

