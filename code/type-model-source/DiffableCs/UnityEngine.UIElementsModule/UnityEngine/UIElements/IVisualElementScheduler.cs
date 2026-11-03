namespace UnityEngine.UIElements;

[Token(Token = "0x2000556")]
public interface IVisualElementScheduler
{

	[Token(Token = "0x60026F7")]
	public IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent) { }

	[Token(Token = "0x60026F8")]
	public IVisualElementScheduledItem Execute(Action updateEvent) { }

}

