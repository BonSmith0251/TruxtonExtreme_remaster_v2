namespace Steamworks;

[Token(Token = "0x20001E6")]
public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
{
	[Token(Token = "0x4000B53")]
	public static readonly PublishedFileId_t Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B54")]
	public ulong m_PublishedFileId; //Field offset: 0x0

	[Address(RVA = "0x6393D0", Offset = "0x6387D0", Length = "0x3A")]
	[Token(Token = "0x6000B58")]
	private static PublishedFileId_t() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000B4E")]
	public PublishedFileId_t(ulong value) { }

	[Address(RVA = "0x604690", Offset = "0x603A90", Length = "0x8")]
	[Token(Token = "0x6000B57")]
	public override int CompareTo(PublishedFileId_t other) { }

	[Address(RVA = "0x639330", Offset = "0x638730", Length = "0x99")]
	[Token(Token = "0x6000B50")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x6000B56")]
	public override bool Equals(PublishedFileId_t other) { }

	[Address(RVA = "0x604740", Offset = "0x603B40", Length = "0x7")]
	[Token(Token = "0x6000B51")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000B52")]
	public static bool op_Equality(PublishedFileId_t x, PublishedFileId_t y) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B54")]
	public static PublishedFileId_t op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B55")]
	public static ulong op_Explicit(PublishedFileId_t that) { }

	[Address(RVA = "0x639410", Offset = "0x638810", Length = "0x52")]
	[Token(Token = "0x6000B53")]
	public static bool op_Inequality(PublishedFileId_t x, PublishedFileId_t y) { }

	[Address(RVA = "0x604A10", Offset = "0x603E10", Length = "0x7")]
	[Token(Token = "0x6000B4F")]
	public virtual string ToString() { }

}

