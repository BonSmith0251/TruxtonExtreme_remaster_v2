namespace Steamworks;

[Token(Token = "0x20001D0")]
public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
{
	[Token(Token = "0x4000AFF")]
	public static readonly SteamInventoryUpdateHandle_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B00")]
	public ulong m_SteamInventoryUpdateHandle; //Field offset: 0x0

	[Address(RVA = "0x63B290", Offset = "0x63A690", Length = "0x3A")]
	[Token(Token = "0x6000A9D")]
	private static SteamInventoryUpdateHandle_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000A93")]
	public SteamInventoryUpdateHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000A9C")]
	public override int CompareTo(SteamInventoryUpdateHandle_t other) { }

	[Address(RVA = "0x63B1F0", Offset = "0x63A5F0", Length = "0x99")]
	[Token(Token = "0x6000A95")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000A9B")]
	public override bool Equals(SteamInventoryUpdateHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000A96")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000A97")]
	public static bool op_Equality(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A99")]
	public static SteamInventoryUpdateHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000A9A")]
	public static ulong op_Explicit(SteamInventoryUpdateHandle_t that) { }

	[Address(RVA = "0x63B2D0", Offset = "0x63A6D0", Length = "0x52")]
	[Token(Token = "0x6000A98")]
	public static bool op_Inequality(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000A94")]
	public virtual string ToString() { }

}

