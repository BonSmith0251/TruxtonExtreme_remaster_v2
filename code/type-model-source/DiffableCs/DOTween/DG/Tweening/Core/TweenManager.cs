namespace DG.Tweening.Core;

[Token(Token = "0x20000B4")]
internal static class TweenManager
{
	[Token(Token = "0x20000B5")]
	public enum CapacityIncreaseMode : int
	{
		TweenersAndSequences = 0,
		TweenersOnly = 1,
		SequencesOnly = 2,
	}

	[Token(Token = "0x4000219")]
	private const int _DefaultMaxTweeners = 200; //Field offset: 0x0
	[Token(Token = "0x400021A")]
	private const int _DefaultMaxSequences = 50; //Field offset: 0x0
	[Token(Token = "0x400021B")]
	private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup"; //Field offset: 0x0
	[Token(Token = "0x400021C")]
	private const float _EpsilonVsTimeCheck = 1E-06; //Field offset: 0x0
	[Token(Token = "0x400021D")]
	internal static bool isUnityEditor; //Field offset: 0x0
	[Token(Token = "0x400021E")]
	internal static bool isDebugBuild; //Field offset: 0x1
	[Token(Token = "0x400021F")]
	internal static int maxActive; //Field offset: 0x4
	[Token(Token = "0x4000220")]
	internal static int maxTweeners; //Field offset: 0x8
	[Token(Token = "0x4000221")]
	internal static int maxSequences; //Field offset: 0xC
	[Token(Token = "0x4000222")]
	internal static bool hasActiveTweens; //Field offset: 0x10
	[Token(Token = "0x4000223")]
	internal static bool hasActiveDefaultTweens; //Field offset: 0x11
	[Token(Token = "0x4000224")]
	internal static bool hasActiveLateTweens; //Field offset: 0x12
	[Token(Token = "0x4000225")]
	internal static bool hasActiveFixedTweens; //Field offset: 0x13
	[Token(Token = "0x4000226")]
	internal static bool hasActiveManualTweens; //Field offset: 0x14
	[Token(Token = "0x4000227")]
	internal static int totActiveTweens; //Field offset: 0x18
	[Token(Token = "0x4000228")]
	internal static int totActiveDefaultTweens; //Field offset: 0x1C
	[Token(Token = "0x4000229")]
	internal static int totActiveLateTweens; //Field offset: 0x20
	[Token(Token = "0x400022A")]
	internal static int totActiveFixedTweens; //Field offset: 0x24
	[Token(Token = "0x400022B")]
	internal static int totActiveManualTweens; //Field offset: 0x28
	[Token(Token = "0x400022C")]
	internal static int totActiveTweeners; //Field offset: 0x2C
	[Token(Token = "0x400022D")]
	internal static int totActiveSequences; //Field offset: 0x30
	[Token(Token = "0x400022E")]
	internal static int totPooledTweeners; //Field offset: 0x34
	[Token(Token = "0x400022F")]
	internal static int totPooledSequences; //Field offset: 0x38
	[Token(Token = "0x4000230")]
	internal static int totTweeners; //Field offset: 0x3C
	[Token(Token = "0x4000231")]
	internal static int totSequences; //Field offset: 0x40
	[Token(Token = "0x4000232")]
	internal static bool isUpdateLoop; //Field offset: 0x44
	[Token(Token = "0x4000233")]
	internal static Tween[] _activeTweens; //Field offset: 0x48
	[Token(Token = "0x4000234")]
	private static Tween[] _pooledTweeners; //Field offset: 0x50
	[Token(Token = "0x4000235")]
	private static readonly Stack<Tween> _PooledSequences; //Field offset: 0x58
	[Token(Token = "0x4000236")]
	private static readonly List<Tween> _KillList; //Field offset: 0x60
	[Token(Token = "0x4000237")]
	private static readonly Dictionary<Tween, TweenLink> _TweenLinks; //Field offset: 0x68
	[Token(Token = "0x4000238")]
	private static int _totTweenLinks; //Field offset: 0x70
	[Token(Token = "0x4000239")]
	private static int _maxActiveLookupId; //Field offset: 0x74
	[Token(Token = "0x400023A")]
	private static bool _requiresActiveReorganization; //Field offset: 0x78
	[Token(Token = "0x400023B")]
	private static int _reorganizeFromId; //Field offset: 0x7C
	[Token(Token = "0x400023C")]
	private static int _minPooledTweenerId; //Field offset: 0x80
	[Token(Token = "0x400023D")]
	private static int _maxPooledTweenerId; //Field offset: 0x84
	[Token(Token = "0x400023E")]
	private static bool _despawnAllCalledFromUpdateLoopCallback; //Field offset: 0x88

