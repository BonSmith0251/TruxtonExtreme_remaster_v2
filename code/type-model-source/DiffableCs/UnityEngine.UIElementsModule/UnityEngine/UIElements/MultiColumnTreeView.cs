namespace UnityEngine.UIElements;

[Token(Token = "0x2000120")]
public class MultiColumnTreeView : BaseTreeView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000121")]
	internal class UxmlFactory : UxmlFactory<MultiColumnTreeView, UxmlTraits>
	{

		[Address(RVA = "0x33A81C0", Offset = "0x33A75C0", Length = "0x39")]
		[Token(Token = "0x6000921")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000122")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40005BE")]
		private readonly UxmlEnumAttributeDescription<ColumnSortingMode> m_SortingMode; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x40005BF")]
		private readonly UxmlObjectAttributeDescription<Columns> m_Columns; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x40005C0")]
		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; //Field offset: 0xE0

		[Address(RVA = "0x33AADF0", Offset = "0x33AA1F0", Length = "0x1B4")]
		[Token(Token = "0x6000923")]
		public UxmlTraits() { }

		[Address(RVA = "0x33A9CF0", Offset = "0x33A90F0", Length = "0x350")]
		[Token(Token = "0x6000922")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005B5")]
	private static readonly BindingId columnsProperty; //Field offset: 0x0
	[Token(Token = "0x40005B6")]
	private static readonly BindingId sortColumnDescriptionsProperty; //Field offset: 0x98
	[Token(Token = "0x40005B7")]
	private static readonly BindingId sortingModeProperty; //Field offset: 0x130
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x40005B8")]
	private Columns m_Columns; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x40005B9")]
	private ColumnSortingMode m_SortingMode; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x40005BA")]
	private SortColumnDescriptions m_SortColumnDescriptions; //Field offset: 0x3F8
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x40005BB")]
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x400
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x40005BC")]
	private Action columnSortingChanged; //Field offset: 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x40005BD")]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; //Field offset: 0x410

	[CreateProperty]
	[Token(Token = "0x1700018A")]
	public private Columns columns
	{
		[Address(RVA = "0x2EA4E40", Offset = "0x2EA4240", Length = "0x8")]
		[Token(Token = "0x6000912")]
		 get { } //Length: 8
		[Address(RVA = "0x33951A0", Offset = "0x33945A0", Length = "0x173")]
		[Token(Token = "0x6000913")]
		private set { } //Length: 371
	}

	[CreateProperty]
	[Token(Token = "0x1700018B")]
	public private SortColumnDescriptions sortColumnDescriptions
	{
		[Address(RVA = "0x3395100", Offset = "0x3394500", Length = "0x8")]
		[Token(Token = "0x6000914")]
		 get { } //Length: 8
		[Address(RVA = "0x3395320", Offset = "0x3394720", Length = "0x111")]
		[Token(Token = "0x6000915")]
		private set { } //Length: 273
	}

	[CreateProperty]
	[Token(Token = "0x1700018C")]
	public ColumnSortingMode sortingMode
	{
		[Address(RVA = "0x3395110", Offset = "0x3394510", Length = "0x7")]
		[Token(Token = "0x6000916")]
		 get { } //Length: 7
		[Address(RVA = "0x3395440", Offset = "0x3394840", Length = "0xB2")]
		[Token(Token = "0x6000917")]
		 set { } //Length: 178
	}

	[Token(Token = "0x17000189")]
	public MultiColumnTreeViewController viewController
	{
		[Address(RVA = "0x3395120", Offset = "0x3394520", Length = "0x7B")]
		[Token(Token = "0x6000911")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x3394B80", Offset = "0x3393F80", Length = "0x2A5")]
	[Token(Token = "0x6000920")]
	private static MultiColumnTreeView() { }

	[Address(RVA = "0x3394F80", Offset = "0x3394380", Length = "0x17C")]
	[Token(Token = "0x6000918")]
	public MultiColumnTreeView() { }

	[Address(RVA = "0x3394E30", Offset = "0x3394230", Length = "0x14A")]
	[Token(Token = "0x6000919")]
	public MultiColumnTreeView(Columns columns) { }

	[Address(RVA = "0x3393B10", Offset = "0x3392F10", Length = "0x83")]
	[Token(Token = "0x600091E")]
	private void ColumnsChanged(object sender, BindablePropertyChangedEventArgs args) { }

	[Address(RVA = "0x3394840", Offset = "0x3393C40", Length = "0x98")]
	[Token(Token = "0x600091A")]
	protected virtual CollectionViewController CreateViewController() { }

	[Address(RVA = "0x33948E0", Offset = "0x3393CE0", Length = "0x39")]
	[Token(Token = "0x600091C")]
	virtual void CreateVirtualizationController() { }

	[Address(RVA = "0x2EA4E40", Offset = "0x2EA4240", Length = "0x8")]
	[Token(Token = "0x6000912")]
	public Columns get_columns() { }

	[Address(RVA = "0x3395100", Offset = "0x3394500", Length = "0x8")]
	[Token(Token = "0x6000914")]
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	[Address(RVA = "0x3395110", Offset = "0x3394510", Length = "0x7")]
	[Token(Token = "0x6000916")]
	public ColumnSortingMode get_sortingMode() { }

	[Address(RVA = "0x3395120", Offset = "0x3394520", Length = "0x7B")]
	[Token(Token = "0x6000911")]
	public MultiColumnTreeViewController get_viewController() { }

	[Address(RVA = "0x3394920", Offset = "0x3393D20", Length = "0x1C")]
	[Token(Token = "0x600091D")]
	private void RaiseColumnSortingChanged() { }

	[Address(RVA = "0x3394940", Offset = "0x3393D40", Length = "0x1C")]
	[Token(Token = "0x600091F")]
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

	[Address(RVA = "0x33951A0", Offset = "0x33945A0", Length = "0x173")]
	[Token(Token = "0x6000913")]
	private void set_columns(Columns value) { }

	[Address(RVA = "0x3395320", Offset = "0x3394720", Length = "0x111")]
	[Token(Token = "0x6000915")]
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	[Address(RVA = "0x3395440", Offset = "0x3394840", Length = "0xB2")]
	[Token(Token = "0x6000917")]
	public void set_sortingMode(ColumnSortingMode value) { }

	[Address(RVA = "0x3394960", Offset = "0x3393D60", Length = "0x212")]
	[Token(Token = "0x600091B")]
	public virtual void SetViewController(CollectionViewController controller) { }

}

