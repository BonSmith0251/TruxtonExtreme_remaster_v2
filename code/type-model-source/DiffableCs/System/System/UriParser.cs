namespace System;

[Token(Token = "0x20000C8")]
public abstract class UriParser
{
	[Token(Token = "0x20000CA")]
	private class BuiltInUriParser : UriParser
	{

		[Address(RVA = "0x2613E80", Offset = "0x2613280", Length = "0x8C")]
		[Token(Token = "0x6000424")]
		internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

	}

	[Token(Token = "0x20000C9")]
	private enum UriQuirksVersion : int
	{
		V2 = 2,
		V3 = 3,
	}

	[Token(Token = "0x40002EF")]
	private const UriSyntaxFlags SchemeOnlyFlags = 16; //Field offset: 0x0
	[Token(Token = "0x4000316")]
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796; //Field offset: 0x0
	[Token(Token = "0x4000315")]
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565; //Field offset: 0x0
	[Token(Token = "0x4000314")]
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405; //Field offset: 0x0
	[Token(Token = "0x4000313")]
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405; //Field offset: 0x0
	[Token(Token = "0x4000312")]
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536; //Field offset: 0x0
	[Token(Token = "0x4000311")]
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405; //Field offset: 0x0
	[Token(Token = "0x4000310")]
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697; //Field offset: 0x0
	[Token(Token = "0x400030E")]
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533; //Field offset: 0x0
	[Token(Token = "0x400030C")]
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590; //Field offset: 0x0
	[Token(Token = "0x400030B")]
	private const int c_MaxCapacity = 512; //Field offset: 0x0
	[Token(Token = "0x4000317")]
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729; //Field offset: 0x0
	[Token(Token = "0x4000318")]
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737; //Field offset: 0x0
	[Token(Token = "0x40002F0")]
	private static readonly Dictionary<String, UriParser> m_Table; //Field offset: 0x0
	[Token(Token = "0x40002F5")]
	private const UriSyntaxFlags c_UpdatableFlags = 33554432; //Field offset: 0x0
	[Token(Token = "0x40002F8")]
	internal const int NoDefaultPort = -1; //Field offset: 0x0
	[Token(Token = "0x40002F9")]
	private const int c_InitialTableSize = 25; //Field offset: 0x0
	[Token(Token = "0x40002F1")]
	private static Dictionary<String, UriParser> m_TempTable; //Field offset: 0x8
	[Token(Token = "0x40002FA")]
	internal static UriParser HttpUri; //Field offset: 0x10
	[Token(Token = "0x40002FB")]
	internal static UriParser HttpsUri; //Field offset: 0x18
	[Token(Token = "0x40002FC")]
	internal static UriParser WsUri; //Field offset: 0x20
	[Token(Token = "0x40002FD")]
	internal static UriParser WssUri; //Field offset: 0x28
	[Token(Token = "0x40002FE")]
	internal static UriParser FtpUri; //Field offset: 0x30
	[Token(Token = "0x40002FF")]
	internal static UriParser FileUri; //Field offset: 0x38
	[Token(Token = "0x4000300")]
	internal static UriParser GopherUri; //Field offset: 0x40
	[Token(Token = "0x4000301")]
	internal static UriParser NntpUri; //Field offset: 0x48
	[Token(Token = "0x4000302")]
	internal static UriParser NewsUri; //Field offset: 0x50
	[Token(Token = "0x4000303")]
	internal static UriParser MailToUri; //Field offset: 0x58
	[Token(Token = "0x4000304")]
	internal static UriParser UuidUri; //Field offset: 0x60
	[Token(Token = "0x4000305")]
	internal static UriParser TelnetUri; //Field offset: 0x68
	[Token(Token = "0x4000306")]
	internal static UriParser LdapUri; //Field offset: 0x70
	[Token(Token = "0x4000307")]
	internal static UriParser NetTcpUri; //Field offset: 0x78
	[Token(Token = "0x4000308")]
	internal static UriParser NetPipeUri; //Field offset: 0x80
	[Token(Token = "0x4000309")]
	internal static UriParser VsMacrosUri; //Field offset: 0x88
	[Token(Token = "0x400030A")]
	private static readonly UriQuirksVersion s_QuirksVersion; //Field offset: 0x90
	[Token(Token = "0x400030D")]
	private static readonly UriSyntaxFlags HttpSyntaxFlags; //Field offset: 0x94
	[Token(Token = "0x400030F")]
	private static readonly UriSyntaxFlags FileSyntaxFlags; //Field offset: 0x98
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F2")]
	private UriSyntaxFlags m_Flags; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002F3")]
	private UriSyntaxFlags m_UpdatableFlags; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F4")]
	private bool m_UpdatableFlagsUsed; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002F6")]
	private int m_Port; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F7")]
	private string m_Scheme; //Field offset: 0x20

