namespace UnityEngine.UI;

[Token(Token = "0x2000052")]
public static class LayoutUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private sealed class <>c
	{
		[Token(Token = "0x400018F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000190")]
		public static Func<ILayoutElement, Single> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x4000191")]
		public static Func<ILayoutElement, Single> <>9__4_0; //Field offset: 0x10
		[Token(Token = "0x4000192")]
		public static Func<ILayoutElement, Single> <>9__4_1; //Field offset: 0x18
		[Token(Token = "0x4000193")]
		public static Func<ILayoutElement, Single> <>9__5_0; //Field offset: 0x20
		[Token(Token = "0x4000194")]
		public static Func<ILayoutElement, Single> <>9__6_0; //Field offset: 0x28
		[Token(Token = "0x4000195")]
		public static Func<ILayoutElement, Single> <>9__7_0; //Field offset: 0x30
		[Token(Token = "0x4000196")]
		public static Func<ILayoutElement, Single> <>9__7_1; //Field offset: 0x38
		[Token(Token = "0x4000197")]
		public static Func<ILayoutElement, Single> <>9__8_0; //Field offset: 0x40

		[Address(RVA = "0x344A570", Offset = "0x3449970", Length = "0x67")]
		[Token(Token = "0x600032F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000330")]
		public <>c() { }

		[Address(RVA = "0x344A000", Offset = "0x3449400", Length = "0x48")]
		[Token(Token = "0x6000338")]
		internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

		[Address(RVA = "0x344A050", Offset = "0x3449450", Length = "0x48")]
		[Token(Token = "0x6000334")]
		internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

		[Address(RVA = "0x344A0A0", Offset = "0x34494A0", Length = "0x48")]
		[Token(Token = "0x6000335")]
		internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

		[Address(RVA = "0x344A0F0", Offset = "0x34494F0", Length = "0x48")]
		[Token(Token = "0x6000331")]
		internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

		[Address(RVA = "0x344A140", Offset = "0x3449540", Length = "0x48")]
		[Token(Token = "0x6000336")]
		internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

		[Address(RVA = "0x344A190", Offset = "0x3449590", Length = "0x48")]
		[Token(Token = "0x6000337")]
		internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

		[Address(RVA = "0x344A1E0", Offset = "0x34495E0", Length = "0x48")]
		[Token(Token = "0x6000332")]
		internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

		[Address(RVA = "0x344A230", Offset = "0x3449630", Length = "0x48")]
		[Token(Token = "0x6000333")]
		internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	}


	[Address(RVA = "0x3445B10", Offset = "0x3444F10", Length = "0x10F")]
	[Token(Token = "0x600032C")]
	public static float GetFlexibleHeight(RectTransform rect) { }

	[Address(RVA = "0x3445C20", Offset = "0x3445020", Length = "0x1E5")]
	[Token(Token = "0x6000326")]
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	[Address(RVA = "0x3445E10", Offset = "0x3445210", Length = "0x10F")]
	[Token(Token = "0x6000329")]
	public static float GetFlexibleWidth(RectTransform rect) { }

	[Address(RVA = "0x3445F20", Offset = "0x3445320", Length = "0x1F")]
	[Token(Token = "0x600032D")]
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, Single> property, float defaultValue) { }

	[Address(RVA = "0x3445F40", Offset = "0x3445340", Length = "0x2D5")]
	[Token(Token = "0x600032E")]
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, Single> property, float defaultValue, out ILayoutElement source) { }

	[Address(RVA = "0x3446220", Offset = "0x3445620", Length = "0x10F")]
	[Token(Token = "0x600032A")]
	public static float GetMinHeight(RectTransform rect) { }

	[Address(RVA = "0x3446330", Offset = "0x3445730", Length = "0x1E5")]
	[Token(Token = "0x6000324")]
	public static float GetMinSize(RectTransform rect, int axis) { }

	[Address(RVA = "0x3446520", Offset = "0x3445920", Length = "0x10F")]
	[Token(Token = "0x6000327")]
	public static float GetMinWidth(RectTransform rect) { }

	[Address(RVA = "0x3446630", Offset = "0x3445A30", Length = "0x1EF")]
	[Token(Token = "0x600032B")]
	public static float GetPreferredHeight(RectTransform rect) { }

	[Address(RVA = "0x3446820", Offset = "0x3445C20", Length = "0x38C")]
	[Token(Token = "0x6000325")]
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	[Address(RVA = "0x3446BB0", Offset = "0x3445FB0", Length = "0x1EF")]
	[Token(Token = "0x6000328")]
	public static float GetPreferredWidth(RectTransform rect) { }

}

