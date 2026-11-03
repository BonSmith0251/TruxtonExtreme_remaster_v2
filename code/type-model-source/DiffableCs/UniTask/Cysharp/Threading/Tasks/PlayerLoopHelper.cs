namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000062")]
public static class PlayerLoopHelper
{
	[CompilerGenerated]
	[Token(Token = "0x2000063")]
	private sealed class <>c
	{
		[Token(Token = "0x40000CA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000CB")]
		public static Func<PlayerLoopSystem, Boolean> <>9__21_0; //Field offset: 0x8
		[Token(Token = "0x40000CC")]
		public static Predicate<PlayerLoopSystem> <>9__21_1; //Field offset: 0x10
		[Token(Token = "0x40000CD")]
		public static Predicate<PlayerLoopSystem> <>9__21_2; //Field offset: 0x18

		[Address(RVA = "0x273F970", Offset = "0x273ED70", Length = "0x67")]
		[Token(Token = "0x6000144")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000145")]
		public <>c() { }

		[Address(RVA = "0x273E9E0", Offset = "0x273DDE0", Length = "0x67")]
		[Token(Token = "0x6000146")]
		internal bool <InsertUniTaskSynchronizationContext>b__21_0(PlayerLoopSystem ls) { }

		[Address(RVA = "0x273EA50", Offset = "0x273DE50", Length = "0x5C")]
		[Token(Token = "0x6000147")]
		internal bool <InsertUniTaskSynchronizationContext>b__21_1(PlayerLoopSystem x) { }

		[Address(RVA = "0x273EAB0", Offset = "0x273DEB0", Length = "0x5C")]
		[Token(Token = "0x6000148")]
		internal bool <InsertUniTaskSynchronizationContext>b__21_2(PlayerLoopSystem x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000064")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CE")]
		public Type loopRunnerYieldType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000CF")]
		public Type loopRunnerType; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000149")]
		public <>c__DisplayClass20_0() { }

		[Address(RVA = "0x273F240", Offset = "0x273E640", Length = "0x86")]
		[Token(Token = "0x600014A")]
		internal bool <RemoveRunner>b__0(PlayerLoopSystem ls) { }

	}

