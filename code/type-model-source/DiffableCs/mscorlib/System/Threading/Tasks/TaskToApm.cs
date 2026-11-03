namespace System.Threading.Tasks;

[Token(Token = "0x2000255")]
internal static class TaskToApm
{
	[CompilerGenerated]
	[Token(Token = "0x2000257")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AA6")]
		public AsyncCallback callback; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AA7")]
		public IAsyncResult asyncResult; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60013B3")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x209F490", Offset = "0x209E890", Length = "0x2C")]
		[Token(Token = "0x60013B4")]
		internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

	}

	[Token(Token = "0x2000256")]
	private sealed class TaskWrapperAsyncResult : IAsyncResult
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AA3")]
		internal readonly Task Task; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AA4")]
		private readonly object _state; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AA5")]
		private readonly bool _completedSynchronously; //Field offset: 0x20

		[Token(Token = "0x170001CA")]
		private override object System.IAsyncResult.AsyncState
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60013AF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001CD")]
		private override WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			[Address(RVA = "0x20B82A0", Offset = "0x20B76A0", Length = "0xBC")]
			[Token(Token = "0x60013B2")]
			private get { } //Length: 188
		}

		[Token(Token = "0x170001CB")]
		private override bool System.IAsyncResult.CompletedSynchronously
		{
			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[Token(Token = "0x60013B0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001CC")]
		private override bool System.IAsyncResult.IsCompleted
		{
			[Address(RVA = "0x20B8360", Offset = "0x20B7760", Length = "0x5C")]
			[Token(Token = "0x60013B1")]
			private get { } //Length: 92
		}

		[Address(RVA = "0x1F29340", Offset = "0x1F28740", Length = "0x61")]
		[Token(Token = "0x60013AE")]
		internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60013AF")]
		private override object System.IAsyncResult.get_AsyncState() { }

		[Address(RVA = "0x20B82A0", Offset = "0x20B76A0", Length = "0xBC")]
		[Token(Token = "0x60013B2")]
		private override WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60013B0")]
		private override bool System.IAsyncResult.get_CompletedSynchronously() { }

		[Address(RVA = "0x20B8360", Offset = "0x20B7760", Length = "0x5C")]
		[Token(Token = "0x60013B1")]
		private override bool System.IAsyncResult.get_IsCompleted() { }

	}


	[Address(RVA = "0x20B7E50", Offset = "0x20B7250", Length = "0x229")]
	[Token(Token = "0x60013AA")]
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	[Address(RVA = "0x20B8080", Offset = "0x20B7480", Length = "0xF9")]
	[Token(Token = "0x60013AB")]
	public static void End(IAsyncResult asyncResult) { }

	[Address(RVA = "0x940E10", Offset = "0x940210", Length = "0x115")]
	[Token(Token = "0x60013AC")]
	public static TResult End(IAsyncResult asyncResult) { }

	[Address(RVA = "0x20B8180", Offset = "0x20B7580", Length = "0x114")]
	[Token(Token = "0x60013AD")]
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

