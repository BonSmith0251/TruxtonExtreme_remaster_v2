namespace UnityEngine.EventSystems;

[Token(Token = "0x20000BA")]
public static class ExecuteEvents
{
	[Token(Token = "0x20000BB")]
	internal sealed class EventFunction : MulticastDelegate
	{

		[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
		[Token(Token = "0x60006FB")]
		public EventFunction`1(object object, IntPtr method) { }

		[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
		[Token(Token = "0x60006FD")]
		public override IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60006FE")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60006FC")]
		public override void Invoke(T1 handler, BaseEventData eventData) { }

	}

	[Token(Token = "0x4000325")]
	private static readonly EventFunction<IPointerMoveHandler> s_PointerMoveHandler; //Field offset: 0x0
	[Token(Token = "0x4000326")]
	private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler; //Field offset: 0x8
	[Token(Token = "0x4000327")]
	private static readonly EventFunction<IPointerExitHandler> s_PointerExitHandler; //Field offset: 0x10
	[Token(Token = "0x4000328")]
	private static readonly EventFunction<IPointerDownHandler> s_PointerDownHandler; //Field offset: 0x18
	[Token(Token = "0x4000329")]
	private static readonly EventFunction<IPointerUpHandler> s_PointerUpHandler; //Field offset: 0x20
	[Token(Token = "0x400032A")]
	private static readonly EventFunction<IPointerClickHandler> s_PointerClickHandler; //Field offset: 0x28
	[Token(Token = "0x400032B")]
	private static readonly EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; //Field offset: 0x30
	[Token(Token = "0x400032C")]
	private static readonly EventFunction<IBeginDragHandler> s_BeginDragHandler; //Field offset: 0x38
	[Token(Token = "0x400032D")]
	private static readonly EventFunction<IDragHandler> s_DragHandler; //Field offset: 0x40
	[Token(Token = "0x400032E")]
	private static readonly EventFunction<IEndDragHandler> s_EndDragHandler; //Field offset: 0x48
	[Token(Token = "0x400032F")]
	private static readonly EventFunction<IDropHandler> s_DropHandler; //Field offset: 0x50
	[Token(Token = "0x4000330")]
	private static readonly EventFunction<IScrollHandler> s_ScrollHandler; //Field offset: 0x58
	[Token(Token = "0x4000331")]
	private static readonly EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; //Field offset: 0x60
	[Token(Token = "0x4000332")]
	private static readonly EventFunction<ISelectHandler> s_SelectHandler; //Field offset: 0x68
	[Token(Token = "0x4000333")]
	private static readonly EventFunction<IDeselectHandler> s_DeselectHandler; //Field offset: 0x70
	[Token(Token = "0x4000334")]
	private static readonly EventFunction<IMoveHandler> s_MoveHandler; //Field offset: 0x78
	[Token(Token = "0x4000335")]
	private static readonly EventFunction<ISubmitHandler> s_SubmitHandler; //Field offset: 0x80
	[Token(Token = "0x4000336")]
	private static readonly EventFunction<ICancelHandler> s_CancelHandler; //Field offset: 0x88
	[Token(Token = "0x4000337")]
	private static readonly List<Transform> s_InternalTransformList; //Field offset: 0x90

	[Token(Token = "0x170001D9")]
	public static EventFunction<IBeginDragHandler> beginDragHandler
	{
		[Address(RVA = "0x34669E0", Offset = "0x3465DE0", Length = "0x4F")]
		[Token(Token = "0x60006E8")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001E3")]
	public static EventFunction<ICancelHandler> cancelHandler
	{
		[Address(RVA = "0x3466A30", Offset = "0x3465E30", Length = "0x52")]
		[Token(Token = "0x60006F2")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170001E0")]
	public static EventFunction<IDeselectHandler> deselectHandler
	{
		[Address(RVA = "0x3466A90", Offset = "0x3465E90", Length = "0x4F")]
		[Token(Token = "0x60006EF")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DA")]
	public static EventFunction<IDragHandler> dragHandler
	{
		[Address(RVA = "0x3466AE0", Offset = "0x3465EE0", Length = "0x4F")]
		[Token(Token = "0x60006E9")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DC")]
	public static EventFunction<IDropHandler> dropHandler
	{
		[Address(RVA = "0x3466B30", Offset = "0x3465F30", Length = "0x4F")]
		[Token(Token = "0x60006EB")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DB")]
	public static EventFunction<IEndDragHandler> endDragHandler
	{
		[Address(RVA = "0x3466B80", Offset = "0x3465F80", Length = "0x4F")]
		[Token(Token = "0x60006EA")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D8")]
	public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
	{
		[Address(RVA = "0x3466BD0", Offset = "0x3465FD0", Length = "0x4F")]
		[Token(Token = "0x60006E7")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001E1")]
	public static EventFunction<IMoveHandler> moveHandler
	{
		[Address(RVA = "0x3466C20", Offset = "0x3466020", Length = "0x4F")]
		[Token(Token = "0x60006F0")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D7")]
	public static EventFunction<IPointerClickHandler> pointerClickHandler
	{
		[Address(RVA = "0x3466C70", Offset = "0x3466070", Length = "0x4F")]
		[Token(Token = "0x60006E6")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D5")]
	public static EventFunction<IPointerDownHandler> pointerDownHandler
	{
		[Address(RVA = "0x3466CC0", Offset = "0x34660C0", Length = "0x4F")]
		[Token(Token = "0x60006E4")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D3")]
	public static EventFunction<IPointerEnterHandler> pointerEnterHandler
	{
		[Address(RVA = "0x3466D10", Offset = "0x3466110", Length = "0x4F")]
		[Token(Token = "0x60006E2")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D4")]
	public static EventFunction<IPointerExitHandler> pointerExitHandler
	{
		[Address(RVA = "0x3466D60", Offset = "0x3466160", Length = "0x4F")]
		[Token(Token = "0x60006E3")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001D2")]
	public static EventFunction<IPointerMoveHandler> pointerMoveHandler
	{
		[Address(RVA = "0x3466DB0", Offset = "0x34661B0", Length = "0x4E")]
		[Token(Token = "0x60006E1")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170001D6")]
	public static EventFunction<IPointerUpHandler> pointerUpHandler
	{
		[Address(RVA = "0x3466E00", Offset = "0x3466200", Length = "0x4F")]
		[Token(Token = "0x60006E5")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DD")]
	public static EventFunction<IScrollHandler> scrollHandler
	{
		[Address(RVA = "0x3466E50", Offset = "0x3466250", Length = "0x4F")]
		[Token(Token = "0x60006EC")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DF")]
	public static EventFunction<ISelectHandler> selectHandler
	{
		[Address(RVA = "0x3466EA0", Offset = "0x34662A0", Length = "0x4F")]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001E2")]
	public static EventFunction<ISubmitHandler> submitHandler
	{
		[Address(RVA = "0x3466EF0", Offset = "0x34662F0", Length = "0x52")]
		[Token(Token = "0x60006F1")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170001DE")]
	public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler
	{
		[Address(RVA = "0x3466F50", Offset = "0x3466350", Length = "0x4F")]
		[Token(Token = "0x60006ED")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x3466200", Offset = "0x3465600", Length = "0x7DA")]
	[Token(Token = "0x60006FA")]
	private static ExecuteEvents() { }

	[Address(RVA = "0x7EA6C0", Offset = "0x7E9AC0", Length = "0xE3")]
	[Token(Token = "0x60006F8")]
	public static bool CanHandleEvent(GameObject go) { }

	[Address(RVA = "0x7EAEB0", Offset = "0x7EA2B0", Length = "0x37C")]
	[Token(Token = "0x60006F4")]
	public static bool Execute(GameObject target, BaseEventData eventData, EventFunction<T> functor) { }

	[Address(RVA = "0x34657E0", Offset = "0x3464BE0", Length = "0x54")]
	[Token(Token = "0x60006E0")]
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465C00", Offset = "0x3465000", Length = "0x54")]
	[Token(Token = "0x60006DF")]
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465D00", Offset = "0x3465100", Length = "0xEB")]
	[Token(Token = "0x60006DE")]
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465DF0", Offset = "0x34651F0", Length = "0x54")]
	[Token(Token = "0x60006DC")]
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3466030", Offset = "0x3465430", Length = "0x54")]
	[Token(Token = "0x60006DB")]
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x34656A0", Offset = "0x3464AA0", Length = "0x90")]
	[Token(Token = "0x60006DA")]
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465C60", Offset = "0x3465060", Length = "0x90")]
	[Token(Token = "0x60006D9")]
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465640", Offset = "0x3464A40", Length = "0x54")]
	[Token(Token = "0x60006DD")]
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465E50", Offset = "0x3465250", Length = "0x90")]
	[Token(Token = "0x60006D7")]
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465A20", Offset = "0x3464E20", Length = "0x90")]
	[Token(Token = "0x60006D6")]
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465EF0", Offset = "0x34652F0", Length = "0x90")]
	[Token(Token = "0x60006D5")]
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465AC0", Offset = "0x3464EC0", Length = "0x90")]
	[Token(Token = "0x60006D4")]
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465840", Offset = "0x3464C40", Length = "0x90")]
	[Token(Token = "0x60006CF")]
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465F90", Offset = "0x3465390", Length = "0x90")]
	[Token(Token = "0x60006D3")]
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x34658E0", Offset = "0x3464CE0", Length = "0x90")]
	[Token(Token = "0x60006D2")]
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465980", Offset = "0x3464D80", Length = "0x90")]
	[Token(Token = "0x60006D1")]
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465B60", Offset = "0x3464F60", Length = "0x90")]
	[Token(Token = "0x60006D0")]
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x3465740", Offset = "0x3464B40", Length = "0x90")]
	[Token(Token = "0x60006D8")]
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	[Address(RVA = "0x7EA920", Offset = "0x7E9D20", Length = "0x161")]
	[Token(Token = "0x60006F5")]
	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction) { }

	[Address(RVA = "0x34669E0", Offset = "0x3465DE0", Length = "0x4F")]
	[Token(Token = "0x60006E8")]
	public static EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	[Address(RVA = "0x3466A30", Offset = "0x3465E30", Length = "0x52")]
	[Token(Token = "0x60006F2")]
	public static EventFunction<ICancelHandler> get_cancelHandler() { }

	[Address(RVA = "0x3466A90", Offset = "0x3465E90", Length = "0x4F")]
	[Token(Token = "0x60006EF")]
	public static EventFunction<IDeselectHandler> get_deselectHandler() { }

	[Address(RVA = "0x3466AE0", Offset = "0x3465EE0", Length = "0x4F")]
	[Token(Token = "0x60006E9")]
	public static EventFunction<IDragHandler> get_dragHandler() { }

	[Address(RVA = "0x3466B30", Offset = "0x3465F30", Length = "0x4F")]
	[Token(Token = "0x60006EB")]
	public static EventFunction<IDropHandler> get_dropHandler() { }

	[Address(RVA = "0x3466B80", Offset = "0x3465F80", Length = "0x4F")]
	[Token(Token = "0x60006EA")]
	public static EventFunction<IEndDragHandler> get_endDragHandler() { }

	[Address(RVA = "0x3466BD0", Offset = "0x3465FD0", Length = "0x4F")]
	[Token(Token = "0x60006E7")]
	public static EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	[Address(RVA = "0x3466C20", Offset = "0x3466020", Length = "0x4F")]
	[Token(Token = "0x60006F0")]
	public static EventFunction<IMoveHandler> get_moveHandler() { }

	[Address(RVA = "0x3466C70", Offset = "0x3466070", Length = "0x4F")]
	[Token(Token = "0x60006E6")]
	public static EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	[Address(RVA = "0x3466CC0", Offset = "0x34660C0", Length = "0x4F")]
	[Token(Token = "0x60006E4")]
	public static EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	[Address(RVA = "0x3466D10", Offset = "0x3466110", Length = "0x4F")]
	[Token(Token = "0x60006E2")]
	public static EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	[Address(RVA = "0x3466D60", Offset = "0x3466160", Length = "0x4F")]
	[Token(Token = "0x60006E3")]
	public static EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	[Address(RVA = "0x3466DB0", Offset = "0x34661B0", Length = "0x4E")]
	[Token(Token = "0x60006E1")]
	public static EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	[Address(RVA = "0x3466E00", Offset = "0x3466200", Length = "0x4F")]
	[Token(Token = "0x60006E5")]
	public static EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	[Address(RVA = "0x3466E50", Offset = "0x3466250", Length = "0x4F")]
	[Token(Token = "0x60006EC")]
	public static EventFunction<IScrollHandler> get_scrollHandler() { }

	[Address(RVA = "0x3466EA0", Offset = "0x34662A0", Length = "0x4F")]
	[Token(Token = "0x60006EE")]
	public static EventFunction<ISelectHandler> get_selectHandler() { }

	[Address(RVA = "0x3466EF0", Offset = "0x34662F0", Length = "0x52")]
	[Token(Token = "0x60006F1")]
	public static EventFunction<ISubmitHandler> get_submitHandler() { }

	[Address(RVA = "0x3466F50", Offset = "0x3466350", Length = "0x4F")]
	[Token(Token = "0x60006ED")]
	public static EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	[Address(RVA = "0x3466090", Offset = "0x3465490", Length = "0x16D")]
	[Token(Token = "0x60006F3")]
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	[Address(RVA = "0x7EB360", Offset = "0x7EA760", Length = "0x1DC")]
	[Token(Token = "0x60006F9")]
	public static GameObject GetEventHandler(GameObject root) { }

	[Address(RVA = "0x7EB7A0", Offset = "0x7EABA0", Length = "0x344")]
	[Token(Token = "0x60006F7")]
	private static void GetEventList(GameObject go, IList<IEventSystemHandler> results) { }

	[Address(RVA = "0x7EBAF0", Offset = "0x7EAEF0", Length = "0x105")]
	[Token(Token = "0x60006F6")]
	private static bool ShouldSendToComponent(Component component) { }

	[Address(RVA = "0x7EBC00", Offset = "0x7EB000", Length = "0x10D")]
	[Token(Token = "0x60006CE")]
	public static T ValidateEventData(BaseEventData data) { }

}

