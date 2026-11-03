namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E1")]
public class Regex : ISerializable
{
	[Token(Token = "0x20000E3")]
	public sealed class CachedCodeEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400038A")]
		public CachedCodeEntry Next; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400038B")]
		public CachedCodeEntry Previous; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400038C")]
		public readonly CachedCodeEntryKey Key; //Field offset: 0x20
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400038D")]
		public RegexCode Code; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400038E")]
		public readonly Hashtable Caps; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400038F")]
		public readonly Hashtable Capnames; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000390")]
		public readonly String[] Capslist; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000391")]
		public readonly int Capsize; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000392")]
		public readonly ExclusiveReference Runnerref; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000393")]
		public readonly WeakReference<RegexReplacement> ReplRef; //Field offset: 0x68

		[Address(RVA = "0x2614150", Offset = "0x2613550", Length = "0xC6")]
		[Token(Token = "0x600050B")]
		public CachedCodeEntry(CachedCodeEntryKey key, Hashtable capnames, String[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref) { }

	}

	[IsReadOnly]
	[Token(Token = "0x20000E2")]
	public struct CachedCodeEntryKey : IEquatable<CachedCodeEntryKey>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000387")]
		private readonly RegexOptions _options; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000388")]
		private readonly string _cultureKey; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000389")]
		private readonly string _pattern; //Field offset: 0x10

