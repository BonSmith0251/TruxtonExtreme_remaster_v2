namespace System.Net;

[Token(Token = "0x200027C")]
internal struct HeaderVariantInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A32")]
	private string m_name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A33")]
	private CookieVariant m_variant; //Field offset: 0x8

	[Token(Token = "0x17000385")]
	internal string Name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60010AD")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000386")]
	internal CookieVariant Variant
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60010AE")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0xAEE5F0", Offset = "0xAED9F0", Length = "0x26")]
	[Token(Token = "0x60010AC")]
	internal HeaderVariantInfo(string name, CookieVariant variant) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60010AD")]
	internal string get_Name() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60010AE")]
	internal CookieVariant get_Variant() { }

}

