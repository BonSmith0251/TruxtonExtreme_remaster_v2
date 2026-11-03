namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000214")]
internal sealed class EveryValueChangedStandardObject : IUniTaskAsyncEnumerable<TProperty>
{
	[Token(Token = "0x2000215")]
	private sealed class _EveryValueChanged : MoveNextSource, IUniTaskAsyncEnumerator<TProperty>, IUniTaskAsyncDisposable, IPlayerLoopItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013AF")]
		private readonly WeakReference<TTarget> target; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013B0")]
		private readonly IEqualityComparer<TProperty> equalityComparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013B1")]
		private readonly Func<TTarget, TProperty> propertySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013B2")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013B3")]
		private bool first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013B4")]
		private TProperty currentValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013B5")]
		private bool disposed; //Field offset: 0x0

		[Token(Token = "0x17000052")]
		public override TProperty Current
		{
			[Address(RVA = "0x15F94C0", Offset = "0x15F88C0", Length = "0xB0")]
			[Token(Token = "0x6000900")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x15F92D0", Offset = "0x15F86D0", Length = "0x1E1")]
		[Token(Token = "0x60008FF")]
		public _EveryValueChanged(WeakReference<TTarget> target, Func<TTarget, TProperty> propertySelector, IEqualityComparer<TProperty> equalityComparer, PlayerLoopTiming monitorTiming, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F7F10", Offset = "0x15F7310", Length = "0xAC")]
		[Token(Token = "0x6000902")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15F94C0", Offset = "0x15F88C0", Length = "0xB0")]
		[Token(Token = "0x6000900")]
		public override TProperty get_Current() { }

		[Address(RVA = "0x15F8710", Offset = "0x15F7B10", Length = "0x408")]
		[Token(Token = "0x6000903")]
		public override bool MoveNext() { }

		[Address(RVA = "0x15F8400", Offset = "0x15F7800", Length = "0x303")]
		[Token(Token = "0x6000901")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013AB")]
	private readonly WeakReference<TTarget> target; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013AC")]
	private readonly Func<TTarget, TProperty> propertySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013AD")]
	private readonly IEqualityComparer<TProperty> equalityComparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013AE")]
	private readonly PlayerLoopTiming monitorTiming; //Field offset: 0x0

	[Address(RVA = "0x1BACD30", Offset = "0x1BAC130", Length = "0xC8")]
	[Token(Token = "0x60008FD")]
	public EveryValueChangedStandardObject`2(TTarget target, Func<TTarget, TProperty> propertySelector, IEqualityComparer<TProperty> equalityComparer, PlayerLoopTiming monitorTiming) { }

	[Address(RVA = "0x1BACC70", Offset = "0x1BAC070", Length = "0xB1")]
	[Token(Token = "0x60008FE")]
	public override IUniTaskAsyncEnumerator<TProperty> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

