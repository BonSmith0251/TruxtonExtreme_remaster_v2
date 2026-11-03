namespace System.Xml;

[Token(Token = "0x200001D")]
internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000DB")]
	private CharEntityEncoderFallback parent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DC")]
	private string charEntity; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000DD")]
	private int charEntityIndex; //Field offset: 0x40

	[Token(Token = "0x17000015")]
	public virtual int Remaining
	{
		[Address(RVA = "0x23F38B0", Offset = "0x23F2CB0", Length = "0x2A")]
		[Token(Token = "0x60000EF")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x23F3850", Offset = "0x23F2C50", Length = "0x59")]
	[Token(Token = "0x60000EA")]
	internal CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent) { }

	[Address(RVA = "0x23F3230", Offset = "0x23F2630", Length = "0x28A")]
	[Token(Token = "0x60000EB")]
	public virtual bool Fallback(char charUnknown, int index) { }

	[Address(RVA = "0x23F34C0", Offset = "0x23F28C0", Length = "0x304")]
	[Token(Token = "0x60000EC")]
	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[Address(RVA = "0x23F38B0", Offset = "0x23F2CB0", Length = "0x2A")]
	[Token(Token = "0x60000EF")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x23F37D0", Offset = "0x23F2BD0", Length = "0x4F")]
	[Token(Token = "0x60000ED")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x23F3820", Offset = "0x23F2C20", Length = "0x15")]
	[Token(Token = "0x60000EE")]
	public virtual bool MovePrevious() { }

	[Address(RVA = "0x19602D0", Offset = "0x195F6D0", Length = "0x8")]
	[Token(Token = "0x60000F0")]
	public virtual void Reset() { }

	[Address(RVA = "0x23F3840", Offset = "0x23F2C40", Length = "0xF")]
	[Token(Token = "0x60000F1")]
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }

}

