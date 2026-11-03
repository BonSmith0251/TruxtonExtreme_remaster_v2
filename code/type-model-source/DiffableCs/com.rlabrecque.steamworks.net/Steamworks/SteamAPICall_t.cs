namespace Steamworks;

[Token(Token = "0x20001F0")]
public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
{
	[Token(Token = "0x4000B66")]
	public static readonly SteamAPICall_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B67")]
	public ulong m_SteamAPICall; //Field offset: 0x0

	[Address(RVA = "0x646CB0", Offset = "0x6460B0", Length = "0x3A")]
	[Token(Token = "0x6000BC5")]
	private static SteamAPICall_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000BBB")]
	public SteamAPICall_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000BC4")]
	public override int CompareTo(SteamAPICall_t other) { }

	[Address(RVA = "0x646C10", Offset = "0x646010", Length = "0x99")]
	[Token(Token = "0x6000BBD")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000BC3")]
	public override bool Equals(SteamAPICall_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000BBE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000BBF")]
	public static bool op_Equality(SteamAPICall_t x, SteamAPICall_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BC1")]
	public static SteamAPICall_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BC2")]
	public static ulong op_Explicit(SteamAPICall_t that) { }

	[Address(RVA = "0x646CF0", Offset = "0x6460F0", Length = "0x52")]
	[Token(Token = "0x6000BC0")]
	public static bool op_Inequality(SteamAPICall_t x, SteamAPICall_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000BBC")]
	public virtual string ToString() { }

}

