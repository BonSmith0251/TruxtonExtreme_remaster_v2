namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000494")]
public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	[CompilerGenerated]
	[Token(Token = "0x2000495")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001263")]
		public Task task; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001264")]
		public Action continuation; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002113")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x1F43610", Offset = "0x1F42A10", Length = "0x17A")]
		[Token(Token = "0x6002114")]
		internal void <OutputWaitEtwEvents>b__0() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001262")]
	internal readonly Task m_task; //Field offset: 0x0

	[Token(Token = "0x17000409")]
	public bool IsCompleted
	{
		[Address(RVA = "0xFE3740", Offset = "0xFE2B40", Length = "0x1C")]
		[Token(Token = "0x600210A")]
		 get { } //Length: 28
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6002109")]
	internal TaskAwaiter(Task task) { }

	[Address(RVA = "0xFE3740", Offset = "0xFE2B40", Length = "0x1C")]
	[Token(Token = "0x600210A")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x1F33130", Offset = "0x1F32530", Length = "0x48")]
	[StackTraceHidden]
	[Token(Token = "0x600210D")]
	public void GetResult() { }

	[Address(RVA = "0x1F42B60", Offset = "0x1F41F60", Length = "0x186")]
	[StackTraceHidden]
	[Token(Token = "0x600210F")]
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	[Address(RVA = "0x1F42DC0", Offset = "0x1F421C0", Length = "0xAA")]
	[Token(Token = "0x600210B")]
	public override void OnCompleted(Action continuation) { }

	[Address(RVA = "0x1F42CF0", Offset = "0x1F420F0", Length = "0xC6")]
	[Token(Token = "0x6002111")]
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	[Address(RVA = "0x1F42E70", Offset = "0x1F42270", Length = "0x1E3")]
	[Token(Token = "0x6002112")]
	private static Action OutputWaitEtwEvents(Task task, Action continuation) { }

	[Address(RVA = "0x1F43060", Offset = "0x1F42460", Length = "0x152")]
	[StackTraceHidden]
	[Token(Token = "0x6002110")]
	private static void ThrowForNonSuccess(Task task) { }

	[Address(RVA = "0x1F431C0", Offset = "0x1F425C0", Length = "0xA9")]
	[Token(Token = "0x600210C")]
	public override void UnsafeOnCompleted(Action continuation) { }

	[Address(RVA = "0x1F43270", Offset = "0x1F42670", Length = "0x48")]
	[StackTraceHidden]
	[Token(Token = "0x600210E")]
	internal static void ValidateEnd(Task task) { }

}

