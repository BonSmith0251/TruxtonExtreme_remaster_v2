namespace UnityEngine.UIElements;

[Token(Token = "0x2000042")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class DataBindingUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000043")]
	private sealed class <>c
	{
		[Token(Token = "0x4000150")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x3229EB0", Offset = "0x32292B0", Length = "0x67")]
		[Token(Token = "0x600020B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600020C")]
		public <>c() { }

		[Address(RVA = "0x3229D60", Offset = "0x3229160", Length = "0x44")]
		[Token(Token = "0x600020D")]
		internal TypePathVisitor <.cctor>b__23_0() { }

		[Address(RVA = "0x3229DB0", Offset = "0x32291B0", Length = "0x1F")]
		[Token(Token = "0x600020E")]
		internal void <.cctor>b__23_1(TypePathVisitor v) { }

		[Address(RVA = "0x3229DD0", Offset = "0x32291D0", Length = "0x44")]
		[Token(Token = "0x600020F")]
		internal AutoCompletePathVisitor <.cctor>b__23_2() { }

		[Address(RVA = "0x3229E20", Offset = "0x3229220", Length = "0x1F")]
		[Token(Token = "0x6000210")]
		internal void <.cctor>b__23_3(AutoCompletePathVisitor v) { }

	}

	[Token(Token = "0x400014D")]
	private static readonly ObjectPool<TypePathVisitor> k_TypeVisitors; //Field offset: 0x0
	[Token(Token = "0x400014E")]
	private static readonly ObjectPool<AutoCompletePathVisitor> k_AutoCompleteVisitors; //Field offset: 0x8
	[Token(Token = "0x400014F")]
	private static readonly Regex s_ReplaceIndices; //Field offset: 0x10

	[Address(RVA = "0x32234C0", Offset = "0x32228C0", Length = "0x318")]
	[Token(Token = "0x600020A")]
	private static DataBindingUtility() { }

	[Address(RVA = "0x32230D0", Offset = "0x32224D0", Length = "0x3E1")]
	[Token(Token = "0x6000209")]
	public static bool TryGetBinding(VisualElement element, in BindingId bindingId, out BindingInfo bindingInfo) { }

}

