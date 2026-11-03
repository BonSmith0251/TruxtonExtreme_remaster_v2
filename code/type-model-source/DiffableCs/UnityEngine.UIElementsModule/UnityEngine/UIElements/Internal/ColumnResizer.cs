namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x200066D")]
internal class ColumnResizer : PointerManipulator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001814")]
	private Vector2 m_Start; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001815")]
	protected bool m_Active; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001816")]
	private bool m_Resizing; //Field offset: 0x31
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001817")]
	private MultiColumnCollectionHeader m_Header; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001818")]
	private Column m_Column; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001819")]
	private VisualElement m_PreviewElement; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400181A")]
	private ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400181B")]
	private bool <preview>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x17000B9D")]
	public ColumnLayout columnLayout
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002DAF")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002DB0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B9E")]
	public bool preview
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002DB1")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002DB2")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3361910", Offset = "0x3360D10", Length = "0x11C")]
	[Token(Token = "0x6002DB3")]
	public ColumnResizer(Column column) { }

	[Address(RVA = "0x3360B90", Offset = "0x335FF90", Length = "0x4D")]
	[Token(Token = "0x6002DBA")]
	private void BeginDragResize(float pos) { }

	[Address(RVA = "0x3360BE0", Offset = "0x335FFE0", Length = "0x42")]
	[Token(Token = "0x6002DBB")]
	private void DragResize(float pos) { }

	[Address(RVA = "0x3360C30", Offset = "0x3360030", Length = "0x68")]
	[Token(Token = "0x6002DBD")]
	private void EndDragResize(float pos, bool cancelled) { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002DAF")]
	public ColumnLayout get_columnLayout() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002DB1")]
	public bool get_preview() { }

	[Address(RVA = "0x3360CA0", Offset = "0x33600A0", Length = "0x92")]
	[Token(Token = "0x6002DB6")]
	private void OnKeyDown(KeyDownEvent e) { }

	[Address(RVA = "0x3360D40", Offset = "0x3360140", Length = "0x39A")]
	[Token(Token = "0x6002DB7")]
	private void OnPointerDown(PointerDownEvent e) { }

	[Address(RVA = "0x33610E0", Offset = "0x33604E0", Length = "0x14A")]
	[Token(Token = "0x6002DB8")]
	private void OnPointerMove(PointerMoveEvent e) { }

	[Address(RVA = "0x3361230", Offset = "0x3360630", Length = "0x195")]
	[Token(Token = "0x6002DB9")]
	private void OnPointerUp(PointerUpEvent e) { }

	[Address(RVA = "0x33613D0", Offset = "0x33607D0", Length = "0x1FE")]
	[Token(Token = "0x6002DB4")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002DB0")]
	public void set_columnLayout(ColumnLayout value) { }

	[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002DB2")]
	public void set_preview(bool value) { }

	[Address(RVA = "0x33615D0", Offset = "0x33609D0", Length = "0x1FE")]
	[Token(Token = "0x6002DB5")]
	protected virtual void UnregisterCallbacksFromTarget() { }

	[Address(RVA = "0x33617D0", Offset = "0x3360BD0", Length = "0x133")]
	[Token(Token = "0x6002DBC")]
	private void UpdatePreviewPosition() { }

}

