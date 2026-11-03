namespace System.Runtime.CompilerServices;

[Token(Token = "0x20004A0")]
internal struct AsyncMethodBuilderCore
{
	[CompilerGenerated]
	[Token(Token = "0x20004A4")]
	private sealed class <>c
	{
		[Token(Token = "0x4001281")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001282")]
		public static SendOrPostCallback <>9__7_0; //Field offset: 0x8
		[Token(Token = "0x4001283")]
		public static WaitCallback <>9__7_1; //Field offset: 0x10

		[Address(RVA = "0x1F438D0", Offset = "0x1F42CD0", Length = "0x67")]
		[Token(Token = "0x6002154")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002155")]
		public <>c() { }

		[Address(RVA = "0x1F434E0", Offset = "0x1F428E0", Length = "0x55")]
		[Token(Token = "0x6002156")]
		internal void <ThrowAsync>b__7_0(object state) { }

		[Address(RVA = "0x1F43540", Offset = "0x1F42940", Length = "0x55")]
		[Token(Token = "0x6002157")]
		internal void <ThrowAsync>b__7_1(object state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20004A3")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400127F")]
		public Task innerTask; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001280")]
		public Action continuation; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002152")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x1F43790", Offset = "0x1F42B90", Length = "0x5B")]
		[Token(Token = "0x6002153")]
		internal void <OutputAsyncCausalityEvents>b__0() { }

	}

	[Token(Token = "0x20004A2")]
	private class ContinuationWrapper
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400127C")]
		internal readonly Action m_continuation; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400127D")]
		private readonly Action m_invokeAction; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400127E")]
		internal readonly Task m_innerTask; //Field offset: 0x20

		[Address(RVA = "0x1F33AB0", Offset = "0x1F32EB0", Length = "0xCC")]
		[Token(Token = "0x6002150")]
		internal ContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

		[Address(RVA = "0x1F33A80", Offset = "0x1F32E80", Length = "0x25")]
		[Token(Token = "0x6002151")]
		internal void Invoke() { }

	}

	[Token(Token = "0x20004A1")]
	public sealed class MoveNextRunner
	{
		[Token(Token = "0x400127B")]
		private static ContextCallback s_invokeMoveNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001279")]
		private readonly ExecutionContext m_context; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400127A")]
		internal IAsyncStateMachine m_stateMachine; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x600214D")]
		internal MoveNextRunner(ExecutionContext context, IAsyncStateMachine stateMachine) { }

		[Address(RVA = "0x1F39100", Offset = "0x1F38500", Length = "0x91")]
		[Token(Token = "0x600214F")]
		private static void InvokeMoveNext(object stateMachine) { }

		[Address(RVA = "0x1F391A0", Offset = "0x1F385A0", Length = "0x192")]
		[Token(Token = "0x600214E")]
		internal void Run() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001277")]
	internal IAsyncStateMachine m_stateMachine; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001278")]
	internal Action m_defaultContextAction; //Field offset: 0x8

	[Address(RVA = "0x1F31A20", Offset = "0x1F30E20", Length = "0x137")]
	[Token(Token = "0x600214B")]
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask = null) { }

	[Address(RVA = "0x1F31B60", Offset = "0x1F30F60", Length = "0x219")]
	[Token(Token = "0x6002147")]
	internal Action GetCompletionAction(Task taskForTracing, ref MoveNextRunner runnerToInitialize) { }

	[Address(RVA = "0x1F31D80", Offset = "0x1F31180", Length = "0x1DC")]
	[Token(Token = "0x6002148")]
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	[Address(RVA = "0x1F31F60", Offset = "0x1F31360", Length = "0x1D1")]
	[Token(Token = "0x6002149")]
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, MoveNextRunner runner, Task builtTask) { }

	[Address(RVA = "0x1F32140", Offset = "0x1F31540", Length = "0xC6")]
	[Token(Token = "0x6002146")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x1F32210", Offset = "0x1F31610", Length = "0x2E6")]
	[Token(Token = "0x600214A")]
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	[Address(RVA = "0x1F32500", Offset = "0x1F31900", Length = "0x71")]
	[Token(Token = "0x600214C")]
	internal static Task TryGetContinuationTask(Action action) { }

}

