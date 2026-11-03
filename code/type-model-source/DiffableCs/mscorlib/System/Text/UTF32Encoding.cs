namespace System.Text;

[Token(Token = "0x20002B3")]
public sealed class UTF32Encoding : Encoding
{
	[Token(Token = "0x20002B4")]
	private sealed class UTF32Decoder : DecoderNLS
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BB2")]
		internal int iChar; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000BB3")]
		internal int readByteCount; //Field offset: 0x34

		[Token(Token = "0x1700022A")]
		internal virtual bool HasState
		{
			[Address(RVA = "0xE8A7A0", Offset = "0xE89BA0", Length = "0x8")]
			[Token(Token = "0x600166E")]
			internal get { } //Length: 8
		}

		[Address(RVA = "0x1E8B130", Offset = "0x1E8A530", Length = "0x8")]
		[Token(Token = "0x600166C")]
		public UTF32Decoder(UTF32Encoding encoding) { }

		[Address(RVA = "0xE8A7A0", Offset = "0xE89BA0", Length = "0x8")]
		[Token(Token = "0x600166E")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x1E95230", Offset = "0x1E94630", Length = "0x25")]
		[Token(Token = "0x600166D")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x4000BAB")]
	internal static readonly UTF32Encoding s_default; //Field offset: 0x0
	[Token(Token = "0x4000BAC")]
	internal static readonly UTF32Encoding s_bigEndianDefault; //Field offset: 0x8
	[Token(Token = "0x4000BAD")]
	private static readonly Byte[] s_bigEndianPreamble; //Field offset: 0x10
	[Token(Token = "0x4000BAE")]
	private static readonly Byte[] s_littleEndianPreamble; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BAF")]
	private bool _emitUTF32ByteOrderMark; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000BB0")]
	private bool _isThrowException; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000BB1")]
	private bool _bigEndian; //Field offset: 0x3A

	[Token(Token = "0x17000229")]
	public virtual ReadOnlySpan<Byte> Preamble
	{
		[Address(RVA = "0x1E97DE0", Offset = "0x1E971E0", Length = "0x154")]
		[Token(Token = "0x6001668")]
		 get { } //Length: 340
	}

	[Address(RVA = "0x1E97B50", Offset = "0x1E96F50", Length = "0x19E")]
	[Token(Token = "0x600166B")]
	private static UTF32Encoding() { }

	[Address(RVA = "0x1E97D20", Offset = "0x1E97120", Length = "0x6E")]
	[Token(Token = "0x600164F")]
	public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	[Address(RVA = "0x1E97CF0", Offset = "0x1E970F0", Length = "0x26")]
	[Token(Token = "0x600164D")]
	public UTF32Encoding() { }

	[Address(RVA = "0x1E97D90", Offset = "0x1E97190", Length = "0x42")]
	[Token(Token = "0x600164E")]
	public UTF32Encoding(bool bigEndian, bool byteOrderMark) { }

	[Address(RVA = "0x1E95260", Offset = "0x1E94660", Length = "0xC8")]
	[Token(Token = "0x6001669")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1E97DE0", Offset = "0x1E971E0", Length = "0x154")]
	[Token(Token = "0x6001668")]
	public virtual ReadOnlySpan<Byte> get_Preamble() { }

	[Address(RVA = "0x1E95330", Offset = "0x1E94730", Length = "0x35E")]
	[Token(Token = "0x600165C")]
	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS encoder) { }

	[Address(RVA = "0x1E95690", Offset = "0x1E94A90", Length = "0x1A4")]
	[Token(Token = "0x6001651")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x1E95840", Offset = "0x1E94C40", Length = "0x98")]
	[Token(Token = "0x6001652")]
	public virtual int GetByteCount(string s) { }

	[Address(RVA = "0x1E958E0", Offset = "0x1E94CE0", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001653")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x1E960B0", Offset = "0x1E954B0", Length = "0x499")]
	[Token(Token = "0x600165D")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	[Address(RVA = "0x1E95DE0", Offset = "0x1E951E0", Length = "0x2C5")]
	[Token(Token = "0x6001654")]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1E95CB0", Offset = "0x1E950B0", Length = "0x12D")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001656")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1E959E0", Offset = "0x1E94DE0", Length = "0x2C0")]
	[Token(Token = "0x6001655")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1E968A0", Offset = "0x1E95CA0", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001658")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x1E96550", Offset = "0x1E95950", Length = "0x34F")]
	[Token(Token = "0x600165E")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1E969A0", Offset = "0x1E95DA0", Length = "0x1A3")]
	[Token(Token = "0x6001657")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1E96C80", Offset = "0x1E96080", Length = "0x2C1")]
	[Token(Token = "0x6001659")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x1E96B50", Offset = "0x1E95F50", Length = "0x12C")]
	[CLSCompliant(False)]
	[Token(Token = "0x600165A")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x1E96F50", Offset = "0x1E96350", Length = "0x473")]
	[Token(Token = "0x600165F")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1E973D0", Offset = "0x1E967D0", Length = "0x54")]
	[Token(Token = "0x6001663")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x1E97430", Offset = "0x1E96830", Length = "0x95")]
	[Token(Token = "0x6001664")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x1E974D0", Offset = "0x1E968D0", Length = "0xA2")]
	[Token(Token = "0x600166A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E97580", Offset = "0x1E96980", Length = "0x12")]
	[Token(Token = "0x6001661")]
	private char GetHighSurrogate(uint iChar) { }

	[Address(RVA = "0x1E975A0", Offset = "0x1E969A0", Length = "0x14")]
	[Token(Token = "0x6001662")]
	private char GetLowSurrogate(uint iChar) { }

	[Address(RVA = "0x1E975C0", Offset = "0x1E969C0", Length = "0x13D")]
	[Token(Token = "0x6001665")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x1E97700", Offset = "0x1E96B00", Length = "0xD4")]
	[Token(Token = "0x6001666")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x1E977E0", Offset = "0x1E96BE0", Length = "0xAD")]
	[Token(Token = "0x6001667")]
	public virtual Byte[] GetPreamble() { }

	[Address(RVA = "0x1E97890", Offset = "0x1E96C90", Length = "0x1AD")]
	[Token(Token = "0x600165B")]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1E97A40", Offset = "0x1E96E40", Length = "0x12")]
	[Token(Token = "0x6001660")]
	private uint GetSurrogate(char cHigh, char cLow) { }

	[Address(RVA = "0x1E97A60", Offset = "0x1E96E60", Length = "0xE3")]
	[Token(Token = "0x6001650")]
	internal virtual void SetDefaultFallbacks() { }

}

