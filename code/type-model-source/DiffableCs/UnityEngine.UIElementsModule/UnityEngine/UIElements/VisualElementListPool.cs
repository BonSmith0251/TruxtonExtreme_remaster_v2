namespace UnityEngine.UIElements;

[Token(Token = "0x200053C")]
internal static class VisualElementListPool
{
	[CompilerGenerated]
	[Token(Token = "0x200053D")]
	private sealed class <>c
	{
		[Token(Token = "0x400116C")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x32BB7D0", Offset = "0x32BABD0", Length = "0x67")]
		[Token(Token = "0x6002693")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002694")]
		public <>c() { }

		[Address(RVA = "0x32BAFF0", Offset = "0x32BA3F0", Length = "0x55")]
		[Token(Token = "0x6002695")]
		internal List<VisualElement> <.cctor>b__4_0() { }

	}

	[Token(Token = "0x400116B")]
	private static ObjectPool<List`1<VisualElement>> pool; //Field offset: 0x0

	[Address(RVA = "0x32CDF30", Offset = "0x32CD330", Length = "0x107")]
	[Token(Token = "0x6002692")]
	private static VisualElementListPool() { }

	[Address(RVA = "0x32CDD00", Offset = "0x32CD100", Length = "0xA9")]
	[Token(Token = "0x600268F")]
	public static List<VisualElement> Copy(List<VisualElement> elements) { }

	[Address(RVA = "0x32CDDB0", Offset = "0x32CD1B0", Length = "0xCA")]
	[Token(Token = "0x6002690")]
	public static List<VisualElement> Get(int initialCapacity = 0) { }

	[Address(RVA = "0x32CDE80", Offset = "0x32CD280", Length = "0xAA")]
	[Token(Token = "0x6002691")]
	public static void Release(List<VisualElement> elements) { }

}

