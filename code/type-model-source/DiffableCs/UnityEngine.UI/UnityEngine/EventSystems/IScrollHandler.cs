namespace UnityEngine.EventSystems;

[Token(Token = "0x20000AD")]
public interface IScrollHandler : IEventSystemHandler
{

	[Token(Token = "0x600068C")]
	public void OnScroll(PointerEventData eventData) { }

}

