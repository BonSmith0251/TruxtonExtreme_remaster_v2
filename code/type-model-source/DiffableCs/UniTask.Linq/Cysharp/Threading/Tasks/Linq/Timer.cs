namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000216")]
internal class Timer : IUniTaskAsyncEnumerable<AsyncUnit>
{
	[Token(Token = "0x2000217")]
	private class _Timer : MoveNextSource, IUniTaskAsyncEnumerator<AsyncUnit>, IUniTaskAsyncDisposable, IPlayerLoopItem
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40013BA")]
		private readonly float dueTime; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40013BB")]
		private readonly Nullable<Single> period; //Field offset: 0x3C
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40013BC")]
		private readonly PlayerLoopTiming updateTiming; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40013BD")]
		private readonly bool ignoreTimeScale; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40013BE")]
		private CancellationToken cancellationToken; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40013BF")]
		private int initialFrame; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40013C0")]
		private float elapsed; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40013C1")]
		private bool dueTimePhase; //Field offset: 0x60
		[FieldOffset(Offset = "0x61")]
		[Token(Token = "0x40013C2")]
		private bool completed; //Field offset: 0x61
		[FieldOffset(Offset = "0x62")]
		[Token(Token = "0x40013C3")]
		private bool disposed; //Field offset: 0x62

		[Token(Token = "0x17000053")]
		public override AsyncUnit Current
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000907")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x276E3B0", Offset = "0x276D7B0", Length = "0x1EA")]
		[Token(Token = "0x6000906")]
		public _Timer(TimeSpan dueTime, Nullable<TimeSpan> period, PlayerLoopTiming updateTiming, bool ignoreTimeScale, CancellationToken cancellationToken) { }

		[Address(RVA = "0x276E0F0", Offset = "0x276D4F0", Length = "0x14")]
		[Token(Token = "0x6000909")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000907")]
		public override AsyncUnit get_Current() { }

		[Address(RVA = "0x276E230", Offset = "0x276D630", Length = "0x174")]
		[Token(Token = "0x600090A")]
		public override bool MoveNext() { }

		[Address(RVA = "0x276E110", Offset = "0x276D510", Length = "0x118")]
		[Token(Token = "0x6000908")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013B6")]
	private readonly PlayerLoopTiming updateTiming; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013B7")]
	private readonly TimeSpan dueTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013B8")]
	private readonly Nullable<TimeSpan> period; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013B9")]
	private readonly bool ignoreTimeScale; //Field offset: 0x30

	[Address(RVA = "0x276C7B0", Offset = "0x276BBB0", Length = "0x52")]
	[Token(Token = "0x6000904")]
	public Timer(TimeSpan dueTime, Nullable<TimeSpan> period, PlayerLoopTiming updateTiming, bool ignoreTimeScale) { }

	[Address(RVA = "0x276C700", Offset = "0x276BB00", Length = "0xAE")]
	[Token(Token = "0x6000905")]
	public override IUniTaskAsyncEnumerator<AsyncUnit> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

