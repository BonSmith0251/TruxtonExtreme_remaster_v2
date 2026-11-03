namespace System.Threading.Tasks;

[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView`1))]
[Token(Token = "0x2000261")]
public class Task : Task
{
	[Token(Token = "0x4000ABD")]
	private static TaskFactory<TResult> s_defaultFactory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ABC")]
	internal TResult m_result; //Field offset: 0x0

	[Token(Token = "0x170001D7")]
	public static TaskFactory<TResult> Factory
	{
		[Address(RVA = "0xFF91E0", Offset = "0xFF85E0", Length = "0x184")]
		[Token(Token = "0x60013FD")]
		 get { } //Length: 388
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x170001D5")]
	public TResult Result
	{
		[Address(RVA = "0xFF93C0", Offset = "0xFF87C0", Length = "0xA3")]
		[Token(Token = "0x60013FA")]
		 get { } //Length: 163
	}

	[Token(Token = "0x170001D6")]
	internal TResult ResultOnSuccess
	{
		[Address(RVA = "0xFF9370", Offset = "0xFF8770", Length = "0x15")]
		[Token(Token = "0x60013FB")]
		internal get { } //Length: 21
	}

	[Address(RVA = "0xFF7C30", Offset = "0xFF7030", Length = "0x49")]
	[Token(Token = "0x60013EE")]
	internal Task`1() { }

	[Address(RVA = "0xFF8180", Offset = "0xFF7580", Length = "0x73")]
	[Token(Token = "0x60013EF")]
	internal Task`1(object state, TaskCreationOptions options) { }

	[Address(RVA = "0xFF8840", Offset = "0xFF7C40", Length = "0x80")]
	[Token(Token = "0x60013F0")]
	internal Task`1(TResult result) { }

	[Address(RVA = "0xFF8B90", Offset = "0xFF7F90", Length = "0xA4")]
	[Token(Token = "0x60013F1")]
	internal Task`1(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }

	[Address(RVA = "0xFF7590", Offset = "0xFF6990", Length = "0x37")]
	[Token(Token = "0x60013F2")]
	public Task`1(Func<TResult> function, CancellationToken cancellationToken) { }

	[Address(RVA = "0xFF75D0", Offset = "0xFF69D0", Length = "0xDF")]
	[Token(Token = "0x60013F3")]
	public Task`1(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0xFF76B0", Offset = "0xFF6AB0", Length = "0xA8")]
	[Token(Token = "0x60013F4")]
	internal Task`1(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0xFF7500", Offset = "0xFF6900", Length = "0x82")]
	[Token(Token = "0x60013F5")]
	internal Task`1(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0xFF0730", Offset = "0xFEFB30", Length = "0x2F")]
	[Token(Token = "0x6001400")]
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }

	[Address(RVA = "0xFF3830", Offset = "0xFF2C30", Length = "0x1FD")]
	[Token(Token = "0x6001404")]
	internal Task ContinueWith(Action<Task`1<TResult>, Object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0xFF3640", Offset = "0xFF2A40", Length = "0x1E5")]
	[Token(Token = "0x6001403")]
	public Task ContinueWith(Action<Task`1<TResult>, Object> continuationAction, object state, TaskScheduler scheduler) { }

	[Address(RVA = "0xFF3C30", Offset = "0xFF3030", Length = "0x1F4")]
	[Token(Token = "0x6001402")]
	internal Task ContinueWith(Action<Task`1<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0xFF3280", Offset = "0xFF2680", Length = "0x1D4")]
	[Token(Token = "0x6001401")]
	public Task ContinueWith(Action<Task`1<TResult>> continuationAction, TaskScheduler scheduler) { }

	[Address(RVA = "0x6A6650", Offset = "0x6A5A50", Length = "0x1DF")]
	[Token(Token = "0x6001406")]
	internal Task<TNewResult> ContinueWith(Func<Task`1<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0x6A6230", Offset = "0x6A5630", Length = "0x208")]
	[Token(Token = "0x6001405")]
	public Task<TNewResult> ContinueWith(Func<Task`1<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0xFF45E0", Offset = "0xFF39E0", Length = "0xDF")]
	[Token(Token = "0x60013F9")]
	internal void DangerousSetResult(TResult result) { }

	[Address(RVA = "0xFF91E0", Offset = "0xFF85E0", Length = "0x184")]
	[Token(Token = "0x60013FD")]
	public static TaskFactory<TResult> get_Factory() { }

	[Address(RVA = "0xFF93C0", Offset = "0xFF87C0", Length = "0xA3")]
	[Token(Token = "0x60013FA")]
	public TResult get_Result() { }

	[Address(RVA = "0xFF9370", Offset = "0xFF8770", Length = "0x15")]
	[Token(Token = "0x60013FB")]
	internal TResult get_ResultOnSuccess() { }

	[Address(RVA = "0xFF49E0", Offset = "0xFF3DE0", Length = "0x25")]
	[Token(Token = "0x60013FF")]
	public TaskAwaiter<TResult> GetAwaiter() { }

	[Address(RVA = "0xFF4BA0", Offset = "0xFF3FA0", Length = "0x92")]
	[Token(Token = "0x60013FC")]
	internal TResult GetResultCore(bool waitCompletionNotification) { }

	[Address(RVA = "0xFF4D10", Offset = "0xFF4110", Length = "0xD9")]
	[Token(Token = "0x60013FE")]
	internal virtual void InnerInvoke() { }

	[Address(RVA = "0xFF6840", Offset = "0xFF5C40", Length = "0x1A4")]
	[Token(Token = "0x60013F7")]
	internal static Task<TResult> StartNew(Task parent, Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0xFF66A0", Offset = "0xFF5AA0", Length = "0x194")]
	[Token(Token = "0x60013F6")]
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0xFF6DA0", Offset = "0xFF61A0", Length = "0xBE")]
	[Token(Token = "0x60013F8")]
	internal bool TrySetResult(TResult result) { }

}

