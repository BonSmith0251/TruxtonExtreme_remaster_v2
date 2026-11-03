namespace System.Text;

[Token(Token = "0x20002A6")]
public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
{

	[Token(Token = "0x17000219")]
	public virtual int Remaining
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60015BA")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60015B5")]
	public EncoderExceptionFallbackBuffer() { }

	[Address(RVA = "0x1E8B150", Offset = "0x1E8A550", Length = "0xAB")]
	[Token(Token = "0x60015B6")]
	public virtual bool Fallback(char charUnknown, int index) { }

	[Address(RVA = "0x1E8B200", Offset = "0x1E8A600", Length = "0x26D")]
	[Token(Token = "0x60015B7")]
	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60015BA")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60015B8")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60015B9")]
	public virtual bool MovePrevious() { }

}

