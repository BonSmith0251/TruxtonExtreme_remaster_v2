namespace OutGame.Utility;

[Token(Token = "0x2000069")]
public static class OutGameUtility
{
	[CompilerGenerated]
	[Token(Token = "0x200006A")]
	private struct <MuteSE>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000189")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400018A")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400018B")]
		public float muteSecond; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400018C")]
		public CancellationToken cts; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400018D")]
		private SoundManager <m>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400018E")]
		private InGameManager <gm>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400018F")]
		private Awaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x21C7F00", Offset = "0x21C7300", Length = "0x440")]
		[Token(Token = "0x600029E")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600029F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000186")]
	private static readonly String[] _ashsStory; //Field offset: 0x0
	[Token(Token = "0x4000187")]
	private static readonly String[] _bergamotsStory; //Field offset: 0x8
	[Token(Token = "0x4000188")]
	private static readonly String[] _chriasStory; //Field offset: 0x10

	[Address(RVA = "0x21C2550", Offset = "0x21C1950", Length = "0x400")]
	[Token(Token = "0x600029D")]
	private static OutGameUtility() { }

	[Address(RVA = "0x21C2290", Offset = "0x21C1690", Length = "0x133")]
	[Token(Token = "0x600029B")]
	public static string GetComicLabel(PlayActor tactor, int stageIndex) { }

	[Address(RVA = "0x21C23D0", Offset = "0x21C17D0", Length = "0x69")]
	[Token(Token = "0x600029C")]
	public static string GetPipiruComicLabel() { }

	[Address(RVA = "0x21C2440", Offset = "0x21C1840", Length = "0x14")]
	[Token(Token = "0x600029A")]
	public static int GetStoryStageIndex(PlayActor nactor, int nindex) { }

	[Address(RVA = "0x21C2460", Offset = "0x21C1860", Length = "0xED")]
	[AsyncStateMachine(typeof(<MuteSE>d__0))]
	[Token(Token = "0x6000299")]
	public static UniTask MuteSE(float muteSecond, CancellationToken cts) { }

}

