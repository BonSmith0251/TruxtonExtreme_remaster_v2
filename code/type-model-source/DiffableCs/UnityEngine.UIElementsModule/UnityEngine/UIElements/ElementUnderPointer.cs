namespace UnityEngine.UIElements;

[Token(Token = "0x20001C3")]
internal class ElementUnderPointer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000807")]
	private VisualElement[] m_PendingTopElementUnderPointer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000808")]
	private VisualElement[] m_TopElementUnderPointer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000809")]
	private IPointerOrMouseEvent[] m_TriggerEvent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400080A")]
	private Vector2[] m_PickingPointerPositions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400080B")]
	private readonly Boolean[] m_IsPrimaryPointer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400080C")]
	private Boolean[] m_IsPickingPointerTemporaries; //Field offset: 0x38

	[Address(RVA = "0x33C98F0", Offset = "0x33C8CF0", Length = "0x274")]
	[Token(Token = "0x6000CAE")]
	public ElementUnderPointer() { }

	[Address(RVA = "0x33C8CE0", Offset = "0x33C80E0", Length = "0x50D")]
	[Token(Token = "0x6000CB7")]
	internal bool CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) { }

	[Address(RVA = "0x33C91F0", Offset = "0x33C85F0", Length = "0xF4")]
	[Token(Token = "0x6000CB3")]
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	[Address(RVA = "0x33C92F0", Offset = "0x33C86F0", Length = "0x6E")]
	[Token(Token = "0x6000CAF")]
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
	[Token(Token = "0x6000CB0")]
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	[Address(RVA = "0x33C9360", Offset = "0x33C8760", Length = "0xA3")]
	[Token(Token = "0x6000CB1")]
	internal void RemoveElementUnderPointer(VisualElement elementToRemove) { }

	[Address(RVA = "0x33C9750", Offset = "0x33C8B50", Length = "0x171")]
	[Token(Token = "0x6000CB2")]
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) { }

	[Address(RVA = "0x33C9730", Offset = "0x33C8B30", Length = "0x1C")]
	[Token(Token = "0x6000CB5")]
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	[Address(RVA = "0x33C9410", Offset = "0x33C8810", Length = "0x31C")]
	[Token(Token = "0x6000CB6")]
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) { }

	[Address(RVA = "0x33C98D0", Offset = "0x33C8CD0", Length = "0x1C")]
	[Token(Token = "0x6000CB4")]
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

}

