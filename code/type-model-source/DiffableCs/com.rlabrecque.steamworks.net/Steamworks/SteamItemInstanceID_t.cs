namespace Steamworks;

[Token(Token = "0x20001D2")]
public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
{
	[Token(Token = "0x4000B02")]
	public static readonly SteamItemInstanceID_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B03")]
	public ulong m_SteamItemInstanceID; //Field offset: 0x0

	[Address(RVA = "0x63B450", Offset = "0x63A850", Length = "0x3A")]
	[Token(Token = "0x6000AB2")]
	private static SteamItemInstanceID_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000AA8")]
	public SteamItemInstanceID_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000AB1")]
	public override int CompareTo(SteamItemInstanceID_t other) { }

	[Address(RVA = "0x63B3B0", Offset = "0x63A7B0", Length = "0x99")]
	[Token(Token = "0x6000AAA")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000AB0")]
	public override bool Equals(SteamItemInstanceID_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000AAB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000AAC")]
	public static bool op_Equality(SteamItemInstanceID_t x, SteamItemInstanceID_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000AAE")]
	public static SteamItemInstanceID_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000AAF")]
	public static ulong op_Explicit(SteamItemInstanceID_t that) { }

	[Address(RVA = "0x63B490", Offset = "0x63A890", Length = "0x52")]
	[Token(Token = "0x6000AAD")]
	public static bool op_Inequality(SteamItemInstanceID_t x, SteamItemInstanceID_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000AA9")]
	public virtual string ToString() { }

}

