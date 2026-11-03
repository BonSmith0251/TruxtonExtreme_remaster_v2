namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000233")]
internal sealed class AsyncSubject : IObservable<T>, IObserver<T>
{
	[Token(Token = "0x2000234")]
	private class Subscription : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400060B")]
		private readonly object gate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400060C")]
		private AsyncSubject<T> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400060D")]
		private IObserver<T> unsubscribeTarget; //Field offset: 0x0

		[Address(RVA = "0xFD8EB0", Offset = "0xFD82B0", Length = "0xA0")]
		[Token(Token = "0x6000C99")]
		public Subscription(AsyncSubject<T> parent, IObserver<T> unsubscribeTarget) { }

		[Address(RVA = "0xFD8C00", Offset = "0xFD8000", Length = "0x2A3")]
		[Token(Token = "0x6000C9A")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000604")]
	private object observerLock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000605")]
	private T lastValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000606")]
	private bool hasValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000607")]
	private bool isStopped; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000608")]
	private bool isDisposed; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000609")]
	private Exception lastError; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060A")]
	private IObserver<T> outObserver; //Field offset: 0x0

	[Token(Token = "0x17000076")]
	public bool HasObservers
	{
		[Address(RVA = "0x116BEA0", Offset = "0x116B2A0", Length = "0x7F")]
		[Token(Token = "0x6000C90")]
		 get { } //Length: 127
	}

	[Token(Token = "0x17000077")]
	public bool IsCompleted
	{
		[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
		[Token(Token = "0x6000C91")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000075")]
	public T Value
	{
		[Address(RVA = "0x116C060", Offset = "0x116B460", Length = "0xE3")]
		[Token(Token = "0x6000C8F")]
		 get { } //Length: 227
	}

	[Address(RVA = "0x116BC60", Offset = "0x116B060", Length = "0xDB")]
	[Token(Token = "0x6000C98")]
	public AsyncSubject`1() { }

	[Address(RVA = "0x1169F40", Offset = "0x1169340", Length = "0x113")]
	[Token(Token = "0x6000C96")]
	public void Dispose() { }

	[Address(RVA = "0x116BEA0", Offset = "0x116B2A0", Length = "0x7F")]
	[Token(Token = "0x6000C90")]
	public bool get_HasObservers() { }

	[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
	[Token(Token = "0x6000C91")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x116C060", Offset = "0x116B460", Length = "0xE3")]
	[Token(Token = "0x6000C8F")]
	public T get_Value() { }

	[Address(RVA = "0x116A060", Offset = "0x1169460", Length = "0x22F")]
	[Token(Token = "0x6000C92")]
	public override void OnCompleted() { }

	[Address(RVA = "0x116A6A0", Offset = "0x1169AA0", Length = "0x232")]
	[Token(Token = "0x6000C93")]
	public override void OnError(Exception error) { }

	[Address(RVA = "0x116AC30", Offset = "0x116A030", Length = "0x108")]
	[Token(Token = "0x6000C94")]
	public override void OnNext(T value) { }

	[Address(RVA = "0x116AF20", Offset = "0x116A320", Length = "0x53B")]
	[Token(Token = "0x6000C95")]
	public override IDisposable Subscribe(IObserver<T> observer) { }

	[Address(RVA = "0x116BB80", Offset = "0x116AF80", Length = "0x5B")]
	[Token(Token = "0x6000C97")]
	private void ThrowIfDisposed() { }

}

