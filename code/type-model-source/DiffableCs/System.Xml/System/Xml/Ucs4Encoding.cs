namespace System.Xml;

[Token(Token = "0x20000D0")]
internal class Ucs4Encoding : Encoding
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000571")]
	internal Ucs4Decoder ucs4Decoder; //Field offset: 0x38

	[Token(Token = "0x170002CF")]
	public virtual int CodePage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000B28")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170002D2")]
	internal static Encoding UCS4_2143
	{
		[Address(RVA = "0x254C0C0", Offset = "0x254B4C0", Length = "0xCF")]
		[Token(Token = "0x6000B2C")]
		internal get { } //Length: 207
	}

	[Token(Token = "0x170002D3")]
	internal static Encoding UCS4_3412
	{
		[Address(RVA = "0x254C190", Offset = "0x254B590", Length = "0xCF")]
		[Token(Token = "0x6000B2D")]
		internal get { } //Length: 207
	}

	[Token(Token = "0x170002D1")]
	internal static Encoding UCS4_Bigendian
	{
		[Address(RVA = "0x254C260", Offset = "0x254B660", Length = "0xCF")]
		[Token(Token = "0x6000B2B")]
		internal get { } //Length: 207
	}

	[Token(Token = "0x170002D0")]
	internal static Encoding UCS4_Littleendian
	{
		[Address(RVA = "0x254C330", Offset = "0x254B730", Length = "0xCF")]
		[Token(Token = "0x6000B2A")]
		internal get { } //Length: 207
	}

	[Token(Token = "0x170002CE")]
	public virtual string WebName
	{
		[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
		[Token(Token = "0x6000B1F")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x254C0B0", Offset = "0x254B4B0", Length = "0x7")]
	[Token(Token = "0x6000B2E")]
	public Ucs4Encoding() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000B28")]
	public virtual int get_CodePage() { }

	[Address(RVA = "0x254C0C0", Offset = "0x254B4C0", Length = "0xCF")]
	[Token(Token = "0x6000B2C")]
	internal static Encoding get_UCS4_2143() { }

	[Address(RVA = "0x254C190", Offset = "0x254B590", Length = "0xCF")]
	[Token(Token = "0x6000B2D")]
	internal static Encoding get_UCS4_3412() { }

	[Address(RVA = "0x254C260", Offset = "0x254B660", Length = "0xCF")]
	[Token(Token = "0x6000B2B")]
	internal static Encoding get_UCS4_Bigendian() { }

	[Address(RVA = "0x254C330", Offset = "0x254B730", Length = "0xCF")]
	[Token(Token = "0x6000B2A")]
	internal static Encoding get_UCS4_Littleendian() { }

	[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
	[Token(Token = "0x6000B1F")]
	public virtual string get_WebName() { }

	[Address(RVA = "0x254BFC0", Offset = "0x254B3C0", Length = "0x67")]
	[Token(Token = "0x6000B21")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000B22")]
	public virtual Byte[] GetBytes(string s) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000B23")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x254C030", Offset = "0x254B430", Length = "0x2F")]
	[Token(Token = "0x6000B25")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x254C060", Offset = "0x254B460", Length = "0x32")]
	[Token(Token = "0x6000B26")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000B20")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000B29")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000B24")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x254C0A0", Offset = "0x254B4A0", Length = "0xD")]
	[Token(Token = "0x6000B27")]
	public virtual int GetMaxCharCount(int byteCount) { }

}

