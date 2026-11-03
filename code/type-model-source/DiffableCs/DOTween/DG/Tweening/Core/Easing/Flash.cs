namespace DG.Tweening.Core.Easing;

[Token(Token = "0x20000C4")]
public static class Flash
{

	[Address(RVA = "0x682210", Offset = "0x681610", Length = "0x11A")]
	[Token(Token = "0x600048B")]
	public static float Ease(float time, float duration, float overshootOrAmplitude, float period) { }

	[Address(RVA = "0x681FB0", Offset = "0x6813B0", Length = "0x11E")]
	[Token(Token = "0x600048C")]
	public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period) { }

	[Address(RVA = "0x681E40", Offset = "0x681240", Length = "0x162")]
	[Token(Token = "0x600048E")]
	public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period) { }

	[Address(RVA = "0x6820D0", Offset = "0x6814D0", Length = "0x133")]
	[Token(Token = "0x600048D")]
	public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period) { }

	[Address(RVA = "0x682330", Offset = "0x681730", Length = "0x16F")]
	[Token(Token = "0x600048F")]
	private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res) { }

}

