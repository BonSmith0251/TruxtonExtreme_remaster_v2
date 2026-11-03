namespace DG.Tweening.Plugins;

[Token(Token = "0x2000074")]
public class DoublePlugin : ABSTweenPlugin<Double, Double, NoOptions>
{

	[Address(RVA = "0x669B10", Offset = "0x668F10", Length = "0x39")]
	[Token(Token = "0x60002C4")]
	public DoublePlugin() { }

	[Address(RVA = "0x6697F0", Offset = "0x668BF0", Length = "0x4")]
	[Token(Token = "0x60002BF")]
	public virtual double ConvertToStartValue(TweenerCore<Double, Double, NoOptions> t, double value) { }

	[Address(RVA = "0x669800", Offset = "0x668C00", Length = "0x152")]
	[Token(Token = "0x60002C3")]
	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Double> getter, DOSetter<Double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x669960", Offset = "0x668D60", Length = "0x1B")]
	[Token(Token = "0x60002C2")]
	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002BC")]
	public virtual void Reset(TweenerCore<Double, Double, NoOptions> t) { }

	[Address(RVA = "0x669980", Offset = "0x668D80", Length = "0x2B")]
	[Token(Token = "0x60002C1")]
	public virtual void SetChangeValue(TweenerCore<Double, Double, NoOptions> t) { }

	[Address(RVA = "0x6699B0", Offset = "0x668DB0", Length = "0x8D")]
	[Token(Token = "0x60002BD")]
	public virtual void SetFrom(TweenerCore<Double, Double, NoOptions> t, bool isRelative) { }

	[Address(RVA = "0x669A40", Offset = "0x668E40", Length = "0x9C")]
	[Token(Token = "0x60002BE")]
	public virtual void SetFrom(TweenerCore<Double, Double, NoOptions> t, double fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x669AE0", Offset = "0x668EE0", Length = "0x2B")]
	[Token(Token = "0x60002C0")]
	public virtual void SetRelativeEndValue(TweenerCore<Double, Double, NoOptions> t) { }

}

