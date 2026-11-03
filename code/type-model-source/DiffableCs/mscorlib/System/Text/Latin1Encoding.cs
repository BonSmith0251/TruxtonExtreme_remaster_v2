namespace System.Text;

[Token(Token = "0x20002AF")]
internal class Latin1Encoding : EncodingNLS, ISerializable
{
	[Token(Token = "0x4000B9E")]
	internal static readonly Latin1Encoding s_default; //Field offset: 0x0
	[Token(Token = "0x4000B9F")]
	private static readonly Char[] arrayCharBestFit; //Field offset: 0x8

	[Address(RVA = "0x1E8FE60", Offset = "0x1E8F260", Length = "0xD7")]
	[Token(Token = "0x600160B")]
	private static Latin1Encoding() { }

	[Address(RVA = "0x1E8FF90", Offset = "0x1E8F390", Length = "0xD")]
	[Token(Token = "0x6001601")]
	public Latin1Encoding() { }

	[Address(RVA = "0x1E8FF40", Offset = "0x1E8F340", Length = "0x50")]
	[Token(Token = "0x6001602")]
	internal Latin1Encoding(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1E8F330", Offset = "0x1E8E730", Length = "0x4F")]
	[Token(Token = "0x600160A")]
	internal virtual Char[] GetBestFitUnicodeToBytesData() { }

	[Address(RVA = "0x1E8F380", Offset = "0x1E8E780", Length = "0x265")]
	[Token(Token = "0x6001604")]
	internal virtual int GetByteCount(Char* chars, int charCount, EncoderNLS encoder) { }

	[Address(RVA = "0x1E8F5F0", Offset = "0x1E8E9F0", Length = "0x48E")]
	[Token(Token = "0x6001605")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	[Address(RVA = "0x669FD0", Offset = "0x6693D0", Length = "0x4")]
	[Token(Token = "0x6001606")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS decoder) { }

	[Address(RVA = "0x1E8FA80", Offset = "0x1E8EE80", Length = "0x7E")]
	[Token(Token = "0x6001607")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS decoder) { }

	[Address(RVA = "0x1E8FB00", Offset = "0x1E8EF00", Length = "0x135")]
	[Token(Token = "0x6001608")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x1E8FC40", Offset = "0x1E8F040", Length = "0x13E")]
	[Token(Token = "0x6001609")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x1E8FD80", Offset = "0x1E8F180", Length = "0xD8")]
	[Token(Token = "0x6001603")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

