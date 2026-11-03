namespace DG.Tweening.Plugins;

[Token(Token = "0x2000077")]
public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions>
{

	[Address(RVA = "0x67D0F0", Offset = "0x67C4F0", Length = "0x39")]
	[Token(Token = "0x60002DF")]
	public Vector3ArrayPlugin() { }

	[Address(RVA = "0x67C4B0", Offset = "0x67B8B0", Length = "0x100")]
	[Token(Token = "0x60002DA")]
	public virtual Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value) { }

	[Address(RVA = "0x67C5C0", Offset = "0x67B9C0", Length = "0x742")]
	[Token(Token = "0x60002DE")]
	public virtual void EvaluateAndApply(Vector3ArrayOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x67CD10", Offset = "0x67C110", Length = "0x18C")]
	[Token(Token = "0x60002DD")]
	public virtual float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue) { }

	[Address(RVA = "0x671BE0", Offset = "0x670FE0", Length = "0x63")]
	[Token(Token = "0x60002D7")]
	public virtual void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	[Address(RVA = "0x67CEA0", Offset = "0x67C2A0", Length = "0x128")]
	[Token(Token = "0x60002DC")]
	public virtual void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002D8")]
	public virtual void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002D9")]
	public virtual void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3[] fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x67CFD0", Offset = "0x67C3D0", Length = "0x115")]
	[Token(Token = "0x60002DB")]
	public virtual void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

}

