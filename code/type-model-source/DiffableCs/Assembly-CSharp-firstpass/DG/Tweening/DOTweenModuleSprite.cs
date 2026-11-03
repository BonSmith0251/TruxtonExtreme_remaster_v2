namespace DG.Tweening;

[Extension]
[Token(Token = "0x200001E")]
public static class DOTweenModuleSprite
{
	[CompilerGenerated]
	[Token(Token = "0x200001F")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002E")]
		public SpriteRenderer target; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600006A")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x5D0E30", Offset = "0x5D0230", Length = "0x33")]
		[Token(Token = "0x600006B")]
		internal Color <DOColor>b__0() { }

		[Address(RVA = "0x5D0E70", Offset = "0x5D0270", Length = "0x2C")]
		[Token(Token = "0x600006C")]
		internal void <DOColor>b__1(Color x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002F")]
		public SpriteRenderer target; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600006D")]
		public <>c__DisplayClass1_0() { }

		[Address(RVA = "0x5D0E30", Offset = "0x5D0230", Length = "0x33")]
		[Token(Token = "0x600006E")]
		internal Color <DOFade>b__0() { }

		[Address(RVA = "0x5D0E70", Offset = "0x5D0270", Length = "0x2C")]
		[Token(Token = "0x600006F")]
		internal void <DOFade>b__1(Color x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000030")]
		public Color to; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000031")]
		public SpriteRenderer target; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000070")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x6000071")]
		internal Color <DOBlendableColor>b__0() { }

		[Address(RVA = "0x5D1990", Offset = "0x5D0D90", Length = "0x105")]
		[Token(Token = "0x6000072")]
		internal void <DOBlendableColor>b__1(Color x) { }

	}


	[Address(RVA = "0x5C9240", Offset = "0x5C8640", Length = "0x1FE")]
	[Extension]
	[Token(Token = "0x6000069")]
	public static Tweener DOBlendableColor(SpriteRenderer target, Color endValue, float duration) { }

	[Address(RVA = "0x5C9440", Offset = "0x5C8840", Length = "0x171")]
	[Extension]
	[Token(Token = "0x6000066")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(SpriteRenderer target, Color endValue, float duration) { }

	[Address(RVA = "0x5C95C0", Offset = "0x5C89C0", Length = "0x167")]
	[Extension]
	[Token(Token = "0x6000067")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(SpriteRenderer target, float endValue, float duration) { }

	[Address(RVA = "0x5C9730", Offset = "0x5C8B30", Length = "0x20F")]
	[Extension]
	[Token(Token = "0x6000068")]
	public static Sequence DOGradientColor(SpriteRenderer target, Gradient gradient, float duration) { }

}

