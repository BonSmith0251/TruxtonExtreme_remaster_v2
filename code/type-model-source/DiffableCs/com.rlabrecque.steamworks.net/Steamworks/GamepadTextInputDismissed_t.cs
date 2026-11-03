namespace Steamworks;

[CallbackIdentity(714)]
[Token(Token = "0x20000FB")]
public struct GamepadTextInputDismissed_t
{
	[Token(Token = "0x4000310")]
	public const int k_iCallback = 714; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000311")]
	public bool m_bSubmitted; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000312")]
	public uint m_unSubmittedText; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000313")]
	public AppId_t m_unAppID; //Field offset: 0x8

}

