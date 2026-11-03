namespace System.Threading.Tasks;

[Token(Token = "0x2000263")]
public class TaskFactory
{
	[CompilerGenerated]
	[Token(Token = "0x2000265")]
	private sealed class <>c__DisplayClass35_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC5")]
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC6")]
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC7")]
		public Task<TResult> promise; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001415")]
		public <>c__DisplayClass35_0() { }

		[Address(RVA = "0xA72C00", Offset = "0xA72000", Length = "0x93")]
		[Token(Token = "0x6001416")]
		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000266")]
	private sealed class <>c__DisplayClass38_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC8")]
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC9")]
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACA")]
		public Task<TResult> promise; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001417")]
		public <>c__DisplayClass38_0`1() { }

		[Address(RVA = "0xA737E0", Offset = "0xA72BE0", Length = "0x93")]
		[Token(Token = "0x6001418")]
		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000267")]
	private sealed class <>c__DisplayClass41_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACB")]
		public Func<IAsyncResult, TResult> endFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACC")]
		public Action<IAsyncResult> endAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACD")]
		public Task<TResult> promise; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001419")]
		public <>c__DisplayClass41_0`2() { }

		[Address(RVA = "0xA73A80", Offset = "0xA72E80", Length = "0x93")]
		[Token(Token = "0x600141A")]
		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[Token(Token = "0x2000264")]
	private sealed class FromAsyncTrimPromise : Task<TResult>
	{
		[Token(Token = "0x4000AC2")]
		internal static readonly AsyncCallback s_completeFromAsyncResult; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC3")]
		private TInstance m_thisRef; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC4")]
		private Func<TInstance, IAsyncResult, TResult> m_endMethod; //Field offset: 0x0

		[Address(RVA = "0x1C0EFC0", Offset = "0x1C0E3C0", Length = "0xEA")]
		[Token(Token = "0x6001414")]
		private static FromAsyncTrimPromise`1() { }

		[Address(RVA = "0x1C0F2F0", Offset = "0x1C0E6F0", Length = "0x5A")]
		[Token(Token = "0x6001411")]
		internal FromAsyncTrimPromise`1(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }

		[Address(RVA = "0x1C0EDE0", Offset = "0x1C0E1E0", Length = "0xEA")]
		[Token(Token = "0x6001413")]
		internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }

		[Address(RVA = "0x1C0E680", Offset = "0x1C0DA80", Length = "0x214")]
		[Token(Token = "0x6001412")]
		internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ABE")]
	private CancellationToken m_defaultCancellationToken; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ABF")]
	private TaskScheduler m_defaultScheduler; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AC0")]
	private TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AC1")]
	private TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x0

	[Address(RVA = "0xFF01F0", Offset = "0xFEF5F0", Length = "0x55")]
	[Token(Token = "0x6001407")]
	public TaskFactory`1() { }

	[Address(RVA = "0xFF0170", Offset = "0xFEF570", Length = "0x75")]
	[Token(Token = "0x6001408")]
	public TaskFactory`1(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0xFEE360", Offset = "0xFED760", Length = "0x40")]
	[Token(Token = "0x600140B")]
	public Task<TResult> FromAsync(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }

	[Address(RVA = "0x6A5D30", Offset = "0x6A5130", Length = "0x85")]
	[Token(Token = "0x600140D")]
	public Task<TResult> FromAsync(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { }

	[Address(RVA = "0xFE6390", Offset = "0xFE5790", Length = "0x1B0")]
	[Token(Token = "0x600140A")]
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }

	[Address(RVA = "0xFEBA70", Offset = "0xFEAE70", Length = "0x504")]
	[Token(Token = "0x600140C")]
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x6A52A0", Offset = "0x6A46A0", Length = "0x476")]
	[Token(Token = "0x600140E")]
	internal static Task<TResult> FromAsyncImpl(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x6A4990", Offset = "0x6A3D90", Length = "0x485")]
	[Token(Token = "0x600140F")]
	internal static Task<TResult> FromAsyncImpl(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x6A5910", Offset = "0x6A4D10", Length = "0x171")]
	[Token(Token = "0x6001410")]
	internal static Task<TResult> FromAsyncTrim(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, Object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }

	[Address(RVA = "0xFEF530", Offset = "0xFEE930", Length = "0x1E5")]
	[Token(Token = "0x6001409")]
	public Task<TResult> StartNew(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

