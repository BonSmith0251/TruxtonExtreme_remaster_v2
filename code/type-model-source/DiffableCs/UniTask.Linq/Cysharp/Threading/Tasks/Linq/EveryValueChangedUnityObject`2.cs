namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000212")]
internal sealed class EveryValueChangedUnityObject : IUniTaskAsyncEnumerable<TProperty>
{
	[Token(Token = "0x2000213")]
	private sealed class _EveryValueChanged : MoveNextSource, IUniTaskAsyncEnumerator<TProperty>, IUniTaskAsyncDisposable, IPlayerLoopItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013A3")]
		private readonly TTarget target; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013A4")]
		private readonly object targetAsUnityObject; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013A5")]
		private readonly IEqualityComparer<TProperty> equalityComparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013A6")]
		private readonly Func<TTarget, TProperty> propertySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013A7")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013A8")]
		private bool first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013A9")]
		private TProperty currentValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013AA")]
		private bool disposed; //Field offset: 0x0

		[Token(Token = "0x17000051")]
		public override TProperty Current
		{
			[Address(RVA = "0x15F9570", Offset = "0x15F8970", Length = "0xB0")]
			[Token(Token = "0x60008F9")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x15F8FB0", Offset = "0x15F83B0", Length = "0x319")]
		[Token(Token = "0x60008F8")]
		public _EveryValueChanged(TTarget target, Func<TTarget, TProperty> propertySelector, IEqualityComparer<TProperty> equalityComparer, PlayerLoopTiming monitorTiming, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F7FC0", Offset = "0x15F73C0", Length = "0xAC")]
		[Token(Token = "0x60008FB")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15F9570", Offset = "0x15F8970", Length = "0xB0")]
		[Token(Token = "0x60008F9")]
		public override TProperty get_Current() { }

		[Address(RVA = "0x15F8B20", Offset = "0x15F7F20", Length = "0x487")]
		[Token(Token = "0x60008FC")]
		public override bool MoveNext() { }

		[Address(RVA = "0x15F8070", Offset = "0x15F7470", Length = "0x38F")]
		[Token(Token = "0x60008FA")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400139F")]
	private readonly TTarget target; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013A0")]
	private readonly Func<TTarget, TProperty> propertySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013A1")]
	private readonly IEqualityComparer<TProperty> equalityComparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013A2")]
	private readonly PlayerLoopTiming monitorTiming; //Field offset: 0x0

	[Address(RVA = "0x1BACFC0", Offset = "0x1BAC3C0", Length = "0x19C")]
	[Token(Token = "0x60008F6")]
	public EveryValueChangedUnityObject`2(TTarget target, Func<TTarget, TProperty> propertySelector, IEqualityComparer<TProperty> equalityComparer, PlayerLoopTiming monitorTiming) { }

	[Address(RVA = "0x1BACE00", Offset = "0x1BAC200", Length = "0x1B6")]
	[Token(Token = "0x60008F7")]
	public override IUniTaskAsyncEnumerator<TProperty> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

