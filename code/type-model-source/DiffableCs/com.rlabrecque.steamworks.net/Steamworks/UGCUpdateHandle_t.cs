namespace Steamworks;

[Token(Token = "0x20001F3")]
public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
{
	[Token(Token = "0x4000B6D")]
	public static readonly UGCUpdateHandle_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B6E")]
	public ulong m_UGCUpdateHandle; //Field offset: 0x0

	[Address(RVA = "0x6475B0", Offset = "0x6469B0", Length = "0x3A")]
	[Token(Token = "0x6000BE0")]
	private static UGCUpdateHandle_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000BD6")]
	public UGCUpdateHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000BDF")]
	public override int CompareTo(UGCUpdateHandle_t other) { }

	[Address(RVA = "0x647510", Offset = "0x646910", Length = "0x99")]
	[Token(Token = "0x6000BD8")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000BDE")]
	public override bool Equals(UGCUpdateHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000BD9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000BDA")]
	public static bool op_Equality(UGCUpdateHandle_t x, UGCUpdateHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BDC")]
	public static UGCUpdateHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BDD")]
	public static ulong op_Explicit(UGCUpdateHandle_t that) { }

	[Address(RVA = "0x6475F0", Offset = "0x6469F0", Length = "0x20B")]
	[Token(Token = "0x6000BDB")]
	public static bool op_Inequality(UGCUpdateHandle_t x, UGCUpdateHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000BD7")]
	public virtual string ToString() { }

}

