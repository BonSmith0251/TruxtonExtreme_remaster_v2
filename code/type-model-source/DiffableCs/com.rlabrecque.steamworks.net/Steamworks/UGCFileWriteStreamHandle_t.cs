namespace Steamworks;

[Token(Token = "0x20001E8")]
public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
{
	[Token(Token = "0x4000B57")]
	public static readonly UGCFileWriteStreamHandle_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B58")]
	public ulong m_UGCFileWriteStreamHandle; //Field offset: 0x0

	[Address(RVA = "0x645B30", Offset = "0x644F30", Length = "0x3A")]
	[Token(Token = "0x6000B6E")]
	private static UGCFileWriteStreamHandle_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000B64")]
	public UGCFileWriteStreamHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000B6D")]
	public override int CompareTo(UGCFileWriteStreamHandle_t other) { }

	[Address(RVA = "0x645A90", Offset = "0x644E90", Length = "0x99")]
	[Token(Token = "0x6000B66")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000B6C")]
	public override bool Equals(UGCFileWriteStreamHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000B67")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000B68")]
	public static bool op_Equality(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B6A")]
	public static UGCFileWriteStreamHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B6B")]
	public static ulong op_Explicit(UGCFileWriteStreamHandle_t that) { }

	[Address(RVA = "0x645B70", Offset = "0x644F70", Length = "0x52")]
	[Token(Token = "0x6000B69")]
	public static bool op_Inequality(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000B65")]
	public virtual string ToString() { }

}

