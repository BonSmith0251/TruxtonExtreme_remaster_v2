namespace DG.Tweening.Core.Easing;

[Token(Token = "0x20000C3")]
public class EaseCurve
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A4")]
	private readonly AnimationCurve _animCurve; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000489")]
	public EaseCurve(AnimationCurve animCurve) { }

	[Address(RVA = "0x67F620", Offset = "0x67EA20", Length = "0xBC")]
	[Token(Token = "0x600048A")]
	public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod) { }

}

