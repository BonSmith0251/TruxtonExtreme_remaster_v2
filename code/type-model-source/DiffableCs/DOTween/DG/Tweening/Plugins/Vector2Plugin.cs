namespace DG.Tweening.Plugins;

[Token(Token = "0x200007F")]
public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions>
{

	[Address(RVA = "0x67C450", Offset = "0x67B850", Length = "0x39")]
	[Token(Token = "0x600032C")]
	public Vector2Plugin() { }

	[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
	[Token(Token = "0x6000327")]
	public virtual Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value) { }

	[Address(RVA = "0x67BC00", Offset = "0x67B000", Length = "0x37B")]
	[Token(Token = "0x600032B")]
	public virtual void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x67BF80", Offset = "0x67B380", Length = "0x96")]
	[Token(Token = "0x600032A")]
	public virtual float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000324")]
	public virtual void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

	[Address(RVA = "0x67C020", Offset = "0x67B420", Length = "0xA5")]
	[Token(Token = "0x6000329")]
	public virtual void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

	[Address(RVA = "0x67C290", Offset = "0x67B690", Length = "0x165")]
	[Token(Token = "0x6000325")]
	public virtual void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative) { }

	[Address(RVA = "0x67C0D0", Offset = "0x67B4D0", Length = "0x1BB")]
	[Token(Token = "0x6000326")]
	public virtual void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x67C400", Offset = "0x67B800", Length = "0x43")]
	[Token(Token = "0x6000328")]
	public virtual void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

}

