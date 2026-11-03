namespace System.Threading.Tasks;

[Token(Token = "0x200028A")]
internal sealed class ThreadPoolTaskScheduler : TaskScheduler
{
	[CompilerGenerated]
	[Token(Token = "0x200028B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B47")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x20C4530", Offset = "0x20C3930", Length = "0x67")]
		[Token(Token = "0x600151F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001520")]
		public <>c() { }

		[Address(RVA = "0x20C4050", Offset = "0x20C3450", Length = "0x75")]
		[Token(Token = "0x6001521")]
		internal void <.cctor>b__10_0(object s) { }

	}

	[Token(Token = "0x4000B46")]
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; //Field offset: 0x0

	[Token(Token = "0x170001FF")]
	internal virtual bool RequiresAtomicStartTransition
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600151D")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x20C0AB0", Offset = "0x20BFEB0", Length = "0xC8")]
	[Token(Token = "0x600151E")]
	private static ThreadPoolTaskScheduler() { }

	[Address(RVA = "0x20C0B80", Offset = "0x20BFF80", Length = "0x49")]
	[Token(Token = "0x6001518")]
	internal ThreadPoolTaskScheduler() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600151D")]
	internal virtual bool get_RequiresAtomicStartTransition() { }

	[Address(RVA = "0x20C0710", Offset = "0x20BFB10", Length = "0x14")]
	[Token(Token = "0x600151C")]
	internal virtual void NotifyWorkItemProgress() { }

	[Address(RVA = "0x20C0730", Offset = "0x20BFB30", Length = "0x290")]
	[Token(Token = "0x6001519")]
	protected private virtual void QueueTask(Task task) { }

	[Address(RVA = "0x20C09D0", Offset = "0x20BFDD0", Length = "0xA")]
	[Token(Token = "0x600151B")]
	protected private virtual bool TryDequeue(Task task) { }

	[Address(RVA = "0x20C09E0", Offset = "0x20BFDE0", Length = "0xC9")]
	[Token(Token = "0x600151A")]
	protected virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

}

