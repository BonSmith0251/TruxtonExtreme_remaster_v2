namespace System.Threading;

[Token(Token = "0x2000235")]
internal interface IThreadPoolWorkItem
{

	[Token(Token = "0x60012F6")]
	public void ExecuteWorkItem() { }

	[Token(Token = "0x60012F7")]
	public void MarkAborted(ThreadAbortException tae) { }

}

