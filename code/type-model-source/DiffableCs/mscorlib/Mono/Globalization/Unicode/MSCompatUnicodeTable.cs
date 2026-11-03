namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000053")]
internal class MSCompatUnicodeTable
{
	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private sealed class <>c
	{
		[Token(Token = "0x4000173")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000174")]
		public static Comparison<Level2Map> <>9__17_0; //Field offset: 0x8

		[Address(RVA = "0x1E6E940", Offset = "0x1E6DD40", Length = "0x67")]
		[Token(Token = "0x60000CB")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000CC")]
		public <>c() { }

		[Address(RVA = "0x1E6E910", Offset = "0x1E6DD10", Length = "0x23")]
		[Token(Token = "0x60000CD")]
		internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

	}

	[Token(Token = "0x4000160")]
	public static int MaxExpansionLength; //Field offset: 0x0
	[Token(Token = "0x4000161")]
	private static readonly Byte* ignorableFlags; //Field offset: 0x8
	[Token(Token = "0x4000162")]
	private static readonly Byte* categories; //Field offset: 0x10
	[Token(Token = "0x4000163")]
	private static readonly Byte* level1; //Field offset: 0x18
	[Token(Token = "0x4000164")]
	private static readonly Byte* level2; //Field offset: 0x20
	[Token(Token = "0x4000165")]
	private static readonly Byte* level3; //Field offset: 0x28
	[Token(Token = "0x4000166")]
	private static Byte* cjkCHScategory; //Field offset: 0x30
	[Token(Token = "0x4000167")]
	private static Byte* cjkCHTcategory; //Field offset: 0x38
	[Token(Token = "0x4000168")]
	private static Byte* cjkJAcategory; //Field offset: 0x40
	[Token(Token = "0x4000169")]
	private static Byte* cjkKOcategory; //Field offset: 0x48
	[Token(Token = "0x400016A")]
	private static Byte* cjkCHSlv1; //Field offset: 0x50
	[Token(Token = "0x400016B")]
	private static Byte* cjkCHTlv1; //Field offset: 0x58
	[Token(Token = "0x400016C")]
	private static Byte* cjkJAlv1; //Field offset: 0x60
	[Token(Token = "0x400016D")]
	private static Byte* cjkKOlv1; //Field offset: 0x68
	[Token(Token = "0x400016E")]
	private static Byte* cjkKOlv2; //Field offset: 0x70
	[Token(Token = "0x400016F")]
	private static readonly Char[] tailoringArr; //Field offset: 0x78
	[Token(Token = "0x4000170")]
	private static readonly TailoringInfo[] tailoringInfos; //Field offset: 0x80
	[Token(Token = "0x4000171")]
	private static object forLock; //Field offset: 0x88
	[Token(Token = "0x4000172")]
	public static readonly bool isReady; //Field offset: 0x90

	[Token(Token = "0x17000016")]
	public static bool IsReady
	{
		[Address(RVA = "0x1E63540", Offset = "0x1E62940", Length = "0x52")]
		[Token(Token = "0x60000C5")]
		 get { } //Length: 82
	}

	[Address(RVA = "0x1E62F60", Offset = "0x1E62360", Length = "0x5D6")]
	[Token(Token = "0x60000C8")]
	private static MSCompatUnicodeTable() { }

	[Address(RVA = "0x1E614D0", Offset = "0x1E608D0", Length = "0x6B8")]
	[Token(Token = "0x60000B7")]
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	[Address(RVA = "0x1E61B90", Offset = "0x1E60F90", Length = "0xAE")]
	[Token(Token = "0x60000B9")]
	public static byte Category(int cp) { }

	[Address(RVA = "0x1E621B0", Offset = "0x1E615B0", Length = "0x171")]
	[Token(Token = "0x60000C9")]
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[Address(RVA = "0x1E61C40", Offset = "0x1E61040", Length = "0x566")]
	[Token(Token = "0x60000CA")]
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref Byte* lv2Table) { }

	[Address(RVA = "0x1E63540", Offset = "0x1E62940", Length = "0x52")]
	[Token(Token = "0x60000C5")]
	public static bool get_IsReady() { }

	[Address(RVA = "0x1E62330", Offset = "0x1E61730", Length = "0xB1")]
	[Token(Token = "0x60000C6")]
	private static IntPtr GetResource(string name) { }

	[Address(RVA = "0x1E623F0", Offset = "0x1E617F0", Length = "0x11A")]
	[Token(Token = "0x60000B6")]
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	[Address(RVA = "0x1E62510", Offset = "0x1E61910", Length = "0x67")]
	[Token(Token = "0x60000C1")]
	public static bool HasSpecialWeight(char c) { }

	[Address(RVA = "0x1E62580", Offset = "0x1E61980", Length = "0x19")]
	[Token(Token = "0x60000C2")]
	public static bool IsHalfWidthKana(char c) { }

	[Address(RVA = "0x1E625A0", Offset = "0x1E619A0", Length = "0x19")]
	[Token(Token = "0x60000C3")]
	public static bool IsHiragana(char c) { }

	[Address(RVA = "0x1E62610", Offset = "0x1E61A10", Length = "0x118")]
	[Token(Token = "0x60000BD")]
	public static bool IsIgnorable(int cp, byte flag) { }

	[Address(RVA = "0x1E625C0", Offset = "0x1E619C0", Length = "0x4A")]
	[Token(Token = "0x60000BE")]
	public static bool IsIgnorableNonSpacing(int cp) { }

	[Address(RVA = "0x1E62730", Offset = "0x1E61B30", Length = "0x120")]
	[Token(Token = "0x60000C4")]
	public static bool IsJapaneseSmallLetter(char c) { }

	[Address(RVA = "0x1E628A0", Offset = "0x1E61CA0", Length = "0xAE")]
	[Token(Token = "0x60000BA")]
	public static byte Level1(int cp) { }

	[Address(RVA = "0x1E62950", Offset = "0x1E61D50", Length = "0xAE")]
	[Token(Token = "0x60000BB")]
	public static byte Level2(int cp) { }

	[Address(RVA = "0x1E62A00", Offset = "0x1E61E00", Length = "0xAE")]
	[Token(Token = "0x60000BC")]
	public static byte Level3(int cp) { }

	[Address(RVA = "0x1E62AB0", Offset = "0x1E61EB0", Length = "0x2CD")]
	[Token(Token = "0x60000B8")]
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[Address(RVA = "0x1E62D80", Offset = "0x1E62180", Length = "0x12")]
	[Token(Token = "0x60000BF")]
	public static int ToKanaTypeInsensitive(int i) { }

	[Address(RVA = "0x1E62DA0", Offset = "0x1E621A0", Length = "0x164")]
	[Token(Token = "0x60000C0")]
	public static int ToWidthCompat(int i) { }

	[Address(RVA = "0x1E62F20", Offset = "0x1E62320", Length = "0x37")]
	[Token(Token = "0x60000C7")]
	private static uint UInt32FromBytePtr(Byte* raw, uint idx) { }

}

