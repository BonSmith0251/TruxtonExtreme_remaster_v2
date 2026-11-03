namespace System.Threading.Tasks;

[Token(Token = "0x2000283")]
public class TaskFactory
{
	[Token(Token = "0x2000284")]
	public sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
	{
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000B3B")]
		private IList<Task> _tasks; //Field offset: 0x58

		[Token(Token = "0x170001F9")]
		public override bool InvokeMayRunArbitraryCode
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001500")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x20ADAC0", Offset = "0x20ACEC0", Length = "0xA1")]
		[Token(Token = "0x60014FE")]
		public CompleteOnInvokePromise(IList<Task> tasks) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001500")]
		public override bool get_InvokeMayRunArbitraryCode() { }

		[Address(RVA = "0x20AD8F0", Offset = "0x20ACCF0", Length = "0x1C0")]
		[Token(Token = "0x60014FF")]
		public override void Invoke(Task completingTask) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B37")]
	private readonly CancellationToken m_defaultCancellationToken; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B38")]
	private readonly TaskScheduler m_defaultScheduler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B39")]
	private readonly TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B3A")]
	private readonly TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x24

	[Address(RVA = "0x20B6E30", Offset = "0x20B6230", Length = "0x43")]
	[Token(Token = "0x60014F0")]
	public TaskFactory() { }

	[Address(RVA = "0x20B6E80", Offset = "0x20B6280", Length = "0x1DC")]
	[Token(Token = "0x60014F1")]
	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x20B6570", Offset = "0x20B5970", Length = "0x63")]
	[Token(Token = "0x60014F2")]
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x20B65E0", Offset = "0x20B59E0", Length = "0x12D")]
	[Token(Token = "0x60014FB")]
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	[Address(RVA = "0x20B6710", Offset = "0x20B5B10", Length = "0x135")]
	[Token(Token = "0x60014FD")]
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0x20B6850", Offset = "0x20B5C50", Length = "0x24E")]
	[Token(Token = "0x60014FC")]
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	[Address(RVA = "0x940850", Offset = "0x93FC50", Length = "0x9A")]
	[Token(Token = "0x60014F7")]
	public Task FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }

	[Address(RVA = "0x9407E0", Offset = "0x93FBE0", Length = "0x68")]
	[Token(Token = "0x60014F8")]
	public Task FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x940730", Offset = "0x93FB30", Length = "0xA5")]
	[Token(Token = "0x60014F9")]
	public Task FromAsync(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }

	[Address(RVA = "0x9406C0", Offset = "0x93FAC0", Length = "0x68")]
	[Token(Token = "0x60014FA")]
	public Task FromAsync(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x20B6C70", Offset = "0x20B6070", Length = "0x1B3")]
	[Token(Token = "0x60014F3")]
	public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x20B6AA0", Offset = "0x20B5EA0", Length = "0x1C6")]
	[Token(Token = "0x60014F4")]
	public Task StartNew(Action<Object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x940B20", Offset = "0x93FF20", Length = "0xA7")]
	[Token(Token = "0x60014F5")]
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x9408F0", Offset = "0x93FCF0", Length = "0xBE")]
	[Token(Token = "0x60014F6")]
	public Task<TResult> StartNew(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