	[Token(Token = "0x40000C2")]
	private static readonly ContinuationQueue ThrowMarkerContinuationQueue; //Field offset: 0x0
	[Token(Token = "0x40000C3")]
	private static readonly PlayerLoopRunner ThrowMarkerPlayerLoopRunner; //Field offset: 0x8
	[Token(Token = "0x40000C4")]
	private static int mainThreadId; //Field offset: 0x10
	[Token(Token = "0x40000C5")]
	private static string applicationDataPath; //Field offset: 0x18
	[Token(Token = "0x40000C6")]
	private static SynchronizationContext unitySynchronizationContext; //Field offset: 0x20
	[Token(Token = "0x40000C7")]
	private static ContinuationQueue[] yielders; //Field offset: 0x28
	[Token(Token = "0x40000C8")]
	private static PlayerLoopRunner[] runners; //Field offset: 0x30
	[CompilerGenerated]
	[Token(Token = "0x40000C9")]
	private static bool <IsEditorApplicationQuitting>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x17000027")]
	internal static string ApplicationDataPath
	{
		[Address(RVA = "0x2737BA0", Offset = "0x2736FA0", Length = "0x4F")]
		[Token(Token = "0x6000133")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000029")]
	internal static bool IsEditorApplicationQuitting
	{
		[Address(RVA = "0x2737BF0", Offset = "0x2736FF0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000135")]
		internal get { } //Length: 79
		[Address(RVA = "0x2737D60", Offset = "0x2737160", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6000136")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000028")]
	public static bool IsMainThread
	{
		[Address(RVA = "0x2737C40", Offset = "0x2737040", Length = "0x75")]
		[Token(Token = "0x6000134")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000026")]
	public static int MainThreadId
	{
		[Address(RVA = "0x2737CC0", Offset = "0x27370C0", Length = "0x4E")]
		[Token(Token = "0x6000132")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000025")]
	public static SynchronizationContext UnitySynchronizationContext
	{
		[Address(RVA = "0x2737D10", Offset = "0x2737110", Length = "0x4F")]
		[Token(Token = "0x6000131")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x2737AD0", Offset = "0x2736ED0", Length = "0xCA")]
	[Token(Token = "0x6000143")]
	private static PlayerLoopHelper() { }

	[Address(RVA = "0x2735C00", Offset = "0x2735000", Length = "0x99")]
	[Token(Token = "0x600013E")]
	public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action) { }

	[Address(RVA = "0x2735CA0", Offset = "0x27350A0", Length = "0x99")]
	[Token(Token = "0x6000140")]
	public static void AddContinuation(PlayerLoopTiming timing, Action continuation) { }

	[Address(RVA = "0x2735D40", Offset = "0x2735140", Length = "0x2DF")]
	[Token(Token = "0x6000141")]
	public static void DumpCurrentPlayerLoop() { }

	[Address(RVA = "0x2736020", Offset = "0x2735420", Length = "0x108")]
	[Token(Token = "0x600013B")]
	private static int FindLoopSystemIndex(PlayerLoopSystem[] playerLoopList, Type systemType) { }

	[Address(RVA = "0x2737BA0", Offset = "0x2736FA0", Length = "0x4F")]
	[Token(Token = "0x6000133")]
	internal static string get_ApplicationDataPath() { }

	[Address(RVA = "0x2737BF0", Offset = "0x2736FF0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000135")]
	internal static bool get_IsEditorApplicationQuitting() { }

	[Address(RVA = "0x2737C40", Offset = "0x2737040", Length = "0x75")]
	[Token(Token = "0x6000134")]
	public static bool get_IsMainThread() { }

	[Address(RVA = "0x2737CC0", Offset = "0x27370C0", Length = "0x4E")]
	[Token(Token = "0x6000132")]
	public static int get_MainThreadId() { }

	[Address(RVA = "0x2737D10", Offset = "0x2737110", Length = "0x4F")]
	[Token(Token = "0x6000131")]
	public static SynchronizationContext get_UnitySynchronizationContext() { }

	[Address(RVA = "0x2736130", Offset = "0x2735530", Length = "0x1AB")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x600013A")]
	private static void Init() { }

	[Address(RVA = "0x27362E0", Offset = "0x27356E0", Length = "0xA6B")]
	[Token(Token = "0x600013D")]
	public static void Initialize(ref PlayerLoopSystem playerLoop, InjectPlayerLoopTimings injectTimings = 65535) { }

	[Address(RVA = "0x2736D50", Offset = "0x2736150", Length = "0x2F4")]
	[Token(Token = "0x600013C")]
	private static void InsertLoop(PlayerLoopSystem[] copyList, InjectPlayerLoopTimings injectTimings, Type loopType, InjectPlayerLoopTimings targetTimings, int index, bool injectOnFirst, Type loopRunnerYieldType, Type loopRunnerType, PlayerLoopTiming playerLoopTiming) { }

	[Address(RVA = "0x2737050", Offset = "0x2736450", Length = "0x30A")]
	[Token(Token = "0x6000137")]
	private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, bool injectOnFirst, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner) { }

	[Address(RVA = "0x2737360", Offset = "0x2736760", Length = "0x459")]
	[Token(Token = "0x6000139")]
	private static PlayerLoopSystem[] InsertUniTaskSynchronizationContext(PlayerLoopSystem loopSystem) { }

	[Address(RVA = "0x27377C0", Offset = "0x2736BC0", Length = "0x152")]
	[Token(Token = "0x6000142")]
	public static bool IsInjectedUniTaskPlayerLoop() { }

	[Address(RVA = "0x2737920", Offset = "0x2736D20", Length = "0x106")]
	[Token(Token = "0x6000138")]
	private static PlayerLoopSystem[] RemoveRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, Type loopRunnerType) { }

	[Address(RVA = "0x2737D60", Offset = "0x2737160", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000136")]
	private static void set_IsEditorApplicationQuitting(bool value) { }

	[Address(RVA = "0x2737A30", Offset = "0x2736E30", Length = "0x94")]
	[Token(Token = "0x600013F")]
	private static void ThrowInvalidLoopTiming(PlayerLoopTiming playerLoopTiming) { }

}

