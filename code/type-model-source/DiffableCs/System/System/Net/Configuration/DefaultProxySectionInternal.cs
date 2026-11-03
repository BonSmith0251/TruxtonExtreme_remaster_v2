namespace System.Net.Configuration;

[Token(Token = "0x20002EC")]
internal sealed class DefaultProxySectionInternal
{
	[Token(Token = "0x4000CBA")]
	private static object classSyncObject; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CB9")]
	private IWebProxy webProxy; //Field offset: 0x10

	[Token(Token = "0x17000439")]
	internal static object ClassSyncObject
	{
		[Address(RVA = "0x25DE670", Offset = "0x25DDA70", Length = "0x95")]
		[Token(Token = "0x6001369")]
		internal get { } //Length: 149
	}

	[Token(Token = "0x1700043A")]
	internal IWebProxy WebProxy
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600136B")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600136C")]
	public DefaultProxySectionInternal() { }

	[Address(RVA = "0x25DE670", Offset = "0x25DDA70", Length = "0x95")]
	[Token(Token = "0x6001369")]
	internal static object get_ClassSyncObject() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600136B")]
	internal IWebProxy get_WebProxy() { }

	[Address(RVA = "0x25DE4E0", Offset = "0x25DD8E0", Length = "0x7")]
	[Token(Token = "0x6001367")]
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	[Address(RVA = "0x25DE4F0", Offset = "0x25DD8F0", Length = "0x179")]
	[Token(Token = "0x600136A")]
	internal static DefaultProxySectionInternal GetSection() { }

	[Address(RVA = "0x25DE4E0", Offset = "0x25DD8E0", Length = "0x7")]
	[Token(Token = "0x6001368")]
	private static IWebProxy GetSystemWebProxy() { }

}

