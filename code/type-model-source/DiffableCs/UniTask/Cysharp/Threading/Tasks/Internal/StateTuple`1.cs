namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000218")]
internal class StateTuple : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005CF")]
	public T1 Item1; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000C36")]
	public StateTuple`1() { }

	[Address(RVA = "0xFCE650", Offset = "0xFCDA50", Length = "0xDA")]
	[Token(Token = "0x6000C34")]
	public void Deconstruct(out T1 item1) { }

	[Address(RVA = "0xFCE860", Offset = "0xFCDC60", Length = "0x63")]
	[Token(Token = "0x6000C35")]
	public override void Dispose() { }

}

