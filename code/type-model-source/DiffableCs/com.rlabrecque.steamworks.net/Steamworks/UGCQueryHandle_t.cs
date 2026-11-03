namespace Steamworks;

[Token(Token = "0x20001F2")]
public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
{
	[Token(Token = "0x4000B6B")]
	public static readonly UGCQueryHandle_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B6C")]
	public ulong m_UGCQueryHandle; //Field offset: 0x0

	[Address(RVA = "0x647470", Offset = "0x646870", Length = "0x3A")]
	[Token(Token = "0x6000BD5")]
	private static UGCQueryHandle_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000BCB")]
	public UGCQueryHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000BD4")]
	public override int CompareTo(UGCQueryHandle_t other) { }

	[Address(RVA = "0x6473D0", Offset = "0x6467D0", Length = "0x99")]
	[Token(Token = "0x6000BCD")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000BD3")]
	public override bool Equals(UGCQueryHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000BCE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000BCF")]
	public static bool op_Equality(UGCQueryHandle_t x, UGCQueryHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BD1")]
	public static UGCQueryHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BD2")]
	public static ulong op_Explicit(UGCQueryHandle_t that) { }

	[Address(RVA = "0x6474B0", Offset = "0x6468B0", Length = "0x52")]
	[Token(Token = "0x6000BD0")]
	public static bool op_Inequality(UGCQueryHandle_t x, UGCQueryHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000BCC")]
	public virtual string ToString() { }

}

