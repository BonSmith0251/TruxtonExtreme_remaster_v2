namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000677")]
internal class MultiColumnHeaderColumn : VisualElement
{
	[Token(Token = "0x4001846")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4001847")]
	public static readonly string sortableUssClassName; //Field offset: 0x8
	[Token(Token = "0x4001848")]
	public static readonly string sortedAscendingUssClassName; //Field offset: 0x10
	[Token(Token = "0x4001849")]
	public static readonly string sortedDescendingUssClassName; //Field offset: 0x18
	[Token(Token = "0x400184A")]
	public static readonly string movingUssClassName; //Field offset: 0x20
	[Token(Token = "0x400184B")]
	public static readonly string contentContainerUssClassName; //Field offset: 0x28
	[Token(Token = "0x400184C")]
	public static readonly string contentUssClassName; //Field offset: 0x30
	[Token(Token = "0x400184D")]
	public static readonly string defaultContentUssClassName; //Field offset: 0x38
	[Token(Token = "0x400184E")]
	public static readonly string hasIconUssClassName; //Field offset: 0x40
	[Token(Token = "0x400184F")]
	public static readonly string hasTitleUssClassName; //Field offset: 0x48
	[Token(Token = "0x4001850")]
	public static readonly string titleUssClassName; //Field offset: 0x50
	[Token(Token = "0x4001851")]
	public static readonly string iconElementName; //Field offset: 0x58
	[Token(Token = "0x4001852")]
	public static readonly string titleElementName; //Field offset: 0x60
	[Token(Token = "0x4001853")]
	private static readonly string s_BoundVEPropertyName; //Field offset: 0x68
	[Token(Token = "0x4001854")]
	private static readonly string s_BindingCallbackVEPropertyName; //Field offset: 0x70
	[Token(Token = "0x4001855")]
	private static readonly string s_UnbindingCallbackVEPropertyName; //Field offset: 0x78
	[Token(Token = "0x4001856")]
	private static readonly string s_DestroyCallbackVEPropertyName; //Field offset: 0x80
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4001857")]
	private VisualElement m_ContentContainer; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4001858")]
	private VisualElement m_Content; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4001859")]
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x400185A")]
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; //Field offset: 0x2E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x400185B")]
	private Clickable <clickable>k__BackingField; //Field offset: 0x2E8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x400185C")]
	private ColumnMover <mover>k__BackingField; //Field offset: 0x2F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x400185D")]
	private Column <column>k__BackingField; //Field offset: 0x2F8

	[Token(Token = "0x17000BAD")]
	public private Clickable clickable
	{
		[Address(RVA = "0x3293220", Offset = "0x3292620", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002E06")]
		 get { } //Length: 8
		[Address(RVA = "0x3293250", Offset = "0x3292650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002E07")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000BB0")]
	public private Column column
	{
		[Address(RVA = "0x336AEC0", Offset = "0x336A2C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002E0B")]
		 get { } //Length: 8
		[Address(RVA = "0x336AFB0", Offset = "0x336A3B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002E0C")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000BB1")]
	public VisualElement content
	{
		[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
		[Token(Token = "0x6002E0D")]
		 get { } //Length: 8
		[Address(RVA = "0x336AFD0", Offset = "0x336A3D0", Length = "0x2A3")]
		[Token(Token = "0x6002E0E")]
		 set { } //Length: 675
	}

	[Token(Token = "0x17000BB2")]
	private bool isContentBound
	{
		[Address(RVA = "0x336AED0", Offset = "0x336A2D0", Length = "0xCD")]
		[Token(Token = "0x6002E0F")]
		private get { } //Length: 205
		[Address(RVA = "0x336B280", Offset = "0x336A680", Length = "0xA3")]
		[Token(Token = "0x6002E10")]
		private set { } //Length: 163
	}

	[Token(Token = "0x17000BAE")]
	public private ColumnMover mover
	{
		[Address(RVA = "0x336AFA0", Offset = "0x336A3A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002E08")]
		 get { } //Length: 8
		[Address(RVA = "0x336B330", Offset = "0x336A730", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002E09")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000BAF")]
	public string sortOrderLabel
	{
		[Address(RVA = "0x336B350", Offset = "0x336A750", Length = "0x39")]
		[Token(Token = "0x6002E0A")]
		 set { } //Length: 57
	}

	[Address(RVA = "0x3369F00", Offset = "0x3369300", Length = "0x5A3")]
	[Token(Token = "0x6002E1F")]
	private static MultiColumnHeaderColumn() { }

	[Address(RVA = "0x336A4B0", Offset = "0x33698B0", Length = "0xA07")]
	[Token(Token = "0x6002E11")]
	public MultiColumnHeaderColumn(Column column) { }

	[Address(RVA = "0x33688D0", Offset = "0x3367CD0", Length = "0xD6")]
	[Token(Token = "0x6002E17")]
	private void BindHeaderContent() { }

	[Address(RVA = "0x33689B0", Offset = "0x3367DB0", Length = "0x270")]
	[Token(Token = "0x6002E1A")]
	private VisualElement CreateDefaultHeaderContent() { }

	[Address(RVA = "0x3368C30", Offset = "0x3368030", Length = "0x3AA")]
	[Token(Token = "0x6002E1B")]
	private void DefaultBindHeaderContent(VisualElement ve) { }

	[Address(RVA = "0x3368FE0", Offset = "0x33683E0", Length = "0x1A6")]
	[Token(Token = "0x6002E19")]
	private void DestroyHeaderContent() { }

	[Address(RVA = "0x3369190", Offset = "0x3368590", Length = "0x23E")]
	[Token(Token = "0x6002E1E")]
	public void Dispose() { }

	[Address(RVA = "0x3293220", Offset = "0x3292620", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002E06")]
	public Clickable get_clickable() { }

	[Address(RVA = "0x336AEC0", Offset = "0x336A2C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002E0B")]
	public Column get_column() { }

	[Address(RVA = "0x1CE5A20", Offset = "0x1CE4E20", Length = "0x8")]
	[Token(Token = "0x6002E0D")]
	public VisualElement get_content() { }

	[Address(RVA = "0x336AED0", Offset = "0x336A2D0", Length = "0xCD")]
	[Token(Token = "0x6002E0F")]
	private bool get_isContentBound() { }

	[Address(RVA = "0x336AFA0", Offset = "0x336A3A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002E08")]
	public ColumnMover get_mover() { }

	[Address(RVA = "0x33693D0", Offset = "0x33687D0", Length = "0x40C")]
	[Token(Token = "0x6002E14")]
	private void InitManipulators() { }

	[Address(RVA = "0x33697E0", Offset = "0x3368BE0", Length = "0x114")]
	[Token(Token = "0x6002E12")]
	private void OnColumnChanged(Column c, ColumnDataType role) { }

	[Address(RVA = "0x3369900", Offset = "0x3368D00", Length = "0x7")]
	[Token(Token = "0x6002E13")]
	private void OnColumnResized(Column c) { }

	[Address(RVA = "0x3369910", Offset = "0x3368D10", Length = "0xAA")]
	[Token(Token = "0x6002E15")]
	private void OnMoverChanged(ColumnMover mv) { }

	[Address(RVA = "0x3293250", Offset = "0x3292650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002E07")]
	private void set_clickable(Clickable value) { }

	[Address(RVA = "0x336AFB0", Offset = "0x336A3B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002E0C")]
	private void set_column(Column value) { }

	[Address(RVA = "0x336AFD0", Offset = "0x336A3D0", Length = "0x2A3")]
	[Token(Token = "0x6002E0E")]
	public void set_content(VisualElement value) { }

	[Address(RVA = "0x336B280", Offset = "0x336A680", Length = "0xA3")]
	[Token(Token = "0x6002E10")]
	private void set_isContentBound(bool value) { }

	[Address(RVA = "0x336B330", Offset = "0x336A730", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002E09")]
	private void set_mover(ColumnMover value) { }

	[Address(RVA = "0x336B350", Offset = "0x336A750", Length = "0x39")]
	[Token(Token = "0x6002E0A")]
	public void set_sortOrderLabel(string value) { }

	[Address(RVA = "0x33699C0", Offset = "0x3368DC0", Length = "0xD6")]
	[Token(Token = "0x6002E18")]
	private void UnbindHeaderContent() { }

	[Address(RVA = "0x3369AA0", Offset = "0x3368EA0", Length = "0x101")]
	[Token(Token = "0x6002E16")]
	private void UpdateDataFromColumn() { }

	[Address(RVA = "0x3369BB0", Offset = "0x3368FB0", Length = "0x126")]
	[Token(Token = "0x6002E1D")]
	private void UpdateGeometryFromColumn() { }

	[Address(RVA = "0x3369CE0", Offset = "0x33690E0", Length = "0x21C")]
	[Token(Token = "0x6002E1C")]
	private void UpdateHeaderTemplate() { }

}

