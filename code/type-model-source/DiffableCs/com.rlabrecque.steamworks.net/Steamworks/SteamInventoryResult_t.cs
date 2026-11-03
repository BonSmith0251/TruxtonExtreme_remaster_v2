namespace Steamworks;

[Token(Token = "0x20001CF")]
public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
{
	[Token(Token = "0x4000AFD")]
	public static readonly SteamInventoryResult_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AFE")]
	public int m_SteamInventoryResult; //Field offset: 0x0

	[Address(RVA = "0x63B160", Offset = "0x63A560", Length = "0x39")]
	[Token(Token = "0x6000A92")]
	private static SteamInventoryResult_t() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000A88")]
	public SteamInventoryResult_t(int value) { }

	[Address(RVA = "0x60B4B0", Offset = "0x60A8B0", Length = "0x8")]
	[Token(Token = "0x6000A91")]
	public override int CompareTo(SteamInventoryResult_t other) { }

	[Address(RVA = "0x63B0C0", Offset = "0x63A4C0", Length = "0x97")]
	[Token(Token = "0x6000A8A")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000A90")]
	public override bool Equals(SteamInventoryResult_t other) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x6000A8B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000A8C")]
	public static bool op_Equality(SteamInventoryResult_t x, SteamInventoryResult_t y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A8E")]
	public static SteamInventoryResult_t op_Explicit(int value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000A8F")]
	public static int op_Explicit(SteamInventoryResult_t that) { }

	[Address(RVA = "0x63B1A0", Offset = "0x63A5A0", Length = "0x4F")]
	[Token(Token = "0x6000A8D")]
	public static bool op_Inequality(SteamInventoryResult_t x, SteamInventoryResult_t y) { }

	[Address(RVA = "0x60B560", Offset = "0x60A960", Length = "0x7")]
	[Token(Token = "0x6000A89")]
	public virtual string ToString() { }

}

