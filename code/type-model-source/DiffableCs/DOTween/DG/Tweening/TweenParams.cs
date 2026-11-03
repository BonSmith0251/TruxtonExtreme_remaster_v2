namespace DG.Tweening;

[Token(Token = "0x200006A")]
public class TweenParams
{
	[Token(Token = "0x40000F7")]
	public static readonly TweenParams Params; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F8")]
	internal object id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000F9")]
	internal object target; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000FA")]
	internal UpdateType updateType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000FB")]
	internal bool isIndependentUpdate; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000FC")]
	internal TweenCallback onStart; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000FD")]
	internal TweenCallback onPlay; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000FE")]
	internal TweenCallback onRewind; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000FF")]
	internal TweenCallback onUpdate; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000100")]
	internal TweenCallback onStepComplete; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000101")]
	internal TweenCallback onComplete; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000102")]
	internal TweenCallback onKill; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000103")]
	internal TweenCallback<Int32> onWaypointChange; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000104")]
	internal bool isRecyclable; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000105")]
	internal bool isSpeedBased; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x4000106")]
	internal bool autoKill; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000107")]
	internal int loops; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000108")]
	internal LoopType loopType; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000109")]
	internal float delay; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400010A")]
	internal bool isRelative; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400010B")]
	internal Ease easeType; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400010C")]
	internal EaseFunction customEase; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400010D")]
	internal float easeOvershootOrAmplitude; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400010E")]
	internal float easePeriod; //Field offset: 0x8C

	[Address(RVA = "0x65F610", Offset = "0x65EA10", Length = "0x1FA")]
	[Token(Token = "0x6000233")]
	private static TweenParams() { }

	[Address(RVA = "0x65F810", Offset = "0x65EC10", Length = "0x1A9")]
	[Token(Token = "0x600021C")]
	public TweenParams() { }

	[Address(RVA = "0x65EF40", Offset = "0x65E340", Length = "0x1A5")]
	[Token(Token = "0x600021D")]
	public TweenParams Clear() { }

	[Address(RVA = "0x65F0F0", Offset = "0x65E4F0", Length = "0x1F")]
	[Token(Token = "0x600022D")]
	public TweenParams OnComplete(TweenCallback action) { }

	[Address(RVA = "0x65F110", Offset = "0x65E510", Length = "0x1F")]
	[Token(Token = "0x600022E")]
	public TweenParams OnKill(TweenCallback action) { }

	[Address(RVA = "0x65F130", Offset = "0x65E530", Length = "0x1F")]
	[Token(Token = "0x6000229")]
	public TweenParams OnPlay(TweenCallback action) { }

	[Address(RVA = "0x65F150", Offset = "0x65E550", Length = "0x1F")]
	[Token(Token = "0x600022A")]
	public TweenParams OnRewind(TweenCallback action) { }

	[Address(RVA = "0x65F170", Offset = "0x65E570", Length = "0x1F")]
	[Token(Token = "0x6000228")]
	public TweenParams OnStart(TweenCallback action) { }

	[Address(RVA = "0x65F190", Offset = "0x65E590", Length = "0x1F")]
	[Token(Token = "0x600022C")]
	public TweenParams OnStepComplete(TweenCallback action) { }

	[Address(RVA = "0x65F1B0", Offset = "0x65E5B0", Length = "0x1F")]
	[Token(Token = "0x600022B")]
	public TweenParams OnUpdate(TweenCallback action) { }

	[Address(RVA = "0x65F1D0", Offset = "0x65E5D0", Length = "0x1F")]
	[Token(Token = "0x600022F")]
	public TweenParams OnWaypointChange(TweenCallback<Int32> action) { }

	[Address(RVA = "0x65F1F0", Offset = "0x65E5F0", Length = "0x7")]
	[Token(Token = "0x600021E")]
	public TweenParams SetAutoKill(bool autoKillOnCompletion = true) { }

	[Address(RVA = "0x65F200", Offset = "0x65E600", Length = "0x9")]
	[Token(Token = "0x6000230")]
	public TweenParams SetDelay(float delay) { }

	[Address(RVA = "0x65F470", Offset = "0x65E870", Length = "0x29")]
	[Token(Token = "0x6000224")]
	public TweenParams SetEase(EaseFunction customEase) { }

	[Address(RVA = "0x65F210", Offset = "0x65E610", Length = "0x13D")]
	[Token(Token = "0x6000223")]
	public TweenParams SetEase(AnimationCurve animCurve) { }

	[Address(RVA = "0x65F350", Offset = "0x65E750", Length = "0x114")]
	[Token(Token = "0x6000222")]
	public TweenParams SetEase(Ease ease, Nullable<Single> overshootOrAmplitude = null, Nullable<Single> period = null) { }

	[Address(RVA = "0x65F4A0", Offset = "0x65E8A0", Length = "0x1F")]
	[Token(Token = "0x600021F")]
	public TweenParams SetId(object id) { }

	[Address(RVA = "0x65F4C0", Offset = "0x65E8C0", Length = "0x80")]
	[Token(Token = "0x6000221")]
	public TweenParams SetLoops(int loops, Nullable<LoopType> loopType = null) { }

	[Address(RVA = "0x65F540", Offset = "0x65E940", Length = "0x7")]
	[Token(Token = "0x6000225")]
	public TweenParams SetRecyclable(bool recyclable = true) { }

	[Address(RVA = "0x65F550", Offset = "0x65E950", Length = "0x7")]
	[Token(Token = "0x6000231")]
	public TweenParams SetRelative(bool isRelative = true) { }

	[Address(RVA = "0x65F560", Offset = "0x65E960", Length = "0x7")]
	[Token(Token = "0x6000232")]
	public TweenParams SetSpeedBased(bool isSpeedBased = true) { }

	[Address(RVA = "0x65F570", Offset = "0x65E970", Length = "0x1F")]
	[Token(Token = "0x6000220")]
	public TweenParams SetTarget(object target) { }

	[Address(RVA = "0x65F5A0", Offset = "0x65E9A0", Length = "0x6A")]
	[Token(Token = "0x6000226")]
	public TweenParams SetUpdate(bool isIndependentUpdate) { }

	[Address(RVA = "0x65F590", Offset = "0x65E990", Length = "0xB")]
	[Token(Token = "0x6000227")]
	public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false) { }

}

