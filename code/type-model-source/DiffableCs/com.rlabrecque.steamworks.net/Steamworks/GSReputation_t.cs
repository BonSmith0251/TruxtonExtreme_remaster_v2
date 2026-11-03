namespace Steamworks;

[CallbackIdentity(209)]
[Token(Token = "0x200004F")]
public struct GSReputation_t
{
	[Token(Token = "0x4000086")]
	public const int k_iCallback = 209; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000087")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000088")]
	public uint m_unReputationScore; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000089")]
	public bool m_bBanned; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400008A")]
	public uint m_unBannedIP; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008B")]
	public ushort m_usBannedPort; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008C")]
	public ulong m_ulBannedGameID; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008D")]
	public uint m_unBanExpires; //Field offset: 0x20

}

