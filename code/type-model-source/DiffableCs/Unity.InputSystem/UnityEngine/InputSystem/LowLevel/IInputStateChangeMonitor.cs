namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001DA")]
public interface IInputStateChangeMonitor
{

	[Token(Token = "0x60011A1")]
	public void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) { }

	[Token(Token = "0x60011A2")]
	public void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) { }

}

