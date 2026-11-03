namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200021A")]
internal class StateTuple : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D1")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D2")]
	public T2 Item2; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000C3C")]
	public StateTuple`2() { }

	[Address(RVA = "0xFCEA60", Offset = "0xFCDE60", Length = "0x3D")]
	[Token(Token = "0x6000C3A")]
	public void Deconstruct(out T1 item1, out T2 item2) { }

	[Address(RVA = "0xFCEB10", Offset = "0xFCDF10", Length = "0x12C")]
	[Token(Token = "0x6000C3B")]
	public override void Dispose() { }

}

