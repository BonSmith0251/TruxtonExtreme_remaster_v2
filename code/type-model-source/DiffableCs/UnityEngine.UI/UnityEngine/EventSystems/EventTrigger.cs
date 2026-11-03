namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Event Trigger")]
[Token(Token = "0x20000B6")]
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
{
	[Token(Token = "0x20000B8")]
	internal class Entry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000311")]
		public EventTriggerType eventID; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000312")]
		public TriggerEvent callback; //Field offset: 0x18

		[Address(RVA = "0x34630F0", Offset = "0x34624F0", Length = "0x8E")]
		[Token(Token = "0x60006CD")]
		public Entry() { }

	}

	[Token(Token = "0x20000B7")]
	internal class TriggerEvent : UnityEvent<BaseEventData>
	{

		[Address(RVA = "0x34752A0", Offset = "0x34746A0", Length = "0x39")]
		[Token(Token = "0x60006CC")]
		public TriggerEvent() { }

	}

	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("delegates")]
	[SerializeField]
	[Token(Token = "0x4000310")]
	private List<Entry> m_Delegates; //Field offset: 0x20

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	[Token(Token = "0x170001D0")]
	public List<Entry> delegates
	{
		[Address(RVA = "0x34655B0", Offset = "0x34649B0", Length = "0x7")]
		[Token(Token = "0x60006B5")]
		 get { } //Length: 7
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60006B6")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001D1")]
	public List<Entry> triggers
	{
		[Address(RVA = "0x34655C0", Offset = "0x34649C0", Length = "0x7A")]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 122
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60006B9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60006B7")]
	protected EventTrigger() { }

	[Address(RVA = "0x3465300", Offset = "0x3464700", Length = "0x197")]
	[Token(Token = "0x60006BA")]
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	[Address(RVA = "0x34655B0", Offset = "0x34649B0", Length = "0x7")]
	[Token(Token = "0x60006B5")]
	public List<Entry> get_delegates() { }

	[Address(RVA = "0x34655C0", Offset = "0x34649C0", Length = "0x7A")]
	[Token(Token = "0x60006B8")]
	public List<Entry> get_triggers() { }

	[Address(RVA = "0x34654A0", Offset = "0x34648A0", Length = "0x10")]
	[Token(Token = "0x60006C8")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x34654B0", Offset = "0x34648B0", Length = "0x10")]
	[Token(Token = "0x60006CB")]
	public override void OnCancel(BaseEventData eventData) { }

	[Address(RVA = "0x34654C0", Offset = "0x34648C0", Length = "0x10")]
	[Token(Token = "0x60006C3")]
	public override void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x34654D0", Offset = "0x34648D0", Length = "0x10")]
	[Token(Token = "0x60006BD")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x34654E0", Offset = "0x34648E0", Length = "0x10")]
	[Token(Token = "0x60006BE")]
	public override void OnDrop(PointerEventData eventData) { }

	[Address(RVA = "0x34654F0", Offset = "0x34648F0", Length = "0x10")]
	[Token(Token = "0x60006C9")]
	public override void OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3465500", Offset = "0x3464900", Length = "0x10")]
	[Token(Token = "0x60006C7")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3465510", Offset = "0x3464910", Length = "0x10")]
	[Token(Token = "0x60006C5")]
	public override void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x3465520", Offset = "0x3464920", Length = "0x10")]
	[Token(Token = "0x60006C1")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x3465530", Offset = "0x3464930", Length = "0x10")]
	[Token(Token = "0x60006BF")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x3465540", Offset = "0x3464940", Length = "0xD")]
	[Token(Token = "0x60006BB")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x3465550", Offset = "0x3464950", Length = "0x10")]
	[Token(Token = "0x60006BC")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x3465560", Offset = "0x3464960", Length = "0x10")]
	[Token(Token = "0x60006C0")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x3465570", Offset = "0x3464970", Length = "0x10")]
	[Token(Token = "0x60006C4")]
	public override void OnScroll(PointerEventData eventData) { }

	[Address(RVA = "0x3465580", Offset = "0x3464980", Length = "0x10")]
	[Token(Token = "0x60006C2")]
	public override void OnSelect(BaseEventData eventData) { }

	[Address(RVA = "0x3465590", Offset = "0x3464990", Length = "0x10")]
	[Token(Token = "0x60006CA")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x34655A0", Offset = "0x34649A0", Length = "0x10")]
	[Token(Token = "0x60006C6")]
	public override void OnUpdateSelected(BaseEventData eventData) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60006B6")]
	public void set_delegates(List<Entry> value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60006B9")]
	public void set_triggers(List<Entry> value) { }

}

