namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000004")]
public enum TweenCancelBehaviour : int
{
	Kill = 0,
	KillWithCompleteCallback = 1,
	Complete = 2,
	CompleteWithSequenceCallback = 3,
	CancelAwait = 4,
	KillAndCancelAwait = 5,
	KillWithCompleteCallbackAndCancelAwait = 6,
	CompleteAndCancelAwait = 7,
	CompleteWithSequenceCallbackAndCancelAwait = 8,
}

