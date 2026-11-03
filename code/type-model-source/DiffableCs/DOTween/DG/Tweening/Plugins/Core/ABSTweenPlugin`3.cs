namespace DG.Tweening.Plugins.Core;

[Token(Token = "0x2000095")]
public abstract class ABSTweenPlugin : ITweenPlugin
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000372")]
	protected ABSTweenPlugin`3() { }

	[Token(Token = "0x600036D")]
	public abstract T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value) { }

	[Token(Token = "0x6000371")]
	public abstract void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Token(Token = "0x6000370")]
	public abstract float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue) { }

	[Token(Token = "0x600036A")]
	public abstract void Reset(TweenerCore<T1, T2, TPlugOptions> t) { }

	[Token(Token = "0x600036F")]
	public abstract void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t) { }

	[Token(Token = "0x600036B")]
	public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative) { }

	[Token(Token = "0x600036C")]
	public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative) { }

	[Token(Token = "0x600036E")]
	public abstract void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t) { }

}

