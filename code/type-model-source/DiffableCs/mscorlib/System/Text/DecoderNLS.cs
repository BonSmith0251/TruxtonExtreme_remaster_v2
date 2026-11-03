namespace System.Text;

[Token(Token = "0x200029F")]
internal class DecoderNLS : Decoder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B75")]
	private Encoding _encoding; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B76")]
	private bool _mustFlush; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000B77")]
	internal bool _throwOnOverflow; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B78")]
	internal int _bytesUsed; //Field offset: 0x2C

	[Token(Token = "0x1700020E")]
	internal override bool HasState
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001586")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700020D")]
	public bool MustFlush
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6001585")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x20AFC10", Offset = "0x20AF010", Length = "0x67")]
	[Token(Token = "0x600157B")]
	internal DecoderNLS(Encoding encoding) { }

	[Address(RVA = "0x1CFEBC0", Offset = "0x1CFDFC0", Length = "0x5")]
	[Token(Token = "0x6001587")]
	internal void ClearMustFlush() { }

	[Address(RVA = "0x20AF0B0", Offset = "0x20AE4B0", Length = "0x3B5")]
	[Token(Token = "0x6001583")]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x20AEED0", Offset = "0x20AE2D0", Length = "0x1DB")]
	[Token(Token = "0x6001584")]
	public virtual void Convert(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001586")]
	internal override bool get_HasState() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6001585")]
	public bool get_MustFlush() { }

	[Address(RVA = "0x1E9FC90", Offset = "0x1E9F090", Length = "0x27")]
	[Token(Token = "0x600157D")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x20AF590", Offset = "0x20AE990", Length = "0x1E8")]
	[Token(Token = "0x600157E")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[Address(RVA = "0x20AF470", Offset = "0x20AE870", Length = "0x111")]
	[Token(Token = "0x600157F")]
	public virtual int GetCharCount(Byte* bytes, int count, bool flush) { }

	[Address(RVA = "0x1E9FCF0", Offset = "0x1E9F0F0", Length = "0x39")]
	[Token(Token = "0x6001580")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x20AF8E0", Offset = "0x20AECE0", Length = "0x307")]
	[Token(Token = "0x6001581")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

	[Address(RVA = "0x20AF780", Offset = "0x20AEB80", Length = "0x150")]
	[Token(Token = "0x6001582")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

	[Address(RVA = "0x20AFBF0", Offset = "0x20AEFF0", Length = "0x1E")]
	[Token(Token = "0x600157C")]
	public virtual void Reset() { }

}

