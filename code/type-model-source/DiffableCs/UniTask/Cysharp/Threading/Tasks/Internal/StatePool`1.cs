namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000219")]
internal static class StatePool
{
	[Token(Token = "0x40005D0")]
	private static readonly ConcurrentQueue<StateTuple`1<T1>> queue; //Field offset: 0x0

	[Address(RVA = "0xFCCC70", Offset = "0xFCC070", Length = "0x120")]
	[Token(Token = "0x6000C39")]
	private static StatePool`1() { }

	[Address(RVA = "0xFCC570", Offset = "0xFCB970", Length = "0x2E0")]
	[Token(Token = "0x6000C37")]
	public static StateTuple<T1> Create(T1 item1) { }

	[Address(RVA = "0xFCCA00", Offset = "0xFCBE00", Length = "0x176")]
	[Token(Token = "0x6000C38")]
	public static void Return(StateTuple<T1> tuple) { }

}

