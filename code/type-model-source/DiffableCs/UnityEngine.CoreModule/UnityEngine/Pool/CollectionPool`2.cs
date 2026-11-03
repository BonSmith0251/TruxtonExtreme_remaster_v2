namespace UnityEngine.Pool;

[Token(Token = "0x20002FD")]
public class CollectionPool
{
	[CompilerGenerated]
	[Token(Token = "0x20002FE")]
	private sealed class <>c
	{
		[Token(Token = "0x40007ED")]
		public static readonly <>c<TCollection, TItem> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6001896")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001897")]
		public <>c() { }

		[Address(RVA = "0xA347A0", Offset = "0xA33BA0", Length = "0x14")]
		[Token(Token = "0x6001898")]
		internal TCollection <.cctor>b__5_0() { }

		[Address(RVA = "0xA36C40", Offset = "0xA36040", Length = "0x48")]
		[Token(Token = "0x6001899")]
		internal void <.cctor>b__5_1(TCollection l) { }

	}

	[Token(Token = "0x40007EC")]
	internal static readonly ObjectPool<TCollection> s_Pool; //Field offset: 0x0

	[Address(RVA = "0x16D2900", Offset = "0x16D1D00", Length = "0x314")]
	[Token(Token = "0x6001895")]
	private static CollectionPool`2() { }

	[Address(RVA = "0x16D2750", Offset = "0x16D1B50", Length = "0xC6")]
	[Token(Token = "0x6001892")]
	public static TCollection Get() { }

	[Address(RVA = "0x16D2650", Offset = "0x16D1A50", Length = "0xF4")]
	[Token(Token = "0x6001893")]
	public static PooledObject<TCollection> Get(out TCollection value) { }

	[Address(RVA = "0x16D2820", Offset = "0x16D1C20", Length = "0xD6")]
	[Token(Token = "0x6001894")]
	public static void Release(TCollection toRelease) { }

}

