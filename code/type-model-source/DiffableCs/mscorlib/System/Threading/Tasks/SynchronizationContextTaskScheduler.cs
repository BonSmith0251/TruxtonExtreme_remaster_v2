namespace System.Threading.Tasks;

[Token(Token = "0x2000287")]
internal sealed class SynchronizationContextTaskScheduler : TaskScheduler
{
	[CompilerGenerated]
	[Token(Token = "0x2000288")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B43")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x20C44C0", Offset = "0x20C38C0", Length = "0x67")]
		[Token(Token = "0x6001514")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001515")]
		public <>c() { }

		[Address(RVA = "0x20C4360", Offset = "0x20C3760", Length = "0x75")]
		[Token(Token = "0x6001516")]
		internal void <.cctor>b__8_0(object s) { }

	}

	[Token(Token = "0x4000B42")]
	private static readonly SendOrPostCallback s_postCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B41")]
	private SynchronizationContext m_synchronizationContext; //Field offset: 0x18

	[Address(RVA = "0x20B5590", Offset = "0x20B4990", Length = "0xC8")]
	[Token(Token = "0x6001513")]
	private static SynchronizationContextTaskScheduler() { }

	[Address(RVA = "0x20B5660", Offset = "0x20B4A60", Length = "0xAD")]
	[Token(Token = "0x6001510")]
	internal SynchronizationContextTaskScheduler() { }

	[Address(RVA = "0x20B5460", Offset = "0x20B4860", Length = "0x87")]
	[Token(Token = "0x6001511")]
	protected private virtual void QueueTask(Task task) { }

	[Address(RVA = "0x20B54F0", Offset = "0x20B48F0", Length = "0x9A")]
	[Token(Token = "0x6001512")]
	protected virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

}

