namespace UnityEngine;

[Token(Token = "0x20001A7")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal static class EnumDataUtility
{
	[CompilerGenerated]
	[Token(Token = "0x20001A9")]
	private sealed class <>c
	{
		[Token(Token = "0x400066D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400066E")]
		public static Func<FieldInfo, Int32> <>9__2_5; //Field offset: 0x8
		[Token(Token = "0x400066F")]
		public static Func<FieldInfo, String> <>9__2_1; //Field offset: 0x10
		[Token(Token = "0x4000670")]
		public static Func<FieldInfo, Enum> <>9__2_2; //Field offset: 0x18
		[Token(Token = "0x4000671")]
		public static Func<Enum, Int32> <>9__2_3; //Field offset: 0x20
		[Token(Token = "0x4000672")]
		public static Func<Enum, Int32> <>9__2_4; //Field offset: 0x28

		[Address(RVA = "0x3073DE0", Offset = "0x30731E0", Length = "0x67")]
		[Token(Token = "0x600130F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001310")]
		public <>c() { }

		[Address(RVA = "0x30733C0", Offset = "0x30727C0", Length = "0x145")]
		[Token(Token = "0x6001312")]
		internal string <GetCachedEnumData>b__2_1(FieldInfo f) { }

		[Address(RVA = "0x3073510", Offset = "0x3072910", Length = "0x6D")]
		[Token(Token = "0x6001313")]
		internal Enum <GetCachedEnumData>b__2_2(FieldInfo f) { }

		[Address(RVA = "0x3073580", Offset = "0x3072980", Length = "0x49")]
		[Token(Token = "0x6001314")]
		internal int <GetCachedEnumData>b__2_3(Enum v) { }

		[Address(RVA = "0x30735D0", Offset = "0x30729D0", Length = "0x49")]
		[Token(Token = "0x6001315")]
		internal int <GetCachedEnumData>b__2_4(Enum v) { }

		[Address(RVA = "0xA50640", Offset = "0xA4FA40", Length = "0x2C")]
		[Token(Token = "0x6001311")]
		internal int <GetCachedEnumData>b__2_5(FieldInfo f) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001AA")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000673")]
		public Func<String, String> nicifyName; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001316")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x3073C20", Offset = "0x3073020", Length = "0x5D")]
		[Token(Token = "0x6001317")]
		internal string <GetCachedEnumData>b__0(FieldInfo f) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001AB")]
	private struct <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000674")]
		public Func<String, String> nicifyName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000675")]
		public FieldInfo field; //Field offset: 0x8

	}

	[Token(Token = "0x20001A8")]
	internal enum CachedType : int
	{
		ExcludeObsolete = 0,
		IncludeObsoleteExceptErrors = 1,
		IncludeAllObsolete = 2,
	}

	[Token(Token = "0x4000668")]
	private static readonly Dictionary<ValueTuple`2<CachedType, Type>, EnumData> s_EnumData; //Field offset: 0x0

	[Address(RVA = "0x3060800", Offset = "0x305FC00", Length = "0x84")]
	[Token(Token = "0x600130D")]
	private static EnumDataUtility() { }

	[Address(RVA = "0x3060790", Offset = "0x305FB90", Length = "0x6F")]
	[CompilerGenerated]
	[Token(Token = "0x600130E")]
	internal static string <EnumNameFromEnumField>g__NicifyName|8_0(ref <>c__DisplayClass8_0 unnamed_param_0) { }

	[Address(RVA = "0x305EBC0", Offset = "0x305DFC0", Length = "0x126")]
	[Token(Token = "0x600130A")]
	private static bool CheckObsoleteAddition(FieldInfo field, CachedType cachedType) { }

	[Address(RVA = "0x305ECF0", Offset = "0x305E0F0", Length = "0x2CA")]
	[Token(Token = "0x600130C")]
	private static string EnumNameFromEnumField(FieldInfo field, Func<String, String> nicifyName) { }

	[Address(RVA = "0x305EFC0", Offset = "0x305E3C0", Length = "0x114")]
	[Token(Token = "0x600130B")]
	private static string EnumTooltipFromEnumField(FieldInfo field) { }

	[Address(RVA = "0x305F0E0", Offset = "0x305E4E0", Length = "0x10F7")]
	[Token(Token = "0x6001308")]
	public static EnumData GetCachedEnumData(Type enumType, CachedType cachedType = 1, Func<String, String> nicifyName = null) { }

	[Address(RVA = "0x30601E0", Offset = "0x305F5E0", Length = "0x5A8")]
	[Token(Token = "0x6001309")]
	public static void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData) { }

}

