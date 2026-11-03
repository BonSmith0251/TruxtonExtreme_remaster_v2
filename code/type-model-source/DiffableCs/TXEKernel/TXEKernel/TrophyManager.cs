namespace TXEKernel;

[Token(Token = "0x20000A6")]
public class TrophyManager : SimpleSingleton<TrophyManager>
{
	[CompilerGenerated]
	[Token(Token = "0x20000A8")]
	private struct <Initialize>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000373")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000374")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000375")]
		public TrophyManager <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2704C50", Offset = "0x2704050", Length = "0x218")]
		[Token(Token = "0x6000570")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000571")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20000A7")]
	internal enum ID : int
	{
		ExtremePlayer = 0,
		Welcome = 1,
		Initialized = 2,
		Doguraba = 3,
		Soroo = 4,
		Aserga = 5,
		Ipan = 6,
		Guamy = 7,
		Sama = 8,
		Gashim = 9,
		Barley = 10,
		EpisodeAsh = 11,
		EpisodeBelgamt = 12,
		EpisodeChria = 13,
		Pipiru = 14,
		Team = 15,
		Arena = 16,
		Arcade = 17,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400035F")]
	private readonly Dictionary<ID, String> _idToAchievementName; //Field offset: 0x10

	[Address(RVA = "0x2701050", Offset = "0x2700450", Length = "0x361")]
	[Token(Token = "0x600056F")]
	public TrophyManager() { }

	[Address(RVA = "0x2700D20", Offset = "0x2700120", Length = "0xBC")]
	[Token(Token = "0x600056C")]
	public void Award(ID trophyId) { }

	[Address(RVA = "0x2700DE0", Offset = "0x27001E0", Length = "0x1AB")]
	[AsyncStateMachine(typeof(<Initialize>d__2))]
	[Token(Token = "0x6000569")]
	public UniTask Initialize() { }

	[Address(RVA = "0x2700F90", Offset = "0x2700390", Length = "0x76")]
	[Token(Token = "0x600056D")]
	public bool IsAwarded(ID trophyId) { }

	[Address(RVA = "0x2701010", Offset = "0x2700410", Length = "0x32")]
	[Token(Token = "0x600056E")]
	public void ShowTrophyList() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600056B")]
	public void Terminate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600056A")]
	public void Update() { }

}

