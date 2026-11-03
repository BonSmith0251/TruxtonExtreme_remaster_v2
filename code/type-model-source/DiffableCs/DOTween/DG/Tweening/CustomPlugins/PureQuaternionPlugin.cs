namespace DG.Tweening.CustomPlugins;

[Token(Token = "0x200009D")]
public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions>
{
	[Token(Token = "0x40001BD")]
	private static PureQuaternionPlugin _plug; //Field offset: 0x0

	[Address(RVA = "0x66FB80", Offset = "0x66EF80", Length = "0x39")]
	[Token(Token = "0x60003AA")]
	public PureQuaternionPlugin() { }

	[Address(RVA = "0x665350", Offset = "0x664750", Length = "0xB")]
	[Token(Token = "0x60003A5")]
	public virtual Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value) { }

	[Address(RVA = "0x66F1E0", Offset = "0x66E5E0", Length = "0xCB")]
	[Token(Token = "0x60003A9")]
	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x66F2B0", Offset = "0x66E6B0", Length = "0x10C")]
	[Token(Token = "0x60003A8")]
	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue) { }

	[Address(RVA = "0x66F3C0", Offset = "0x66E7C0", Length = "0xAE")]
	[Token(Token = "0x60003A1")]
	public static PureQuaternionPlugin Plug() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003A2")]
	public virtual void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

	[Address(RVA = "0x66F470", Offset = "0x66E870", Length = "0x21")]
	[Token(Token = "0x60003A7")]
	public virtual void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

	[Address(RVA = "0x66F7E0", Offset = "0x66EBE0", Length = "0x210")]
	[Token(Token = "0x60003A3")]
	public virtual void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative) { }

	[Address(RVA = "0x66F4A0", Offset = "0x66E8A0", Length = "0x332")]
	[Token(Token = "0x60003A4")]
	public virtual void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x66FA00", Offset = "0x66EE00", Length = "0x17C")]
	[Token(Token = "0x60003A6")]
	public virtual void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

}

