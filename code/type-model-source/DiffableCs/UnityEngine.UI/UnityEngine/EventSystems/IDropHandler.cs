namespace UnityEngine.EventSystems;

[Token(Token = "0x20000AC")]
public interface IDropHandler : IEventSystemHandler
{

	[Token(Token = "0x600068B")]
	public void OnDrop(PointerEventData eventData) { }

}

