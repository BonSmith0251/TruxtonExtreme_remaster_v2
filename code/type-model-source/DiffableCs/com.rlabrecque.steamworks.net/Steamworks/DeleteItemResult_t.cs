namespace Steamworks;

[CallbackIdentity(3417)]
[Token(Token = "0x20000D8")]
public struct DeleteItemResult_t
{
	[Token(Token = "0x4000298")]
	public const int k_iCallback = 3417; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000299")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400029A")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8

}

