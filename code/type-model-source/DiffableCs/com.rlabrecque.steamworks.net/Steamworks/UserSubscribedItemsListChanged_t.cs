namespace Steamworks;

[CallbackIdentity(3418)]
[Token(Token = "0x20000D9")]
public struct UserSubscribedItemsListChanged_t
{
	[Token(Token = "0x400029B")]
	public const int k_iCallback = 3418; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400029C")]
	public AppId_t m_nAppID; //Field offset: 0x0

}

