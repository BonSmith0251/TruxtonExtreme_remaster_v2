namespace InGame.Kernel.Effect;

[Token(Token = "0x2000237")]
public class InGameEffect : InGameObject, IPrefabBankObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000238")]
	private struct <_progressAsyncDelay>d__23 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013B0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40013B1")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40013B2")]
		public InGameEffect <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40013B3")]
		public float tdelay; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40013B4")]
		public Action callback; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40013B5")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x1D1AC10", Offset = "0x1D1A010", Length = "0x35E")]
		[Token(Token = "0x60010F5")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60010F6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4001398")]
	private bool _isTimelimit; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x4001399")]
	private float _timelimitSecond; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400139A")]
	private ID _callSoundID; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400139B")]
	private ID _startSoundID; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400139C")]
	private float _passedSecond; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x400139D")]
	private int _sortlayerID; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x400139E")]
	private ParticleSystem _rootParticle; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400139F")]
	private CancellationToken _token; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40013A0")]
	private InGameEffectStopper _stopAct; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40013A1")]
	private Transform _transform; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40013A2")]
	private bool _isMoveVector; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x40013A3")]
	private bool _isLoop; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAA")]
	[Token(Token = "0x40013A4")]
	private bool _isStartEffect; //Field offset: 0xAA
	[FieldOffset(Offset = "0xAB")]
	[Token(Token = "0x40013A5")]
	private bool _isDone; //Field offset: 0xAB
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40013A6")]
	private Vector3 _startVector; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40013A7")]
	private Vector3 _moveVector; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40013A8")]
	private float _moveSecondMax; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40013A9")]
	private float _moveSecond; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40013AA")]
	private int _nlayer; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40013AB")]
	private int _hashCode; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40013AC")]
	private int _poolIndex; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40013AD")]
	private int _burstIndex; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40013AE")]
	private List<Int32> _psystemMaxs; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40013AF")]
	private List<Color> _psystemColors; //Field offset: 0xE8

	[Token(Token = "0x1700022F")]
	public int BurstIndex
	{
		[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
		[Token(Token = "0x60010F3")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000226")]
	public ID CallSoundID
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x60010EA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700022D")]
	public int HashCode
	{
		[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
		[Token(Token = "0x60010F1")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700022B")]
	public bool IsDone
	{
		[Address(RVA = "0x1D16D30", Offset = "0x1D16130", Length = "0x8")]
		[Token(Token = "0x60010EF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000229")]
	public bool IsLoop
	{
		[Address(RVA = "0x1D16D40", Offset = "0x1D16140", Length = "0x8")]
		[Token(Token = "0x60010ED")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000228")]
	public bool IsMoveVector
	{
		[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
		[Token(Token = "0x60010EC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700022A")]
	public bool IsStartEffect
	{
		[Address(RVA = "0x1D16D60", Offset = "0x1D16160", Length = "0x17")]
		[Token(Token = "0x60010EE")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700022E")]
	public int PoolIndex
	{
		[Address(RVA = "0xE26990", Offset = "0xE25D90", Length = "0x7")]
		[Token(Token = "0x60010F2")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700022C")]
	public Vector3 StartVector
	{
		[Address(RVA = "0x1D16D80", Offset = "0x1D16180", Length = "0x19")]
		[Token(Token = "0x60010F0")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000227")]
	public Transform TransfromCache
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x60010EB")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1D16C50", Offset = "0x1D16050", Length = "0xC0")]
	[AsyncStateMachine(typeof(<_progressAsyncDelay>d__23))]
	[Token(Token = "0x60010E2")]
	private UniTaskVoid _progressAsyncDelay(float tdelay, Action callback) { }

	[Address(RVA = "0x1D13F40", Offset = "0x1D13340", Length = "0xA8")]
	[Token(Token = "0x60010F4")]
	public InGameEffect() { }

	[Address(RVA = "0x1D15830", Offset = "0x1D14C30", Length = "0xA2")]
	[Token(Token = "0x60010D5")]
	public virtual void EntryInGame() { }

	[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
	[Token(Token = "0x60010F3")]
	public int get_BurstIndex() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x60010EA")]
	public ID get_CallSoundID() { }

	[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
	[Token(Token = "0x60010F1")]
	public int get_HashCode() { }

	[Address(RVA = "0x1D16D30", Offset = "0x1D16130", Length = "0x8")]
	[Token(Token = "0x60010EF")]
	public bool get_IsDone() { }

	[Address(RVA = "0x1D16D40", Offset = "0x1D16140", Length = "0x8")]
	[Token(Token = "0x60010ED")]
	public bool get_IsLoop() { }

	[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
	[Token(Token = "0x60010EC")]
	public bool get_IsMoveVector() { }

	[Address(RVA = "0x1D16D60", Offset = "0x1D16160", Length = "0x17")]
	[Token(Token = "0x60010EE")]
	public bool get_IsStartEffect() { }

	[Address(RVA = "0xE26990", Offset = "0xE25D90", Length = "0x7")]
	[Token(Token = "0x60010F2")]
	public int get_PoolIndex() { }

	[Address(RVA = "0x1D16D80", Offset = "0x1D16180", Length = "0x19")]
	[Token(Token = "0x60010F0")]
	public Vector3 get_StartVector() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x60010EB")]
	public Transform get_TransfromCache() { }

	[Address(RVA = "0x1D158E0", Offset = "0x1D14CE0", Length = "0x1CD")]
	[Token(Token = "0x60010CB")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D15AB0", Offset = "0x1D14EB0", Length = "0xC3")]
	[Token(Token = "0x60010D7")]
	public virtual bool IsPlayingInGame(float dt) { }

	[Address(RVA = "0x1D15B80", Offset = "0x1D14F80", Length = "0x2D7")]
	[Token(Token = "0x60010DE")]
	public void KeepDefaults() { }

	[Address(RVA = "0x1D15E60", Offset = "0x1D15260", Length = "0x72")]
	[Token(Token = "0x60010E3")]
	protected override void PlayStartEffect() { }

	[Address(RVA = "0x1D15EE0", Offset = "0x1D152E0", Length = "0xFE")]
	[Token(Token = "0x60010E6")]
	public override bool ProgressEffect(float dt, float ts) { }

	[Address(RVA = "0x1D15FE0", Offset = "0x1D153E0", Length = "0x91")]
	[Token(Token = "0x60010D6")]
	public virtual void RemoveInGame() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60010E8")]
	public virtual void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D16080", Offset = "0x1D15480", Length = "0x7")]
	[Token(Token = "0x60010E9")]
	public void SetBurstIndex(int tindex) { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[Token(Token = "0x60010E0")]
	public void SetCallSoundID(ID tid) { }

	[Address(RVA = "0x1D160B0", Offset = "0x1D154B0", Length = "0x1BC")]
	[Token(Token = "0x60010DD")]
	protected override void SetDefaults() { }

	[Address(RVA = "0x1D160A0", Offset = "0x1D154A0", Length = "0xE")]
	[Token(Token = "0x60010E1")]
	public void SetDefaultSound() { }

	[Address(RVA = "0x1D16270", Offset = "0x1D15670", Length = "0x30")]
	[Token(Token = "0x60010CD")]
	public void SetEffectsLayer(int nlayer) { }

	[Address(RVA = "0x1D16450", Offset = "0x1D15850", Length = "0x20E")]
	[Token(Token = "0x60010DB")]
	public void SetFade(float trate) { }

	[Address(RVA = "0x1D162A0", Offset = "0x1D156A0", Length = "0x1A2")]
	[Token(Token = "0x60010DC")]
	public void SetFadeAlpha(float trate) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60010DA")]
	public override void SetIntEffect(int tint) { }

	[Address(RVA = "0x1D16660", Offset = "0x1D15A60", Length = "0xE")]
	[Token(Token = "0x60010D8")]
	public void SetPoolCallback(int hashCode, int pindex) { }

	[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
	[Token(Token = "0x60010DF")]
	public void SetSoundID(ID tid) { }

	[Address(RVA = "0x1D16680", Offset = "0x1D15A80", Length = "0x16")]
	[Token(Token = "0x60010D0")]
	public void SetStartVector(Vector3 spos) { }

	[Address(RVA = "0x1D16700", Offset = "0x1D15B00", Length = "0xC9")]
	[Token(Token = "0x60010D3")]
	private void SetupPos(Vector3 pos, bool isGround) { }

	[Address(RVA = "0x1D167D0", Offset = "0x1D15BD0", Length = "0x4B")]
	[Token(Token = "0x60010D4")]
	private void SetupStart() { }

	[Address(RVA = "0x1D16820", Offset = "0x1D15C20", Length = "0x34")]
	[Token(Token = "0x60010CC")]
	public void SetupTimelimit(float ltime) { }

	[Address(RVA = "0x1D166A0", Offset = "0x1D15AA0", Length = "0x57")]
	[Token(Token = "0x60010D9")]
	public void SetVectorEffect(Vector3 fv, float ttime) { }

	[Address(RVA = "0x1D16A10", Offset = "0x1D15E10", Length = "0x82")]
	[Token(Token = "0x60010D1")]
	public void StartEffect(Vector3 pos, bool isGround) { }

	[Address(RVA = "0x1D169A0", Offset = "0x1D15DA0", Length = "0x61")]
	[Token(Token = "0x60010CF")]
	public void StartEffect() { }

	[Address(RVA = "0x1D16860", Offset = "0x1D15C60", Length = "0x13A")]
	[Token(Token = "0x60010D2")]
	public void StartEffectWithDelay(Vector3 pos, bool isGround, float tdelay, Action callback) { }

	[Address(RVA = "0x1D16AA0", Offset = "0x1D15EA0", Length = "0x23")]
	[Token(Token = "0x60010E4")]
	public virtual void StartParticles() { }

	[Address(RVA = "0x1D16AD0", Offset = "0x1D15ED0", Length = "0x95")]
	[Token(Token = "0x60010E7")]
	public void StopEffect() { }

	[Address(RVA = "0x1D16B70", Offset = "0x1D15F70", Length = "0x26")]
	[Token(Token = "0x60010E5")]
	public virtual void StopParticles() { }

	[Address(RVA = "0x1D16BA0", Offset = "0x1D15FA0", Length = "0xA1")]
	[Token(Token = "0x60010CE")]
	public virtual void Terminate() { }

}