	[Token(Token = "0x170000AA")]
	internal int DefaultPort
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600040B")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170000AC")]
	internal UriSyntaxFlags Flags
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000415")]
		internal get { } //Length: 85
	}

	[Token(Token = "0x170000AD")]
	internal bool IsSimple
	{
		[Address(RVA = "0x2611CB0", Offset = "0x26110B0", Length = "0xB")]
		[Token(Token = "0x600041D")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x170000A9")]
	internal string SchemeName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600040A")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000AB")]
	internal static bool ShouldUseLegacyV2Quirks
	{
		[Address(RVA = "0x2611CC0", Offset = "0x26110C0", Length = "0x55")]
		[Token(Token = "0x6000413")]
		internal get { } //Length: 85
	}

	[Address(RVA = "0x2610F50", Offset = "0x2610350", Length = "0xCCB")]
	[Token(Token = "0x6000414")]
	private static UriParser() { }

	[Address(RVA = "0x2611C70", Offset = "0x2611070", Length = "0x3A")]
	[Token(Token = "0x600040C")]
	protected UriParser() { }

	[Address(RVA = "0x2611C20", Offset = "0x2611020", Length = "0x41")]
	[Token(Token = "0x600041A")]
	internal UriParser(UriSyntaxFlags flags) { }

	[Address(RVA = "0x2610340", Offset = "0x260F740", Length = "0x34B")]
	[Token(Token = "0x600041B")]
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600040B")]
	internal int get_DefaultPort() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000415")]
	internal UriSyntaxFlags get_Flags() { }

	[Address(RVA = "0x2611CB0", Offset = "0x26110B0", Length = "0xB")]
	[Token(Token = "0x600041D")]
	internal bool get_IsSimple() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600040A")]
	internal string get_SchemeName() { }

	[Address(RVA = "0x2611CC0", Offset = "0x26110C0", Length = "0x55")]
	[Token(Token = "0x6000413")]
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	[Address(RVA = "0x2610690", Offset = "0x260FA90", Length = "0x279")]
	[Token(Token = "0x6000411")]
	protected override string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	[Address(RVA = "0x2610910", Offset = "0x260FD10", Length = "0xD9")]
	[Token(Token = "0x600041C")]
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	[Address(RVA = "0x26109F0", Offset = "0x260FDF0", Length = "0x5C")]
	[Token(Token = "0x6000417")]
	internal bool InFact(UriSyntaxFlags flags) { }

	[Address(RVA = "0x2610A50", Offset = "0x260FE50", Length = "0x33")]
	[Token(Token = "0x600040E")]
	protected override void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	[Address(RVA = "0x2610A90", Offset = "0x260FE90", Length = "0x19")]
	[Token(Token = "0x6000422")]
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	[Address(RVA = "0x2610AB0", Offset = "0x260FEB0", Length = "0x14")]
	[Token(Token = "0x6000421")]
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	[Address(RVA = "0x2610AD0", Offset = "0x260FED0", Length = "0x14")]
	[Token(Token = "0x6000423")]
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

	[Address(RVA = "0x2610AF0", Offset = "0x260FEF0", Length = "0x5D")]
	[Token(Token = "0x600041E")]
	internal UriParser InternalOnNewUri() { }

	[Address(RVA = "0x2610B50", Offset = "0x260FF50", Length = "0x19")]
	[Token(Token = "0x6000420")]
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	[Address(RVA = "0x2610B70", Offset = "0x260FF70", Length = "0x14")]
	[Token(Token = "0x600041F")]
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	[Address(RVA = "0x2610B90", Offset = "0x260FF90", Length = "0x5E")]
	[Token(Token = "0x6000418")]
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	[Address(RVA = "0x2610BF0", Offset = "0x260FFF0", Length = "0x26")]
	[Token(Token = "0x6000410")]
	protected override bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	[Address(RVA = "0x2610C20", Offset = "0x2610020", Length = "0x6E")]
	[Token(Token = "0x6000419")]
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	[Address(RVA = "0x2610C90", Offset = "0x2610090", Length = "0x1F")]
	[Token(Token = "0x6000412")]
	protected override bool IsWellFormedOriginalString(Uri uri) { }

	[Address(RVA = "0x2610CB0", Offset = "0x26100B0", Length = "0x5C")]
	[Token(Token = "0x6000416")]
	internal bool NotAny(UriSyntaxFlags flags) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600040D")]
	protected override UriParser OnNewUri() { }

	[Address(RVA = "0x2610D10", Offset = "0x2610110", Length = "0x231")]
	[Token(Token = "0x600040F")]
	protected override string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

}

