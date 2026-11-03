namespace TXEKernel;

[Token(Token = "0x2000050")]
public class RankingsManager : SimpleSingleton<RankingsManager>
{
	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private struct <GetRankings>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FE")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001FF")]
		public AsyncUniTaskMethodBuilder<ValueTuple`2<List`1<ValueTuple`5<Int32, String, Int64, Int32, Int32>>, Result>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000200")]
		public ID boardId; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000201")]
		public int offset; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000202")]
		public int limit; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000203")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Result", "IOFailure"})]
		private TaskAwaiter<ValueTuple`2<LeaderboardFindResult_t, Boolean>> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000204")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Result", "IOFailure"})]
		private TaskAwaiter<ValueTuple`2<LeaderboardScoresDownloaded_t, Boolean>> <>u__2; //Field offset: 0x40

		[Address(RVA = "0x26E5040", Offset = "0x26E4440", Length = "0x9A9")]
		[Token(Token = "0x6000275")]
		private override void MoveNext() { }

		[Address(RVA = "0x26E59F0", Offset = "0x26E4DF0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000276")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private struct <GetUserRankings>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000205")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000206")]
		public AsyncUniTaskMethodBuilder<ValueTuple`3<Int32, List`1<ValueTuple`5<Int32, String, Int64, Int32, Int32>>, Result>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000207")]
		public ID boardId; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000208")]
		public RankingsManager <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000209")]
		public int limit; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400020A")]
		private int <userRank>5__2; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400020B")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Result", "IOFailure"})]
		private TaskAwaiter<ValueTuple`2<LeaderboardFindResult_t, Boolean>> <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400020C")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Result", "IOFailure"})]
		private TaskAwaiter<ValueTuple`2<LeaderboardScoresDownloaded_t, Boolean>> <>u__2; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400020D")]
		private Awaiter<ValueTuple<List`1<ValueTuple`5<Int32, String, Int64, Int32, Int32>>, Result>> <>u__3; //Field offset: 0x58

		[Address(RVA = "0x26E5E10", Offset = "0x26E5210", Length = "0xB34")]
		[Token(Token = "0x6000277")]
		private override void MoveNext() { }

		[Address(RVA = "0x26E6950", Offset = "0x26E5D50", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000278")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private struct <RegistScore>d__14 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400020F")]
		public AsyncUniTaskMethodBuilder<ValueTuple`2<Int32, Result>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000210")]
		public ID boardId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000211")]
		public long score; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000212")]
		public int round; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000213")]
		public int stage; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000214")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Result", "IOFailure"})]
		private TaskAwaiter<ValueTuple`2<LeaderboardFindResult_t, Boolean>> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000215")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Result", "IOFailure"})]
		private TaskAwaiter<ValueTuple`2<LeaderboardScoreUploaded_t, Boolean>> <>u__2; //Field offset: 0x40

		[Address(RVA = "0x2705050", Offset = "0x2704450", Length = "0x797")]
		[Token(Token = "0x6000279")]
		private override void MoveNext() { }

		[Address(RVA = "0x27057F0", Offset = "0x2704BF0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600027A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000052")]
	internal enum ID : int
	{
		Unknown = -1,
		StoryAshEp1 = 0,
		StoryAshEp2 = 1,
		StoryAshEp3 = 2,
		StoryAshEp4 = 3,
		StoryAshEp5 = 4,
		StoryAshEp6 = 5,
		StoryBergamotEp1 = 6,
		StoryBergamotEp2 = 7,
		StoryBergamotEp3 = 8,
		StoryBergamotEp4 = 9,
		StoryBergamotEp5 = 10,
		StoryBergamotEp6 = 11,
		StoryChriaEp1 = 12,
		StoryChriaEp2 = 13,
		StoryChriaEp3 = 14,
		StoryChriaEp4 = 15,
		StoryChriaEp5 = 16,
		StoryChriaEp6 = 17,
		Team = 18,
		ArcadeOnce = 19,
		ArcadeInfinity = 20,
		Arena = 21,
		MAX = 22,
	}

	[Token(Token = "0x2000051")]
	internal enum Result : int
	{
		Done = 0,
		HighScoreUpdated = 1,
		OutOfRange = 2,
		NotBestScore = 3,
		NotSignedIn = 4,
		Maintenance = 5,
		NetworkError = 6,
		UserErrorForNX2 = 7,
		UnknownError = 8,
	}

	[Token(Token = "0x40001D8")]
	public const int DefaultFetchLimit = 10; //Field offset: 0x0
	[Token(Token = "0x40001DA")]
	private const float SteamCallTimeoutSeconds = 6; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D9")]
	private Dictionary<PlayActor, List`1<ID>> episodeMap; //Field offset: 0x10

	[Token(Token = "0x17000097")]
	public bool HiddenAccessSpinner
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000273")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000096")]
	public int IdCount
	{
		[Address(RVA = "0x25A87B0", Offset = "0x25A7BB0", Length = "0x6")]
		[Token(Token = "0x600026A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x26DF850", Offset = "0x26DEC50", Length = "0x77C")]
	[Token(Token = "0x6000274")]
	public RankingsManager() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000273")]
	public bool get_HiddenAccessSpinner() { }

	[Address(RVA = "0x25A87B0", Offset = "0x25A7BB0", Length = "0x6")]
	[Token(Token = "0x600026A")]
	public int get_IdCount() { }

	[Address(RVA = "0x26DF3A0", Offset = "0x26DE7A0", Length = "0x104")]
	[AsyncStateMachine(typeof(<GetRankings>d__13))]
	[Token(Token = "0x6000271")]
	public UniTask<ValueTuple`2<List`1<ValueTuple`5<Int32, String, Int64, Int32, Int32>>, Result>> GetRankings(ID boardId, int offset, int limit = 10) { }

	[Address(RVA = "0x26DFFD0", Offset = "0x26DF3D0", Length = "0xBF")]
	[Token(Token = "0x600026B")]
	private ID getStoryID(PlayActor actor, int episode) { }

	[Address(RVA = "0x26DF4B0", Offset = "0x26DE8B0", Length = "0x139")]
	[AsyncStateMachine(typeof(<GetUserRankings>d__12))]
	[Token(Token = "0x6000270")]
	public UniTask<ValueTuple`3<Int32, List`1<ValueTuple`5<Int32, String, Int64, Int32, Int32>>, Result>> GetUserRankings(ID boardId, int limit = 10) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600026D")]
	public void Initialize() { }

	[Address(RVA = "0x26DF5F0", Offset = "0x26DE9F0", Length = "0x12E")]
	[Token(Token = "0x600026C")]
	public ID PlayMode2ID(PlayMode playMode, PlayActor playActor, int episode, bool isLoopFlag) { }

	[Address(RVA = "0x26DF720", Offset = "0x26DEB20", Length = "0x122")]
	[AsyncStateMachine(typeof(<RegistScore>d__14))]
	[Token(Token = "0x6000272")]
	public UniTask<ValueTuple`2<Int32, Result>> RegistScore(ID boardId, long score, int round = 0, int stage = 0, InGameResult inGameResult = null) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600026F")]
	public void Terminate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600026E")]
	public void Update() { }

}

