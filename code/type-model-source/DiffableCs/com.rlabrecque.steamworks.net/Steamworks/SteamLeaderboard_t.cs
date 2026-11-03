namespace Steamworks;

[Token(Token = "0x20001F5")]
public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B70")]
	public ulong m_SteamLeaderboard; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000BEB")]
	public SteamLeaderboard_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000BF4")]
	public override int CompareTo(SteamLeaderboard_t other) { }

	[Address(RVA = "0x647340", Offset = "0x646740", Length = "0x81")]
	[Token(Token = "0x6000BED")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000BF3")]
	public override bool Equals(SteamLeaderboard_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000BEE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000BEF")]
	public static bool op_Equality(SteamLeaderboard_t x, SteamLeaderboard_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BF1")]
	public static SteamLeaderboard_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BF2")]
	public static ulong op_Explicit(SteamLeaderboard_t that) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000BF0")]
	public static bool op_Inequality(SteamLeaderboard_t x, SteamLeaderboard_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000BEC")]
	public virtual string ToString() { }

}

