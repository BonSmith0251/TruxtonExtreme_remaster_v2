namespace DG.Tweening.Plugins;

[Token(Token = "0x200007B")]
public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions>
{

	[Address(RVA = "0x671350", Offset = "0x670750", Length = "0x39")]
	[Token(Token = "0x6000307")]
	public QuaternionPlugin() { }

	[Address(RVA = "0x66FC50", Offset = "0x66F050", Length = "0x7E")]
	[Token(Token = "0x6000302")]
	public virtual Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value) { }

	[Address(RVA = "0x66FCD0", Offset = "0x66F0D0", Length = "0xA17")]
	[Token(Token = "0x6000306")]
	public virtual void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x6706F0", Offset = "0x66FAF0", Length = "0x24")]
	[Token(Token = "0x6000305")]
	public virtual float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002FF")]
	public virtual void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	[Address(RVA = "0x670720", Offset = "0x66FB20", Length = "0x1EE")]
	[Token(Token = "0x6000304")]
	public virtual void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	[Address(RVA = "0x670910", Offset = "0x66FD10", Length = "0x7DD")]
	[Token(Token = "0x6000300")]
	public virtual void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative) { }

	[Address(RVA = "0x6710F0", Offset = "0x6704F0", Length = "0x1F5")]
	[Token(Token = "0x6000301")]
	public virtual void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x6712F0", Offset = "0x6706F0", Length = "0x5F")]
	[Token(Token = "0x6000303")]
	public virtual void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

}

