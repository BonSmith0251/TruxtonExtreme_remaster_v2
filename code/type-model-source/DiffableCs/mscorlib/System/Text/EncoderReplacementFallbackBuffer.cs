namespace System.Text;

[Token(Token = "0x20002AC")]
public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B99")]
	private string _strDefault; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B9A")]
	private int _fallbackCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B9B")]
	private int _fallbackIndex; //Field offset: 0x3C

	[Token(Token = "0x17000223")]
	public virtual int Remaining
	{
		[Address(RVA = "0x1E8CE30", Offset = "0x1E8C230", Length = "0xD")]
		[Token(Token = "0x60015EA")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x1E8CDD0", Offset = "0x1E8C1D0", Length = "0x52")]
	[Token(Token = "0x60015E5")]
	public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback) { }

	[Address(RVA = "0x1E8CC10", Offset = "0x1E8C010", Length = "0x125")]
	[Token(Token = "0x60015E6")]
	public virtual bool Fallback(char charUnknown, int index) { }

	[Address(RVA = "0x1E8C9F0", Offset = "0x1E8BDF0", Length = "0x211")]
	[Token(Token = "0x60015E7")]
	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[Address(RVA = "0x1E8CE30", Offset = "0x1E8C230", Length = "0xD")]
	[Token(Token = "0x60015EA")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x1E8CD40", Offset = "0x1E8C140", Length = "0x4D")]
	[Token(Token = "0x60015E8")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x1E8CD90", Offset = "0x1E8C190", Length = "0x18")]
	[Token(Token = "0x60015E9")]
	public virtual bool MovePrevious() { }

	[Address(RVA = "0x1E8CDB0", Offset = "0x1E8C1B0", Length = "0x14")]
	[Token(Token = "0x60015EB")]
	public virtual void Reset() { }

}

