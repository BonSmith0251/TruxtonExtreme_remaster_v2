namespace Steamworks;

[Token(Token = "0x20001E7")]
public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
{
	[Token(Token = "0x4000B55")]
	public static readonly PublishedFileUpdateHandle_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B56")]
	public ulong m_PublishedFileUpdateHandle; //Field offset: 0x0

	[Address(RVA = "0x639510", Offset = "0x638910", Length = "0x3A")]
	[Token(Token = "0x6000B63")]
	private static PublishedFileUpdateHandle_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000B59")]
	public PublishedFileUpdateHandle_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000B62")]
	public override int CompareTo(PublishedFileUpdateHandle_t other) { }

	[Address(RVA = "0x639470", Offset = "0x638870", Length = "0x99")]
	[Token(Token = "0x6000B5B")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000B61")]
	public override bool Equals(PublishedFileUpdateHandle_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000B5C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000B5D")]
	public static bool op_Equality(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B5F")]
	public static PublishedFileUpdateHandle_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B60")]
	public static ulong op_Explicit(PublishedFileUpdateHandle_t that) { }

	[Address(RVA = "0x639550", Offset = "0x638950", Length = "0x52")]
	[Token(Token = "0x6000B5E")]
	public static bool op_Inequality(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000B5A")]
	public virtual string ToString() { }

}

