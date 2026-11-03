namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200002B")]
internal sealed class AppendPrepend : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200002C")]
	private sealed class _AppendPrepend : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x200002D")]
		private enum State : byte
		{
			None = 0,
			RequirePrepend = 1,
			RequireAppend = 2,
			Completed = 3,
		}

		[Token(Token = "0x40000F8")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F9")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FA")]
		private readonly TSource element; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FB")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FC")]
		private State<TSource> state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FD")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FE")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FF")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000001")]
		public private override TSource Current
		{
			[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000246")]
			 get { } //Length: 176
			[Address(RVA = "0x100A360", Offset = "0x1009760", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000247")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1551B10", Offset = "0x1550F10", Length = "0xEA")]
		[Token(Token = "0x600024B")]
		private static _AppendPrepend() { }

		[Address(RVA = "0x1551C00", Offset = "0x1551000", Length = "0x1BA")]
		[Token(Token = "0x6000245")]
		public _AppendPrepend(IUniTaskAsyncEnumerable<TSource> source, TSource element, bool append, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1551070", Offset = "0x1550470", Length = "0x12B")]
		[Token(Token = "0x600024A")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000246")]
		public override TSource get_Current() { }

		[Address(RVA = "0x15511A0", Offset = "0x15505A0", Length = "0x5ED")]
		[Token(Token = "0x6000248")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1551790", Offset = "0x1550B90", Length = "0x378")]
		[Token(Token = "0x6000249")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x100A360", Offset = "0x1009760", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000247")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F5")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F6")]
	private readonly TSource element; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F7")]
	private readonly bool append; //Field offset: 0x0

	[Address(RVA = "0xB442B0", Offset = "0xB436B0", Length = "0x157")]
	[Token(Token = "0x6000243")]
	public AppendPrepend`1(IUniTaskAsyncEnumerable<TSource> source, TSource element, bool append) { }

	[Address(RVA = "0xB44120", Offset = "0xB43520", Length = "0x18A")]
	[Token(Token = "0x6000244")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

