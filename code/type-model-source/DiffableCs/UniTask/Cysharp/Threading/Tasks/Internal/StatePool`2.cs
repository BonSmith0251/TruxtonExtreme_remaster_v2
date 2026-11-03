namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200021B")]
internal static class StatePool
{
	[Token(Token = "0x40005D3")]
	private static readonly ConcurrentQueue<StateTuple`2<T1, T2>> queue; //Field offset: 0x0

	[Address(RVA = "0xFCD870", Offset = "0xFCCC70", Length = "0xF6")]
	[Token(Token = "0x6000C3F")]
	private static StatePool`2() { }

	[Address(RVA = "0xFCD2C0", Offset = "0xFCC6C0", Length = "0x1BC")]
	[Token(Token = "0x6000C3D")]
	public static StateTuple<T1, T2> Create(T1 item1, T2 item2) { }

	[Address(RVA = "0xFCD480", Offset = "0xFCC880", Length = "0xEC")]
	[Token(Token = "0x6000C3E")]
	public static void Return(StateTuple<T1, T2> tuple) { }

}

