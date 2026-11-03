namespace UnityEngine.UIElements;

[Token(Token = "0x200007A")]
public abstract class BaseListView : BaseVerticalCollectionView
{
	[CompilerGenerated]
	[Token(Token = "0x200007C")]
	private sealed class <>c__DisplayClass82_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000294")]
		public BaseListView <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000295")]
		public int itemsCountPreCallback; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000482")]
		public <>c__DisplayClass82_0() { }

		[Address(RVA = "0x3346180", Offset = "0x3345580", Length = "0x24")]
		[Token(Token = "0x6000483")]
		internal void <OnAddClicked>b__0() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200007B")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400028C")]
		private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; //Field offset: 0xC8
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400028D")]
		private readonly UxmlStringAttributeDescription m_HeaderTitle; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400028E")]
		private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x400028F")]
		private readonly UxmlBoolAttributeDescription m_AllowAdd; //Field offset: 0xE0
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4000290")]
		private readonly UxmlBoolAttributeDescription m_AllowRemove; //Field offset: 0xE8
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4000291")]
		private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode; //Field offset: 0xF0
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4000292")]
		private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; //Field offset: 0xF8
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4000293")]
		private readonly UxmlEnumAttributeDescription<BindingSourceSelectionMode> m_BindingSourceSelectionMode; //Field offset: 0x100

		[Address(RVA = "0x3349C20", Offset = "0x3349020", Length = "0x3D5")]
		[Token(Token = "0x6000481")]
		protected UxmlTraits() { }

		[Address(RVA = "0x33470C0", Offset = "0x33464C0", Length = "0x398")]
		[Token(Token = "0x6000480")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000246")]
	private static readonly string k_SizeFieldLabel; //Field offset: 0x0
	[Token(Token = "0x4000247")]
	internal static readonly BindingId showBoundCollectionSizeProperty; //Field offset: 0x8
	[Token(Token = "0x4000248")]
	internal static readonly BindingId showFoldoutHeaderProperty; //Field offset: 0xA0
	[Token(Token = "0x4000249")]
	internal static readonly BindingId headerTitleProperty; //Field offset: 0x138
	[Token(Token = "0x400024A")]
	internal static readonly BindingId makeHeaderProperty; //Field offset: 0x1D0
	[Token(Token = "0x400024B")]
	internal static readonly BindingId makeFooterProperty; //Field offset: 0x268
	[Token(Token = "0x400024C")]
	internal static readonly BindingId showAddRemoveFooterProperty; //Field offset: 0x300
	[Token(Token = "0x400024D")]
	internal static readonly BindingId bindingSourceSelectionModeProperty; //Field offset: 0x398
	[Token(Token = "0x400024E")]
	internal static readonly BindingId reorderModeProperty; //Field offset: 0x430
	[Token(Token = "0x400024F")]
	internal static readonly BindingId makeNoneElementProperty; //Field offset: 0x4C8
	[Token(Token = "0x4000250")]
	internal static readonly BindingId allowAddProperty; //Field offset: 0x560
	[Token(Token = "0x4000251")]
	internal static readonly BindingId overridingAddButtonBehaviorProperty; //Field offset: 0x5F8
	[Token(Token = "0x4000252")]
	internal static readonly BindingId onAddProperty; //Field offset: 0x690
	[Token(Token = "0x4000253")]
	internal static readonly BindingId allowRemoveProperty; //Field offset: 0x728
	[Token(Token = "0x4000254")]
	internal static readonly BindingId onRemoveProperty; //Field offset: 0x7C0
	[Token(Token = "0x4000277")]
	public static readonly string ussClassName; //Field offset: 0x858
	[Token(Token = "0x4000278")]
	public static readonly string itemUssClassName; //Field offset: 0x860
	[Token(Token = "0x4000279")]
	public static readonly string emptyLabelUssClassName; //Field offset: 0x868
	[Token(Token = "0x400027A")]
	public static readonly string overMaxMultiEditLimitClassName; //Field offset: 0x870
	[Token(Token = "0x400027B")]
	public static readonly string reorderableUssClassName; //Field offset: 0x878
	[Token(Token = "0x400027C")]
	public static readonly string reorderableItemUssClassName; //Field offset: 0x880
	[Token(Token = "0x400027D")]
	public static readonly string reorderableItemContainerUssClassName; //Field offset: 0x888
	[Token(Token = "0x400027E")]
	public static readonly string reorderableItemHandleUssClassName; //Field offset: 0x890
	[Token(Token = "0x400027F")]
	public static readonly string reorderableItemHandleBarUssClassName; //Field offset: 0x898
	[Token(Token = "0x4000280")]
	public static readonly string footerUssClassName; //Field offset: 0x8A0
	[Token(Token = "0x4000281")]
	public static readonly string foldoutHeaderUssClassName; //Field offset: 0x8A8
	[Token(Token = "0x4000282")]
	public static readonly string arraySizeFieldUssClassName; //Field offset: 0x8B0
	[Token(Token = "0x4000283")]
	public static readonly string arraySizeFieldWithHeaderUssClassName; //Field offset: 0x8B8
	[Token(Token = "0x4000284")]
	public static readonly string arraySizeFieldWithFooterUssClassName; //Field offset: 0x8C0
	[Token(Token = "0x4000285")]
	public static readonly string listViewWithHeaderUssClassName; //Field offset: 0x8C8
	[Token(Token = "0x4000286")]
	public static readonly string listViewWithFooterUssClassName; //Field offset: 0x8D0
	[Token(Token = "0x4000287")]
	public static readonly string scrollViewWithFooterUssClassName; //Field offset: 0x8D8
	[Token(Token = "0x4000288")]
	public static readonly string footerAddButtonName; //Field offset: 0x8E0
	[Token(Token = "0x4000289")]
	public static readonly string footerRemoveButtonName; //Field offset: 0x8E8
	[Token(Token = "0x400028B")]
	private static readonly string k_EmptyListStr; //Field offset: 0x8F0
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x4000255")]
	private bool m_ShowBoundCollectionSize; //Field offset: 0x3C8
	[FieldOffset(Offset = "0x3C9")]
	[Token(Token = "0x4000256")]
	private bool m_ShowFoldoutHeader; //Field offset: 0x3C9
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x4000257")]
	private string m_HeaderTitle; //Field offset: 0x3D0
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x4000258")]
	private VisualElement drawnHeader; //Field offset: 0x3D8
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x4000259")]
	private Func<VisualElement> m_MakeHeader; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x400025A")]
	private VisualElement drawnFooter; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x400025B")]
	private Func<VisualElement> m_MakeFooter; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x400025C")]
	private bool m_ShowAddRemoveFooter; //Field offset: 0x3F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x400025D")]
	private Action<IEnumerable`1<Int32>> itemsAdded; //Field offset: 0x400
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x400025E")]
	private Action<IEnumerable`1<Int32>> itemsRemoved; //Field offset: 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x400025F")]
	private Action itemsSourceSizeChanged; //Field offset: 0x410
	[FieldOffset(Offset = "0x418")]
	[Token(Token = "0x4000260")]
	private IVisualElementScheduledItem m_TrackedItem; //Field offset: 0x418
	[FieldOffset(Offset = "0x420")]
	[Token(Token = "0x4000261")]
	private Action m_TrackCount; //Field offset: 0x420
	[FieldOffset(Offset = "0x428")]
	[Token(Token = "0x4000262")]
	private Func<Boolean> m_WhileAutoAssign; //Field offset: 0x428
	[FieldOffset(Offset = "0x430")]
	[Token(Token = "0x4000263")]
	private BindingSourceSelectionMode m_BindingSourceSelectionMode; //Field offset: 0x430
	[FieldOffset(Offset = "0x438")]
	[Token(Token = "0x4000264")]
	private Label m_ListViewLabel; //Field offset: 0x438
	[FieldOffset(Offset = "0x440")]
	[Token(Token = "0x4000265")]
	private Foldout m_Foldout; //Field offset: 0x440
	[FieldOffset(Offset = "0x448")]
	[Token(Token = "0x4000266")]
	private TextField m_ArraySizeField; //Field offset: 0x448
	[FieldOffset(Offset = "0x450")]
	[Token(Token = "0x4000267")]
	private bool m_IsOverMultiEditLimit; //Field offset: 0x450
	[FieldOffset(Offset = "0x458")]
	[Token(Token = "0x4000268")]
	private VisualElement m_Footer; //Field offset: 0x458
	[FieldOffset(Offset = "0x460")]
	[Token(Token = "0x4000269")]
	private Button m_AddButton; //Field offset: 0x460
	[FieldOffset(Offset = "0x468")]
	[Token(Token = "0x400026A")]
	private Button m_RemoveButton; //Field offset: 0x468
	[FieldOffset(Offset = "0x470")]
	[Token(Token = "0x400026B")]
	private Action<IEnumerable`1<Int32>> m_ItemAddedCallback; //Field offset: 0x470
	[FieldOffset(Offset = "0x478")]
	[Token(Token = "0x400026C")]
	private Action<IEnumerable`1<Int32>> m_ItemRemovedCallback; //Field offset: 0x478
	[FieldOffset(Offset = "0x480")]
	[Token(Token = "0x400026D")]
	private Action m_ItemsSourceSizeChangedCallback; //Field offset: 0x480
	[FieldOffset(Offset = "0x488")]
	[Token(Token = "0x400026E")]
	private ListViewReorderMode m_ReorderMode; //Field offset: 0x488
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x490")]
	[Token(Token = "0x400026F")]
	private Action reorderModeChanged; //Field offset: 0x490
	[FieldOffset(Offset = "0x498")]
	[Token(Token = "0x4000270")]
	private VisualElement m_NoneElement; //Field offset: 0x498
	[FieldOffset(Offset = "0x4A0")]
	[Token(Token = "0x4000271")]
	private Func<VisualElement> m_MakeNoneElement; //Field offset: 0x4A0
	[FieldOffset(Offset = "0x4A8")]
	[Token(Token = "0x4000272")]
	private bool m_AllowAdd; //Field offset: 0x4A8
	[FieldOffset(Offset = "0x4B0")]
	[Token(Token = "0x4000273")]
	private Action<BaseListView, Button> m_OverridingAddButtonBehavior; //Field offset: 0x4B0
	[FieldOffset(Offset = "0x4B8")]
	[Token(Token = "0x4000274")]
	private Action<BaseListView> m_OnAdd; //Field offset: 0x4B8
	[FieldOffset(Offset = "0x4C0")]
	[Token(Token = "0x4000275")]
	private bool m_AllowRemove; //Field offset: 0x4C0
	[FieldOffset(Offset = "0x4C8")]
	[Token(Token = "0x4000276")]
	private Action<BaseListView> m_OnRemove; //Field offset: 0x4C8
	[FieldOffset(Offset = "0x4D0")]
	[Token(Token = "0x400028A")]
	private string m_MaxMultiEditStr; //Field offset: 0x4D0

	[Token(Token = "0x14000010")]
	internal event Action reorderModeChanged
	{
		[Address(RVA = "0x32197F0", Offset = "0x3218BF0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000467")]
		internal add { } //Length: 162
		[Address(RVA = "0x3219D50", Offset = "0x3219150", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000468")]
		internal remove { } //Length: 162
	}

	[CreateProperty]
	[Token(Token = "0x170000A6")]
	public bool allowAdd
	{
		[Address(RVA = "0x32198A0", Offset = "0x3218CA0", Length = "0x8")]
		[Token(Token = "0x600046D")]
		 get { } //Length: 8
		[Address(RVA = "0x3219E00", Offset = "0x3219200", Length = "0x97")]
		[Token(Token = "0x600046E")]
		 set { } //Length: 151
	}

	[CreateProperty]
	[Token(Token = "0x170000A9")]
	public bool allowRemove
	{
		[Address(RVA = "0x32198B0", Offset = "0x3218CB0", Length = "0x8")]
		[Token(Token = "0x6000473")]
		 get { } //Length: 8
		[Address(RVA = "0x3219EA0", Offset = "0x32192A0", Length = "0x89")]
		[Token(Token = "0x6000474")]
		 set { } //Length: 137
	}

	[Token(Token = "0x170000A1")]
	internal bool autoAssignSource
	{
		[Address(RVA = "0x32198C0", Offset = "0x3218CC0", Length = "0xB")]
		[Token(Token = "0x6000457")]
		internal get { } //Length: 11
	}

	[CreateProperty]
	[Token(Token = "0x170000A0")]
	public BindingSourceSelectionMode bindingSourceSelectionMode
	{
		[Address(RVA = "0x32198D0", Offset = "0x3218CD0", Length = "0x7")]
		[Token(Token = "0x6000455")]
		 get { } //Length: 7
		[Address(RVA = "0x3219F30", Offset = "0x3219330", Length = "0xC3")]
		[Token(Token = "0x6000456")]
		 set { } //Length: 195
	}

	[Token(Token = "0x170000A2")]
	internal VisualElement footer
	{
		[Address(RVA = "0x32198E0", Offset = "0x3218CE0", Length = "0x8")]
		[Token(Token = "0x6000460")]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x17000099")]
	public string headerTitle
	{
		[Address(RVA = "0x32198F0", Offset = "0x3218CF0", Length = "0x8")]
		[Token(Token = "0x6000449")]
		 get { } //Length: 8
		[Address(RVA = "0x321A000", Offset = "0x3219400", Length = "0xCC")]
		[Token(Token = "0x600044A")]
		 set { } //Length: 204
	}

	[CreateProperty]
	[Token(Token = "0x1700009B")]
	public Func<VisualElement> makeFooter
	{
		[Address(RVA = "0x3219900", Offset = "0x3218D00", Length = "0x8")]
		[Token(Token = "0x600044D")]
		 get { } //Length: 8
		[Address(RVA = "0x321A0D0", Offset = "0x32194D0", Length = "0x24B")]
		[Token(Token = "0x600044E")]
		 set { } //Length: 587
	}

	[CreateProperty]
	[Token(Token = "0x1700009A")]
	public Func<VisualElement> makeHeader
	{
		[Address(RVA = "0x3219910", Offset = "0x3218D10", Length = "0x8")]
		[Token(Token = "0x600044B")]
		 get { } //Length: 8
		[Address(RVA = "0x321A320", Offset = "0x3219720", Length = "0x2B5")]
		[Token(Token = "0x600044C")]
		 set { } //Length: 693
	}

	[CreateProperty]
	[Token(Token = "0x170000A5")]
	public Func<VisualElement> makeNoneElement
	{
		[Address(RVA = "0x3219920", Offset = "0x3218D20", Length = "0x8")]
		[Token(Token = "0x600046B")]
		 get { } //Length: 8
		[Address(RVA = "0x321A5E0", Offset = "0x32199E0", Length = "0xD5")]
		[Token(Token = "0x600046C")]
		 set { } //Length: 213
	}

	[CreateProperty]
	[Token(Token = "0x170000A8")]
	public Action<BaseListView> onAdd
	{
		[Address(RVA = "0x3219930", Offset = "0x3218D30", Length = "0x8")]
		[Token(Token = "0x6000471")]
		 get { } //Length: 8
		[Address(RVA = "0x321A6C0", Offset = "0x3219AC0", Length = "0xA5")]
		[Token(Token = "0x6000472")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x170000AA")]
	public Action<BaseListView> onRemove
	{
		[Address(RVA = "0x3219940", Offset = "0x3218D40", Length = "0x8")]
		[Token(Token = "0x6000475")]
		 get { } //Length: 8
		[Address(RVA = "0x321A770", Offset = "0x3219B70", Length = "0xA5")]
		[Token(Token = "0x6000476")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x170000A7")]
	public Action<BaseListView, Button> overridingAddButtonBehavior
	{
		[Address(RVA = "0x3219950", Offset = "0x3218D50", Length = "0x8")]
		[Token(Token = "0x600046F")]
		 get { } //Length: 8
		[Address(RVA = "0x321A820", Offset = "0x3219C20", Length = "0xA5")]
		[Token(Token = "0x6000470")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x170000A4")]
	public ListViewReorderMode reorderMode
	{
		[Address(RVA = "0x3219960", Offset = "0x3218D60", Length = "0x7")]
		[Token(Token = "0x6000469")]
		 get { } //Length: 7
		[Address(RVA = "0x321A8D0", Offset = "0x3219CD0", Length = "0xB8")]
		[Token(Token = "0x600046A")]
		 set { } //Length: 184
	}

	[CreateProperty]
	[Token(Token = "0x1700009C")]
	public bool showAddRemoveFooter
	{
		[Address(RVA = "0x3219970", Offset = "0x3218D70", Length = "0xC")]
		[Token(Token = "0x600044F")]
		 get { } //Length: 12
		[Address(RVA = "0x321A990", Offset = "0x3219D90", Length = "0x10B")]
		[Token(Token = "0x6000450")]
		 set { } //Length: 267
	}

	[CreateProperty]
	[Token(Token = "0x17000097")]
	public bool showBoundCollectionSize
	{
		[Address(RVA = "0x3219980", Offset = "0x3218D80", Length = "0x8")]
		[Token(Token = "0x6000442")]
		 get { } //Length: 8
		[Address(RVA = "0x321AAA0", Offset = "0x3219EA0", Length = "0x86")]
		[Token(Token = "0x6000443")]
		 set { } //Length: 134
	}

	[CreateProperty]
	[Token(Token = "0x17000098")]
	public bool showFoldoutHeader
	{
		[Address(RVA = "0x3219990", Offset = "0x3218D90", Length = "0x8")]
		[Token(Token = "0x6000444")]
		 get { } //Length: 8
		[Address(RVA = "0x321AB30", Offset = "0x3219F30", Length = "0x22A")]
		[Token(Token = "0x6000445")]
		 set { } //Length: 554
	}

	[Token(Token = "0x1700009E")]
	private Action trackCount
	{
		[Address(RVA = "0x32199A0", Offset = "0x3218DA0", Length = "0x8A")]
		[Token(Token = "0x6000453")]
		private get { } //Length: 138
	}

	[Token(Token = "0x1700009D")]
	private IVisualElementScheduledItem trackItemCount
	{
		[Address(RVA = "0x3219A30", Offset = "0x3218E30", Length = "0x206")]
		[Token(Token = "0x6000452")]
		private get { } //Length: 518
	}

	[Token(Token = "0x1700009F")]
	private Func<Boolean> untilManualBindingSourceSelectionMode
	{
		[Address(RVA = "0x3219C40", Offset = "0x3219040", Length = "0x8A")]
		[Token(Token = "0x6000454")]
		private get { } //Length: 138
	}

	[Token(Token = "0x170000A3")]
	public BaseListViewController viewController
	{
		[Address(RVA = "0x3219CD0", Offset = "0x32190D0", Length = "0x75")]
		[Token(Token = "0x6000461")]
		 get { } //Length: 117
	}

	[Address(RVA = "0x3218310", Offset = "0x3217710", Length = "0x12A7")]
	[Token(Token = "0x600047D")]
	private static BaseListView() { }

	[Address(RVA = "0x32195E0", Offset = "0x32189E0", Length = "0x20B")]
	[Token(Token = "0x600047A")]
	public BaseListView(IList itemsSource, float itemHeight = -1) { }

	[Address(RVA = "0x32195C0", Offset = "0x32189C0", Length = "0x12")]
	[Token(Token = "0x6000479")]
	public BaseListView() { }

	[Address(RVA = "0x3217D10", Offset = "0x3217110", Length = "0xBE")]
	[CompilerGenerated]
	[Token(Token = "0x600047E")]
	private void <get_trackCount>b__65_0() { }

	[Address(RVA = "0x3217DD0", Offset = "0x32171D0", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x600047F")]
	private bool <get_untilManualBindingSourceSelectionMode>b__68_0() { }

	[Address(RVA = "0x32197F0", Offset = "0x3218BF0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6000467")]
	internal void add_reorderModeChanged(Action value) { }

	[Address(RVA = "0x3215EB0", Offset = "0x32152B0", Length = "0x1F4")]
	[Token(Token = "0x6000446")]
	private void AddFoldout() { }

	[Address(RVA = "0x32160B0", Offset = "0x32154B0", Length = "0x86")]
	[Token(Token = "0x6000458")]
	private void AddItems(int itemCount) { }

	[Address(RVA = "0x3216140", Offset = "0x3215540", Length = "0x54")]
	[Token(Token = "0x6000478")]
	internal virtual ICollectionDragAndDropController CreateDragAndDropController() { }

	[Address(RVA = "0x32161A0", Offset = "0x32155A0", Length = "0x95")]
	[Token(Token = "0x6000477")]
	internal virtual ListViewDragger CreateDragger() { }

	[Address(RVA = "0x3216240", Offset = "0x3215640", Length = "0x39")]
	[Token(Token = "0x6000462")]
	virtual void CreateVirtualizationController() { }

	[Address(RVA = "0x3216280", Offset = "0x3215680", Length = "0x457")]
	[Token(Token = "0x6000451")]
	private void EnableFooter(bool enabled) { }

	[Address(RVA = "0x32198A0", Offset = "0x3218CA0", Length = "0x8")]
	[Token(Token = "0x600046D")]
	public bool get_allowAdd() { }

	[Address(RVA = "0x32198B0", Offset = "0x3218CB0", Length = "0x8")]
	[Token(Token = "0x6000473")]
	public bool get_allowRemove() { }

	[Address(RVA = "0x32198C0", Offset = "0x3218CC0", Length = "0xB")]
	[Token(Token = "0x6000457")]
	internal bool get_autoAssignSource() { }

	[Address(RVA = "0x32198D0", Offset = "0x3218CD0", Length = "0x7")]
	[Token(Token = "0x6000455")]
	public BindingSourceSelectionMode get_bindingSourceSelectionMode() { }

	[Address(RVA = "0x32198E0", Offset = "0x3218CE0", Length = "0x8")]
	[Token(Token = "0x6000460")]
	internal VisualElement get_footer() { }

	[Address(RVA = "0x32198F0", Offset = "0x3218CF0", Length = "0x8")]
	[Token(Token = "0x6000449")]
	public string get_headerTitle() { }

	[Address(RVA = "0x3219900", Offset = "0x3218D00", Length = "0x8")]
	[Token(Token = "0x600044D")]
	public Func<VisualElement> get_makeFooter() { }

	[Address(RVA = "0x3219910", Offset = "0x3218D10", Length = "0x8")]
	[Token(Token = "0x600044B")]
	public Func<VisualElement> get_makeHeader() { }

	[Address(RVA = "0x3219920", Offset = "0x3218D20", Length = "0x8")]
	[Token(Token = "0x600046B")]
	public Func<VisualElement> get_makeNoneElement() { }

	[Address(RVA = "0x3219930", Offset = "0x3218D30", Length = "0x8")]
	[Token(Token = "0x6000471")]
	public Action<BaseListView> get_onAdd() { }

	[Address(RVA = "0x3219940", Offset = "0x3218D40", Length = "0x8")]
	[Token(Token = "0x6000475")]
	public Action<BaseListView> get_onRemove() { }

	[Address(RVA = "0x3219950", Offset = "0x3218D50", Length = "0x8")]
	[Token(Token = "0x600046F")]
	public Action<BaseListView, Button> get_overridingAddButtonBehavior() { }

	[Address(RVA = "0x3219960", Offset = "0x3218D60", Length = "0x7")]
	[Token(Token = "0x6000469")]
	public ListViewReorderMode get_reorderMode() { }

	[Address(RVA = "0x3219970", Offset = "0x3218D70", Length = "0xC")]
	[Token(Token = "0x600044F")]
	public bool get_showAddRemoveFooter() { }

	[Address(RVA = "0x3219980", Offset = "0x3218D80", Length = "0x8")]
	[Token(Token = "0x6000442")]
	public bool get_showBoundCollectionSize() { }

	[Address(RVA = "0x3219990", Offset = "0x3218D90", Length = "0x8")]
	[Token(Token = "0x6000444")]
	public bool get_showFoldoutHeader() { }

	[Address(RVA = "0x32199A0", Offset = "0x3218DA0", Length = "0x8A")]
	[Token(Token = "0x6000453")]
	private Action get_trackCount() { }

	[Address(RVA = "0x3219A30", Offset = "0x3218E30", Length = "0x206")]
	[Token(Token = "0x6000452")]
	private IVisualElementScheduledItem get_trackItemCount() { }

	[Address(RVA = "0x3219C40", Offset = "0x3219040", Length = "0x8A")]
	[Token(Token = "0x6000454")]
	private Func<Boolean> get_untilManualBindingSourceSelectionMode() { }

	[Address(RVA = "0x3219CD0", Offset = "0x32190D0", Length = "0x75")]
	[Token(Token = "0x6000461")]
	public BaseListViewController get_viewController() { }

	[Address(RVA = "0x32166E0", Offset = "0x3215AE0", Length = "0x32E")]
	[Token(Token = "0x600047C")]
	virtual bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	[Address(RVA = "0x3216A10", Offset = "0x3215E10", Length = "0x3A9")]
	[Token(Token = "0x600045D")]
	private void OnAddClicked() { }

	[Address(RVA = "0x3216DC0", Offset = "0x32161C0", Length = "0x11E")]
	[Token(Token = "0x600045E")]
	private void OnAfterAddClicked(int itemsCountPreCallback) { }

	[Address(RVA = "0x3216EE0", Offset = "0x32162E0", Length = "0x242")]
	[Token(Token = "0x6000459")]
	private void OnArraySizeFieldChanged(ChangeEvent<String> evt) { }

	[Address(RVA = "0x3217130", Offset = "0x3216530", Length = "0x1C")]
	[Token(Token = "0x6000464")]
	private void OnItemAdded(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x3217150", Offset = "0x3216550", Length = "0x1C")]
	[Token(Token = "0x6000465")]
	private void OnItemsRemoved(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x3217170", Offset = "0x3216570", Length = "0x75")]
	[Token(Token = "0x6000466")]
	private void OnItemsSourceSizeChanged() { }

	[Address(RVA = "0x32171F0", Offset = "0x32165F0", Length = "0x1BA")]
	[Token(Token = "0x600045F")]
	private void OnRemoveClicked() { }

	[Address(RVA = "0x32173B0", Offset = "0x32167B0", Length = "0x81")]
	[Token(Token = "0x600047B")]
	virtual void PostRefresh() { }

	[Address(RVA = "0x3219D50", Offset = "0x3219150", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6000468")]
	internal void remove_reorderModeChanged(Action value) { }

	[Address(RVA = "0x3217440", Offset = "0x3216840", Length = "0x64")]
	[Token(Token = "0x6000447")]
	private void RemoveFoldout() { }

	[Address(RVA = "0x3219E00", Offset = "0x3219200", Length = "0x97")]
	[Token(Token = "0x600046E")]
	public void set_allowAdd(bool value) { }

	[Address(RVA = "0x3219EA0", Offset = "0x32192A0", Length = "0x89")]
	[Token(Token = "0x6000474")]
	public void set_allowRemove(bool value) { }

	[Address(RVA = "0x3219F30", Offset = "0x3219330", Length = "0xC3")]
	[Token(Token = "0x6000456")]
	public void set_bindingSourceSelectionMode(BindingSourceSelectionMode value) { }

	[Address(RVA = "0x321A000", Offset = "0x3219400", Length = "0xCC")]
	[Token(Token = "0x600044A")]
	public void set_headerTitle(string value) { }

	[Address(RVA = "0x321A0D0", Offset = "0x32194D0", Length = "0x24B")]
	[Token(Token = "0x600044E")]
	public void set_makeFooter(Func<VisualElement> value) { }

	[Address(RVA = "0x321A320", Offset = "0x3219720", Length = "0x2B5")]
	[Token(Token = "0x600044C")]
	public void set_makeHeader(Func<VisualElement> value) { }

	[Address(RVA = "0x321A5E0", Offset = "0x32199E0", Length = "0xD5")]
	[Token(Token = "0x600046C")]
	public void set_makeNoneElement(Func<VisualElement> value) { }

	[Address(RVA = "0x321A6C0", Offset = "0x3219AC0", Length = "0xA5")]
	[Token(Token = "0x6000472")]
	public void set_onAdd(Action<BaseListView> value) { }

	[Address(RVA = "0x321A770", Offset = "0x3219B70", Length = "0xA5")]
	[Token(Token = "0x6000476")]
	public void set_onRemove(Action<BaseListView> value) { }

	[Address(RVA = "0x321A820", Offset = "0x3219C20", Length = "0xA5")]
	[Token(Token = "0x6000470")]
	public void set_overridingAddButtonBehavior(Action<BaseListView, Button> value) { }

	[Address(RVA = "0x321A8D0", Offset = "0x3219CD0", Length = "0xB8")]
	[Token(Token = "0x600046A")]
	public void set_reorderMode(ListViewReorderMode value) { }

	[Address(RVA = "0x321A990", Offset = "0x3219D90", Length = "0x10B")]
	[Token(Token = "0x6000450")]
	public void set_showAddRemoveFooter(bool value) { }

	[Address(RVA = "0x321AAA0", Offset = "0x3219EA0", Length = "0x86")]
	[Token(Token = "0x6000443")]
	public void set_showBoundCollectionSize(bool value) { }

	[Address(RVA = "0x321AB30", Offset = "0x3219F30", Length = "0x22A")]
	[Token(Token = "0x6000445")]
	public void set_showFoldoutHeader(bool value) { }

	[Address(RVA = "0x3217980", Offset = "0x3216D80", Length = "0x38C")]
	[Token(Token = "0x6000448")]
	internal void SetupArraySizeField() { }

	[Address(RVA = "0x32174B0", Offset = "0x32168B0", Length = "0x4C2")]
	[Token(Token = "0x6000463")]
	public virtual void SetViewController(CollectionViewController controller) { }

	[Address(RVA = "0x3217DE0", Offset = "0x32171E0", Length = "0xEF")]
	[Token(Token = "0x600045B")]
	internal void UpdateArraySizeField() { }

	[Address(RVA = "0x3217ED0", Offset = "0x32172D0", Length = "0x3CD")]
	[Token(Token = "0x600045C")]
	internal void UpdateListViewLabel() { }

	[Address(RVA = "0x32182A0", Offset = "0x32176A0", Length = "0x6B")]
	[Token(Token = "0x600045A")]
	private void UpdateRemoveButton() { }

}

