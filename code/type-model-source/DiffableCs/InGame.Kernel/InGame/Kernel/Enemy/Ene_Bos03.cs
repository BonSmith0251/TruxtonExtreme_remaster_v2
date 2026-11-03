namespace InGame.Kernel.Enemy;

[Token(Token = "0x200018E")]
public class Ene_Bos03 : Ene_BosBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000193")]
	private struct <>c__DisplayClass68_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C86")]
		public Ene_Bos03 <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C87")]
		public float deltaTime; //Field offset: 0x8

	}

	[Token(Token = "0x2000191")]
	private enum Boss03BT : int
	{
		Laser00 = 0,
		FaceRoundL1 = 1,
		FaceRoundL2 = 2,
		FaceRoundL3 = 3,
		FaceRoundR1 = 4,
		FaceRoundR2 = 5,
		FaceRoundR3 = 6,
		Rapid3 = 7,
		SideWayL = 8,
		SideWayR = 9,
		Arm0 = 10,
		typeWay7 = 11,
		Turret = 12,
	}

	[Token(Token = "0x2000192")]
	private enum Boss03MZ : int
	{
		muzzle_body70 = 0,
		muzzle_body80 = 1,
		muzzle_body90 = 2,
		muzzle_arm40 = 3,
		muzzle_arm60 = 4,
		muzzle_body20 = 5,
		muzzle_body40 = 6,
		muzzle_body60 = 7,
		muzzle_battery40 = 8,
		muzzle_battery60 = 9,
		muzzle_shoulder40 = 10,
		muzzle_shoulder40e = 11,
		muzzle_shoulder60 = 12,
		muzzle_shoulder60e = 13,
	}

	[Token(Token = "0x200018F")]
	private enum Boss03State : int
	{
		EntryWait = 0,
		PT1 = 1,
		PT5Summon = 2,
		Destruction = 100,
		Timeover = 101,
	}

	[Token(Token = "0x2000190")]
	private enum PartsKind : int
	{
		MainBody = 0,
		ArmL = 1,
		ArmR = 2,
		Cover = 3,
		Face = 4,
		Shoulder40 = 5,
		Shoulder60 = 6,
	}

	[Token(Token = "0x4000C40")]
	private static readonly Quaternion _summonTimeRotate; //Field offset: 0x0
	[Token(Token = "0x4000C41")]
	private static readonly Vector3 _summonTimePosition; //Field offset: 0x10
	[Token(Token = "0x4000C42")]
	private static readonly Vector3 _summonOffset; //Field offset: 0x1C
	[Token(Token = "0x4000C43")]
	private static readonly Quaternion _timeOverRotate; //Field offset: 0x28
	[Token(Token = "0x4000C44")]
	private static readonly String[] _bos03enemyData; //Field offset: 0x38
	[Token(Token = "0x4000C45")]
	private static readonly EnemyChildData[] _bos03childdatas; //Field offset: 0x40
	[Token(Token = "0x4000C46")]
	private static readonly String[] routeNames; //Field offset: 0x48
	[Token(Token = "0x4000C47")]
	private static readonly String[] btNames; //Field offset: 0x50
	[Token(Token = "0x4000C4E")]
	private static readonly float _entryNoHitTime; //Field offset: 0x58
	[Token(Token = "0x4000C4F")]
	private static readonly float _entryEndWait; //Field offset: 0x5C
	[Token(Token = "0x4000C50")]
	private static readonly Vector3 _leftMoveOffset; //Field offset: 0x60
	[Token(Token = "0x4000C51")]
	private static readonly Vector3 _rightMoveOffset; //Field offset: 0x6C
	[Token(Token = "0x4000C52")]
	private static readonly float _oneWayMoveDuration; //Field offset: 0x78
	[Token(Token = "0x4000C53")]
	private static readonly float _oneWayMoveWait; //Field offset: 0x7C
	[Token(Token = "0x4000C54")]
	private static readonly float _summonSeconds; //Field offset: 0x80
	[Token(Token = "0x4000C55")]
	private static readonly float _summonCallHS; //Field offset: 0x84
	[Token(Token = "0x4000C56")]
	private static readonly float _summonCallST; //Field offset: 0x88
	[Token(Token = "0x4000C57")]
	private static readonly float _summonCallAC; //Field offset: 0x8C
	[Token(Token = "0x4000C58")]
	private static readonly float _CoverClosedFireInterval; //Field offset: 0x90
	[Token(Token = "0x4000C59")]
	private static readonly float _CoverOpenFireInterval; //Field offset: 0x94
	[Token(Token = "0x4000C5A")]
	private static Quaternion _basicRotate; //Field offset: 0x98
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000C31")]
	private Boss03State _bos03state; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4000C32")]
	private float _localTime; //Field offset: 0x274
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000C33")]
	private float _moveTime; //Field offset: 0x278
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4000C34")]
	private bool _isBackMove; //Field offset: 0x27C
	[FieldOffset(Offset = "0x27D")]
	[Token(Token = "0x4000C35")]
	private bool _isRightMove; //Field offset: 0x27D
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000C36")]
	private Vector3 _bos3MoveStartPosition; //Field offset: 0x280
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x4000C37")]
	private float _laserArcRate; //Field offset: 0x28C
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000C38")]
	private int _openedAttackCount; //Field offset: 0x290
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x4000C39")]
	private bool _isNoHit; //Field offset: 0x294
	[FieldOffset(Offset = "0x295")]
	[Token(Token = "0x4000C3A")]
	private bool _isCoverOpen; //Field offset: 0x295
	[FieldOffset(Offset = "0x296")]
	[Token(Token = "0x4000C3B")]
	private bool _isLaserFire; //Field offset: 0x296
	[FieldOffset(Offset = "0x297")]
	[Token(Token = "0x4000C3C")]
	private bool _isArmLBreak; //Field offset: 0x297
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000C3D")]
	private bool _isArmRBreak; //Field offset: 0x298
	[FieldOffset(Offset = "0x299")]
	[Token(Token = "0x4000C3E")]
	private bool _isShoulderTurn; //Field offset: 0x299
	[FieldOffset(Offset = "0x29A")]
	[Token(Token = "0x4000C3F")]
	private bool _isLeftRound; //Field offset: 0x29A
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x4000C48")]
	private readonly int MuzzleCount; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000C49")]
	private Transform[] _muzzles; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	[Token(Token = "0x4000C4A")]
	private ParticleSystem _smokeL; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x4000C4B")]
	private ParticleSystem _smokeR; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	[Token(Token = "0x4000C4C")]
	private Transform _shoulder40; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[SerializeField]
	[Token(Token = "0x4000C4D")]
	private Transform _shoulder60; //Field offset: 0x2C0

	[Token(Token = "0x170001EC")]
	private bool IsBothBreak
	{
		[Address(RVA = "0x1D85D00", Offset = "0x1D85100", Length = "0x14")]
		[Token(Token = "0x6000C65")]
		private get { } //Length: 20
	}

	[Address(RVA = "0x1D85480", Offset = "0x1D84880", Length = "0xD4")]
	[Token(Token = "0x6000C6D")]
	private void _callBT(int btIndex, Boss03MZ mz, float tangle = 0) { }

	[Address(RVA = "0x1D853B0", Offset = "0x1D847B0", Length = "0xCB")]
	[Token(Token = "0x6000C6E")]
	private void _callBTLaser(int btIndex, Boss03MZ mz, Boss03MZ mzdir) { }

	[Address(RVA = "0x1D85560", Offset = "0x1D84960", Length = "0x6C6")]
	[Token(Token = "0x6000C76")]
	private static Ene_Bos03() { }

	[Address(RVA = "0x1D85C30", Offset = "0x1D85030", Length = "0xC0")]
	[Token(Token = "0x6000C75")]
	public Ene_Bos03() { }

	[Address(RVA = "0x1D84A90", Offset = "0x1D83E90", Length = "0x319")]
	[CompilerGenerated]
	[Token(Token = "0x6000C79")]
	private bool <PatternMovePT1>g__Bos03Move|68_2(ref <>c__DisplayClass68_0 unnamed_param_0) { }

	[Address(RVA = "0x1D84A70", Offset = "0x1D83E70", Length = "0x1D")]
	[CompilerGenerated]
	[Token(Token = "0x6000C78")]
	private void <PatternMovePT1>g__Bos03MoveReset|68_1(Vector3 startPosition, ref <>c__DisplayClass68_0 unnamed_param_1) { }

	[Address(RVA = "0x1D84DB0", Offset = "0x1D841B0", Length = "0x13A")]
	[CompilerGenerated]
	[Token(Token = "0x6000C7A")]
	private bool <PatternMovePT1>g__FireBasicSet|68_3(ref <>c__DisplayClass68_0 unnamed_param_0) { }

	[Address(RVA = "0x1D84EF0", Offset = "0x1D842F0", Length = "0xC9")]
	[CompilerGenerated]
	[Token(Token = "0x6000C7D")]
	private void <PatternMovePT1>g__FireRoundShortLaser|68_6(ref <>c__DisplayClass68_0 unnamed_param_0) { }

	[Address(RVA = "0x1D84FC0", Offset = "0x1D843C0", Length = "0x63")]
	[CompilerGenerated]
	[Token(Token = "0x6000C77")]
	private void <PatternMovePT1>g__FireShoulderLaser|68_0(ref <>c__DisplayClass68_0 unnamed_param_0) { }

	[Address(RVA = "0x1D85030", Offset = "0x1D84430", Length = "0xB7")]
	[CompilerGenerated]
	[Token(Token = "0x6000C7E")]
	private void <PatternMovePT1>g__FireSideArm|68_7(ref <>c__DisplayClass68_0 unnamed_param_0) { }

	[Address(RVA = "0x1D850F0", Offset = "0x1D844F0", Length = "0x140")]
	[CompilerGenerated]
	[Token(Token = "0x6000C7C")]
	private bool <PatternMovePT1>g__ShoulderLaserArcBack|68_5(float deltaTime, ref <>c__DisplayClass68_0 unnamed_param_1) { }

	[Address(RVA = "0x1D85240", Offset = "0x1D84640", Length = "0x16B")]
	[CompilerGenerated]
	[Token(Token = "0x6000C7B")]
	private bool <PatternMovePT1>g__ShoulderLaserArcClose|68_4(float dt, ref <>c__DisplayClass68_0 unnamed_param_1) { }

	[Address(RVA = "0x1D82000", Offset = "0x1D81400", Length = "0x130")]
	[Token(Token = "0x6000C63")]
	private void CheckCoverBreak(bool isForce) { }

	[Address(RVA = "0x1D82130", Offset = "0x1D81530", Length = "0x41")]
	[Token(Token = "0x6000C64")]
	private void CheckNextState() { }

	[Address(RVA = "0x1D82180", Offset = "0x1D81580", Length = "0x15F")]
	[Token(Token = "0x6000C6F")]
	private void FireTurretShortLaser() { }

	[Address(RVA = "0x1D85D00", Offset = "0x1D85100", Length = "0x14")]
	[Token(Token = "0x6000C65")]
	private bool get_IsBothBreak() { }

	[Address(RVA = "0x1D822E0", Offset = "0x1D816E0", Length = "0x4F")]
	[Token(Token = "0x6000C6A")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1D82330", Offset = "0x1D81730", Length = "0x4F")]
	[Token(Token = "0x6000C67")]
	protected virtual String[] GetBossCD() { }

	[Address(RVA = "0x1D82380", Offset = "0x1D81780", Length = "0x2E")]
	[Token(Token = "0x6000C6B")]
	private Transform GetMuzzle(Boss03MZ mz) { }

	[Address(RVA = "0x1D823B0", Offset = "0x1D817B0", Length = "0x8A")]
	[Token(Token = "0x6000C69")]
	public virtual List<String> GetRouteNames() { }

	[Address(RVA = "0x1D82440", Offset = "0x1D81840", Length = "0x74")]
	[Token(Token = "0x6000C74")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1D7E4B0", Offset = "0x1D7D8B0", Length = "0x25")]
	[Token(Token = "0x6000C5D")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D824C0", Offset = "0x1D818C0", Length = "0x330")]
	[Token(Token = "0x6000C5B")]
	public virtual void Initialize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C66")]
	public virtual bool IsPoseRecord() { }

	[Address(RVA = "0x1D82800", Offset = "0x1D81C00", Length = "0x106")]
	[Token(Token = "0x6000C5F")]
	public virtual void OnPartsBreak(int parts) { }

	[Address(RVA = "0x1D82910", Offset = "0x1D81D10", Length = "0x6B4")]
	[Token(Token = "0x6000C72")]
	private void PatternMoveDestruction(float dt) { }

	[Address(RVA = "0x1D82FD0", Offset = "0x1D823D0", Length = "0x2ED")]
	[Token(Token = "0x6000C6C")]
	private void PatternMoveEntryWait(float dt) { }

	[Address(RVA = "0x1D832C0", Offset = "0x1D826C0", Length = "0x28C")]
	[Token(Token = "0x6000C70")]
	private void PatternMovePT1(float deltaTime) { }

	[Address(RVA = "0x1D83940", Offset = "0x1D82D40", Length = "0x8B3")]
	[Token(Token = "0x6000C71")]
	private void PatternMoveSummon(float dt) { }

	[Address(RVA = "0x1D84200", Offset = "0x1D83600", Length = "0x42A")]
	[Token(Token = "0x6000C73")]
	private void PatternMoveTimeover(float dt) { }

	[Address(RVA = "0x1D84630", Offset = "0x1D83A30", Length = "0x179")]
	[Token(Token = "0x6000C5C")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D847B0", Offset = "0x1D83BB0", Length = "0x42")]
	[Token(Token = "0x6000C61")]
	private void SetState(Boss03State tstate) { }

	[Address(RVA = "0x1D84800", Offset = "0x1D83C00", Length = "0xB8")]
	[Token(Token = "0x6000C60")]
	protected virtual void StateExec(float dt) { }

	[Address(RVA = "0x1D848C0", Offset = "0x1D83CC0", Length = "0x4F")]
	[Token(Token = "0x6000C68")]
	public virtual EnemyChildData[] SubEnemys() { }

	[Address(RVA = "0x1D84910", Offset = "0x1D83D10", Length = "0x62")]
	[Token(Token = "0x6000C62")]
	protected virtual void TimeupAction() { }

	[Address(RVA = "0x1D84980", Offset = "0x1D83D80", Length = "0xEE")]
	[Token(Token = "0x6000C5E")]
	public virtual void ToDestroid() { }

}

