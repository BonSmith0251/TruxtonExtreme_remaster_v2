namespace System.Text;

[Token(Token = "0x2000297")]
public abstract class Decoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B65")]
	internal DecoderFallback _fallback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B66")]
	internal DecoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	[Token(Token = "0x17000201")]
	public DecoderFallback Fallback
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001545")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000202")]
	public DecoderFallbackBuffer FallbackBuffer
	{
		[Address(RVA = "0x20B0FD0", Offset = "0x20B03D0", Length = "0x77")]
		[Token(Token = "0x6001546")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000203")]
	internal bool InternalHasFallbackBuffer
	{
		[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
		[Token(Token = "0x6001547")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001544")]
	protected Decoder() { }

	[Address(RVA = "0x20B02F0", Offset = "0x20AF6F0", Length = "0x3DF")]
	[Token(Token = "0x6001550")]
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x20B06D0", Offset = "0x20AFAD0", Length = "0x25F")]
	[CLSCompliant(False)]
	[Token(Token = "0x6001551")]
	public override void Convert(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001545")]
	public DecoderFallback get_Fallback() { }

	[Address(RVA = "0x20B0FD0", Offset = "0x20B03D0", Length = "0x77")]
	[Token(Token = "0x6001546")]
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
	[Token(Token = "0x6001547")]
	internal bool get_InternalHasFallbackBuffer() { }

	[Token(Token = "0x6001549")]
	public abstract int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x20B0AC0", Offset = "0x20AFEC0", Length = "0x19")]
	[Token(Token = "0x600154A")]
	public override int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[Address(RVA = "0x20B0930", Offset = "0x20AFD30", Length = "0x185")]
	[CLSCompliant(False)]
	[Token(Token = "0x600154B")]
	public override int GetCharCount(Byte* bytes, int count, bool flush) { }

	[Token(Token = "0x600154C")]
	public abstract int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x20B0AE0", Offset = "0x20AFEE0", Length = "0x19")]
	[Token(Token = "0x600154D")]
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

	[Address(RVA = "0x20B0B00", Offset = "0x20AFF00", Length = "0x256")]
	[CLSCompliant(False)]
	[Token(Token = "0x600154E")]
	public override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

	[Address(RVA = "0x20B0D60", Offset = "0x20B0160", Length = "0x133")]
	[Token(Token = "0x600154F")]
	public override int GetChars(ReadOnlySpan<Byte> bytes, Span<Char> chars, bool flush) { }

	[Address(RVA = "0x20B0EA0", Offset = "0x20B02A0", Length = "0x12E")]
	[Token(Token = "0x6001548")]
	public override void Reset() { }

}

