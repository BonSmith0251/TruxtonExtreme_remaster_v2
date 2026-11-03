namespace Steamworks;

[CallbackIdentity(1325)]
[Token(Token = "0x20000BD")]
public struct RemoteStorageUserVoteDetails_t
{
	[Token(Token = "0x400022E")]
	public const int k_iCallback = 1325; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400022F")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000230")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000231")]
	public EWorkshopVote m_eVote; //Field offset: 0x10

}

