namespace Internal.Cryptography;

[Token(Token = "0x20000AC")]
internal static class OidLookup
{
	[CompilerGenerated]
	[Token(Token = "0x20000AD")]
	private sealed class <>c
	{
		[Token(Token = "0x4000207")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x260D740", Offset = "0x260CB40", Length = "0x67")]
		[Token(Token = "0x600033D")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600033E")]
		public <>c() { }

		[Address(RVA = "0x260D6C0", Offset = "0x260CAC0", Length = "0x39")]
		[Token(Token = "0x600033F")]
		internal string <.cctor>b__10_0(KeyValuePair<String, String> kvp) { }

		[Address(RVA = "0x260D700", Offset = "0x260CB00", Length = "0x37")]
		[Token(Token = "0x6000340")]
		internal string <.cctor>b__10_1(KeyValuePair<String, String> kvp) { }

	}

	[Token(Token = "0x4000202")]
	private static readonly ConcurrentDictionary<String, String> s_lateBoundOidToFriendlyName; //Field offset: 0x0
	[Token(Token = "0x4000203")]
	private static readonly ConcurrentDictionary<String, String> s_lateBoundFriendlyNameToOid; //Field offset: 0x8
	[Token(Token = "0x4000204")]
	private static readonly Dictionary<String, String> s_friendlyNameToOid; //Field offset: 0x10
	[Token(Token = "0x4000205")]
	private static readonly Dictionary<String, String> s_oidToFriendlyName; //Field offset: 0x18
	[Token(Token = "0x4000206")]
	private static readonly Dictionary<String, String> s_compatOids; //Field offset: 0x20

	[Address(RVA = "0x260B080", Offset = "0x260A480", Length = "0x1A38")]
	[Token(Token = "0x600033C")]
	private static OidLookup() { }

	[Address(RVA = "0x260A530", Offset = "0x2609930", Length = "0x34E")]
	[Token(Token = "0x600033B")]
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[Address(RVA = "0x260A880", Offset = "0x2609C80", Length = "0x34E")]
	[Token(Token = "0x600033A")]
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000339")]
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	[Address(RVA = "0x260ABD0", Offset = "0x2609FD0", Length = "0x265")]
	[Token(Token = "0x6000337")]
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[Address(RVA = "0x260AE40", Offset = "0x260A240", Length = "0x234")]
	[Token(Token = "0x6000338")]
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

}

