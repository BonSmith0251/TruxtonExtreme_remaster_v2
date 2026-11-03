namespace System.Text;

[Token(Token = "0x20002A5")]
public sealed class EncoderExceptionFallback : EncoderFallback
{

	[Token(Token = "0x17000218")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60015B2")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60015B0")]
	public EncoderExceptionFallback() { }

	[Address(RVA = "0x1E8B470", Offset = "0x1E8A870", Length = "0x44")]
	[Token(Token = "0x60015B1")]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x1E8B4C0", Offset = "0x1E8A8C0", Length = "0x4E")]
	[Token(Token = "0x60015B3")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60015B2")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x1E8B510", Offset = "0x1E8A910", Length = "0x6")]
	[Token(Token = "0x60015B4")]
	public virtual int GetHashCode() { }

}

