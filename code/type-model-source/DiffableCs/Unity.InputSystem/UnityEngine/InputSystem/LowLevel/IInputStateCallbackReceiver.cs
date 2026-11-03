namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001D9")]
public interface IInputStateCallbackReceiver
{

	[Token(Token = "0x60011A0")]
	public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[Token(Token = "0x600119E")]
	public void OnNextUpdate() { }

	[Token(Token = "0x600119F")]
	public void OnStateEvent(InputEventPtr eventPtr) { }

}