		[Address(RVA = "0x24F76C0", Offset = "0x24F6AC0", Length = "0x3C")]
		[Token(Token = "0x6000506")]
		public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern) { }

		[Address(RVA = "0x2613F80", Offset = "0x2613380", Length = "0xDC")]
		[Token(Token = "0x6000507")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x2613F10", Offset = "0x2613310", Length = "0x6B")]
		[Token(Token = "0x6000508")]
		public override bool Equals(CachedCodeEntryKey other) { }

		[Address(RVA = "0x2614060", Offset = "0x2613460", Length = "0x68")]
		[Token(Token = "0x600050A")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x26140D0", Offset = "0x26134D0", Length = "0x77")]
		[Token(Token = "0x6000509")]
		public static bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	}

	[Token(Token = "0x4000370")]
	private const int CacheDictionarySwitchLimit = 10; //Field offset: 0x0
	[Token(Token = "0x4000377")]
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT"; //Field offset: 0x0
	[Token(Token = "0x400037B")]
	internal const int MaxOptionShift = 10; //Field offset: 0x0
	[Token(Token = "0x4000371")]
	private static int s_cacheSize; //Field offset: 0x0
	[Token(Token = "0x4000372")]
	private static readonly Dictionary<CachedCodeEntryKey, CachedCodeEntry> s_cache; //Field offset: 0x8
	[Token(Token = "0x4000373")]
	private static int s_cacheCount; //Field offset: 0x10
	[Token(Token = "0x4000374")]
	private static CachedCodeEntry s_cacheFirst; //Field offset: 0x18
	[Token(Token = "0x4000375")]
	private static CachedCodeEntry s_cacheLast; //Field offset: 0x20
	[Token(Token = "0x4000376")]
	private static readonly TimeSpan s_maximumMatchTimeout; //Field offset: 0x28
	[Token(Token = "0x4000378")]
	internal static readonly TimeSpan s_defaultMatchTimeout; //Field offset: 0x30
	[Token(Token = "0x4000379")]
	public static readonly TimeSpan InfiniteMatchTimeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400037A")]
	protected private TimeSpan internalMatchTimeout; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400037C")]
	protected private string pattern; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400037D")]
	protected private RegexOptions roptions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400037E")]
	protected private RegexRunnerFactory factory; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400037F")]
	protected private Hashtable caps; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000380")]
	protected private Hashtable capnames; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000381")]
	protected private String[] capslist; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000382")]
	protected private int capsize; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000383")]
	internal ExclusiveReference _runnerref; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000384")]
	internal WeakReference<RegexReplacement> _replref; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000385")]
	internal RegexCode _code; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000386")]
	internal bool _refsInitialized; //Field offset: 0x68

	[Token(Token = "0x170000DA")]
	public RegexOptions Options
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60004FD")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000DB")]
	public bool RightToLeft
	{
		[Address(RVA = "0x262A0D0", Offset = "0x26294D0", Length = "0x8")]
		[Token(Token = "0x60004FE")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x262A250", Offset = "0x2629650", Length = "0x170")]
	[Token(Token = "0x60004F5")]
	private static Regex() { }

	[Address(RVA = "0x262A3C0", Offset = "0x26297C0", Length = "0x7E")]
	[Token(Token = "0x60004F9")]
	public Regex(string pattern) { }

	[Address(RVA = "0x262A900", Offset = "0x2629D00", Length = "0x8B")]
	[Token(Token = "0x60004FA")]
	public Regex(string pattern, RegexOptions options) { }

	[Address(RVA = "0x262A440", Offset = "0x2629840", Length = "0x4B4")]
	[Token(Token = "0x60004FC")]
	private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	[Address(RVA = "0x262A990", Offset = "0x2629D90", Length = "0x63")]
	[Token(Token = "0x60004F8")]
	protected Regex() { }

	[Address(RVA = "0x2627670", Offset = "0x2626A70", Length = "0x109")]
	[Token(Token = "0x60004E3")]
	private void FillCacheDictionary() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60004FD")]
	public RegexOptions get_Options() { }

	[Address(RVA = "0x262A0D0", Offset = "0x26294D0", Length = "0x8")]
	[Token(Token = "0x60004FE")]
	public bool get_RightToLeft() { }

	[Address(RVA = "0x2627E60", Offset = "0x2627260", Length = "0x160")]
	[Token(Token = "0x60004E1")]
	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	[Address(RVA = "0x2627780", Offset = "0x2626B80", Length = "0x6D5")]
	[Token(Token = "0x60004E2")]
	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	[Address(RVA = "0x2627FD0", Offset = "0x26273D0", Length = "0x10A")]
	[Token(Token = "0x6000500")]
	public string GroupNameFromNumber(int i) { }

	[Address(RVA = "0x26280E0", Offset = "0x26274E0", Length = "0x11A")]
	[Token(Token = "0x6000501")]
	public int GroupNumberFromName(string name) { }

	[Address(RVA = "0x2628200", Offset = "0x2627600", Length = "0x211")]
	[Token(Token = "0x60004F7")]
	private static TimeSpan InitDefaultMatchTimeout() { }

	[Address(RVA = "0x2628420", Offset = "0x2627820", Length = "0xF7")]
	[Token(Token = "0x6000502")]
	protected void InitializeReferences() { }

	[Address(RVA = "0x2628720", Offset = "0x2627B20", Length = "0x8F")]
	[Token(Token = "0x60004EA")]
	public bool IsMatch(string input, int startat) { }

	[Address(RVA = "0x26287B0", Offset = "0x2627BB0", Length = "0x125")]
	[Token(Token = "0x60004E8")]
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	[Address(RVA = "0x2628520", Offset = "0x2627920", Length = "0x156")]
	[Token(Token = "0x60004E7")]
	public static bool IsMatch(string input, string pattern) { }

	[Address(RVA = "0x2628680", Offset = "0x2627A80", Length = "0x9C")]
	[Token(Token = "0x60004E9")]
	public bool IsMatch(string input) { }

	[Address(RVA = "0x26288E0", Offset = "0x2627CE0", Length = "0x4C9")]
	[Token(Token = "0x60004E6")]
	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	[Address(RVA = "0x2629000", Offset = "0x2628400", Length = "0x150")]
	[Token(Token = "0x60004EB")]
	public static Match Match(string input, string pattern) { }

	[Address(RVA = "0x2628E50", Offset = "0x2628250", Length = "0x11F")]
	[Token(Token = "0x60004EC")]
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	[Address(RVA = "0x2628F70", Offset = "0x2628370", Length = "0x89")]
	[Token(Token = "0x60004EE")]
	public Match Match(string input, int startat) { }

	[Address(RVA = "0x2628DB0", Offset = "0x26281B0", Length = "0x96")]
	[Token(Token = "0x60004ED")]
	public Match Match(string input) { }

	[Address(RVA = "0x2629160", Offset = "0x2628560", Length = "0x1CE")]
	[Token(Token = "0x60004EF")]
	public MatchCollection Matches(string input) { }

	[Address(RVA = "0x2629330", Offset = "0x2628730", Length = "0x1C4")]
	[Token(Token = "0x60004F0")]
	public MatchCollection Matches(string input, int startat) { }

	[Address(RVA = "0x2629880", Offset = "0x2628C80", Length = "0x12D")]
	[Token(Token = "0x60004F3")]
	public string Replace(string input, string replacement) { }

	[Address(RVA = "0x26299B0", Offset = "0x2628DB0", Length = "0x11B")]
	[Token(Token = "0x60004F4")]
	public string Replace(string input, string replacement, int count, int startat) { }

	[Address(RVA = "0x2629500", Offset = "0x2628900", Length = "0x19A")]
	[Token(Token = "0x60004F2")]
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	[Address(RVA = "0x26296A0", Offset = "0x2628AA0", Length = "0x1D9")]
	[Token(Token = "0x60004F1")]
	public static string Replace(string input, string pattern, string replacement) { }

	[Address(RVA = "0x2629AD0", Offset = "0x2628ED0", Length = "0x355")]
	[Token(Token = "0x6000503")]
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	[Address(RVA = "0x2629E30", Offset = "0x2629230", Length = "0x3E")]
	[Token(Token = "0x60004FB")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60004FF")]
	public virtual string ToString() { }

	[Address(RVA = "0x2629FC0", Offset = "0x26293C0", Length = "0xF9")]
	[Token(Token = "0x60004E4")]
	private static bool TryGetCacheValue(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	[Address(RVA = "0x2629E70", Offset = "0x2629270", Length = "0x14E")]
	[Token(Token = "0x60004E5")]
	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	[Address(RVA = "0x262A0C0", Offset = "0x26294C0", Length = "0xB")]
	[Token(Token = "0x6000505")]
	internal bool UseOptionInvariant() { }

	[Address(RVA = "0x262A0D0", Offset = "0x26294D0", Length = "0x8")]
	[Token(Token = "0x6000504")]
	protected private bool UseOptionR() { }

	[Address(RVA = "0x262A0E0", Offset = "0x26294E0", Length = "0x163")]
	[Token(Token = "0x60004F6")]
	protected private static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

}

