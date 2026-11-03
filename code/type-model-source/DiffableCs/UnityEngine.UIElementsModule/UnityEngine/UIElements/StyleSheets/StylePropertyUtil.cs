namespace UnityEngine.UIElements.StyleSheets;

[Extension]
[Token(Token = "0x2000630")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StylePropertyUtil
{
	[Token(Token = "0x400173E")]
	internal static readonly Dictionary<String, StylePropertyId> s_NameToId; //Field offset: 0x0
	[Token(Token = "0x400173F")]
	internal static readonly Dictionary<StylePropertyId, String> s_IdToName; //Field offset: 0x8
	[Token(Token = "0x4001740")]
	internal static readonly Dictionary<String, String> s_UssNameToCSharpName; //Field offset: 0x10
	[Token(Token = "0x4001741")]
	internal static readonly Dictionary<String, String> s_CSharpNameToUssName; //Field offset: 0x18
	[Token(Token = "0x4001742")]
	internal static readonly HashSet<StylePropertyId> s_AnimatableProperties; //Field offset: 0x20
	[Token(Token = "0x4001743")]
	internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties; //Field offset: 0x28

	[Token(Token = "0x17000B4D")]
	internal static Dictionary<String, StylePropertyId> propertyNameToStylePropertyId
	{
		[Address(RVA = "0x335C210", Offset = "0x335B610", Length = "0x4E")]
		[Token(Token = "0x6002C08")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000B4E")]
	internal static Dictionary<StylePropertyId, String> stylePropertyIdToPropertyName
	{
		[Address(RVA = "0x335C260", Offset = "0x335B660", Length = "0x4F")]
		[Token(Token = "0x6002C09")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 79
	}

	[Address(RVA = "0x33583C0", Offset = "0x33577C0", Length = "0x3E46")]
	[Token(Token = "0x6002C0B")]
	private static StylePropertyUtil() { }

	[Address(RVA = "0x335C210", Offset = "0x335B610", Length = "0x4E")]
	[Token(Token = "0x6002C08")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static Dictionary<String, StylePropertyId> get_propertyNameToStylePropertyId() { }

	[Address(RVA = "0x335C260", Offset = "0x335B660", Length = "0x4F")]
	[Token(Token = "0x6002C09")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static Dictionary<StylePropertyId, String> get_stylePropertyIdToPropertyName() { }

	[Address(RVA = "0x3356FB0", Offset = "0x33563B0", Length = "0x77")]
	[Token(Token = "0x6002C0A")]
	public static bool IsAnimatable(StylePropertyId id) { }

	[Address(RVA = "0x3357030", Offset = "0x3356430", Length = "0x134")]
	[Token(Token = "0x6002C07")]
	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	[Address(RVA = "0x3357190", Offset = "0x3356590", Length = "0x498")]
	[Token(Token = "0x6002C06")]
	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) { }

}

