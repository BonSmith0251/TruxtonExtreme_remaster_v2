namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x2000115")]
[UxmlObject]
public class Columns : ICollection<Column>, IEnumerable<Column>, IEnumerable, INotifyBindablePropertyChanged
{
	[CompilerGenerated]
	[Token(Token = "0x200011A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000592")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000593")]
		public static Predicate<Column> <>9__87_0; //Field offset: 0x8

		[Address(RVA = "0x33911B0", Offset = "0x33905B0", Length = "0x67")]
		[Token(Token = "0x60008D5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008D6")]
		public <>c() { }

		[Address(RVA = "0x33910C0", Offset = "0x33904C0", Length = "0x17")]
		[Token(Token = "0x60008D7")]
		internal bool <UpdateVisibleColumns>b__87_0(Column c) { }

	}

	[Token(Token = "0x2000116")]
	internal enum StretchMode : int
	{
		Grow = 0,
		GrowAndFill = 1,
	}

	[Obsolete("UxmlObjectFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000118")]
	public class UxmlObjectFactory : UxmlObjectFactory<Columns>
	{

		[Address(RVA = "0x33914A0", Offset = "0x33908A0", Length = "0x39")]
		[Token(Token = "0x60008D2")]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000117")]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[Address(RVA = "0x11E5050", Offset = "0x11E4450", Length = "0x22")]
		[Token(Token = "0x60008D1")]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000119")]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058C")]
		private readonly UxmlStringAttributeDescription m_PrimaryColumnName; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058D")]
		private readonly UxmlEnumAttributeDescription<StretchMode> m_StretchMode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058E")]
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058F")]
		private readonly UxmlBoolAttributeDescription m_Resizable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000590")]
		private readonly UxmlBoolAttributeDescription m_ResizePreview; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000591")]
		private readonly UxmlObjectListAttributeDescription<Column> m_Columns; //Field offset: 0x0

		[Address(RVA = "0x11E6FA0", Offset = "0x11E63A0", Length = "0x26D")]
		[Token(Token = "0x60008D4")]
		public UxmlObjectTraits`1() { }

		[Address(RVA = "0x11E59E0", Offset = "0x11E4DE0", Length = "0x3E7")]
		[Token(Token = "0x60008D3")]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000574")]
	private static readonly BindingId primaryColumnNameProperty; //Field offset: 0x0
	[Token(Token = "0x4000575")]
	private static readonly BindingId reorderableProperty; //Field offset: 0x98
	[Token(Token = "0x4000576")]
	private static readonly BindingId resizableProperty; //Field offset: 0x130
	[Token(Token = "0x4000577")]
	private static readonly BindingId resizePreviewProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000578")]
	private static readonly BindingId stretchModeProperty; //Field offset: 0x260
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000579")]
	private IList<Column> m_Columns; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400057A")]
	private List<Column> m_DisplayColumns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400057B")]
	private List<Column> m_VisibleColumns; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400057C")]
	private bool m_VisibleColumnsDirty; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400057D")]
	private StretchMode m_StretchMode; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400057E")]
	private bool m_Reorderable; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400057F")]
	private bool m_Resizable; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000580")]
	private bool m_ResizePreview; //Field offset: 0x32
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000581")]
	private string m_PrimaryColumnName; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000582")]
	private EventHandler<BindablePropertyChangedEventArgs> propertyChanged; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000583")]
	private Action<ColumnsDataType> changed; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000584")]
	private Action<Column, Int32> columnAdded; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000585")]
	private Action<Column> columnRemoved; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000586")]
	private Action<Column, ColumnDataType> columnChanged; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000587")]
	private Action<Column> columnResized; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000588")]
	private Action<Column, Int32, Int32> columnReordered; //Field offset: 0x70

	[Token(Token = "0x14000019")]
	internal event Action<ColumnsDataType> changed
	{
		[Address(RVA = "0x337DFF0", Offset = "0x337D3F0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008A9")]
		internal add { } //Length: 172
		[Address(RVA = "0x337E780", Offset = "0x337DB80", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008AA")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001A")]
	internal event Action<Column, Int32> columnAdded
	{
		[Address(RVA = "0x337E0A0", Offset = "0x337D4A0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008AD")]
		internal add { } //Length: 172
		[Address(RVA = "0x337E830", Offset = "0x337DC30", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008AE")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001C")]
	internal event Action<Column, ColumnDataType> columnChanged
	{
		[Address(RVA = "0x337E150", Offset = "0x337D550", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008B1")]
		internal add { } //Length: 172
		[Address(RVA = "0x337E8E0", Offset = "0x337DCE0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008B2")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001B")]
	internal event Action<Column> columnRemoved
	{
		[Address(RVA = "0x337E200", Offset = "0x337D600", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008AF")]
		internal add { } //Length: 172
		[Address(RVA = "0x337E990", Offset = "0x337DD90", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008B0")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001E")]
	internal event Action<Column, Int32, Int32> columnReordered
	{
		[Address(RVA = "0x337E2B0", Offset = "0x337D6B0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008B5")]
		internal add { } //Length: 172
		[Address(RVA = "0x337EA40", Offset = "0x337DE40", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008B6")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001D")]
	internal event Action<Column> columnResized
	{
		[Address(RVA = "0x337E360", Offset = "0x337D760", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008B3")]
		internal add { } //Length: 172
		[Address(RVA = "0x337EAF0", Offset = "0x337DEF0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008B4")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x14000018")]
	public override event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Address(RVA = "0x337E410", Offset = "0x337D810", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600089D")]
		 add { } //Length: 172
		[Address(RVA = "0x337EBA0", Offset = "0x337DFA0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600089E")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x1700017F")]
	public override int Count
	{
		[Address(RVA = "0x337E4C0", Offset = "0x337D8C0", Length = "0x46")]
		[Token(Token = "0x60008C3")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700017C")]
	internal IEnumerable<Column> displayList
	{
		[Address(RVA = "0x337E740", Offset = "0x337DB40", Length = "0x1A")]
		[Token(Token = "0x60008A7")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000180")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x337E510", Offset = "0x337D910", Length = "0x49")]
		[Token(Token = "0x60008C4")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000181")]
	public Column Item
	{
		[Address(RVA = "0x337E560", Offset = "0x337D960", Length = "0x54")]
		[Token(Token = "0x60008C7")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000182")]
	public Column Item
	{
		[Address(RVA = "0x337E5C0", Offset = "0x337D9C0", Length = "0x175")]
		[Token(Token = "0x60008C8")]
		 get { } //Length: 373
	}

	[CreateProperty]
	[Token(Token = "0x17000178")]
	public string primaryColumnName
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600089F")]
		 get { } //Length: 5
		[Address(RVA = "0x337EC50", Offset = "0x337E050", Length = "0xA4")]
		[Token(Token = "0x60008A0")]
		 set { } //Length: 164
	}

	[CreateProperty]
	[Token(Token = "0x17000179")]
	public bool reorderable
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60008A1")]
		 get { } //Length: 5
		[Address(RVA = "0x337ED00", Offset = "0x337E100", Length = "0x95")]
		[Token(Token = "0x60008A2")]
		 set { } //Length: 149
	}

	[CreateProperty]
	[Token(Token = "0x1700017A")]
	public bool resizable
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x60008A3")]
		 get { } //Length: 5
		[Address(RVA = "0x337EDA0", Offset = "0x337E1A0", Length = "0x95")]
		[Token(Token = "0x60008A4")]
		 set { } //Length: 149
	}

	[CreateProperty]
	[Token(Token = "0x1700017B")]
	public bool resizePreview
	{
		[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
		[Token(Token = "0x60008A5")]
		 get { } //Length: 5
		[Address(RVA = "0x337EE40", Offset = "0x337E240", Length = "0x95")]
		[Token(Token = "0x60008A6")]
		 set { } //Length: 149
	}

	[CreateProperty]
	[Token(Token = "0x1700017E")]
	public StretchMode stretchMode
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x60008AB")]
		 get { } //Length: 4
		[Address(RVA = "0x337EEE0", Offset = "0x337E2E0", Length = "0x92")]
		[Token(Token = "0x60008AC")]
		 set { } //Length: 146
	}

	[Token(Token = "0x1700017D")]
	internal IEnumerable<Column> visibleList
	{
		[Address(RVA = "0x337E760", Offset = "0x337DB60", Length = "0x1A")]
		[Token(Token = "0x60008A8")]
		internal get { } //Length: 26
	}

	[Address(RVA = "0x337DB30", Offset = "0x337CF30", Length = "0x42B")]
	[Token(Token = "0x60008D0")]
	private static Columns() { }

	[Address(RVA = "0x337DF60", Offset = "0x337D360", Length = "0x88")]
	[Token(Token = "0x60008CF")]
	public Columns() { }

	[Address(RVA = "0x337C660", Offset = "0x337BA60", Length = "0x62")]
	[Token(Token = "0x60008BA")]
	public override void Add(Column item) { }

	[Address(RVA = "0x337DFF0", Offset = "0x337D3F0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008A9")]
	internal void add_changed(Action<ColumnsDataType> value) { }

	[Address(RVA = "0x337E0A0", Offset = "0x337D4A0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008AD")]
	internal void add_columnAdded(Action<Column, Int32> value) { }

	[Address(RVA = "0x337E150", Offset = "0x337D550", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008B1")]
	internal void add_columnChanged(Action<Column, ColumnDataType> value) { }

	[Address(RVA = "0x337E200", Offset = "0x337D600", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008AF")]
	internal void add_columnRemoved(Action<Column> value) { }

	[Address(RVA = "0x337E2B0", Offset = "0x337D6B0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008B5")]
	internal void add_columnReordered(Action<Column, Int32, Int32> value) { }

	[Address(RVA = "0x337E360", Offset = "0x337D760", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008B3")]
	internal void add_columnResized(Action<Column> value) { }

	[Address(RVA = "0x337E410", Offset = "0x337D810", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600089D")]
	public override void add_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x337C6D0", Offset = "0x337BAD0", Length = "0x21D")]
	[Token(Token = "0x60008BB")]
	public override void Clear() { }

	[Address(RVA = "0x337C8F0", Offset = "0x337BCF0", Length = "0x171")]
	[Token(Token = "0x60008BD")]
	public bool Contains(string name) { }

	[Address(RVA = "0x337CA70", Offset = "0x337BE70", Length = "0x58")]
	[Token(Token = "0x60008BC")]
	public override bool Contains(Column item) { }

	[Address(RVA = "0x337CAD0", Offset = "0x337BED0", Length = "0xCC")]
	[Token(Token = "0x60008BE")]
	public override void CopyTo(Column[] array, int arrayIndex) { }

	[Address(RVA = "0x337CBA0", Offset = "0x337BFA0", Length = "0x60")]
	[Token(Token = "0x60008CB")]
	private void DirtyVisibleColumns() { }

	[Address(RVA = "0x337E4C0", Offset = "0x337D8C0", Length = "0x46")]
	[Token(Token = "0x60008C3")]
	public override int get_Count() { }

	[Address(RVA = "0x337E740", Offset = "0x337DB40", Length = "0x1A")]
	[Token(Token = "0x60008A7")]
	internal IEnumerable<Column> get_displayList() { }

	[Address(RVA = "0x337E510", Offset = "0x337D910", Length = "0x49")]
	[Token(Token = "0x60008C4")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x337E560", Offset = "0x337D960", Length = "0x54")]
	[Token(Token = "0x60008C7")]
	public Column get_Item(int index) { }

	[Address(RVA = "0x337E5C0", Offset = "0x337D9C0", Length = "0x175")]
	[Token(Token = "0x60008C8")]
	public Column get_Item(string name) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600089F")]
	public string get_primaryColumnName() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x60008A1")]
	public bool get_reorderable() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x60008A3")]
	public bool get_resizable() { }

	[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
	[Token(Token = "0x60008A5")]
	public bool get_resizePreview() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x60008AB")]
	public StretchMode get_stretchMode() { }

	[Address(RVA = "0x337E760", Offset = "0x337DB60", Length = "0x1A")]
	[Token(Token = "0x60008A8")]
	internal IEnumerable<Column> get_visibleList() { }

	[Address(RVA = "0x337CC00", Offset = "0x337C000", Length = "0x46")]
	[Token(Token = "0x60008B8")]
	public override IEnumerator<Column> GetEnumerator() { }

	[Address(RVA = "0x337CC50", Offset = "0x337C050", Length = "0x58")]
	[Token(Token = "0x60008C5")]
	public int IndexOf(Column column) { }

	[Address(RVA = "0x337CCB0", Offset = "0x337C0B0", Length = "0x79")]
	[Token(Token = "0x60008CA")]
	private void InitOrderColumns() { }

	[Address(RVA = "0x337CD30", Offset = "0x337C130", Length = "0x37A")]
	[Token(Token = "0x60008C6")]
	public void Insert(int index, Column column) { }

	[Address(RVA = "0x337D0B0", Offset = "0x337C4B0", Length = "0x7D")]
	[Token(Token = "0x60008B7")]
	public bool IsPrimary(Column column) { }

	[Address(RVA = "0x337D130", Offset = "0x337C530", Length = "0x19")]
	[Token(Token = "0x60008CD")]
	private void NotifyChange(ColumnsDataType type) { }

	[Address(RVA = "0x337D150", Offset = "0x337C550", Length = "0xE9")]
	[Token(Token = "0x60008CE")]
	private void NotifyPropertyChanged(in BindingId property) { }

	[Address(RVA = "0x337D240", Offset = "0x337C640", Length = "0x97")]
	[Token(Token = "0x60008C1")]
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	[Address(RVA = "0x337D2E0", Offset = "0x337C6E0", Length = "0x19")]
	[Token(Token = "0x60008C2")]
	private void OnColumnResized(Column column) { }

	[Address(RVA = "0x337D300", Offset = "0x337C700", Length = "0x24F")]
	[Token(Token = "0x60008C0")]
	private void OnColumnsPropertyChanged(object sender, BindablePropertyChangedEventArgs args) { }

	[Address(RVA = "0x337D550", Offset = "0x337C950", Length = "0x2AD")]
	[Token(Token = "0x60008BF")]
	public override bool Remove(Column column) { }

	[Address(RVA = "0x337E780", Offset = "0x337DB80", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008AA")]
	internal void remove_changed(Action<ColumnsDataType> value) { }

	[Address(RVA = "0x337E830", Offset = "0x337DC30", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008AE")]
	internal void remove_columnAdded(Action<Column, Int32> value) { }

	[Address(RVA = "0x337E8E0", Offset = "0x337DCE0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008B2")]
	internal void remove_columnChanged(Action<Column, ColumnDataType> value) { }

	[Address(RVA = "0x337E990", Offset = "0x337DD90", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008B0")]
	internal void remove_columnRemoved(Action<Column> value) { }

	[Address(RVA = "0x337EA40", Offset = "0x337DE40", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008B6")]
	internal void remove_columnReordered(Action<Column, Int32, Int32> value) { }

	[Address(RVA = "0x337EAF0", Offset = "0x337DEF0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60008B4")]
	internal void remove_columnResized(Action<Column> value) { }

	[Address(RVA = "0x337EBA0", Offset = "0x337DFA0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600089E")]
	public override void remove_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x337D800", Offset = "0x337CC00", Length = "0x13D")]
	[Token(Token = "0x60008C9")]
	public void ReorderDisplay(int from, int to) { }

	[Address(RVA = "0x337EC50", Offset = "0x337E050", Length = "0xA4")]
	[Token(Token = "0x60008A0")]
	public void set_primaryColumnName(string value) { }

	[Address(RVA = "0x337ED00", Offset = "0x337E100", Length = "0x95")]
	[Token(Token = "0x60008A2")]
	public void set_reorderable(bool value) { }

	[Address(RVA = "0x337EDA0", Offset = "0x337E1A0", Length = "0x95")]
	[Token(Token = "0x60008A4")]
	public void set_resizable(bool value) { }

	[Address(RVA = "0x337EE40", Offset = "0x337E240", Length = "0x95")]
	[Token(Token = "0x60008A6")]
	public void set_resizePreview(bool value) { }

	[Address(RVA = "0x337EEE0", Offset = "0x337E2E0", Length = "0x92")]
	[Token(Token = "0x60008AC")]
	public void set_stretchMode(StretchMode value) { }

	[Address(RVA = "0x337CC00", Offset = "0x337C000", Length = "0x46")]
	[Token(Token = "0x60008B9")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x337D940", Offset = "0x337CD40", Length = "0x1E8")]
	[Token(Token = "0x60008CC")]
	private void UpdateVisibleColumns() { }

}

