namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000198")]
internal interface IEventPreProcessor
{

	[Token(Token = "0x6001002")]
	public bool PreProcessEvent(InputEventPtr currentEventPtr) { }

}

