namespace System.Text;

[Token(Token = "0x20002BE")]
public class UnicodeEncoding : Encoding
{
	[Token(Token = "0x20002BF")]
	private sealed class Decoder : DecoderNLS
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BCF")]
		internal int lastByte; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000BD0")]
		internal char lastChar; //Field offset: 0x34

		[Token(Token = "0x17000234")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x1E9FC40", Offset = "0x1E9F040", Length = "0x12")]
			[Token(Token = "0x60016E2")]
			internal get { } //Length: 18
		}

		[Address(RVA = "0x1E9FC30", Offset = "0x1E9F030", Length = "0xF")]
		[Token(Token = "0x60016E0")]
		public Decoder(UnicodeEncoding encoding) { }

		[Address(RVA = "0x1E9FC40", Offset = "0x1E9F040", Length = "0x12")]
		[Token(Token = "0x60016E2")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x1E9FC00", Offset = "0x1E9F000", Length = "0x2C")]
		[Token(Token = "0x60016E1")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x4000BC7")]
	internal static readonly UnicodeEncoding s_bigEndianDefault; //Field offset: 0x0
	[Token(Token = "0x4000BC8")]
	internal static readonly UnicodeEncoding s_littleEndianDefault; //Field offset: 0x8
	[Token(Token = "0x4000BC9")]
	private static readonly Byte[] s_bigEndianPreamble; //Field offset: 0x10
	[Token(Token = "0x4000BCA")]
	private static readonly Byte[] s_littleEndianPreamble; //Field offset: 0x18
	[Token(Token = "0x4000BCE")]
	private static readonly ulong highLowPatternMask; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BCB")]
	internal bool isThrowException; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000BCC")]
	internal bool bigEndian; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000BCD")]
	internal bool byteOrderMark; //Field offset: 0x3A

	[Token(Token = "0x17000233")]
	public virtual ReadOnlySpan<Byte> Preamble
	{
		[Address(RVA = "0x1EB48C0", Offset = "0x1EB3CC0", Length = "0x154")]
		[Token(Token = "0x60016DA")]
		 get { } //Length: 340
	}

	[Address(RVA = "0x1EB45F0", Offset = "0x1EB39F0", Length = "0x1C3")]
	[Token(Token = "0x60016DF")]
	private static UnicodeEncoding() { }

	[Address(RVA = "0x1EB47C0", Offset = "0x1EB3BC0", Length = "0x72")]
	[Token(Token = "0x60016C6")]
	public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[Address(RVA = "0x1EB4890", Offset = "0x1EB3C90", Length = "0x2A")]
	[Token(Token = "0x60016C4")]
	public UnicodeEncoding() { }

	[Address(RVA = "0x1EB4840", Offset = "0x1EB3C40", Length = "0x46")]
	[Token(Token = "0x60016C5")]
	public UnicodeEncoding(bool bigEndian, bool byteOrderMark) { }

	[Address(RVA = "0x1EB08C0", Offset = "0x1EAFCC0", Length = "0x118")]
	[Token(Token = "0x60016DD")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1EB48C0", Offset = "0x1EB3CC0", Length = "0x154")]
	[Token(Token = "0x60016DA")]
	public virtual ReadOnlySpan<Byte> get_Preamble() { }

	[Address(RVA = "0x1EB0B90", Offset = "0x1EAFF90", Length = "0x73E")]
	[Token(Token = "0x60016D3")]
	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS encoder) { }

	[Address(RVA = "0x1EB09E0", Offset = "0x1EAFDE0", Length = "0x1A4")]
	[Token(Token = "0x60016C8")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x1EB12D0", Offset = "0x1EB06D0", Length = "0x98")]
	[Token(Token = "0x60016C9")]
	public virtual int GetByteCount(string s) { }

	[Address(RVA = "0x1EB1370", Offset = "0x1EB0770", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60016CA")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x1EB1470", Offset = "0x1EB0870", Length = "0x2C5")]
	[Token(Token = "0x60016CB")]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1EB2090", Offset = "0x1EB1490", Length = "0x2C0")]
	[Token(Token = "0x60016CC")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1EB2360", Offset = "0x1EB1760", Length = "0x12D")]
	[CLSCompliant(False)]
	[Token(Token = "0x60016CD")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1EB1740", Offset = "0x1EB0B40", Length = "0x94F")]
	[Token(Token = "0x60016D4")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	[Address(RVA = "0x1EB2DF0", Offset = "0x1EB21F0", Length = "0x1A3")]
	[Token(Token = "0x60016CE")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1EB2CF0", Offset = "0x1EB20F0", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60016CF")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x1EB2490", Offset = "0x1EB1890", Length = "0x858")]
	[Token(Token = "0x60016D5")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1EB2FA0", Offset = "0x1EB23A0", Length = "0xB0A")]
	[Token(Token = "0x60016D6")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1EB3AB0", Offset = "0x1EB2EB0", Length = "0x12C")]
	[CLSCompliant(False)]
	[Token(Token = "0x60016D1")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x1EB3BE0", Offset = "0x1EB2FE0", Length = "0x2C1")]
	[Token(Token = "0x60016D0")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x1EB3EB0", Offset = "0x1EB32B0", Length = "0x5B")]
	[Token(Token = "0x60016D8")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x1EB3F10", Offset = "0x1EB3310", Length = "0x54")]
	[Token(Token = "0x60016D7")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x1EB3F70", Offset = "0x1EB3370", Length = "0x9B")]
	[Token(Token = "0x60016DE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1EB4010", Offset = "0x1EB3410", Length = "0x138")]
	[Token(Token = "0x60016DB")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x1EB4150", Offset = "0x1EB3550", Length = "0x142")]
	[Token(Token = "0x60016DC")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x1EB42A0", Offset = "0x1EB36A0", Length = "0xAD")]
	[Token(Token = "0x60016D9")]
	public virtual Byte[] GetPreamble() { }

	[Address(RVA = "0x1EB4350", Offset = "0x1EB3750", Length = "0x1AD")]
	[Token(Token = "0x60016D2")]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1EB4500", Offset = "0x1EB3900", Length = "0xE3")]
	[Token(Token = "0x60016C7")]
	internal virtual void SetDefaultFallbacks() { }

}

