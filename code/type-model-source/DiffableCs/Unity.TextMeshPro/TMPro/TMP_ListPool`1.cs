namespace TMPro;

[Token(Token = "0x2000072")]
internal static class TMP_ListPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000073")]
	private sealed class <>c
	{
		[Token(Token = "0x4000329")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x600040B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600040C")]
		public <>c() { }

		[Address(RVA = "0xA36470", Offset = "0xA35870", Length = "0x3B")]
		[Token(Token = "0x600040D")]
		internal void <.cctor>b__3_0(List<T> l) { }

	}

	[Token(Token = "0x4000328")]
	private static readonly TMP_ObjectPool<List`1<T>> s_ListPool; //Field offset: 0x0

	[Address(RVA = "0xFD9CF0", Offset = "0xFD90F0", Length = "0x2B9")]
	[Token(Token = "0x600040A")]
	private static TMP_ListPool`1() { }

	[Address(RVA = "0xFD9800", Offset = "0xFD8C00", Length = "0x19A")]
	[Token(Token = "0x6000408")]
	public static List<T> Get() { }

	[Address(RVA = "0xFD99A0", Offset = "0xFD8DA0", Length = "0x221")]
	[Token(Token = "0x6000409")]
	public static void Release(List<T> toRelease) { }

}

