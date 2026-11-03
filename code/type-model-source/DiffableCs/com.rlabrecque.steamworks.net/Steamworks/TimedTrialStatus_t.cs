namespace Steamworks;

[CallbackIdentity(1030)]
[Token(Token = "0x200002F")]
public struct TimedTrialStatus_t
{
	[Token(Token = "0x4000015")]
	public const int k_iCallback = 1030; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000016")]
	public AppId_t m_unAppID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000017")]
	public bool m_bIsOffline; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000018")]
	public uint m_unSecondsAllowed; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000019")]
	public uint m_unSecondsPlayed; //Field offset: 0xC

}

