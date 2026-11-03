namespace System.Net;

[Token(Token = "0x2000299")]
internal class DigestSession
{
	[Token(Token = "0x4000A87")]
	private static RandomNumberGenerator rng; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A88")]
	private DateTime lastUse; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A89")]
	private int _nc; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A8A")]
	private HashAlgorithm hash; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A8B")]
	private DigestHeaderParser parser; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A8C")]
	private string _cnonce; //Field offset: 0x30

	[Token(Token = "0x170003A4")]
	public string Algorithm
	{
		[Address(RVA = "0x26BFC40", Offset = "0x26BF040", Length = "0x30")]
		[Token(Token = "0x600114F")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170003A9")]
	public string CNonce
	{
		[Address(RVA = "0x26BFC80", Offset = "0x26BF080", Length = "0xFB")]
		[Token(Token = "0x6001154")]
		 get { } //Length: 251
	}

	[Token(Token = "0x170003AA")]
	public DateTime LastUse
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600115B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003A6")]
	public string Nonce
	{
		[Address(RVA = "0x26BFD80", Offset = "0x26BF180", Length = "0x30")]
		[Token(Token = "0x6001151")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170003A7")]
	public string Opaque
	{
		[Address(RVA = "0x26BFDC0", Offset = "0x26BF1C0", Length = "0x30")]
		[Token(Token = "0x6001152")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170003A8")]
	public string QOP
	{
		[Address(RVA = "0x26BFE00", Offset = "0x26BF200", Length = "0x30")]
		[Token(Token = "0x6001153")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170003A5")]
	public string Realm
	{
		[Address(RVA = "0x26BFE40", Offset = "0x26BF240", Length = "0x30")]
		[Token(Token = "0x6001150")]
		 get { } //Length: 48
	}

	[Address(RVA = "0x26BFB80", Offset = "0x26BEF80", Length = "0x52")]
	[Token(Token = "0x600114D")]
	private static DigestSession() { }

	[Address(RVA = "0x26BFBE0", Offset = "0x26BEFE0", Length = "0x5C")]
	[Token(Token = "0x600114E")]
	public DigestSession() { }

	[Address(RVA = "0x26BECD0", Offset = "0x26BE0D0", Length = "0x5AE")]
	[Token(Token = "0x600115A")]
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x26BFC40", Offset = "0x26BF040", Length = "0x30")]
	[Token(Token = "0x600114F")]
	public string get_Algorithm() { }

	[Address(RVA = "0x26BFC80", Offset = "0x26BF080", Length = "0xFB")]
	[Token(Token = "0x6001154")]
	public string get_CNonce() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600115B")]
	public DateTime get_LastUse() { }

	[Address(RVA = "0x26BFD80", Offset = "0x26BF180", Length = "0x30")]
	[Token(Token = "0x6001151")]
	public string get_Nonce() { }

	[Address(RVA = "0x26BFDC0", Offset = "0x26BF1C0", Length = "0x30")]
	[Token(Token = "0x6001152")]
	public string get_Opaque() { }

	[Address(RVA = "0x26BFE00", Offset = "0x26BF200", Length = "0x30")]
	[Token(Token = "0x6001153")]
	public string get_QOP() { }

	[Address(RVA = "0x26BFE40", Offset = "0x26BF240", Length = "0x30")]
	[Token(Token = "0x6001150")]
	public string get_Realm() { }

	[Address(RVA = "0x26BF280", Offset = "0x26BE680", Length = "0x15F")]
	[Token(Token = "0x6001157")]
	private string HA1(string username, string password) { }

	[Address(RVA = "0x26BF3E0", Offset = "0x26BE7E0", Length = "0xF0")]
	[Token(Token = "0x6001158")]
	private string HA2(HttpWebRequest webRequest) { }

	[Address(RVA = "0x26BF4E0", Offset = "0x26BE8E0", Length = "0x169")]
	[Token(Token = "0x6001156")]
	private string HashToHexString(string toBeHashed) { }

	[Address(RVA = "0x26BF650", Offset = "0x26BEA50", Length = "0x1B6")]
	[Token(Token = "0x6001155")]
	public bool Parse(string challenge) { }

	[Address(RVA = "0x26BF810", Offset = "0x26BEC10", Length = "0x36B")]
	[Token(Token = "0x6001159")]
	private string Response(string username, string password, HttpWebRequest webRequest) { }

}

