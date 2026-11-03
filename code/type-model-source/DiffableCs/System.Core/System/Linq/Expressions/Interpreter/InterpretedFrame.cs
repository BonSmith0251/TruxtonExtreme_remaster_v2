namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000162")]
internal sealed class InterpretedFrame
{
	[CompilerGenerated]
	[Token(Token = "0x2000163")]
	private sealed class <GetStackTraceDebugInfo>d__29 : IEnumerable<InterpretedFrameInfo>, IEnumerable, IEnumerator<InterpretedFrameInfo>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002D8")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002D9")]
		private InterpretedFrameInfo <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002DA")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002DB")]
		public InterpretedFrame <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002DC")]
		private InterpretedFrame <frame>5__2; //Field offset: 0x38

		[Token(Token = "0x170001B8")]
		private override InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x60007D2")]
			private get { } //Length: 11
		}

		[Token(Token = "0x170001B9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2290980", Offset = "0x228FD80", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x60007D4")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60007CF")]
		public <GetStackTraceDebugInfo>d__29(int <>1__state) { }

		[Address(RVA = "0x2290690", Offset = "0x228FA90", Length = "0x20A")]
		[Token(Token = "0x60007D1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x22908A0", Offset = "0x228FCA0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60007D5")]
		private override IEnumerator<InterpretedFrameInfo> System.Collections.Generic.IEnumerable<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.GetEnumerator() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x60007D2")]
		private override InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.get_Current() { }

		[Address(RVA = "0x22908A0", Offset = "0x228FCA0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60007D6")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2290980", Offset = "0x228FD80", Length = "0x45")]
		[DebuggerHidden]
		[Token(Token = "0x60007D4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2290940", Offset = "0x228FD40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60007D3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60007D0")]
		private override void System.IDisposable.Dispose() { }

	}

	[ThreadStatic]
	[Token(Token = "0x40002CD")]
	private static InterpretedFrame s_currentFrame; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002CE")]
	internal readonly Interpreter Interpreter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002CF")]
	internal InterpretedFrame _parent; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D0")]
	private readonly Int32[] _continuations; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002D1")]
	private int _continuationIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40002D2")]
	private int _pendingContinuation; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002D3")]
	private object _pendingValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002D4")]
	public readonly Object[] Data; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002D5")]
	public readonly IStrongBox[] Closure; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002D6")]
	public int StackIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40002D7")]
	public int InstructionIndex; //Field offset: 0x4C

	[Token(Token = "0x170001B6")]
	public string Name
	{
		[Address(RVA = "0x227A4B0", Offset = "0x22798B0", Length = "0x1B")]
		[Token(Token = "0x60007B6")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170001B7")]
	public InterpretedFrame Parent
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60007C2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x227A390", Offset = "0x2279790", Length = "0x11F")]
	[Token(Token = "0x60007B4")]
	internal InterpretedFrame(Interpreter interpreter, IStrongBox[] closure) { }

	[Address(RVA = "0x2279250", Offset = "0x2278650", Length = "0x9B")]
	[Token(Token = "0x60007C1")]
	public void Dup() { }

	[Address(RVA = "0x22792F0", Offset = "0x22786F0", Length = "0x7C")]
	[Token(Token = "0x60007C5")]
	internal InterpretedFrame Enter() { }

	[Address(RVA = "0x227A4B0", Offset = "0x22798B0", Length = "0x1B")]
	[Token(Token = "0x60007B6")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60007C2")]
	public InterpretedFrame get_Parent() { }

	[Address(RVA = "0x2279370", Offset = "0x2278770", Length = "0x12B")]
	[Token(Token = "0x60007B5")]
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	[Address(RVA = "0x22794A0", Offset = "0x22788A0", Length = "0x71")]
	[IteratorStateMachine(typeof(<GetStackTraceDebugInfo>d__29))]
	[Token(Token = "0x60007C3")]
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	[Address(RVA = "0x2279520", Offset = "0x2278920", Length = "0x1C3")]
	[Token(Token = "0x60007CE")]
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }

	[Address(RVA = "0x22796F0", Offset = "0x2278AF0", Length = "0x9")]
	[Token(Token = "0x60007C7")]
	internal bool IsJumpHappened() { }

	[Address(RVA = "0x2279700", Offset = "0x2278B00", Length = "0x50")]
	[Token(Token = "0x60007C6")]
	internal void Leave(InterpretedFrame prevFrame) { }

	[Address(RVA = "0x2279750", Offset = "0x2278B50", Length = "0x2E")]
	[Token(Token = "0x60007C0")]
	public object Peek() { }

	[Address(RVA = "0x2279820", Offset = "0x2278C20", Length = "0x36")]
	[Token(Token = "0x60007BE")]
	public object Pop() { }

	[Address(RVA = "0x2279780", Offset = "0x2278B80", Length = "0x94")]
	[Token(Token = "0x60007CD")]
	internal void PopPendingContinuation() { }

	[Address(RVA = "0x2279A30", Offset = "0x2278E30", Length = "0x99")]
	[Token(Token = "0x60007BC")]
	public void Push(short value) { }

	[Address(RVA = "0x2279B70", Offset = "0x2278F70", Length = "0x98")]
	[Token(Token = "0x60007BB")]
	public void Push(sbyte value) { }

	[Address(RVA = "0x22799A0", Offset = "0x2278DA0", Length = "0x82")]
	[Token(Token = "0x60007B7")]
	public void Push(object value) { }

	[Address(RVA = "0x2279AD0", Offset = "0x2278ED0", Length = "0x98")]
	[Token(Token = "0x60007BA")]
	public void Push(byte value) { }

	[Address(RVA = "0x2279DA0", Offset = "0x22791A0", Length = "0x99")]
	[Token(Token = "0x60007BD")]
	public void Push(ushort value) { }

	[Address(RVA = "0x2279CA0", Offset = "0x22790A0", Length = "0xFE")]
	[Token(Token = "0x60007B8")]
	public void Push(bool value) { }

	[Address(RVA = "0x2279C10", Offset = "0x2279010", Length = "0x8F")]
	[Token(Token = "0x60007B9")]
	public void Push(int value) { }

	[Address(RVA = "0x2279860", Offset = "0x2278C60", Length = "0x33")]
	[Token(Token = "0x60007C9")]
	public void PushContinuation(int continuation) { }

	[Address(RVA = "0x22798A0", Offset = "0x2278CA0", Length = "0xFB")]
	[Token(Token = "0x60007CC")]
	internal void PushPendingContinuation() { }

	[Address(RVA = "0x10974A0", Offset = "0x10968A0", Length = "0x4")]
	[Token(Token = "0x60007C8")]
	public void RemoveContinuation() { }

	[Address(RVA = "0x2279E40", Offset = "0x2279240", Length = "0x2BF")]
	[Token(Token = "0x60007C4")]
	internal void SaveTraceToException(Exception exception) { }

	[Address(RVA = "0x227A100", Offset = "0x2279500", Length = "0x1D")]
	[Token(Token = "0x60007BF")]
	internal void SetStackDepth(int depth) { }

	[Address(RVA = "0x227A120", Offset = "0x2279520", Length = "0x79")]
	[Token(Token = "0x60007CA")]
	public int YieldToCurrentContinuation() { }

	[Address(RVA = "0x227A1A0", Offset = "0x22795A0", Length = "0x1EC")]
	[Token(Token = "0x60007CB")]
	public int YieldToPendingContinuation() { }

}

