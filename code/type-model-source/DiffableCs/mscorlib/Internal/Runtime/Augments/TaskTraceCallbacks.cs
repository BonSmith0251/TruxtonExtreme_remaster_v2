namespace Internal.Runtime.Augments;

[Token(Token = "0x2000088")]
internal abstract class TaskTraceCallbacks
{

	[Token(Token = "0x17000033")]
	public abstract bool Enabled
	{
		[Token(Token = "0x600022E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600022E")]
	public abstract bool get_Enabled() { }

	[Token(Token = "0x6000232")]
	public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }

	[Token(Token = "0x600022F")]
	public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	[Token(Token = "0x6000230")]
	public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	[Token(Token = "0x6000231")]
	public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

}

