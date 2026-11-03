namespace UnityEngine.UIElements;

[Token(Token = "0x2000171")]
public class TwoPaneSplitView : VisualElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000172")]
	internal class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits>
	{

		[Address(RVA = "0x33C3D60", Offset = "0x33C3160", Length = "0x39")]
		[Token(Token = "0x6000B3D")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000173")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000757")]
		private UxmlIntAttributeDescription m_FixedPaneIndex; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000758")]
		private UxmlIntAttributeDescription m_FixedPaneInitialDimension; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000759")]
		private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation; //Field offset: 0x98

		[Address(RVA = "0x33C4A40", Offset = "0x33C3E40", Length = "0x190")]
		[Token(Token = "0x6000B3F")]
		public UxmlTraits() { }

		[Address(RVA = "0x33C41A0", Offset = "0x33C35A0", Length = "0x201")]
		[Token(Token = "0x6000B3E")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400073B")]
	internal static readonly BindingId fixedPaneIndexProperty; //Field offset: 0x0
	[Token(Token = "0x400073C")]
	internal static readonly BindingId fixedPaneInitialDimensionProperty; //Field offset: 0x98
	[Token(Token = "0x400073D")]
	internal static readonly BindingId orientationProperty; //Field offset: 0x130
	[Token(Token = "0x400073E")]
	private static readonly string s_UssClassName; //Field offset: 0x1C8
	[Token(Token = "0x400073F")]
	private static readonly string s_ContentContainerClassName; //Field offset: 0x1D0
	[Token(Token = "0x4000740")]
	private static readonly string s_HandleDragLineClassName; //Field offset: 0x1D8
	[Token(Token = "0x4000741")]
	private static readonly string s_HandleDragLineVerticalClassName; //Field offset: 0x1E0
	[Token(Token = "0x4000742")]
	private static readonly string s_HandleDragLineHorizontalClassName; //Field offset: 0x1E8
	[Token(Token = "0x4000743")]
	private static readonly string s_HandleDragLineAnchorClassName; //Field offset: 0x1F0
	[Token(Token = "0x4000744")]
	private static readonly string s_HandleDragLineAnchorVerticalClassName; //Field offset: 0x1F8
	[Token(Token = "0x4000745")]
	private static readonly string s_HandleDragLineAnchorHorizontalClassName; //Field offset: 0x200
	[Token(Token = "0x4000746")]
	private static readonly string s_VerticalClassName; //Field offset: 0x208
	[Token(Token = "0x4000747")]
	private static readonly string s_HorizontalClassName; //Field offset: 0x210
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000748")]
	private VisualElement m_LeftPane; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000749")]
	private VisualElement m_RightPane; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400074A")]
	private VisualElement m_FixedPane; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x400074B")]
	private VisualElement m_FlexedPane; //Field offset: 0x2E0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	[Token(Token = "0x400074C")]
	private float m_FixedPaneDimension; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x400074D")]
	private VisualElement m_DragLine; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x400074E")]
	private VisualElement m_DragLineAnchor; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x400074F")]
	private bool m_CollapseMode; //Field offset: 0x300
	[FieldOffset(Offset = "0x301")]
	[Token(Token = "0x4000750")]
	private bool m_PendingCollapseToExecute; //Field offset: 0x301
	[FieldOffset(Offset = "0x304")]
	[Token(Token = "0x4000751")]
	private int m_CollapsedChildIndex; //Field offset: 0x304
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000752")]
	private VisualElement m_Content; //Field offset: 0x308
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000753")]
	private TwoPaneSplitViewOrientation m_Orientation; //Field offset: 0x310
	[FieldOffset(Offset = "0x314")]
	[Token(Token = "0x4000754")]
	private int m_FixedPaneIndex; //Field offset: 0x314
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000755")]
	private float m_FixedPaneInitialDimension; //Field offset: 0x318
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000756")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TwoPaneSplitViewResizer m_Resizer; //Field offset: 0x320

	[Token(Token = "0x170001F4")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x33C1F50", Offset = "0x33C1350", Length = "0xA")]
		[Token(Token = "0x6000B38")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170001EF")]
	internal VisualElement dragLine
	{
		[Address(RVA = "0x336AFA0", Offset = "0x336A3A0", Length = "0x8")]
		[Token(Token = "0x6000B25")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170001ED")]
	public VisualElement fixedPane
	{
		[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
		[Token(Token = "0x6000B23")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F3")]
	internal float fixedPaneDimension
	{
		[Address(RVA = "0x33C1F60", Offset = "0x33C1360", Length = "0x34")]
		[Token(Token = "0x6000B2C")]
		internal get { } //Length: 52
		[Address(RVA = "0x33C1FB0", Offset = "0x33C13B0", Length = "0x1B")]
		[Token(Token = "0x6000B2D")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 27
	}

	[CreateProperty]
	[Token(Token = "0x170001F0")]
	public int fixedPaneIndex
	{
		[Address(RVA = "0x33C1FA0", Offset = "0x33C13A0", Length = "0x7")]
		[Token(Token = "0x6000B26")]
		 get { } //Length: 7
		[Address(RVA = "0x33C1FD0", Offset = "0x33C13D0", Length = "0x9C")]
		[Token(Token = "0x6000B27")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x170001F1")]
	public float fixedPaneInitialDimension
	{
		[Address(RVA = "0x2EF5150", Offset = "0x2EF4550", Length = "0x9")]
		[Token(Token = "0x6000B28")]
		 get { } //Length: 9
		[Address(RVA = "0x33C2070", Offset = "0x33C1470", Length = "0xA7")]
		[Token(Token = "0x6000B29")]
		 set { } //Length: 167
	}

	[Token(Token = "0x170001EE")]
	public VisualElement flexedPane
	{
		[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
		[Token(Token = "0x6000B24")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001F2")]
	public TwoPaneSplitViewOrientation orientation
	{
		[Address(RVA = "0x1665700", Offset = "0x1664B00", Length = "0x7")]
		[Token(Token = "0x6000B2A")]
		 get { } //Length: 7
		[Address(RVA = "0x33C2120", Offset = "0x33C1520", Length = "0xA3")]
		[Token(Token = "0x6000B2B")]
		 set { } //Length: 163
	}

	[Address(RVA = "0x33C18D0", Offset = "0x33C0CD0", Length = "0x5CF")]
	[Token(Token = "0x6000B3C")]
	private static TwoPaneSplitView() { }

	[Address(RVA = "0x33C1EA0", Offset = "0x33C12A0", Length = "0xA3")]
	[Token(Token = "0x6000B2E")]
	public TwoPaneSplitView() { }

	[Address(RVA = "0x33BE7B0", Offset = "0x33BDBB0", Length = "0x79D")]
	[Token(Token = "0x6000B33")]
	private void AdjustPanesBasedOnAnchor() { }

	[Address(RVA = "0x33BEF50", Offset = "0x33BE350", Length = "0x3D1")]
	[Token(Token = "0x6000B30")]
	public void CollapseChild(int index) { }

	[Address(RVA = "0x33C1F50", Offset = "0x33C1350", Length = "0xA")]
	[Token(Token = "0x6000B38")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x336AFA0", Offset = "0x336A3A0", Length = "0x8")]
	[Token(Token = "0x6000B25")]
	internal VisualElement get_dragLine() { }

	[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
	[Token(Token = "0x6000B23")]
	public VisualElement get_fixedPane() { }

	[Address(RVA = "0x33C1F60", Offset = "0x33C1360", Length = "0x34")]
	[Token(Token = "0x6000B2C")]
	internal float get_fixedPaneDimension() { }

	[Address(RVA = "0x33C1FA0", Offset = "0x33C13A0", Length = "0x7")]
	[Token(Token = "0x6000B26")]
	public int get_fixedPaneIndex() { }

	[Address(RVA = "0x2EF5150", Offset = "0x2EF4550", Length = "0x9")]
	[Token(Token = "0x6000B28")]
	public float get_fixedPaneInitialDimension() { }

	[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
	[Token(Token = "0x6000B24")]
	public VisualElement get_flexedPane() { }

	[Address(RVA = "0x1665700", Offset = "0x1664B00", Length = "0x7")]
	[Token(Token = "0x6000B2A")]
	public TwoPaneSplitViewOrientation get_orientation() { }

	[Address(RVA = "0x33BF330", Offset = "0x33BE730", Length = "0xE2")]
	[Token(Token = "0x6000B34")]
	private void IdentifyLeftAndRightPane() { }

	[Address(RVA = "0x33BF420", Offset = "0x33BE820", Length = "0x408")]
	[Token(Token = "0x6000B31")]
	internal override void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) { }

	[Address(RVA = "0x33BF830", Offset = "0x33BEC30", Length = "0x12A")]
	[Token(Token = "0x6000B32")]
	private void OnPostDisplaySetup(GeometryChangedEvent evt) { }

	[Address(RVA = "0x33BF960", Offset = "0x33BED60", Length = "0xF")]
	[Token(Token = "0x6000B36")]
	private void OnSizeChange(GeometryChangedEvent evt) { }

	[Address(RVA = "0x33BF970", Offset = "0x33BED70", Length = "0x3A")]
	[Token(Token = "0x6000B39")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x33BF9B0", Offset = "0x33BEDB0", Length = "0x1289")]
	[Token(Token = "0x6000B35")]
	private void PostDisplaySetup() { }

	[Address(RVA = "0x33C1FB0", Offset = "0x33C13B0", Length = "0x1B")]
	[Token(Token = "0x6000B2D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_fixedPaneDimension(float value) { }

	[Address(RVA = "0x33C1FD0", Offset = "0x33C13D0", Length = "0x9C")]
	[Token(Token = "0x6000B27")]
	public void set_fixedPaneIndex(int value) { }

	[Address(RVA = "0x33C2070", Offset = "0x33C1470", Length = "0xA7")]
	[Token(Token = "0x6000B29")]
	public void set_fixedPaneInitialDimension(float value) { }

	[Address(RVA = "0x33C2120", Offset = "0x33C1520", Length = "0xA3")]
	[Token(Token = "0x6000B2B")]
	public void set_orientation(TwoPaneSplitViewOrientation value) { }

	[Address(RVA = "0x33C0C40", Offset = "0x33C0040", Length = "0x18B")]
	[Token(Token = "0x6000B3A")]
	private void SetDragLineOffset(float offset) { }

	[Address(RVA = "0x33C0DD0", Offset = "0x33C01D0", Length = "0x18D")]
	[Token(Token = "0x6000B3B")]
	private void SetFixedPaneDimension(float dimension) { }

	[Address(RVA = "0x33C0F60", Offset = "0x33C0360", Length = "0x26E")]
	[Token(Token = "0x6000B2F")]
	private void SetupSplitView() { }

	[Address(RVA = "0x33C11D0", Offset = "0x33C05D0", Length = "0x6FB")]
	[Token(Token = "0x6000B37")]
	private void UpdateLayout(bool updateFixedPane, bool updateDragLine) { }

}

