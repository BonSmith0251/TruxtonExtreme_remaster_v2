namespace DG.Tweening.Plugins;

[Token(Token = "0x200007E")]
public class UintPlugin : ABSTweenPlugin<UInt32, UInt32, UintOptions>
{

	[Address(RVA = "0x67B890", Offset = "0x67AC90", Length = "0x39")]
	[Token(Token = "0x6000323")]
	public UintPlugin() { }

	[Address(RVA = "0x669FD0", Offset = "0x6693D0", Length = "0x4")]
	[Token(Token = "0x600031E")]
	public virtual uint ConvertToStartValue(TweenerCore<UInt32, UInt32, UintOptions> t, uint value) { }

	[Address(RVA = "0x67B5C0", Offset = "0x67A9C0", Length = "0x1C0")]
	[Token(Token = "0x6000322")]
	public virtual void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<UInt32> getter, DOSetter<UInt32> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x67B790", Offset = "0x67AB90", Length = "0x23")]
	[Token(Token = "0x6000321")]
	public virtual float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600031B")]
	public virtual void Reset(TweenerCore<UInt32, UInt32, UintOptions> t) { }

	[Address(RVA = "0x67B7C0", Offset = "0x67ABC0", Length = "0x49")]
	[Token(Token = "0x6000320")]
	public virtual void SetChangeValue(TweenerCore<UInt32, UInt32, UintOptions> t) { }

	[Address(RVA = "0x67B810", Offset = "0x67AC10", Length = "0x7F")]
	[Token(Token = "0x600031C")]
	public virtual void SetFrom(TweenerCore<UInt32, UInt32, UintOptions> t, bool isRelative) { }

	[Address(RVA = "0x66A1B0", Offset = "0x6695B0", Length = "0x8A")]
	[Token(Token = "0x600031D")]
	public virtual void SetFrom(TweenerCore<UInt32, UInt32, UintOptions> t, uint fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x66A2C0", Offset = "0x6696C0", Length = "0x25")]
	[Token(Token = "0x600031F")]
	public virtual void SetRelativeEndValue(TweenerCore<UInt32, UInt32, UintOptions> t) { }

}

