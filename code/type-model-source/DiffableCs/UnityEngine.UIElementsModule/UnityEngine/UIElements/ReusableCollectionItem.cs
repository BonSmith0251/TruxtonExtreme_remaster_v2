namespace UnityEngine.UIElements;

[Token(Token = "0x200006B")]
internal class ReusableCollectionItem
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F9")]
	private VisualElement <bindableElement>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FA")]
	private ValueAnimation<StyleValues> <animator>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FB")]
	private int <index>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001FC")]
	private int <id>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001FD")]
	private bool <isDragGhost>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001FE")]
	private Action<ReusableCollectionItem> onGeometryChanged; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001FF")]
	protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000200")]
	private Action<ReusableCollectionItem> onDestroy; //Field offset: 0x40

	[Token(Token = "0x1400000D")]
	internal event Action<ReusableCollectionItem> onDestroy
	{
		[Address(RVA = "0x3226700", Offset = "0x3225B00", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60003B3")]
		internal add { } //Length: 172
		[Address(RVA = "0x3226860", Offset = "0x3225C60", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60003B4")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400000C")]
	public event Action<ReusableCollectionItem> onGeometryChanged
	{
		[Address(RVA = "0x32267B0", Offset = "0x3225BB0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60003B1")]
		 add { } //Length: 172
		[Address(RVA = "0x3226910", Offset = "0x3225D10", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60003B2")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x1700007F")]
	public ValueAnimation<StyleValues> animator
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003A9")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60003AA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700007E")]
	public VisualElement bindableElement
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003A7")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60003A8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000081")]
	public int id
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003AD")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003AE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000080")]
	public int index
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003AB")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003AC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000082")]
	internal bool isDragGhost
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003AF")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003B0")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700007D")]
	public override VisualElement rootElement
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60003A6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3226680", Offset = "0x3225A80", Length = "0x7C")]
	[Token(Token = "0x60003B5")]
	public ReusableCollectionItem() { }

	[Address(RVA = "0x3226700", Offset = "0x3225B00", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60003B3")]
	internal void add_onDestroy(Action<ReusableCollectionItem> value) { }

	[Address(RVA = "0x32267B0", Offset = "0x3225BB0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60003B1")]
	public void add_onGeometryChanged(Action<ReusableCollectionItem> value) { }

	[Address(RVA = "0x32260A0", Offset = "0x32254A0", Length = "0x1C")]
	[Token(Token = "0x60003B9")]
	public override void DestroyElement() { }

	[Address(RVA = "0x32260C0", Offset = "0x32254C0", Length = "0x12D")]
	[Token(Token = "0x60003B8")]
	public override void DetachElement() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003A9")]
	public ValueAnimation<StyleValues> get_animator() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003A7")]
	public VisualElement get_bindableElement() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003AD")]
	public int get_id() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003AB")]
	public int get_index() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003AF")]
	internal bool get_isDragGhost() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60003A6")]
	public override VisualElement get_rootElement() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60003B6")]
	public override void Init(VisualElement item) { }

	[Address(RVA = "0x32261F0", Offset = "0x32255F0", Length = "0x7C")]
	[Token(Token = "0x60003BC")]
	protected override void OnGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x3226270", Offset = "0x3225670", Length = "0xCB")]
	[Token(Token = "0x60003B7")]
	public override void PreAttachElement() { }

	[Address(RVA = "0x3226860", Offset = "0x3225C60", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60003B4")]
	internal void remove_onDestroy(Action<ReusableCollectionItem> value) { }

	[Address(RVA = "0x3226910", Offset = "0x3225D10", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60003B2")]
	public void remove_onGeometryChanged(Action<ReusableCollectionItem> value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60003AA")]
	public void set_animator(ValueAnimation<StyleValues> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60003A8")]
	protected void set_bindableElement(VisualElement value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003AE")]
	public void set_id(int value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003AC")]
	public void set_index(int value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003B0")]
	private void set_isDragGhost(bool value) { }

	[Address(RVA = "0x3226340", Offset = "0x3225740", Length = "0x1FA")]
	[Token(Token = "0x60003BB")]
	public override void SetDragGhost(bool dragGhost) { }

	[Address(RVA = "0x3226540", Offset = "0x3225940", Length = "0x131")]
	[Token(Token = "0x60003BA")]
	public override void SetSelected(bool selected) { }

}

