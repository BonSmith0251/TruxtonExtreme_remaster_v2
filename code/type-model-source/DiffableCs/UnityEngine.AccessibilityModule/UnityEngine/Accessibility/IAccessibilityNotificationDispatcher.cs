namespace UnityEngine.Accessibility;

[Token(Token = "0x2000014")]
public interface IAccessibilityNotificationDispatcher
{

	[Token(Token = "0x6000084")]
	public void SendLayoutChanged(AccessibilityNode nodeToFocus = null) { }

	[Token(Token = "0x6000083")]
	public void SendScreenChanged(AccessibilityNode nodeToFocus = null) { }

}

