namespace DG.Tweening;

[Token(Token = "0x200000C")]
public static class DOVirtual
{
	[CompilerGenerated]
	[Token(Token = "0x200000D")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002F")]
		public float val; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000030")]
		public TweenCallback<Single> onVirtualUpdate; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000076")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000077")]
		internal float <Float>b__0() { }

		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6000078")]
		internal void <Float>b__1(float x) { }

		[Address(RVA = "0x661860", Offset = "0x660C60", Length = "0x2D")]
		[Token(Token = "0x6000079")]
		internal void <Float>b__2() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000E")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000031")]
		public int val; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000032")]
		public TweenCallback<Int32> onVirtualUpdate; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600007A")]
		public <>c__DisplayClass1_0() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600007B")]
		internal int <Int>b__0() { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x600007C")]
		internal void <Int>b__1(int x) { }

		[Address(RVA = "0x661CB0", Offset = "0x6610B0", Length = "0x2B")]
		[Token(Token = "0x600007D")]
		internal void <Int>b__2() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000F")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000033")]
		public Vector3 val; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000034")]
		public TweenCallback<Vector3> onVirtualUpdate; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600007E")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
		[Token(Token = "0x600007F")]
		internal Vector3 <Vector3>b__0() { }

		[Address(RVA = "0x6620C0", Offset = "0x6614C0", Length = "0x10")]
		[Token(Token = "0x6000080")]
		internal void <Vector3>b__1(Vector3 x) { }

		[Address(RVA = "0x6620D0", Offset = "0x6614D0", Length = "0x3F")]
		[Token(Token = "0x6000081")]
		internal void <Vector3>b__2() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000010")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000035")]
		public Color val; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000036")]
		public TweenCallback<Color> onVirtualUpdate; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000082")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x6000083")]
		internal Color <Color>b__0() { }

		[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
		[Token(Token = "0x6000084")]
		internal void <Color>b__1(Color x) { }

		[Address(RVA = "0x6622C0", Offset = "0x6616C0", Length = "0x36")]
		[Token(Token = "0x6000085")]
		internal void <Color>b__2() { }

	}


	[Address(RVA = "0x64E410", Offset = "0x64D810", Length = "0x24A")]
	[Token(Token = "0x6000070")]
	public static Tweener Color(Color from, Color to, float duration, TweenCallback<Color> onVirtualUpdate) { }

	[Address(RVA = "0x64E660", Offset = "0x64DA60", Length = "0x117")]
	[Token(Token = "0x6000075")]
	public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true) { }

	[Address(RVA = "0x64E930", Offset = "0x64DD30", Length = "0xB8")]
	[Token(Token = "0x6000071")]
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType) { }

	[Address(RVA = "0x64E9F0", Offset = "0x64DDF0", Length = "0xBF")]
	[Token(Token = "0x6000072")]
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot) { }

	[Address(RVA = "0x64EAB0", Offset = "0x64DEB0", Length = "0x68")]
	[Token(Token = "0x6000073")]
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period) { }

	[Address(RVA = "0x64E780", Offset = "0x64DB80", Length = "0x1AE")]
	[Token(Token = "0x6000074")]
	public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve) { }

	[Address(RVA = "0x64EB20", Offset = "0x64DF20", Length = "0x20F")]
	[Token(Token = "0x600006D")]
	public static Tweener Float(float from, float to, float duration, TweenCallback<Single> onVirtualUpdate) { }

	[Address(RVA = "0x64ED30", Offset = "0x64E130", Length = "0x239")]
	[Token(Token = "0x600006E")]
	public static Tweener Int(int from, int to, float duration, TweenCallback<Int32> onVirtualUpdate) { }

	[Address(RVA = "0x64EF70", Offset = "0x64E370", Length = "0x25B")]
	[Token(Token = "0x600006F")]
	public static Tweener Vector3(Vector3 from, Vector3 to, float duration, TweenCallback<Vector3> onVirtualUpdate) { }

}

