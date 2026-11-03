namespace UnityEngine.UIElements;

[Token(Token = "0x2000564")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
{
	[CompilerGenerated]
	[Token(Token = "0x2000565")]
	private sealed class <>c
	{
		[Token(Token = "0x40011EE")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40011EF")]
		public static Comparison<SelectorMatchRecord> <>9__28_0; //Field offset: 0x8

		[Address(RVA = "0x32DEC90", Offset = "0x32DE090", Length = "0x67")]
		[Token(Token = "0x6002759")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600275A")]
		public <>c() { }

		[Address(RVA = "0x32DEC40", Offset = "0x32DE040", Length = "0x43")]
		[Token(Token = "0x600275B")]
		internal int <ProcessMatchedRules>b__28_0(SelectorMatchRecord a, SelectorMatchRecord b) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011E5")]
	private StyleVariableContext m_ProcessVarContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011E6")]
	private HashSet<VisualElement> m_UpdateList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011E7")]
	private HashSet<VisualElement> m_ParentList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011E8")]
	private List<SelectorMatchRecord> m_TempMatchResults; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011E9")]
	private float <currentPixelsPerPoint>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011EA")]
	private StyleMatchingContext m_StyleMatchingContext; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40011EB")]
	private StylePropertyReader m_StylePropertyReader; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40011EC")]
	private BaseVisualElementPanel <currentPanel>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40011ED")]
	private readonly List<StylePropertyId> m_AnimatedProperties; //Field offset: 0x50

	[Token(Token = "0x17000A23")]
	private BaseVisualElementPanel currentPanel
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002749")]
		private get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600274A")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000A22")]
	private float currentPixelsPerPoint
	{
		[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6002747")]
		private get { } //Length: 6
		[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6002748")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x32EC470", Offset = "0x32EB870", Length = "0x31A")]
	[Token(Token = "0x6002758")]
	public VisualTreeStyleUpdaterTraversal() { }

	[Address(RVA = "0x32EA630", Offset = "0x32E9A30", Length = "0x101")]
	[Token(Token = "0x600274C")]
	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x32EA740", Offset = "0x32E9B40", Length = "0x1E5")]
	[Token(Token = "0x6002754")]
	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) { }

	[Address(RVA = "0x32EA930", Offset = "0x32E9D30", Length = "0x95")]
	[Token(Token = "0x600274D")]
	public void Clear() { }

	[Address(RVA = "0x32EA9D0", Offset = "0x32E9DD0", Length = "0x24E")]
	[Token(Token = "0x6002753")]
	private void ForceUpdateTransitions(VisualElement element) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002749")]
	private BaseVisualElementPanel get_currentPanel() { }

	[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6002747")]
	private float get_currentPixelsPerPoint() { }

	[Address(RVA = "0x32EAC20", Offset = "0x32EA020", Length = "0x31")]
	[Token(Token = "0x6002750")]
	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	[Address(RVA = "0x32EAC60", Offset = "0x32EA060", Length = "0x2E")]
	[Token(Token = "0x600274B")]
	public void PrepareTraversal(BaseVisualElementPanel panel, float pixelsPerPoint) { }

	[Address(RVA = "0x32EAC90", Offset = "0x32EA090", Length = "0xAFC")]
	[Token(Token = "0x6002756")]
	private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors) { }

	[Address(RVA = "0x32EB790", Offset = "0x32EAB90", Length = "0x10E")]
	[Token(Token = "0x6002757")]
	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	[Address(RVA = "0x32EB8A0", Offset = "0x32EACA0", Length = "0x129")]
	[Token(Token = "0x6002752")]
	private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) { }

	[Address(RVA = "0x32EB9D0", Offset = "0x32EADD0", Length = "0xDA")]
	[Token(Token = "0x600274E")]
	private void PropagateToChildren(VisualElement ve) { }

	[Address(RVA = "0x32EBAB0", Offset = "0x32EAEB0", Length = "0xA2")]
	[Token(Token = "0x600274F")]
	private void PropagateToParents(VisualElement ve) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600274A")]
	private void set_currentPanel(BaseVisualElementPanel value) { }

	[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6002748")]
	private void set_currentPixelsPerPoint(float value) { }

	[Address(RVA = "0x32EBB60", Offset = "0x32EAF60", Length = "0x7F")]
	[Token(Token = "0x6002755")]
	protected bool ShouldSkipElement(VisualElement element) { }

	[Address(RVA = "0x32EBBE0", Offset = "0x32EAFE0", Length = "0x882")]
	[Token(Token = "0x6002751")]
	public virtual void TraverseRecursive(VisualElement element, int depth) { }

}

