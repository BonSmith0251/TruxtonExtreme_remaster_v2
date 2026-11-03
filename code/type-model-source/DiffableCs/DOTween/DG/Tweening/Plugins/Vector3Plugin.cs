namespace DG.Tweening.Plugins;

[Token(Token = "0x2000084")]
public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions>
{

	[Address(RVA = "0x67DBE0", Offset = "0x67CFE0", Length = "0x39")]
	[Token(Token = "0x6000356")]
	public Vector3Plugin() { }

	[Address(RVA = "0x67D130", Offset = "0x67C530", Length = "0x14")]
	[Token(Token = "0x6000351")]
	public virtual Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value) { }

	[Address(RVA = "0x67D150", Offset = "0x67C550", Length = "0x467")]
	[Token(Token = "0x6000355")]
	public virtual void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x6706F0", Offset = "0x66FAF0", Length = "0x24")]
	[Token(Token = "0x6000354")]
	public virtual float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600034E")]
	public virtual void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

	[Address(RVA = "0x67D5C0", Offset = "0x67C9C0", Length = "0xD9")]
	[Token(Token = "0x6000353")]
	public virtual void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

	[Address(RVA = "0x67D6A0", Offset = "0x67CAA0", Length = "0x23D")]
	[Token(Token = "0x600034F")]
	public virtual void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative) { }

	[Address(RVA = "0x67D8E0", Offset = "0x67CCE0", Length = "0x2FC")]
	[Token(Token = "0x6000350")]
	public virtual void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x6712F0", Offset = "0x6706F0", Length = "0x5F")]
	[Token(Token = "0x6000352")]
	public virtual void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

}

