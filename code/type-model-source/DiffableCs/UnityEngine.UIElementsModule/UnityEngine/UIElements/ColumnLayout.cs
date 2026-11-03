namespace UnityEngine.UIElements;

[Token(Token = "0x2000111")]
internal class ColumnLayout
{
	[CompilerGenerated]
	[Token(Token = "0x2000112")]
	private sealed class <>c__DisplayClass54_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400056A")]
		public float totalColumnWidth; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400056B")]
		public ColumnLayout <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000899")]
		public <>c__DisplayClass54_0() { }

		[Address(RVA = "0x33910E0", Offset = "0x33904E0", Length = "0xC3")]
		[Token(Token = "0x600089A")]
		internal void <RecomputeToMaxWidthProportionally>b__1(Column c) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000113")]
	private sealed class <>c__DisplayClass55_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400056C")]
		public float totalColumnsWidth; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400056D")]
		public ColumnLayout <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600089B")]
		public <>c__DisplayClass55_0() { }

		[Address(RVA = "0x33910E0", Offset = "0x33904E0", Length = "0xC3")]
		[Token(Token = "0x600089C")]
		internal void <RecomputeToMinWidthProportionally>b__1(Column c) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000554")]
	private List<Column> m_StretchableColumns; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000555")]
	private List<Column> m_FixedColumns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000556")]
	private List<Column> m_RelativeWidthColumns; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000557")]
	private List<Column> m_MixedWidthColumns; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000558")]
	private Columns m_Columns; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000559")]
	private float m_ColumnsWidth; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400055A")]
	private bool m_ColumnsWidthDirty; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400055B")]
	private float m_MaxColumnsWidth; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400055C")]
	private float m_MinColumnsWidth; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400055D")]
	private bool m_IsDirty; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400055E")]
	private float m_PreviousWidth; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400055F")]
	private float m_LayoutWidth; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000560")]
	private bool m_DragResizeInPreviewMode; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4000561")]
	private bool m_DragResizing; //Field offset: 0x55
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000562")]
	private float m_DragStartPos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000563")]
	private float m_DragLastPos; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000564")]
	private float m_DragInitialColumnWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000565")]
	private List<Column> m_DragStretchableColumns; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000566")]
	private List<Column> m_DragRelativeColumns; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000567")]
	private List<Column> m_DragFixedColumns; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000568")]
	private Dictionary<Column, Single> m_PreviewDesiredWidths; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000569")]
	private Action layoutRequested; //Field offset: 0x88

