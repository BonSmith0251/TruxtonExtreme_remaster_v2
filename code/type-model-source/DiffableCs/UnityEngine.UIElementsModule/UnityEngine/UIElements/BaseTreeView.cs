namespace UnityEngine.UIElements;

[Token(Token = "0x2000085")]
public abstract class BaseTreeView : BaseVerticalCollectionView
{
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000086")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40002EA")]
		private readonly UxmlBoolAttributeDescription m_AutoExpand; //Field offset: 0xC8

		[Address(RVA = "0x334AD00", Offset = "0x334A100", Length = "0xA6")]
		[Token(Token = "0x600050F")]
		public UxmlTraits() { }

		[Address(RVA = "0x3348850", Offset = "0x3347C50", Length = "0x1A4")]
		[Token(Token = "0x600050E")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40002DD")]
	internal static readonly BindingId autoExpandProperty; //Field offset: 0x0
	[Token(Token = "0x40002DE")]
	internal static CustomStyleProperty<Single> s_TreeViewIndentProperty; //Field offset: 0x98
	[Token(Token = "0x40002DF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static readonly int invalidId; //Field offset: 0xA0
	[Token(Token = "0x40002E0")]
	public static readonly string ussClassName; //Field offset: 0xA8
	[Token(Token = "0x40002E1")]
	public static readonly string itemUssClassName; //Field offset: 0xB0
	[Token(Token = "0x40002E2")]
	public static readonly string itemToggleUssClassName; //Field offset: 0xB8
	[Obsolete("Individual item indents are no longer used, see itemIndentUssClassName instead", False)]
	[Token(Token = "0x40002E3")]
	public static readonly string itemIndentsContainerUssClassName; //Field offset: 0xC0
	[Token(Token = "0x40002E4")]
	public static readonly string itemIndentUssClassName; //Field offset: 0xC8
	[Token(Token = "0x40002E5")]
	public static readonly string itemContentContainerUssClassName; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x40002E6")]
	private Action<TreeViewExpansionChangedArgs> itemExpandedChanged; //Field offset: 0x3C8
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x40002E7")]
	private bool m_AutoExpand; //Field offset: 0x3D0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x3D8")]
	[SerializeField]
	[Token(Token = "0x40002E8")]
	private List<Int32> m_ExpandedItemIds; //Field offset: 0x3D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x40002E9")]
	private Nullable<Single> <customIdent>k__BackingField; //Field offset: 0x3E0

	[CreateProperty]
	[Token(Token = "0x170000C5")]
	public bool autoExpand
	{
		[Address(RVA = "0x3330320", Offset = "0x332F720", Length = "0x8")]
		[Token(Token = "0x60004F7")]
		 get { } //Length: 8
		[Address(RVA = "0x33303F0", Offset = "0x332F7F0", Length = "0x82")]
		[Token(Token = "0x60004F8")]
		 set { } //Length: 130
	}

	[Token(Token = "0x170000C7")]
	internal Nullable<Single> customIdent
	{
		[Address(RVA = "0x3219910", Offset = "0x3218D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60004FB")]
		internal get { } //Length: 8
		[Address(RVA = "0x3330480", Offset = "0x332F880", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60004FC")]
		private set { } //Length: 8
	}

	[Token(Token = "0x170000C6")]
	internal List<Int32> expandedItemIds
	{
		[Address(RVA = "0x3330330", Offset = "0x332F730", Length = "0x8")]
		[Token(Token = "0x60004F9")]
		internal get { } //Length: 8
		[Address(RVA = "0x3330490", Offset = "0x332F890", Length = "0x13")]
		[Token(Token = "0x60004FA")]
		internal set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000C3")]
	public internal IList itemsSource
	{
		[Address(RVA = "0x3330340", Offset = "0x332F740", Length = "0x30")]
		[Token(Token = "0x60004EF")]
		 get { } //Length: 48
		[Address(RVA = "0x33304B0", Offset = "0x332F8B0", Length = "0x79")]
		[Token(Token = "0x60004F0")]
		internal set { } //Length: 121
	}

	[Token(Token = "0x170000C4")]
	public BaseTreeViewController viewController
	{
		[Address(RVA = "0x3330370", Offset = "0x332F770", Length = "0x75")]
		[Token(Token = "0x60004F1")]
		 get { } //Length: 117
	}

	[Address(RVA = "0x332FBE0", Offset = "0x332EFE0", Length = "0x3E7")]
	[Token(Token = "0x600050C")]
	private static BaseTreeView() { }

	[Address(RVA = "0x332FFD0", Offset = "0x332F3D0", Length = "0x1AD")]
	[Token(Token = "0x60004FE")]
	public BaseTreeView(int itemHeight) { }

	[Address(RVA = "0x3330180", Offset = "0x332F580", Length = "0x194")]
	[Token(Token = "0x60004FD")]
	public BaseTreeView() { }

	[Address(RVA = "0x332FBD0", Offset = "0x332EFD0", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x600050D")]
	private int <SetSelectionInternalById>b__60_0(int id) { }

	[Address(RVA = "0x332E820", Offset = "0x332DC20", Length = "0x54")]
	[Token(Token = "0x6000507")]
	public void CollapseItem(int id, bool collapseAllChildren = false, bool refresh = true) { }

	[Address(RVA = "0x332E790", Offset = "0x332DB90", Length = "0x87")]
	[Token(Token = "0x600050A")]
	private void CollapseItemByIndex(int index, bool collapseAll) { }

	[Address(RVA = "0x332E880", Offset = "0x332DC80", Length = "0x54")]
	[Token(Token = "0x60004F6")]
	internal virtual ICollectionDragAndDropController CreateDragAndDropController() { }

	[Address(RVA = "0x332E8E0", Offset = "0x332DCE0", Length = "0x39")]
	[Token(Token = "0x60004F2")]
	virtual void CreateVirtualizationController() { }

	[Address(RVA = "0x332E9B0", Offset = "0x332DDB0", Length = "0x54")]
	[Token(Token = "0x6000508")]
	public void ExpandItem(int id, bool expandAllChildren = false, bool refresh = true) { }

	[Address(RVA = "0x332E920", Offset = "0x332DD20", Length = "0x87")]
	[Token(Token = "0x600050B")]
	private void ExpandItemByIndex(int index, bool expandAll) { }

	[Address(RVA = "0x3330320", Offset = "0x332F720", Length = "0x8")]
	[Token(Token = "0x60004F7")]
	public bool get_autoExpand() { }

	[Address(RVA = "0x3219910", Offset = "0x3218D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60004FB")]
	internal Nullable<Single> get_customIdent() { }

	[Address(RVA = "0x3330330", Offset = "0x332F730", Length = "0x8")]
	[Token(Token = "0x60004F9")]
	internal List<Int32> get_expandedItemIds() { }

	[Address(RVA = "0x3330340", Offset = "0x332F740", Length = "0x30")]
	[Token(Token = "0x60004EF")]
	public IList get_itemsSource() { }

	[Address(RVA = "0x3330370", Offset = "0x332F770", Length = "0x75")]
	[Token(Token = "0x60004F1")]
	public BaseTreeViewController get_viewController() { }

	[Address(RVA = "0x332EA10", Offset = "0x332DE10", Length = "0x207")]
	[Token(Token = "0x6000505")]
	private int GetItemIndex(int id, bool expand = false) { }

	[Address(RVA = "0x332EC20", Offset = "0x332E020", Length = "0x597")]
	[Token(Token = "0x6000501")]
	virtual bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	[Address(RVA = "0x332F1F0", Offset = "0x332E5F0", Length = "0x2B")]
	[Token(Token = "0x6000506")]
	public bool IsExpanded(int id) { }

	[Address(RVA = "0x332F1C0", Offset = "0x332E5C0", Length = "0x2B")]
	[Token(Token = "0x6000509")]
	private bool IsExpandedByIndex(int index) { }

	[Address(RVA = "0x332F220", Offset = "0x332E620", Length = "0x1AD")]
	[Token(Token = "0x60004FF")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	[Address(RVA = "0x332F3D0", Offset = "0x332E7D0", Length = "0x1C")]
	[Token(Token = "0x60004F5")]
	private void OnItemExpandedChanged(TreeViewExpansionChangedArgs arg) { }

	[Address(RVA = "0x332F3F0", Offset = "0x332E7F0", Length = "0x7")]
	[Token(Token = "0x60004F4")]
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	[Address(RVA = "0x332F400", Offset = "0x332E800", Length = "0x80")]
	[Token(Token = "0x6000500")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x33303F0", Offset = "0x332F7F0", Length = "0x82")]
	[Token(Token = "0x60004F8")]
	public void set_autoExpand(bool value) { }

	[Address(RVA = "0x3330480", Offset = "0x332F880", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60004FC")]
	private void set_customIdent(Nullable<Single> value) { }

	[Address(RVA = "0x3330490", Offset = "0x332F890", Length = "0x13")]
	[Token(Token = "0x60004FA")]
	internal void set_expandedItemIds(List<Int32> value) { }

	[Address(RVA = "0x33304B0", Offset = "0x332F8B0", Length = "0x79")]
	[Token(Token = "0x60004F0")]
	internal void set_itemsSource(IList value) { }

	[Address(RVA = "0x332F490", Offset = "0x332E890", Length = "0xC0")]
	[Token(Token = "0x6000503")]
	public void SetSelectionById(IEnumerable<Int32> ids) { }

	[Address(RVA = "0x332F550", Offset = "0x332E950", Length = "0x10B")]
	[Token(Token = "0x6000502")]
	public void SetSelectionById(int id) { }

	[Address(RVA = "0x332F660", Offset = "0x332EA60", Length = "0xCF")]
	[Token(Token = "0x6000504")]
	internal void SetSelectionInternalById(IEnumerable<Int32> ids, bool sendNotification) { }

	[Address(RVA = "0x332F730", Offset = "0x332EB30", Length = "0x492")]
	[Token(Token = "0x60004F3")]
	public virtual void SetViewController(CollectionViewController controller) { }

}

