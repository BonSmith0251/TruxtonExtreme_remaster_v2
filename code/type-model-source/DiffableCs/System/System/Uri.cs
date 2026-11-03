namespace System;

[Token(Token = "0x20000B9")]
[TypeConverter(typeof(UriTypeConverter))]
public class Uri : ISerializable
{
	[Flags]
	[Token(Token = "0x20000BE")]
	private enum Check : int
	{
		None = 0,
		EscapedCanonical = 1,
		DisplayCanonical = 2,
		DotSlashAttn = 4,
		DotSlashEscaped = 128,
		BackslashInPath = 16,
		ReservedFound = 32,
		NotIriCanonical = 64,
		FoundNonAscii = 8,
	}

	[Flags]
	[Token(Token = "0x20000BA")]
	private enum Flags : ulong
	{
		Zero = 0,
		SchemeNotCanonical = 1,
		UserNotCanonical = 2,
		HostNotCanonical = 4,
		PortNotCanonical = 8,
		PathNotCanonical = 16,
		QueryNotCanonical = 32,
		FragmentNotCanonical = 64,
		CannotDisplayCanonical = 127,
		E_UserNotCanonical = 128,
		E_HostNotCanonical = 256,
		E_PortNotCanonical = 512,
		E_PathNotCanonical = 1024,
		E_QueryNotCanonical = 2048,
		E_FragmentNotCanonical = 4096,
		E_CannotDisplayCanonical = 8064,
		ShouldBeCompressed = 8192,
		FirstSlashAbsent = 16384,
		BackslashInPath = 32768,
		IndexMask = 65535,
		HostTypeMask = 458752,
		HostNotParsed = 0,
		IPv6HostType = 65536,
		IPv4HostType = 131072,
		DnsHostType = 196608,
		UncHostType = 262144,
		BasicHostType = 327680,
		UnusedHostType = 393216,
		UnknownHostType = 458752,
		UserEscaped = 524288,
		AuthorityFound = 1048576,
		HasUserInfo = 2097152,
		LoopbackHost = 4194304,
		NotDefaultPort = 8388608,
		UserDrivenParsing = 16777216,
		CanonicalDnsHost = 33554432,
		ErrorOrParsingRecursion = 67108864,
		DosPath = 134217728,
		UncPath = 268435456,
		ImplicitFile = 536870912,
		MinimalUriInfoSet = 1073741824,
		AllUriInfoSet = 2147483648,
		IdnHost = 4294967296,
		HasUnicode = 8589934592,
		HostUnicodeNormalized = 17179869184,
		RestUnicodeNormalized = 34359738368,
		UnicodeHost = 68719476736,
		IntranetUri = 137438953472,
		UseOrigUncdStrOffset = 274877906944,
		UserIriCanonical = 549755813888,
		PathIriCanonical = 1099511627776,
		QueryIriCanonical = 2199023255552,
		FragmentIriCanonical = 4398046511104,
		IriCanonical = 8246337208320,
		CompressedSlashes = 17592186044416,
	}

