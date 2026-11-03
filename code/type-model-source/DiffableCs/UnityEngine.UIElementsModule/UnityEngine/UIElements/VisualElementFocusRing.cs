namespace UnityEngine.UIElements;

[Token(Token = "0x2000551")]
public class VisualElementFocusRing : IFocusRing
{
	[Token(Token = "0x2000552")]
	internal enum DefaultFocusOrder : int
	{
		ChildOrder = 0,
		PositionXY = 1,
		PositionYX = 2,
	}

	[Token(Token = "0x2000553")]
	private class FocusRingRecord
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011A8")]
		public int m_AutoIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011A9")]
		public Focusable m_Focusable; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40011AA")]
		public bool m_IsSlot; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40011AB")]
		public List<FocusRingRecord> m_ScopeNavigationOrder; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60026ED")]
		public FocusRingRecord() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011A1")]
	private readonly VisualElement root; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011A2")]
	private DefaultFocusOrder <defaultFocusOrder>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011A3")]
	private List<FocusRingRecord> m_FocusRing; //Field offset: 0x20

	[Token(Token = "0x17000A18")]
	public DefaultFocusOrder defaultFocusOrder
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60026DE")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60026DF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000A17")]
	private FocusController focusController
	{
		[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
		[Token(Token = "0x60026DD")]
		private get { } //Length: 42
	}

	[Address(RVA = "0x32CDC60", Offset = "0x32CD060", Length = "0x9A")]
	[Token(Token = "0x60026DC")]
	public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = 0) { }

	[Address(RVA = "0x32CC300", Offset = "0x32CB700", Length = "0x2C6")]
	[Token(Token = "0x60026E3")]
	private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList) { }

	[Address(RVA = "0x32CC5D0", Offset = "0x32CB9D0", Length = "0xDA")]
	[Token(Token = "0x60026E2")]
	private void DoUpdate() { }

	[Address(RVA = "0x32CC6B0", Offset = "0x32CBAB0", Length = "0x487")]
	[Token(Token = "0x60026E0")]
	private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) { }

	[Address(RVA = "0x32CCB40", Offset = "0x32CBF40", Length = "0x11C")]
	[Token(Token = "0x60026E1")]
	private int FocusRingSort(FocusRingRecord a, FocusRingRecord b) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60026DE")]
	public DefaultFocusOrder get_defaultFocusOrder() { }

	[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
	[Token(Token = "0x60026DD")]
	private FocusController get_focusController() { }

	[Address(RVA = "0x32CCF90", Offset = "0x32CC390", Length = "0xA2")]
	[Token(Token = "0x60026E5")]
	private int GetFocusableInternalIndex(Focusable f) { }

	[Address(RVA = "0x32CCC60", Offset = "0x32CC060", Length = "0x325")]
	[Token(Token = "0x60026E6")]
	public override FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	[Address(RVA = "0x32CD040", Offset = "0x32CC440", Length = "0x51")]
	[Token(Token = "0x60026EB")]
	private VisualElement GetNextElementDepthFirst(VisualElement ve) { }

	[Address(RVA = "0x32CD730", Offset = "0x32CCB30", Length = "0x167")]
	[Token(Token = "0x60026E7")]
	public override Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	[Address(RVA = "0x32CD0A0", Offset = "0x32CC4A0", Length = "0x583")]
	[Token(Token = "0x60026E8")]
	internal Focusable GetNextFocusableInSequence(Focusable currentFocusable, FocusChangeDirection direction) { }

	[Address(RVA = "0x32CD630", Offset = "0x32CCA30", Length = "0xF8")]
	[Token(Token = "0x60026E9")]
	internal VisualElement GetNextFocusableInTree(VisualElement currentFocusable) { }

	[Address(RVA = "0x32CD8A0", Offset = "0x32CCCA0", Length = "0xA6")]
	[Token(Token = "0x60026EC")]
	private VisualElement GetPreviousElementDepthFirst(VisualElement ve) { }

	[Address(RVA = "0x32CD950", Offset = "0x32CCD50", Length = "0xAB")]
	[Token(Token = "0x60026EA")]
	internal VisualElement GetPreviousFocusableInTree(VisualElement currentFocusable) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60026DF")]
	public void set_defaultFocusOrder(DefaultFocusOrder value) { }

	[Address(RVA = "0x32CDA00", Offset = "0x32CCE00", Length = "0x257")]
	[Token(Token = "0x60026E4")]
	private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList) { }

}

