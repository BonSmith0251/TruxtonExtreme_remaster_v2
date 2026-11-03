namespace System;

[Token(Token = "0x20000F0")]
public interface IAsyncResult
{

	[Token(Token = "0x17000085")]
	public object AsyncState
	{
		[Token(Token = "0x6000795")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000084")]
	public WaitHandle AsyncWaitHandle
	{
		[Token(Token = "0x6000794")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000086")]
	public bool CompletedSynchronously
	{
		[Token(Token = "0x6000796")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000083")]
	public bool IsCompleted
	{
		[Token(Token = "0x6000793")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000795")]
	public object get_AsyncState() { }

	[Token(Token = "0x6000794")]
	public WaitHandle get_AsyncWaitHandle() { }

	[Token(Token = "0x6000796")]
	public bool get_CompletedSynchronously() { }

	[Token(Token = "0x6000793")]
	public bool get_IsCompleted() { }

}

