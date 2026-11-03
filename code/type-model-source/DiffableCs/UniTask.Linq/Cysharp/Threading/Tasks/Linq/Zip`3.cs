namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000226")]
internal sealed class Zip : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000227")]
	private sealed class _Zip : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000228")]
		private struct <DisposeAsync>d__18 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001420")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001421")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001422")]
			public _Zip<TFirst, TSecond, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001423")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E7990", Offset = "0x16E6D90", Length = "0x42B")]
			[Token(Token = "0x600094C")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x600094D")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4001415")]
		private static readonly Action<Object> firstMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4001416")]
		private static readonly Action<Object> secondMoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001417")]
		private readonly IUniTaskAsyncEnumerable<TFirst> first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001418")]
		private readonly IUniTaskAsyncEnumerable<TSecond> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001419")]
		private readonly Func<TFirst, TSecond, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400141A")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400141B")]
		private IUniTaskAsyncEnumerator<TFirst> firstEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400141C")]
		private IUniTaskAsyncEnumerator<TSecond> secondEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400141D")]
		private Awaiter<Boolean> firstAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400141E")]
		private Awaiter<Boolean> secondAwaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400141F")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700005B")]
		public private override TResult Current
		{
			[Address(RVA = "0x1619850", Offset = "0x1618C50", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000945")]
			 get { } //Length: 176
			[Address(RVA = "0x1619900", Offset = "0x1618D00", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000946")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x162BA20", Offset = "0x162AE20", Length = "0x1A6")]
		[Token(Token = "0x600094B")]
		private static _Zip() { }

		[Address(RVA = "0x162BBD0", Offset = "0x162AFD0", Length = "0x4B3")]
		[Token(Token = "0x6000944")]
		public _Zip(IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1568B50", Offset = "0x1567F50", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__18))]
		[Token(Token = "0x600094A")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x162AA70", Offset = "0x1629E70", Length = "0x456")]
		[Token(Token = "0x6000948")]
		private static void FirstMoveNextCore(object state) { }

		[Address(RVA = "0x1619850", Offset = "0x1618C50", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000945")]
		public override TResult get_Current() { }

		[Address(RVA = "0x162AED0", Offset = "0x162A2D0", Length = "0x568")]
		[Token(Token = "0x6000947")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x162B440", Offset = "0x162A840", Length = "0x5D2")]
		[Token(Token = "0x6000949")]
		private static void SecondMoveNextCore(object state) { }

		[Address(RVA = "0x1619900", Offset = "0x1618D00", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000946")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001412")]
	private readonly IUniTaskAsyncEnumerable<TFirst> first; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001413")]
	private readonly IUniTaskAsyncEnumerable<TSecond> second; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001414")]
	private readonly Func<TFirst, TSecond, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x6000942")]
	public Zip`3(IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x6000943")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

