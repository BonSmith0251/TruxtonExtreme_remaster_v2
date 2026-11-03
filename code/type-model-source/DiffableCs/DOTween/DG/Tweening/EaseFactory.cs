namespace DG.Tweening;

[Token(Token = "0x2000012")]
public class EaseFactory
{
	[CompilerGenerated]
	[Token(Token = "0x2000013")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005E")]
		public float motionDelay; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005F")]
		public EaseFunction customEase; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600008A")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x662020", Offset = "0x661420", Length = "0x7D")]
		[Token(Token = "0x600008B")]
		internal float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period) { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000089")]
	public EaseFactory() { }

	[Address(RVA = "0x64F300", Offset = "0x64E700", Length = "0xA1")]
	[Token(Token = "0x6000086")]
	public static EaseFunction StopMotion(int motionFps, Nullable<Ease> ease = null) { }

	[Address(RVA = "0x64F3B0", Offset = "0x64E7B0", Length = "0x128")]
	[Token(Token = "0x6000087")]
	public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve) { }

	[Address(RVA = "0x64F1D0", Offset = "0x64E5D0", Length = "0x127")]
	[Token(Token = "0x6000088")]
	public static EaseFunction StopMotion(int motionFps, EaseFunction customEase) { }

}

