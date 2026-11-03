namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001F8")]
public class Ene_Mn01h : KnightEnemy
{
	[CompilerGenerated]
	[Token(Token = "0x20001F9")]
	private struct <_fire>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011C5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40011C6")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011C7")]
		public Ene_Mn01h <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40011C8")]
		private Awaiter <>u__1; //Field offset: 0x20

		[Address(RVA = "0x1D128B0", Offset = "0x1D11CB0", Length = "0x32D")]
		[Token(Token = "0x6000F14")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000F15")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x40011AC")]
	private static readonly float _STARTPOS; //Field offset: 0x0
	[FieldOffset(Offset = "0x210")]
	[SerializeField]
	[Token(Token = "0x40011AD")]
	private string _useBullet; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40011AE")]
	private BulletTemplate _useBT; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40011AF")]
	private Vector3 _localPosition; //Field offset: 0x220
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x40011B0")]
	private Vector3 _localEuler; //Field offset: 0x22C
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x40011B1")]
	private float _spinSpeed; //Field offset: 0x238
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x40011B2")]
	private float _spinTimer; //Field offset: 0x23C
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x40011B3")]
	private bool _spinFlag; //Field offset: 0x240
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x40011B4")]
	private int _state; //Field offset: 0x244
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x40011B5")]
	private float _stateTime; //Field offset: 0x248
	[FieldOffset(Offset = "0x24C")]
	[SerializeField]
	[Token(Token = "0x40011B6")]
	private float _slowWait; //Field offset: 0x24C
	[FieldOffset(Offset = "0x250")]
	[SerializeField]
	[Token(Token = "0x40011B7")]
	private float _slowLine; //Field offset: 0x250
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x40011B8")]
	private float _velZ; //Field offset: 0x254
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40011B9")]
	private float _accZ; //Field offset: 0x258
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x40011BA")]
	private bool _summonStart; //Field offset: 0x25C
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40011BB")]
	private float _summonTimer; //Field offset: 0x260
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x40011BC")]
	private int _summonCount; //Field offset: 0x264
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40011BD")]
	private int _summonState; //Field offset: 0x268
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x40011BE")]
	private bool _isSummonEnd; //Field offset: 0x26C
	[FieldOffset(Offset = "0x270")]
	[SerializeField]
	[Token(Token = "0x40011BF")]
	private AnimationCurve _inCurve; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	[Token(Token = "0x40011C0")]
	private AnimationCurve _spinCurve; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Header("子機と親機の距離")]
	[SerializeField]
	[Token(Token = "0x40011C1")]
	private float _childRangeMin; //Field offset: 0x280
	[FieldOffset(Offset = "0x284")]
	[SerializeField]
	[Token(Token = "0x40011C2")]
	private float _childRangeMax; //Field offset: 0x284
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x40011C3")]
	private Transform _muzzle; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x40011C4")]
	private float _shotWait; //Field offset: 0x290

	[Address(RVA = "0x1CFC7E0", Offset = "0x1CFBBE0", Length = "0x22")]
	[Token(Token = "0x6000F0E")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1CFC850", Offset = "0x1CFBC50", Length = "0x3C5")]
	[Token(Token = "0x6000F0D")]
	private void _createChildren() { }

	[Address(RVA = "0x1CFCD30", Offset = "0x1CFC130", Length = "0x1BB")]
	[AsyncStateMachine(typeof(<_fire>d__8))]
	[Token(Token = "0x6000F11")]
	private UniTask _fire() { }

	[Address(RVA = "0x1CFC810", Offset = "0x1CFBC10", Length = "0x39")]
	[Token(Token = "0x6000F13")]
	private static Ene_Mn01h() { }

	[Address(RVA = "0x1CFCC20", Offset = "0x1CFC020", Length = "0x10A")]
	[Token(Token = "0x6000F12")]
	public Ene_Mn01h() { }

	[Address(RVA = "0x1CFBF90", Offset = "0x1CFB390", Length = "0x147")]
	[Token(Token = "0x6000F10")]
	public virtual void ChildDieCallback(PawnEnemy pe) { }

	[Address(RVA = "0x1CFC0E0", Offset = "0x1CFB4E0", Length = "0x76")]
	[Token(Token = "0x6000F0C")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1CFC160", Offset = "0x1CFB560", Length = "0xB1")]
	[Token(Token = "0x6000F0A")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1CFC220", Offset = "0x1CFB620", Length = "0x454")]
	[Token(Token = "0x6000F0F")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1CFC680", Offset = "0x1CFBA80", Length = "0x159")]
	[Token(Token = "0x6000F0B")]
	public virtual void ReStart(bool withPlay) { }

}

