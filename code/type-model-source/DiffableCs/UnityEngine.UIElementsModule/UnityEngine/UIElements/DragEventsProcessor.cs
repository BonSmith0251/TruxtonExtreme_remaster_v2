namespace UnityEngine.UIElements;

[Token(Token = "0x200018E")]
internal abstract class DragEventsProcessor
{
	[Token(Token = "0x200018F")]
	public enum DragState : int
	{
		None = 0,
		CanStartDrag = 1,
		Dragging = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000784")]
	private bool m_IsRegistered; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000785")]
	private DragState m_DragState; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000786")]
	private Vector3 m_Start; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000787")]
	private bool m_PendingPerformDrag; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000788")]
	protected readonly VisualElement m_Target; //Field offset: 0x28

	[Token(Token = "0x17000212")]
	protected IDragAndDrop dragAndDrop
	{
		[Address(RVA = "0x33AEFC0", Offset = "0x33AE3C0", Length = "0x27")]
		[Token(Token = "0x6000BC1")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000213")]
	internal override bool isEditorContext
	{
		[Address(RVA = "0x33AEFF0", Offset = "0x33AE3F0", Length = "0xC7")]
		[Token(Token = "0x6000BC2")]
		internal get { } //Length: 199
	}

	[Token(Token = "0x17000210")]
	protected override bool supportsDragEvents
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000BBF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000211")]
	private bool useDragEvents
	{
		[Address(RVA = "0x33AF0C0", Offset = "0x33AE4C0", Length = "0x51")]
		[Token(Token = "0x6000BC0")]
		private get { } //Length: 81
	}

	[Address(RVA = "0x33AEE90", Offset = "0x33AE290", Length = "0x129")]
	[Token(Token = "0x6000BC3")]
	internal DragEventsProcessor(VisualElement target) { }

	[Address(RVA = "0x33ADB80", Offset = "0x33ACF80", Length = "0x105")]
	[Token(Token = "0x6000BD4")]
	private void CancelDragAndDrop(int releaseCapturePointerId = -1) { }

	[Token(Token = "0x6000BC8")]
	protected abstract bool CanStartDrag(Vector3 pointerPosition, EventModifiers modifiers) { }

	[Token(Token = "0x6000BCC")]
	protected abstract void ClearDragAndDropUI(bool dragCancelled) { }

	[Address(RVA = "0x33AEFC0", Offset = "0x33AE3C0", Length = "0x27")]
	[Token(Token = "0x6000BC1")]
	protected IDragAndDrop get_dragAndDrop() { }

	[Address(RVA = "0x33AEFF0", Offset = "0x33AE3F0", Length = "0xC7")]
	[Token(Token = "0x6000BC2")]
	internal override bool get_isEditorContext() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000BBF")]
	protected override bool get_supportsDragEvents() { }

	[Address(RVA = "0x33AF0C0", Offset = "0x33AE4C0", Length = "0x51")]
	[Token(Token = "0x6000BC0")]
	private bool get_useDragEvents() { }

	[Address(RVA = "0x33ADC90", Offset = "0x33AD090", Length = "0x1A4")]
	[Token(Token = "0x6000BD6")]
	private DragEventsProcessor GetDropTarget(Vector2 position) { }

	[Token(Token = "0x6000BCB")]
	protected private abstract void OnDrop(Vector3 pointerPosition, EventModifiers modifiers) { }

	[Address(RVA = "0x33ADE40", Offset = "0x33AD240", Length = "0x73")]
	[Token(Token = "0x6000BD3")]
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x33ADEC0", Offset = "0x33AD2C0", Length = "0x51")]
	[Token(Token = "0x6000BD1")]
	private void OnPointerCancelEvent(PointerCancelEvent evt) { }

	[Address(RVA = "0x33ADF20", Offset = "0x33AD320", Length = "0xD")]
	[Token(Token = "0x6000BD2")]
	private void OnPointerCapturedOut(PointerCaptureOutEvent evt) { }

	[Address(RVA = "0x33ADF30", Offset = "0x33AD330", Length = "0xD3")]
	[Token(Token = "0x6000BCD")]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[Address(RVA = "0x33AE010", Offset = "0x33AD410", Length = "0x16")]
	[Token(Token = "0x6000BD0")]
	private void OnPointerLeaveEvent(PointerLeaveEvent evt) { }

	[Address(RVA = "0x33AE030", Offset = "0x33AD430", Length = "0x351")]
	[Token(Token = "0x6000BD5")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x33AE390", Offset = "0x33AD790", Length = "0xA6")]
	[Token(Token = "0x6000BCE")]
	private void OnPointerOutEvent(PointerOutEvent evt) { }

	[Address(RVA = "0x33AE440", Offset = "0x33AD840", Length = "0x205")]
	[Token(Token = "0x6000BCF")]
	internal void OnPointerUpEvent(PointerUpEvent evt) { }

	[Address(RVA = "0x33AE650", Offset = "0x33ADA50", Length = "0x395")]
	[Token(Token = "0x6000BC5")]
	private void RegisterCallbacksFromTarget() { }

	[Address(RVA = "0x33AE9F0", Offset = "0x33ADDF0", Length = "0x7")]
	[Token(Token = "0x6000BC4")]
	private void RegisterCallbacksFromTarget(AttachToPanelEvent evt) { }

	[Token(Token = "0x6000BC9")]
	protected private abstract StartDragArgs StartDrag(Vector3 pointerPosition, EventModifiers modifiers) { }

	[Address(RVA = "0x33AEE80", Offset = "0x33AE280", Length = "0xA")]
	[Token(Token = "0x6000BC6")]
	private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x33AEA00", Offset = "0x33ADE00", Length = "0x474")]
	[Token(Token = "0x6000BC7")]
	internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false) { }

	[Token(Token = "0x6000BCA")]
	protected private abstract void UpdateDrag(Vector3 pointerPosition, EventModifiers modifiers) { }

}

