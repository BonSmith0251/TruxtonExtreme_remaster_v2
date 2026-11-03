namespace UnityEngine.UIElements;

[Token(Token = "0x20000D6")]
public class GenericDropdownMenu : AbstractGenericMenu
{
	[CompilerGenerated]
	[Token(Token = "0x20000D8")]
	private struct <>c__DisplayClass56_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000435")]
		public GenericDropdownMenu <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000436")]
		public int selectedIndex; //Field offset: 0x8

	}

	[Token(Token = "0x20000D7")]
	public class MenuItem
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000431")]
		public string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000432")]
		public VisualElement element; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000433")]
		public Action action; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000434")]
		public Action<Object> actionUserData; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006B6")]
		public MenuItem() { }

	}

	[Token(Token = "0x4000416")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000417")]
	public static readonly string itemUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000418")]
	public static readonly string itemContentUssClassName; //Field offset: 0x10
	[Token(Token = "0x4000419")]
	public static readonly string labelUssClassName; //Field offset: 0x18
	[Token(Token = "0x400041A")]
	public static readonly string containerInnerUssClassName; //Field offset: 0x20
	[Token(Token = "0x400041B")]
	public static readonly string containerOuterUssClassName; //Field offset: 0x28
	[Token(Token = "0x400041C")]
	public static readonly string checkmarkUssClassName; //Field offset: 0x30
	[Token(Token = "0x400041D")]
	public static readonly string separatorUssClassName; //Field offset: 0x38
	[Token(Token = "0x400041E")]
	public static readonly string contentWidthUssClassName; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400041F")]
	private List<MenuItem> m_Items; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000420")]
	private VisualElement m_MenuContainer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000421")]
	private VisualElement m_OuterContainer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000422")]
	private ScrollView m_ScrollView; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000423")]
	private VisualElement m_PanelRootVisualContainer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000424")]
	private VisualElement m_TargetElement; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000425")]
	private Rect m_DesiredRect; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000426")]
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000427")]
	private float m_PositionTop; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000428")]
	private float m_PositionLeft; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000429")]
	private float m_ContentWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400042A")]
	private bool m_FitContentWidth; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x400042B")]
	private bool m_ShownAboveTarget; //Field offset: 0x65
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x400042C")]
	private bool <isSingleSelectionDropdown>k__BackingField; //Field offset: 0x66
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x67")]
	[Token(Token = "0x400042D")]
	private bool <closeOnParentResize>k__BackingField; //Field offset: 0x67
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400042E")]
	private Action onOpen; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400042F")]
	private Action onClose; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000430")]
	private Vector2 m_MousePosition; //Field offset: 0x78

	[Token(Token = "0x170000FA")]
	internal bool closeOnParentResize
	{
		[Address(RVA = "0x23382B0", Offset = "0x23376B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000696")]
		internal get { } //Length: 5
		[Address(RVA = "0x33439D0", Offset = "0x3342DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000697")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000FB")]
	public VisualElement contentContainer
	{
		[Address(RVA = "0x33439A0", Offset = "0x3342DA0", Length = "0x2A")]
		[Token(Token = "0x6000698")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000F9")]
	internal bool isSingleSelectionDropdown
	{
		[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000694")]
		internal get { } //Length: 5
		[Address(RVA = "0x2E22780", Offset = "0x2E21B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000695")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x3343300", Offset = "0x3342700", Length = "0x322")]
	[Token(Token = "0x60006B3")]
	private static GenericDropdownMenu() { }

	[Address(RVA = "0x3343630", Offset = "0x3342A30", Length = "0x364")]
	[Token(Token = "0x6000699")]
	public GenericDropdownMenu() { }

	[Address(RVA = "0x3343050", Offset = "0x3342450", Length = "0xAE")]
	[CompilerGenerated]
	[Token(Token = "0x60006B4")]
	private void <Apply>g__UpdateSelectionDown|56_0(int newIndex, ref <>c__DisplayClass56_0 unnamed_param_1) { }

	[Address(RVA = "0x3343100", Offset = "0x3342500", Length = "0x9F")]
	[CompilerGenerated]
	[Token(Token = "0x60006B5")]
	private void <Apply>g__UpdateSelectionUp|56_1(int newIndex, ref <>c__DisplayClass56_0 unnamed_param_1) { }

	[Address(RVA = "0x333F480", Offset = "0x333E880", Length = "0x399")]
	[Token(Token = "0x60006AA")]
	private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data = null) { }

	[Address(RVA = "0x333F820", Offset = "0x333EC20", Length = "0x44")]
	[Token(Token = "0x60006A8")]
	public virtual void AddItem(string itemName, bool isChecked, Action<Object> action, object data) { }

	[Address(RVA = "0x333F440", Offset = "0x333E840", Length = "0x3D")]
	[Token(Token = "0x60006A7")]
	public virtual void AddItem(string itemName, bool isChecked, Action action) { }

	[Address(RVA = "0x333F870", Offset = "0x333EC70", Length = "0xBB")]
	[Token(Token = "0x60006A9")]
	public virtual void AddSeparator(string path) { }

	[Address(RVA = "0x333FC70", Offset = "0x333F070", Length = "0x34")]
	[Token(Token = "0x600069D")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	[Address(RVA = "0x333F930", Offset = "0x333ED30", Length = "0x314")]
	[Token(Token = "0x600069E")]
	private bool Apply(KeyboardNavigationOperation op) { }

	[Address(RVA = "0x333FCB0", Offset = "0x333F0B0", Length = "0x12E")]
	[Token(Token = "0x60006A5")]
	private void ChangeSelectedIndex(int newIndex, int previousIndex) { }

	[Address(RVA = "0x333FDE0", Offset = "0x333F1E0", Length = "0xED4")]
	[Token(Token = "0x60006AC")]
	private void DoDropDown(Rect position, VisualElement targetElement, bool anchored) { }

	[Address(RVA = "0x3340CC0", Offset = "0x33400C0", Length = "0x84")]
	[Token(Token = "0x60006AB")]
	public virtual void DropDown(Rect position, VisualElement targetElement, DropdownMenuSizeMode dropdownMenuSizeMode = 0) { }

	[Address(RVA = "0x3340D50", Offset = "0x3340150", Length = "0xD1B")]
	[Token(Token = "0x60006B1")]
	private void EnsureVisibilityInParent() { }

	[Address(RVA = "0x23382B0", Offset = "0x23376B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000696")]
	internal bool get_closeOnParentResize() { }

	[Address(RVA = "0x33439A0", Offset = "0x3342DA0", Length = "0x2A")]
	[Token(Token = "0x6000698")]
	public VisualElement get_contentContainer() { }

	[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000694")]
	internal bool get_isSingleSelectionDropdown() { }

	[Address(RVA = "0x3341A70", Offset = "0x3340E70", Length = "0x6CF")]
	[Token(Token = "0x60006B2")]
	private float GetLargestItemWidth() { }

	[Address(RVA = "0x3342140", Offset = "0x3341540", Length = "0x9D")]
	[Token(Token = "0x60006A6")]
	private int GetSelectedIndex() { }

	[Address(RVA = "0x33421E0", Offset = "0x33415E0", Length = "0x187")]
	[Token(Token = "0x600069C")]
	private void Hide(bool giveFocusBack = false) { }

	[Address(RVA = "0x3342370", Offset = "0x3341770", Length = "0x405")]
	[Token(Token = "0x600069A")]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x3342780", Offset = "0x3341B80", Length = "0x7")]
	[Token(Token = "0x60006AF")]
	private void OnContainerGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x3342790", Offset = "0x3341B90", Length = "0x319")]
	[Token(Token = "0x600069B")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x3342AB0", Offset = "0x3341EB0", Length = "0x129")]
	[Token(Token = "0x60006A2")]
	private void OnFocusOut(FocusOutEvent evt) { }

	[Address(RVA = "0x3342BE0", Offset = "0x3341FE0", Length = "0x23")]
	[Token(Token = "0x60006B0")]
	private void OnInitialDisplay(GeometryChangedEvent evt) { }

	[Address(RVA = "0x3342C10", Offset = "0x3342010", Length = "0x11")]
	[Token(Token = "0x60006A3")]
	private void OnParentResized(GeometryChangedEvent evt) { }

	[Address(RVA = "0x3342C30", Offset = "0x3342030", Length = "0x10F")]
	[Token(Token = "0x600069F")]
	private void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x3342D40", Offset = "0x3342140", Length = "0x10F")]
	[Token(Token = "0x60006A0")]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x3342E50", Offset = "0x3342250", Length = "0x15C")]
	[Token(Token = "0x60006A1")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x3342FB0", Offset = "0x33423B0", Length = "0xA")]
	[Token(Token = "0x60006AE")]
	private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x33439D0", Offset = "0x3342DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000697")]
	internal void set_closeOnParentResize(bool value) { }

	[Address(RVA = "0x2E22780", Offset = "0x2E21B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000695")]
	internal void set_isSingleSelectionDropdown(bool value) { }

	[Address(RVA = "0x3342FC0", Offset = "0x33423C0", Length = "0x82")]
	[Token(Token = "0x60006AD")]
	private void SetFitContentWidth(bool fit) { }

	[Address(RVA = "0x33431A0", Offset = "0x33425A0", Length = "0x157")]
	[Token(Token = "0x60006A4")]
	private void UpdateSelection(VisualElement target) { }

}

