namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000197")]
internal interface IEventMerger
{

	[Token(Token = "0x6001001")]
	public bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

}

