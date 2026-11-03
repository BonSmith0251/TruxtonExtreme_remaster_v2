namespace System.Threading;

[Token(Token = "0x200023F")]
internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
{
	[Token(Token = "0x4000A4A")]
	internal static ContextCallback ccb; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A47")]
	private WaitCallback callback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A48")]
	private ExecutionContext context; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A49")]
	private object state; //Field offset: 0x20

	[Address(RVA = "0x20B3090", Offset = "0x20B2490", Length = "0x89")]
	[Token(Token = "0x600131E")]
	private static QueueUserWorkItemCallback() { }

	[Address(RVA = "0x20B3120", Offset = "0x20B2520", Length = "0xD8")]
	[Token(Token = "0x600131A")]
	internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x20B2F20", Offset = "0x20B2320", Length = "0xEC")]
	[Token(Token = "0x600131B")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600131C")]
	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	[Address(RVA = "0x20B3010", Offset = "0x20B2410", Length = "0x71")]
	[Token(Token = "0x600131D")]
	private static void WaitCallback_Context(object state) { }

}

