namespace System.Net;

[Token(Token = "0x200027D")]
public class CookieContainer
{
	[Token(Token = "0x4000A34")]
	public const int DefaultCookieLimit = 300; //Field offset: 0x0
	[Token(Token = "0x4000A35")]
	public const int DefaultPerDomainCookieLimit = 20; //Field offset: 0x0
	[Token(Token = "0x4000A36")]
	public const int DefaultCookieLengthLimit = 4096; //Field offset: 0x0
	[Token(Token = "0x4000A37")]
	private static readonly HeaderVariantInfo[] HeaderInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A38")]
	private Hashtable m_domainTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A39")]
	private int m_maxCookieSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A3A")]
	private int m_maxCookies; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A3B")]
	private int m_maxCookiesPerDomain; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000A3C")]
	private int m_count; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A3D")]
	private string m_fqdnMyDomain; //Field offset: 0x28

	[Address(RVA = "0x26B8F20", Offset = "0x26B8320", Length = "0x121")]
	[Token(Token = "0x60010BD")]
	private static CookieContainer() { }

	[Address(RVA = "0x26B9050", Offset = "0x26B8450", Length = "0xFB")]
	[Token(Token = "0x60010AF")]
	public CookieContainer() { }

	[Address(RVA = "0x26B5D00", Offset = "0x26B5100", Length = "0x5B9")]
	[Token(Token = "0x60010B0")]
	public void Add(Cookie cookie) { }

	[Address(RVA = "0x26B5230", Offset = "0x26B4630", Length = "0x827")]
	[Token(Token = "0x60010B2")]
	internal void Add(Cookie cookie, bool throwOnError) { }

	[Address(RVA = "0x26B5A60", Offset = "0x26B4E60", Length = "0x29F")]
	[Token(Token = "0x60010B5")]
	public void Add(CookieCollection cookies) { }

	[Address(RVA = "0x26B50F0", Offset = "0x26B44F0", Length = "0x135")]
	[Token(Token = "0x60010B1")]
	private void AddRemoveDomain(string key, PathList value) { }

	[Address(RVA = "0x26B62C0", Offset = "0x26B56C0", Length = "0xF23")]
	[Token(Token = "0x60010B3")]
	private bool AgeCookies(string domain) { }

	[Address(RVA = "0x26B71F0", Offset = "0x26B65F0", Length = "0x73D")]
	[Token(Token = "0x60010B9")]
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<String> domainAttribute, bool matchOnlyPlainCookie) { }

	[Address(RVA = "0x26B7930", Offset = "0x26B6D30", Length = "0x772")]
	[Token(Token = "0x60010B7")]
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	[Address(RVA = "0x26B80B0", Offset = "0x26B74B0", Length = "0x168")]
	[Token(Token = "0x60010B4")]
	private int ExpireCollection(CookieCollection cc) { }

	[Address(RVA = "0x26B8220", Offset = "0x26B7620", Length = "0xC1")]
	[Token(Token = "0x60010BB")]
	public string GetCookieHeader(Uri uri) { }

	[Address(RVA = "0x26B82F0", Offset = "0x26B76F0", Length = "0x35B")]
	[Token(Token = "0x60010BC")]
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	[Address(RVA = "0x26B8650", Offset = "0x26B7A50", Length = "0x442")]
	[Token(Token = "0x60010B8")]
	internal CookieCollection InternalGetCookies(Uri uri) { }

	[Address(RVA = "0x26B8AA0", Offset = "0x26B7EA0", Length = "0x29D")]
	[Token(Token = "0x60010B6")]
	internal bool IsLocalDomain(string host) { }

	[Address(RVA = "0x26B8D40", Offset = "0x26B8140", Length = "0x1D3")]
	[Token(Token = "0x60010BA")]
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

}

