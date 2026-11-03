namespace Steamworks;

[Token(Token = "0x20001E9")]
public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
{
	[Token(Token = "0x4000B59")]
	public static readonly UGCHandle_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B5A")]
	public ulong m_UGCHandle; //Field offset: 0x0

	[Address(RVA = "0x645C70", Offset = "0x645070", Length = "0x3A")]
	[Token(Token = "0x6000B79")]
	private static UGCHandle_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000B6F")]
	public UGCHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000B78")]
	public override int CompareTo(UGCHandle_t other) { }

	[Address(RVA = "0x645BD0", Offset = "0x644FD0", Length = "0x99")]
	[Token(Token = "0x6000B71")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000B77")]
	public override bool Equals(UGCHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000B72")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000B73")]
	public static bool op_Equality(UGCHandle_t x, UGCHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B75")]
	public static UGCHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B76")]
	public static ulong op_Explicit(UGCHandle_t that) { }

	[Address(RVA = "0x645CB0", Offset = "0x6450B0", Length = "0x52")]
	[Token(Token = "0x6000B74")]
	public static bool op_Inequality(UGCHandle_t x, UGCHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000B70")]
	public virtual string ToString() { }

}

