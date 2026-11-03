namespace System.Text;

[Token(Token = "0x200029E")]
public abstract class DecoderFallbackBuffer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B73")]
	internal Byte* byteStart; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B74")]
	internal Char* charEnd; //Field offset: 0x18

	[Token(Token = "0x1700020C")]
	public abstract int Remaining
	{
		[Token(Token = "0x6001573")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600157A")]
	protected DecoderFallbackBuffer() { }

	[Token(Token = "0x6001571")]
	public abstract bool Fallback(Byte[] bytesUnknown, int index) { }

	[Token(Token = "0x6001573")]
	public abstract int get_Remaining() { }

	[Token(Token = "0x6001572")]
	public abstract char GetNextChar() { }

	[Address(RVA = "0x20AE850", Offset = "0x20ADC50", Length = "0x218")]
	[Token(Token = "0x6001577")]
	internal override bool InternalFallback(Byte[] bytes, Byte* pBytes, ref Char* chars) { }

	[Address(RVA = "0x20AE660", Offset = "0x20ADA60", Length = "0x1E7")]
	[Token(Token = "0x6001578")]
	internal override int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	[Address(RVA = "0x20AEA70", Offset = "0x20ADE70", Length = "0x9")]
	[Token(Token = "0x6001576")]
	internal void InternalInitialize(Byte* byteStart, Char* charEnd) { }

	[Address(RVA = "0x20AEA80", Offset = "0x20ADE80", Length = "0x1C")]
	[Token(Token = "0x6001575")]
	internal void InternalReset() { }

	[Address(RVA = "0x20AEAA0", Offset = "0x20ADEA0", Length = "0x31")]
	[Token(Token = "0x6001574")]
	public override void Reset() { }

	[Address(RVA = "0x20AEAE0", Offset = "0x20ADEE0", Length = "0x206")]
	[Token(Token = "0x6001579")]
	internal void ThrowLastBytesRecursive(Byte[] bytesUnknown) { }

}

