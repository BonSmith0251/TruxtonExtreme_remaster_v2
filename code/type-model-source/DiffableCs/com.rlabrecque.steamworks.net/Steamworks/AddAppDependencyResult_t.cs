namespace Steamworks;

[CallbackIdentity(3414)]
[Token(Token = "0x20000D5")]
public struct AddAppDependencyResult_t
{
	[Token(Token = "0x400028A")]
	public const int k_iCallback = 3414; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400028B")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400028C")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400028D")]
	public AppId_t m_nAppID; //Field offset: 0x10

}

