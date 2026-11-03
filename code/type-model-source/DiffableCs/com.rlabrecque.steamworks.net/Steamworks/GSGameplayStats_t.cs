namespace Steamworks;

[CallbackIdentity(207)]
[Token(Token = "0x200004D")]
public struct GSGameplayStats_t
{
	[Token(Token = "0x400007C")]
	public const int k_iCallback = 207; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007D")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400007E")]
	public int m_nRank; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007F")]
	public uint m_unTotalConnects; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000080")]
	public uint m_unTotalMinutesPlayed; //Field offset: 0xC

}

