namespace UnityEngine.EventSystems;

[Token(Token = "0x20000AB")]
public interface IEndDragHandler : IEventSystemHandler
{

	[Token(Token = "0x600068A")]
	public void OnEndDrag(PointerEventData eventData) { }

}

