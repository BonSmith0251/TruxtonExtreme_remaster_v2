namespace System.Text;

[Token(Token = "0x2000298")]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B67")]
	internal Encoding _encoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B68")]
	internal Char[] _arrayBestFit; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B69")]
	internal char _cReplacement; //Field offset: 0x20

	[Token(Token = "0x17000204")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6001554")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x20B2600", Offset = "0x20B1A00", Length = "0x37")]
	[Token(Token = "0x6001552")]
	internal InternalDecoderBestFitFallback(Encoding encoding) { }

	[Address(RVA = "0x20B24E0", Offset = "0x20B18E0", Length = "0x54")]
	[Token(Token = "0x6001553")]
	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x20B2540", Offset = "0x20B1940", Length = "0xB2")]
	[Token(Token = "0x6001555")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6001554")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
	[Token(Token = "0x6001556")]
	public virtual int GetHashCode() { }

}

