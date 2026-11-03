namespace DG.Tweening.Plugins;

[Token(Token = "0x2000079")]
public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions>
{

	[Address(RVA = "0x665B20", Offset = "0x664F20", Length = "0x39")]
	[Token(Token = "0x60002F5")]
	public ColorPlugin() { }

	[Address(RVA = "0x665350", Offset = "0x664750", Length = "0xB")]
	[Token(Token = "0x60002F0")]
	public virtual Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value) { }

	[Address(RVA = "0x665360", Offset = "0x664760", Length = "0x348")]
	[Token(Token = "0x60002F4")]
	public virtual void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x6485C0", Offset = "0x6479C0", Length = "0xD")]
	[Token(Token = "0x60002F3")]
	public virtual float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002ED")]
	public virtual void Reset(TweenerCore<Color, Color, ColorOptions> t) { }

	[Address(RVA = "0x6656B0", Offset = "0x664AB0", Length = "0x7B")]
	[Token(Token = "0x60002F2")]
	public virtual void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t) { }

	[Address(RVA = "0x665730", Offset = "0x664B30", Length = "0x151")]
	[Token(Token = "0x60002EE")]
	public virtual void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative) { }

	[Address(RVA = "0x665890", Offset = "0x664C90", Length = "0x20E")]
	[Token(Token = "0x60002EF")]
	public virtual void SetFrom(TweenerCore<Color, Color, ColorOptions> t, Color fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x665AA0", Offset = "0x664EA0", Length = "0x7B")]
	[Token(Token = "0x60002F1")]
	public virtual void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t) { }

}

