namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000238")]
internal class DisposedObserver : IObserver<T>
{
	[Token(Token = "0x4000611")]
	public static readonly DisposedObserver<T> Instance; //Field offset: 0x0

	[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
	[Token(Token = "0x6000CAF")]
	private static DisposedObserver`1() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000CAB")]
	private DisposedObserver`1() { }

	[Address(RVA = "0x193CDC0", Offset = "0x193C1C0", Length = "0x49")]
	[Token(Token = "0x6000CAC")]
	public override void OnCompleted() { }

	[Address(RVA = "0x193CE10", Offset = "0x193C210", Length = "0x49")]
	[Token(Token = "0x6000CAD")]
	public override void OnError(Exception error) { }

	[Address(RVA = "0x193CE10", Offset = "0x193C210", Length = "0x49")]
	[Token(Token = "0x6000CAE")]
	public override void OnNext(T value) { }

}

