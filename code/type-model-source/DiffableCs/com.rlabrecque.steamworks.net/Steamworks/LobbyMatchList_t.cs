namespace Steamworks;

[CallbackIdentity(510)]
[Token(Token = "0x2000080")]
public struct LobbyMatchList_t
{
	[Token(Token = "0x400015C")]
	public const int k_iCallback = 510; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015D")]
	public uint m_nLobbiesMatching; //Field offset: 0x0

}

