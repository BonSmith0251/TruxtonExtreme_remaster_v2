namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000161")]
public class UnityEventHandlerAsyncEnumerable : IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x2000162")]
	private class UnityEventHandlerAsyncEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x4000541")]
		private static readonly Action<Object> cancel1; //Field offset: 0x0
		[Token(Token = "0x4000542")]
		private static readonly Action<Object> cancel2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000543")]
		private readonly UnityEvent<T> unityEvent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000544")]
		private CancellationToken cancellationToken1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000545")]
		private CancellationToken cancellationToken2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000546")]
		private UnityAction<T> unityAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000547")]
		private CancellationTokenRegistration registration1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000548")]
		private CancellationTokenRegistration registration2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000549")]
		private bool isDisposed; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400054A")]
		private T <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700005F")]
		public private override T Current
		{
			[Address(RVA = "0x119FB50", Offset = "0x119EF50", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000878")]
			 get { } //Length: 8
			[Address(RVA = "0x119FC40", Offset = "0x119F040", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6000879")]
			private set { } //Length: 7
		}

		[Address(RVA = "0x119EEC0", Offset = "0x119E2C0", Length = "0x1A6")]
		[Token(Token = "0x600087F")]
		private static UnityEventHandlerAsyncEnumerator() { }

		[Address(RVA = "0x119F8E0", Offset = "0x119ECE0", Length = "0x69")]
		[Token(Token = "0x6000877")]
		public UnityEventHandlerAsyncEnumerator(UnityEvent<T> unityEvent, CancellationToken cancellationToken1, CancellationToken cancellationToken2) { }

		[Address(RVA = "0x119C6A0", Offset = "0x119BAA0", Length = "0xCF")]
		[Token(Token = "0x600087E")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x119FB50", Offset = "0x119EF50", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000878")]
		public override T get_Current() { }

		[Address(RVA = "0x119CC60", Offset = "0x119C060", Length = "0x4F")]
		[Token(Token = "0x600087B")]
		private void Invoke(T value) { }

		[Address(RVA = "0x119D310", Offset = "0x119C710", Length = "0x406")]
		[Token(Token = "0x600087A")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x119E960", Offset = "0x119DD60", Length = "0x141")]
		[Token(Token = "0x600087C")]
		private static void OnCanceled1(object state) { }

		[Address(RVA = "0x119E960", Offset = "0x119DD60", Length = "0x141")]
		[Token(Token = "0x600087D")]
		private static void OnCanceled2(object state) { }

		[Address(RVA = "0x119FC40", Offset = "0x119F040", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000879")]
		private void set_Current(T value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053F")]
	private readonly UnityEvent<T> unityEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000540")]
	private readonly CancellationToken cancellationToken1; //Field offset: 0x0

	[Address(RVA = "0xF63F80", Offset = "0xF63380", Length = "0x4D")]
	[Token(Token = "0x6000875")]
	public UnityEventHandlerAsyncEnumerable`1(UnityEvent<T> unityEvent, CancellationToken cancellationToken) { }

	[Address(RVA = "0x119C3A0", Offset = "0x119B7A0", Length = "0x154")]
	[Token(Token = "0x6000876")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

