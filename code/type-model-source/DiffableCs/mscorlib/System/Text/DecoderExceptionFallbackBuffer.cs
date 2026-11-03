namespace System.Text;

[Token(Token = "0x200029B")]
public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
{

	[Token(Token = "0x17000208")]
	public virtual int Remaining
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001566")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001568")]
	public DecoderExceptionFallbackBuffer() { }

	[Address(RVA = "0x20AE3A0", Offset = "0x20AD7A0", Length = "0xC")]
	[Token(Token = "0x6001564")]
	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001566")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001565")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x20AE3B0", Offset = "0x20AD7B0", Length = "0x1FB")]
	[Token(Token = "0x6001567")]
	private void Throw(Byte[] bytesUnknown, int index) { }

}

