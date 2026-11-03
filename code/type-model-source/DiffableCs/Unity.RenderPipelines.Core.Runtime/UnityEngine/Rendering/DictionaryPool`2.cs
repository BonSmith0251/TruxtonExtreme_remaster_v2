namespace UnityEngine.Rendering;

[Token(Token = "0x200005B")]
public static class DictionaryPool
{
	[CompilerGenerated]
	[Token(Token = "0x200005C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000149")]
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0

		[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
		[Token(Token = "0x6000540")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000541")]
		public <>c() { }

		[Address(RVA = "0xA36440", Offset = "0xA35840", Length = "0x2D")]
		[Token(Token = "0x6000542")]
		internal void <.cctor>b__4_0(Dictionary<TKey, TValue> l) { }

	}

	[Token(Token = "0x4000148")]
	private static readonly ObjectPool<Dictionary`2<TKey, TValue>> s_Pool; //Field offset: 0x0

	[Address(RVA = "0xB0D0C0", Offset = "0xB0C4C0", Length = "0x26A")]
	[Token(Token = "0x600053F")]
	private static DictionaryPool`2() { }

	[Address(RVA = "0xB0CAC0", Offset = "0xB0BEC0", Length = "0x10A")]
	[Token(Token = "0x600053C")]
	public static Dictionary<TKey, TValue> Get() { }

	[Address(RVA = "0xB0C990", Offset = "0xB0BD90", Length = "0x128")]
	[Token(Token = "0x600053D")]
	public static PooledObject<Dictionary<TKey, TValue>> Get(out Dictionary<TKey, TValue>& value) { }

	[Address(RVA = "0xB0CD80", Offset = "0xB0C180", Length = "0x114")]
	[Token(Token = "0x600053E")]
	public static void Release(Dictionary<TKey, TValue> toRelease) { }

}

