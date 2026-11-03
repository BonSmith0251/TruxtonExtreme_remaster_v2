namespace UnityEngine.UIElements;

[Token(Token = "0x2000124")]
[UxmlObject]
public class SortColumnDescription : INotifyBindablePropertyChanged
{
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000126")]
	public class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescription>
	{

		[Address(RVA = "0x33A82C0", Offset = "0x33A76C0", Length = "0x39")]
		[Token(Token = "0x6000936")]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000125")]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[Address(RVA = "0x11E5050", Offset = "0x11E4450", Length = "0x22")]
		[Token(Token = "0x6000935")]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000127")]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CD")]
		private readonly UxmlStringAttributeDescription m_ColumnName; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CE")]
		private readonly UxmlIntAttributeDescription m_ColumnIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CF")]
		private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription; //Field offset: 0x0

		[Address(RVA = "0x11E7210", Offset = "0x11E6610", Length = "0x183")]
		[Token(Token = "0x6000938")]
		public UxmlObjectTraits`1() { }

		[Address(RVA = "0x11E67B0", Offset = "0x11E5BB0", Length = "0x194")]
		[Token(Token = "0x6000937")]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005C4")]
	private static readonly BindingId columnNameProperty; //Field offset: 0x0
	[Token(Token = "0x40005C5")]
	private static readonly BindingId columnIndexProperty; //Field offset: 0x98
	[Token(Token = "0x40005C6")]
	private static readonly BindingId directionProperty; //Field offset: 0x130
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40005C7")]
	private int m_ColumnIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40005C8")]
	private string m_ColumnName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40005C9")]
	private SortDirection m_SortDirection; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005CA")]
	private EventHandler<BindablePropertyChangedEventArgs> propertyChanged; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005CB")]
	private Column <column>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005CC")]
	private Action<SortColumnDescription> changed; //Field offset: 0x38

	[Token(Token = "0x14000022")]
	internal event Action<SortColumnDescription> changed
	{
		[Address(RVA = "0x33A4680", Offset = "0x33A3A80", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600092E")]
		internal add { } //Length: 172
		[Address(RVA = "0x33A47E0", Offset = "0x33A3BE0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600092F")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x14000021")]
	public override event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Address(RVA = "0x33A4730", Offset = "0x33A3B30", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000924")]
		 add { } //Length: 172
		[Address(RVA = "0x33A4890", Offset = "0x33A3C90", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000925")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x1700018F")]
	public internal Column column
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600092A")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600092B")]
		internal set { } //Length: 13
	}

	[CreateProperty]
	[Token(Token = "0x1700018E")]
	public int columnIndex
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000928")]
		 get { } //Length: 85
		[Address(RVA = "0x33A4940", Offset = "0x33A3D40", Length = "0x90")]
		[Token(Token = "0x6000929")]
		 set { } //Length: 144
	}

	[CreateProperty]
	[Token(Token = "0x1700018D")]
	public string columnName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000926")]
		 get { } //Length: 5
		[Address(RVA = "0x33A49D0", Offset = "0x33A3DD0", Length = "0xA5")]
		[Token(Token = "0x6000927")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x17000190")]
	public SortDirection direction
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x600092C")]
		 get { } //Length: 4
		[Address(RVA = "0x33A4A80", Offset = "0x33A3E80", Length = "0x90")]
		[Token(Token = "0x600092D")]
		 set { } //Length: 144
	}

	[Address(RVA = "0x33A4160", Offset = "0x33A3560", Length = "0x2A5")]
	[Token(Token = "0x6000934")]
	private static SortColumnDescription() { }

	[Address(RVA = "0x33A4410", Offset = "0x33A3810", Length = "0x136")]
	[Token(Token = "0x6000932")]
	public SortColumnDescription(string columnName, SortDirection direction) { }

	[Address(RVA = "0x33A4550", Offset = "0x33A3950", Length = "0x121")]
	[Token(Token = "0x6000931")]
	public SortColumnDescription(int columnIndex, SortDirection direction) { }

	[Address(RVA = "0x19BFBF0", Offset = "0x19BEFF0", Length = "0xE")]
	[Token(Token = "0x6000930")]
	public SortColumnDescription() { }

	[Address(RVA = "0x33A4680", Offset = "0x33A3A80", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600092E")]
	internal void add_changed(Action<SortColumnDescription> value) { }

	[Address(RVA = "0x33A4730", Offset = "0x33A3B30", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000924")]
	public override void add_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600092A")]
	public Column get_column() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000928")]
	public int get_columnIndex() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000926")]
	public string get_columnName() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x600092C")]
	public SortDirection get_direction() { }

	[Address(RVA = "0x33A4070", Offset = "0x33A3470", Length = "0xE9")]
	[Token(Token = "0x6000933")]
	private void NotifyPropertyChanged(in BindingId property) { }

	[Address(RVA = "0x33A47E0", Offset = "0x33A3BE0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600092F")]
	internal void remove_changed(Action<SortColumnDescription> value) { }

	[Address(RVA = "0x33A4890", Offset = "0x33A3C90", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000925")]
	public override void remove_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600092B")]
	internal void set_column(Column value) { }

	[Address(RVA = "0x33A4940", Offset = "0x33A3D40", Length = "0x90")]
	[Token(Token = "0x6000929")]
	public void set_columnIndex(int value) { }

	[Address(RVA = "0x33A49D0", Offset = "0x33A3DD0", Length = "0xA5")]
	[Token(Token = "0x6000927")]
	public void set_columnName(string value) { }

	[Address(RVA = "0x33A4A80", Offset = "0x33A3E80", Length = "0x90")]
	[Token(Token = "0x600092D")]
	public void set_direction(SortDirection value) { }

}

