namespace Steamworks;

[Token(Token = "0x20001F4")]
public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B6F")]
	public ulong m_SteamLeaderboardEntries; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000BE1")]
	public SteamLeaderboardEntries_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000BEA")]
	public override int CompareTo(SteamLeaderboardEntries_t other) { }

	[Address(RVA = "0x6472B0", Offset = "0x6466B0", Length = "0x81")]
	[Token(Token = "0x6000BE3")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000BE9")]
	public override bool Equals(SteamLeaderboardEntries_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000BE4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000BE5")]
	public static bool op_Equality(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BE7")]
	public static SteamLeaderboardEntries_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BE8")]
	public static ulong op_Explicit(SteamLeaderboardEntries_t that) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000BE6")]
	public static bool op_Inequality(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000BE2")]
	public virtual string ToString() { }

}

