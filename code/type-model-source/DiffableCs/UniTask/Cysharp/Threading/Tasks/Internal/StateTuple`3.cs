namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200021C")]
internal class StateTuple : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D4")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D5")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D6")]
	public T3 Item3; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000C42")]
	public StateTuple`3() { }

	[Address(RVA = "0xFCEC40", Offset = "0xFCE040", Length = "0x50")]
	[Token(Token = "0x6000C40")]
	public void Deconstruct(out T1 item1, out T2 item2, out T3 item3) { }

	[Address(RVA = "0xFCEED0", Offset = "0xFCE2D0", Length = "0x12F")]
	[Token(Token = "0x6000C41")]
	public override void Dispose() { }

}

