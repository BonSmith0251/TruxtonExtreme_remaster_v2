namespace DG.Tweening.Plugins;

[Token(Token = "0x2000078")]
public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
{
	[Token(Token = "0x4000158")]
	public const float MinLookAhead = 0.0001; //Field offset: 0x0

	[Address(RVA = "0x66CFE0", Offset = "0x66C3E0", Length = "0x39")]
	[Token(Token = "0x60002EC")]
	public PathPlugin() { }

	[Address(RVA = "0x66AD50", Offset = "0x66A150", Length = "0x1A")]
	[Token(Token = "0x60002E4")]
	public virtual Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value) { }

	[Address(RVA = "0x66AD70", Offset = "0x66A170", Length = "0x34")]
	[Token(Token = "0x60002EA")]
	private Vector3 DivideVectorByVector(Vector3 vector, Vector3 byVector) { }

	[Address(RVA = "0x66ADB0", Offset = "0x66A1B0", Length = "0x471")]
	[Token(Token = "0x60002E8")]
	public virtual void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x66B250", Offset = "0x66A650", Length = "0x30")]
	[Token(Token = "0x60002E3")]
	public static ABSTweenPlugin<Vector3, Path, PathOptions> Get() { }

	[Address(RVA = "0x66B230", Offset = "0x66A630", Length = "0x1D")]
	[Token(Token = "0x60002E7")]
	public virtual float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue) { }

	[Address(RVA = "0x66B280", Offset = "0x66A680", Length = "0x34")]
	[Token(Token = "0x60002EB")]
	private Vector3 MultiplyVectorByVector(Vector3 vector, Vector3 byVector) { }

	[Address(RVA = "0x66B2C0", Offset = "0x66A6C0", Length = "0x76")]
	[Token(Token = "0x60002E0")]
	public virtual void Reset(TweenerCore<Vector3, Path, PathOptions> t) { }

	[Address(RVA = "0x66B340", Offset = "0x66A740", Length = "0x695")]
	[Token(Token = "0x60002E6")]
	public virtual void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002E1")]
	public virtual void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002E2")]
	public virtual void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x66B9E0", Offset = "0x66ADE0", Length = "0x14CA")]
	[Token(Token = "0x60002E9")]
	public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice) { }

	[Address(RVA = "0x66CEB0", Offset = "0x66C2B0", Length = "0x123")]
	[Token(Token = "0x60002E5")]
	public virtual void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t) { }

}

