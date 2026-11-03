namespace Steamworks;

[CallbackIdentity(3415)]
[Token(Token = "0x20000D6")]
public struct RemoveAppDependencyResult_t
{
	[Token(Token = "0x400028E")]
	public const int k_iCallback = 3415; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400028F")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000290")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000291")]
	public AppId_t m_nAppID; //Field offset: 0x10

}

