namespace System.Text;

[Token(Token = "0x200029A")]
public sealed class DecoderExceptionFallback : DecoderFallback
{

	[Token(Token = "0x17000207")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001561")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600155F")]
	public DecoderExceptionFallback() { }

	[Address(RVA = "0x20AE5B0", Offset = "0x20AD9B0", Length = "0x44")]
	[Token(Token = "0x6001560")]
	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x20AE600", Offset = "0x20ADA00", Length = "0x4E")]
	[Token(Token = "0x6001562")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001561")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x20AE650", Offset = "0x20ADA50", Length = "0x6")]
	[Token(Token = "0x6001563")]
	public virtual int GetHashCode() { }

}

