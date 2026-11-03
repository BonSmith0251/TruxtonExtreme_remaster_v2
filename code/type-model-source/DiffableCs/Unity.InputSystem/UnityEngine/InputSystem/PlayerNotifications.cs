namespace UnityEngine.InputSystem;

[Token(Token = "0x20000E0")]
public enum PlayerNotifications : int
{
	SendMessages = 0,
	BroadcastMessages = 1,
	InvokeUnityEvents = 2,
	InvokeCSharpEvents = 3,
}

