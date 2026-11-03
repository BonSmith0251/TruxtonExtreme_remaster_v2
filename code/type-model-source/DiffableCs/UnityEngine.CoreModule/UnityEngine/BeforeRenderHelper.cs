namespace UnityEngine;

[Token(Token = "0x20000CF")]
internal static class BeforeRenderHelper
{
	[Token(Token = "0x20000D0")]
	private struct OrderBlock
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024F")]
		internal int order; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000250")]
		internal UnityAction callback; //Field offset: 0x8

	}

	[Token(Token = "0x400024E")]
	private static List<OrderBlock> s_OrderBlocks; //Field offset: 0x0

	[Address(RVA = "0x2FF1890", Offset = "0x2FF0C90", Length = "0x84")]
	[Token(Token = "0x6000611")]
	private static BeforeRenderHelper() { }

	[Address(RVA = "0x2FF16F0", Offset = "0x2FF0AF0", Length = "0x190")]
	[Token(Token = "0x6000610")]
	public static void Invoke() { }

}

