namespace System.Threading.Tasks;

[Token(Token = "0x200027D")]
internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
{
	[CompilerGenerated]
	[Token(Token = "0x200027E")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B2B")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x20C43E0", Offset = "0x20C37E0", Length = "0x67")]
		[Token(Token = "0x60014CF")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014D0")]
		public <>c() { }

		[Address(RVA = "0x20C42F0", Offset = "0x20C36F0", Length = "0x6A")]
		[Token(Token = "0x60014D1")]
		internal void <.cctor>b__7_0(object state) { }

	}

	[Token(Token = "0x4000B28")]
	private static readonly SendOrPostCallback s_postCallback; //Field offset: 0x0
	[Token(Token = "0x4000B29")]
	private static ContextCallback s_postActionCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B2A")]
	private readonly SynchronizationContext m_syncContext; //Field offset: 0x20

	[Address(RVA = "0x20B5350", Offset = "0x20B4750", Length = "0xC8")]
	[Token(Token = "0x60014CE")]
	private static SynchronizationContextAwaitTaskContinuation() { }

	[Address(RVA = "0x20B5420", Offset = "0x20B4820", Length = "0x40")]
	[Token(Token = "0x60014CA")]
	internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	[Address(RVA = "0x20B5010", Offset = "0x20B4410", Length = "0xE0")]
	[Token(Token = "0x60014CD")]
	private static ContextCallback GetPostActionCallback() { }

	[Address(RVA = "0x20B50F0", Offset = "0x20B44F0", Length = "0xA2")]
	[Token(Token = "0x60014CC")]
	private static void PostAction(object state) { }

	[Address(RVA = "0x20B51A0", Offset = "0x20B45A0", Length = "0x1AF")]
	[Token(Token = "0x60014CB")]
	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

}

