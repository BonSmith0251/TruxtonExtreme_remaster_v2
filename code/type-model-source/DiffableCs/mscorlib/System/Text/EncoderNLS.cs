namespace System.Text;

[Token(Token = "0x20002AA")]
internal class EncoderNLS : Encoder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B93")]
	internal char _charLeftOver; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B94")]
	private Encoding _encoding; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B95")]
	private bool _mustFlush; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000B96")]
	internal bool _throwOnOverflow; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B97")]
	internal int _charsUsed; //Field offset: 0x34

	[Token(Token = "0x1700021E")]
	public Encoding Encoding
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60015D8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000220")]
	internal override bool HasState
	{
		[Address(RVA = "0x1E8C9E0", Offset = "0x1E8BDE0", Length = "0x9")]
		[Token(Token = "0x60015DA")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x1700021F")]
	public bool MustFlush
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60015D9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E8C970", Offset = "0x1E8BD70", Length = "0x67")]
	[Token(Token = "0x60015D0")]
	internal EncoderNLS(Encoding encoding) { }

	[Address(RVA = "0xD985E0", Offset = "0xD979E0", Length = "0x5")]
	[Token(Token = "0x60015DB")]
	internal void ClearMustFlush() { }

	[Address(RVA = "0x1E8BE00", Offset = "0x1E8B200", Length = "0x3B5")]
	[Token(Token = "0x60015D6")]
	public virtual void Convert(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[Address(RVA = "0x1E8BC20", Offset = "0x1E8B020", Length = "0x1DB")]
	[Token(Token = "0x60015D7")]
	public virtual void Convert(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60015D8")]
	public Encoding get_Encoding() { }

	[Address(RVA = "0x1E8C9E0", Offset = "0x1E8BDE0", Length = "0x9")]
	[Token(Token = "0x60015DA")]
	internal override bool get_HasState() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x60015D9")]
	public bool get_MustFlush() { }

	[Address(RVA = "0x1E8C1C0", Offset = "0x1E8B5C0", Length = "0x1FA")]
	[Token(Token = "0x60015D2")]
	public virtual int GetByteCount(Char[] chars, int index, int count, bool flush) { }

	[Address(RVA = "0x1E8C3C0", Offset = "0x1E8B7C0", Length = "0x111")]
	[Token(Token = "0x60015D3")]
	public virtual int GetByteCount(Char* chars, int count, bool flush) { }

	[Address(RVA = "0x1E8C4E0", Offset = "0x1E8B8E0", Length = "0x30A")]
	[Token(Token = "0x60015D4")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

	[Address(RVA = "0x1E8C7F0", Offset = "0x1E8BBF0", Length = "0x14D")]
	[Token(Token = "0x60015D5")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

	[Address(RVA = "0x1E8C940", Offset = "0x1E8BD40", Length = "0x25")]
	[Token(Token = "0x60015D1")]
	public virtual void Reset() { }

}

