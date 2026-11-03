namespace System.Text;

[Token(Token = "0x20002A2")]
public abstract class Encoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B7D")]
	internal EncoderFallback _fallback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B7E")]
	internal EncoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	[Token(Token = "0x17000212")]
	public EncoderFallback Fallback
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001598")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000213")]
	public EncoderFallbackBuffer FallbackBuffer
	{
		[Address(RVA = "0x20B1D30", Offset = "0x20B1130", Length = "0x77")]
		[Token(Token = "0x6001599")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000214")]
	internal bool InternalHasFallbackBuffer
	{
		[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
		[Token(Token = "0x600159A")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001597")]
	protected Encoder() { }

	[Address(RVA = "0x20B1470", Offset = "0x20B0870", Length = "0x3DF")]
	[Token(Token = "0x60015A0")]
	public override void Convert(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[Address(RVA = "0x20B1210", Offset = "0x20B0610", Length = "0x25F")]
	[CLSCompliant(False)]
	[Token(Token = "0x60015A1")]
	public override void Convert(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001598")]
	public EncoderFallback get_Fallback() { }

	[Address(RVA = "0x20B1D30", Offset = "0x20B1130", Length = "0x77")]
	[Token(Token = "0x6001599")]
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
	[Token(Token = "0x600159A")]
	internal bool get_InternalHasFallbackBuffer() { }

	[Token(Token = "0x600159C")]
	public abstract int GetByteCount(Char[] chars, int index, int count, bool flush) { }

	[Address(RVA = "0x20B1850", Offset = "0x20B0C50", Length = "0x19A")]
	[CLSCompliant(False)]
	[Token(Token = "0x600159D")]
	public override int GetByteCount(Char* chars, int count, bool flush) { }

	[Token(Token = "0x600159E")]
	public abstract int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

	[Address(RVA = "0x20B19F0", Offset = "0x20B0DF0", Length = "0x257")]
	[CLSCompliant(False)]
	[Token(Token = "0x600159F")]
	public override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

	[Address(RVA = "0x20B1C50", Offset = "0x20B1050", Length = "0xDE")]
	[Token(Token = "0x600159B")]
	public override void Reset() { }

}

