namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000213")]
public class Ene_X01 : PawnEnemy
{
	[CompilerGenerated]
	[Token(Token = "0x2000216")]
	private struct <_followAndFire>d__26 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E7")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40012E8")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012E9")]
		public CancellationToken token; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40012EA")]
		public InGameBulletBow bow; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40012EB")]
		public Ene_X01 <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40012EC")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1D12BE0", Offset = "0x1D11FE0", Length = "0x3C2")]
		[Token(Token = "0x6000FB8")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000FB9")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000215")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012E5")]
		public Ene_X01 <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40012E6")]
		public CancellationToken token; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FB6")]
		public <>c__DisplayClass18_0() { }

		[Address(RVA = "0x1D12880", Offset = "0x1D11C80", Length = "0x25")]
		[Token(Token = "0x6000FB7")]
		internal void <_onBulletFire>b__0(InGameBulletInterface bullet) { }

	}

	[Token(Token = "0x2000214")]
	internal enum EneXType : int
	{
		First = 0,
		Second = 1,
		Third = 2,
	}

	[Token(Token = "0x40012D2")]
	private static readonly String[] _fanSequenceNames; //Field offset: 0x0
	[Token(Token = "0x40012D5")]
	private const float BowFollowSeconds = 0.2; //Field offset: 0x0
	[Token(Token = "0x40012D6")]
	private const float BowFireDelaySeconds = 0; //Field offset: 0x0
	[Token(Token = "0x40012D7")]
	private const float FanSequenceIntervalSeconds = 0.5; //Field offset: 0x0
	[Token(Token = "0x40012D3")]
	private static readonly HashSet<String> _fanStartTriggerNames; //Field offset: 0x8
	[Token(Token = "0x40012D4")]
	private static readonly List<String> _bulletTemplateNames; //Field offset: 0x10
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40012D8")]
	private float _firePosRadius; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40012D9")]
	private readonly Dictionary<InGameBulletBow, Vector3> _bowFollowerOffsets; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40012DA")]
	private readonly List<InGameBulletBow> _bowFollowersToRemove; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40012DB")]
	private CancellationToken _fanSequenceToken; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40012DC")]
	private bool _isFanSequenceRunning; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x40012DD")]
	private float _fanSequenceTime; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40012DE")]
	private int _fanSequenceIndex; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[SerializeField]
	[Token(Token = "0x40012DF")]
	private Kind _item; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x40012E0")]
	private EneXType _eneXType; //Field offset: 0x1E0

	[Address(RVA = "0x1D098D0", Offset = "0x1D08CD0", Length = "0x1AB")]
	[Token(Token = "0x6000FB1")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1D09A80", Offset = "0x1D08E80", Length = "0x13F")]
	[Token(Token = "0x6000FAB")]
	private bool _canFireFanBullet() { }

	[Address(RVA = "0x1D0A3D0", Offset = "0x1D097D0", Length = "0x1D9")]
	[Token(Token = "0x6000FB0")]
	private void _clearBowFollowers() { }

	[Address(RVA = "0x1D0A6A0", Offset = "0x1D09AA0", Length = "0x3B3")]
	[Token(Token = "0x6000FAA")]
	private void _fireFanByIndex(int sequenceIndex) { }

	[Address(RVA = "0x1D0AA60", Offset = "0x1D09E60", Length = "0xC8")]
	[AsyncStateMachine(typeof(<_followAndFire>d__26))]
	[Token(Token = "0x6000FAE")]
	private UniTaskVoid _followAndFire(InGameBulletBow bow, CancellationToken token) { }

	[Address(RVA = "0x1D0AB30", Offset = "0x1D09F30", Length = "0x255")]
	[Token(Token = "0x6000FA6")]
	private void _onBulletFire(CancellationToken token, RouteEvent _event) { }

	[Address(RVA = "0x1D0AD90", Offset = "0x1D0A190", Length = "0x145")]
	[Token(Token = "0x6000FAC")]
	private void _onBulletGenerated(InGameBulletInterface bullet, CancellationToken token) { }

	[Address(RVA = "0x1D0AEE0", Offset = "0x1D0A2E0", Length = "0x2A6")]
	[Token(Token = "0x6000FAD")]
	private void _registerBowFollower(InGameBulletBow bullet) { }

	[Address(RVA = "0x1D0B190", Offset = "0x1D0A590", Length = "0xAF")]
	[Token(Token = "0x6000FA7")]
	private void _startFanSequence(CancellationToken token) { }

	[Address(RVA = "0x1D0B240", Offset = "0x1D0A640", Length = "0x18")]
	[Token(Token = "0x6000FA8")]
	private void _stopFanSequence() { }

	[Address(RVA = "0x1D0B260", Offset = "0x1D0A660", Length = "0x505")]
	[Token(Token = "0x6000FAF")]
	private void _updateBowFollowers() { }

	[Address(RVA = "0x1D0B770", Offset = "0x1D0AB70", Length = "0x54E")]
	[Token(Token = "0x6000FA9")]
	private void _updateFanSequence(float dt) { }

	[Address(RVA = "0x1D09BC0", Offset = "0x1D08FC0", Length = "0x80B")]
	[Token(Token = "0x6000FB4")]
	private static Ene_X01() { }

	[Address(RVA = "0x1D0A5B0", Offset = "0x1D099B0", Length = "0xEA")]
	[Token(Token = "0x6000FB3")]
	public Ene_X01() { }

	[Address(RVA = "0x1D098C0", Offset = "0x1D08CC0", Length = "0xF")]
	[CompilerGenerated]
	[Token(Token = "0x6000FB5")]
	private void <_fireFanByIndex>b__22_0(InGameBulletInterface bullet) { }

	[Address(RVA = "0x1D094D0", Offset = "0x1D088D0", Length = "0xAA")]
	[Token(Token = "0x6000FB2")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D09580", Offset = "0x1D08980", Length = "0x1CE")]
	[Token(Token = "0x6000FA5")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D09750", Offset = "0x1D08B50", Length = "0x9E")]
	[Token(Token = "0x6000FA1")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D097F0", Offset = "0x1D08BF0", Length = "0x3B")]
	[Token(Token = "0x6000FA3")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D09830", Offset = "0x1D08C30", Length = "0x4E")]
	[Token(Token = "0x6000FA2")]
	public virtual void Terminate() { }

	[Address(RVA = "0x1D09880", Offset = "0x1D08C80", Length = "0x36")]
	[Token(Token = "0x6000FA4")]
	public virtual void ToDestroid() { }

}