	[Address(RVA = "0x67AED0", Offset = "0x67A2D0", Length = "0x2AF")]
	[Token(Token = "0x6000419")]
	private static TweenManager() { }

	[Address(RVA = "0x675180", Offset = "0x674580", Length = "0x3E1")]
	[Token(Token = "0x600043D")]
	private static void AddActiveTween(Tween t) { }

	[Address(RVA = "0x675130", Offset = "0x674530", Length = "0x49")]
	[Token(Token = "0x600041D")]
	internal static void AddActiveTweenToSequence(Tween t) { }

	[Address(RVA = "0x675570", Offset = "0x674970", Length = "0x232")]
	[Token(Token = "0x6000422")]
	internal static void AddTweenLink(Tween t, TweenLink tweenLink) { }

	[Address(RVA = "0x6757B0", Offset = "0x674BB0", Length = "0x92")]
	[Token(Token = "0x6000441")]
	private static void ClearTweenArray(Tween[] tweens) { }

	[Address(RVA = "0x675850", Offset = "0x674C50", Length = "0x112")]
	[Token(Token = "0x600042A")]
	internal static bool Complete(Tween t, bool modifyActiveLists = true, UpdateMode updateMode = 1) { }

	[Address(RVA = "0x675D60", Offset = "0x675160", Length = "0x66C")]
	[Token(Token = "0x600041F")]
	internal static void Despawn(Tween t, bool modifyActiveLists = true) { }

	[Address(RVA = "0x675970", Offset = "0x674D70", Length = "0xB2")]
	[Token(Token = "0x600043F")]
	private static void DespawnActiveTweens(List<Tween> tweens) { }

	[Address(RVA = "0x675A30", Offset = "0x674E30", Length = "0x32F")]
	[Token(Token = "0x600041E")]
	internal static int DespawnAll() { }

	[Address(RVA = "0x6763D0", Offset = "0x6757D0", Length = "0x154")]
	[Token(Token = "0x600043C")]
	private static void EvaluateTweenLink(Tween t) { }

