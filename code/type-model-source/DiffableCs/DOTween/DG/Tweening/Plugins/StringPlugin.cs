namespace DG.Tweening.Plugins;

[Token(Token = "0x2000081")]
public class StringPlugin : ABSTweenPlugin<String, String, StringOptions>
{
	[Token(Token = "0x400015A")]
	private static readonly StringBuilder _Buffer; //Field offset: 0x0
	[Token(Token = "0x400015B")]
	private static readonly List<Char> _OpenedTags; //Field offset: 0x8

	[Address(RVA = "0x674FB0", Offset = "0x6743B0", Length = "0xD5")]
	[Token(Token = "0x6000341")]
	private static StringPlugin() { }

	[Address(RVA = "0x675090", Offset = "0x674490", Length = "0x39")]
	[Token(Token = "0x6000340")]
	public StringPlugin() { }

	[Address(RVA = "0x673CB0", Offset = "0x6730B0", Length = "0x760")]
	[Token(Token = "0x600033E")]
	private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled) { }

	[Address(RVA = "0x647940", Offset = "0x646D40", Length = "0x4")]
	[Token(Token = "0x6000339")]
	public virtual string ConvertToStartValue(TweenerCore<String, String, StringOptions> t, string value) { }

	[Address(RVA = "0x674420", Offset = "0x673820", Length = "0x584")]
	[Token(Token = "0x600033D")]
	public virtual void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<String> getter, DOSetter<String> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[Address(RVA = "0x6749B0", Offset = "0x673DB0", Length = "0x52")]
	[Token(Token = "0x600033C")]
	public virtual float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue) { }

	[Address(RVA = "0x674A10", Offset = "0x673E10", Length = "0x86")]
	[Token(Token = "0x6000338")]
	public virtual void Reset(TweenerCore<String, String, StringOptions> t) { }

	[Address(RVA = "0x674AA0", Offset = "0x673EA0", Length = "0x10D")]
	[Token(Token = "0x600033F")]
	private Char[] ScrambledCharsToUse(StringOptions options) { }

	[Address(RVA = "0x674BB0", Offset = "0x673FB0", Length = "0x287")]
	[Token(Token = "0x600033B")]
	public virtual void SetChangeValue(TweenerCore<String, String, StringOptions> t) { }

	[Address(RVA = "0x674F10", Offset = "0x674310", Length = "0x90")]
	[Token(Token = "0x6000336")]
	public virtual void SetFrom(TweenerCore<String, String, StringOptions> t, bool isRelative) { }

	[Address(RVA = "0x674E40", Offset = "0x674240", Length = "0xCB")]
	[Token(Token = "0x6000337")]
	public virtual void SetFrom(TweenerCore<String, String, StringOptions> t, string fromValue, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600033A")]
	public virtual void SetRelativeEndValue(TweenerCore<String, String, StringOptions> t) { }

}

