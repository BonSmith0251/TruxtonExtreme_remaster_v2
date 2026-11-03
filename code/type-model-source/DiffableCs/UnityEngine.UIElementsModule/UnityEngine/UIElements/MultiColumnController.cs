namespace UnityEngine.UIElements;

[Token(Token = "0x200011C")]
public class MultiColumnController : IDisposable
{
	[Token(Token = "0x4000598")]
	private static readonly PropertyName k_BoundColumnVePropertyName; //Field offset: 0x0
	[Token(Token = "0x4000599")]
	internal static readonly PropertyName bindableElementPropertyName; //Field offset: 0x4
	[Token(Token = "0x400059A")]
	internal static readonly string baseUssClassName; //Field offset: 0x8
	[Token(Token = "0x400059B")]
	private static readonly string k_HeaderContainerViewDataKey; //Field offset: 0x10
	[Token(Token = "0x400059C")]
	public static readonly string headerContainerUssClassName; //Field offset: 0x18
	[Token(Token = "0x400059D")]
	public static readonly string rowContainerUssClassName; //Field offset: 0x20
	[Token(Token = "0x400059E")]
	public static readonly string cellUssClassName; //Field offset: 0x28
	[Token(Token = "0x400059F")]
	public static readonly string cellLabelUssClassName; //Field offset: 0x30
	[Token(Token = "0x40005A0")]
	private static readonly string k_HeaderViewDataKey; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A1")]
	private Action columnSortingChanged; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A2")]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005A3")]
	private List<Int32> m_SortedToSourceIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005A4")]
	private List<Int32> m_SourceToSortedIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005A5")]
	private ColumnSortingMode m_SortingMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005A6")]
	private BaseVerticalCollectionView m_View; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005A7")]
	private VisualElement m_HeaderContainer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005A8")]
	private MultiColumnCollectionHeader m_MultiColumnHeader; //Field offset: 0x48

	[Token(Token = "0x1400001F")]
	public event Action columnSortingChanged
	{
		[Address(RVA = "0x338E640", Offset = "0x338DA40", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60008D8")]
		 add { } //Length: 158
		[Address(RVA = "0x338E790", Offset = "0x338DB90", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60008D9")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000020")]
	public event Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent
	{
		[Address(RVA = "0x338E6E0", Offset = "0x338DAE0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008DA")]
		 add { } //Length: 172
		[Address(RVA = "0x338E830", Offset = "0x338DC30", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008DB")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000183")]
	internal MultiColumnCollectionHeader header
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60008DC")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000184")]
	internal ColumnSortingMode sortingMode
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60008DD")]
		internal get { } //Length: 4
		[Address(RVA = "0x338E8E0", Offset = "0x338DCE0", Length = "0x26")]
		[Token(Token = "0x60008DE")]
		internal set { } //Length: 38
	}

	[Address(RVA = "0x338DE60", Offset = "0x338D260", Length = "0x2A6")]
	[Token(Token = "0x60008FD")]
	private static MultiColumnController() { }

	[Address(RVA = "0x338E110", Offset = "0x338D510", Length = "0x520")]
	[Token(Token = "0x60008DF")]
	public MultiColumnController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[Address(RVA = "0x338E640", Offset = "0x338DA40", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60008D8")]
	public void add_columnSortingChanged(Action value) { }

	[Address(RVA = "0x338E6E0", Offset = "0x338DAE0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008DA")]
	public void add_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[Address(RVA = "0x88ABD0", Offset = "0x889FD0", Length = "0x13B")]
	[Token(Token = "0x60008E0")]
	private static void BindCellItem(VisualElement ve, int rowIndex, Column column, T item) { }

	[Address(RVA = "0x88B1E0", Offset = "0x88A5E0", Length = "0x42D")]
	[Token(Token = "0x60008E5")]
	public void BindItem(VisualElement element, int index, T item) { }

	[Address(RVA = "0x338B2E0", Offset = "0x338A6E0", Length = "0x4FD")]
	[Token(Token = "0x60008F1")]
	private int CombinedComparison(int a, int b) { }

	[Address(RVA = "0x88B750", Offset = "0x88AB50", Length = "0xA1")]
	[Token(Token = "0x60008E3")]
	private static void DefaultBindCellItem(VisualElement ve, T item) { }

	[Address(RVA = "0x338B7E0", Offset = "0x338ABE0", Length = "0xA1")]
	[Token(Token = "0x60008E2")]
	private static VisualElement DefaultMakeCellItem() { }

	[Address(RVA = "0x338B890", Offset = "0x338AC90", Length = "0x340")]
	[Token(Token = "0x60008E7")]
	public void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x338BBE0", Offset = "0x338AFE0", Length = "0x7A4")]
	[Token(Token = "0x60008E9")]
	public override void Dispose() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60008DC")]
	internal MultiColumnCollectionHeader get_header() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60008DD")]
	internal ColumnSortingMode get_sortingMode() { }

	[Address(RVA = "0x338C390", Offset = "0x338B790", Length = "0x6B")]
	[Token(Token = "0x60008F4")]
	private static int GetIndexFromList(int index, List<Int32> indices) { }

	[Address(RVA = "0x338C400", Offset = "0x338B800", Length = "0xA0")]
	[Token(Token = "0x60008F3")]
	internal int GetSortedIndex(int sourceIndex) { }

	[Address(RVA = "0x338C4A0", Offset = "0x338B8A0", Length = "0xA0")]
	[Token(Token = "0x60008F2")]
	internal int GetSourceIndex(int sortedIndex) { }

	[Address(RVA = "0x338C540", Offset = "0x338B940", Length = "0x37B")]
	[Token(Token = "0x60008E4")]
	public VisualElement MakeItem() { }

	[Address(RVA = "0x338C8C0", Offset = "0x338BCC0", Length = "0x1D")]
	[Token(Token = "0x60008F7")]
	private void OnColumnAdded(Column column, int index) { }

	[Address(RVA = "0x338C8E0", Offset = "0x338BCE0", Length = "0x38")]
	[Token(Token = "0x60008FB")]
	private void OnColumnChanged(ColumnsDataType type) { }

	[Address(RVA = "0x338C920", Offset = "0x338BD20", Length = "0xC")]
	[Token(Token = "0x60008EC")]
	private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x338C8C0", Offset = "0x338BCC0", Length = "0x1D")]
	[Token(Token = "0x60008F8")]
	private void OnColumnRemoved(Column column) { }

	[Address(RVA = "0x338C930", Offset = "0x338BD30", Length = "0x34")]
	[Token(Token = "0x60008F9")]
	private void OnColumnReordered(Column column, int from, int to) { }

	[Address(RVA = "0x338C970", Offset = "0x338BD70", Length = "0x305")]
	[Token(Token = "0x60008F6")]
	private void OnColumnResized(int index, float width) { }

	[Address(RVA = "0x338CCD0", Offset = "0x338C0D0", Length = "0x3A")]
	[Token(Token = "0x60008FA")]
	private void OnColumnsChanged(Column column, ColumnDataType type) { }

	[Address(RVA = "0x338CC80", Offset = "0x338C080", Length = "0x4E")]
	[Token(Token = "0x60008EE")]
	private void OnColumnSortingChanged() { }

	[Address(RVA = "0x338CD10", Offset = "0x338C110", Length = "0x19")]
	[Token(Token = "0x60008F5")]
	private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column) { }

	[Address(RVA = "0x338CD30", Offset = "0x338C130", Length = "0x1E")]
	[Token(Token = "0x60008EA")]
	private void OnHorizontalScrollerValueChanged(float v) { }

	[Address(RVA = "0x338C8C0", Offset = "0x338BCC0", Length = "0x1D")]
	[Token(Token = "0x60008FC")]
	private void OnViewDataRestored() { }

	[Address(RVA = "0x338CD50", Offset = "0x338C150", Length = "0x2B8")]
	[Token(Token = "0x60008EB")]
	private void OnViewportGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x338D010", Offset = "0x338C410", Length = "0x321")]
	[Token(Token = "0x60008E8")]
	public void PrepareView(BaseVerticalCollectionView collectionView) { }

	[Address(RVA = "0x338E790", Offset = "0x338DB90", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60008D9")]
	public void remove_columnSortingChanged(Action value) { }

	[Address(RVA = "0x338E830", Offset = "0x338DC30", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008DB")]
	public void remove_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[Address(RVA = "0x338E8E0", Offset = "0x338DCE0", Length = "0x26")]
	[Token(Token = "0x60008DE")]
	internal void set_sortingMode(ColumnSortingMode value) { }

	[Address(RVA = "0x338D340", Offset = "0x338C740", Length = "0x494")]
	[Token(Token = "0x60008F0")]
	internal void SortIfNeeded() { }

	[Address(RVA = "0x338D7E0", Offset = "0x338CBE0", Length = "0x3B")]
	[Token(Token = "0x60008E1")]
	private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column) { }

	[Address(RVA = "0x338D820", Offset = "0x338CC20", Length = "0x3A2")]
	[Token(Token = "0x60008E6")]
	public void UnbindItem(VisualElement element, int index) { }

	[Address(RVA = "0x338DBD0", Offset = "0x338CFD0", Length = "0x1D5")]
	[Token(Token = "0x60008ED")]
	private void UpdateContentContainer(BaseVerticalCollectionView collectionView) { }

	[Address(RVA = "0x338DDB0", Offset = "0x338D1B0", Length = "0xA9")]
	[Token(Token = "0x60008EF")]
	internal void UpdateDragger() { }

}