	[Address(RVA = "0x6767A0", Offset = "0x675BA0", Length = "0xD00")]
	[Token(Token = "0x6000429")]
	internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, Object[] optionalArray = null) { }

	[Address(RVA = "0x6774E0", Offset = "0x6768E0", Length = "0x1F")]
	[Token(Token = "0x600042B")]
	internal static bool Flip(Tween t) { }

	[Address(RVA = "0x677500", Offset = "0x676900", Length = "0xC0")]
	[Token(Token = "0x600042C")]
	internal static void ForceInit(Tween t, bool isSequenced = false) { }

	[Address(RVA = "0x6775D0", Offset = "0x6769D0", Length = "0x1F0")]
	[Token(Token = "0x6000438")]
	internal static List<Tween> GetActiveTweens(bool playing, List<Tween> fillableList = null) { }

	[Address(RVA = "0x6777D0", Offset = "0x676BD0", Length = "0x304")]
	[Token(Token = "0x600041B")]
	internal static Sequence GetSequence() { }

	[Address(RVA = "0x947450", Offset = "0x946850", Length = "0x65E")]
	[Token(Token = "0x600041A")]
	internal static TweenerCore<T1, T2, TPlugOptions> GetTweener() { }

	[Address(RVA = "0x677AE0", Offset = "0x676EE0", Length = "0x2F2")]
	[Token(Token = "0x6000439")]
	internal static List<Tween> GetTweensById(object id, bool playingOnly, List<Tween> fillableList = null) { }

	[Address(RVA = "0x677DE0", Offset = "0x6771E0", Length = "0x216")]
	[Token(Token = "0x600043A")]
	internal static List<Tween> GetTweensByTarget(object target, bool playingOnly, List<Tween> fillableList = null) { }

	[Address(RVA = "0x678000", Offset = "0x677400", Length = "0x175")]
	[Token(Token = "0x600042D")]
	internal static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = 1) { }

	[Address(RVA = "0x678180", Offset = "0x677580", Length = "0x239")]
	[Token(Token = "0x6000442")]
	private static void IncreaseCapacities(CapacityIncreaseMode increaseMode) { }

	[Address(RVA = "0x6783C0", Offset = "0x6777C0", Length = "0xBB")]
	[Token(Token = "0x6000443")]
	private static void ManageOnRewindCallbackWhenAlreadyRewinded(Tween t, bool isPlayBackwardsOrSmoothRewind) { }

	[Address(RVA = "0x678480", Offset = "0x677880", Length = "0x13E")]
	[Token(Token = "0x600043B")]
	private static void MarkForKilling(Tween t, bool isSingleTweenManualUpdate = false) { }

	[Address(RVA = "0x6785C0", Offset = "0x6779C0", Length = "0x42")]
	[Token(Token = "0x600042E")]
	internal static bool Pause(Tween t) { }

	[Address(RVA = "0x6789A0", Offset = "0x677DA0", Length = "0x82")]
	[Token(Token = "0x600042F")]
	internal static bool Play(Tween t) { }

	[Address(RVA = "0x678610", Offset = "0x677A10", Length = "0x204")]
	[Token(Token = "0x6000430")]
	internal static bool PlayBackwards(Tween t) { }

	[Address(RVA = "0x678820", Offset = "0x677C20", Length = "0x173")]
	[Token(Token = "0x6000431")]
	internal static bool PlayForward(Tween t) { }

	[Address(RVA = "0x678A30", Offset = "0x677E30", Length = "0x445")]
	[Token(Token = "0x6000420")]
	internal static void PurgeAll(bool isApplicationQuitting) { }

	[Address(RVA = "0x678E80", Offset = "0x678280", Length = "0x192")]
	[Token(Token = "0x6000421")]
	internal static void PurgePools() { }

	[Address(RVA = "0x679020", Offset = "0x678420", Length = "0x702")]
	[Token(Token = "0x6000440")]
	private static void RemoveActiveTween(Tween t) { }

	[Address(RVA = "0x679730", Offset = "0x678B30", Length = "0xDE")]
	[Token(Token = "0x6000423")]
	private static void RemoveTweenLink(Tween t) { }

	[Address(RVA = "0x679810", Offset = "0x678C10", Length = "0x322")]
	[Token(Token = "0x600043E")]
	private static void ReorganizeActiveTweens() { }

	[Address(RVA = "0x679B40", Offset = "0x678F40", Length = "0x4B")]
	[Token(Token = "0x6000424")]
	internal static void ResetCapacities() { }

	[Address(RVA = "0x679B90", Offset = "0x678F90", Length = "0xE6")]
	[Token(Token = "0x6000432")]
	internal static bool Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1) { }

	[Address(RVA = "0x679C80", Offset = "0x679080", Length = "0x1A2")]
	[Token(Token = "0x6000433")]
	internal static bool Rewind(Tween t, bool includeDelay = true) { }

	[Address(RVA = "0x679E30", Offset = "0x679230", Length = "0x117")]
	[Token(Token = "0x6000425")]
	internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity) { }

	[Address(RVA = "0x679F50", Offset = "0x679350", Length = "0x2D9")]
	[Token(Token = "0x600041C")]
	internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate) { }

	[Address(RVA = "0x67A230", Offset = "0x679630", Length = "0x170")]
	[Token(Token = "0x6000434")]
	internal static bool SmoothRewind(Tween t) { }

	[Address(RVA = "0x67A3B0", Offset = "0x6797B0", Length = "0x107")]
	[Token(Token = "0x6000435")]
	internal static bool TogglePause(Tween t) { }

	[Address(RVA = "0x67A4C0", Offset = "0x6798C0", Length = "0x136")]
	[Token(Token = "0x6000437")]
	internal static int TotalPlayingTweens() { }

	[Address(RVA = "0x67A600", Offset = "0x679A00", Length = "0x51")]
	[Token(Token = "0x6000436")]
	internal static int TotalPooledTweens() { }

	[Address(RVA = "0x67A660", Offset = "0x679A60", Length = "0x359")]
	[Token(Token = "0x6000427")]
	internal static void Update(UpdateType updateType, float deltaTime, float independentTime) { }

	[Address(RVA = "0x67A9C0", Offset = "0x679DC0", Length = "0x29B")]
	[Token(Token = "0x6000428")]
	internal static bool Update(Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate) { }

	[Address(RVA = "0x67AC60", Offset = "0x67A060", Length = "0x267")]
	[Token(Token = "0x6000426")]
	internal static int Validate() { }

}

