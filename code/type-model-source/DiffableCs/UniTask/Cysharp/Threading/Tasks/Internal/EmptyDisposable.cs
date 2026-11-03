namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000231")]
internal class EmptyDisposable : IDisposable
{
	[Token(Token = "0x4000600")]
	public static EmptyDisposable Instance; //Field offset: 0x0

	[Address(RVA = "0x2788B70", Offset = "0x2787F70", Length = "0x67")]
	[Token(Token = "0x6000C89")]
	private static EmptyDisposable() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000C87")]
	private EmptyDisposable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000C88")]
	public override void Dispose() { }

}

