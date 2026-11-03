namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x200066B")]
internal class ColumnMover : PointerManipulator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001802")]
	private float m_StartPos; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001803")]
	private float m_LastPos; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001804")]
	private bool m_Active; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001805")]
	private bool m_Moving; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4001806")]
	private bool m_Cancelled; //Field offset: 0x32
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001807")]
	private MultiColumnCollectionHeader m_Header; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001808")]
	private VisualElement m_PreviewElement; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001809")]
	private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400180A")]
	private Column m_ColumnToMove; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400180B")]
	private float m_ColumnToMovePos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400180C")]
	private float m_ColumnToMoveWidth; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400180D")]
	private Column m_DestinationColumn; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400180E")]
	private bool m_MoveBeforeDestination; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400180F")]
	private ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001810")]
	private Action<ColumnMover> activeChanged; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001811")]
	private Action<ColumnMover> movingChanged; //Field offset: 0x80

	[Token(Token = "0x14000032")]
	public event Action<ColumnMover> activeChanged
	{
		[Address(RVA = "0x3360850", Offset = "0x335FC50", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6002D97")]
		 add { } //Length: 172
		[Address(RVA = "0x33609C0", Offset = "0x335FDC0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6002D98")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000033")]
	public event Action<ColumnMover> movingChanged
	{
		[Address(RVA = "0x3360900", Offset = "0x335FD00", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6002D99")]
		 add { } //Length: 186
		[Address(RVA = "0x3360A70", Offset = "0x335FE70", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x6002D9A")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x17000B9B")]
	public bool active
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6002D93")]
		 get { } //Length: 5
		[Address(RVA = "0x3360B30", Offset = "0x335FF30", Length = "0x24")]
		[Token(Token = "0x6002D94")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000B9A")]
	public ColumnLayout columnLayout
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D91")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002D92")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B9C")]
	public bool moving
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x6002D95")]
		 get { } //Length: 5
		[Address(RVA = "0x3360B60", Offset = "0x335FF60", Length = "0x27")]
		[Token(Token = "0x6002D96")]
		 set { } //Length: 39
	}

	[Address(RVA = "0x3360760", Offset = "0x335FB60", Length = "0xEF")]
	[Token(Token = "0x6002D9B")]
	public ColumnMover() { }

	[Address(RVA = "0x3360850", Offset = "0x335FC50", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6002D97")]
	public void add_activeChanged(Action<ColumnMover> value) { }

	[Address(RVA = "0x3360900", Offset = "0x335FD00", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6002D99")]
	public void add_movingChanged(Action<ColumnMover> value) { }

	[Address(RVA = "0x335EB50", Offset = "0x335DF50", Length = "0x50B")]
	[Token(Token = "0x6002DA8")]
	private void BeginDragMove(float pos) { }

	[Address(RVA = "0x335F060", Offset = "0x335E460", Length = "0xC")]
	[Token(Token = "0x6002DA9")]
	internal void DragMove(float pos) { }

	[Address(RVA = "0x335F070", Offset = "0x335E470", Length = "0x14D")]
	[Token(Token = "0x6002DAC")]
	private void EndDragMove(bool cancelled) { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6002D93")]
	public bool get_active() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D91")]
	public ColumnLayout get_columnLayout() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x6002D95")]
	public bool get_moving() { }

	[Address(RVA = "0x335F1C0", Offset = "0x335E5C0", Length = "0xD9")]
	[Token(Token = "0x6002DA4")]
	private void OnKeyDown(KeyDownEvent e) { }

	[Address(RVA = "0x335F2A0", Offset = "0x335E6A0", Length = "0x6E")]
	[Token(Token = "0x6002DA1")]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[Address(RVA = "0x335F310", Offset = "0x335E710", Length = "0x59")]
	[Token(Token = "0x6002DA2")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	[Address(RVA = "0x335F370", Offset = "0x335E770", Length = "0x91")]
	[Token(Token = "0x6002D9E")]
	private void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x335F410", Offset = "0x335E810", Length = "0x177")]
	[Token(Token = "0x6002D9F")]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x335F590", Offset = "0x335E990", Length = "0x154")]
	[Token(Token = "0x6002DA0")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x335F6F0", Offset = "0x335EAF0", Length = "0x15A")]
	[Token(Token = "0x6002DA3")]
	protected void ProcessCancelEvent(EventBase evt, int pointerId) { }

	[Address(RVA = "0x335F850", Offset = "0x335EC50", Length = "0x1F3")]
	[Token(Token = "0x6002DA5")]
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x335FA50", Offset = "0x335EE50", Length = "0x137")]
	[Token(Token = "0x6002DA6")]
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	[Address(RVA = "0x335FB90", Offset = "0x335EF90", Length = "0x10A")]
	[Token(Token = "0x6002DA7")]
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x335FCA0", Offset = "0x335F0A0", Length = "0x2E4")]
	[Token(Token = "0x6002D9C")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x33609C0", Offset = "0x335FDC0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6002D98")]
	public void remove_activeChanged(Action<ColumnMover> value) { }

	[Address(RVA = "0x3360A70", Offset = "0x335FE70", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x6002D9A")]
	public void remove_movingChanged(Action<ColumnMover> value) { }

	[Address(RVA = "0x3360B30", Offset = "0x335FF30", Length = "0x24")]
	[Token(Token = "0x6002D94")]
	public void set_active(bool value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002D92")]
	public void set_columnLayout(ColumnLayout value) { }

	[Address(RVA = "0x3360B60", Offset = "0x335FF60", Length = "0x27")]
	[Token(Token = "0x6002D96")]
	public void set_moving(bool value) { }

	[Address(RVA = "0x335FF90", Offset = "0x335F390", Length = "0x2E4")]
	[Token(Token = "0x6002D9D")]
	protected virtual void UnregisterCallbacksFromTarget() { }

	[Address(RVA = "0x3360280", Offset = "0x335F680", Length = "0x1E9")]
	[Token(Token = "0x6002DAB")]
	private void UpdateMoveLocation() { }

	[Address(RVA = "0x3360470", Offset = "0x335F870", Length = "0x2EC")]
	[Token(Token = "0x6002DAA")]
	private void UpdatePreviewPosition() { }

}

