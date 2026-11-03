namespace DG.Tweening.Plugins;

[Token(Token = "0x2000083")]
public class FloatPlugin : ABSTweenPlugin<Single, Single, FloatOptions>
{

	[Address(RVA = "0x669F90", Offset = "0x669390", Length = "0x39")]
	[Token(Token = "0x600034D")]
	public FloatPlugin() { }

	[Address(RVA = "0x6697F0", Offset = "0x668BF0", Length = "0x4")]
	[Token(Token = "0x6000348")]
	public virtual float ConvertToStartValue(TweenerCore<Single, Single, FloatOptions> t, float value) { }

	[Address(RVA = "0x669B50", Offset = "0x668F50", Length = "0x1C3")]
	[Token(Token = "0x600034C")]
	public virtual void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<Single> getter, DOSetter<Single> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x669D20", Offset = "0x669120", Length = "0x17")]
	[Token(Token = "0x600034B")]
	public virtual float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000345")]
	public virtual void Reset(TweenerCore<Single, Single, FloatOptions> t) { }

	[Address(RVA = "0x669D40", Offset = "0x669140", Length = "0x2B")]
	[Token(Token = "0x600034A")]
	public virtual void SetChangeValue(TweenerCore<Single, Single, FloatOptions> t) { }

	[Address(RVA = "0x669D70", Offset = "0x669170", Length = "0xE1")]
	[Token(Token = "0x6000346")]
	public virtual void SetFrom(TweenerCore<Single, Single, FloatOptions> t, bool isRelative) { }

	[Address(RVA = "0x669E60", Offset = "0x669260", Length = "0xF1")]
	[Token(Token = "0x6000347")]
	public virtual void SetFrom(TweenerCore<Single, Single, FloatOptions> t, float fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x669F60", Offset = "0x669360", Length = "0x2B")]
	[Token(Token = "0x6000349")]
	public virtual void SetRelativeEndValue(TweenerCore<Single, Single, FloatOptions> t) { }

}

