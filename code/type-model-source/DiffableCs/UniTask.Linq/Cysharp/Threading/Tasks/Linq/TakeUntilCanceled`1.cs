namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001D9")]
internal sealed class TakeUntilCanceled : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001DA")]
	private sealed class _TakeUntilCanceled : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x400123C")]
		private static readonly Action<Object> CancelDelegate1; //Field offset: 0x0
		[Token(Token = "0x400123D")]
		private static readonly Action<Object> CancelDelegate2; //Field offset: 0x0
		[Token(Token = "0x400123E")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400123F")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001240")]
		private CancellationToken cancellationToken1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001241")]
		private CancellationToken cancellationToken2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001242")]
		private CancellationTokenRegistration cancellationTokenRegistration1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001243")]
		private CancellationTokenRegistration cancellationTokenRegistration2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001244")]
		private bool isCanceled; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001245")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001246")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001247")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000046")]
		public private override TSource Current
		{
			[Address(RVA = "0x161D350", Offset = "0x161C750", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000850")]
			 get { } //Length: 176
			[Address(RVA = "0x161D400", Offset = "0x161C800", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000851")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x161CCE0", Offset = "0x161C0E0", Length = "0x262")]
		[Token(Token = "0x6000858")]
		private static _TakeUntilCanceled() { }

		[Address(RVA = "0x161CF50", Offset = "0x161C350", Length = "0x3F2")]
		[Token(Token = "0x600084F")]
		public _TakeUntilCanceled(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken1, CancellationToken cancellationToken2) { }

		[Address(RVA = "0x161BF50", Offset = "0x161B350", Length = "0x17E")]
		[Token(Token = "0x6000857")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x161D350", Offset = "0x161C750", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000850")]
		public override TSource get_Current() { }

		[Address(RVA = "0x161C0D0", Offset = "0x161B4D0", Length = "0x35D")]
		[Token(Token = "0x6000852")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x161C430", Offset = "0x161B830", Length = "0x2D1")]
		[Token(Token = "0x6000854")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x161C710", Offset = "0x161BB10", Length = "0x12C")]
		[Token(Token = "0x6000855")]
		private static void OnCanceled1(object state) { }

		[Address(RVA = "0x161C840", Offset = "0x161BC40", Length = "0x12C")]
		[Token(Token = "0x6000856")]
		private static void OnCanceled2(object state) { }

		[Address(RVA = "0x161D400", Offset = "0x161C800", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000851")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x161C970", Offset = "0x161BD70", Length = "0x362")]
		[Token(Token = "0x6000853")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400123A")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400123B")]
	private readonly CancellationToken cancellationToken; //Field offset: 0x0

	[Address(RVA = "0xF63F80", Offset = "0xF63380", Length = "0x4D")]
	[Token(Token = "0x600084D")]
	public TakeUntilCanceled`1(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0xF63EE0", Offset = "0xF632E0", Length = "0x97")]
	[Token(Token = "0x600084E")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

