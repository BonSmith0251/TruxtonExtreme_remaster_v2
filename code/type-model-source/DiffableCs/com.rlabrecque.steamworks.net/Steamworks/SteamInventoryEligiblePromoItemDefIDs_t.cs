namespace Steamworks;

[CallbackIdentity(4703)]
[Token(Token = "0x2000076")]
public struct SteamInventoryEligiblePromoItemDefIDs_t
{
	[Token(Token = "0x400012C")]
	public const int k_iCallback = 4703; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400012D")]
	public EResult m_result; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400012E")]
	public CSteamID m_steamID; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400012F")]
	public int m_numEligiblePromoItemDefs; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000130")]
	public bool m_bCachedData; //Field offset: 0x10

}

