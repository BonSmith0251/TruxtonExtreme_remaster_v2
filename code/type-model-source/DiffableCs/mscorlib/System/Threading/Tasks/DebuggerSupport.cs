namespace System.Threading.Tasks;

[Extension]
[Token(Token = "0x2000260")]
internal static class DebuggerSupport
{
	[Token(Token = "0x4000ABA")]
	private static readonly LowLevelDictionary<Int32, Task> s_activeTasks; //Field offset: 0x0
	[Token(Token = "0x4000ABB")]
	private static readonly object s_activeTasksLock; //Field offset: 0x8

	[Token(Token = "0x170001D4")]
	public static bool LoggingOn
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60013E3")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x20AE2C0", Offset = "0x20AD6C0", Length = "0xD5")]
	[Token(Token = "0x60013ED")]
	private static DebuggerSupport() { }

	[Address(RVA = "0x20AE060", Offset = "0x20AD460", Length = "0x87")]
	[Token(Token = "0x60013E9")]
	public static void AddToActiveTasks(Task task) { }

	[Address(RVA = "0x20ADF10", Offset = "0x20AD310", Length = "0x146")]
	[Token(Token = "0x60013EA")]
	private static void AddToActiveTasksNonInlined(Task task) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60013E3")]
	public static bool get_LoggingOn() { }

	[Address(RVA = "0x20AE230", Offset = "0x20AD630", Length = "0x87")]
	[Token(Token = "0x60013EB")]
	public static void RemoveFromActiveTasks(Task task) { }

	[Address(RVA = "0x20AE0F0", Offset = "0x20AD4F0", Length = "0x13A")]
	[Token(Token = "0x60013EC")]
	private static void RemoveFromActiveTasksNonInlined(Task task) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60013E5")]
	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60013E4")]
	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60013E6")]
	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60013E8")]
	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60013E7")]
	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work) { }

}

