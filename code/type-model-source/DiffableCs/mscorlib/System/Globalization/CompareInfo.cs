namespace System.Globalization;

[Token(Token = "0x200053E")]
public class CompareInfo : IDeserializationCallback
{
	[Token(Token = "0x40014EE")]
	private const CompareOptions ValidIndexMaskOffFlags = -32; //Field offset: 0x0
	[Token(Token = "0x40014EF")]
	private const CompareOptions ValidCompareMaskOffFlags = -536870944; //Field offset: 0x0
	[Token(Token = "0x40014F0")]
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32; //Field offset: 0x0
	[Token(Token = "0x40014F1")]
	private const CompareOptions ValidSortkeyCtorMaskOffFlags = -536870944; //Field offset: 0x0
	[Token(Token = "0x40014F2")]
	internal static readonly CompareInfo Invariant; //Field offset: 0x0
	[Token(Token = "0x40014F8")]
	private static Dictionary<String, ISimpleCollator> collators; //Field offset: 0x8
	[Token(Token = "0x40014F9")]
	private static bool managedCollation; //Field offset: 0x10
	[Token(Token = "0x40014FA")]
	private static bool managedCollationChecked; //Field offset: 0x11
	[FieldOffset(Offset = "0x10")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40014F3")]
	private string m_name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014F4")]
	private string _sortName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[OptionalField(VersionAdded = 3)]
	[Token(Token = "0x40014F5")]
	private SortVersion m_SortVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014F6")]
	private int culture; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014F7")]
	private ISimpleCollator collator; //Field offset: 0x30

	[Token(Token = "0x17000539")]
	public override string Name
	{
		[Address(RVA = "0x1F518A0", Offset = "0x1F50CA0", Length = "0x73")]
		[Token(Token = "0x600260B")]
		 get { } //Length: 115
	}

	[Token(Token = "0x1700053A")]
	private static bool UseManagedCollation
	{
		[Address(RVA = "0x1F51920", Offset = "0x1F50D20", Length = "0x17A")]
		[Token(Token = "0x6002628")]
		private get { } //Length: 378
	}

	[Address(RVA = "0x1F51780", Offset = "0x1F50B80", Length = "0x94")]
	[Token(Token = "0x6002643")]
	private static CompareInfo() { }

	[Address(RVA = "0x1F51850", Offset = "0x1F50C50", Length = "0x4D")]
	[Token(Token = "0x6002604")]
	internal CompareInfo(CultureInfo culture) { }

	[Address(RVA = "0x1F51820", Offset = "0x1F50C20", Length = "0x2C")]
	[Token(Token = "0x6002644")]
	internal CompareInfo() { }

	[Address(RVA = "0x1F4D620", Offset = "0x1F4CA20", Length = "0x29C")]
	[Token(Token = "0x600260D")]
	public override int Compare(string string1, string string2, CompareOptions options) { }

	[Address(RVA = "0x1F4D8C0", Offset = "0x1F4CCC0", Length = "0x565")]
	[Token(Token = "0x6002611")]
	public override int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	[Address(RVA = "0x1F4DE30", Offset = "0x1F4D230", Length = "0x25")]
	[Token(Token = "0x600260C")]
	public override int Compare(string string1, string string2) { }

	[Address(RVA = "0x1F4DE60", Offset = "0x1F4D260", Length = "0x456")]
	[Token(Token = "0x600260E")]
	internal int Compare(ReadOnlySpan<Char> string1, string string2, CompareOptions options) { }

	[Address(RVA = "0x1F4CB30", Offset = "0x1F4BF30", Length = "0x157")]
	[Token(Token = "0x6002610")]
	internal int CompareOptionIgnoreCase(ReadOnlySpan<Char> string1, ReadOnlySpan<Char> string2) { }

	[Address(RVA = "0x1F4CC90", Offset = "0x1F4C090", Length = "0x18E")]
	[Token(Token = "0x600260F")]
	internal int CompareOptionNone(ReadOnlySpan<Char> string1, ReadOnlySpan<Char> string2) { }

	[Address(RVA = "0x1F4CE20", Offset = "0x1F4C220", Length = "0x337")]
	[Token(Token = "0x6002613")]
	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<Char> strA, ReadOnlySpan<Char> strB) { }

