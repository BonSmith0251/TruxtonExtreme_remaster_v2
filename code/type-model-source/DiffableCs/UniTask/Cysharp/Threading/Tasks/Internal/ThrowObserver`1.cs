namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000237")]
internal class ThrowObserver : IObserver<T>
{
	[Token(Token = "0x4000610")]
	public static readonly ThrowObserver<T> Instance; //Field offset: 0x0

	[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
	[Token(Token = "0x6000CAA")]
	private static ThrowObserver`1() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000CA6")]
	private ThrowObserver`1() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000CA7")]
	public override void OnCompleted() { }

	[Address(RVA = "0x1084FD0", Offset = "0x10843D0", Length = "0x26")]
	[Token(Token = "0x6000CA8")]
	public override void OnError(Exception error) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000CA9")]
	public override void OnNext(T value) { }

}

