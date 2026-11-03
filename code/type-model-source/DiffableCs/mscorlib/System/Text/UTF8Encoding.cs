namespace System.Text;

[Token(Token = "0x20002BA")]
public class UTF8Encoding : Encoding
{
	[Token(Token = "0x20002BD")]
	private sealed class UTF8Decoder : DecoderNLS
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BC6")]
		internal int bits; //Field offset: 0x30

		[Token(Token = "0x17000232")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x1EB0750", Offset = "0x1EAFB50", Length = "0x8")]
			[Token(Token = "0x60016C3")]
			internal get { } //Length: 8
		}

		[Address(RVA = "0x1E8B130", Offset = "0x1E8A530", Length = "0x8")]
		[Token(Token = "0x60016C1")]
		public UTF8Decoder(UTF8Encoding encoding) { }

		[Address(RVA = "0x1EB0750", Offset = "0x1EAFB50", Length = "0x8")]
		[Token(Token = "0x60016C3")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x1EB0720", Offset = "0x1EAFB20", Length = "0x27")]
		[Token(Token = "0x60016C2")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x20002BC")]
	private sealed class UTF8Encoder : EncoderNLS
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BC5")]
		internal int surrogateChar; //Field offset: 0x38

		[Token(Token = "0x17000231")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x1EB07A0", Offset = "0x1EAFBA0", Length = "0x8")]
			[Token(Token = "0x60016C0")]
			internal get { } //Length: 8
		}

		[Address(RVA = "0x1EB0790", Offset = "0x1EAFB90", Length = "0x8")]
		[Token(Token = "0x60016BE")]
		public UTF8Encoder(UTF8Encoding encoding) { }

		[Address(RVA = "0x1EB07A0", Offset = "0x1EAFBA0", Length = "0x8")]
		[Token(Token = "0x60016C0")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x1EB0760", Offset = "0x1EAFB60", Length = "0x27")]
		[Token(Token = "0x60016BF")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x20002BB")]
	public sealed class UTF8EncodingSealed : UTF8Encoding
	{

		[Token(Token = "0x17000230")]
		public virtual ReadOnlySpan<Byte> Preamble
		{
			[Address(RVA = "0x1EB0810", Offset = "0x1EAFC10", Length = "0xAC")]
			[Token(Token = "0x60016BD")]
			 get { } //Length: 172
		}

		[Address(RVA = "0x1EB07B0", Offset = "0x1EAFBB0", Length = "0x59")]
		[Token(Token = "0x60016BC")]
		public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier) { }

		[Address(RVA = "0x1EB0810", Offset = "0x1EAFC10", Length = "0xAC")]
		[Token(Token = "0x60016BD")]
		public virtual ReadOnlySpan<Byte> get_Preamble() { }

	}

	[Token(Token = "0x4000BC1")]
	internal static readonly UTF8EncodingSealed s_default; //Field offset: 0x0
	[Token(Token = "0x4000BC2")]
	internal static readonly Byte[] s_preamble; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BC3")]
	internal readonly bool _emitUTF8Identifier; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000BC4")]
	private bool _isThrowException; //Field offset: 0x39

	[Token(Token = "0x1700022F")]
	public virtual ReadOnlySpan<Byte> Preamble
	{
		[Address(RVA = "0x1E9D920", Offset = "0x1E9CD20", Length = "0x60A")]
		[Token(Token = "0x60016B8")]
		 get { } //Length: 1546
	}

	[Address(RVA = "0x1E9D780", Offset = "0x1E9CB80", Length = "0xE0")]
	[Token(Token = "0x60016BB")]
	private static UTF8Encoding() { }

	[Address(RVA = "0x1E9D860", Offset = "0x1E9CC60", Length = "0x58")]
	[Token(Token = "0x600169C")]
	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	[Address(RVA = "0x1E9D8C0", Offset = "0x1E9CCC0", Length = "0x22")]
	[Token(Token = "0x600169A")]
	public UTF8Encoding() { }

	[Address(RVA = "0x1E9D8F0", Offset = "0x1E9CCF0", Length = "0x2F")]
	[Token(Token = "0x600169B")]
	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) { }

	[Address(RVA = "0x1E9A020", Offset = "0x1E99420", Length = "0xCA")]
	[Token(Token = "0x60016B9")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1E9A140", Offset = "0x1E99540", Length = "0x7C")]
	[Token(Token = "0x60016B0")]
	private bool FallbackInvalidByteSequence(ref Byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref Char* pTarget) { }

	[Address(RVA = "0x1E9A0F0", Offset = "0x1E994F0", Length = "0x48")]
	[Token(Token = "0x60016B1")]
	private int FallbackInvalidByteSequence(Byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	[Address(RVA = "0x1E9D920", Offset = "0x1E9CD20", Length = "0x60A")]
	[Token(Token = "0x60016B8")]
	public virtual ReadOnlySpan<Byte> get_Preamble() { }

	[Address(RVA = "0x1E9A930", Offset = "0x1E99D30", Length = "0x1A4")]
	[Token(Token = "0x600169E")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x1E9A1C0", Offset = "0x1E995C0", Length = "0x98")]
	[Token(Token = "0x600169F")]
	public virtual int GetByteCount(string chars) { }

	[Address(RVA = "0x1E9AAE0", Offset = "0x1E99EE0", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60016A0")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x1E9A260", Offset = "0x1E99660", Length = "0x6C7")]
	[Token(Token = "0x60016A9")]
	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS baseEncoder) { }

	[Address(RVA = "0x1E9B770", Offset = "0x1E9AB70", Length = "0x2C5")]
	[Token(Token = "0x60016A1")]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1E9BA40", Offset = "0x1E9AE40", Length = "0x2C0")]
	[Token(Token = "0x60016A2")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1E9B640", Offset = "0x1E9AA40", Length = "0x12D")]
	[CLSCompliant(False)]
	[Token(Token = "0x60016A3")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1E9AE40", Offset = "0x1E9A240", Length = "0x7FA")]
	[Token(Token = "0x60016AD")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	[Address(RVA = "0x1E9ABE0", Offset = "0x1E99FE0", Length = "0x25D")]
	[Token(Token = "0x60016B2")]
	private Byte[] GetBytesUnknown(ref Byte* pSrc, int ch) { }

	[Address(RVA = "0x1E9C1E0", Offset = "0x1E9B5E0", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60016A5")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x1E9BD10", Offset = "0x1E9B110", Length = "0x4C4")]
	[Token(Token = "0x60016AE")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1E9C2E0", Offset = "0x1E9B6E0", Length = "0x1A3")]
	[Token(Token = "0x60016A4")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1E9C490", Offset = "0x1E9B890", Length = "0x2C1")]
	[Token(Token = "0x60016A6")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x1E9C760", Offset = "0x1E9BB60", Length = "0x7DD")]
	[Token(Token = "0x60016AF")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1E9CF40", Offset = "0x1E9C340", Length = "0x12C")]
	[CLSCompliant(False)]
	[Token(Token = "0x60016A7")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x1E9D070", Offset = "0x1E9C470", Length = "0x54")]
	[Token(Token = "0x60016B3")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x1E9D0D0", Offset = "0x1E9C4D0", Length = "0x54")]
	[Token(Token = "0x60016B4")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x1E9D130", Offset = "0x1E9C530", Length = "0x6A")]
	[Token(Token = "0x60016BA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E9D1A0", Offset = "0x1E9C5A0", Length = "0x139")]
	[Token(Token = "0x60016B5")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x1E9D2E0", Offset = "0x1E9C6E0", Length = "0x135")]
	[Token(Token = "0x60016B6")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x1E9D420", Offset = "0x1E9C820", Length = "0x83")]
	[Token(Token = "0x60016B7")]
	public virtual Byte[] GetPreamble() { }

	[Address(RVA = "0x1E9D4B0", Offset = "0x1E9C8B0", Length = "0x1AD")]
	[Token(Token = "0x60016A8")]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1E9D660", Offset = "0x1E9CA60", Length = "0xC")]
	[Token(Token = "0x60016AC")]
	private static bool InRange(int ch, int start, int end) { }

	[Address(RVA = "0x1E9D680", Offset = "0x1E9CA80", Length = "0x7")]
	[Token(Token = "0x60016AA")]
	private static int PtrDiff(Char* a, Char* b) { }

	[Address(RVA = "0x1E9D670", Offset = "0x1E9CA70", Length = "0x5")]
	[Token(Token = "0x60016AB")]
	private static int PtrDiff(Byte* a, Byte* b) { }

	[Address(RVA = "0x1E9D690", Offset = "0x1E9CA90", Length = "0xE3")]
	[Token(Token = "0x600169D")]
	internal virtual void SetDefaultFallbacks() { }

}

