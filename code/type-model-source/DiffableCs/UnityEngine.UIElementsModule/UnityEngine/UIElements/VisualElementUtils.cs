namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000558")]
internal static class VisualElementUtils
{
	[CompilerGenerated]
	[Token(Token = "0x2000559")]
	private sealed class <>c
	{
		[Token(Token = "0x40011B0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40011B1")]
		public static Predicate<VisualElement> <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x32DED00", Offset = "0x32DE100", Length = "0x67")]
		[Token(Token = "0x6002705")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002706")]
		public <>c() { }

		[Address(RVA = "0x32DEBD0", Offset = "0x32DDFD0", Length = "0x69")]
		[Token(Token = "0x6002707")]
		internal bool <AssignInspectorStyleIfNecessary>b__5_0(VisualElement i) { }

	}

	[Token(Token = "0x40011AD")]
	private static readonly HashSet<String> s_usedNames; //Field offset: 0x0
	[Token(Token = "0x40011AE")]
	private static readonly Type s_FoldoutType; //Field offset: 0x8
	[Token(Token = "0x40011AF")]
	private static readonly string s_InspectorElementUssClassName; //Field offset: 0x10

	[Address(RVA = "0x32E8410", Offset = "0x32E7810", Length = "0x125")]
	[Token(Token = "0x6002704")]
	private static VisualElementUtils() { }

	[Address(RVA = "0x32E80E0", Offset = "0x32E74E0", Length = "0x129")]
	[Extension]
	[Token(Token = "0x6002703")]
	internal static void AssignInspectorStyleIfNecessary(VisualElement element, string classNameToEnable) { }

	[Address(RVA = "0x32E8210", Offset = "0x32E7610", Length = "0xEB")]
	[Extension]
	[Token(Token = "0x6002702")]
	internal static int GetFoldoutDepth(VisualElement element) { }

	[Address(RVA = "0x32E8300", Offset = "0x32E7700", Length = "0x108")]
	[Token(Token = "0x6002701")]
	public static string GetUniqueName(string nameBase) { }

}

