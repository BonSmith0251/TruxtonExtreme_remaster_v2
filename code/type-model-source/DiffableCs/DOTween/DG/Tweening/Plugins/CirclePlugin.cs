namespace DG.Tweening.Plugins;

[Token(Token = "0x2000072")]
public class CirclePlugin : ABSTweenPlugin<Vector2, Vector2, CircleOptions>
{

	[Address(RVA = "0x648000", Offset = "0x647400", Length = "0x39")]
	[Token(Token = "0x60002B2")]
	public CirclePlugin() { }

	[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
	[Token(Token = "0x60002AC")]
	public virtual Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 value) { }

	[Address(RVA = "0x647950", Offset = "0x646D50", Length = "0x19B")]
	[Token(Token = "0x60002B0")]
	public virtual void EvaluateAndApply(CircleOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x647BF0", Offset = "0x646FF0", Length = "0x30")]
	[Token(Token = "0x60002AB")]
	public static ABSTweenPlugin<Vector2, Vector2, CircleOptions> Get() { }

	[Address(RVA = "0x647AF0", Offset = "0x646EF0", Length = "0xE0")]
	[Token(Token = "0x60002B1")]
	public Vector2 GetPositionOnCircle(CircleOptions options, float degrees) { }

	[Address(RVA = "0x647BD0", Offset = "0x646FD0", Length = "0x16")]
	[Token(Token = "0x60002AF")]
	public virtual float GetSpeedBasedDuration(CircleOptions options, float unitsXSecond, Vector2 changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002A8")]
	public virtual void Reset(TweenerCore<Vector2, Vector2, CircleOptions> t) { }

	[Address(RVA = "0x647C20", Offset = "0x647020", Length = "0x83")]
	[Token(Token = "0x60002AE")]
	public virtual void SetChangeValue(TweenerCore<Vector2, Vector2, CircleOptions> t) { }

	[Address(RVA = "0x647E20", Offset = "0x647220", Length = "0x156")]
	[Token(Token = "0x60002A9")]
	public virtual void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, bool isRelative) { }

	[Address(RVA = "0x647CB0", Offset = "0x6470B0", Length = "0x16C")]
	[Token(Token = "0x60002AA")]
	public virtual void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x647F80", Offset = "0x647380", Length = "0x79")]
	[Token(Token = "0x60002AD")]
	public virtual void SetRelativeEndValue(TweenerCore<Vector2, Vector2, CircleOptions> t) { }

}

