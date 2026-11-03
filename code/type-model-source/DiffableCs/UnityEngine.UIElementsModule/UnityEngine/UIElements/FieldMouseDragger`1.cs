namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x200024E")]
public class FieldMouseDragger : BaseFieldMouseDragger
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008F8")]
	private readonly IValueField<T> m_DrivenField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008F9")]
	private VisualElement m_DragElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008FA")]
	private Rect m_DragHotZone; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008FB")]
	private bool <dragging>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008FC")]
	private T <startValue>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170002E0")]
	public bool dragging
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FD3")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FD4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002E1")]
	public T startValue
	{
		[Address(RVA = "0x1BB5D30", Offset = "0x1BB5130", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000FD5")]
		 get { } //Length: 6
		[Address(RVA = "0x1BB5D40", Offset = "0x1BB5140", Length = "0x9F")]
		[CompilerGenerated]
		[Token(Token = "0x6000FD6")]
		 set { } //Length: 159
	}

	[Address(RVA = "0x1BB5CD0", Offset = "0x1BB50D0", Length = "0x55")]
	[Token(Token = "0x6000FD2")]
	public FieldMouseDragger`1(IValueField<T> drivenField) { }

	[Address(RVA = "0x1BB4BD0", Offset = "0x1BB3FD0", Length = "0x171")]
	[Token(Token = "0x6000FD8")]
	private bool CanStartDrag(int button, Vector2 localPosition) { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FD3")]
	public bool get_dragging() { }

	[Address(RVA = "0x1BB5D30", Offset = "0x1BB5130", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000FD5")]
	public T get_startValue() { }

	[Address(RVA = "0x1BB4D50", Offset = "0x1BB4150", Length = "0x219")]
	[Token(Token = "0x6000FDA")]
	private void ProcessDownEvent(EventBase evt) { }

	[Address(RVA = "0x1BB4F70", Offset = "0x1BB4370", Length = "0x160")]
	[Token(Token = "0x6000FDC")]
	private void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition) { }

	[Address(RVA = "0x1BB50E0", Offset = "0x1BB44E0", Length = "0x1FD")]
	[Token(Token = "0x6000FDE")]
	private void ProcessUpEvent(EventBase evt, int pointerId) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FD4")]
	public void set_dragging(bool value) { }

	[Address(RVA = "0x1BB5D40", Offset = "0x1BB5140", Length = "0x9F")]
	[CompilerGenerated]
	[Token(Token = "0x6000FD6")]
	public void set_startValue(T value) { }

	[Address(RVA = "0x1BB52E0", Offset = "0x1BB46E0", Length = "0x2B9")]
	[Token(Token = "0x6000FD7")]
	public virtual void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	[Address(RVA = "0x1BB55A0", Offset = "0x1BB49A0", Length = "0x226")]
	[Token(Token = "0x6000FDF")]
	private void UpdateValueOnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0x1BB57D0", Offset = "0x1BB4BD0", Length = "0x298")]
	[Token(Token = "0x6000FD9")]
	private void UpdateValueOnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x1BB5A70", Offset = "0x1BB4E70", Length = "0x1DE")]
	[Token(Token = "0x6000FDB")]
	private void UpdateValueOnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x1BB5C50", Offset = "0x1BB5050", Length = "0x71")]
	[Token(Token = "0x6000FDD")]
	private void UpdateValueOnPointerUp(PointerUpEvent evt) { }

}

