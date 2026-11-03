namespace DG.Tweening.Plugins;

[Token(Token = "0x200007C")]
public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions>
{
	[Token(Token = "0x4000159")]
	private static RectOffset _r; //Field offset: 0x0

	[Address(RVA = "0x672310", Offset = "0x671710", Length = "0x73")]
	[Token(Token = "0x6000311")]
	private static RectOffsetPlugin() { }

	[Address(RVA = "0x672390", Offset = "0x671790", Length = "0x39")]
	[Token(Token = "0x6000310")]
	public RectOffsetPlugin() { }

	[Address(RVA = "0x671390", Offset = "0x670790", Length = "0xC2")]
	[Token(Token = "0x600030B")]
	public virtual RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value) { }

	[Address(RVA = "0x671460", Offset = "0x670860", Length = "0x67E")]
	[Token(Token = "0x600030F")]
	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x671AE0", Offset = "0x670EE0", Length = "0xF1")]
	[Token(Token = "0x600030E")]
	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue) { }

	[Address(RVA = "0x671BE0", Offset = "0x670FE0", Length = "0x63")]
	[Token(Token = "0x6000308")]
	public virtual void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t) { }

	[Address(RVA = "0x671C50", Offset = "0x671050", Length = "0x1A6")]
	[Token(Token = "0x600030D")]
	public virtual void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) { }

	[Address(RVA = "0x671E00", Offset = "0x671200", Length = "0x1A7")]
	[Token(Token = "0x6000309")]
	public virtual void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative) { }

	[Address(RVA = "0x671FB0", Offset = "0x6713B0", Length = "0x221")]
	[Token(Token = "0x600030A")]
	public virtual void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x6721E0", Offset = "0x6715E0", Length = "0x123")]
	[Token(Token = "0x600030C")]
	public virtual void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) { }

}

