namespace System.Text;

[Token(Token = "0x20002A3")]
internal class InternalEncoderBestFitFallback : EncoderFallback
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B7F")]
	internal Encoding _encoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B80")]
	internal Char[] _arrayBestFit; //Field offset: 0x18

	[Token(Token = "0x17000215")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60015A4")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60015A2")]
	internal InternalEncoderBestFitFallback(Encoding encoding) { }

	[Address(RVA = "0x1E8F1E0", Offset = "0x1E8E5E0", Length = "0x54")]
	[Token(Token = "0x60015A3")]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x1E8F240", Offset = "0x1E8E640", Length = "0xB9")]
	[Token(Token = "0x60015A5")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60015A4")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
	[Token(Token = "0x60015A6")]
	public virtual int GetHashCode() { }

}

