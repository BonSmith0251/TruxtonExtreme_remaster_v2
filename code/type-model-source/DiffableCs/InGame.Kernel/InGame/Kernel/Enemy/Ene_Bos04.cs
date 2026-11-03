namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000194")]
public class Ene_Bos04 : Ene_BosBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000199")]
	private sealed class <>c
	{
		[Token(Token = "0x4000CFB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000CFC")]
		public static Func<PawnEnemy, Boolean> <>9__102_0; //Field offset: 0x8

		[Address(RVA = "0x1D9F920", Offset = "0x1D9ED20", Length = "0x67")]
		[Token(Token = "0x6000CB2")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CB3")]
		public <>c() { }

		[Address(RVA = "0x1D9F740", Offset = "0x1D9EB40", Length = "0x50")]
		[Token(Token = "0x6000CB4")]
		internal bool <DestroyGuardians>b__102_0(PawnEnemy a) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200019A")]
	private struct <>c__DisplayClass110_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CFD")]
		public Ene_Bos04 <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000CFE")]
		public float deltaTime; //Field offset: 0x8

	}

	[CompilerGenerated]
	[Token(Token = "0x200019B")]
	private struct <>c__DisplayClass118_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CFF")]
		public Ene_Bos04 <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000D00")]
		public float deltaTime; //Field offset: 0x8

	}

	[CompilerGenerated]
	[Token(Token = "0x200019C")]
	private sealed class <>c__DisplayClass119_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D01")]
		public bool firstFlag; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CB5")]
		public <>c__DisplayClass119_0() { }

		[Address(RVA = "0x1D9F7A0", Offset = "0x1D9EBA0", Length = "0x8E")]
		[Token(Token = "0x6000CB6")]
		internal void <coreLongLaser>b__0(InGameBulletInterface bullet) { }

	}

	[Token(Token = "0x2000197")]
	private enum Boss04BT : int
	{
		bit0 = 0,
		p1way3l = 1,
		p1way3r = 2,
		laser = 3,
		shortLaser = 4,
		roundShot = 5,
		p5way3 = 6,
		p5way3s = 7,
	}

	[Token(Token = "0x2000198")]
	private enum Boss04MZ : int
	{
		muzzle_body_under20 = 0,
		muzzle_body_under40 = 1,
		muzzle_body_under60 = 2,
		muzzle_body_under80 = 3,
		muzzle_body_under_ene_sg = 4,
		muzzle_body_upper02 = 5,
		muzzle_body_upper04 = 6,
		muzzle_body_upper05 = 7,
		muzzle_body_upper06 = 8,
		muzzle_body_upper08 = 9,
	}

	[Token(Token = "0x2000195")]
	private enum Boss04State : int
	{
		EntryWait = 0,
		PT1 = 1,
		PT2 = 2,
		PT3 = 3,
		PT5 = 4,
		PT6 = 5,
		OpenWing = 10,
		Destruction = 100,
	}

	[Token(Token = "0x2000196")]
	private enum PartsKind : int
	{
		MainBody = 0,
		MainCore = 1,
		MainHead = 2,
		Wing2 = 3,
		Wing4 = 4,
		Wing6 = 5,
		Wing8 = 6,
	}

	[Token(Token = "0x4000C88")]
	private static readonly EnemyChildData[] _ChildData; //Field offset: 0x0
	[Token(Token = "0x4000C89")]
	private static readonly String[] _BtNames; //Field offset: 0x8
	[Token(Token = "0x4000C8A")]
	private static readonly String[] _Boss04ClipData; //Field offset: 0x10
	[Token(Token = "0x4000C8B")]
	private static readonly String[] _Boss04RouteData; //Field offset: 0x18
	[Token(Token = "0x4000C8E")]
	private static readonly int _WingMax; //Field offset: 0x20
	[Token(Token = "0x4000C8F")]
	private static readonly Vector3 _OpenWingPosition; //Field offset: 0x24
	[Token(Token = "0x4000C90")]
	private static readonly Vector3 _OpenAttackPosition; //Field offset: 0x30
	[Token(Token = "0x4000C9A")]
	private static readonly Quaternion[] _WingArcs; //Field offset: 0x40
	[Token(Token = "0x4000C9B")]
	private static readonly Quaternion _ModelTopRotateStart; //Field offset: 0x48
	[Token(Token = "0x4000C9C")]
	private static readonly Quaternion _ModelTopRotate; //Field offset: 0x58
	[Token(Token = "0x4000CB5")]
	private static readonly float _EntryNoHitTime; //Field offset: 0x68
	[Token(Token = "0x4000CB6")]
	private static readonly float _Pattern1OneLoopTime; //Field offset: 0x6C
	[Token(Token = "0x4000CB7")]
	private static readonly int _Pattern1RepeatCount; //Field offset: 0x70
	[Token(Token = "0x4000CB8")]
	private static readonly float _Pattern1OneLoopEndWait; //Field offset: 0x74
	[Token(Token = "0x4000CB9")]
	private static readonly float _Pattern2FirstMove; //Field offset: 0x78
	[Token(Token = "0x4000CBA")]
	private static readonly float _Pattern2EnemyEmitTime; //Field offset: 0x7C
	[Token(Token = "0x4000CBB")]
	private static readonly float _Pattern2EnemyEmitIntervalEasy; //Field offset: 0x80
	[Token(Token = "0x4000CBC")]
	private static readonly float _Pattern2EnemyEmitIntervalHard; //Field offset: 0x84
	[Token(Token = "0x4000CBD")]
	private static readonly float _Pattern3EmitTime; //Field offset: 0x88
	[Token(Token = "0x4000CBE")]
	private static readonly float _Pattern3EmitInterval; //Field offset: 0x8C
	[Token(Token = "0x4000CBF")]
	private static readonly float _Pattern3EmitAfterWait; //Field offset: 0x90
	[Token(Token = "0x4000CC0")]
	private static readonly float _Pattern3RushTime; //Field offset: 0x94
	[Token(Token = "0x4000CC1")]
	private static readonly float _Pattern3RushDistance; //Field offset: 0x98
	[Token(Token = "0x4000CC2")]
	private static readonly float _Pattern3RushTwist; //Field offset: 0x9C
	[Token(Token = "0x4000CC3")]
	private static readonly float _SecondOneRoundFirst; //Field offset: 0xA0
	[Token(Token = "0x4000CC4")]
	private static readonly float _SecondOneRoundNormal; //Field offset: 0xA4
	[Token(Token = "0x4000CC5")]
	private static readonly float _SecondOneRoundLast; //Field offset: 0xA8
	[Token(Token = "0x4000CC6")]
	private static readonly float _SecondOneRoundBodyRotate; //Field offset: 0xAC
	[Token(Token = "0x4000CC7")]
	private static readonly float _SecondShortLaserCoreRotate; //Field offset: 0xB0
	[Token(Token = "0x4000CC8")]
	private static readonly float _SecondFireLookRate; //Field offset: 0xB4
	[Token(Token = "0x4000CC9")]
	private static readonly float _SecondFireRepeatFirst; //Field offset: 0xB8
	[Token(Token = "0x4000CCA")]
	private static readonly float _SecondFireRepeatNormal; //Field offset: 0xBC
	[Token(Token = "0x4000CCB")]
	private static readonly float _SecondFireRepeatHard; //Field offset: 0xC0
	[Token(Token = "0x4000CCC")]
	private static readonly float _SecondFireRepeatExpert; //Field offset: 0xC4
	[Token(Token = "0x4000CCD")]
	private static readonly float _SecondEndingTime; //Field offset: 0xC8
	[Token(Token = "0x4000CCE")]
	private static readonly List<Single> _WatchAngles; //Field offset: 0xD0
	[Token(Token = "0x4000CCF")]
	private static readonly float _LastOneRound; //Field offset: 0xD8
	[Token(Token = "0x4000CD0")]
	private static readonly float _LastOneRoundBodyRotate; //Field offset: 0xDC
	[Token(Token = "0x4000CD1")]
	private static readonly float _LastOneRoundCoreRotate; //Field offset: 0xE0
	[Token(Token = "0x4000CD2")]
	private static readonly int _LastLaserCount; //Field offset: 0xE4
	[Token(Token = "0x4000CD3")]
	private static readonly float _LastLaserInterval; //Field offset: 0xE8
	[Token(Token = "0x4000CD4")]
	private static readonly float _LastShotInterval; //Field offset: 0xEC
	[Token(Token = "0x4000CD5")]
	private static readonly float _patternOpenWingY; //Field offset: 0xF0
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000C8C")]
	private readonly int _MuzzleCount; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000C8D")]
	private Transform[] _muzzles; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x4000C91")]
	private Transform[] _wings; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x4000C92")]
	private Transform _upperCore; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x4000C93")]
	private AnimationCurve _pattern1EaseIn; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[SerializeField]
	[Token(Token = "0x4000C94")]
	private AnimationCurve _pattern1EaseOut; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x4000C95")]
	private AnimationCurve _pattern2EaseInOut; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	[Token(Token = "0x4000C96")]
	private AnimationCurve _pattern3Position; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x4000C97")]
	private AnimationCurve _pattern3RotateX; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	[Token(Token = "0x4000C98")]
	private AnimationCurve _pattern5EaseIn; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[SerializeField]
	[Token(Token = "0x4000C99")]
	private AnimationCurve _patternOpenWing; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000C9D")]
	private Boss04State _bos04state; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2CC")]
	[Token(Token = "0x4000C9E")]
	private float _localTime; //Field offset: 0x2CC
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000C9F")]
	private int _sgCounter; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D4")]
	[Token(Token = "0x4000CA0")]
	private int _rollSEId; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000CA1")]
	private int _destroyWingCount; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x4000CA2")]
	private bool _isGuardianLeft; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2DD")]
	[Token(Token = "0x4000CA3")]
	private bool _isGuardianRight; //Field offset: 0x2DD
	[FieldOffset(Offset = "0x2DE")]
	[Token(Token = "0x4000CA4")]
	private bool _isOpenWing; //Field offset: 0x2DE
	[FieldOffset(Offset = "0x2DF")]
	[Token(Token = "0x4000CA5")]
	private bool _isReverseMove; //Field offset: 0x2DF
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000CA6")]
	private int _laserCount; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000CA7")]
	private List<Ene_Bos04Bit> _guardianList; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000CA8")]
	private int _pattern1LoopCount; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x4000CA9")]
	private bool _pattern1IsFirst; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F5")]
	[Token(Token = "0x4000CAA")]
	private bool _pattern1turnSEFlag; //Field offset: 0x2F5
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000CAB")]
	private int _targetPlayer; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x4000CAC")]
	private bool _isFireReady; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000CAD")]
	private float _lastFireAngle; //Field offset: 0x300
	[FieldOffset(Offset = "0x304")]
	[Token(Token = "0x4000CAE")]
	private float _lookAngle; //Field offset: 0x304
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000CAF")]
	private float _destroyedPositionRate; //Field offset: 0x308
	[FieldOffset(Offset = "0x30C")]
	[Token(Token = "0x4000CB0")]
	private float _destroyedRemainTime; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000CB1")]
	private bool _pattern5First; //Field offset: 0x310
	[FieldOffset(Offset = "0x314")]
	[Token(Token = "0x4000CB2")]
	private float _wingRotation; //Field offset: 0x314
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000CB3")]
	private bool _patternOpenWingCollitionFlag; //Field offset: 0x318
	[FieldOffset(Offset = "0x319")]
	[Token(Token = "0x4000CB4")]
	private bool _patternOpenWingFadeFlag; //Field offset: 0x319

	[Address(RVA = "0x1D91090", Offset = "0x1D90490", Length = "0xC41")]
	[Token(Token = "0x6000CAA")]
	private static Ene_Bos04() { }

	[Address(RVA = "0x1D91CE0", Offset = "0x1D910E0", Length = "0xD4")]
	[Token(Token = "0x6000CA9")]
	public Ene_Bos04() { }

	[Address(RVA = "0x1D906F0", Offset = "0x1D8FAF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000CAB")]
	private void <CheckGuardians>b__101_0() { }

	[Address(RVA = "0x1D90700", Offset = "0x1D8FB00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000CAC")]
	private void <CheckGuardians>b__101_1() { }

	[Address(RVA = "0x1D90710", Offset = "0x1D8FB10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000CAD")]
	private void <PatternMove2>b__107_0() { }

	[Address(RVA = "0x1D90710", Offset = "0x1D8FB10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000CAE")]
	private void <PatternMove3>b__108_0() { }

	[Address(RVA = "0x1D90720", Offset = "0x1D8FB20", Length = "0x100")]
	[CompilerGenerated]
	[Token(Token = "0x6000CAF")]
	private void <PatternMove5>g__FireMuzzle|110_0(ref <>c__DisplayClass110_0 unnamed_param_0) { }

	[Address(RVA = "0x1D90830", Offset = "0x1D8FC30", Length = "0x5BB")]
	[CompilerGenerated]
	[Token(Token = "0x6000CB0")]
	private void <PatternMove5>g__Update|110_1(float moveRate, float attackRate, int destroyWingCount, ref <>c__DisplayClass110_0 unnamed_param_3) { }

	[Address(RVA = "0x1D90DF0", Offset = "0x1D901F0", Length = "0x1D2")]
	[CompilerGenerated]
	[Token(Token = "0x6000CB1")]
	private bool <PatternMove6>g__pat6fire|118_0(ref <>c__DisplayClass118_0 unnamed_param_0) { }

	[Address(RVA = "0x1D8B3F0", Offset = "0x1D8A7F0", Length = "0xAC")]
	[Token(Token = "0x6000C90")]
	public void AddGuardian(Ene_Bos04Bit guardian) { }

	[Address(RVA = "0x1D8B4A0", Offset = "0x1D8A8A0", Length = "0x22")]
	[Token(Token = "0x6000CA6")]
	private float CalcTranslateRate(float rate) { }

	[Address(RVA = "0x1D8B4D0", Offset = "0x1D8A8D0", Length = "0xB3")]
	[Token(Token = "0x6000C83")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D8B590", Offset = "0x1D8A990", Length = "0x43")]
	[Token(Token = "0x6000C87")]
	private bool CheckChangeToOpenWing() { }

	[Address(RVA = "0x1D8B5E0", Offset = "0x1D8A9E0", Length = "0x25F")]
	[Token(Token = "0x6000CA0")]
	private bool CheckFireAngle() { }

	[Address(RVA = "0x1D8B840", Offset = "0x1D8AC40", Length = "0x3FA")]
	[Token(Token = "0x6000C92")]
	private void CheckGuardians() { }

	[Address(RVA = "0x1D8BC40", Offset = "0x1D8B040", Length = "0xFD")]
	[Token(Token = "0x6000C88")]
	private void CheckNextState() { }

	[Address(RVA = "0x1D91DC0", Offset = "0x1D911C0", Length = "0x229")]
	[Token(Token = "0x6000CA4")]
	private void coreLongLaser() { }

	[Address(RVA = "0x1D91FF0", Offset = "0x1D913F0", Length = "0x1D4")]
	[Token(Token = "0x6000CA5")]
	private void coreShortLaser() { }

	[Address(RVA = "0x1D8BD40", Offset = "0x1D8B140", Length = "0xD4")]
	[Token(Token = "0x6000C9F")]
	private bool CrossedAngle(float previousAngle, float currentAngle, float targetAngle) { }

	[Address(RVA = "0x1D8BE20", Offset = "0x1D8B220", Length = "0x2AC")]
	[Token(Token = "0x6000C93")]
	private void DestroyGuardians() { }

	[Address(RVA = "0x1D8C0D0", Offset = "0x1D8B4D0", Length = "0x4F")]
	[Token(Token = "0x6000C8B")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1D8C120", Offset = "0x1D8B520", Length = "0x4F")]
	[Token(Token = "0x6000C8C")]
	protected virtual String[] GetBossCD() { }

	[Address(RVA = "0x1D8C170", Offset = "0x1D8B570", Length = "0xB4")]
	[Token(Token = "0x6000CA1")]
	private int GetDestroyWingCount(bool forceBreak) { }

	[Address(RVA = "0x1D8C230", Offset = "0x1D8B630", Length = "0x2E")]
	[Token(Token = "0x6000C8E")]
	private Transform GetMuzzle(Boss04MZ mz) { }

	[Address(RVA = "0x1D8C260", Offset = "0x1D8B660", Length = "0x183")]
	[Token(Token = "0x6000C9E")]
	private float GetRelativeAngle() { }

	[Address(RVA = "0x1D8C3F0", Offset = "0x1D8B7F0", Length = "0x8A")]
	[Token(Token = "0x6000C8D")]
	public virtual List<String> GetRouteNames() { }

	[Address(RVA = "0x1D8C480", Offset = "0x1D8B880", Length = "0x72")]
	[Token(Token = "0x6000CA8")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1D7E4B0", Offset = "0x1D7D8B0", Length = "0x25")]
	[Token(Token = "0x6000C81")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D8C500", Offset = "0x1D8B900", Length = "0xEF")]
	[Token(Token = "0x6000C8F")]
	private Quaternion GetWingRotate(int index, float rate) { }

	[Address(RVA = "0x1D92AA0", Offset = "0x1D91EA0", Length = "0x47A")]
	[Token(Token = "0x6000CA2")]
	private void infinityMove(float bodyRate, float width, float height, float deltaTime, bool isForwardRotate) { }

	[Address(RVA = "0x1D921D0", Offset = "0x1D915D0", Length = "0x8C2")]
	[Token(Token = "0x6000C9D")]
	private void infinityMoveLookPlayer(float bodyRate, float attackRate, float width, float height, bool isLookPlayer, bool isForwardRotate, float deltaTime) { }

	[Address(RVA = "0x1D8C5F0", Offset = "0x1D8B9F0", Length = "0x385")]
	[Token(Token = "0x6000C7F")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D8C980", Offset = "0x1D8BD80", Length = "0x1A0")]
	[Token(Token = "0x6000C85")]
	protected virtual void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D8CB30", Offset = "0x1D8BF30", Length = "0x151")]
	[Token(Token = "0x6000C97")]
	private void Pattern1Fire(float timeRate) { }

	[Address(RVA = "0x1D8CC90", Offset = "0x1D8C090", Length = "0x15B")]
	[Token(Token = "0x6000C96")]
	private void Pattern1Move(float timeRate) { }

	[Address(RVA = "0x1D8CDF0", Offset = "0x1D8C1F0", Length = "0x247")]
	[Token(Token = "0x6000C94")]
	private void PatternEntryWait(float deltaTime) { }

	[Address(RVA = "0x1D8D040", Offset = "0x1D8C440", Length = "0x670")]
	[Token(Token = "0x6000C95")]
	private void PatternMove1(float deltaTime) { }

	[Address(RVA = "0x1D8D6C0", Offset = "0x1D8CAC0", Length = "0x73C")]
	[Token(Token = "0x6000C98")]
	private void PatternMove2(float deltaTime) { }

	[Address(RVA = "0x1D8DE00", Offset = "0x1D8D200", Length = "0xB14")]
	[Token(Token = "0x6000C99")]
	private void PatternMove3(float deltaTime) { }

	[Address(RVA = "0x1D8E920", Offset = "0x1D8DD20", Length = "0x4CD")]
	[Token(Token = "0x6000C9B")]
	private void PatternMove5(float deltaTime) { }

	[Address(RVA = "0x1D8EDF0", Offset = "0x1D8E1F0", Length = "0x3CF")]
	[Token(Token = "0x6000CA3")]
	private void PatternMove6(float deltaTime) { }

	[Address(RVA = "0x1D8F1C0", Offset = "0x1D8E5C0", Length = "0x52C")]
	[Token(Token = "0x6000CA7")]
	private void PatternMoveDestruction(float deltaTime) { }

	[Address(RVA = "0x1D8F6F0", Offset = "0x1D8EAF0", Length = "0x89A")]
	[Token(Token = "0x6000C9A")]
	private void PatternOpenWing(float deltaTime) { }

	[Address(RVA = "0x1D90170", Offset = "0x1D8F570", Length = "0x56")]
	[Token(Token = "0x6000C91")]
	public void RemoveGuardian(Ene_Bos04Bit guardian) { }

	[Address(RVA = "0x1D8FF90", Offset = "0x1D8F390", Length = "0x1D9")]
	[Token(Token = "0x6000C80")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D92F20", Offset = "0x1D92320", Length = "0x7F")]
	[Token(Token = "0x6000C8A")]
	private void setBodyHeadCollision(bool isHeadHit) { }

	[Address(RVA = "0x1D901D0", Offset = "0x1D8F5D0", Length = "0x9D")]
	[Token(Token = "0x6000C89")]
	private void SetState(Boss04State tstate) { }

	[Address(RVA = "0x1D90270", Offset = "0x1D8F670", Length = "0x360")]
	[Token(Token = "0x6000C86")]
	protected virtual void StateExec(float deltaTime) { }

	[Address(RVA = "0x1D90600", Offset = "0x1D8FA00", Length = "0x4E")]
	[Token(Token = "0x6000C84")]
	public virtual EnemyChildData[] SubEnemys() { }

	[Address(RVA = "0x1D90650", Offset = "0x1D8FA50", Length = "0x9F")]
	[Token(Token = "0x6000C82")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1D90FD0", Offset = "0x1D903D0", Length = "0xBD")]
	[Token(Token = "0x6000C9C")]
	private void UpdateWingRotation(float addRotate) { }

}

