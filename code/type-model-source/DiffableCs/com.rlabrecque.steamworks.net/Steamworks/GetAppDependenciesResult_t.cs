namespace Steamworks;

[CallbackIdentity(3416)]
[Token(Token = "0x20000D7")]
public struct GetAppDependenciesResult_t
{
	[Token(Token = "0x4000292")]
	public const int k_iCallback = 3416; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000293")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000294")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000295")]
	public AppId_t[] m_rgAppIDs; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000296")]
	public uint m_nNumAppDependencies; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000297")]
	public uint m_nTotalNumAppDependencies; //Field offset: 0x1C

}