	[Token(Token = "0x14000017")]
	public event Action layoutRequested
	{
		[Address(RVA = "0x337A480", Offset = "0x3379880", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000875")]
		 add { } //Length: 162
		[Address(RVA = "0x337A7F0", Offset = "0x3379BF0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000876")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x17000171")]
	public Columns columns
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600086E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000172")]
	public float columnsWidth
	{
		[Address(RVA = "0x337A530", Offset = "0x3379930", Length = "0x204")]
		[Token(Token = "0x600086F")]
		 get { } //Length: 516
	}

	[Token(Token = "0x17000177")]
	public bool hasRelativeWidthColumns
	{
		[Address(RVA = "0x337A740", Offset = "0x3379B40", Length = "0x5B")]
		[Token(Token = "0x6000874")]
		 get { } //Length: 91
	}

	[Token(Token = "0x17000176")]
	public bool hasStretchableColumns
	{
		[Address(RVA = "0x337A7A0", Offset = "0x3379BA0", Length = "0x40")]
		[Token(Token = "0x6000873")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000173")]
	public float layoutWidth
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[Token(Token = "0x6000870")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000175")]
	public float maxColumnsWidth
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x6000872")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000174")]
	public float minColumnsWidth
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x6000871")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x337A040", Offset = "0x3379440", Length = "0x435")]
	[Token(Token = "0x6000877")]
	public ColumnLayout(Columns columns) { }

	[Address(RVA = "0x33799C0", Offset = "0x3378DC0", Length = "0x7D")]
	[CompilerGenerated]
	[Token(Token = "0x6000895")]
	private int <DoLayout>b__50_0(Column c1, Column c2) { }

	[Address(RVA = "0x33799C0", Offset = "0x3378DC0", Length = "0x7D")]
	[CompilerGenerated]
	[Token(Token = "0x6000896")]
	private int <DoLayout>b__50_1(Column c1, Column c2) { }

	[Address(RVA = "0x33799C0", Offset = "0x3378DC0", Length = "0x7D")]
	[CompilerGenerated]
	[Token(Token = "0x6000897")]
	private int <RecomputeToMaxWidthProportionally>b__54_0(Column c1, Column c2) { }

	[Address(RVA = "0x3379A40", Offset = "0x3378E40", Length = "0x7D")]
	[CompilerGenerated]
	[Token(Token = "0x6000898")]
	private int <RecomputeToMinWidthProportionally>b__55_0(Column c1, Column c2) { }

	[Address(RVA = "0x337A480", Offset = "0x3379880", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6000875")]
	public void add_layoutRequested(Action value) { }

	[Address(RVA = "0x3374C30", Offset = "0x3374030", Length = "0x2E8")]
	[Token(Token = "0x600088D")]
	internal void BeginDragResize(Column column, float pos, bool previewMode) { }

	[Address(RVA = "0x3374F20", Offset = "0x3374320", Length = "0xB6")]
	[Token(Token = "0x6000894")]
	private void ClearCache() { }

	[Address(RVA = "0x3374FE0", Offset = "0x33743E0", Length = "0x40")]
	[Token(Token = "0x6000878")]
	public void Dirty() { }

	[Address(RVA = "0x3375020", Offset = "0x3374420", Length = "0x396")]
	[Token(Token = "0x6000884")]
	private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	[Address(RVA = "0x33753C0", Offset = "0x33747C0", Length = "0x2FE")]
	[Token(Token = "0x6000883")]
	private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	[Address(RVA = "0x33756C0", Offset = "0x3374AC0", Length = "0x11D2")]
	[Token(Token = "0x6000881")]
	public void DoLayout(float width) { }

	[Address(RVA = "0x33768A0", Offset = "0x3375CA0", Length = "0x4F2")]
	[Token(Token = "0x6000890")]
	public void DragResize(Column column, float pos) { }

	[Address(RVA = "0x3376DA0", Offset = "0x33761A0", Length = "0x24F")]
	[Token(Token = "0x6000891")]
	internal void EndDragResize(Column column, bool cancelled) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600086E")]
	public Columns get_columns() { }

	[Address(RVA = "0x337A530", Offset = "0x3379930", Length = "0x204")]
	[Token(Token = "0x600086F")]
	public float get_columnsWidth() { }

	[Address(RVA = "0x337A740", Offset = "0x3379B40", Length = "0x5B")]
	[Token(Token = "0x6000874")]
	public bool get_hasRelativeWidthColumns() { }

	[Address(RVA = "0x337A7A0", Offset = "0x3379BA0", Length = "0x40")]
	[Token(Token = "0x6000873")]
	public bool get_hasStretchableColumns() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[Token(Token = "0x6000870")]
	public float get_layoutWidth() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x6000872")]
	public float get_maxColumnsWidth() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x6000871")]
	public float get_minColumnsWidth() { }

	[Address(RVA = "0x3376FF0", Offset = "0x33763F0", Length = "0x14B")]
	[Token(Token = "0x600088E")]
	public float GetDesiredPosition(Column column) { }

	[Address(RVA = "0x3377140", Offset = "0x3376540", Length = "0x9C")]
	[Token(Token = "0x600088F")]
	public float GetDesiredWidth(Column c) { }

	[Address(RVA = "0x33771E0", Offset = "0x33765E0", Length = "0xF")]
	[Token(Token = "0x6000880")]
	private static bool IsClamped(float value, float min, float max) { }

	[Address(RVA = "0x33771F0", Offset = "0x33765F0", Length = "0x4EB")]
	[Token(Token = "0x600087E")]
	private void MakeRoomForColumn(Column column) { }

	[Address(RVA = "0x33776E0", Offset = "0x3376AE0", Length = "0x101")]
	[Token(Token = "0x6000879")]
	private void OnColumnAdded(Column column, int index) { }

	[Address(RVA = "0x33777F0", Offset = "0x3376BF0", Length = "0x1D9")]
	[Token(Token = "0x600087D")]
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	[Address(RVA = "0x33779D0", Offset = "0x3376DD0", Length = "0x101")]
	[Token(Token = "0x600087A")]
	private void OnColumnRemoved(Column column) { }

	[Address(RVA = "0x3374FE0", Offset = "0x33743E0", Length = "0x40")]
	[Token(Token = "0x600087B")]
	private void OnColumnReordered(Column column, int from, int to) { }

	[Address(RVA = "0x2E3D9F0", Offset = "0x2E3CDF0", Length = "0x5")]
	[Token(Token = "0x600087F")]
	private void OnColumnResized(Column column) { }

	[Address(RVA = "0x3377E00", Offset = "0x3377200", Length = "0x140")]
	[Token(Token = "0x6000887")]
	private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	[Address(RVA = "0x3377AE0", Offset = "0x3376EE0", Length = "0x318")]
	[Token(Token = "0x6000888")]
	private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	[Address(RVA = "0x3378470", Offset = "0x3377870", Length = "0x295")]
	[Token(Token = "0x600088A")]
	private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x3377F50", Offset = "0x3377350", Length = "0x519")]
	[Token(Token = "0x6000885")]
	private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x3378BE0", Offset = "0x3377FE0", Length = "0x278")]
	[Token(Token = "0x6000889")]
	private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x3378710", Offset = "0x3377B10", Length = "0x4CC")]
	[Token(Token = "0x6000886")]
	private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x337A7F0", Offset = "0x3379BF0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6000876")]
	public void remove_layoutRequested(Action value) { }

	[Address(RVA = "0x3378E60", Offset = "0x3378260", Length = "0x16")]
	[Token(Token = "0x600087C")]
	private bool RequiresLayoutUpdate(ColumnDataType type) { }

	[Address(RVA = "0x3378E80", Offset = "0x3378280", Length = "0x1D4")]
	[Token(Token = "0x600088C")]
	private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x3379060", Offset = "0x3378460", Length = "0x88F")]
	[Token(Token = "0x600088B")]
	public void ResizeToFit(float width) { }

	[Address(RVA = "0x33798F0", Offset = "0x3378CF0", Length = "0xC3")]
	[Token(Token = "0x6000882")]
	public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	[Address(RVA = "0x3379AC0", Offset = "0x3378EC0", Length = "0x32A")]
	[Token(Token = "0x6000892")]
	private void UpdateCache() { }

	[Address(RVA = "0x3379DF0", Offset = "0x33791F0", Length = "0x248")]
	[Token(Token = "0x6000893")]
	private void UpdateMinAndMaxColumnsWidth() { }

}

