namespace System.Threading.Tasks;

[Token(Token = "0x200027F")]
internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
{
	[CompilerGenerated]
	[Token(Token = "0x2000280")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B2D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000B2E")]
		public static Action<Object> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x20C4450", Offset = "0x20C3850", Length = "0x67")]
		[Token(Token = "0x60014D4")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014D5")]
		public <>c() { }

		[Address(RVA = "0x20C3FD0", Offset = "0x20C33D0", Length = "0x7D")]
		[Token(Token = "0x60014D6")]
		internal void <Run>b__2_0(object state) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B2C")]
	private readonly TaskScheduler m_scheduler; //Field offset: 0x20

	[Address(RVA = "0x20B5420", Offset = "0x20B4820", Length = "0x40")]
	[Token(Token = "0x60014D2")]
	internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext) { }

	[Address(RVA = "0x20B7060", Offset = "0x20B6460", Length = "0x398")]
	[Token(Token = "0x60014D3")]
	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

}

