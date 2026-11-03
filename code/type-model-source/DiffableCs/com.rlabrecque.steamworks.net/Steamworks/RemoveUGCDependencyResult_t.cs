namespace Steamworks;

[CallbackIdentity(3413)]
[Token(Token = "0x20000D4")]
public struct RemoveUGCDependencyResult_t
{
	[Token(Token = "0x4000286")]
	public const int k_iCallback = 3413; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000287")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000288")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000289")]
	public PublishedFileId_t m_nChildPublishedFileId; //Field offset: 0x10

}

