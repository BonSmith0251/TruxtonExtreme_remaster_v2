namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000B9")]
internal static class ForEach
{
	[CompilerGenerated]
	[Token(Token = "0x20000BA")]
	private struct <ForEachAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000876")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000877")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000878")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000879")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400087A")]
		public Action<TSource> action; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400087B")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400087C")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400087D")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400087E")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400087F")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16FB780", Offset = "0x16FAB80", Length = "0x8EA")]
		[Token(Token = "0x6000496")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000497")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BB")]
	private struct <ForEachAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000880")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000881")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000882")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000883")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000884")]
		public Action<TSource, Int32> action; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000885")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000886")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000887")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000888")]
		private int <index>5__5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000889")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088A")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16FC070", Offset = "0x16FB470", Length = "0x724")]
		[Token(Token = "0x6000498")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000499")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BC")]
	private struct <ForEachAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088C")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088D")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088E")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088F")]
		public Func<TSource, UniTask> action; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000890")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000891")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000892")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000893")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000894")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16FC7A0", Offset = "0x16FBBA0", Length = "0x7C3")]
		[Token(Token = "0x600049A")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600049B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BD")]
	private struct <ForEachAwaitAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000895")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000896")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000897")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000898")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000899")]
		public Func<TSource, Int32, UniTask> action; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089A")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089B")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089C")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089D")]
		private int <index>5__5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089E")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089F")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16FCF70", Offset = "0x16FC370", Length = "0x80A")]
		[Token(Token = "0x600049C")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600049D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BE")]
	private struct <ForEachAwaitWithCancellationAsync>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A1")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A2")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A3")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A4")]
		public Func<TSource, CancellationToken, UniTask> action; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A5")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A6")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A7")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A8")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008A9")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16FD780", Offset = "0x16FCB80", Length = "0x7E7")]
		[Token(Token = "0x600049E")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600049F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BF")]
	private struct <ForEachAwaitWithCancellationAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008AA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008AB")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008AC")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008AD")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008AE")]
		public Func<TSource, Int32, CancellationToken, UniTask> action; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008AF")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008B0")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008B1")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008B2")]
		private int <index>5__5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008B3")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008B4")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16FDF70", Offset = "0x16FD370", Length = "0x81E")]
		[Token(Token = "0x60004A0")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60004A1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x811BF0", Offset = "0x810FF0", Length = "0x10D")]
	[AsyncStateMachine(typeof(<ForEachAsync>d__0`1))]
	[Token(Token = "0x6000490")]
	public static UniTask ForEachAsync(IUniTaskAsyncEnumerable<TSource> source, Action<TSource> action, CancellationToken cancellationToken) { }

	[Address(RVA = "0x811BF0", Offset = "0x810FF0", Length = "0x10D")]
	[AsyncStateMachine(typeof(<ForEachAsync>d__1`1))]
	[Token(Token = "0x6000491")]
	public static UniTask ForEachAsync(IUniTaskAsyncEnumerable<TSource> source, Action<TSource, Int32> action, CancellationToken cancellationToken) { }

	[Address(RVA = "0x811BF0", Offset = "0x810FF0", Length = "0x10D")]
	[AsyncStateMachine(typeof(<ForEachAwaitAsync>d__2`1))]
	[Token(Token = "0x6000492")]
	public static UniTask ForEachAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> action, CancellationToken cancellationToken) { }

	[Address(RVA = "0x811BF0", Offset = "0x810FF0", Length = "0x10D")]
	[AsyncStateMachine(typeof(<ForEachAwaitAsync>d__3`1))]
	[Token(Token = "0x6000493")]
	public static UniTask ForEachAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask> action, CancellationToken cancellationToken) { }

	[Address(RVA = "0x811BF0", Offset = "0x810FF0", Length = "0x10D")]
	[AsyncStateMachine(typeof(<ForEachAwaitWithCancellationAsync>d__4`1))]
	[Token(Token = "0x6000494")]
	public static UniTask ForEachAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> action, CancellationToken cancellationToken) { }

	[Address(RVA = "0x811BF0", Offset = "0x810FF0", Length = "0x10D")]
	[AsyncStateMachine(typeof(<ForEachAwaitWithCancellationAsync>d__5`1))]
	[Token(Token = "0x6000495")]
	public static UniTask ForEachAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, CancellationToken, UniTask> action, CancellationToken cancellationToken) { }

}

