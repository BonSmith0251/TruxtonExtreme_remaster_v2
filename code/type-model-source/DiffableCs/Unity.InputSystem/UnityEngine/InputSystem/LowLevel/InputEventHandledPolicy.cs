namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001BC")]
internal enum InputEventHandledPolicy : int
{
	SuppressStateUpdates = 0,
	SuppressActionEventNotifications = 1,
}

