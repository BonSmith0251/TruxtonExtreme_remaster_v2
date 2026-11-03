namespace UnityEngine.UIElements;

[Token(Token = "0x2000561")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleCache
{
	[Token(Token = "0x40011D4")]
	private static Dictionary<Int64, ComputedStyle> s_ComputedStyleCache; //Field offset: 0x0
	[Token(Token = "0x40011D5")]
	private static Dictionary<Int32, StyleVariableContext> s_StyleVariableContextCache; //Field offset: 0x8
	[Token(Token = "0x40011D6")]
	private static Dictionary<Int32, ComputedTransitionProperty[]> s_ComputedTransitionsCache; //Field offset: 0x10

	[Address(RVA = "0x32DE770", Offset = "0x32DDB70", Length = "0x148")]
	[Token(Token = "0x6002738")]
	private static StyleCache() { }

	[Address(RVA = "0x32DE110", Offset = "0x32DD510", Length = "0x2C1")]
	[Token(Token = "0x6002737")]
	public static void ClearStyleCache() { }

	[Address(RVA = "0x32DE3E0", Offset = "0x32DD7E0", Length = "0xB9")]
	[Token(Token = "0x6002732")]
	public static void SetValue(long hash, ref ComputedStyle data) { }

	[Address(RVA = "0x32DE4A0", Offset = "0x32DD8A0", Length = "0x86")]
	[Token(Token = "0x6002734")]
	public static void SetValue(int hash, StyleVariableContext data) { }

	[Address(RVA = "0x32DE530", Offset = "0x32DD930", Length = "0x86")]
	[Token(Token = "0x6002736")]
	public static void SetValue(int hash, ComputedTransitionProperty[] data) { }

	[Address(RVA = "0x32DE6E0", Offset = "0x32DDAE0", Length = "0x87")]
	[Token(Token = "0x6002731")]
	public static bool TryGetValue(long hash, out ComputedStyle data) { }

	[Address(RVA = "0x32DE5C0", Offset = "0x32DD9C0", Length = "0x86")]
	[Token(Token = "0x6002733")]
	public static bool TryGetValue(int hash, out StyleVariableContext data) { }

	[Address(RVA = "0x32DE650", Offset = "0x32DDA50", Length = "0x86")]
	[Token(Token = "0x6002735")]
	public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data) { }

}

