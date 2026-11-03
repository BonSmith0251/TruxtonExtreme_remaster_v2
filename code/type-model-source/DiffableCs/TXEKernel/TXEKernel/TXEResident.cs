namespace TXEKernel;

[Token(Token = "0x20000F1")]
public class TXEResident : DontDestroyMe<TXEResident>
{
	[CompilerGenerated]
	[Token(Token = "0x20000F2")]
	private struct <<CheckDLC>g__GetDlcsTask|24_0>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004F1")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<List`1<EntitlementLabel>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004F3")]
		private Awaiter<List<EntitlementLabel>> <>u__1; //Field offset: 0x20

		[Address(RVA = "0x271EFB0", Offset = "0x271E3B0", Length = "0x3AD")]
		[Token(Token = "0x6000717")]
		private override void MoveNext() { }

		[Address(RVA = "0x271F360", Offset = "0x271E760", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000718")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F3")]
	private struct <CheckDLC>d__24 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004F4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004F5")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004F6")]
		private Task<List`1<EntitlementLabel>> <dlcTask>5__2; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004F7")]
		private Task <timeoutTask>5__3; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004F8")]
		private bool <newFlg>5__4; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40004F9")]
		private TaskAwaiter<Task> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40004FA")]
		private TaskAwaiter<List`1<EntitlementLabel>> <>u__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40004FB")]
		private Awaiter <>u__3; //Field offset: 0x48

		[Address(RVA = "0x27191B0", Offset = "0x27185B0", Length = "0xAC6")]
		[Token(Token = "0x6000719")]
		private override void MoveNext() { }

		[Address(RVA = "0x2719C80", Offset = "0x2719080", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600071A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F4")]
	private sealed class <Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004FC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004FD")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004FE")]
		public TXEResident <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000203")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600071E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000204")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000720")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600071B")]
		public <Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x271A690", Offset = "0x2719A90", Length = "0x5D5")]
		[Token(Token = "0x600071D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600071E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000720")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271AC70", Offset = "0x271A070", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600071F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600071C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F5")]
	private sealed class <LoadDatas>d__34 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004FF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000500")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000501")]
		public TXEResident <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000205")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000724")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000206")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000726")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000721")]
		public <LoadDatas>d__34(int <>1__state) { }

		[Address(RVA = "0x271AE20", Offset = "0x271A220", Length = "0x202")]
		[Token(Token = "0x6000723")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000724")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000726")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271B030", Offset = "0x271A430", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000725")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000722")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40004EC")]
	private static readonly string _labelStage; //Field offset: 0x0
	[Token(Token = "0x40004ED")]
	private static readonly string _soundDatabasePath; //Field offset: 0x8
	[Token(Token = "0x40004EF")]
	private static readonly string _atlasDataPath; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004DE")]
	public Action PauseRequested; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004DF")]
	private Sprite[] numberSprite; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004E0")]
	private Vector2[] numScales; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004E1")]
	private GameObject _mainImage; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004E2")]
	private PlayMode _playMode; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40004E3")]
	private PlayStage _playStage; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004E4")]
	private PlayActor _playActor; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40004E5")]
	private int _playRound; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004E6")]
	private bool _isPlayLoop; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004E7")]
	private UsersManager _usersManager; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004E8")]
	private PurchaseManager _purchaseManager; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004E9")]
	private TrophyManager _trophyManager; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40004EA")]
	private RankingsManager _rankingManager; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40004EB")]
	private ActivityManager _activityManager; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40004EE")]
	private SoundDataBaseRecords _soundDB; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40004F0")]
	private SpriteAtlas _atlasData; //Field offset: 0x88

	[Token(Token = "0x17000202")]
	public bool IsPlayLoop
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x6000701")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2718240", Offset = "0x2717640", Length = "0xE8")]
	[Token(Token = "0x6000715")]
	private static TXEResident() { }

	[Address(RVA = "0x2718330", Offset = "0x2717730", Length = "0x40")]
	[Token(Token = "0x6000714")]
	public TXEResident() { }

	[Address(RVA = "0x2718140", Offset = "0x2717540", Length = "0xD8")]
	[AsyncStateMachine(typeof(<<CheckDLC>g__GetDlcsTask|24_0>d))]
	[CompilerGenerated]
	[Token(Token = "0x6000716")]
	internal static Task<List`1<EntitlementLabel>> <CheckDLC>g__GetDlcsTask|24_0() { }

	[Address(RVA = "0x2716F00", Offset = "0x2716300", Length = "0x2B")]
	[Token(Token = "0x6000713")]
	private void AtlasRequested(string tag, Action<SpriteAtlas> atlasAction) { }

	[Address(RVA = "0x2716F30", Offset = "0x2716330", Length = "0xF1")]
	[AsyncStateMachine(typeof(<CheckDLC>d__24))]
	[Token(Token = "0x6000707")]
	public UniTask<Boolean> CheckDLC() { }

	[Address(RVA = "0x27172A0", Offset = "0x27166A0", Length = "0x12E")]
	[Token(Token = "0x600070C")]
	private RenderTexture Create(Vector2 ssize, int depth, RenderTextureFormat tformat) { }

	[Address(RVA = "0x2717030", Offset = "0x2716430", Length = "0x260")]
	[Token(Token = "0x600070E")]
	public void CreateMainScreen(Transform root, Vector2 sizeDelta) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60006F2")]
	public void CreateOffscreenTexture(Vector2 ssize) { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x6000701")]
	public bool get_IsPlayLoop() { }

	[Address(RVA = "0x27173D0", Offset = "0x27167D0", Length = "0x54")]
	[Token(Token = "0x600070D")]
	public static string GetActorNameLabel(PlayActor tactor) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000710")]
	public string GetDebugString() { }

	[Address(RVA = "0x2717430", Offset = "0x2716830", Length = "0xDB")]
	[Token(Token = "0x6000700")]
	public string GetDisplayRound(int nstage) { }

	[Address(RVA = "0x2717510", Offset = "0x2716910", Length = "0x1D")]
	[Token(Token = "0x600070F")]
	public string GetGamertag() { }

	[Address(RVA = "0x2717570", Offset = "0x2716970", Length = "0x50")]
	[Token(Token = "0x60006F6")]
	public Sprite GetNumber(int n) { }

	[Address(RVA = "0x2717530", Offset = "0x2716930", Length = "0x3C")]
	[Token(Token = "0x60006F7")]
	public Vector2 GetNumberScale(int nnum) { }

	[Address(RVA = "0x27175D0", Offset = "0x27169D0", Length = "0xB7")]
	[Token(Token = "0x6000708")]
	private Vector2 GetOffScreenSize() { }

	[Address(RVA = "0x2717690", Offset = "0x2716A90", Length = "0x379")]
	[Token(Token = "0x6000706")]
	public string GetOpeningText() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60006FE")]
	public PlayActor GetPlayActor() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60006FD")]
	public PlayMode GetPlayMode() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x60006FF")]
	public PlayStage GetPlayStage() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x60006FA")]
	public SoundDataBaseRecords GetSoundDb() { }

	[Address(RVA = "0x2717A10", Offset = "0x2716E10", Length = "0x9B")]
	[Token(Token = "0x60006F8")]
	public Record GetSoundInformation(string rname) { }

	[Address(RVA = "0x2717AB0", Offset = "0x2716EB0", Length = "0x21")]
	[Token(Token = "0x60006F9")]
	public Record[] GetSoundLists(SCType tkind) { }

	[Address(RVA = "0x2717AE0", Offset = "0x2716EE0", Length = "0x67")]
	[IteratorStateMachine(typeof(<Initialize>d__1))]
	[Token(Token = "0x60006F1")]
	public IEnumerator Initialize() { }

	[Address(RVA = "0x2717B50", Offset = "0x2716F50", Length = "0x11")]
	[Token(Token = "0x6000703")]
	public bool IsPlayModeArcade() { }

	[Address(RVA = "0x2717B70", Offset = "0x2716F70", Length = "0x8")]
	[Token(Token = "0x6000702")]
	public bool IsPlayModeStory() { }

	[Address(RVA = "0x2717B80", Offset = "0x2716F80", Length = "0x8")]
	[Token(Token = "0x6000704")]
	public bool IsPlayModeTeam() { }

	[Address(RVA = "0x2717B90", Offset = "0x2716F90", Length = "0x8")]
	[Token(Token = "0x6000705")]
	public bool IsPlayModeTutorial() { }

	[Address(RVA = "0x2717BA0", Offset = "0x2716FA0", Length = "0x67")]
	[IteratorStateMachine(typeof(<LoadDatas>d__34))]
	[Token(Token = "0x6000711")]
	private IEnumerator LoadDatas() { }

	[Address(RVA = "0x2717C10", Offset = "0x2717010", Length = "0x43")]
	[Token(Token = "0x60006F5")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x2717C60", Offset = "0x2717060", Length = "0x19")]
	[Token(Token = "0x600070B")]
	private void OnPauseRequestedByPlatform() { }

	[Address(RVA = "0x2717C80", Offset = "0x2717080", Length = "0x119")]
	[Token(Token = "0x6000712")]
	private void ReleaseDatas() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000709")]
	private void ReleaseOffscreenTexture() { }

	[Address(RVA = "0x2717DA0", Offset = "0x27171A0", Length = "0xA7")]
	[Token(Token = "0x60006FB")]
	public void SetPlayMode(PlayMode tmode, PlayActor tactor, PlayStage tstage, int tround = 0, bool isLoop = false) { }

	[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
	[Token(Token = "0x60006FC")]
	public void SetPlayStage(PlayStage tstage) { }

	[Address(RVA = "0x2717E50", Offset = "0x2717250", Length = "0xAB")]
	[Token(Token = "0x600070A")]
	public static void SetTrophy(ID tropyId) { }

	[Address(RVA = "0x2717F00", Offset = "0x2717300", Length = "0x233")]
	[Token(Token = "0x60006F4")]
	public void Terminate() { }

	[Address(RVA = "0x2718220", Offset = "0x2717620", Length = "0x11")]
	[Token(Token = "0x60006F3")]
	protected void Update() { }

}

