namespace DG.Tweening.Plugins;

[Token(Token = "0x200007D")]
public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions>
{

	[Address(RVA = "0x672E00", Offset = "0x672200", Length = "0x39")]
	[Token(Token = "0x600031A")]
	public RectPlugin() { }

	[Address(RVA = "0x665350", Offset = "0x664750", Length = "0xB")]
	[Token(Token = "0x6000315")]
	public virtual Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value) { }

	[Address(RVA = "0x6723D0", Offset = "0x6717D0", Length = "0x385")]
	[Token(Token = "0x6000319")]
	public virtual void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x672760", Offset = "0x671B60", Length = "0xBE")]
	[Token(Token = "0x6000318")]
	public virtual float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000312")]
	public virtual void Reset(TweenerCore<Rect, Rect, RectOptions> t) { }

	[Address(RVA = "0x672820", Offset = "0x671C20", Length = "0xAD")]
	[Token(Token = "0x6000317")]
	public virtual void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t) { }

	[Address(RVA = "0x6728D0", Offset = "0x671CD0", Length = "0x21E")]
	[Token(Token = "0x6000313")]
	public virtual void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative) { }

	[Address(RVA = "0x672AF0", Offset = "0x671EF0", Length = "0x252")]
	[Token(Token = "0x6000314")]
	public virtual void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x672D50", Offset = "0x672150", Length = "0xAA")]
	[Token(Token = "0x6000316")]
	public virtual void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t) { }

}

