namespace UnityEngine.UIElements;

[Token(Token = "0x20002B8")]
public interface IDebugPanelChangeReceiver
{

	[Token(Token = "0x600128B")]
	public void OnVisualElementChange(VisualElement element, VersionChangeType changeType) { }

}

