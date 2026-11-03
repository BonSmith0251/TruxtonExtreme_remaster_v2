namespace DG.Tweening.Plugins;

[Token(Token = "0x2000075")]
public class LongPlugin : ABSTweenPlugin<Int64, Int64, NoOptions>
{

	[Address(RVA = "0x66ABF0", Offset = "0x669FF0", Length = "0x39")]
	[Token(Token = "0x60002CD")]
	public LongPlugin() { }

	[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
	[Token(Token = "0x60002C8")]
	public virtual long ConvertToStartValue(TweenerCore<Int64, Int64, NoOptions> t, long value) { }

	[Address(RVA = "0x66A8C0", Offset = "0x669CC0", Length = "0x18F")]
	[Token(Token = "0x60002CC")]
	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Int64> getter, DOSetter<Int64> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x66AA50", Offset = "0x669E50", Length = "0x1C")]
	[Token(Token = "0x60002CB")]
	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002C5")]
	public virtual void Reset(TweenerCore<Int64, Int64, NoOptions> t) { }

	[Address(RVA = "0x66AA70", Offset = "0x669E70", Length = "0x28")]
	[Token(Token = "0x60002CA")]
	public virtual void SetChangeValue(TweenerCore<Int64, Int64, NoOptions> t) { }

	[Address(RVA = "0x66AAA0", Offset = "0x669EA0", Length = "0x84")]
	[Token(Token = "0x60002C6")]
	public virtual void SetFrom(TweenerCore<Int64, Int64, NoOptions> t, bool isRelative) { }

	[Address(RVA = "0x66AB30", Offset = "0x669F30", Length = "0x8E")]
	[Token(Token = "0x60002C7")]
	public virtual void SetFrom(TweenerCore<Int64, Int64, NoOptions> t, long fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x66ABC0", Offset = "0x669FC0", Length = "0x28")]
	[Token(Token = "0x60002C9")]
	public virtual void SetRelativeEndValue(TweenerCore<Int64, Int64, NoOptions> t) { }

}

