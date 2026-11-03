namespace DG.Tweening.Plugins;

[Token(Token = "0x2000076")]
public class UlongPlugin : ABSTweenPlugin<UInt64, UInt64, NoOptions>
{

	[Address(RVA = "0x67BBC0", Offset = "0x67AFC0", Length = "0x39")]
	[Token(Token = "0x60002D6")]
	public UlongPlugin() { }

	[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
	[Token(Token = "0x60002D1")]
	public virtual ulong ConvertToStartValue(TweenerCore<UInt64, UInt64, NoOptions> t, ulong value) { }

	[Address(RVA = "0x67B8D0", Offset = "0x67ACD0", Length = "0x216")]
	[Token(Token = "0x60002D5")]
	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<UInt64> getter, DOSetter<UInt64> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x67BAF0", Offset = "0x67AEF0", Length = "0x3D")]
	[Token(Token = "0x60002D4")]
	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002CE")]
	public virtual void Reset(TweenerCore<UInt64, UInt64, NoOptions> t) { }

	[Address(RVA = "0x66AA70", Offset = "0x669E70", Length = "0x28")]
	[Token(Token = "0x60002D3")]
	public virtual void SetChangeValue(TweenerCore<UInt64, UInt64, NoOptions> t) { }

	[Address(RVA = "0x67BB30", Offset = "0x67AF30", Length = "0x84")]
	[Token(Token = "0x60002CF")]
	public virtual void SetFrom(TweenerCore<UInt64, UInt64, NoOptions> t, bool isRelative) { }

	[Address(RVA = "0x66AB30", Offset = "0x669F30", Length = "0x8E")]
	[Token(Token = "0x60002D0")]
	public virtual void SetFrom(TweenerCore<UInt64, UInt64, NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x66ABC0", Offset = "0x669FC0", Length = "0x28")]
	[Token(Token = "0x60002D2")]
	public virtual void SetRelativeEndValue(TweenerCore<UInt64, UInt64, NoOptions> t) { }

}

