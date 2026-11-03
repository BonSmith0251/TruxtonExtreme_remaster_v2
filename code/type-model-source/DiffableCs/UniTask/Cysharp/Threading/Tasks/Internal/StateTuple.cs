namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000217")]
internal static class StateTuple
{

	[Address(RVA = "0x9145F0", Offset = "0x9139F0", Length = "0xE9")]
	[Token(Token = "0x6000C31")]
	public static StateTuple<T1> Create(T1 item1) { }

	[Address(RVA = "0x914770", Offset = "0x913B70", Length = "0x7E")]
	[Token(Token = "0x6000C32")]
	public static StateTuple<T1, T2> Create(T1 item1, T2 item2) { }

	[Address(RVA = "0x9146E0", Offset = "0x913AE0", Length = "0x8E")]
	[Token(Token = "0x6000C33")]
	public static StateTuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3) { }

}

