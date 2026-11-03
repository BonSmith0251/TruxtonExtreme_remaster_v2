namespace UnityEngine.UIElements;

[Token(Token = "0x200011D")]
public class MultiColumnListView : BaseListView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200011E")]
	internal class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits>
	{

		[Address(RVA = "0x33A8080", Offset = "0x33A7480", Length = "0x39")]
		[Token(Token = "0x600090E")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200011F")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x40005B2")]
		private readonly UxmlEnumAttributeDescription<ColumnSortingMode> m_SortingMode; //Field offset: 0x108
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x40005B3")]
		private readonly UxmlObjectAttributeDescription<Columns> m_Columns; //Field offset: 0x110
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x40005B4")]
		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; //Field offset: 0x118

		[Address(RVA = "0x33AAC30", Offset = "0x33AA030", Length = "0x1B4")]
		[Token(Token = "0x6000910")]
		public UxmlTraits() { }

		[Address(RVA = "0x33A8B90", Offset = "0x33A7F90", Length = "0x350")]
		[Token(Token = "0x600090F")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005A9")]
	private static readonly BindingId columnsProperty; //Field offset: 0x0
	[Token(Token = "0x40005AA")]
	private static readonly BindingId sortColumnDescriptionsProperty; //Field offset: 0x98
	[Token(Token = "0x40005AB")]
	private static readonly BindingId sortingModeProperty; //Field offset: 0x130
	[FieldOffset(Offset = "0x4D8")]
	[Token(Token = "0x40005AC")]
	private Columns m_Columns; //Field offset: 0x4D8
	[FieldOffset(Offset = "0x4E0")]
	[Token(Token = "0x40005AD")]
	private ColumnSortingMode m_SortingMode; //Field offset: 0x4E0
	[FieldOffset(Offset = "0x4E8")]
	[Token(Token = "0x40005AE")]
	private SortColumnDescriptions m_SortColumnDescriptions; //Field offset: 0x4E8
	[FieldOffset(Offset = "0x4F0")]
	[Token(Token = "0x40005AF")]
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x4F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4F8")]
	[Token(Token = "0x40005B0")]
	private Action columnSortingChanged; //Field offset: 0x4F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x500")]
	[Token(Token = "0x40005B1")]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; //Field offset: 0x500

	[CreateProperty]
	[Token(Token = "0x17000186")]
	public private Columns columns
	{
		[Address(RVA = "0x33867A0", Offset = "0x3385BA0", Length = "0x8")]
		[Token(Token = "0x60008FF")]
		 get { } //Length: 8
		[Address(RVA = "0x33944E0", Offset = "0x33938E0", Length = "0x173")]
		[Token(Token = "0x6000900")]
		private set { } //Length: 371
	}

	[CreateProperty]
	[Token(Token = "0x17000187")]
	public private SortColumnDescriptions sortColumnDescriptions
	{
		[Address(RVA = "0x3386790", Offset = "0x3385B90", Length = "0x8")]
		[Token(Token = "0x6000901")]
		 get { } //Length: 8
		[Address(RVA = "0x3394660", Offset = "0x3393A60", Length = "0x111")]
		[Token(Token = "0x6000902")]
		private set { } //Length: 273
	}

	[CreateProperty]
	[Token(Token = "0x17000188")]
	public ColumnSortingMode sortingMode
	{
		[Address(RVA = "0x3394450", Offset = "0x3393850", Length = "0x7")]
		[Token(Token = "0x6000903")]
		 get { } //Length: 7
		[Address(RVA = "0x3394780", Offset = "0x3393B80", Length = "0xB2")]
		[Token(Token = "0x6000904")]
		 set { } //Length: 178
	}

	[Token(Token = "0x17000185")]
	public MultiColumnListViewController viewController
	{
		[Address(RVA = "0x3394460", Offset = "0x3393860", Length = "0x7B")]
		[Token(Token = "0x60008FE")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x3393ED0", Offset = "0x33932D0", Length = "0x2A5")]
	[Token(Token = "0x600090D")]
	private static MultiColumnListView() { }

	[Address(RVA = "0x33942D0", Offset = "0x33936D0", Length = "0x17C")]
	[Token(Token = "0x6000905")]
	public MultiColumnListView() { }

	[Address(RVA = "0x3394180", Offset = "0x3393580", Length = "0x14A")]
	[Token(Token = "0x6000906")]
	public MultiColumnListView(Columns columns) { }

	[Address(RVA = "0x3393B10", Offset = "0x3392F10", Length = "0x83")]
	[Token(Token = "0x600090B")]
	private void ColumnsChanged(object sender, BindablePropertyChangedEventArgs args) { }

	[Address(RVA = "0x3393BA0", Offset = "0x3392FA0", Length = "0x89")]
	[Token(Token = "0x6000907")]
	protected virtual CollectionViewController CreateViewController() { }

	[Address(RVA = "0x3393C30", Offset = "0x3393030", Length = "0x39")]
	[Token(Token = "0x6000909")]
	virtual void CreateVirtualizationController() { }

	[Address(RVA = "0x33867A0", Offset = "0x3385BA0", Length = "0x8")]
	[Token(Token = "0x60008FF")]
	public Columns get_columns() { }

	[Address(RVA = "0x3386790", Offset = "0x3385B90", Length = "0x8")]
	[Token(Token = "0x6000901")]
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	[Address(RVA = "0x3394450", Offset = "0x3393850", Length = "0x7")]
	[Token(Token = "0x6000903")]
	public ColumnSortingMode get_sortingMode() { }

	[Address(RVA = "0x3394460", Offset = "0x3393860", Length = "0x7B")]
	[Token(Token = "0x60008FE")]
	public MultiColumnListViewController get_viewController() { }

	[Address(RVA = "0x3393C70", Offset = "0x3393070", Length = "0x1C")]
	[Token(Token = "0x600090A")]
	private void RaiseColumnSortingChanged() { }

	[Address(RVA = "0x3393C90", Offset = "0x3393090", Length = "0x1C")]
	[Token(Token = "0x600090C")]
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

	[Address(RVA = "0x33944E0", Offset = "0x33938E0", Length = "0x173")]
	[Token(Token = "0x6000900")]
	private void set_columns(Columns value) { }

	[Address(RVA = "0x3394660", Offset = "0x3393A60", Length = "0x111")]
	[Token(Token = "0x6000902")]
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	[Address(RVA = "0x3394780", Offset = "0x3393B80", Length = "0xB2")]
	[Token(Token = "0x6000904")]
	public void set_sortingMode(ColumnSortingMode value) { }

	[Address(RVA = "0x3393CB0", Offset = "0x33930B0", Length = "0x212")]
	[Token(Token = "0x6000908")]
	public virtual void SetViewController(CollectionViewController controller) { }

}

