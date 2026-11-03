namespace System.Linq.Expressions;

[Token(Token = "0x20000BB")]
internal sealed class StackGuard
{
	[CompilerGenerated]
	[Token(Token = "0x20000BC")]
	private sealed class <>c__3
	{
		[Token(Token = "0x40001BF")]
		public static readonly <>c__3<T1, T2> <>9; //Field offset: 0x0
		[Token(Token = "0x40001C0")]
		public static Func<Object, Object> <>9__3_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x60004BC")]
		private static <>c__3`2() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004BD")]
		public <>c__3`2() { }

		[Address(RVA = "0xA537F0", Offset = "0xA52BF0", Length = "0x8A")]
		[Token(Token = "0x60004BE")]
		internal object <RunOnEmptyStack>b__3_0(object s) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BE")]
	private int _executionStackCount; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60004BB")]
	public StackGuard() { }

	[Address(RVA = "0x913AD0", Offset = "0x912ED0", Length = "0x1CC")]
	[Token(Token = "0x60004B9")]
	public void RunOnEmptyStack(Action<T1, T2> action, T1 arg1, T2 arg2) { }

	[Address(RVA = "0x913590", Offset = "0x912990", Length = "0x274")]
	[Token(Token = "0x60004BA")]
	private R RunOnEmptyStackCore(Func<Object, R> action, object state) { }

	[Address(RVA = "0x22696A0", Offset = "0x2268AA0", Length = "0x63")]
	[Token(Token = "0x60004B8")]
	public bool TryEnterOnCurrentStack() { }

}

