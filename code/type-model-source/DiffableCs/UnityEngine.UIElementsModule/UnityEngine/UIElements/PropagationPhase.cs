namespace UnityEngine.UIElements;

[Token(Token = "0x20001D4")]
public enum PropagationPhase : int
{
	None = 0,
	TrickleDown = 1,
	BubbleUp = 3,
	AtTarget = 2,
	DefaultAction = 4,
	DefaultActionAtTarget = 5,
}

