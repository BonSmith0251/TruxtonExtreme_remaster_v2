namespace Steamworks;

[CallbackIdentity(1005)]
[Token(Token = "0x200002B")]
public struct DlcInstalled_t
{
	[Token(Token = "0x4000008")]
	public const int k_iCallback = 1005; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000009")]
	public AppId_t m_nAppID; //Field offset: 0x0

}

