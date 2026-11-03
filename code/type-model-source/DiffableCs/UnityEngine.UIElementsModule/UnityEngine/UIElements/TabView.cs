namespace UnityEngine.UIElements;

[Token(Token = "0x200015A")]
[UxmlElement(null, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Tab)})]
public class TabView : VisualElement
{
	[CompilerGenerated]
	[Token(Token = "0x200015F")]
	private sealed class <>c__DisplayClass82_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006FF")]
		public string key; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AB5")]
		public <>c__DisplayClass82_0() { }

		[Address(RVA = "0x33C21F0", Offset = "0x33C15F0", Length = "0x25")]
		[Token(Token = "0x6000AB6")]
		internal bool <FindTabByKey>b__0(Tab tab) { }

	}

	[Token(Token = "0x200015E")]
	private class TabViewContentContainer : VisualElement
	{

		[Address(RVA = "0x33B6A00", Offset = "0x33B5E00", Length = "0x49")]
		[Token(Token = "0x6000AB4")]
		public TabViewContentContainer() { }

		[Address(RVA = "0x33B68E0", Offset = "0x33B5CE0", Length = "0x8D")]
		[Token(Token = "0x6000AB2")]
		internal virtual void OnChildAdded(VisualElement ve) { }

		[Address(RVA = "0x33B6970", Offset = "0x33B5D70", Length = "0x8D")]
		[Token(Token = "0x6000AB3")]
		internal virtual void OnChildRemoved(VisualElement ve) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200015B")]
	internal class UxmlFactory : UxmlFactory<TabView, UxmlTraits>
	{

		[Address(RVA = "0x33C3DE0", Offset = "0x33C31E0", Length = "0x39")]
		[Token(Token = "0x6000AAA")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200015C")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40006FB")]
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0x88

		[Address(RVA = "0x33C4D60", Offset = "0x33C4160", Length = "0xA6")]
		[Token(Token = "0x6000AAC")]
		public UxmlTraits() { }

		[Address(RVA = "0x33C43B0", Offset = "0x33C37B0", Length = "0x13B")]
		[Token(Token = "0x6000AAB")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x200015D")]
	private class ViewState : ISerializationCallbackReceiver
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006FC")]
		private bool m_HasPersistedData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40006FD")]
		private List<String> m_TabOrder; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x40006FE")]
		private string m_ActiveTabKey; //Field offset: 0x20

		[Address(RVA = "0x33C5330", Offset = "0x33C4730", Length = "0x69A")]
		[Token(Token = "0x6000AB1")]
		public ViewState() { }

		[Address(RVA = "0x33C4F70", Offset = "0x33C4370", Length = "0x196")]
		[Token(Token = "0x6000AAE")]
		internal void Apply(TabView tabView) { }

		[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
		[Token(Token = "0x6000AB0")]
		public override void OnAfterDeserialize() { }

		[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
		[Token(Token = "0x6000AAF")]
		public override void OnBeforeSerialize() { }

		[Address(RVA = "0x33C5110", Offset = "0x33C4510", Length = "0x213")]
		[Token(Token = "0x6000AAD")]
		internal void Save(TabView tabView) { }

	}

	[Token(Token = "0x40006E3")]
	internal static readonly BindingId reorderableProperty; //Field offset: 0x0
	[Token(Token = "0x40006E4")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x40006E5")]
	public static readonly string headerContainerClassName; //Field offset: 0xA0
	[Token(Token = "0x40006E6")]
	public static readonly string contentContainerUssClassName; //Field offset: 0xA8
	[Token(Token = "0x40006E7")]
	public static readonly string reorderableUssClassName; //Field offset: 0xB0
	[Token(Token = "0x40006E8")]
	public static readonly string verticalUssClassName; //Field offset: 0xB8
	[Token(Token = "0x40006E9")]
	public static readonly string viewportUssClassName; //Field offset: 0xC0
	[Token(Token = "0x40006EA")]
	public static readonly string nextButtonUssClassName; //Field offset: 0xC8
	[Token(Token = "0x40006EB")]
	public static readonly string previousButtonUssClassName; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x40006EC")]
	private readonly VisualElement <contentViewport>k__BackingField; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x40006ED")]
	private VisualElement m_HeaderContainer; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40006EE")]
	private VisualElement m_ContentContainer; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40006EF")]
	private List<Tab> m_Tabs; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x40006F0")]
	private List<VisualElement> m_TabHeaders; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x40006F1")]
	private Tab m_ActiveTab; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x40006F2")]
	private ViewState m_ViewState; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x40006F3")]
	private bool m_ApplyingViewState; //Field offset: 0x300
	[FieldOffset(Offset = "0x301")]
	[Token(Token = "0x40006F4")]
	private bool m_Reordering; //Field offset: 0x301
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x40006F5")]
	private RepeatButton <nextButton>k__BackingField; //Field offset: 0x308
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x40006F6")]
	private RepeatButton <previousButton>k__BackingField; //Field offset: 0x310
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x40006F7")]
	private Action<Tab, Tab> activeTabChanged; //Field offset: 0x318
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x40006F8")]
	private Action<Int32, Int32> tabReordered; //Field offset: 0x320
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x40006F9")]
	private Action<Tab, Int32> tabClosed; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x40006FA")]
	private bool m_Reorderable; //Field offset: 0x330

	[Token(Token = "0x170001D6")]
	public Tab activeTab
	{
		[Address(RVA = "0x336AFA0", Offset = "0x336A3A0", Length = "0x8")]
		[Token(Token = "0x6000A94")]
		 get { } //Length: 8
		[Address(RVA = "0x33B9020", Offset = "0x33B8420", Length = "0x1A5")]
		[Token(Token = "0x6000A95")]
		 set { } //Length: 421
	}

	[Token(Token = "0x170001CD")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
		[Token(Token = "0x6000A89")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001CE")]
	public VisualElement contentViewport
	{
		[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001CF")]
	internal VisualElement header
	{
		[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
		[Token(Token = "0x6000A8B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170001D5")]
	internal bool needsButtons
	{
		[Address(RVA = "0x33B8F60", Offset = "0x33B8360", Length = "0x1A")]
		[Token(Token = "0x6000A93")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x170001D2")]
	internal RepeatButton nextButton
	{
		[Address(RVA = "0x32A9220", Offset = "0x32A8620", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8E")]
		internal get { } //Length: 8
		[Address(RVA = "0x32AA010", Offset = "0x32A9410", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8F")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170001D3")]
	internal RepeatButton previousButton
	{
		[Address(RVA = "0x3367950", Offset = "0x3366D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A90")]
		internal get { } //Length: 8
		[Address(RVA = "0x33B91D0", Offset = "0x33B85D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A91")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170001D7")]
	public bool reorderable
	{
		[Address(RVA = "0x1665B60", Offset = "0x1664F60", Length = "0x8")]
		[Token(Token = "0x6000A96")]
		 get { } //Length: 8
		[Address(RVA = "0x33B91F0", Offset = "0x33B85F0", Length = "0x1C7")]
		[Token(Token = "0x6000A97")]
		 set { } //Length: 455
	}

	[Token(Token = "0x170001D4")]
	internal float scrollableWidth
	{
		[Address(RVA = "0x33B8F80", Offset = "0x33B8380", Length = "0x94")]
		[Token(Token = "0x6000A92")]
		internal get { } //Length: 148
	}

	[Token(Token = "0x170001D1")]
	internal List<VisualElement> tabHeaders
	{
		[Address(RVA = "0x3293220", Offset = "0x3292620", Length = "0x8")]
		[Token(Token = "0x6000A8D")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170001D0")]
	internal List<Tab> tabs
	{
		[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
		[Token(Token = "0x6000A8C")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x33B8390", Offset = "0x33B7790", Length = "0x41A")]
	[Token(Token = "0x6000AA7")]
	private static TabView() { }

	[Address(RVA = "0x33B87B0", Offset = "0x33B7BB0", Length = "0x7A3")]
	[Token(Token = "0x6000A98")]
	public TabView() { }

	[Address(RVA = "0x33B7F20", Offset = "0x33B7320", Length = "0x180")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA8")]
	private bool <OnNextClicked>b__70_0(VisualElement tab) { }

	[Address(RVA = "0x33B80B0", Offset = "0x33B74B0", Length = "0x12F")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA9")]
	private bool <OnPreviousClicked>b__71_0(VisualElement tab) { }

	[Address(RVA = "0x33B6A50", Offset = "0x33B5E50", Length = "0xD9")]
	[Token(Token = "0x6000AA6")]
	internal Tab FindTabByKey(string key) { }

	[Address(RVA = "0x336AFA0", Offset = "0x336A3A0", Length = "0x8")]
	[Token(Token = "0x6000A94")]
	public Tab get_activeTab() { }

	[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
	[Token(Token = "0x6000A89")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x102C7D0", Offset = "0x102BBD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8A")]
	public VisualElement get_contentViewport() { }

	[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
	[Token(Token = "0x6000A8B")]
	internal VisualElement get_header() { }

	[Address(RVA = "0x33B8F60", Offset = "0x33B8360", Length = "0x1A")]
	[Token(Token = "0x6000A93")]
	internal bool get_needsButtons() { }

	[Address(RVA = "0x32A9220", Offset = "0x32A8620", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8E")]
	internal RepeatButton get_nextButton() { }

	[Address(RVA = "0x3367950", Offset = "0x3366D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A90")]
	internal RepeatButton get_previousButton() { }

	[Address(RVA = "0x1665B60", Offset = "0x1664F60", Length = "0x8")]
	[Token(Token = "0x6000A96")]
	public bool get_reorderable() { }

	[Address(RVA = "0x33B8F80", Offset = "0x33B8380", Length = "0x94")]
	[Token(Token = "0x6000A92")]
	internal float get_scrollableWidth() { }

	[Address(RVA = "0x3293220", Offset = "0x3292620", Length = "0x8")]
	[Token(Token = "0x6000A8D")]
	internal List<VisualElement> get_tabHeaders() { }

	[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
	[Token(Token = "0x6000A8C")]
	internal List<Tab> get_tabs() { }

	[Address(RVA = "0x33B6B30", Offset = "0x33B5F30", Length = "0x108")]
	[Token(Token = "0x6000A9A")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x33B6C40", Offset = "0x33B6040", Length = "0x1F9")]
	[Token(Token = "0x6000AA1")]
	private void OnElementAdded(VisualElement ve) { }

	[Address(RVA = "0x33B6E40", Offset = "0x33B6240", Length = "0x1DE")]
	[Token(Token = "0x6000AA2")]
	private void OnElementRemoved(VisualElement ve) { }

	[Address(RVA = "0x33B7020", Offset = "0x33B6420", Length = "0x392")]
	[Token(Token = "0x6000A9B")]
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x33B73C0", Offset = "0x33B67C0", Length = "0x432")]
	[Token(Token = "0x6000A9C")]
	private void OnNextClicked() { }

	[Address(RVA = "0x33B7800", Offset = "0x33B6C00", Length = "0x37B")]
	[Token(Token = "0x6000A9D")]
	private void OnPreviousClicked() { }

	[Address(RVA = "0x33B7B80", Offset = "0x33B6F80", Length = "0x39")]
	[Token(Token = "0x6000AA4")]
	private void OnTabClosed(Tab tab) { }

	[Address(RVA = "0x33B7BC0", Offset = "0x33B6FC0", Length = "0x8")]
	[Token(Token = "0x6000AA3")]
	private void OnTabSelected(Tab tab) { }

	[Address(RVA = "0x33B7BD0", Offset = "0x33B6FD0", Length = "0xE5")]
	[Token(Token = "0x6000A99")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x33B7CC0", Offset = "0x33B70C0", Length = "0x216")]
	[Token(Token = "0x6000AA5")]
	public void ReorderTab(int from, int to) { }

	[Address(RVA = "0x33B7EE0", Offset = "0x33B72E0", Length = "0x3E")]
	[Token(Token = "0x6000A9F")]
	private void SaveViewState() { }

	[Address(RVA = "0x33B9020", Offset = "0x33B8420", Length = "0x1A5")]
	[Token(Token = "0x6000A95")]
	public void set_activeTab(Tab value) { }

	[Address(RVA = "0x32AA010", Offset = "0x32A9410", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8F")]
	private void set_nextButton(RepeatButton value) { }

	[Address(RVA = "0x33B91D0", Offset = "0x33B85D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A91")]
	private void set_previousButton(RepeatButton value) { }

	[Address(RVA = "0x33B91F0", Offset = "0x33B85F0", Length = "0x1C7")]
	[Token(Token = "0x6000A97")]
	public void set_reorderable(bool value) { }

	[Address(RVA = "0x33B81E0", Offset = "0x33B75E0", Length = "0x106")]
	[Token(Token = "0x6000A9E")]
	internal void UpdateButtons(Vector3 contentTransform) { }

	[Address(RVA = "0x33B82F0", Offset = "0x33B76F0", Length = "0x91")]
	[Token(Token = "0x6000AA0")]
	private void UpdateIndexes() { }

}

