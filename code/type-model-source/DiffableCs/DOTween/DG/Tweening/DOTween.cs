namespace DG.Tweening;

[Token(Token = "0x200000A")]
public class DOTween
{
	[CompilerGenerated]
	[Token(Token = "0x200000B")]
	private sealed class <>c__DisplayClass66_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002D")]
		public float v; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002E")]
		public DOSetter<Single> setter; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600006A")]
		public <>c__DisplayClass66_0() { }

		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x600006B")]
		internal float <To>b__0() { }

		[Address(RVA = "0x662950", Offset = "0x661D50", Length = "0x2A")]
		[Token(Token = "0x600006C")]
		internal void <To>b__1(float x) { }

	}

	[Token(Token = "0x400000E")]
	public static readonly string Version; //Field offset: 0x0
	[Token(Token = "0x400000F")]
	public static bool useSafeMode; //Field offset: 0x8
	[Token(Token = "0x4000010")]
	public static SafeModeLogBehaviour safeModeLogBehaviour; //Field offset: 0xC
	[Token(Token = "0x4000011")]
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; //Field offset: 0x10
	[Token(Token = "0x4000012")]
	public static bool showUnityEditorReport; //Field offset: 0x14
	[Token(Token = "0x4000013")]
	public static float timeScale; //Field offset: 0x18
	[Token(Token = "0x4000014")]
	public static bool useSmoothDeltaTime; //Field offset: 0x1C
	[Token(Token = "0x4000015")]
	public static float maxSmoothUnscaledTime; //Field offset: 0x20
	[Token(Token = "0x4000016")]
	internal static RewindCallbackMode rewindCallbackMode; //Field offset: 0x24
	[Token(Token = "0x4000017")]
	private static LogBehaviour _logBehaviour; //Field offset: 0x28
	[Token(Token = "0x4000018")]
	public static Func<LogType, Object, Boolean> onWillLog; //Field offset: 0x30
	[Token(Token = "0x4000019")]
	public static bool drawGizmos; //Field offset: 0x38
	[Token(Token = "0x400001A")]
	public static bool debugMode; //Field offset: 0x39
	[Token(Token = "0x400001B")]
	private static bool _fooDebugStoreTargetId; //Field offset: 0x3A
	[Token(Token = "0x400001C")]
	public static UpdateType defaultUpdateType; //Field offset: 0x3C
	[Token(Token = "0x400001D")]
	public static bool defaultTimeScaleIndependent; //Field offset: 0x40
	[Token(Token = "0x400001E")]
	public static AutoPlay defaultAutoPlay; //Field offset: 0x44
	[Token(Token = "0x400001F")]
	public static bool defaultAutoKill; //Field offset: 0x48
	[Token(Token = "0x4000020")]
	public static LoopType defaultLoopType; //Field offset: 0x4C
	[Token(Token = "0x4000021")]
	public static bool defaultRecyclable; //Field offset: 0x50
	[Token(Token = "0x4000022")]
	public static Ease defaultEaseType; //Field offset: 0x54
	[Token(Token = "0x4000023")]
	public static float defaultEaseOvershootOrAmplitude; //Field offset: 0x58
	[Token(Token = "0x4000024")]
	public static float defaultEasePeriod; //Field offset: 0x5C
	[Token(Token = "0x4000025")]
	public static DOTweenComponent instance; //Field offset: 0x60
	[Token(Token = "0x4000026")]
	private static bool _foo_isQuitting; //Field offset: 0x68
	[Token(Token = "0x4000027")]
	internal static int maxActiveTweenersReached; //Field offset: 0x6C
	[Token(Token = "0x4000028")]
	internal static int maxActiveSequencesReached; //Field offset: 0x70
	[Token(Token = "0x4000029")]
	internal static SafeModeReport safeModeReport; //Field offset: 0x74
	[Token(Token = "0x400002A")]
	internal static readonly List<TweenCallback> GizmosDelegates; //Field offset: 0x88
	[Token(Token = "0x400002B")]
	internal static bool initialized; //Field offset: 0x90
	[Token(Token = "0x400002C")]
	private static int _isQuittingFrame; //Field offset: 0x94

	[Token(Token = "0x17000002")]
	public static bool debugStoreTargetId
	{
		[Address(RVA = "0x64E0F0", Offset = "0x64D4F0", Length = "0x97")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 151
		[Address(RVA = "0x64E2B0", Offset = "0x64D6B0", Length = "0x54")]
		[Token(Token = "0x6000017")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000003")]
	internal static bool isQuitting
	{
		[Address(RVA = "0x64E190", Offset = "0x64D590", Length = "0xD0")]
		[Token(Token = "0x6000018")]
		internal get { } //Length: 208
		[Address(RVA = "0x64E310", Offset = "0x64D710", Length = "0x8A")]
		[Token(Token = "0x6000019")]
		internal set { } //Length: 138
	}

	[Token(Token = "0x17000001")]
	public static LogBehaviour logBehaviour
	{
		[Address(RVA = "0x64E260", Offset = "0x64D660", Length = "0x4E")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 78
		[Address(RVA = "0x64E3A0", Offset = "0x64D7A0", Length = "0x6A")]
		[Token(Token = "0x6000015")]
		 set { } //Length: 106
	}

	[Address(RVA = "0x64DEA0", Offset = "0x64D2A0", Length = "0x24B")]
	[Token(Token = "0x6000069")]
	private static DOTween() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000068")]
	public DOTween() { }

	[Address(RVA = "0x7BAA00", Offset = "0x7B9E00", Length = "0x129")]
	[Token(Token = "0x6000067")]
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) { }

	[Address(RVA = "0x649850", Offset = "0x648C50", Length = "0x125")]
	[Token(Token = "0x600001B")]
	private static void AutoInit() { }

	[Address(RVA = "0x6499C0", Offset = "0x648DC0", Length = "0x2E9")]
	[Token(Token = "0x600001F")]
	internal static void Clear(bool destroy, bool isApplicationQuitting) { }

	[Address(RVA = "0x649CB0", Offset = "0x6490B0", Length = "0x4C")]
	[Token(Token = "0x600001E")]
	public static void Clear(bool destroy = false) { }

	[Address(RVA = "0x649980", Offset = "0x648D80", Length = "0x40")]
	[Token(Token = "0x6000020")]
	public static void ClearCachedTweens() { }

	[Address(RVA = "0x649F60", Offset = "0x649360", Length = "0x8E")]
	[Token(Token = "0x600003E")]
	public static int Complete(object targetOrId, bool withCallbacks = false) { }

	[Address(RVA = "0x649D00", Offset = "0x649100", Length = "0x6D")]
	[Token(Token = "0x600003D")]
	public static int CompleteAll(bool withCallbacks = false) { }

	[Address(RVA = "0x649ED0", Offset = "0x6492D0", Length = "0x8F")]
	[Token(Token = "0x6000041")]
	internal static int CompleteAndReturnKilledTot(object target, object id) { }

	[Address(RVA = "0x649DE0", Offset = "0x6491E0", Length = "0x79")]
	[Token(Token = "0x6000040")]
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	[Address(RVA = "0x649E60", Offset = "0x649260", Length = "0x63")]
	[Token(Token = "0x600003F")]
	internal static int CompleteAndReturnKilledTot() { }

	[Address(RVA = "0x649D70", Offset = "0x649170", Length = "0x6C")]
	[Token(Token = "0x6000042")]
	internal static int CompleteAndReturnKilledTotExceptFor(Object[] excludeTargetsOrIds) { }

	[Address(RVA = "0x64A060", Offset = "0x649460", Length = "0x7C")]
	[Token(Token = "0x6000044")]
	public static int Flip(object targetOrId) { }

	[Address(RVA = "0x649FF0", Offset = "0x6493F0", Length = "0x66")]
	[Token(Token = "0x6000043")]
	public static int FlipAll() { }

	[Address(RVA = "0x64E0F0", Offset = "0x64D4F0", Length = "0x97")]
	[Token(Token = "0x6000016")]
	public static bool get_debugStoreTargetId() { }

	[Address(RVA = "0x64E190", Offset = "0x64D590", Length = "0xD0")]
	[Token(Token = "0x6000018")]
	internal static bool get_isQuitting() { }

	[Address(RVA = "0x64E260", Offset = "0x64D660", Length = "0x4E")]
	[Token(Token = "0x6000014")]
	public static LogBehaviour get_logBehaviour() { }

	[Address(RVA = "0x64A160", Offset = "0x649560", Length = "0x9E")]
	[Token(Token = "0x6000046")]
	public static int Goto(object targetOrId, float to, bool andPlay = false) { }

	[Address(RVA = "0x64A0E0", Offset = "0x6494E0", Length = "0x77")]
	[Token(Token = "0x6000045")]
	public static int GotoAll(float to, bool andPlay = false) { }

	[Address(RVA = "0x64A3E0", Offset = "0x6497E0", Length = "0x6F0")]
	[Token(Token = "0x600001C")]
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<Boolean> recycleAllByDefault, Nullable<Boolean> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	[Address(RVA = "0x64AAE0", Offset = "0x649EE0", Length = "0x1AF")]
	[Token(Token = "0x600001A")]
	public static IDOTweenInit Init(Nullable<Boolean> recycleAllByDefault = null, Nullable<Boolean> useSafeMode = null, Nullable<LogBehaviour> logBehaviour = null) { }

	[Address(RVA = "0x64A200", Offset = "0x649600", Length = "0x1DD")]
	[Token(Token = "0x6000066")]
	private static void InitCheck() { }

	[Address(RVA = "0x64AC90", Offset = "0x64A090", Length = "0x81")]
	[Token(Token = "0x600005F")]
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false) { }

	[Address(RVA = "0x64AF10", Offset = "0x64A310", Length = "0x148")]
	[Token(Token = "0x600004A")]
	public static int Kill(object target, object id, bool complete = false) { }

	[Address(RVA = "0x64B060", Offset = "0x64A460", Length = "0x129")]
	[Token(Token = "0x6000049")]
	public static int Kill(object targetOrId, bool complete = false) { }

	[Address(RVA = "0x64AD20", Offset = "0x64A120", Length = "0x16E")]
	[Token(Token = "0x6000048")]
	public static int KillAll(bool complete, Object[] idsOrTargetsToExclude) { }

	[Address(RVA = "0x64AE90", Offset = "0x64A290", Length = "0x7B")]
	[Token(Token = "0x6000047")]
	public static int KillAll(bool complete = false) { }

	[Address(RVA = "0x64B190", Offset = "0x64A590", Length = "0x10A")]
	[Token(Token = "0x6000022")]
	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	[Address(RVA = "0x64B310", Offset = "0x64A710", Length = "0x7C")]
	[Token(Token = "0x600004C")]
	public static int Pause(object targetOrId) { }

	[Address(RVA = "0x64B2A0", Offset = "0x64A6A0", Length = "0x66")]
	[Token(Token = "0x600004B")]
	public static int PauseAll() { }

	[Address(RVA = "0x64B390", Offset = "0x64A790", Length = "0x7E")]
	[Token(Token = "0x6000063")]
	public static List<Tween> PausedTweens(List<Tween> fillableList = null) { }

	[Address(RVA = "0x64B7A0", Offset = "0x64ABA0", Length = "0x7C")]
	[Token(Token = "0x600004E")]
	public static int Play(object targetOrId) { }

	[Address(RVA = "0x64B820", Offset = "0x64AC20", Length = "0x92")]
	[Token(Token = "0x600004F")]
	public static int Play(object target, object id) { }

	[Address(RVA = "0x64B410", Offset = "0x64A810", Length = "0x66")]
	[Token(Token = "0x600004D")]
	public static int PlayAll() { }

	[Address(RVA = "0x64B4F0", Offset = "0x64A8F0", Length = "0x7C")]
	[Token(Token = "0x6000051")]
	public static int PlayBackwards(object targetOrId) { }

	[Address(RVA = "0x64B570", Offset = "0x64A970", Length = "0x92")]
	[Token(Token = "0x6000052")]
	public static int PlayBackwards(object target, object id) { }

	[Address(RVA = "0x64B480", Offset = "0x64A880", Length = "0x66")]
	[Token(Token = "0x6000050")]
	public static int PlayBackwardsAll() { }

	[Address(RVA = "0x64B680", Offset = "0x64AA80", Length = "0x7C")]
	[Token(Token = "0x6000054")]
	public static int PlayForward(object targetOrId) { }

	[Address(RVA = "0x64B700", Offset = "0x64AB00", Length = "0x92")]
	[Token(Token = "0x6000055")]
	public static int PlayForward(object target, object id) { }

	[Address(RVA = "0x64B610", Offset = "0x64AA10", Length = "0x66")]
	[Token(Token = "0x6000053")]
	public static int PlayForwardAll() { }

	[Address(RVA = "0x64B8C0", Offset = "0x64ACC0", Length = "0x7E")]
	[Token(Token = "0x6000062")]
	public static List<Tween> PlayingTweens(List<Tween> fillableList = null) { }

	[Address(RVA = "0x64B940", Offset = "0x64AD40", Length = "0x3E2")]
	[Token(Token = "0x6000035")]
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	[Address(RVA = "0x64BE50", Offset = "0x64B250", Length = "0x9D")]
	[Token(Token = "0x6000057")]
	public static int Restart(object targetOrId, bool includeDelay = true, float changeDelayTo = -1) { }

	[Address(RVA = "0x64BDA0", Offset = "0x64B1A0", Length = "0xA2")]
	[Token(Token = "0x6000058")]
	public static int Restart(object target, object id, bool includeDelay = true, float changeDelayTo = -1) { }

	[Address(RVA = "0x64BD30", Offset = "0x64B130", Length = "0x6D")]
	[Token(Token = "0x6000056")]
	public static int RestartAll(bool includeDelay = true) { }

	[Address(RVA = "0x64BF60", Offset = "0x64B360", Length = "0x8E")]
	[Token(Token = "0x600005A")]
	public static int Rewind(object targetOrId, bool includeDelay = true) { }

	[Address(RVA = "0x64BEF0", Offset = "0x64B2F0", Length = "0x6D")]
	[Token(Token = "0x6000059")]
	public static int RewindAll(bool includeDelay = true) { }

	[Address(RVA = "0x64C180", Offset = "0x64B580", Length = "0x64")]
	[Token(Token = "0x600003C")]
	public static Sequence Sequence(object target) { }

	[Address(RVA = "0x64BFF0", Offset = "0x64B3F0", Length = "0x18F")]
	[Token(Token = "0x600003B")]
	public static Sequence Sequence() { }

	[Address(RVA = "0x64E2B0", Offset = "0x64D6B0", Length = "0x54")]
	[Token(Token = "0x6000017")]
	public static void set_debugStoreTargetId(bool value) { }

	[Address(RVA = "0x64E310", Offset = "0x64D710", Length = "0x8A")]
	[Token(Token = "0x6000019")]
	internal static void set_isQuitting(bool value) { }

	[Address(RVA = "0x64E3A0", Offset = "0x64D7A0", Length = "0x6A")]
	[Token(Token = "0x6000015")]
	public static void set_logBehaviour(LogBehaviour value) { }

	[Address(RVA = "0x64C1F0", Offset = "0x64B5F0", Length = "0x55")]
	[Token(Token = "0x600001D")]
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	[Address(RVA = "0x64C250", Offset = "0x64B650", Length = "0xC5")]
	[Token(Token = "0x6000037")]
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = true) { }

	[Address(RVA = "0x64C400", Offset = "0x64B800", Length = "0x777")]
	[Token(Token = "0x6000038")]
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	[Address(RVA = "0x64C320", Offset = "0x64B720", Length = "0xD4")]
	[Token(Token = "0x6000036")]
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = true, bool fadeOut = true) { }

	[Address(RVA = "0x64CBF0", Offset = "0x64BFF0", Length = "0x7C")]
	[Token(Token = "0x600005C")]
	public static int SmoothRewind(object targetOrId) { }

	[Address(RVA = "0x64CB80", Offset = "0x64BF80", Length = "0x66")]
	[Token(Token = "0x600005B")]
	public static int SmoothRewindAll() { }

	[Address(RVA = "0x64D6C0", Offset = "0x64CAC0", Length = "0x98")]
	[Token(Token = "0x6000028")]
	public static TweenerCore<UInt64, UInt64, NoOptions> To(DOGetter<UInt64> getter, DOSetter<UInt64> setter, ulong endValue, float duration) { }

	[Address(RVA = "0x64D040", Offset = "0x64C440", Length = "0x98")]
	[Token(Token = "0x6000027")]
	public static TweenerCore<Int64, Int64, NoOptions> To(DOGetter<Int64> getter, DOSetter<Int64> setter, long endValue, float duration) { }

	[Address(RVA = "0x64D4D0", Offset = "0x64C8D0", Length = "0x98")]
	[Token(Token = "0x6000030")]
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	[Address(RVA = "0x64D430", Offset = "0x64C830", Length = "0x98")]
	[Token(Token = "0x6000029")]
	public static TweenerCore<String, String, StringOptions> To(DOGetter<String> getter, DOSetter<String> setter, string endValue, float duration) { }

	[Address(RVA = "0x7BC1E0", Offset = "0x7BB5E0", Length = "0x15E")]
	[Token(Token = "0x6000031")]
	public static TweenerCore<T1, T2, TPlugOptions> To(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }

	[Address(RVA = "0x64D760", Offset = "0x64CB60", Length = "0x172")]
	[Token(Token = "0x6000034")]
	public static Tweener To(DOSetter<Single> setter, float startValue, float endValue, float duration) { }

	[Address(RVA = "0x64D570", Offset = "0x64C970", Length = "0xA2")]
	[Token(Token = "0x600002F")]
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	[Address(RVA = "0x64D980", Offset = "0x64CD80", Length = "0xAB")]
	[Token(Token = "0x600003A")]
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	[Address(RVA = "0x64DA30", Offset = "0x64CE30", Length = "0x98")]
	[Token(Token = "0x6000024")]
	public static TweenerCore<Double, Double, NoOptions> To(DOGetter<Double> getter, DOSetter<Double> setter, double endValue, float duration) { }

	[Address(RVA = "0x64D240", Offset = "0x64C640", Length = "0x98")]
	[Token(Token = "0x6000023")]
	public static TweenerCore<Single, Single, FloatOptions> To(DOGetter<Single> getter, DOSetter<Single> setter, float endValue, float duration) { }

	[Address(RVA = "0x64D390", Offset = "0x64C790", Length = "0x98")]
	[Token(Token = "0x6000026")]
	public static TweenerCore<UInt32, UInt32, UintOptions> To(DOGetter<UInt32> getter, DOSetter<UInt32> setter, uint endValue, float duration) { }

	[Address(RVA = "0x64D2E0", Offset = "0x64C6E0", Length = "0xA2")]
	[Token(Token = "0x600002E")]
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	[Address(RVA = "0x64D190", Offset = "0x64C590", Length = "0xAB")]
	[Token(Token = "0x600002D")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	[Address(RVA = "0x64DAD0", Offset = "0x64CED0", Length = "0xA2")]
	[Token(Token = "0x600002C")]
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	[Address(RVA = "0x64D8E0", Offset = "0x64CCE0", Length = "0x98")]
	[Token(Token = "0x6000025")]
	public static TweenerCore<Int32, Int32, NoOptions> To(DOGetter<Int32> getter, DOSetter<Int32> setter, int endValue, float duration) { }

	[Address(RVA = "0x64D0E0", Offset = "0x64C4E0", Length = "0xAB")]
	[Token(Token = "0x600002B")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	[Address(RVA = "0x64D620", Offset = "0x64CA20", Length = "0x9C")]
	[Token(Token = "0x600002A")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	[Address(RVA = "0x64CC70", Offset = "0x64C070", Length = "0xC6")]
	[Token(Token = "0x6000033")]
	public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	[Address(RVA = "0x64CD40", Offset = "0x64C140", Length = "0x228")]
	[Token(Token = "0x6000039")]
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, Single[] durations) { }

	[Address(RVA = "0x64CF70", Offset = "0x64C370", Length = "0xC3")]
	[Token(Token = "0x6000032")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	[Address(RVA = "0x64DBF0", Offset = "0x64CFF0", Length = "0x7C")]
	[Token(Token = "0x600005E")]
	public static int TogglePause(object targetOrId) { }

	[Address(RVA = "0x64DB80", Offset = "0x64CF80", Length = "0x66")]
	[Token(Token = "0x600005D")]
	public static int TogglePauseAll() { }

	[Address(RVA = "0x64DC70", Offset = "0x64D070", Length = "0x4E")]
	[Token(Token = "0x6000060")]
	public static int TotalActiveTweens() { }

	[Address(RVA = "0x64DCC0", Offset = "0x64D0C0", Length = "0x40")]
	[Token(Token = "0x6000061")]
	public static int TotalPlayingTweens() { }

	[Address(RVA = "0x64DD00", Offset = "0x64D100", Length = "0xB3")]
	[Token(Token = "0x6000064")]
	public static List<Tween> TweensById(object id, bool playingOnly = false, List<Tween> fillableList = null) { }

	[Address(RVA = "0x64DDC0", Offset = "0x64D1C0", Length = "0x9C")]
	[Token(Token = "0x6000065")]
	public static List<Tween> TweensByTarget(object target, bool playingOnly = false, List<Tween> fillableList = null) { }

	[Address(RVA = "0x64DE60", Offset = "0x64D260", Length = "0x40")]
	[Token(Token = "0x6000021")]
	public static int Validate() { }

}

