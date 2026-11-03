namespace System.Net.Cache;

[Token(Token = "0x20002F2")]
public class RequestCachePolicy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CCC")]
	private RequestCacheLevel m_Level; //Field offset: 0x10

	[Token(Token = "0x1700043F")]
	public RequestCacheLevel Level
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001378")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x25E1A20", Offset = "0x25E0E20", Length = "0x1D")]
	[Token(Token = "0x6001376")]
	public RequestCachePolicy() { }

	[Address(RVA = "0x25E1A40", Offset = "0x25E0E40", Length = "0x71")]
	[Token(Token = "0x6001377")]
	public RequestCachePolicy(RequestCacheLevel level) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6001378")]
	public RequestCacheLevel get_Level() { }

	[Address(RVA = "0x25E19A0", Offset = "0x25E0DA0", Length = "0x71")]
	[Token(Token = "0x6001379")]
	public virtual string ToString() { }

}

