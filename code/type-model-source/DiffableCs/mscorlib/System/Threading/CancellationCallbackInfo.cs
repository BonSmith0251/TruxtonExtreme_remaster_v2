namespace System.Threading;

[Token(Token = "0x200020F")]
internal class CancellationCallbackInfo
{
	[Token(Token = "0x2000210")]
	public sealed class WithSyncContext : CancellationCallbackInfo
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40009C2")]
		internal readonly SynchronizationContext TargetSyncContext; //Field offset: 0x30

		[Address(RVA = "0x16D8D00", Offset = "0x16D8100", Length = "0x8F")]
		[Token(Token = "0x60011FE")]
		internal WithSyncContext(Action<Object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext) { }

	}

	[Token(Token = "0x40009C1")]
	private static ContextCallback s_executionContextCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009BD")]
	internal readonly Action<Object> Callback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009BE")]
	internal readonly object StateForCallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009BF")]
	internal readonly ExecutionContext TargetExecutionContext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009C0")]
	internal readonly CancellationTokenSource CancellationTokenSource; //Field offset: 0x28

	[Address(RVA = "0x16D8BC0", Offset = "0x16D7FC0", Length = "0x7D")]
	[Token(Token = "0x60011FB")]
	internal CancellationCallbackInfo(Action<Object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	[Address(RVA = "0x2093A00", Offset = "0x2092E00", Length = "0x16C")]
	[Token(Token = "0x60011FC")]
	internal void ExecuteCallback() { }

	[Address(RVA = "0x2093B70", Offset = "0x2092F70", Length = "0x7B")]
	[Token(Token = "0x60011FD")]
	private static void ExecutionContextCallback(object obj) { }

}

