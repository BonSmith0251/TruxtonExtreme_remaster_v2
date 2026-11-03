namespace Steamworks;

[CallbackIdentity(1327)]
[Token(Token = "0x20000BF")]
public struct RemoteStorageSetUserPublishedFileActionResult_t
{
	[Token(Token = "0x4000237")]
	public const int k_iCallback = 1327; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000238")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000239")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400023A")]
	public EWorkshopFileAction m_eAction; //Field offset: 0x10

}

