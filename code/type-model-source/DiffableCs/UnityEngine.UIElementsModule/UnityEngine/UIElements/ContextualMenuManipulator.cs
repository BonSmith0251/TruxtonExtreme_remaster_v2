namespace UnityEngine.UIElements;

[Token(Token = "0x2000073")]
public class ContextualMenuManipulator : PointerManipulator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000225")]
	private Action<ContextualMenuPopulateEvent> m_MenuBuilder; //Field offset: 0x28

	[Address(RVA = "0x3222F10", Offset = "0x3222310", Length = "0x1B5")]
	[Token(Token = "0x6000412")]
	public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder) { }

	[Address(RVA = "0x32223D0", Offset = "0x32217D0", Length = "0xFC")]
	[Token(Token = "0x600041D")]
	private void DoDisplayMenu(EventBase evt) { }

	[Address(RVA = "0x32224D0", Offset = "0x32218D0", Length = "0x40")]
	[Token(Token = "0x6000415")]
	protected bool IsOSXContextualMenuPlatform() { }

	[Address(RVA = "0x3078760", Offset = "0x3077B60", Length = "0x19")]
	[Token(Token = "0x600041E")]
	private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) { }

	[Address(RVA = "0x3222510", Offset = "0x3221910", Length = "0x58")]
	[Token(Token = "0x600041C")]
	private void OnKeyUpEvent(KeyUpEvent evt) { }

	[Address(RVA = "0x3222570", Offset = "0x3221970", Length = "0x94")]
	[Token(Token = "0x6000417")]
	private void OnPointerDownEventOSX(IPointerEvent evt) { }

	[Address(RVA = "0x3222710", Offset = "0x3221B10", Length = "0xAF")]
	[Token(Token = "0x6000419")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x3222610", Offset = "0x3221A10", Length = "0xF5")]
	[Token(Token = "0x600041A")]
	private void OnPointerMoveEventOSX(PointerMoveEvent evt) { }

	[Address(RVA = "0x3222570", Offset = "0x3221970", Length = "0x94")]
	[Token(Token = "0x6000416")]
	private void OnPointerUpEvent(IPointerEvent evt) { }

	[Address(RVA = "0x32227C0", Offset = "0x3221BC0", Length = "0xC7")]
	[Token(Token = "0x6000418")]
	private void OnPointerUpEventOSX(IPointerEvent evt) { }

	[Address(RVA = "0x3222570", Offset = "0x3221970", Length = "0x94")]
	[Token(Token = "0x600041B")]
	private void ProcessPointerEvent(IPointerEvent evt) { }

	[Address(RVA = "0x3222890", Offset = "0x3221C90", Length = "0x335")]
	[Token(Token = "0x6000413")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x3222BD0", Offset = "0x3221FD0", Length = "0x335")]
	[Token(Token = "0x6000414")]
	protected virtual void UnregisterCallbacksFromTarget() { }

}

