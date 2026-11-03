namespace Steamworks;

[CallbackIdentity(2301)]
[Token(Token = "0x20000C6")]
public struct ScreenshotReady_t
{
	[Token(Token = "0x4000251")]
	public const int k_iCallback = 2301; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000252")]
	public ScreenshotHandle m_hLocal; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000253")]
	public EResult m_eResult; //Field offset: 0x4

}

