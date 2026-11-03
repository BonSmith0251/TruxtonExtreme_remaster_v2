namespace DG.Tweening.Plugins;

[Token(Token = "0x2000073")]
internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions>
{

	[Address(RVA = "0x648DD0", Offset = "0x6481D0", Length = "0x39")]
	[Token(Token = "0x60002BB")]
	public Color2Plugin() { }

	[Address(RVA = "0x648040", Offset = "0x647440", Length = "0x14")]
	[Token(Token = "0x60002B6")]
	public virtual Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value) { }

	[Address(RVA = "0x648060", Offset = "0x647460", Length = "0x55F")]
	[Token(Token = "0x60002BA")]
	public virtual void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x6485C0", Offset = "0x6479C0", Length = "0xD")]
	[Token(Token = "0x60002B9")]
	public virtual float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002B3")]
	public virtual void Reset(TweenerCore<Color2, Color2, ColorOptions> t) { }

	[Address(RVA = "0x6485D0", Offset = "0x6479D0", Length = "0x126")]
	[Token(Token = "0x60002B8")]
	public virtual void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t) { }

	[Address(RVA = "0x648A50", Offset = "0x647E50", Length = "0x249")]
	[Token(Token = "0x60002B4")]
	public virtual void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative) { }

	[Address(RVA = "0x648700", Offset = "0x647B00", Length = "0x346")]
	[Token(Token = "0x60002B5")]
	public virtual void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, Color2 fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x648CA0", Offset = "0x6480A0", Length = "0x126")]
	[Token(Token = "0x60002B7")]
	public virtual void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t) { }

}

