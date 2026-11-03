namespace System.Threading.Tasks;

[FriendAccessAllowed]
[Token(Token = "0x2000290")]
internal static class AsyncCausalityTracer
{

	[FriendAccessAllowed]
	[Token(Token = "0x17000200")]
	internal static bool LoggingOn
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[FriendAccessAllowed]
		[Token(Token = "0x6001522")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[FriendAccessAllowed]
	[Token(Token = "0x6001522")]
	internal static bool get_LoggingOn() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[FriendAccessAllowed]
	[Token(Token = "0x6001524")]
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[FriendAccessAllowed]
	[Token(Token = "0x6001523")]
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001526")]
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001525")]
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

}

