namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000099")]
internal sealed class DefaultIfEmpty : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200009A")]
	private sealed class _DefaultIfEmpty : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x200009B")]
		private enum IteratingState : byte
		{
			Empty = 0,
			Iterating = 1,
			Completed = 2,
		}

		[Token(Token = "0x40007CE")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007CF")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007D0")]
		private readonly TSource defaultValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007D1")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007D2")]
		private IteratingState<TSource> iteratingState; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007D3")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007D4")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007D5")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000018")]
		public private override TSource Current
		{
			[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600042F")]
			 get { } //Length: 176
			[Address(RVA = "0x100A360", Offset = "0x1009760", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000430")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x15F0980", Offset = "0x15EFD80", Length = "0xEA")]
		[Token(Token = "0x6000434")]
		private static _DefaultIfEmpty() { }

		[Address(RVA = "0x15F0A70", Offset = "0x15EFE70", Length = "0x1A4")]
		[Token(Token = "0x600042E")]
		public _DefaultIfEmpty(IUniTaskAsyncEnumerable<TSource> source, TSource defaultValue, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15EFF90", Offset = "0x15EF390", Length = "0x12B")]
		[Token(Token = "0x6000433")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600042F")]
		public override TSource get_Current() { }

		[Address(RVA = "0x15F00C0", Offset = "0x15EF4C0", Length = "0x502")]
		[Token(Token = "0x6000431")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15F05D0", Offset = "0x15EF9D0", Length = "0x3A2")]
		[Token(Token = "0x6000432")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x100A360", Offset = "0x1009760", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000430")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007CC")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007CD")]
	private readonly TSource defaultValue; //Field offset: 0x0

	[Address(RVA = "0x17D3780", Offset = "0x17D2B80", Length = "0x116")]
	[Token(Token = "0x600042C")]
	public DefaultIfEmpty`1(IUniTaskAsyncEnumerable<TSource> source, TSource defaultValue) { }

	[Address(RVA = "0x17D3620", Offset = "0x17D2A20", Length = "0x158")]
	[Token(Token = "0x600042D")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