	[Token(Token = "0x20000BD")]
	private class MoreInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002A3")]
		public string Path; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002A4")]
		public string Query; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002A5")]
		public string Fragment; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002A6")]
		public string AbsoluteUri; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002A7")]
		public int Hash; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002A8")]
		public string RemoteUrl; //Field offset: 0x38

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60003F7")]
		public MoreInfo() { }

	}

	[Token(Token = "0x20000BC")]
	private struct Offset
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029B")]
		public ushort Scheme; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x400029C")]
		public ushort User; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400029D")]
		public ushort Host; //Field offset: 0x4
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x400029E")]
		public ushort PortValue; //Field offset: 0x6
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400029F")]
		public ushort Path; //Field offset: 0x8
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x40002A0")]
		public ushort Query; //Field offset: 0xA
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40002A1")]
		public ushort Fragment; //Field offset: 0xC
		[FieldOffset(Offset = "0xE")]
		[Token(Token = "0x40002A2")]
		public ushort End; //Field offset: 0xE

	}

	[Token(Token = "0x20000BB")]
	private class UriInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000295")]
		public string Host; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000296")]
		public string ScopeId; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000297")]
		public string String; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000298")]
		public Offset Offset; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000299")]
		public string DnsSafeHost; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400029A")]
		public MoreInfo MoreInfo; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60003F6")]
		public UriInfo() { }

	}

	[Token(Token = "0x4000239")]
	public static readonly string UriSchemeFile; //Field offset: 0x0
	[Token(Token = "0x4000255")]
	private const UriKind DotNetRelativeOrAbsolute = 300; //Field offset: 0x0
	[Token(Token = "0x4000258")]
	private const UriFormat V1ToStringUnescape = 32767; //Field offset: 0x0
	[Token(Token = "0x4000259")]
	internal const char c_DummyChar = '\uFFFF'; //Field offset: 0x0
	[Token(Token = "0x400025A")]
	internal const char c_EOL = '\uFFFE'; //Field offset: 0x0
	[Token(Token = "0x4000248")]
	private const int c_MaxUriSchemeName = 1024; //Field offset: 0x0
	[Token(Token = "0x4000247")]
	internal const int c_MaxUriBufferSize = 65520; //Field offset: 0x0
	[Token(Token = "0x4000246")]
	private const int c_Max16BitUtf8SequenceLength = 12; //Field offset: 0x0
	[Token(Token = "0x400023A")]
	public static readonly string UriSchemeFtp; //Field offset: 0x8
	[Token(Token = "0x400023B")]
	public static readonly string UriSchemeGopher; //Field offset: 0x10
	[Token(Token = "0x400023C")]
	public static readonly string UriSchemeHttp; //Field offset: 0x18
	[Token(Token = "0x400023D")]
	public static readonly string UriSchemeHttps; //Field offset: 0x20
	[Token(Token = "0x400023E")]
	internal static readonly string UriSchemeWs; //Field offset: 0x28
	[Token(Token = "0x400023F")]
	internal static readonly string UriSchemeWss; //Field offset: 0x30
	[Token(Token = "0x4000240")]
	public static readonly string UriSchemeMailto; //Field offset: 0x38
	[Token(Token = "0x4000241")]
	public static readonly string UriSchemeNews; //Field offset: 0x40
	[Token(Token = "0x4000242")]
	public static readonly string UriSchemeNntp; //Field offset: 0x48
	[Token(Token = "0x4000243")]
	public static readonly string UriSchemeNetTcp; //Field offset: 0x50
	[Token(Token = "0x4000244")]
	public static readonly string UriSchemeNetPipe; //Field offset: 0x58
	[Token(Token = "0x4000245")]
	public static readonly string SchemeDelimiter; //Field offset: 0x60
	[Token(Token = "0x4000250")]
	private static bool s_ConfigInitialized; //Field offset: 0x68
	[Token(Token = "0x4000251")]
	private static bool s_ConfigInitializing; //Field offset: 0x69
	[Token(Token = "0x4000252")]
	private static UriIdnScope s_IdnScope; //Field offset: 0x6C
	[Token(Token = "0x4000253")]
	private static bool s_IriParsing; //Field offset: 0x70
	[Token(Token = "0x4000254")]
	private static bool useDotNetRelativeOrAbsolute; //Field offset: 0x71
	[Token(Token = "0x4000256")]
	internal static readonly bool IsWindowsFileSystem; //Field offset: 0x72
	[Token(Token = "0x4000257")]
	private static object s_initLock; //Field offset: 0x78
	[Token(Token = "0x400025B")]
	internal static readonly Char[] HexLowerChars; //Field offset: 0x80
	[Token(Token = "0x400025C")]
	private static readonly Char[] _WSchars; //Field offset: 0x88
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000249")]
	private string m_String; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024A")]
	private string m_originalUnicodeString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400024B")]
	private UriParser m_Syntax; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400024C")]
	private string m_DnsSafeHost; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400024D")]
	private Flags m_Flags; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400024E")]
	private UriInfo m_Info; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400024F")]
	private bool m_iriParsing; //Field offset: 0x40

	[Token(Token = "0x17000090")]
	public string AbsolutePath
	{
		[Address(RVA = "0x25C43F0", Offset = "0x25C37F0", Length = "0xC2")]
		[Token(Token = "0x6000396")]
		 get { } //Length: 194
	}

	[Token(Token = "0x17000092")]
	public string AbsoluteUri
	{
		[Address(RVA = "0x25C44C0", Offset = "0x25C38C0", Length = "0x146")]
		[Token(Token = "0x6000398")]
		 get { } //Length: 326
	}

	[Token(Token = "0x1700008D")]
	private bool AllowIdn
	{
		[Address(RVA = "0x25C4610", Offset = "0x25C3A10", Length = "0xE5")]
		[Token(Token = "0x600037F")]
		private get { } //Length: 229
	}

	[Token(Token = "0x17000094")]
	public string Authority
	{
		[Address(RVA = "0x25C4700", Offset = "0x25C3B00", Length = "0x8B")]
		[Token(Token = "0x600039A")]
		 get { } //Length: 139
	}

	[Token(Token = "0x170000A4")]
	public string DnsSafeHost
	{
		[Address(RVA = "0x25C4790", Offset = "0x25C3B90", Length = "0x308")]
		[Token(Token = "0x60003AD")]
		 get { } //Length: 776
	}

	[Token(Token = "0x170000A0")]
	public string Fragment
	{
		[Address(RVA = "0x25C4AA0", Offset = "0x25C3EA0", Length = "0x146")]
		[Token(Token = "0x60003A9")]
		 get { } //Length: 326
	}

	[Token(Token = "0x170000A8")]
	internal bool HasAuthority
	{
		[Address(RVA = "0x25C4BF0", Offset = "0x25C3FF0", Length = "0xD")]
		[Token(Token = "0x60003D9")]
		internal get { } //Length: 13
	}

	[Token(Token = "0x1700009C")]
	public string Host
	{
		[Address(RVA = "0x25C4D60", Offset = "0x25C4160", Length = "0x8B")]
		[Token(Token = "0x60003A2")]
		 get { } //Length: 139
	}

	[Token(Token = "0x17000095")]
	public UriHostNameType HostNameType
	{
		[Address(RVA = "0x25C4C00", Offset = "0x25C4000", Length = "0x14C")]
		[Token(Token = "0x600039B")]
		 get { } //Length: 332
	}

	[Token(Token = "0x1700008A")]
	private Flags HostType
	{
		[Address(RVA = "0x25C4D50", Offset = "0x25C4150", Length = "0x9")]
		[Token(Token = "0x600037B")]
		private get { } //Length: 9
	}

	[Token(Token = "0x1700009D")]
	private static object InitializeLock
	{
		[Address(RVA = "0x25C4DF0", Offset = "0x25C41F0", Length = "0xEA")]
		[Token(Token = "0x60003A4")]
		private get { } //Length: 234
	}

	[Token(Token = "0x170000A5")]
	public bool IsAbsoluteUri
	{
		[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
		[Token(Token = "0x60003AE")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000096")]
	public bool IsDefaultPort
	{
		[Address(RVA = "0x25C4EE0", Offset = "0x25C42E0", Length = "0xF8")]
		[Token(Token = "0x600039C")]
		 get { } //Length: 248
	}

	[Token(Token = "0x17000088")]
	private bool IsDosPath
	{
		[Address(RVA = "0x25C4FE0", Offset = "0x25C43E0", Length = "0xD")]
		[Token(Token = "0x6000379")]
		private get { } //Length: 13
	}

	[Token(Token = "0x17000097")]
	public bool IsFile
	{
		[Address(RVA = "0x25C4FF0", Offset = "0x25C43F0", Length = "0xC5")]
		[Token(Token = "0x600039D")]
		 get { } //Length: 197
	}

	[Token(Token = "0x17000086")]
	private bool IsImplicitFile
	{
		[Address(RVA = "0x25C50C0", Offset = "0x25C44C0", Length = "0xD")]
		[Token(Token = "0x6000377")]
		private get { } //Length: 13
	}

	[Token(Token = "0x17000098")]
	public bool IsLoopback
	{
		[Address(RVA = "0x25C50D0", Offset = "0x25C44D0", Length = "0xBA")]
		[Token(Token = "0x600039E")]
		 get { } //Length: 186
	}

	[Token(Token = "0x1700008C")]
	private bool IsNotAbsoluteUri
	{
		[Address(RVA = "0x17D6B30", Offset = "0x17D5F30", Length = "0x9")]
		[Token(Token = "0x600037D")]
		private get { } //Length: 9
	}

	[Token(Token = "0x1700009B")]
	public bool IsUnc
	{
		[Address(RVA = "0x25C51B0", Offset = "0x25C45B0", Length = "0x85")]
		[Token(Token = "0x60003A1")]
		 get { } //Length: 133
	}

	[Token(Token = "0x17000087")]
	private bool IsUncOrDosPath
	{
		[Address(RVA = "0x25C5190", Offset = "0x25C4590", Length = "0xD")]
		[Token(Token = "0x6000378")]
		private get { } //Length: 13
	}

	[Token(Token = "0x17000089")]
	private bool IsUncPath
	{
		[Address(RVA = "0x25C51A0", Offset = "0x25C45A0", Length = "0xD")]
		[Token(Token = "0x600037A")]
		private get { } //Length: 13
	}

	[Token(Token = "0x17000093")]
	public string LocalPath
	{
		[Address(RVA = "0x25C5240", Offset = "0x25C4640", Length = "0x7F")]
		[Token(Token = "0x6000399")]
		 get { } //Length: 127
	}

	[Token(Token = "0x170000A3")]
	public string OriginalString
	{
		[Address(RVA = "0x25C5320", Offset = "0x25C4720", Length = "0x5E")]
		[Token(Token = "0x60003AC")]
		 get { } //Length: 94
	}

	[Token(Token = "0x170000A2")]
	private bool OriginalStringSwitched
	{
		[Address(RVA = "0x25C52C0", Offset = "0x25C46C0", Length = "0x5F")]
		[Token(Token = "0x60003AB")]
		private get { } //Length: 95
	}

	[Token(Token = "0x17000099")]
	public string PathAndQuery
	{
		[Address(RVA = "0x25C5380", Offset = "0x25C4780", Length = "0xCE")]
		[Token(Token = "0x600039F")]
		 get { } //Length: 206
	}

	[Token(Token = "0x1700009E")]
	public int Port
	{
		[Address(RVA = "0x25C5450", Offset = "0x25C4850", Length = "0x108")]
		[Token(Token = "0x60003A7")]
		 get { } //Length: 264
	}

	[Token(Token = "0x17000091")]
	private string PrivateAbsolutePath
	{
		[Address(RVA = "0x25C5560", Offset = "0x25C4960", Length = "0xE0")]
		[Token(Token = "0x6000397")]
		private get { } //Length: 224
	}

	[Token(Token = "0x1700009F")]
	public string Query
	{
		[Address(RVA = "0x25C5650", Offset = "0x25C4A50", Length = "0x146")]
		[Token(Token = "0x60003A8")]
		 get { } //Length: 326
	}

	[Token(Token = "0x170000A1")]
	public string Scheme
	{
		[Address(RVA = "0x25C57A0", Offset = "0x25C4BA0", Length = "0x81")]
		[Token(Token = "0x60003AA")]
		 get { } //Length: 129
	}

	[Token(Token = "0x1700008F")]
	private ushort SecuredPathIndex
	{
		[Address(RVA = "0x25C5830", Offset = "0x25C4C30", Length = "0x54")]
		[Token(Token = "0x6000384")]
		private get { } //Length: 84
	}

	[Token(Token = "0x1700009A")]
	public String[] Segments
	{
		[Address(RVA = "0x25C5890", Offset = "0x25C4C90", Length = "0x1FA")]
		[Token(Token = "0x60003A0")]
		 get { } //Length: 506
	}

	[Token(Token = "0x1700008B")]
	private UriParser Syntax
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600037C")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700008E")]
	internal bool UserDrivenParsing
	{
		[Address(RVA = "0x25C5A90", Offset = "0x25C4E90", Length = "0xD")]
		[Token(Token = "0x6000382")]
		internal get { } //Length: 13
	}

	[Token(Token = "0x170000A6")]
	public bool UserEscaped
	{
		[Address(RVA = "0x25C5AA0", Offset = "0x25C4EA0", Length = "0xD")]
		[Token(Token = "0x60003AF")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170000A7")]
	public string UserInfo
	{
		[Address(RVA = "0x25C5AB0", Offset = "0x25C4EB0", Length = "0x8B")]
		[Token(Token = "0x60003B0")]
		 get { } //Length: 139
	}

	[Address(RVA = "0x25C3640", Offset = "0x25C2A40", Length = "0x5CF")]
	[Token(Token = "0x60003F5")]
	private static Uri() { }

	[Address(RVA = "0x25C41A0", Offset = "0x25C35A0", Length = "0x24F")]
	[Token(Token = "0x6000393")]
	protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x25C40B0", Offset = "0x25C34B0", Length = "0xE6")]
	[Token(Token = "0x600038E")]
	public Uri(Uri baseUri, string relativeUri) { }

	[Address(RVA = "0x25C3C10", Offset = "0x25C3010", Length = "0x96")]
	[Token(Token = "0x600038D")]
	public Uri(string uriString, UriKind uriKind) { }

	[Address(RVA = "0x25C3F20", Offset = "0x25C3320", Length = "0x123")]
	[Token(Token = "0x600038C")]
	public Uri(string uriString) { }

	[Address(RVA = "0x25C3CB0", Offset = "0x25C30B0", Length = "0x26B")]
	[Token(Token = "0x6000390")]
	public Uri(Uri baseUri, Uri relativeUri) { }

	[Address(RVA = "0x25C4050", Offset = "0x25C3450", Length = "0x5F")]
	[Token(Token = "0x60003ED")]
	private Uri(Flags flags, UriParser uriParser, string uri) { }

	[Address(RVA = "0x25B4FA0", Offset = "0x25B43A0", Length = "0xF1")]
	[Token(Token = "0x6000380")]
	private bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	[Address(RVA = "0x25B50A0", Offset = "0x25B44A0", Length = "0xA3")]
	[Token(Token = "0x60003D6")]
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	[Address(RVA = "0x25B59C0", Offset = "0x25B4DC0", Length = "0x102F")]
	[Token(Token = "0x60003CD")]
	private ushort CheckAuthorityHelper(Char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost) { }

	[Address(RVA = "0x25B5150", Offset = "0x25B4550", Length = "0x30B")]
	[Token(Token = "0x60003CF")]
	private void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err) { }

	[Address(RVA = "0x25B5460", Offset = "0x25B4860", Length = "0x552")]
	[Token(Token = "0x60003CE")]
	private void CheckAuthorityHelperHandleDnsIri(Char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	[Address(RVA = "0x25B6A00", Offset = "0x25B5E00", Length = "0x3E8")]
	[Token(Token = "0x60003D2")]
	private Check CheckCanonical(Char* str, ref ushort idx, ushort end, char delim) { }

	[Address(RVA = "0x25B6DF0", Offset = "0x25B61F0", Length = "0xA3")]
	[Token(Token = "0x60003BA")]
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	[Address(RVA = "0x25B6EA0", Offset = "0x25B62A0", Length = "0xB2")]
	[Token(Token = "0x60003E1")]
	private bool CheckForConfigLoad(string data) { }

	[Address(RVA = "0x25B6F60", Offset = "0x25B6360", Length = "0x199")]
	[Token(Token = "0x60003E3")]
	private bool CheckForEscapedUnreserved(string data) { }

	[Address(RVA = "0x25B7100", Offset = "0x25B6500", Length = "0x13B")]
	[Token(Token = "0x60003E2")]
	private bool CheckForUnicode(string data) { }

	[Address(RVA = "0x25B7240", Offset = "0x25B6640", Length = "0x520")]
	[Token(Token = "0x60003CB")]
	private static bool CheckKnownSchemes(Int64* lptr, ushort nChars, ref UriParser syntax) { }

	[Address(RVA = "0x25B7760", Offset = "0x25B6B60", Length = "0x11B")]
	[Token(Token = "0x60003CC")]
	private static ParsingError CheckSchemeSyntax(Char* ptr, ushort length, ref UriParser syntax) { }

	[Address(RVA = "0x25B7880", Offset = "0x25B6C80", Length = "0x9E2")]
	[Token(Token = "0x60003D7")]
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	[Address(RVA = "0x25B8270", Offset = "0x25B7670", Length = "0x4B2")]
	[Token(Token = "0x60003D5")]
	private static Char[] Compress(Char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	[Address(RVA = "0x25B8730", Offset = "0x25B7B30", Length = "0x2DC")]
	[Token(Token = "0x60003EE")]
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	[Address(RVA = "0x25B8C10", Offset = "0x25B8010", Length = "0x473")]
	[Token(Token = "0x60003C1")]
	private void CreateHostString() { }

	[Address(RVA = "0x25B8A10", Offset = "0x25B7E10", Length = "0x1FF")]
	[Token(Token = "0x60003C2")]
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId) { }

	[Address(RVA = "0x25B9240", Offset = "0x25B8640", Length = "0x1D0")]
	[Token(Token = "0x60003DF")]
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	[Address(RVA = "0x25B9090", Offset = "0x25B8490", Length = "0x1A3")]
	[Token(Token = "0x60003F4")]
	private void CreateThisFromUri(Uri otherUri) { }

	[Address(RVA = "0x25B99C0", Offset = "0x25B8DC0", Length = "0x329")]
	[Token(Token = "0x600038F")]
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	[Address(RVA = "0x25B9420", Offset = "0x25B8820", Length = "0x59D")]
	[Token(Token = "0x60003C0")]
	private void CreateUriInfo(Flags cF) { }

	[Address(RVA = "0x25B9CF0", Offset = "0x25B90F0", Length = "0x60")]
	[Token(Token = "0x600038B")]
	private void EnsureHostString(bool allowDnsOptimization) { }

	[Address(RVA = "0x25B9D60", Offset = "0x25B9160", Length = "0x12")]
	[Token(Token = "0x600038A")]
	private void EnsureParseRemaining() { }

	[Address(RVA = "0x25B9D80", Offset = "0x25B9180", Length = "0x33")]
	[Token(Token = "0x6000389")]
	private UriInfo EnsureUriInfo() { }

	[Address(RVA = "0x25B9DC0", Offset = "0x25B91C0", Length = "0x73F")]
	[Token(Token = "0x60003B8")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x25BA500", Offset = "0x25B9900", Length = "0x54")]
	[Token(Token = "0x60003EC")]
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	[Address(RVA = "0x25BA560", Offset = "0x25B9960", Length = "0xA0")]
	[Token(Token = "0x60003D1")]
	private void FindEndOfComponent(Char* str, ref ushort idx, ushort end, char delim) { }

	[Address(RVA = "0x25BA600", Offset = "0x25B9A00", Length = "0xAF")]
	[Token(Token = "0x60003D0")]
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	[Address(RVA = "0x25BA6B0", Offset = "0x25B9AB0", Length = "0x9D")]
	[Token(Token = "0x60003B3")]
	public static int FromHex(char digit) { }

	[Address(RVA = "0x25C43F0", Offset = "0x25C37F0", Length = "0xC2")]
	[Token(Token = "0x6000396")]
	public string get_AbsolutePath() { }

	[Address(RVA = "0x25C44C0", Offset = "0x25C38C0", Length = "0x146")]
	[Token(Token = "0x6000398")]
	public string get_AbsoluteUri() { }

	[Address(RVA = "0x25C4610", Offset = "0x25C3A10", Length = "0xE5")]
	[Token(Token = "0x600037F")]
	private bool get_AllowIdn() { }

	[Address(RVA = "0x25C4700", Offset = "0x25C3B00", Length = "0x8B")]
	[Token(Token = "0x600039A")]
	public string get_Authority() { }

	[Address(RVA = "0x25C4790", Offset = "0x25C3B90", Length = "0x308")]
	[Token(Token = "0x60003AD")]
	public string get_DnsSafeHost() { }

	[Address(RVA = "0x25C4AA0", Offset = "0x25C3EA0", Length = "0x146")]
	[Token(Token = "0x60003A9")]
	public string get_Fragment() { }

	[Address(RVA = "0x25C4BF0", Offset = "0x25C3FF0", Length = "0xD")]
	[Token(Token = "0x60003D9")]
	internal bool get_HasAuthority() { }

	[Address(RVA = "0x25C4D60", Offset = "0x25C4160", Length = "0x8B")]
	[Token(Token = "0x60003A2")]
	public string get_Host() { }

	[Address(RVA = "0x25C4C00", Offset = "0x25C4000", Length = "0x14C")]
	[Token(Token = "0x600039B")]
	public UriHostNameType get_HostNameType() { }

	[Address(RVA = "0x25C4D50", Offset = "0x25C4150", Length = "0x9")]
	[Token(Token = "0x600037B")]
	private Flags get_HostType() { }

	[Address(RVA = "0x25C4DF0", Offset = "0x25C41F0", Length = "0xEA")]
	[Token(Token = "0x60003A4")]
	private static object get_InitializeLock() { }

	[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
	[Token(Token = "0x60003AE")]
	public bool get_IsAbsoluteUri() { }

	[Address(RVA = "0x25C4EE0", Offset = "0x25C42E0", Length = "0xF8")]
	[Token(Token = "0x600039C")]
	public bool get_IsDefaultPort() { }

	[Address(RVA = "0x25C4FE0", Offset = "0x25C43E0", Length = "0xD")]
	[Token(Token = "0x6000379")]
	private bool get_IsDosPath() { }

	[Address(RVA = "0x25C4FF0", Offset = "0x25C43F0", Length = "0xC5")]
	[Token(Token = "0x600039D")]
	public bool get_IsFile() { }

	[Address(RVA = "0x25C50C0", Offset = "0x25C44C0", Length = "0xD")]
	[Token(Token = "0x6000377")]
	private bool get_IsImplicitFile() { }

	[Address(RVA = "0x25C50D0", Offset = "0x25C44D0", Length = "0xBA")]
	[Token(Token = "0x600039E")]
	public bool get_IsLoopback() { }

	[Address(RVA = "0x17D6B30", Offset = "0x17D5F30", Length = "0x9")]
	[Token(Token = "0x600037D")]
	private bool get_IsNotAbsoluteUri() { }

	[Address(RVA = "0x25C51B0", Offset = "0x25C45B0", Length = "0x85")]
	[Token(Token = "0x60003A1")]
	public bool get_IsUnc() { }

	[Address(RVA = "0x25C5190", Offset = "0x25C4590", Length = "0xD")]
	[Token(Token = "0x6000378")]
	private bool get_IsUncOrDosPath() { }

	[Address(RVA = "0x25C51A0", Offset = "0x25C45A0", Length = "0xD")]
	[Token(Token = "0x600037A")]
	private bool get_IsUncPath() { }

	[Address(RVA = "0x25C5240", Offset = "0x25C4640", Length = "0x7F")]
	[Token(Token = "0x6000399")]
	public string get_LocalPath() { }

	[Address(RVA = "0x25C5320", Offset = "0x25C4720", Length = "0x5E")]
	[Token(Token = "0x60003AC")]
	public string get_OriginalString() { }

	[Address(RVA = "0x25C52C0", Offset = "0x25C46C0", Length = "0x5F")]
	[Token(Token = "0x60003AB")]
	private bool get_OriginalStringSwitched() { }

	[Address(RVA = "0x25C5380", Offset = "0x25C4780", Length = "0xCE")]
	[Token(Token = "0x600039F")]
	public string get_PathAndQuery() { }

	[Address(RVA = "0x25C5450", Offset = "0x25C4850", Length = "0x108")]
	[Token(Token = "0x60003A7")]
	public int get_Port() { }

	[Address(RVA = "0x25C5560", Offset = "0x25C4960", Length = "0xE0")]
	[Token(Token = "0x6000397")]
	private string get_PrivateAbsolutePath() { }

	[Address(RVA = "0x25C5650", Offset = "0x25C4A50", Length = "0x146")]
	[Token(Token = "0x60003A8")]
	public string get_Query() { }

	[Address(RVA = "0x25C57A0", Offset = "0x25C4BA0", Length = "0x81")]
	[Token(Token = "0x60003AA")]
	public string get_Scheme() { }

	[Address(RVA = "0x25C5830", Offset = "0x25C4C30", Length = "0x54")]
	[Token(Token = "0x6000384")]
	private ushort get_SecuredPathIndex() { }

	[Address(RVA = "0x25C5890", Offset = "0x25C4C90", Length = "0x1FA")]
	[Token(Token = "0x60003A0")]
	public String[] get_Segments() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600037C")]
	private UriParser get_Syntax() { }

	[Address(RVA = "0x25C5A90", Offset = "0x25C4E90", Length = "0xD")]
	[Token(Token = "0x6000382")]
	internal bool get_UserDrivenParsing() { }

	[Address(RVA = "0x25C5AA0", Offset = "0x25C4EA0", Length = "0xD")]
	[Token(Token = "0x60003AF")]
	public bool get_UserEscaped() { }

	[Address(RVA = "0x25C5AB0", Offset = "0x25C4EB0", Length = "0x8B")]
	[Token(Token = "0x60003B0")]
	public string get_UserInfo() { }

	[Address(RVA = "0x25BA750", Offset = "0x25B9B50", Length = "0x7A0")]
	[Token(Token = "0x60003D3")]
	private Char[] GetCanonicalPath(Char[] dest, ref int pos, UriFormat formatAs) { }

	[Address(RVA = "0x25BAF00", Offset = "0x25BA300", Length = "0x216")]
	[Token(Token = "0x6000391")]
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	[Address(RVA = "0x25BB430", Offset = "0x25BA830", Length = "0x1F5")]
	[Token(Token = "0x60003E7")]
	public string GetComponents(UriComponents components, UriFormat format) { }

	[Address(RVA = "0x25BB120", Offset = "0x25BA520", Length = "0x30F")]
	[Token(Token = "0x60003F1")]
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	[Address(RVA = "0x25BB630", Offset = "0x25BAA30", Length = "0xEA")]
	[Token(Token = "0x60003C5")]
	private string GetEscapedParts(UriComponents uriParts) { }

	[Address(RVA = "0x25BB720", Offset = "0x25BAB20", Length = "0x170")]
	[Token(Token = "0x6000392")]
	private static UriFormatException GetException(ParsingError err) { }

	[Address(RVA = "0x25BB8D0", Offset = "0x25BACD0", Length = "0x1AE")]
	[Token(Token = "0x60003B4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x25BBA80", Offset = "0x25BAE80", Length = "0x4AB")]
	[Token(Token = "0x60003C3")]
	private void GetHostViaCustomSyntax() { }

	[Address(RVA = "0x25BBF30", Offset = "0x25BB330", Length = "0x85A")]
	[Token(Token = "0x60003A6")]
	private string GetLocalPath() { }

	[Address(RVA = "0x25BC790", Offset = "0x25BBB90", Length = "0xDF")]
	[Token(Token = "0x6000395")]
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x25BC870", Offset = "0x25BBC70", Length = "0x8")]
	[Token(Token = "0x60003C4")]
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	[Address(RVA = "0x25BC880", Offset = "0x25BBC80", Length = "0x3DA")]
	[Token(Token = "0x60003F0")]
	private string GetRelativeSerializationString(UriFormat format) { }

	[Address(RVA = "0x25BCC60", Offset = "0x25BC060", Length = "0xCB")]
	[Token(Token = "0x60003C6")]
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	[Address(RVA = "0x25BCD30", Offset = "0x25BC130", Length = "0x8D6")]
	[Token(Token = "0x60003C8")]
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	[Address(RVA = "0x25BD610", Offset = "0x25BCA10", Length = "0x8")]
	[Token(Token = "0x6000386")]
	private bool InFact(Flags flags) { }

	[Address(RVA = "0x25BD890", Offset = "0x25BCC90", Length = "0xB22")]
	[Token(Token = "0x60003E0")]
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	[Address(RVA = "0x25BD620", Offset = "0x25BCA20", Length = "0x262")]
	[Token(Token = "0x60003A5")]
	private static void InitializeUriConfig() { }

	[Address(RVA = "0x25BE3C0", Offset = "0x25BD7C0", Length = "0xDB")]
	[Token(Token = "0x60003BB")]
	internal static string InternalEscapeString(string rawString) { }

	[Address(RVA = "0x25BE4A0", Offset = "0x25BD8A0", Length = "0x4CA")]
	[Token(Token = "0x60003EA")]
	internal bool InternalIsWellFormedOriginalString() { }

	[Address(RVA = "0x25BE970", Offset = "0x25BDD70", Length = "0xA0")]
	[Token(Token = "0x600037E")]
	internal static bool IriParsingStatic(UriParser syntax) { }

	[Address(RVA = "0x25BEA90", Offset = "0x25BDE90", Length = "0x1D")]
	[Token(Token = "0x60003DB")]
	private static bool IsAsciiLetter(char character) { }

	[Address(RVA = "0x25BEA10", Offset = "0x25BDE10", Length = "0x72")]
	[Token(Token = "0x60003DC")]
	internal static bool IsAsciiLetterOrDigit(char character) { }

	[Address(RVA = "0x25BED10", Offset = "0x25BE110", Length = "0xC3")]
	[Token(Token = "0x60003F2")]
	public bool IsBaseOf(Uri uri) { }

	[Address(RVA = "0x25BEAB0", Offset = "0x25BDEB0", Length = "0x25C")]
	[Token(Token = "0x60003F3")]
	internal bool IsBaseOfHelper(Uri uriLink) { }

	[Address(RVA = "0x25BEDE0", Offset = "0x25BE1E0", Length = "0x31")]
	[Token(Token = "0x60003DD")]
	internal static bool IsBidiControlCharacter(char ch) { }

	[Address(RVA = "0x25BEE20", Offset = "0x25BE220", Length = "0x24")]
	[Token(Token = "0x60003B1")]
	internal static bool IsGenDelim(char ch) { }

	[Address(RVA = "0x25BEE50", Offset = "0x25BE250", Length = "0x26")]
	[Token(Token = "0x60003B2")]
	public static bool IsHexDigit(char character) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000381")]
	private bool IsIntranet(string schemeHost) { }

	[Address(RVA = "0x25BEE80", Offset = "0x25BE280", Length = "0x24")]
	[Token(Token = "0x60003DA")]
	private static bool IsLWS(char ch) { }

	[Address(RVA = "0x25BEEB0", Offset = "0x25BE2B0", Length = "0x4C")]
	[Token(Token = "0x60003E8")]
	public bool IsWellFormedOriginalString() { }

	[Address(RVA = "0x25BEF00", Offset = "0x25BE300", Length = "0x161")]
	[Token(Token = "0x60003E9")]
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	[Address(RVA = "0x25BF070", Offset = "0x25BE470", Length = "0x37D")]
	[Token(Token = "0x60003B9")]
	public Uri MakeRelativeUri(Uri uri) { }

	[Address(RVA = "0x25BF3F0", Offset = "0x25BE7F0", Length = "0x8")]
	[Token(Token = "0x6000385")]
	private bool NotAny(Flags flags) { }

	[Address(RVA = "0x25C5B40", Offset = "0x25C4F40", Length = "0x32")]
	[Token(Token = "0x60003B6")]
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	[Address(RVA = "0x25C5B80", Offset = "0x25C4F80", Length = "0x13E")]
	[Token(Token = "0x60003B7")]
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	[Address(RVA = "0x25BF400", Offset = "0x25BE800", Length = "0x76")]
	[Token(Token = "0x60003BD")]
	internal UriFormatException ParseMinimal() { }

	[Address(RVA = "0x25BF480", Offset = "0x25BE880", Length = "0xD86")]
	[Token(Token = "0x60003C9")]
	private void ParseRemaining() { }

	[Address(RVA = "0x25C06D0", Offset = "0x25BFAD0", Length = "0xE4")]
	[Token(Token = "0x60003BC")]
	private static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax) { }

	[Address(RVA = "0x25C0210", Offset = "0x25BF610", Length = "0x4B8")]
	[Token(Token = "0x60003CA")]
	private static ushort ParseSchemeCheckImplicitFile(Char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax) { }

	[Address(RVA = "0x25C07C0", Offset = "0x25BFBC0", Length = "0x29E")]
	[Token(Token = "0x60003D8")]
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	[Address(RVA = "0x25C0B80", Offset = "0x25BFF80", Length = "0x763")]
	[Token(Token = "0x60003BE")]
	private ParsingError PrivateParseMinimal() { }

	[Address(RVA = "0x25C0A60", Offset = "0x25BFE60", Length = "0x114")]
	[Token(Token = "0x60003BF")]
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	[Address(RVA = "0x25C12F0", Offset = "0x25C06F0", Length = "0x11C7")]
	[Token(Token = "0x60003C7")]
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	[Address(RVA = "0x25C24C0", Offset = "0x25C18C0", Length = "0x53E")]
	[Token(Token = "0x60003EF")]
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	[Address(RVA = "0x25C2A00", Offset = "0x25C1E00", Length = "0x12")]
	[Token(Token = "0x6000383")]
	private void SetUserDrivenParsing() { }

	[Address(RVA = "0x25C2A20", Offset = "0x25C1E20", Length = "0x7")]
	[Token(Token = "0x6000388")]
	private static bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	[Address(RVA = "0x25C2A30", Offset = "0x25C1E30", Length = "0x1F")]
	[Token(Token = "0x60003A3")]
	private static bool StaticIsFile(UriParser syntax) { }

	[Address(RVA = "0x25C2A50", Offset = "0x25C1E50", Length = "0x7")]
	[Token(Token = "0x6000387")]
	private static bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	[Address(RVA = "0x25C2A60", Offset = "0x25C1E60", Length = "0x172")]
	[Token(Token = "0x60003DE")]
	internal static string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	[Address(RVA = "0x25BC790", Offset = "0x25BBB90", Length = "0xDF")]
	[Token(Token = "0x6000394")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x25C2BE0", Offset = "0x25C1FE0", Length = "0x117")]
	[Token(Token = "0x60003B5")]
	public virtual string ToString() { }

	[Address(RVA = "0x25C30D0", Offset = "0x25C24D0", Length = "0x1B2")]
	[Token(Token = "0x60003E6")]
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	[Address(RVA = "0x25C2DE0", Offset = "0x25C21E0", Length = "0x2E2")]
	[Token(Token = "0x60003E5")]
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	[Address(RVA = "0x25C2D00", Offset = "0x25C2100", Length = "0xD8")]
	[Token(Token = "0x60003E4")]
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	[Address(RVA = "0x25C3290", Offset = "0x25C2690", Length = "0x1AD")]
	[Token(Token = "0x60003EB")]
	public static string UnescapeDataString(string stringToUnescape) { }

	[Address(RVA = "0x25C3440", Offset = "0x25C2840", Length = "0x1FC")]
	[Token(Token = "0x60003D4")]
	private static void UnescapeOnly(Char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

}

