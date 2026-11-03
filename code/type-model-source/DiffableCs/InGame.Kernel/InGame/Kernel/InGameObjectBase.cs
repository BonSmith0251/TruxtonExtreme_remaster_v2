namespace InGame.Kernel;

[Token(Token = "0x2000071")]
public abstract class InGameObjectBase : InGameRenderBase
{
	[Flags]
	[Token(Token = "0x2000072")]
	internal enum EntryObjectFlag : uint
	{
		None = 0,
		NoPlayAnime = 1,
		NoPlayParticle = 2,
	}

	[Token(Token = "0x400039E")]
	private static bool isQuitPhase; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400039F")]
	private EntryObjectFlag _entryFlag; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40003A0")]
	private PlayLayer _particleLayer; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003A1")]
	protected ParticleSystem[] _psystems; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003A2")]
	protected Animator[] _animators; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003A3")]
	protected GameObject GameObjectCache; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003A4")]
	private bool _animatorsPlay; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x40003A5")]
	protected bool _isEntryInGame; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x40003A6")]
	private bool _isEntryGround; //Field offset: 0x52
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40003A7")]
	private float _particleTimeScale; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003A8")]
	private float _particleSpeed; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40003A9")]
	private int _animatorsCount; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003AA")]
	private int _psystemCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40003AB")]
	protected bool _withRenderer; //Field offset: 0x64

