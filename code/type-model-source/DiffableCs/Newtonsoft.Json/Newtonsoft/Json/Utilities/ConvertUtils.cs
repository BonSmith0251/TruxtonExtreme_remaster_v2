namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000A1")]
internal static class ConvertUtils
{
	[CompilerGenerated]
	[Token(Token = "0x20000A3")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 2})]
		[Token(Token = "0x40003DB")]
		public MethodCall<Object, Object> call; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600054B")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x2131D00", Offset = "0x2131100", Length = "0xC0")]
		[NullableContext(2)]
		[Token(Token = "0x600054C")]
		internal object <CreateCastConverter>b__0(object o) { }

	}

	[NullableContext(0)]
	[Token(Token = "0x20000A2")]
	public enum ConvertResult : int
	{
		Success = 0,
		CannotConvertNull = 1,
		NotInstantiableType = 2,
		NoValidConversion = 3,
	}

	[Token(Token = "0x40003D3")]
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; //Field offset: 0x0
	[Token(Token = "0x40003D4")]
	private static readonly TypeInformation[] PrimitiveTypeCodes; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 1, 2, 2, 2})]
	[Token(Token = "0x40003D5")]
	private static readonly ThreadSafeStore<StructMultiKey`2<Type, Type>, Func`2<Object, Object>> CastConverters; //Field offset: 0x10

	[Address(RVA = "0x211DF60", Offset = "0x211D360", Length = "0x1360")]
	[Token(Token = "0x600054A")]
	private static ConvertUtils() { }

	[Address(RVA = "0x211B0A0", Offset = "0x211A4A0", Length = "0x29F")]
	[Token(Token = "0x600053E")]
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	[Address(RVA = "0x211AF50", Offset = "0x211A350", Length = "0x14F")]
	[Token(Token = "0x6000541")]
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	[Address(RVA = "0x211B340", Offset = "0x211A740", Length = "0x27A")]
	[NullableContext(2)]
	[Token(Token = "0x600053B")]
	private static Func<Object, Object> CreateCastConverter(StructMultiKey<Type, Type> t) { }

	[Address(RVA = "0x211B5C0", Offset = "0x211A9C0", Length = "0x94F")]
	[Token(Token = "0x6000547")]
	public static ParseResult DecimalTryParse(Char[] chars, int start, int length, out decimal value) { }

	[Address(RVA = "0x211BF10", Offset = "0x211B310", Length = "0x235")]
	[Token(Token = "0x6000542")]
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	[Address(RVA = "0x211C150", Offset = "0x211B550", Length = "0x423")]
	[Token(Token = "0x600053D")]
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	[Address(RVA = "0x211C580", Offset = "0x211B980", Length = "0x55")]
	[Token(Token = "0x6000536")]
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	[Address(RVA = "0x211C5E0", Offset = "0x211B9E0", Length = "0x261")]
	[Token(Token = "0x6000537")]
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	[Address(RVA = "0x211C850", Offset = "0x211BC50", Length = "0x9C")]
	[Token(Token = "0x6000538")]
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	[Address(RVA = "0x211C8F0", Offset = "0x211BCF0", Length = "0x19D")]
	[Token(Token = "0x6000545")]
	public static ParseResult Int32TryParse(Char[] chars, int start, int length, out int value) { }

	[Address(RVA = "0x211CA90", Offset = "0x211BE90", Length = "0x18D")]
	[Token(Token = "0x6000546")]
	public static ParseResult Int64TryParse(Char[] chars, int start, int length, out long value) { }

	[Address(RVA = "0x211CC20", Offset = "0x211C020", Length = "0x7D")]
	[Token(Token = "0x6000539")]
	public static bool IsConvertible(Type t) { }

	[Address(RVA = "0x211CCA0", Offset = "0x211C0A0", Length = "0xCC")]
	[Token(Token = "0x6000544")]
	public static bool IsInteger(object value) { }

	[Address(RVA = "0x211CDB0", Offset = "0x211C1B0", Length = "0x81")]
	[Token(Token = "0x600053A")]
	public static TimeSpan ParseTimeSpan(string input) { }

	[Address(RVA = "0x211CE40", Offset = "0x211C240", Length = "0x425")]
	[Token(Token = "0x600053C")]
	internal static BigInteger ToBigInteger(object value) { }

	[Address(RVA = "0x211DDF0", Offset = "0x211D1F0", Length = "0xAD")]
	[Token(Token = "0x600053F")]
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	[Address(RVA = "0x211D270", Offset = "0x211C670", Length = "0x4B")]
	[Token(Token = "0x6000548")]
	public static bool TryConvertGuid(string s, out Guid g) { }

	[Address(RVA = "0x211D2C0", Offset = "0x211C6C0", Length = "0xB2D")]
	[Token(Token = "0x6000540")]
	private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	[Address(RVA = "0x211DEA0", Offset = "0x211D2A0", Length = "0xAF")]
	[Token(Token = "0x6000549")]
	public static bool TryHexTextToInt(Char[] text, int start, int end, out int value) { }

	[Address(RVA = "0x211DF50", Offset = "0x211D350", Length = "0x8")]
	[Token(Token = "0x6000543")]
	public static bool VersionTryParse(string input, out Version result) { }

}

