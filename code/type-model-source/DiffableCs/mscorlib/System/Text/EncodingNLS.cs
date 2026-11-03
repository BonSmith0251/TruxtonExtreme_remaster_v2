namespace System.Text;

[Token(Token = "0x20002AD")]
internal abstract class EncodingNLS : Encoding
{

	[Address(RVA = "0x1E8E610", Offset = "0x1E8DA10", Length = "0x8")]
	[Token(Token = "0x60015EC")]
	protected EncodingNLS(int codePage) { }

	[Address(RVA = "0x1E8D430", Offset = "0x1E8C830", Length = "0x1A4")]
	[Token(Token = "0x60015ED")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x1E8D290", Offset = "0x1E8C690", Length = "0x98")]
	[Token(Token = "0x60015EE")]
	public virtual int GetByteCount(string s) { }

	[Address(RVA = "0x1E8D330", Offset = "0x1E8C730", Length = "0xF4")]
	[Token(Token = "0x60015EF")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x1E8D5E0", Offset = "0x1E8C9E0", Length = "0x2C5")]
	[Token(Token = "0x60015F0")]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1E8D9E0", Offset = "0x1E8CDE0", Length = "0x2C0")]
	[Token(Token = "0x60015F1")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1E8D8B0", Offset = "0x1E8CCB0", Length = "0x12D")]
	[Token(Token = "0x60015F2")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1E8DCB0", Offset = "0x1E8D0B0", Length = "0x1A3")]
	[Token(Token = "0x60015F3")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1E8DE60", Offset = "0x1E8D260", Length = "0xF4")]
	[Token(Token = "0x60015F4")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x1E8E090", Offset = "0x1E8D490", Length = "0x2C1")]
	[Token(Token = "0x60015F5")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x1E8DF60", Offset = "0x1E8D360", Length = "0x12C")]
	[Token(Token = "0x60015F6")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x1E8E360", Offset = "0x1E8D760", Length = "0x54")]
	[Token(Token = "0x60015F8")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x1E8E3C0", Offset = "0x1E8D7C0", Length = "0x95")]
	[Token(Token = "0x60015F9")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x1E8E460", Offset = "0x1E8D860", Length = "0x1AD")]
	[Token(Token = "0x60015F7")]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

}

