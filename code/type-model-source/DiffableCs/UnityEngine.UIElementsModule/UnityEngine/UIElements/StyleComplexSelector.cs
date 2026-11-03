namespace UnityEngine.UIElements;

[Token(Token = "0x200047F")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleComplexSelector
{
	[CompilerGenerated]
	[Token(Token = "0x2000481")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EB4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000EB5")]
		public static Func<StyleSelector, String> <>9__23_0; //Field offset: 0x8
		[Token(Token = "0x4000EB6")]
		public static Predicate<StyleSelectorPart> <>9__26_0; //Field offset: 0x10

		[Address(RVA = "0x3293390", Offset = "0x3292790", Length = "0x67")]
		[Token(Token = "0x60021B5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60021B6")]
		public <>c() { }

		[Address(RVA = "0x32932B0", Offset = "0x32926B0", Length = "0x19")]
		[Token(Token = "0x60021B8")]
		internal bool <CalculateHashes>b__26_0(StyleSelectorPart p) { }

		[Address(RVA = "0x32932F0", Offset = "0x32926F0", Length = "0x2C")]
		[Token(Token = "0x60021B7")]
		internal string <ToString>b__23_0(StyleSelector x) { }

	}

	[Token(Token = "0x2000480")]
	private struct PseudoStateData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EB2")]
		public readonly PseudoStates state; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000EB3")]
		public readonly bool negate; //Field offset: 0x4

		[Address(RVA = "0xAEE2F0", Offset = "0xAED6F0", Length = "0x7")]
		[Token(Token = "0x60021B4")]
		public PseudoStateData(PseudoStates state, bool negate) { }

	}

	[Token(Token = "0x4000EB0")]
	private static Dictionary<String, PseudoStateData> s_PseudoStates; //Field offset: 0x0
	[Token(Token = "0x4000EB1")]
	private static readonly List<StyleSelectorPart> s_HashList; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EA9")]
	public Hashes ancestorHashes; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000EAA")]
	private int m_Specificity; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EAB")]
	private StyleRule <rule>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000EAC")]
	private StyleSelector[] m_Selectors; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000EAD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int ruleIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000EAE")]
	internal StyleComplexSelector nextInTable; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EAF")]
	internal int orderInStyleSheet; //Field offset: 0x48

	[Token(Token = "0x17000910")]
	public bool isSimple
	{
		[Address(RVA = "0x3288690", Offset = "0x3287A90", Length = "0x14")]
		[Token(Token = "0x60021AB")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700090F")]
	public internal StyleRule rule
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60021A9")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60021AA")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000911")]
	public internal StyleSelector[] selectors
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60021AC")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60021AD")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700090E")]
	public internal int specificity
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60021A7")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x60021A8")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x32885B0", Offset = "0x32879B0", Length = "0x89")]
	[Token(Token = "0x60021B3")]
	private static StyleComplexSelector() { }

	[Address(RVA = "0x3288640", Offset = "0x3287A40", Length = "0x50")]
	[Token(Token = "0x60021AE")]
	internal StyleComplexSelector() { }

	[Address(RVA = "0x32876A0", Offset = "0x3286AA0", Length = "0x75D")]
	[Token(Token = "0x60021AF")]
	internal void CachePseudoStateMasks(StyleSheet styleSheet) { }

	[Address(RVA = "0x3287E00", Offset = "0x3287200", Length = "0x5CC")]
	[Token(Token = "0x60021B2")]
	internal void CalculateHashes() { }

	[Address(RVA = "0x3288690", Offset = "0x3287A90", Length = "0x14")]
	[Token(Token = "0x60021AB")]
	public bool get_isSimple() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60021A9")]
	public StyleRule get_rule() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60021AC")]
	public StyleSelector[] get_selectors() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60021A7")]
	public int get_specificity() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60021AA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_rule(StyleRule value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60021AD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_selectors(StyleSelector[] value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x60021A8")]
	internal void set_specificity(int value) { }

	[Address(RVA = "0x32883D0", Offset = "0x32877D0", Length = "0x41")]
	[Token(Token = "0x60021B1")]
	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	[Address(RVA = "0x3288420", Offset = "0x3287820", Length = "0x184")]
	[Token(Token = "0x60021B0")]
	public virtual string ToString() { }

}

