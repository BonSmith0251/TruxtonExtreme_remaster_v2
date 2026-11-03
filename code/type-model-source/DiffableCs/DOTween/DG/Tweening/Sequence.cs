namespace DG.Tweening;

[Token(Token = "0x200001C")]
public sealed class Sequence : Tween
{
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000085")]
	internal readonly List<Tween> sequencedTweens; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000086")]
	private readonly List<ABSSequentiable> _sequencedObjs; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000087")]
	internal float lastTweenInsertTime; //Field offset: 0x130

	[Address(RVA = "0x651250", Offset = "0x650650", Length = "0x109")]
	[Token(Token = "0x60000B5")]
	internal Sequence() { }

	[Address(RVA = "0x64F690", Offset = "0x64EA90", Length = "0x80C")]
	[Token(Token = "0x60000C3")]
	private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false) { }

	[Address(RVA = "0x64FEA0", Offset = "0x64F2A0", Length = "0x17")]
	[Token(Token = "0x60000BF")]
	internal virtual bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	[Address(RVA = "0x64FEC0", Offset = "0x64F2C0", Length = "0x32")]
	[Token(Token = "0x60000B8")]
	internal static Sequence DoAppendInterval(Sequence inSequence, float interval) { }

	[Address(RVA = "0x64FF00", Offset = "0x64F300", Length = "0x437")]
	[Token(Token = "0x60000C2")]
	internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) { }

	[Address(RVA = "0x650470", Offset = "0x64F870", Length = "0x215")]
	[Token(Token = "0x60000B7")]
	internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) { }

	[Address(RVA = "0x650340", Offset = "0x64F740", Length = "0x124")]
	[Token(Token = "0x60000BA")]
	internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) { }

	[Address(RVA = "0x650770", Offset = "0x64FB70", Length = "0x11E")]
	[Token(Token = "0x60000B6")]
	internal static Sequence DoPrepend(Sequence inSequence, Tween t) { }

	[Address(RVA = "0x650690", Offset = "0x64FA90", Length = "0xDC")]
	[Token(Token = "0x60000B9")]
	internal static Sequence DoPrependInterval(Sequence inSequence, float interval) { }

	[Address(RVA = "0x650890", Offset = "0x64FC90", Length = "0x3D2")]
	[Token(Token = "0x60000C1")]
	internal static bool DoStartup(Sequence s) { }

	[Address(RVA = "0x650C70", Offset = "0x650070", Length = "0x59")]
	[Token(Token = "0x60000C5")]
	private static bool IsAnyCallbackSet(Sequence s) { }

	[Address(RVA = "0x650CD0", Offset = "0x6500D0", Length = "0x21C")]
	[Token(Token = "0x60000BC")]
	internal virtual void Reset() { }

	[Address(RVA = "0x650EF0", Offset = "0x6502F0", Length = "0x12C")]
	[Token(Token = "0x60000C0")]
	internal static void Setup(Sequence s) { }

	[Address(RVA = "0x651020", Offset = "0x650420", Length = "0x121")]
	[Token(Token = "0x60000C4")]
	private static void StableSortSequencedObjs(List<ABSSequentiable> list) { }

	[Address(RVA = "0x651150", Offset = "0x650550", Length = "0x7")]
	[Token(Token = "0x60000BE")]
	internal virtual bool Startup() { }

	[Address(RVA = "0x651160", Offset = "0x650560", Length = "0x30")]
	[Token(Token = "0x60000BB")]
	internal virtual float UpdateDelay(float elapsed) { }

	[Address(RVA = "0x651190", Offset = "0x650590", Length = "0xB9")]
	[Token(Token = "0x60000BD")]
	internal virtual bool Validate() { }

}