	[Token(Token = "0x170000DF")]
	public bool IsEntryInGame
	{
		[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
		[Token(Token = "0x60004B1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E0")]
	public bool IsGroundObject
	{
		[Address(RVA = "0x1CF2E10", Offset = "0x1CF2210", Length = "0x5")]
		[Token(Token = "0x60004B2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000DE")]
	protected PlayLayer ParticleLayer
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x60004B0")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1D1D7D0", Offset = "0x1D1CBD0", Length = "0x4F")]
	[Token(Token = "0x60004AF")]
	private bool _isPlaying(ParticleSystem _p) { }

	[Address(RVA = "0x1D1D7C0", Offset = "0x1D1CBC0", Length = "0xE")]
	[Token(Token = "0x60004B3")]
	protected InGameObjectBase() { }

	[Address(RVA = "0x1D1C5D0", Offset = "0x1D1B9D0", Length = "0x29")]
	[Token(Token = "0x6000492")]
	public void ClearAnimatorData() { }

	[Address(RVA = "0x1D1C600", Offset = "0x1D1BA00", Length = "0xF3")]
	[Token(Token = "0x6000493")]
	public void DisableAnimatorData(bool isArena) { }

	[Address(RVA = "0x1D1C700", Offset = "0x1D1BB00", Length = "0x1EC")]
	[Token(Token = "0x6000497")]
	public override void EntryInGame() { }

	[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
	[Token(Token = "0x60004B1")]
	public bool get_IsEntryInGame() { }

	[Address(RVA = "0x1CF2E10", Offset = "0x1CF2210", Length = "0x5")]
	[Token(Token = "0x60004B2")]
	public bool get_IsGroundObject() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x60004B0")]
	protected PlayLayer get_ParticleLayer() { }

	[Address(RVA = "0x1D1C8F0", Offset = "0x1D1BCF0", Length = "0x3A")]
	[Token(Token = "0x60004A8")]
	public Animator GetAnimator(int index) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60004AE")]
	public override GameObject GetObject() { }

	[Address(RVA = "0x1D1C930", Offset = "0x1D1BD30", Length = "0x1F3")]
	[Token(Token = "0x6000491")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D1CB30", Offset = "0x1D1BF30", Length = "0x8")]
	[Token(Token = "0x60004AA")]
	public bool IsAnimationData() { }

	[Address(RVA = "0x1D1CB40", Offset = "0x1D1BF40", Length = "0x95")]
	[Token(Token = "0x60004AB")]
	public override bool IsPlayingInGame(float dt) { }

	[Address(RVA = "0x1D1CBE0", Offset = "0x1D1BFE0", Length = "0x36")]
	[Token(Token = "0x6000495")]
	private void OnApplicationQuit() { }

	[Address(RVA = "0x1D1CC20", Offset = "0x1D1C020", Length = "0x5A")]
	[Token(Token = "0x6000496")]
	private void OnDestroy() { }

	[Address(RVA = "0x1D1CC80", Offset = "0x1D1C080", Length = "0x11B")]
	[Token(Token = "0x60004A6")]
	public void PauseParticles(bool isPause) { }

	[Address(RVA = "0x1D1CE80", Offset = "0x1D1C280", Length = "0x33")]
	[Token(Token = "0x60004A7")]
	public Animator PlayAnimator(int index, string keystr) { }

	[Address(RVA = "0x1D1CDA0", Offset = "0x1D1C1A0", Length = "0xDF")]
	[Token(Token = "0x60004A9")]
	public Animator PlayAnimator(int index, int hashkey) { }

	[Address(RVA = "0x1D1CEC0", Offset = "0x1D1C2C0", Length = "0x153")]
	[Token(Token = "0x6000499")]
	public override void RemoveInGame() { }

	[Address(RVA = "0x1CEB210", Offset = "0x1CEA610", Length = "0x4")]
	[Token(Token = "0x6000498")]
	public void SetGround(bool v) { }

	[Address(RVA = "0x1D1D020", Offset = "0x1D1C420", Length = "0x127")]
	[Token(Token = "0x60004A2")]
	public void SetMaxParticles(int tmax, string tkeyword) { }

	[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
	[Token(Token = "0x60004A1")]
	public void SetParticlesTimeScale(float tspeed) { }

	[Address(RVA = "0x1D1D160", Offset = "0x1D1C560", Length = "0x8F")]
	[Token(Token = "0x60004AC")]
	public void SetPlayOnAwake(bool isAwake) { }

	[Address(RVA = "0x1D1D1F0", Offset = "0x1D1C5F0", Length = "0x93")]
	[Token(Token = "0x600049E")]
	public void SetRandomSeed(uint tseed) { }

	[Address(RVA = "0x1D1D290", Offset = "0x1D1C690", Length = "0x25")]
	[Token(Token = "0x60004AD")]
	public override void SetupCache() { }

	[Address(RVA = "0x1D1D2C0", Offset = "0x1D1C6C0", Length = "0x8B")]
	[Token(Token = "0x60004A4")]
	public void SetupParticlesTimeScale(float bspeed) { }

	[Address(RVA = "0x1D1D350", Offset = "0x1D1C750", Length = "0x97")]
	[Token(Token = "0x600049A")]
	public override void StartAll() { }

	[Address(RVA = "0x1D1D3F0", Offset = "0x1D1C7F0", Length = "0x77")]
	[Token(Token = "0x600049C")]
	public void StartAnime() { }

	[Address(RVA = "0x1D1D470", Offset = "0x1D1C870", Length = "0x67")]
	[Token(Token = "0x600049F")]
	public override void StartParticles() { }

	[Address(RVA = "0x1D1D4E0", Offset = "0x1D1C8E0", Length = "0xB7")]
	[Token(Token = "0x600049B")]
	public override void StopAll() { }

	[Address(RVA = "0x1D1D5A0", Offset = "0x1D1C9A0", Length = "0x9B")]
	[Token(Token = "0x600049D")]
	public void StopAnime(bool withForce = false) { }

	[Address(RVA = "0x1D1D640", Offset = "0x1D1CA40", Length = "0x6A")]
	[Token(Token = "0x60004A0")]
	public override void StopParticles() { }

	[Address(RVA = "0x1D1D6B0", Offset = "0x1D1CAB0", Length = "0x5C")]
	[Token(Token = "0x6000494")]
	public virtual void Terminate() { }

	[Address(RVA = "0x1D1D710", Offset = "0x1D1CB10", Length = "0x9B")]
	[Token(Token = "0x60004A5")]
	public void UpdateParticlesTimeScale(float bspeed) { }

	[Address(RVA = "0x1D1D7B0", Offset = "0x1D1CBB0", Length = "0x4")]
	[Token(Token = "0x60004A3")]
	public void WithRenderer(bool _v) { }

}

