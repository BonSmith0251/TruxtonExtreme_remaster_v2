namespace DG.Tweening.Core;

[Token(Token = "0x20000B7")]
public class TweenerCore : Tweener
{
	[Token(Token = "0x400024C")]
	private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000245")]
	public T2 startValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000246")]
	public T2 endValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000247")]
	public T2 changeValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000248")]
	public TPlugOptions plugOptions; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000249")]
	public DOGetter<T1> getter; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024A")]
	public DOSetter<T1> setter; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024B")]
	internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024D")]
	private Type _colorType; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024E")]
	private Type _color32Type; //Field offset: 0x0

	[Address(RVA = "0x10B3D80", Offset = "0x10B3180", Length = "0x158")]
	[Token(Token = "0x600044B")]
	internal TweenerCore`3() { }

	[Address(RVA = "0x10AC110", Offset = "0x10AB510", Length = "0x2FF")]
	[Token(Token = "0x600045B")]
	internal virtual bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	[Address(RVA = "0x10AD3D0", Offset = "0x10AC7D0", Length = "0x38")]
	[Token(Token = "0x600044D")]
	public virtual Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	[Address(RVA = "0x10AEB90", Offset = "0x10ADF90", Length = "0x392")]
	[Token(Token = "0x600044E")]
	public virtual Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	[Address(RVA = "0x10AD910", Offset = "0x10ACD10", Length = "0xB3")]
	[Token(Token = "0x6000451")]
	public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue) { }

	[Address(RVA = "0x10AD270", Offset = "0x10AC670", Length = "0xAA")]
	[Token(Token = "0x6000452")]
	public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	[Address(RVA = "0x10AF090", Offset = "0x10AE490", Length = "0x98")]
	[Token(Token = "0x6000450")]
	public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1) { }

	[Address(RVA = "0x10AF1C0", Offset = "0x10AE5C0", Length = "0x375")]
	[Token(Token = "0x600044C")]
	public virtual Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	[Address(RVA = "0x10B1CB0", Offset = "0x10B10B0", Length = "0x5B4")]
	[Token(Token = "0x600044F")]
	public virtual Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	[Address(RVA = "0x10B09B0", Offset = "0x10AFDB0", Length = "0xB2")]
	[Token(Token = "0x6000453")]
	public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1) { }

	[Address(RVA = "0x10B3090", Offset = "0x10B2490", Length = "0xA7")]
	[Token(Token = "0x6000456")]
	internal virtual void Reset() { }

	[Address(RVA = "0x10B34D0", Offset = "0x10B28D0", Length = "0x44")]
	[Token(Token = "0x6000454")]
	internal virtual Tweener SetFrom(bool relative) { }

	[Address(RVA = "0x10B3240", Offset = "0x10B2640", Length = "0x5C")]
	[Token(Token = "0x6000455")]
	internal Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative) { }

	[Address(RVA = "0x10B3540", Offset = "0x10B2940", Length = "0x17")]
	[Token(Token = "0x600045A")]
	internal virtual bool Startup() { }

	[Address(RVA = "0x10B35E0", Offset = "0x10B29E0", Length = "0x17")]
	[Token(Token = "0x6000459")]
	internal virtual float UpdateDelay(float elapsed) { }

	[Address(RVA = "0x10B3700", Offset = "0x10B2B00", Length = "0x38")]
	[Token(Token = "0x6000457")]
	internal virtual bool Validate() { }

	[Address(RVA = "0x10B3680", Offset = "0x10B2A80", Length = "0x37")]
	[Token(Token = "0x6000458")]
	private bool ValidateChangeValueType(Type newType, out bool isColor32ToColor) { }

}

