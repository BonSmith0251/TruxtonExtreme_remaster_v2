namespace UnityEngine.Rendering;

[Token(Token = "0x2000057")]
public static class ListPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private sealed class <>c
	{
		[Token(Token = "0x4000145")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000532")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000533")]
		public <>c() { }

		[Address(RVA = "0xA364B0", Offset = "0xA358B0", Length = "0x1D")]
		[Token(Token = "0x6000534")]
		internal void <.cctor>b__4_0(List<T> l) { }

	}

	[Token(Token = "0x4000144")]
	private static readonly ObjectPool<List`1<T>> s_Pool; //Field offset: 0x0

	[Address(RVA = "0xB0CEA0", Offset = "0xB0C2A0", Length = "0x21E")]
	[Token(Token = "0x6000531")]
	private static ListPool`1() { }

	[Address(RVA = "0xB0CBD0", Offset = "0xB0BFD0", Length = "0xC6")]
	[Token(Token = "0x600052E")]
	public static List<T> Get() { }

	[Address(RVA = "0xB0C890", Offset = "0xB0BC90", Length = "0xF4")]
	[Token(Token = "0x600052F")]
	public static PooledObject<List<T>> Get(out List<T>& value) { }

	[Address(RVA = "0xB0CCA0", Offset = "0xB0C0A0", Length = "0xD6")]
	[Token(Token = "0x6000530")]
	public static void Release(List<T> toRelease) { }

}

