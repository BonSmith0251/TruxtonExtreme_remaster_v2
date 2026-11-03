namespace DG.Tweening;

[Token(Token = "0x200006E")]
public abstract class Tweener : Tween
{
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000146")]
	internal bool hasManuallySetStartValue; //Field offset: 0x120
	[FieldOffset(Offset = "0x121")]
	[Token(Token = "0x4000147")]
	internal bool isFromAllowed; //Field offset: 0x121

	[Address(RVA = "0x6617D0", Offset = "0x660BD0", Length = "0x30")]
	[Token(Token = "0x6000298")]
	internal Tweener() { }

	[Token(Token = "0x600029A")]
	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	[Token(Token = "0x600029B")]
	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	[Token(Token = "0x6000299")]
	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	[Token(Token = "0x600029C")]
	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	[Address(RVA = "0x9538C0", Offset = "0x952CC0", Length = "0x383")]
	[Token(Token = "0x60002A2")]
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) { }

	[Address(RVA = "0x957D10", Offset = "0x957110", Length = "0x105")]
	[Token(Token = "0x60002A1")]
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) { }

	[Address(RVA = "0x959380", Offset = "0x958780", Length = "0x130")]
	[Token(Token = "0x60002A3")]
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) { }

	[Address(RVA = "0x95AFE0", Offset = "0x95A3E0", Length = "0x370")]
	[Token(Token = "0x60002A0")]
	internal static bool DoStartup(TweenerCore<T1, T2, TPlugOptions> t) { }

	[Address(RVA = "0x950750", Offset = "0x94FB50", Length = "0xB1")]
	[Token(Token = "0x60002A5")]
	private static void DOStartupDurationBased(TweenerCore<T1, T2, TPlugOptions> t) { }

	[Address(RVA = "0x9514F0", Offset = "0x9508F0", Length = "0x1AE")]
	[Token(Token = "0x60002A4")]
	private static bool DOStartupSpecials(TweenerCore<T1, T2, TPlugOptions> t) { }

	[Address(RVA = "0x95F150", Offset = "0x95E550", Length = "0x46")]
	[Token(Token = "0x600029F")]
	internal static float DoUpdateDelay(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) { }

	[Token(Token = "0x600029D")]
	internal abstract Tweener SetFrom(bool relative) { }

	[Address(RVA = "0x95F3E0", Offset = "0x95E7E0", Length = "0x226")]
	[Token(Token = "0x600029E")]
	internal static bool Setup(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) { }

}

