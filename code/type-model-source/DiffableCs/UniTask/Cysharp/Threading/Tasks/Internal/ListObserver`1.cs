namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000235")]
internal class ListObserver : IObserver<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060E")]
	private readonly ImmutableList<IObserver`1<T>> _observers; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000C9B")]
	public ListObserver`1(ImmutableList<IObserver`1<T>> observers) { }

	[Address(RVA = "0xB0B8D0", Offset = "0xB0ACD0", Length = "0x86")]
	[Token(Token = "0x6000C9F")]
	internal IObserver<T> Add(IObserver<T> observer) { }

	[Address(RVA = "0xB0B960", Offset = "0xB0AD60", Length = "0x120")]
	[Token(Token = "0x6000C9C")]
	public override void OnCompleted() { }

	[Address(RVA = "0xB0BBD0", Offset = "0xB0AFD0", Length = "0x138")]
	[Token(Token = "0x6000C9D")]
	public override void OnError(Exception error) { }

	[Address(RVA = "0xB0BE60", Offset = "0xB0B260", Length = "0x131")]
	[Token(Token = "0x6000C9E")]
	public override void OnNext(T value) { }

	[Address(RVA = "0xB0C2B0", Offset = "0xB0B6B0", Length = "0x10A")]
	[Token(Token = "0x6000CA0")]
	internal IObserver<T> Remove(IObserver<T> observer) { }

}

