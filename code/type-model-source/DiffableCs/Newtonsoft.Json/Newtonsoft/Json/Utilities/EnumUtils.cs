namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000C2")]
internal static class EnumUtils
{
	[CompilerGenerated]
	[Token(Token = "0x20000C3")]
	private sealed class <>c
	{
		[Nullable(0)]
		[Token(Token = "0x4000445")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x4000446")]
		public static Func<EnumMemberAttribute, String> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x2131DD0", Offset = "0x21311D0", Length = "0x67")]
		[Token(Token = "0x6000606")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000607")]
		public <>c() { }

		[Address(RVA = "0xA503D0", Offset = "0xA4F7D0", Length = "0x17")]
		[NullableContext(0)]
		[Token(Token = "0x6000608")]
		internal string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C4")]
	private sealed class <>c__4
	{
		[Nullable(0)]
		[Token(Token = "0x4000447")]
		public static readonly <>c__4<T> <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x4000448")]
		public static Func<UInt64, Boolean> <>9__4_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000609")]
		private static <>c__4`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600060A")]
		public <>c__4`1() { }

		[Address(RVA = "0xA53AA0", Offset = "0xA52EA0", Length = "0x7")]
		[Token(Token = "0x600060B")]
		internal bool <GetFlagsValues>b__4_0(ulong v) { }

	}

	[Token(Token = "0x4000441")]
	private const char EnumSeparatorChar = '\u2C'; //Field offset: 0x0
	[Token(Token = "0x4000442")]
	private const string EnumSeparatorString = ", "; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 2, 1})]
	[Token(Token = "0x4000443")]
	private static readonly ThreadSafeStore<StructMultiKey`2<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; //Field offset: 0x0
	[Token(Token = "0x4000444")]
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; //Field offset: 0x8

	[Address(RVA = "0x21255C0", Offset = "0x21249C0", Length = "0x11C")]
	[Token(Token = "0x6000605")]
	private static EnumUtils() { }

	[Address(RVA = "0x2123DC0", Offset = "0x21231C0", Length = "0xFD")]
	[Token(Token = "0x6000604")]
	private static Nullable<Int32> FindIndexByName(String[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	[Address(RVA = "0x2123EC0", Offset = "0x21232C0", Length = "0xBD")]
	[Token(Token = "0x6000600")]
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	[Address(RVA = "0x7D3A00", Offset = "0x7D2E00", Length = "0x548")]
	[NullableContext(0)]
	[Token(Token = "0x60005FC")]
	public static IList<T> GetFlagsValues(T value) { }

	[Address(RVA = "0x2123F80", Offset = "0x2123380", Length = "0x53E")]
	[Token(Token = "0x60005FB")]
	private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key) { }

	[Address(RVA = "0x21244C0", Offset = "0x21238C0", Length = "0x19D")]
	[Token(Token = "0x60005FF")]
	private static string InternalFlagsFormat(EnumInfo entry, ulong result) { }

	[Address(RVA = "0x2124660", Offset = "0x2123A60", Length = "0xDB")]
	[Token(Token = "0x6000603")]
	private static Nullable<Int32> MatchName(string value, String[] enumNames, String[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	[Address(RVA = "0x2124740", Offset = "0x2123B40", Length = "0x7A4")]
	[Token(Token = "0x6000602")]
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	[Address(RVA = "0x2124EF0", Offset = "0x21242F0", Length = "0x2C0")]
	[Token(Token = "0x6000601")]
	private static ulong ToUInt64(object value) { }

	[Address(RVA = "0x21253B0", Offset = "0x21247B0", Length = "0x208")]
	[Token(Token = "0x60005FD")]
	public static bool TryToString(Type enumType, object value, bool camelCase, out string name) { }

	[Address(RVA = "0x2125200", Offset = "0x2124600", Length = "0x1A9")]
	[Token(Token = "0x60005FE")]
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name) { }

}

