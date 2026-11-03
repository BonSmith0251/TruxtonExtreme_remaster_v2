namespace UnityEngine.Rendering;

[Token(Token = "0x2000059")]
public static class HashSetPool
{
	[CompilerGenerated]
	[Token(Token = "0x200005A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000147")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000539")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600053A")]
		public <>c() { }

		[Address(RVA = "0xA36A20", Offset = "0xA35E20", Length = "0x2C")]
		[Token(Token = "0x600053B")]
		internal void <.cctor>b__4_0(HashSet<T> l) { }

	}

	[Token(Token = "0x4000146")]
	private static readonly ObjectPool<HashSet`1<T>> s_Pool; //Field offset: 0x0

	[Address(RVA = "0xB0CEA0", Offset = "0xB0C2A0", Length = "0x21E")]
	[Token(Token = "0x6000538")]
	private static HashSetPool`1() { }

	[Address(RVA = "0xB0CBD0", Offset = "0xB0BFD0", Length = "0xC6")]
	[Token(Token = "0x6000535")]
	public static HashSet<T> Get() { }

	[Address(RVA = "0xB0C890", Offset = "0xB0BC90", Length = "0xF4")]
	[Token(Token = "0x6000536")]
	public static PooledObject<HashSet<T>> Get(out HashSet<T>& value) { }

	[Address(RVA = "0xB0CCA0", Offset = "0xB0C0A0", Length = "0xD6")]
	[Token(Token = "0x6000537")]
	public static void Release(HashSet<T> toRelease) { }

}

