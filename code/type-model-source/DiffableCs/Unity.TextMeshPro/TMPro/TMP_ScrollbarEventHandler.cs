namespace TMPro;

[Token(Token = "0x2000084")]
public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400040A")]
	public bool isSelected; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600044D")]
	public TMP_ScrollbarEventHandler() { }

	[Address(RVA = "0x2F0E950", Offset = "0x2F0DD50", Length = "0x5E")]
	[Token(Token = "0x600044C")]
	public override void OnDeselect(BaseEventData eventData) { }

	[Address(RVA = "0x2F0E9B0", Offset = "0x2F0DDB0", Length = "0x53")]
	[Token(Token = "0x600044A")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x2F0EA10", Offset = "0x2F0DE10", Length = "0x5E")]
	[Token(Token = "0x600044B")]
	public override void OnSelect(BaseEventData eventData) { }

}