	[Address(RVA = "0x1F4D160", Offset = "0x1F4C560", Length = "0x1A6")]
	[Token(Token = "0x6002612")]
	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB) { }

	[Address(RVA = "0x1F4D480", Offset = "0x1F4C880", Length = "0x118")]
	[Token(Token = "0x600263C")]
	private int CompareString(ReadOnlySpan<Char> string1, ReadOnlySpan<Char> string2, CompareOptions options) { }

	[Address(RVA = "0x1F4D5A0", Offset = "0x1F4C9A0", Length = "0x7B")]
	[Token(Token = "0x600263B")]
	private int CompareString(ReadOnlySpan<Char> string1, string string2, CompareOptions options) { }

	[Address(RVA = "0x1F4D310", Offset = "0x1F4C710", Length = "0x163")]
	[Token(Token = "0x6002634")]
	private static int CompareStringOrdinalIgnoreCase(Char* pString1, int length1, Char* pString2, int length2) { }

	[Address(RVA = "0x1F4E410", Offset = "0x1F4D810", Length = "0x203")]
	[Token(Token = "0x600263D")]
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	[Address(RVA = "0x1F4E2C0", Offset = "0x1F4D6C0", Length = "0x147")]
	[Token(Token = "0x600262A")]
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	[Address(RVA = "0x1F4E620", Offset = "0x1F4DA20", Length = "0x116")]
	[Token(Token = "0x6002640")]
	private bool EndsWith(string source, string suffix, CompareOptions options) { }

	[Address(RVA = "0x1F4E740", Offset = "0x1F4DB40", Length = "0x7C")]
	[Token(Token = "0x6002641")]
	private bool EndsWith(ReadOnlySpan<Char> source, ReadOnlySpan<Char> suffix, CompareOptions options) { }

	[Address(RVA = "0x1F4E7C0", Offset = "0x1F4DBC0", Length = "0xB1")]
	[Token(Token = "0x6002622")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1F518A0", Offset = "0x1F50CA0", Length = "0x73")]
	[Token(Token = "0x600260B")]
	public override string get_Name() { }

	[Address(RVA = "0x1F51920", Offset = "0x1F50D20", Length = "0x17A")]
	[Token(Token = "0x6002628")]
	private static bool get_UseManagedCollation() { }

	[Address(RVA = "0x1F4E880", Offset = "0x1F4DC80", Length = "0x304")]
	[Token(Token = "0x6002629")]
	private ISimpleCollator GetCollator() { }

	[Address(RVA = "0x1F4EB90", Offset = "0x1F4DF90", Length = "0xB8")]
	[Token(Token = "0x6002605")]
	public static CompareInfo GetCompareInfo(string name) { }

	[Address(RVA = "0x1F4EE90", Offset = "0x1F4E290", Length = "0x109")]
	[Token(Token = "0x6002626")]
	public override int GetHashCode(string source, CompareOptions options) { }

	[Address(RVA = "0x1F4EFA0", Offset = "0x1F4E3A0", Length = "0x3C")]
	[Token(Token = "0x6002623")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F4EC90", Offset = "0x1F4E090", Length = "0x1FC")]
	[Token(Token = "0x6002625")]
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	[Address(RVA = "0x1F4EC50", Offset = "0x1F4E050", Length = "0x3C")]
	[Token(Token = "0x6002642")]
	internal int GetHashCodeOfStringCore(string source, CompareOptions options) { }

	[Address(RVA = "0x1F4EFE0", Offset = "0x1F4E3E0", Length = "0x3D4")]
	[Token(Token = "0x6002624")]
	internal static int GetIgnoreCaseHash(string source) { }

	[Address(RVA = "0x1F4F3C0", Offset = "0x1F4E7C0", Length = "0xC1")]
	[Token(Token = "0x6002621")]
	public override SortKey GetSortKey(string source, CompareOptions options) { }

	[Address(RVA = "0x1F4FC60", Offset = "0x1F4F060", Length = "0x36C")]
	[Token(Token = "0x600261B")]
	public override int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	[Address(RVA = "0x1F4F830", Offset = "0x1F4EC30", Length = "0x96")]
	[Token(Token = "0x600261D")]
	internal int IndexOf(ReadOnlySpan<Char> source, ReadOnlySpan<Char> value, CompareOptions options) { }

	[Address(RVA = "0x1F4F8D0", Offset = "0x1F4ECD0", Length = "0x88")]
	[Token(Token = "0x6002619")]
	public override int IndexOf(string source, string value, CompareOptions options) { }

	[Address(RVA = "0x1F4FFD0", Offset = "0x1F4F3D0", Length = "0x88")]
	[Token(Token = "0x6002618")]
	public override int IndexOf(string source, char value, CompareOptions options) { }

	[Address(RVA = "0x1F4F960", Offset = "0x1F4ED60", Length = "0x2FA")]
	[Token(Token = "0x600261A")]
	public override int IndexOf(string source, char value, int startIndex, int count, CompareOptions options) { }

	[Address(RVA = "0x1F4F4E0", Offset = "0x1F4E8E0", Length = "0xAD")]
	[Token(Token = "0x6002639")]
	private int IndexOfCore(ReadOnlySpan<Char> source, ReadOnlySpan<Char> target, CompareOptions options, Int32* matchLengthPtr) { }

	[Address(RVA = "0x1F4F490", Offset = "0x1F4E890", Length = "0x4F")]
	[Token(Token = "0x6002638")]
	private int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, Int32* matchLengthPtr) { }

	[Address(RVA = "0x1F4F5D0", Offset = "0x1F4E9D0", Length = "0x96")]
	[Token(Token = "0x600261C")]
	internal int IndexOfOrdinal(ReadOnlySpan<Char> source, ReadOnlySpan<Char> value, bool ignoreCase) { }

	[Address(RVA = "0x1F4F670", Offset = "0x1F4EA70", Length = "0x1B1")]
	[Token(Token = "0x600261E")]
	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	[Address(RVA = "0x1F4F5D0", Offset = "0x1F4E9D0", Length = "0x96")]
	[Token(Token = "0x600263A")]
	private int IndexOfOrdinalCore(ReadOnlySpan<Char> source, ReadOnlySpan<Char> value, bool ignoreCase) { }

	[Address(RVA = "0x1F4F590", Offset = "0x1F4E990", Length = "0x32")]
	[Token(Token = "0x6002635")]
	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	[Address(RVA = "0x1F50060", Offset = "0x1F4F460", Length = "0x23")]
	[Token(Token = "0x6002633")]
	private void InitSort(CultureInfo culture) { }

	[Address(RVA = "0x1F51AB0", Offset = "0x1F50EB0", Length = "0xAA")]
	[Token(Token = "0x6002630")]
	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	[Address(RVA = "0x1F51AA0", Offset = "0x1F50EA0", Length = "0x5")]
	[Token(Token = "0x600262F")]
	private static int internal_compare_icall(Char* str1, int length1, Char* str2, int length2, CompareOptions options) { }

	[Address(RVA = "0x1F51B60", Offset = "0x1F50F60", Length = "0xEC")]
	[Token(Token = "0x600262D")]
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	[Address(RVA = "0x1F51C50", Offset = "0x1F51050", Length = "0x1F9")]
	[Token(Token = "0x600262C")]
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	[Address(RVA = "0x1F51E60", Offset = "0x1F51260", Length = "0xB9")]
	[Token(Token = "0x6002632")]
	private static int internal_index(string source, int sindex, int count, string value, bool first) { }

	[Address(RVA = "0x1F51E50", Offset = "0x1F51250", Length = "0xE")]
	[Token(Token = "0x6002631")]
	private static int internal_index_icall(Char* source, int sindex, int count, Char* value, int value_length, bool first) { }

	[Address(RVA = "0x1F51F20", Offset = "0x1F51320", Length = "0xA7")]
	[Token(Token = "0x600262E")]
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	[Address(RVA = "0x1F51FD0", Offset = "0x1F513D0", Length = "0x1F1")]
	[Token(Token = "0x600262B")]
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	[Address(RVA = "0x1F50090", Offset = "0x1F4F490", Length = "0x2B7")]
	[Token(Token = "0x6002603")]
	private SortKey InvariantCreateSortKey(string source, CompareOptions options) { }

	[Address(RVA = "0x1F50350", Offset = "0x1F4F750", Length = "0x3DD")]
	[Token(Token = "0x6002601")]
	private static int InvariantFindString(Char* source, int sourceCount, Char* value, int valueCount, bool ignoreCase, bool start) { }

	[Address(RVA = "0x1F50730", Offset = "0x1F4FB30", Length = "0xE4")]
	[Token(Token = "0x60025FF")]
	internal static int InvariantIndexOf(ReadOnlySpan<Char> source, ReadOnlySpan<Char> value, bool ignoreCase) { }

	[Address(RVA = "0x1F50820", Offset = "0x1F4FC20", Length = "0xD6")]
	[Token(Token = "0x60025FE")]
	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	[Address(RVA = "0x1F50900", Offset = "0x1F4FD00", Length = "0xE5")]
	[Token(Token = "0x6002600")]
	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	[Address(RVA = "0x1F509F0", Offset = "0x1F4FDF0", Length = "0x14")]
	[Token(Token = "0x6002602")]
	private static char InvariantToUpper(char c) { }

	[Address(RVA = "0x1F50A90", Offset = "0x1F4FE90", Length = "0x1C9")]
	[Token(Token = "0x6002614")]
	public override bool IsPrefix(string source, string prefix, CompareOptions options) { }

	[Address(RVA = "0x1F50A10", Offset = "0x1F4FE10", Length = "0x7C")]
	[Token(Token = "0x6002615")]
	internal bool IsPrefix(ReadOnlySpan<Char> source, ReadOnlySpan<Char> prefix, CompareOptions options) { }

	[Address(RVA = "0x1F50C60", Offset = "0x1F50060", Length = "0x1C9")]
	[Token(Token = "0x6002616")]
	public override bool IsSuffix(string source, string suffix, CompareOptions options) { }

	[Address(RVA = "0x1F4E740", Offset = "0x1F4DB40", Length = "0x7C")]
	[Token(Token = "0x6002617")]
	internal bool IsSuffix(ReadOnlySpan<Char> source, ReadOnlySpan<Char> suffix, CompareOptions options) { }

	[Address(RVA = "0x1F50FF0", Offset = "0x1F503F0", Length = "0x49C")]
	[Token(Token = "0x600261F")]
	public override int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	[Address(RVA = "0x1F50E30", Offset = "0x1F50230", Length = "0x34")]
	[Token(Token = "0x6002637")]
	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options) { }

	[Address(RVA = "0x1F50EB0", Offset = "0x1F502B0", Length = "0x130")]
	[Token(Token = "0x6002620")]
	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	[Address(RVA = "0x1F50E70", Offset = "0x1F50270", Length = "0x32")]
	[Token(Token = "0x6002636")]
	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	[Address(RVA = "0x1F51550", Offset = "0x1F50950", Length = "0x7")]
	[OnDeserialized]
	[Token(Token = "0x6002608")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x1F51490", Offset = "0x1F50890", Length = "0xB3")]
	[Token(Token = "0x6002609")]
	private void OnDeserialized() { }

	[Address(RVA = "0x1CC8D30", Offset = "0x1CC8130", Length = "0x13")]
	[OnDeserializing]
	[Token(Token = "0x6002606")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x1F51560", Offset = "0x1F50960", Length = "0x90")]
	[OnSerializing]
	[Token(Token = "0x600260A")]
	private void OnSerializing(StreamingContext ctx) { }

	[Address(RVA = "0x1F51600", Offset = "0x1F50A00", Length = "0x113")]
	[Token(Token = "0x600263E")]
	private bool StartsWith(string source, string prefix, CompareOptions options) { }

	[Address(RVA = "0x1F50A10", Offset = "0x1F4FE10", Length = "0x7C")]
	[Token(Token = "0x600263F")]
	private bool StartsWith(ReadOnlySpan<Char> source, ReadOnlySpan<Char> prefix, CompareOptions options) { }

	[Address(RVA = "0x1F51550", Offset = "0x1F50950", Length = "0x7")]
	[Token(Token = "0x6002607")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x1F51720", Offset = "0x1F50B20", Length = "0x52")]
	[Token(Token = "0x6002627")]
	public virtual string ToString() { }

}

