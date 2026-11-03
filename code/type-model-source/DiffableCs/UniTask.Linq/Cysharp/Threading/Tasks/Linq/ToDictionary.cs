namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001EB")]
internal static class ToDictionary
{
	[CompilerGenerated]
	[Token(Token = "0x20001EC")]
	private struct <ToDictionaryAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400126D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400126E")]
		public AsyncUniTaskMethodBuilder<Dictionary`2<TKey, TSource>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400126F")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001270")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001271")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001272")]
		public Func<TSource, TKey> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001273")]
		private Dictionary<TKey, TSource> <dict>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001274")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001275")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001276")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001277")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001278")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B60590", Offset = "0x1B5F990", Length = "0xCD4")]
		[Token(Token = "0x6000884")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B61270", Offset = "0x1B60670", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x6000885")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001ED")]
	private struct <ToDictionaryAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001279")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400127A")]
		public AsyncUniTaskMethodBuilder<Dictionary`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400127B")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400127C")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400127D")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400127E")]
		public Func<TSource, TKey> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400127F")]
		public Func<TSource, TElement> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001280")]
		private Dictionary<TKey, TElement> <dict>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001281")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001282")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001283")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001284")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001285")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B61300", Offset = "0x1B60700", Length = "0xE49")]
		[Token(Token = "0x6000886")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B60500", Offset = "0x1B5F900", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x6000887")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001EE")]
	private struct <ToDictionaryAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001286")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001287")]
		public AsyncUniTaskMethodBuilder<Dictionary`2<TKey, TSource>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001288")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001289")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400128A")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400128B")]
		public Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400128C")]
		private Dictionary<TKey, TSource> <dict>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400128D")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400128E")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400128F")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001290")]
		private TSource <v>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001291")]
		private Awaiter<TKey> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001292")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001293")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1B62150", Offset = "0x1B61550", Length = "0x182F")]
		[Token(Token = "0x6000888")]
		private override void MoveNext() { }

		[Address(RVA = "0x1821E20", Offset = "0x1821220", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000889")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001EF")]
	private struct <ToDictionaryAwaitAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001294")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A2")]
		private Awaiter<TElement> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A1")]
		private Awaiter<TKey> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A0")]
		private TKey <key>5__7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400129F")]
		private TSource <v>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400129E")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400129D")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A3")]
		private Awaiter<Boolean> <>u__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400129C")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400129A")]
		public Func<TSource, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001299")]
		public Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001298")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001297")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001296")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001295")]
		public AsyncUniTaskMethodBuilder<Dictionary`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400129B")]
		private Dictionary<TKey, TElement> <dict>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A4")]
		private Awaiter <>u__4; //Field offset: 0x0

		[Address(RVA = "0x1B63990", Offset = "0x1B62D90", Length = "0x1F51")]
		[Token(Token = "0x600088A")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B658F0", Offset = "0x1B64CF0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600088B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001F0")]
	private struct <ToDictionaryAwaitWithCancellationAsync>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A6")]
		public AsyncUniTaskMethodBuilder<Dictionary`2<TKey, TSource>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A7")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A8")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012A9")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012AA")]
		public Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012AB")]
		private Dictionary<TKey, TSource> <dict>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012AC")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012AD")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012AE")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012AF")]
		private TSource <v>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B0")]
		private Awaiter<TKey> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B1")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B2")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1B659C0", Offset = "0x1B64DC0", Length = "0x1873")]
		[Token(Token = "0x600088C")]
		private override void MoveNext() { }

		[Address(RVA = "0x1821E20", Offset = "0x1821220", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600088D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001F1")]
	private struct <ToDictionaryAwaitWithCancellationAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C1")]
		private Awaiter<TElement> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C0")]
		private Awaiter<TKey> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012BF")]
		private TKey <key>5__7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012BE")]
		private TSource <v>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012BD")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012BC")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C2")]
		private Awaiter<Boolean> <>u__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012BB")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B9")]
		public Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B8")]
		public Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B7")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B6")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B5")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012B4")]
		public AsyncUniTaskMethodBuilder<Dictionary`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012BA")]
		private Dictionary<TKey, TElement> <dict>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012C3")]
		private Awaiter <>u__4; //Field offset: 0x0

		[Address(RVA = "0x1B67240", Offset = "0x1B66640", Length = "0x1FE5")]
		[Token(Token = "0x600088E")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B658F0", Offset = "0x1B64CF0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600088F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x945660", Offset = "0x944A60", Length = "0x14F")]
	[AsyncStateMachine(typeof(<ToDictionaryAsync>d__0`2))]
	[Token(Token = "0x600087E")]
	internal static UniTask<Dictionary`2<TKey, TSource>> ToDictionaryAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x9454F0", Offset = "0x9448F0", Length = "0x16A")]
	[AsyncStateMachine(typeof(<ToDictionaryAsync>d__1`3))]
	[Token(Token = "0x600087F")]
	internal static UniTask<Dictionary`2<TKey, TElement>> ToDictionaryAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x945AC0", Offset = "0x944EC0", Length = "0x2BD")]
	[AsyncStateMachine(typeof(<ToDictionaryAwaitAsync>d__2`2))]
	[Token(Token = "0x6000880")]
	internal static UniTask<Dictionary`2<TKey, TSource>> ToDictionaryAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x9457B0", Offset = "0x944BB0", Length = "0x308")]
	[AsyncStateMachine(typeof(<ToDictionaryAwaitAsync>d__3`3))]
	[Token(Token = "0x6000881")]
	internal static UniTask<Dictionary`2<TKey, TElement>> ToDictionaryAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, Func<TSource, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x945AC0", Offset = "0x944EC0", Length = "0x2BD")]
	[AsyncStateMachine(typeof(<ToDictionaryAwaitWithCancellationAsync>d__4`2))]
	[Token(Token = "0x6000882")]
	internal static UniTask<Dictionary`2<TKey, TSource>> ToDictionaryAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x9457B0", Offset = "0x944BB0", Length = "0x308")]
	[AsyncStateMachine(typeof(<ToDictionaryAwaitWithCancellationAsync>d__5`3))]
	[Token(Token = "0x6000883")]
	internal static UniTask<Dictionary`2<TKey, TElement>> ToDictionaryAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

}

