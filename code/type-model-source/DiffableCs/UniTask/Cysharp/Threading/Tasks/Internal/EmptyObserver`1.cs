namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000236")]
internal class EmptyObserver : IObserver<T>
{
	[Token(Token = "0x400060F")]
	public static readonly EmptyObserver<T> Instance; //Field offset: 0x0

	[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
	[Token(Token = "0x6000CA5")]
	private static EmptyObserver`1() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000CA1")]
	private EmptyObserver`1() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000CA2")]
	public override void OnCompleted() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000CA3")]
	public override void OnError(Exception error) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000CA4")]
	public override void OnNext(T value) { }

}

