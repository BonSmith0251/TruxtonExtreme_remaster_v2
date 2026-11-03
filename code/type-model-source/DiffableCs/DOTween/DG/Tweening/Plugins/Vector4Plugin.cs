namespace DG.Tweening.Plugins;

[Token(Token = "0x2000080")]
public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions>
{

	[Address(RVA = "0x67EA30", Offset = "0x67DE30", Length = "0x39")]
	[Token(Token = "0x6000335")]
	public Vector4Plugin() { }

	[Address(RVA = "0x665350", Offset = "0x664750", Length = "0xB")]
	[Token(Token = "0x6000330")]
	public virtual Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value) { }

	[Address(RVA = "0x67DC20", Offset = "0x67D020", Length = "0x588")]
	[Token(Token = "0x6000334")]
	public virtual void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x67E1B0", Offset = "0x67D5B0", Length = "0xA8")]
	[Token(Token = "0x6000333")]
	public virtual float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600032D")]
	public virtual void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

	[Address(RVA = "0x67E260", Offset = "0x67D660", Length = "0x194")]
	[Token(Token = "0x6000332")]
	public virtual void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

	[Address(RVA = "0x67E400", Offset = "0x67D800", Length = "0x289")]
	[Token(Token = "0x600032E")]
	public virtual void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative) { }

	[Address(RVA = "0x67E690", Offset = "0x67DA90", Length = "0x393")]
	[Token(Token = "0x600032F")]
	public virtual void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x665AA0", Offset = "0x664EA0", Length = "0x7B")]
	[Token(Token = "0x6000331")]
	public virtual void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

}

