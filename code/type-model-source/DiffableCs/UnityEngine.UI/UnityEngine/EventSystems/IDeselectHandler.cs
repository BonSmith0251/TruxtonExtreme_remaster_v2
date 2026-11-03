namespace UnityEngine.EventSystems;

[Token(Token = "0x20000B0")]
public interface IDeselectHandler : IEventSystemHandler
{

	[Token(Token = "0x600068F")]
	public void OnDeselect(BaseEventData eventData) { }

}

