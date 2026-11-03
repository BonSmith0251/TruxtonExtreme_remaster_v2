namespace UnityEngine.UIElements;

[Token(Token = "0x200053E")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class ObjectListPool
{
	[CompilerGenerated]
	[Token(Token = "0x200053F")]
	private sealed class <>c
	{
		[Token(Token = "0x400116E")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6002699")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600269A")]
		public <>c() { }

		[Address(RVA = "0xA36A50", Offset = "0xA35E50", Length = "0x5D")]
		[Token(Token = "0x600269B")]
		internal List<T> <.cctor>b__4_0() { }

	}

	[Token(Token = "0x400116D")]
	private static ObjectPool<List`1<T>> pool; //Field offset: 0x0

	[Address(RVA = "0xE0ACF0", Offset = "0xE0A0F0", Length = "0x21A")]
	[Token(Token = "0x6002698")]
	private static ObjectListPool`1() { }

	[Address(RVA = "0xE0A640", Offset = "0xE09A40", Length = "0x10C")]
	[Token(Token = "0x6002696")]
	public static List<T> Get() { }

	[Address(RVA = "0xE0A8C0", Offset = "0xE09CC0", Length = "0x1B2")]
	[Token(Token = "0x6002697")]
	public static void Release(List<T> elements) { }

}

