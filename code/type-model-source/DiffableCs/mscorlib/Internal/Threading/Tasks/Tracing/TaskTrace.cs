namespace Internal.Threading.Tasks.Tracing;

[Token(Token = "0x2000086")]
internal static class TaskTrace
{
	[Token(Token = "0x4000238")]
	private static TaskTraceCallbacks s_callbacks; //Field offset: 0x0

	[Token(Token = "0x17000032")]
	public static bool Enabled
	{
		[Address(RVA = "0x1E8AC60", Offset = "0x1E8A060", Length = "0x5B")]
		[Token(Token = "0x6000229")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x1E8AC60", Offset = "0x1E8A060", Length = "0x5B")]
	[Token(Token = "0x6000229")]
	public static bool get_Enabled() { }

	[Address(RVA = "0x1E8AA40", Offset = "0x1E89E40", Length = "0x92")]
	[Token(Token = "0x600022D")]
	public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }

	[Address(RVA = "0x1E8AAE0", Offset = "0x1E89EE0", Length = "0x79")]
	[Token(Token = "0x600022A")]
	public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	[Address(RVA = "0x1E8AB60", Offset = "0x1E89F60", Length = "0x79")]
	[Token(Token = "0x600022B")]
	public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	[Address(RVA = "0x1E8ABE0", Offset = "0x1E89FE0", Length = "0x79")]
	[Token(Token = "0x600022C")]
	public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

}

