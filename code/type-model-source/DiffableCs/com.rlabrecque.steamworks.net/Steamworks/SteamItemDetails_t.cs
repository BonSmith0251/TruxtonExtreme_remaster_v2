namespace Steamworks;

[Token(Token = "0x2000176")]
public struct SteamItemDetails_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F6")]
	public SteamItemInstanceID_t m_itemId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009F7")]
	public SteamItemDef_t m_iDefinition; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009F8")]
	public ushort m_unQuantity; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x40009F9")]
	public ushort m_unFlags; //Field offset: 0xE

}

