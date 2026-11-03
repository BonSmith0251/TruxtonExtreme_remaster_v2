namespace System.Net.Cache;

[Token(Token = "0x20002F0")]
internal class RequestCacheBinding
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CC1")]
	private RequestCache m_RequestCache; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CC2")]
	private RequestCacheValidator m_CacheValidator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CC3")]
	private RequestCachePolicy m_Policy; //Field offset: 0x20

	[Token(Token = "0x1700043D")]
	internal RequestCache Cache
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001374")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700043E")]
	internal RequestCacheValidator Validator
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001375")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001374")]
	internal RequestCache get_Cache() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001375")]
	internal RequestCacheValidator get_Validator() { }

}

