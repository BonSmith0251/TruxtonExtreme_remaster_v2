namespace UnityEngine.UIElements;

[Token(Token = "0x2000555")]
public interface IVisualElementScheduledItem
{

	[Token(Token = "0x17000A19")]
	public bool isActive
	{
		[Token(Token = "0x60026F0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60026F5")]
	public IVisualElementScheduledItem Every(long intervalMs) { }

	[Token(Token = "0x60026F3")]
	public void ExecuteLater(long delayMs) { }

	[Token(Token = "0x60026F0")]
	public bool get_isActive() { }

	[Token(Token = "0x60026F2")]
	public void Pause() { }

	[Token(Token = "0x60026F1")]
	public void Resume() { }

	[Token(Token = "0x60026F4")]
	public IVisualElementScheduledItem StartingIn(long delayMs) { }

	[Token(Token = "0x60026F6")]
	public IVisualElementScheduledItem Until(Func<Boolean> stopCondition) { }

}

