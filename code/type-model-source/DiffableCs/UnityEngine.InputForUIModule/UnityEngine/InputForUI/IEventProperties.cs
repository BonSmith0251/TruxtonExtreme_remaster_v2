namespace UnityEngine.InputForUI;

[Token(Token = "0x200000E")]
internal interface IEventProperties
{

	[Token(Token = "0x17000017")]
	public EventModifiers eventModifiers
	{
		[Token(Token = "0x600002F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000016")]
	public EventSource eventSource
	{
		[Token(Token = "0x600002E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600002F")]
	public EventModifiers get_eventModifiers() { }

	[Token(Token = "0x600002E")]
	public EventSource get_eventSource() { }

}

