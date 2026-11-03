namespace Steamworks;

[CallbackIdentity(331)]
[Token(Token = "0x2000031")]
public struct GameOverlayActivated_t
{
	[Token(Token = "0x400001D")]
	public const int k_iCallback = 331; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001E")]
	public byte m_bActive; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400001F")]
	public bool m_bUserInitiated; //Field offset: 0x1
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000020")]
	public AppId_t m_nAppID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000021")]
	public uint m_dwOverlayPID; //Field offset: 0x8

}

