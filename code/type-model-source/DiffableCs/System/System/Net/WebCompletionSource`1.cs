namespace System.Net;

[Token(Token = "0x20002BA")]
internal class WebCompletionSource
{
	[CompilerGenerated]
	[Token(Token = "0x20002BD")]
	private struct <WaitForCompletion>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B91")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B92")]
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B93")]
		public WebCompletionSource<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B94")]
		private ConfiguredTaskAwaiter<Result<T>> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x1B77E30", Offset = "0x1B77230", Length = "0x3B2")]
		[Token(Token = "0x6001274")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B78660", Offset = "0x1B77A60", Length = "0x98")]
		[DebuggerHidden]
		[Token(Token = "0x6001275")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20002BC")]
	public class Result
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B8E")]
		private readonly Status<T> <Status>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B8F")]
		private readonly ExceptionDispatchInfo <Error>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B90")]
		private readonly T <Argument>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170003FB")]
		public T Argument
		{
			[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
			[CompilerGenerated]
			[Token(Token = "0x6001271")]
			 get { } //Length: 11
		}

		[Token(Token = "0x170003FA")]
		public ExceptionDispatchInfo Error
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001270")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170003F8")]
		public Status<T> Status
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[CompilerGenerated]
			[Token(Token = "0x600126E")]
			 get { } //Length: 85
		}

		[Token(Token = "0x170003F9")]
		public bool Success
		{
			[Address(RVA = "0xF54050", Offset = "0xF53450", Length = "0x8")]
			[Token(Token = "0x600126F")]
			 get { } //Length: 8
		}

		[Address(RVA = "0xF53C60", Offset = "0xF53060", Length = "0x3A")]
		[Token(Token = "0x6001272")]
		public Result(T argument) { }

		[Address(RVA = "0xF53D70", Offset = "0xF53170", Length = "0x40")]
		[Token(Token = "0x6001273")]
		public Result(Status<T> state, ExceptionDispatchInfo error) { }

		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6001271")]
		public T get_Argument() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001270")]
		public ExceptionDispatchInfo get_Error() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600126E")]
		public Status<T> get_Status() { }

		[Address(RVA = "0xF54050", Offset = "0xF53450", Length = "0x8")]
		[Token(Token = "0x600126F")]
		public bool get_Success() { }

	}

	[Token(Token = "0x20002BB")]
	public enum Status : int
	{
		Running = 0,
		Completed = 1,
		Canceled = 2,
		Faulted = 3,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B87")]
	private TaskCompletionSource<Result<T>> completion; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B88")]
	private Result<T> currentResult; //Field offset: 0x0

	[Token(Token = "0x170003F6")]
	internal Result<T> CurrentResult
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001265")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003F7")]
	internal Task Task
	{
		[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
		[Token(Token = "0x6001266")]
		internal get { } //Length: 27
	}

	[Address(RVA = "0x141B1B0", Offset = "0x141A5B0", Length = "0x98")]
	[Token(Token = "0x6001264")]
	public WebCompletionSource`1(bool runAsync = true) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001265")]
	internal Result<T> get_CurrentResult() { }

	[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
	[Token(Token = "0x6001266")]
	internal Task get_Task() { }

	[Address(RVA = "0x141A2B0", Offset = "0x14196B0", Length = "0x78")]
	[Token(Token = "0x600126C")]
	public void ThrowOnError() { }

	[Address(RVA = "0x141A760", Offset = "0x1419B60", Length = "0x107")]
	[Token(Token = "0x6001269")]
	public bool TrySetCanceled() { }

	[Address(RVA = "0x141A500", Offset = "0x1419900", Length = "0xC6")]
	[Token(Token = "0x600126A")]
	public bool TrySetCanceled(OperationCanceledException error) { }

	[Address(RVA = "0x141AC40", Offset = "0x141A040", Length = "0xBF")]
	[Token(Token = "0x6001267")]
	public bool TrySetCompleted(T argument) { }

	[Address(RVA = "0x141A930", Offset = "0x1419D30", Length = "0xB9")]
	[Token(Token = "0x6001268")]
	public bool TrySetCompleted() { }

	[Address(RVA = "0x141ADE0", Offset = "0x141A1E0", Length = "0xC6")]
	[Token(Token = "0x600126B")]
	public bool TrySetException(Exception error) { }

	[Address(RVA = "0x141AFB0", Offset = "0x141A3B0", Length = "0xF6")]
	[AsyncStateMachine(typeof(<WaitForCompletion>d__15))]
	[Token(Token = "0x600126D")]
	public Task<T> WaitForCompletion() { }

}

