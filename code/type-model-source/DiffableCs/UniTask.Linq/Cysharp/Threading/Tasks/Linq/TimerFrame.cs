namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000218")]
internal class TimerFrame : IUniTaskAsyncEnumerable<AsyncUnit>
{
	[Token(Token = "0x2000219")]
	private class _TimerFrame : MoveNextSource, IUniTaskAsyncEnumerator<AsyncUnit>, IUniTaskAsyncDisposable, IPlayerLoopItem
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40013C7")]
		private readonly int dueTimeFrameCount; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40013C8")]
		private readonly Nullable<Int32> periodFrameCount; //Field offset: 0x3C
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40013C9")]
		private CancellationToken cancellationToken; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40013CA")]
		private int initialFrame; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40013CB")]
		private int currentFrame; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40013CC")]
		private bool dueTimePhase; //Field offset: 0x58
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x40013CD")]
		private bool completed; //Field offset: 0x59
		[FieldOffset(Offset = "0x5A")]
		[Token(Token = "0x40013CE")]
		private bool disposed; //Field offset: 0x5A

		[Token(Token = "0x17000054")]
		public override AsyncUnit Current
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600090E")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x276DFB0", Offset = "0x276D3B0", Length = "0x139")]
		[Token(Token = "0x600090D")]
		public _TimerFrame(int dueTimeFrameCount, Nullable<Int32> periodFrameCount, PlayerLoopTiming updateTiming, CancellationToken cancellationToken) { }

		[Address(RVA = "0x276DD30", Offset = "0x276D130", Length = "0x14")]
		[Token(Token = "0x6000910")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600090E")]
		public override AsyncUnit get_Current() { }

		[Address(RVA = "0x276DE70", Offset = "0x276D270", Length = "0x136")]
		[Token(Token = "0x6000911")]
		public override bool MoveNext() { }

		[Address(RVA = "0x276DD50", Offset = "0x276D150", Length = "0x118")]
		[Token(Token = "0x600090F")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013C4")]
	private readonly PlayerLoopTiming updateTiming; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40013C5")]
	private readonly int dueTimeFrameCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013C6")]
	private readonly Nullable<Int32> periodFrameCount; //Field offset: 0x18

	[Address(RVA = "0x276C6B0", Offset = "0x276BAB0", Length = "0x45")]
	[Token(Token = "0x600090B")]
	public TimerFrame(int dueTimeFrameCount, Nullable<Int32> periodFrameCount, PlayerLoopTiming updateTiming) { }

	[Address(RVA = "0x276C540", Offset = "0x276B940", Length = "0x168")]
	[Token(Token = "0x600090C")]
	public override IUniTaskAsyncEnumerator<AsyncUnit> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

