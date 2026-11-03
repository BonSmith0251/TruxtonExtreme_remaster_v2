namespace System.Text;

[Token(Token = "0x2000295")]
public class ASCIIEncoding : Encoding
{
	[Token(Token = "0x2000296")]
	public sealed class ASCIIEncodingSealed : ASCIIEncoding
	{

		[Address(RVA = "0x20AAC90", Offset = "0x20AA090", Length = "0x4F")]
		[Token(Token = "0x6001543")]
		public ASCIIEncodingSealed() { }

	}

	[Token(Token = "0x4000B64")]
	internal static readonly ASCIIEncodingSealed s_default; //Field offset: 0x0

	[Address(RVA = "0x20AD000", Offset = "0x20AC400", Length = "0xAA")]
	[Token(Token = "0x6001542")]
	private static ASCIIEncoding() { }

	[Address(RVA = "0x20AD0B0", Offset = "0x20AC4B0", Length = "0xD")]
	[Token(Token = "0x600152D")]
	public ASCIIEncoding() { }

	[Address(RVA = "0x20AB110", Offset = "0x20AA510", Length = "0x1A4")]
	[Token(Token = "0x600152F")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x20AB2C0", Offset = "0x20AA6C0", Length = "0x98")]
	[Token(Token = "0x6001530")]
	public virtual int GetByteCount(string chars) { }

	[Address(RVA = "0x20AACE0", Offset = "0x20AA0E0", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001531")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x20AADE0", Offset = "0x20AA1E0", Length = "0x328")]
	[Token(Token = "0x600153A")]
	internal virtual int GetByteCount(Char* chars, int charCount, EncoderNLS encoder) { }

	[Address(RVA = "0x20ABC50", Offset = "0x20AB050", Length = "0x2C5")]
	[Token(Token = "0x6001532")]
	public virtual int GetBytes(string chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x20AB980", Offset = "0x20AAD80", Length = "0x2C0")]
	[Token(Token = "0x6001533")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x20AB850", Offset = "0x20AAC50", Length = "0x12D")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001534")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x20AB360", Offset = "0x20AA760", Length = "0x4E0")]
	[Token(Token = "0x600153B")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	[Address(RVA = "0x20ABF20", Offset = "0x20AB320", Length = "0x1A3")]
	[Token(Token = "0x6001535")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x20AC0D0", Offset = "0x20AB4D0", Length = "0xF4")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001536")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x20AC1D0", Offset = "0x20AB5D0", Length = "0x19F")]
	[Token(Token = "0x600153C")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS decoder) { }

	[Address(RVA = "0x20AC4A0", Offset = "0x20AB8A0", Length = "0x310")]
	[Token(Token = "0x600153D")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS decoder) { }

	[Address(RVA = "0x20AC370", Offset = "0x20AB770", Length = "0x12C")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001538")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x20AC7C0", Offset = "0x20ABBC0", Length = "0x2C1")]
	[Token(Token = "0x6001537")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x20ACA90", Offset = "0x20ABE90", Length = "0x95")]
	[Token(Token = "0x6001540")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x20ACB30", Offset = "0x20ABF30", Length = "0x54")]
	[Token(Token = "0x6001541")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x20ACB90", Offset = "0x20ABF90", Length = "0x135")]
	[Token(Token = "0x600153E")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x20ACCD0", Offset = "0x20AC0D0", Length = "0x13E")]
	[Token(Token = "0x600153F")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x20ACE10", Offset = "0x20AC210", Length = "0x1AD")]
	[Token(Token = "0x6001539")]
	public virtual string GetString(Byte[] bytes, int byteIndex, int byteCount) { }

	[Address(RVA = "0x20ACFC0", Offset = "0x20AC3C0", Length = "0x3C")]
	[Token(Token = "0x600152E")]
	internal virtual void SetDefaultFallbacks() { }

}

