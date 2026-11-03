namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200020E")]
internal class ToUniTaskAsyncEnumerableObservable : IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x200020F")]
	private class _ToUniTaskAsyncEnumerableObservable : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable, IObserver<T>
	{
		[Token(Token = "0x4001391")]
		private static readonly Action<Object> OnCanceledDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001392")]
		private readonly IObservable<T> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001393")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001394")]
		private bool useCachedCurrent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001395")]
		private T current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001396")]
		private bool subscribeCompleted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001397")]
		private readonly Queue<T> queuedResult; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001398")]
		private Exception error; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001399")]
		private IDisposable subscription; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400139A")]
		private CancellationTokenRegistration cancellationTokenRegistration; //Field offset: 0x0

		[Token(Token = "0x1700004F")]
		public override T Current
		{
			[Address(RVA = "0x1621040", Offset = "0x1620440", Length = "0x3C5")]
			[Token(Token = "0x60008E7")]
			 get { } //Length: 965
		}

		[Address(RVA = "0x1620C90", Offset = "0x1620090", Length = "0xEA")]
		[Token(Token = "0x60008EE")]
		private static _ToUniTaskAsyncEnumerableObservable() { }

		[Address(RVA = "0x1620D80", Offset = "0x1620180", Length = "0x2B2")]
		[Token(Token = "0x60008E6")]
		public _ToUniTaskAsyncEnumerableObservable(IObservable<T> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161FFE0", Offset = "0x161F3E0", Length = "0xDE")]
		[Token(Token = "0x60008E9")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1621040", Offset = "0x1620440", Length = "0x3C5")]
		[Token(Token = "0x60008E7")]
		public override T get_Current() { }

		[Address(RVA = "0x16200C0", Offset = "0x161F4C0", Length = "0x58B")]
		[Token(Token = "0x60008E8")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1620650", Offset = "0x161FA50", Length = "0x1B2")]
		[Token(Token = "0x60008ED")]
		private static void OnCanceled(object state) { }

		[Address(RVA = "0x1620810", Offset = "0x161FC10", Length = "0x13B")]
		[Token(Token = "0x60008EA")]
		public override void OnCompleted() { }

		[Address(RVA = "0x1620950", Offset = "0x161FD50", Length = "0x149")]
		[Token(Token = "0x60008EB")]
		public override void OnError(Exception error) { }

		[Address(RVA = "0x1620AA0", Offset = "0x161FEA0", Length = "0x1EF")]
		[Token(Token = "0x60008EC")]
		public override void OnNext(T value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001390")]
	private readonly IObservable<T> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60008E4")]
	public ToUniTaskAsyncEnumerableObservable`1(IObservable<T> source) { }

	[Address(RVA = "0xE12E80", Offset = "0xE12280", Length = "0x7F")]
	[Token(Token = "0x60008E5")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

