namespace DG.Tweening.Plugins;

[Token(Token = "0x200007A")]
public class IntPlugin : ABSTweenPlugin<Int32, Int32, NoOptions>
{

	[Address(RVA = "0x66A2F0", Offset = "0x6696F0", Length = "0x39")]
	[Token(Token = "0x60002FE")]
	public IntPlugin() { }

	[Address(RVA = "0x669FD0", Offset = "0x6693D0", Length = "0x4")]
	[Token(Token = "0x60002F9")]
	public virtual int ConvertToStartValue(TweenerCore<Int32, Int32, NoOptions> t, int value) { }

	[Address(RVA = "0x669FE0", Offset = "0x6693E0", Length = "0x17D")]
	[Token(Token = "0x60002FD")]
	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Int32> getter, DOSetter<Int32> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x66A160", Offset = "0x669560", Length = "0x1C")]
	[Token(Token = "0x60002FC")]
	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002F6")]
	public virtual void Reset(TweenerCore<Int32, Int32, NoOptions> t) { }

	[Address(RVA = "0x66A180", Offset = "0x669580", Length = "0x25")]
	[Token(Token = "0x60002FB")]
	public virtual void SetChangeValue(TweenerCore<Int32, Int32, NoOptions> t) { }

	[Address(RVA = "0x66A240", Offset = "0x669640", Length = "0x7F")]
	[Token(Token = "0x60002F7")]
	public virtual void SetFrom(TweenerCore<Int32, Int32, NoOptions> t, bool isRelative) { }

	[Address(RVA = "0x66A1B0", Offset = "0x6695B0", Length = "0x8A")]
	[Token(Token = "0x60002F8")]
	public virtual void SetFrom(TweenerCore<Int32, Int32, NoOptions> t, int fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x66A2C0", Offset = "0x6696C0", Length = "0x25")]
	[Token(Token = "0x60002FA")]
	public virtual void SetRelativeEndValue(TweenerCore<Int32, Int32, NoOptions> t) { }

}

