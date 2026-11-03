namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x200066E")]
internal class MultiColumnCollectionHeader : VisualElement, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000673")]
	private sealed class <>c__DisplayClass67_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400183D")]
		public Column column; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400183E")]
		public MultiColumnCollectionHeader <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002DF8")]
		public <>c__DisplayClass67_0() { }

		[Address(RVA = "0x3373270", Offset = "0x3372670", Length = "0x28")]
		[Token(Token = "0x6002DF9")]
		internal void <OnContextualMenuManipulator>b__1(DropdownMenuAction a) { }

		[Address(RVA = "0x33732A0", Offset = "0x33726A0", Length = "0x8D")]
		[Token(Token = "0x6002DFA")]
		internal Status <OnContextualMenuManipulator>b__2(DropdownMenuAction a) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000674")]
	private sealed class <>c__DisplayClass73_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400183F")]
		public Column column; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002DFB")]
		public <>c__DisplayClass73_0() { }

		[Address(RVA = "0x3373330", Offset = "0x3372730", Length = "0x8E")]
		[Token(Token = "0x6002DFC")]
		internal bool <UpdateSortColumnDescriptionsOnClick>b__0(SortColumnDescription d) { }

	}

	[Token(Token = "0x2000671")]
	public class ColumnData
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001839")]
		private MultiColumnHeaderColumn <control>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400183A")]
		private MultiColumnHeaderColumnResizeHandle <resizeHandle>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x17000BA9")]
		public MultiColumnHeaderColumn control
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002DF2")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6002DF3")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000BAA")]
		public MultiColumnHeaderColumnResizeHandle resizeHandle
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002DF4")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6002DF5")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002DF6")]
		public ColumnData() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002DF2")]
		public MultiColumnHeaderColumn get_control() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002DF4")]
		public MultiColumnHeaderColumnResizeHandle get_resizeHandle() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002DF3")]
		public void set_control(MultiColumnHeaderColumn value) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002DF5")]
		public void set_resizeHandle(MultiColumnHeaderColumnResizeHandle value) { }

	}

	[Token(Token = "0x2000672")]
	private struct SortedColumnState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400183B")]
		public SortColumnDescription columnDesc; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400183C")]
		public SortDirection direction; //Field offset: 0x8

		[Address(RVA = "0xAEE5F0", Offset = "0xAED9F0", Length = "0x26")]
		[Token(Token = "0x6002DF7")]
		public SortedColumnState(SortColumnDescription desc, SortDirection dir) { }

	}

	[Token(Token = "0x200066F")]
	private class ViewState
	{
		[Token(Token = "0x2000670")]
		private struct ColumnState
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001834")]
			public int index; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4001835")]
			public string name; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4001836")]
			public float actualWidth; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4001837")]
			public Length width; //Field offset: 0x14
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4001838")]
			public bool visible; //Field offset: 0x1C

		}

		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4001831")]
		private bool m_HasPersistedData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4001832")]
		private List<SortColumnDescription> m_SortDescriptions; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x4001833")]
		private List<ColumnState> m_OrderedColumnStates; //Field offset: 0x20

		[Address(RVA = "0x3373FA0", Offset = "0x33733A0", Length = "0xBD")]
		[Token(Token = "0x6002DF1")]
		public ViewState() { }

		[Address(RVA = "0x33735F0", Offset = "0x33729F0", Length = "0x35C")]
		[Token(Token = "0x6002DF0")]
		internal void Apply(MultiColumnCollectionHeader header) { }

		[Address(RVA = "0x3373950", Offset = "0x3372D50", Length = "0x641")]
		[Token(Token = "0x6002DEF")]
		internal void Save(MultiColumnCollectionHeader header) { }

	}

	[Token(Token = "0x400181C")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400181D")]
	public static readonly string columnContainerUssClassName; //Field offset: 0x8
	[Token(Token = "0x400181E")]
	public static readonly string handleContainerUssClassName; //Field offset: 0x10
	[Token(Token = "0x400181F")]
	public static readonly string reorderableUssClassName; //Field offset: 0x18
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4001820")]
	private bool m_SortingEnabled; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4001821")]
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4001822")]
	private SortColumnDescriptions m_SortDescriptions; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4001823")]
	private List<SortedColumnState> m_OldSortedColumnStates; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4001824")]
	private bool m_SortingUpdatesTemporarilyDisabled; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4001825")]
	private ViewState m_ViewState; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4001826")]
	private bool m_ApplyingViewState; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2F9")]
	[Token(Token = "0x4001827")]
	private bool m_DoLayoutScheduled; //Field offset: 0x2F9
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4001828")]
	private readonly Dictionary<Column, ColumnData> <columnDataMap>k__BackingField; //Field offset: 0x300
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4001829")]
	private readonly ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x308
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x400182A")]
	private readonly VisualElement <columnContainer>k__BackingField; //Field offset: 0x310
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x400182B")]
	private readonly VisualElement <resizeHandleContainer>k__BackingField; //Field offset: 0x318
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x400182C")]
	private readonly Columns <columns>k__BackingField; //Field offset: 0x320
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x400182D")]
	private Action<Int32, Single> columnResized; //Field offset: 0x328
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x400182E")]
	private Action columnSortingChanged; //Field offset: 0x330
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x400182F")]
	private Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent; //Field offset: 0x338
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4001830")]
	private Action viewDataRestored; //Field offset: 0x340

	[Token(Token = "0x14000034")]
	public event Action<Int32, Single> columnResized
	{
		[Address(RVA = "0x3367670", Offset = "0x3366A70", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6002DCA")]
		 add { } //Length: 186
		[Address(RVA = "0x3367980", Offset = "0x3366D80", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6002DCB")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000035")]
	public event Action columnSortingChanged
	{
		[Address(RVA = "0x3367730", Offset = "0x3366B30", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6002DCC")]
		 add { } //Length: 162
		[Address(RVA = "0x3367A40", Offset = "0x3366E40", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6002DCD")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x14000036")]
	public event Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent
	{
		[Address(RVA = "0x33677E0", Offset = "0x3366BE0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6002DCE")]
		 add { } //Length: 186
		[Address(RVA = "0x3367AF0", Offset = "0x3366EF0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6002DCF")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000037")]
	internal event Action viewDataRestored
	{
		[Address(RVA = "0x33678A0", Offset = "0x3366CA0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6002DD0")]
		internal add { } //Length: 162
		[Address(RVA = "0x3367BB0", Offset = "0x3366FB0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6002DD1")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x17000BA2")]
	public VisualElement columnContainer
	{
		[Address(RVA = "0x3367950", Offset = "0x3366D50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002DC1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000BA0")]
	public Dictionary<Column, ColumnData> columnDataMap
	{
		[Address(RVA = "0x1081820", Offset = "0x1080C20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002DBF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000BA1")]
	public ColumnLayout columnLayout
	{
		[Address(RVA = "0x32A9220", Offset = "0x32A8620", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002DC0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000BA7")]
	public Columns columns
	{
		[Address(RVA = "0x167EF70", Offset = "0x167E370", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002DC7")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000B9F")]
	internal bool isApplyingViewState
	{
		[Address(RVA = "0x3367960", Offset = "0x3366D60", Length = "0x8")]
		[Token(Token = "0x6002DBE")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000BA3")]
	public VisualElement resizeHandleContainer
	{
		[Address(RVA = "0x1665730", Offset = "0x1664B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002DC2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000BA6")]
	public private SortColumnDescriptions sortDescriptions
	{
		[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
		[Token(Token = "0x6002DC5")]
		 get { } //Length: 8
		[Address(RVA = "0x3367C60", Offset = "0x3367060", Length = "0xAF")]
		[Token(Token = "0x6002DC6")]
		private set { } //Length: 175
	}

	[Token(Token = "0x17000BA5")]
	internal IReadOnlyList<SortColumnDescription> sortedColumnReadonly
	{
		[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
		[Token(Token = "0x6002DC4")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000BA4")]
	public IEnumerable<SortColumnDescription> sortedColumns
	{
		[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
		[Token(Token = "0x6002DC3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000BA8")]
	public bool sortingEnabled
	{
		[Address(RVA = "0x3367970", Offset = "0x3366D70", Length = "0x8")]
		[Token(Token = "0x6002DC8")]
		 get { } //Length: 8
		[Address(RVA = "0x3367D10", Offset = "0x3367110", Length = "0x33")]
		[Token(Token = "0x6002DC9")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x3366D20", Offset = "0x3366120", Length = "0x16A")]
	[Token(Token = "0x6002DED")]
	private static MultiColumnCollectionHeader() { }

	[Address(RVA = "0x3366E90", Offset = "0x3366290", Length = "0x7D5")]
	[Token(Token = "0x6002DD2")]
	public MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[Address(RVA = "0x3365630", Offset = "0x3364A30", Length = "0x88")]
	[CompilerGenerated]
	[Token(Token = "0x6002DEE")]
	private void <OnContextualMenuManipulator>b__67_0(DropdownMenuAction a) { }

	[Address(RVA = "0x3367670", Offset = "0x3366A70", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6002DCA")]
	public void add_columnResized(Action<Int32, Single> value) { }

	[Address(RVA = "0x3367730", Offset = "0x3366B30", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6002DCC")]
	public void add_columnSortingChanged(Action value) { }

	[Address(RVA = "0x33677E0", Offset = "0x3366BE0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6002DCE")]
	public void add_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[Address(RVA = "0x33678A0", Offset = "0x3366CA0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6002DD0")]
	internal void add_viewDataRestored(Action value) { }

	[Address(RVA = "0x3362BD0", Offset = "0x3361FD0", Length = "0x706")]
	[Token(Token = "0x6002DE7")]
	private void ApplyColumnSorting() { }

	[Address(RVA = "0x33632E0", Offset = "0x33626E0", Length = "0x236")]
	[Token(Token = "0x6002DEB")]
	private void CleanupColumnData(ColumnData data) { }

	[Address(RVA = "0x3363520", Offset = "0x3362920", Length = "0x3D0")]
	[Token(Token = "0x6002DEC")]
	public override void Dispose() { }

	[Address(RVA = "0x3363900", Offset = "0x3362D00", Length = "0x90")]
	[Token(Token = "0x6002DE0")]
	private void DoLayout() { }

	[Address(RVA = "0x3367950", Offset = "0x3366D50", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002DC1")]
	public VisualElement get_columnContainer() { }

	[Address(RVA = "0x1081820", Offset = "0x1080C20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002DBF")]
	public Dictionary<Column, ColumnData> get_columnDataMap() { }

	[Address(RVA = "0x32A9220", Offset = "0x32A8620", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002DC0")]
	public ColumnLayout get_columnLayout() { }

	[Address(RVA = "0x167EF70", Offset = "0x167E370", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002DC7")]
	public Columns get_columns() { }

	[Address(RVA = "0x3367960", Offset = "0x3366D60", Length = "0x8")]
	[Token(Token = "0x6002DBE")]
	internal bool get_isApplyingViewState() { }

	[Address(RVA = "0x1665730", Offset = "0x1664B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002DC2")]
	public VisualElement get_resizeHandleContainer() { }

	[Address(RVA = "0x3293210", Offset = "0x3292610", Length = "0x8")]
	[Token(Token = "0x6002DC5")]
	public SortColumnDescriptions get_sortDescriptions() { }

	[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
	[Token(Token = "0x6002DC4")]
	internal IReadOnlyList<SortColumnDescription> get_sortedColumnReadonly() { }

	[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
	[Token(Token = "0x6002DC3")]
	public IEnumerable<SortColumnDescription> get_sortedColumns() { }

	[Address(RVA = "0x3367970", Offset = "0x3366D70", Length = "0x8")]
	[Token(Token = "0x6002DC8")]
	public bool get_sortingEnabled() { }

	[Address(RVA = "0x33639B0", Offset = "0x3362DB0", Length = "0x4DF")]
	[Token(Token = "0x6002DD8")]
	private void OnColumnAdded(Column column) { }

	[Address(RVA = "0x33639A0", Offset = "0x3362DA0", Length = "0x8")]
	[Token(Token = "0x6002DD7")]
	private void OnColumnAdded(Column column, int index) { }

	[Address(RVA = "0x3363E90", Offset = "0x3363290", Length = "0x83")]
	[Token(Token = "0x6002DDA")]
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	[Address(RVA = "0x3363F20", Offset = "0x3363320", Length = "0x1A6")]
	[Token(Token = "0x6002DE2")]
	private void OnColumnClicked(EventBase evt) { }

	[Address(RVA = "0x33640D0", Offset = "0x33634D0", Length = "0x367")]
	[Token(Token = "0x6002DE1")]
	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x3364440", Offset = "0x3363840", Length = "0x312")]
	[Token(Token = "0x6002DD9")]
	private void OnColumnRemoved(Column column) { }

	[Address(RVA = "0x3364760", Offset = "0x3363B60", Length = "0x1C6")]
	[Token(Token = "0x6002DDB")]
	private void OnColumnReordered(Column column, int from, int to) { }

	[Address(RVA = "0x3364930", Offset = "0x3363D30", Length = "0x3E")]
	[Token(Token = "0x6002DDC")]
	private void OnColumnResized(Column column) { }

	[Address(RVA = "0x3364970", Offset = "0x3363D70", Length = "0x7B7")]
	[Token(Token = "0x6002DDD")]
	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	[Address(RVA = "0x3365130", Offset = "0x3364530", Length = "0x1E0")]
	[Token(Token = "0x6002DDF")]
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	[Address(RVA = "0x3365320", Offset = "0x3364720", Length = "0x92")]
	[Token(Token = "0x6002DDE")]
	private void OnMoveManipulatorActivated(ColumnMover mover) { }

	[Address(RVA = "0x33653C0", Offset = "0x33647C0", Length = "0x103")]
	[Token(Token = "0x6002DE9")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x33654D0", Offset = "0x33648D0", Length = "0x119")]
	[Token(Token = "0x6002DE5")]
	private void RaiseColumnResized(int columnIndex) { }

	[Address(RVA = "0x33655F0", Offset = "0x33649F0", Length = "0x3F")]
	[Token(Token = "0x6002DE6")]
	private void RaiseColumnSortingChanged() { }

	[Address(RVA = "0x3367980", Offset = "0x3366D80", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6002DCB")]
	public void remove_columnResized(Action<Int32, Single> value) { }

	[Address(RVA = "0x3367A40", Offset = "0x3366E40", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6002DCD")]
	public void remove_columnSortingChanged(Action value) { }

	[Address(RVA = "0x3367AF0", Offset = "0x3366EF0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6002DCF")]
	public void remove_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[Address(RVA = "0x3367BB0", Offset = "0x3366FB0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6002DD1")]
	internal void remove_viewDataRestored(Action value) { }

	[Address(RVA = "0x3365630", Offset = "0x3364A30", Length = "0x88")]
	[Token(Token = "0x6002DD4")]
	private void ResizeToFit() { }

	[Address(RVA = "0x3364930", Offset = "0x3363D30", Length = "0x3E")]
	[Token(Token = "0x6002DEA")]
	private void SaveViewState() { }

	[Address(RVA = "0x33656C0", Offset = "0x3364AC0", Length = "0xB9")]
	[Token(Token = "0x6002DD3")]
	private void ScheduleDoLayout() { }

	[Address(RVA = "0x3365780", Offset = "0x3364B80", Length = "0x2BA")]
	[Token(Token = "0x6002DE4")]
	public void ScrollHorizontally(float horizontalOffset) { }

	[Address(RVA = "0x3367C60", Offset = "0x3367060", Length = "0xAF")]
	[Token(Token = "0x6002DC6")]
	protected private void set_sortDescriptions(SortColumnDescriptions value) { }

	[Address(RVA = "0x3367D10", Offset = "0x3367110", Length = "0x33")]
	[Token(Token = "0x6002DC9")]
	public void set_sortingEnabled(bool value) { }

	[Address(RVA = "0x3365A40", Offset = "0x3364E40", Length = "0x530")]
	[Token(Token = "0x6002DD6")]
	private void UpdateColumnControls() { }

	[Address(RVA = "0x3365F80", Offset = "0x3365380", Length = "0x250")]
	[Token(Token = "0x6002DE3")]
	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	[Address(RVA = "0x33661E0", Offset = "0x33655E0", Length = "0x61D")]
	[Token(Token = "0x6002DD5")]
	private void UpdateSortedColumns() { }

	[Address(RVA = "0x3366800", Offset = "0x3365C00", Length = "0x511")]
	[Token(Token = "0x6002DE8")]
	private void UpdateSortingStatus() { }

}

