namespace System.Runtime.CompilerServices;

[Token(Token = "0x2000482")]
public interface ICriticalNotifyCompletion : INotifyCompletion
{

	[Token(Token = "0x60020E6")]
	public void UnsafeOnCompleted(Action continuation) { }

}

