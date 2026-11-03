namespace UnityEngine.UIElements;

[Token(Token = "0x2000152")]
public class Tab : VisualElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000155")]
	private sealed class <>c
	{
		[Token(Token = "0x40006C8")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40006C9")]
		public static EventCallback<TooltipEvent> <>9__67_0; //Field offset: 0x8

		[Address(RVA = "0x33C2220", Offset = "0x33C1620", Length = "0x67")]
		[Token(Token = "0x6000A61")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A62")]
		public <>c() { }

		[Address(RVA = "0x33C21D0", Offset = "0x33C15D0", Length = "0x1F")]
		[Token(Token = "0x6000A63")]
		internal void <.ctor>b__67_0(TooltipEvent evt) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000153")]
	internal class UxmlFactory : UxmlFactory<Tab, UxmlTraits>
	{

		[Address(RVA = "0x33C3E20", Offset = "0x33C3220", Length = "0x39")]
		[Token(Token = "0x6000A5E")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000154")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40006C5")]
		private readonly UxmlStringAttributeDescription m_Label; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40006C6")]
		private readonly UxmlImageAttributeDescription m_IconImage; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40006C7")]
		private readonly UxmlBoolAttributeDescription m_Closeable; //Field offset: 0x98

		[Address(RVA = "0x33C48D0", Offset = "0x33C3CD0", Length = "0x16E")]
		[Token(Token = "0x6000A60")]
		public UxmlTraits() { }

		[Address(RVA = "0x33C3FA0", Offset = "0x33C33A0", Length = "0x1FE")]
		[Token(Token = "0x6000A5F")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40006A5")]
	internal static readonly BindingId labelProperty; //Field offset: 0x0
	[Token(Token = "0x40006A6")]
	internal static readonly BindingId iconImageProperty; //Field offset: 0x98
	[Token(Token = "0x40006A7")]
	internal static readonly BindingId closeableProperty; //Field offset: 0x130
	[Token(Token = "0x40006A8")]
	public static readonly string ussClassName; //Field offset: 0x1C8
	[Token(Token = "0x40006A9")]
	public static readonly string tabHeaderUssClassName; //Field offset: 0x1D0
	[Token(Token = "0x40006AA")]
	public static readonly string tabHeaderImageUssClassName; //Field offset: 0x1D8
	[Token(Token = "0x40006AB")]
	public static readonly string tabHeaderEmptyImageUssClassName; //Field offset: 0x1E0
	[Token(Token = "0x40006AC")]
	public static readonly string tabHeaderStandaloneImageUssClassName; //Field offset: 0x1E8
	[Token(Token = "0x40006AD")]
	public static readonly string tabHeaderLabelUssClassName; //Field offset: 0x1F0
	[Token(Token = "0x40006AE")]
	public static readonly string tabHeaderEmptyLabeUssClassName; //Field offset: 0x1F8
	[Token(Token = "0x40006AF")]
	public static readonly string tabHeaderUnderlineUssClassName; //Field offset: 0x200
	[Token(Token = "0x40006B0")]
	public static readonly string contentUssClassName; //Field offset: 0x208
	[Token(Token = "0x40006B1")]
	public static readonly string draggingUssClassName; //Field offset: 0x210
	[Token(Token = "0x40006B2")]
	public static readonly string reorderableUssClassName; //Field offset: 0x218
	[Token(Token = "0x40006B3")]
	public static readonly string reorderableItemHandleUssClassName; //Field offset: 0x220
	[Token(Token = "0x40006B4")]
	public static readonly string reorderableItemHandleBarUssClassName; //Field offset: 0x228
	[Token(Token = "0x40006B5")]
	public static readonly string closeableUssClassName; //Field offset: 0x230
	[Token(Token = "0x40006B6")]
	public static readonly string closeButtonUssClassName; //Field offset: 0x238
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x40006B7")]
	private Action<Tab> selected; //Field offset: 0x2C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x40006B8")]
	private Func<Boolean> closing; //Field offset: 0x2D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40006B9")]
	private Action<Tab> closed; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40006BA")]
	private string m_Label; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x40006BB")]
	private Background m_IconImage; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x40006BC")]
	private bool m_Closeable; //Field offset: 0x308
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x40006BD")]
	private VisualElement m_ContentContainer; //Field offset: 0x310
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x40006BE")]
	private VisualElement m_DragHandle; //Field offset: 0x318
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x40006BF")]
	private VisualElement m_CloseButton; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x40006C0")]
	private VisualElement m_TabHeader; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x40006C1")]
	private Image m_TabHeaderImage; //Field offset: 0x330
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x40006C2")]
	private Label m_TabHeaderLabel; //Field offset: 0x338
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x40006C3")]
	private readonly TabDragger <dragger>k__BackingField; //Field offset: 0x340
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x40006C4")]
	private int <index>k__BackingField; //Field offset: 0x348

	[Token(Token = "0x14000026")]
	public event Action<Tab> closed
	{
		[Address(RVA = "0x33A70B0", Offset = "0x33A64B0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6000A44")]
		 add { } //Length: 186
		[Address(RVA = "0x33A7270", Offset = "0x33A6670", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6000A45")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000025")]
	public event Action<Tab> selected
	{
		[Address(RVA = "0x33A7170", Offset = "0x33A6570", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6000A42")]
		 add { } //Length: 186
		[Address(RVA = "0x33A7330", Offset = "0x33A6730", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6000A43")]
		 remove { } //Length: 186
	}

	[CreateProperty]
	[Token(Token = "0x170001C6")]
	public bool closeable
	{
		[Address(RVA = "0x33A7230", Offset = "0x33A6630", Length = "0x8")]
		[Token(Token = "0x6000A4D")]
		 get { } //Length: 8
		[Address(RVA = "0x33A73F0", Offset = "0x33A67F0", Length = "0x10C")]
		[Token(Token = "0x6000A4E")]
		 set { } //Length: 268
	}

	[Token(Token = "0x170001C7")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x3367950", Offset = "0x3366D50", Length = "0x8")]
		[Token(Token = "0x6000A4F")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001C5")]
	public Background iconImage
	{
		[Address(RVA = "0x33A7240", Offset = "0x33A6640", Length = "0x19")]
		[Token(Token = "0x6000A4B")]
		 get { } //Length: 25
		[Address(RVA = "0x33A7500", Offset = "0x33A6900", Length = "0x355")]
		[Token(Token = "0x6000A4C")]
		 set { } //Length: 853
	}

	[Token(Token = "0x170001C3")]
	internal int index
	{
		[Address(RVA = "0x33A7260", Offset = "0x33A6660", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A47")]
		internal get { } //Length: 7
		[Address(RVA = "0x33A7860", Offset = "0x33A6C60", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A48")]
		internal set { } //Length: 7
	}

	[CreateProperty]
	[Token(Token = "0x170001C4")]
	public string label
	{
		[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
		[Token(Token = "0x6000A49")]
		 get { } //Length: 8
		[Address(RVA = "0x33A7870", Offset = "0x33A6C70", Length = "0x155")]
		[Token(Token = "0x6000A4A")]
		 set { } //Length: 341
	}

	[Token(Token = "0x170001C2")]
	public VisualElement tabHeader
	{
		[Address(RVA = "0x1665720", Offset = "0x1664B20", Length = "0x8")]
		[Token(Token = "0x6000A46")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x33A5990", Offset = "0x33A4D90", Length = "0x842")]
	[Token(Token = "0x6000A5D")]
	private static Tab() { }

	[Address(RVA = "0x33A61E0", Offset = "0x33A55E0", Length = "0xE7C")]
	[Token(Token = "0x6000A51")]
	public Tab(string label, Background iconImage) { }

	[Address(RVA = "0x33A7060", Offset = "0x33A6460", Length = "0x41")]
	[Token(Token = "0x6000A50")]
	public Tab() { }

	[Address(RVA = "0x33A70B0", Offset = "0x33A64B0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6000A44")]
	public void add_closed(Action<Tab> value) { }

	[Address(RVA = "0x33A7170", Offset = "0x33A6570", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6000A42")]
	public void add_selected(Action<Tab> value) { }

	[Address(RVA = "0x33A5580", Offset = "0x33A4980", Length = "0x2B")]
	[Token(Token = "0x6000A56")]
	private void AddCloseButton() { }

	[Address(RVA = "0x33A55B0", Offset = "0x33A49B0", Length = "0x2D")]
	[Token(Token = "0x6000A53")]
	private void AddDragHandles() { }

	[Address(RVA = "0x33A55E0", Offset = "0x33A49E0", Length = "0x61")]
	[Token(Token = "0x6000A58")]
	internal void EnableTabCloseButton(bool enable) { }

	[Address(RVA = "0x33A5650", Offset = "0x33A4A50", Length = "0x6D")]
	[Token(Token = "0x6000A55")]
	internal void EnableTabDragHandles(bool enable) { }

	[Address(RVA = "0x33A7230", Offset = "0x33A6630", Length = "0x8")]
	[Token(Token = "0x6000A4D")]
	public bool get_closeable() { }

	[Address(RVA = "0x3367950", Offset = "0x3366D50", Length = "0x8")]
	[Token(Token = "0x6000A4F")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x33A7240", Offset = "0x33A6640", Length = "0x19")]
	[Token(Token = "0x6000A4B")]
	public Background get_iconImage() { }

	[Address(RVA = "0x33A7260", Offset = "0x33A6660", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A47")]
	internal int get_index() { }

	[Address(RVA = "0x2ED76E0", Offset = "0x2ED6AE0", Length = "0x8")]
	[Token(Token = "0x6000A49")]
	public string get_label() { }

	[Address(RVA = "0x1665720", Offset = "0x1664B20", Length = "0x8")]
	[Token(Token = "0x6000A46")]
	public VisualElement get_tabHeader() { }

	[Address(RVA = "0x33A56C0", Offset = "0x33A4AC0", Length = "0x73")]
	[Token(Token = "0x6000A5C")]
	private void OnCloseButtonClicked(PointerDownEvent evt) { }

	[Address(RVA = "0x33A5740", Offset = "0x33A4B40", Length = "0x1F")]
	[Token(Token = "0x6000A5B")]
	private void OnTabClicked(PointerDownEvent _) { }

	[Address(RVA = "0x33A7270", Offset = "0x33A6670", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6000A45")]
	public void remove_closed(Action<Tab> value) { }

	[Address(RVA = "0x33A7330", Offset = "0x33A6730", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6000A43")]
	public void remove_selected(Action<Tab> value) { }

	[Address(RVA = "0x33A5760", Offset = "0x33A4B60", Length = "0x53")]
	[Token(Token = "0x6000A57")]
	private void RemoveCloseButton() { }

	[Address(RVA = "0x33A57C0", Offset = "0x33A4BC0", Length = "0x53")]
	[Token(Token = "0x6000A54")]
	private void RemoveDragHandles() { }

	[Address(RVA = "0x33A73F0", Offset = "0x33A67F0", Length = "0x10C")]
	[Token(Token = "0x6000A4E")]
	public void set_closeable(bool value) { }

	[Address(RVA = "0x33A7500", Offset = "0x33A6900", Length = "0x355")]
	[Token(Token = "0x6000A4C")]
	public void set_iconImage(Background value) { }

	[Address(RVA = "0x33A7860", Offset = "0x33A6C60", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A48")]
	internal void set_index(int value) { }

	[Address(RVA = "0x33A7870", Offset = "0x33A6C70", Length = "0x155")]
	[Token(Token = "0x6000A4A")]
	public void set_label(string value) { }

	[Address(RVA = "0x33A5820", Offset = "0x33A4C20", Length = "0x36")]
	[Token(Token = "0x6000A59")]
	internal void SetActive() { }

	[Address(RVA = "0x33A5860", Offset = "0x33A4C60", Length = "0x36")]
	[Token(Token = "0x6000A5A")]
	internal void SetInactive() { }

	[Address(RVA = "0x33A58A0", Offset = "0x33A4CA0", Length = "0xEB")]
	[Token(Token = "0x6000A52")]
	private void UpdateTooltip(TooltipEvent evt) { }

}

