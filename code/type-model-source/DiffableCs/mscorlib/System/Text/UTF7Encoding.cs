namespace System.Text;

[Token(Token = "0x20002B5")]
public class UTF7Encoding : Encoding
{
	[Token(Token = "0x20002B6")]
	private sealed class Decoder : DecoderNLS
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BB9")]
		internal int bits; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000BBA")]
		internal int bitCount; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BBB")]
		internal bool firstByte; //Field offset: 0x38

		[Token(Token = "0x1700022B")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x1E8B140", Offset = "0x1E8A540", Length = "0x8")]
			[Token(Token = "0x600168B")]
			internal get { } //Length: 8
		}

		[Address(RVA = "0x1E8B130", Offset = "0x1E8A530", Length = "0x8")]
		[Token(Token = "0x6001689")]
		public Decoder(UTF7Encoding encoding) { }

		[Address(RVA = "0x1E8B140", Offset = "0x1E8A540", Length = "0x8")]
		[Token(Token = "0x600168B")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x1E8B0F0", Offset = "0x1E8A4F0", Length = "0x32")]
		[Token(Token = "0x600168A")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x20002B8")]
	private sealed class DecoderUTF7Fallback : DecoderFallback
	{

		[Token(Token = "0x1700022D")]
		public virtual int MaxCharCount
		{
			[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
			[Token(Token = "0x6001691")]
			 get { } //Length: 6
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600168F")]
		public DecoderUTF7Fallback() { }

		[Address(RVA = "0x1E8B040", Offset = "0x1E8A440", Length = "0x4B")]
		[Token(Token = "0x6001690")]
		public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

		[Address(RVA = "0x1E8B090", Offset = "0x1E8A490", Length = "0x4E")]
		[Token(Token = "0x6001692")]
		public virtual bool Equals(object value) { }

		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6001691")]
		public virtual int get_MaxCharCount() { }

		[Address(RVA = "0x1E8B0E0", Offset = "0x1E8A4E0", Length = "0x6")]
		[Token(Token = "0x6001693")]
		public virtual int GetHashCode() { }

	}

	[Token(Token = "0x20002B9")]
	private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BBE")]
		private char cFallback; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000BBF")]
		private int iCount; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BC0")]
		private int iSize; //Field offset: 0x28

		[Token(Token = "0x1700022E")]
		public virtual int Remaining
		{
			[Address(RVA = "0x1E8B030", Offset = "0x1E8A430", Length = "0xD")]
			[Token(Token = "0x6001697")]
			 get { } //Length: 13
		}

		[Address(RVA = "0x1E8B020", Offset = "0x1E8A420", Length = "0xE")]
		[Token(Token = "0x6001694")]
		public DecoderUTF7FallbackBuffer(DecoderUTF7Fallback fallback) { }

		[Address(RVA = "0x1E8AF20", Offset = "0x1E8A320", Length = "0x43")]
		[Token(Token = "0x6001695")]
		public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

		[Address(RVA = "0x1E8B030", Offset = "0x1E8A430", Length = "0xD")]
		[Token(Token = "0x6001697")]
		public virtual int get_Remaining() { }

		[Address(RVA = "0x1E8AF70", Offset = "0x1E8A370", Length = "0x15")]
		[Token(Token = "0x6001696")]
		public virtual char GetNextChar() { }

		[Address(RVA = "0x1E8AF90", Offset = "0x1E8A390", Length = "0x80")]
		[Token(Token = "0x6001699")]
		internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

		[Address(RVA = "0x1E8B010", Offset = "0x1E8A410", Length = "0x10")]
		[Token(Token = "0x6001698")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x20002B7")]
	private sealed class Encoder : EncoderNLS
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BBC")]
		internal int bits; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000BBD")]
		internal int bitCount; //Field offset: 0x3C

		[Token(Token = "0x1700022C")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x1E8D270", Offset = "0x1E8C670", Length = "0x11")]
			[Token(Token = "0x600168E")]
			internal get { } //Length: 17
		}

		[Address(RVA = "0x1E8C970", Offset = "0x1E8BD70", Length = "0x67")]
		[Token(Token = "0x600168C")]
		public Encoder(UTF7Encoding encoding) { }

		[Address(RVA = "0x1E8D270", Offset = "0x1E8C670", Length = "0x11")]
		[Token(Token = "0x600168E")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x1E8D240", Offset = "0x1E8C640", Length = "0x2E")]
		[Token(Token = "0x600168D")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x4000BB4")]
	internal static readonly UTF7Encoding s_default; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BB5")]
	private Byte[] _base64Bytes; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BB6")]
	private SByte[] _base64Values; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BB7")]
	private Boolean[] _directEncode; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BB8")]
	private bool _allowOptionals; //Field offset: 0x50

	[Address(RVA = "0x1E99F30", Offset = "0x1E99330", Length = "0x7B")]
	[Token(Token = "0x6001688")]
	private static UTF7Encoding() { }

	[Address(RVA = "0x1E99FB0", Offset = "0x1E993B0", Length = "0x29")]
	[Token(Token = "0x600166F")]
	public UTF7Encoding() { }

	[Address(RVA = "0x1E99FE0", Offset = "0x1E993E0", Length = "0x34")]
	[Token(Token = "0x6001670")]
	public UTF7Encoding(bool allowOptionals) { }

	[Address(RVA = "0x1E97F40", Offset = "0x1E97340", Length = "0xCA")]
	[Token(Token = "0x6001673")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1E981F0", Offset = "0x1E975F0", Length = "0x1A4")]
	[Token(Token = "0x6001675")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x1E98150", Offset = "0x1E97550", Length = "0x98")]
	[Token(Token = "0x6001676")]
	public virtual int GetByteCount(string s) { }

	[Address(RVA = "0x1E98010", Offset = "0x1E97410", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001677")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x1E98110", Offset = "0x1E97510", Length = "0x32")]
	[Token(Token = "0x6001680")]
	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS baseEncoder) { }

	[Address(RVA = "0x1E98940", Offset = "0x1E97D40", Length = "0x38B")]
	[Token(Token = "0x6001681")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	[Address(RVA = "0x1E98670", Offset = "0x1E97A70", Length = "0x2C5")]
	[Token(Token = "0x6001678")]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1E983A0", Offset = "0x1E977A0", Length = "0x2C0")]
	[Token(Token = "0x6001679")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1E98CD0", Offset = "0x1E980D0", Length = "0x12D")]
	[CLSCompliant(False)]
	[Token(Token = "0x600167A")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1E98E00", Offset = "0x1E98200", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x600167C")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x1E990B0", Offset = "0x1E984B0", Length = "0x32")]
	[Token(Token = "0x6001682")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1E98F00", Offset = "0x1E98300", Length = "0x1A3")]
	[Token(Token = "0x600167B")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1E99620", Offset = "0x1E98A20", Length = "0x12C")]
	[CLSCompliant(False)]
	[Token(Token = "0x600167E")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x1E990F0", Offset = "0x1E984F0", Length = "0x251")]
	[Token(Token = "0x6001683")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1E99350", Offset = "0x1E98750", Length = "0x2C1")]
	[Token(Token = "0x600167D")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x1E99750", Offset = "0x1E98B50", Length = "0x54")]
	[Token(Token = "0x6001684")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x1E997B0", Offset = "0x1E98BB0", Length = "0x95")]
	[Token(Token = "0x6001685")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x1E99850", Offset = "0x1E98C50", Length = "0x7C")]
	[Token(Token = "0x6001674")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E998D0", Offset = "0x1E98CD0", Length = "0xE1")]
	[Token(Token = "0x6001686")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x1E999C0", Offset = "0x1E98DC0", Length = "0x83")]
	[Token(Token = "0x6001687")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x1E99A50", Offset = "0x1E98E50", Length = "0x1AD")]
	[Token(Token = "0x600167F")]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1E99C00", Offset = "0x1E99000", Length = "0x27D")]
	[Token(Token = "0x6001671")]
	private void MakeTables() { }

	[Address(RVA = "0x1E99E80", Offset = "0x1E99280", Length = "0xB0")]
	[Token(Token = "0x6001672")]
	internal virtual void SetDefaultFallbacks() { }

}

