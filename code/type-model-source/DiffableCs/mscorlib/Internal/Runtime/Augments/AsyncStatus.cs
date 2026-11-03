namespace Internal.Runtime.Augments;

[Token(Token = "0x2000087")]
internal enum AsyncStatus : int
{
	Started = 0,
	Completed = 1,
	Canceled = 2,
	Error = 3,
}

