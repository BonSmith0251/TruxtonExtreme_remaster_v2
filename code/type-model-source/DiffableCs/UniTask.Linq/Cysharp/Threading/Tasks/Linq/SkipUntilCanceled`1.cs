namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000192")]
internal sealed class SkipUntilCanceled : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000193")]
	private sealed class _SkipUntilCanceled : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x4000FD0")]
		private static readonly Action<Object> CancelDelegate1; //Field offset: 0x0
		[Token(Token = "0x4000FD1")]
		private static readonly Action<Object> CancelDelegate2; //Field offset: 0x0
		[Token(Token = "0x4000FD2")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FD3")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FD4")]
		private CancellationToken cancellationToken1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FD5")]
		private CancellationToken cancellationToken2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FD6")]
		private CancellationTokenRegistration cancellationTokenRegistration1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FD7")]
		private CancellationTokenRegistration cancellationTokenRegistration2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FD8")]
		private int isCanceled; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FD9")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FDA")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FDB")]
		private bool continueNext; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FDC")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000041")]
		public private override TSource Current
		{
			[Address(RVA = "0x16184D0", Offset = "0x16178D0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000774")]
			 get { } //Length: 176
			[Address(RVA = "0x1618580", Offset = "0x1617980", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000775")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1617E60", Offset = "0x1617260", Length = "0x262")]
		[Token(Token = "0x600077C")]
		private static _SkipUntilCanceled() { }

		[Address(RVA = "0x16180D0", Offset = "0x16174D0", Length = "0x3F2")]
		[Token(Token = "0x6000773")]
		public _SkipUntilCanceled(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken1, CancellationToken cancellationToken2) { }

		[Address(RVA = "0x1617030", Offset = "0x1616430", Length = "0x17E")]
		[Token(Token = "0x600077B")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x16184D0", Offset = "0x16178D0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000774")]
		public override TSource get_Current() { }

		[Address(RVA = "0x16171B0", Offset = "0x16165B0", Length = "0x327")]
		[Token(Token = "0x6000776")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x16174E0", Offset = "0x16168E0", Length = "0x32E")]
		[Token(Token = "0x6000778")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x1617810", Offset = "0x1616C10", Length = "0x193")]
		[Token(Token = "0x6000779")]
		private static void OnCanceled1(object state) { }

		[Address(RVA = "0x1617810", Offset = "0x1616C10", Length = "0x193")]
		[Token(Token = "0x600077A")]
		private static void OnCanceled2(object state) { }

		[Address(RVA = "0x1618580", Offset = "0x1617980", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000775")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x16179B0", Offset = "0x1616DB0", Length = "0x4A2")]
		[Token(Token = "0x6000777")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FCE")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FCF")]
	private readonly CancellationToken cancellationToken; //Field offset: 0x0

	[Address(RVA = "0xF63F80", Offset = "0xF63380", Length = "0x4D")]
	[Token(Token = "0x6000771")]
	public SkipUntilCanceled`1(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0xF63EE0", Offset = "0xF632E0", Length = "0x97")]
	[Token(Token = "0x6000772")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

