namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000176")]
public class Ene_Bos01 : Ene_BosBase
{
	[Token(Token = "0x2000177")]
	private enum Boss01BT : int
	{
		laser01 = 0,
		laser02 = 1,
		bullet01 = 2,
		bullet10 = 3,
		bullet11 = 4,
		btmax = 5,
	}

	[Token(Token = "0x2000178")]
	private enum Boss01State : int
	{
		EntryWait = 0,
		PT1 = 1,
		PT2 = 2,
		PT6 = 3,
		Destruction = 4,
	}

	[Flags]
	[Token(Token = "0x2000179")]
	private enum CannonBit : int
	{
		none = 0,
		L4 = 1,
		L3 = 2,
		L2 = 4,
		L1 = 8,
		R4 = 16,
		R3 = 32,
		R2 = 64,
		R1 = 128,
		BodyL = 256,
		BodyR = 512,
		Core = 1024,
		WL5 = 2048,
		WL4 = 4096,
		WL3 = 8192,
		WL2 = 16384,
		WL1 = 32768,
		WR5 = 65536,
		WR4 = 131072,
		WR3 = 262144,
		WR2 = 524288,
		WR1 = 1048576,
		Body = 768,
		R12 = 192,
		R123 = 224,
		R1234 = 240,
		L12 = 12,
		L123 = 14,
		L1234 = 15,
		Cannon = 255,
		WL12345 = 63488,
		WR12345 = 2031616,
		Wing = 2095104,
		CannonALL = 1023,
		WingAll = 2095872,
	}

	[Token(Token = "0x2000180")]
	private class CannonData
	{
		[Token(Token = "0x4000B94")]
		private const float RollAngle = -90; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B8C")]
		private Transform _baseTransform; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B8D")]
		private Transform _laserMuzzle; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B8E")]
		private Transform _bulletMuzzle; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B8F")]
		private Transform _targetDir; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B90")]
		private EnemyCollisionModel _partsDamage; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B91")]
		private float _openRate; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000B92")]
		private bool _isAlive; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B93")]
		private CancellationTokenSource _laserTokenSource; //Field offset: 0x40

		[Token(Token = "0x170001E7")]
		public Transform BaseTransform
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000BFC")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170001E6")]
		public Transform TargetDir
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x6000BFB")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000BFD")]
		public CannonData(Transform baseTransform) { }

		[Address(RVA = "0x1D78270", Offset = "0x1D77670", Length = "0x4B")]
		[Token(Token = "0x6000C04")]
		public void CancelLaser() { }

		[Address(RVA = "0x1D782C0", Offset = "0x1D776C0", Length = "0x4F")]
		[Token(Token = "0x6000C09")]
		public void Destroy() { }

		[Address(RVA = "0x1D78310", Offset = "0x1D77710", Length = "0x39")]
		[Token(Token = "0x6000C06")]
		private void DisposeLaserTokenSource() { }

		[Address(RVA = "0x1D78350", Offset = "0x1D77750", Length = "0xF4")]
		[Token(Token = "0x6000C05")]
		private void EnsureLaserTokenSource(CancellationToken parentToken) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000BFC")]
		public Transform get_BaseTransform() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000BFB")]
		public Transform get_TargetDir() { }

		[Address(RVA = "0x1D78450", Offset = "0x1D77850", Length = "0x1F")]
		[Token(Token = "0x6000C02")]
		public Transform GetMuzzle() { }

		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000C03")]
		public CancellationTokenSource GetToken() { }

		[Address(RVA = "0x1D78470", Offset = "0x1D77870", Length = "0x11F")]
		[Token(Token = "0x6000BFE")]
		public void Initialize(Transform targetDirection) { }

		[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
		[Token(Token = "0x6000C08")]
		public bool IsAlive() { }

		[Address(RVA = "0x1D78590", Offset = "0x1D77990", Length = "0x20")]
		[Token(Token = "0x6000C07")]
		public bool IsContain(int partIndex) { }

		[Address(RVA = "0x1D785C0", Offset = "0x1D779C0", Length = "0x10")]
		[Token(Token = "0x6000C00")]
		public bool IsLaserMode() { }

		[Address(RVA = "0x1D785D0", Offset = "0x1D779D0", Length = "0x182")]
		[Token(Token = "0x6000BFF")]
		public void ReStart(CancellationToken parentToken, bool isLaser) { }

		[Address(RVA = "0x1D78760", Offset = "0x1D77B60", Length = "0xDB")]
		[Token(Token = "0x6000C01")]
		public bool Roll(float deltaTime, bool isLaser) { }

	}

	[Token(Token = "0x200017F")]
	private class CoreAttackPatternLogic
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B88")]
		private readonly Ene_Bos01 _owner; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B89")]
		private int _patternMode; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000B8A")]
		private float _stateWaitTime; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B8B")]
		private int _shotCount; //Field offset: 0x20

		[Token(Token = "0x170001E5")]
		public int Mode
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x6000BF7")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000BF8")]
		public CoreAttackPatternLogic(Ene_Bos01 owner) { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000BF7")]
		public int get_Mode() { }

		[Address(RVA = "0x1D78840", Offset = "0x1D77C40", Length = "0xE")]
		[Token(Token = "0x6000BF9")]
		public void Initialize() { }

		[Address(RVA = "0x1D78850", Offset = "0x1D77C50", Length = "0xFA")]
		[Token(Token = "0x6000BFA")]
		public void Update(float deltaTime) { }

	}

	[Token(Token = "0x200017A")]
	private enum PartsKind : int
	{
		MainBody = 0,
		Wing40 = 1,
		Wing60 = 2,
		Shoulder_R1 = 3,
		Shoulder_R2 = 4,
		Shoulder_R3 = 5,
		Shoulder_R4 = 6,
		Shoulder_L1 = 7,
		Shoulder_L2 = 8,
		Shoulder_L3 = 9,
		Shoulder_L4 = 10,
	}

	[Token(Token = "0x2000181")]
	private struct WingAttackCommand
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B95")]
		public float Time; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000B96")]
		public CannonBit Cannon; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B97")]
		public bool IsLaser; //Field offset: 0x8

	}

	[Token(Token = "0x200017B")]
	private class WingAttackPatternLogic
	{
		[CompilerGenerated]
		[Token(Token = "0x200017E")]
		private sealed class <EnumerateCannonBits>d__19 : IEnumerable<CannonBit>, IEnumerable, IEnumerator<CannonBit>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000B82")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000B83")]
			private CannonBit <>2__current; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000B84")]
			private int <>l__initialThreadId; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000B85")]
			private CannonBit bits; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000B86")]
			public CannonBit <>3__bits; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4000B87")]
			private int <mask>5__2; //Field offset: 0x24

			[Token(Token = "0x170001E3")]
			private override CannonBit System.Collections.Generic.IEnumerator<InGame.Kernel.Enemy.Ene_Bos01.CannonBit>.Current
			{
				[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
				[DebuggerHidden]
				[Token(Token = "0x6000BF2")]
				private get { } //Length: 4
			}

			[Token(Token = "0x170001E4")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x1D89240", Offset = "0x1D88640", Length = "0x43")]
				[DebuggerHidden]
				[Token(Token = "0x6000BF4")]
				private get { } //Length: 67
			}

			[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x6000BEF")]
			public <EnumerateCannonBits>d__19(int <>1__state) { }

			[Address(RVA = "0x1D89110", Offset = "0x1D88510", Length = "0x41")]
			[Token(Token = "0x6000BF1")]
			private override bool MoveNext() { }

			[Address(RVA = "0x1D89160", Offset = "0x1D88560", Length = "0x91")]
			[DebuggerHidden]
			[Token(Token = "0x6000BF5")]
			private override IEnumerator<CannonBit> System.Collections.Generic.IEnumerable<InGame.Kernel.Enemy.Ene_Bos01.CannonBit>.GetEnumerator() { }

			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[DebuggerHidden]
			[Token(Token = "0x6000BF2")]
			private override CannonBit System.Collections.Generic.IEnumerator<InGame.Kernel.Enemy.Ene_Bos01.CannonBit>.get_Current() { }

			[Address(RVA = "0x1D89160", Offset = "0x1D88560", Length = "0x91")]
			[DebuggerHidden]
			[Token(Token = "0x6000BF6")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x1D89240", Offset = "0x1D88640", Length = "0x43")]
			[DebuggerHidden]
			[Token(Token = "0x6000BF4")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x1D89200", Offset = "0x1D88600", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x6000BF3")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x6000BF0")]
			private override void System.IDisposable.Dispose() { }

		}

		[Token(Token = "0x200017D")]
		private class ActiveAttack
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000B7E")]
			public CannonBit Cannon; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000B7F")]
			public bool IsLaser; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000B80")]
			public float WaitTimer; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000B81")]
			public bool RollTriggered; //Field offset: 0x1C

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000BEE")]
			public ActiveAttack() { }

		}

		[Token(Token = "0x200017C")]
		private enum State : int
		{
			Waiting = 0,
			Executing = 1,
			Resetting = 2,
		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B71")]
		private readonly Ene_Bos01 _owner; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B72")]
		private State _state; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000B73")]
		private int _currentPatternIndex; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B74")]
		private float _timeline; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000B75")]
		private int _lastCommandIndex; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B76")]
		private float _waitTimer; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000B77")]
		private bool _cycleCompleted; //Field offset: 0x2C
		[FieldOffset(Offset = "0x2D")]
		[Token(Token = "0x4000B78")]
		private bool _isLeftAsteroidTurn; //Field offset: 0x2D
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B79")]
		private readonly List<ActiveAttack> _activeAttacks; //Field offset: 0x30

		[Token(Token = "0x170001E2")]
		public int Mode
		{
			[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
			[Token(Token = "0x6000BE5")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1D89F20", Offset = "0x1D89320", Length = "0xA6")]
		[Token(Token = "0x6000BE6")]
		public WingAttackPatternLogic(Ene_Bos01 owner) { }

		[Address(RVA = "0x1D89290", Offset = "0x1D88690", Length = "0x25F")]
		[Token(Token = "0x6000BED")]
		private void CallAsteroids() { }

		[Address(RVA = "0x1D894F0", Offset = "0x1D888F0", Length = "0x63")]
		[IteratorStateMachine(typeof(<EnumerateCannonBits>d__19))]
		[Token(Token = "0x6000BEC")]
		private static IEnumerable<CannonBit> EnumerateCannonBits(CannonBit bits) { }

		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000BE5")]
		public int get_Mode() { }

		[Address(RVA = "0x1D89560", Offset = "0x1D88960", Length = "0x86")]
		[Token(Token = "0x6000BE7")]
		public void Initialize() { }

		[Address(RVA = "0x1D895F0", Offset = "0x1D889F0", Length = "0x379")]
		[Token(Token = "0x6000BEA")]
		private void ProcessActiveAttacks(float deltaTime) { }

		[Address(RVA = "0x1D89970", Offset = "0x1D88D70", Length = "0x2F8")]
		[Token(Token = "0x6000BE9")]
		private void ScheduleAttack(WingAttackCommand command) { }

		[Address(RVA = "0x1D89C70", Offset = "0x1D89070", Length = "0x10")]
		[Token(Token = "0x6000BEB")]
		public bool TryConsumeCycleCompleted() { }

		[Address(RVA = "0x1D89C80", Offset = "0x1D89080", Length = "0x29B")]
		[Token(Token = "0x6000BE8")]
		public void Update(float deltaTime, bool isCannonRotating, bool isWingMoving, bool isHomeLooping) { }

	}

	[Token(Token = "0x4000B03")]
	private const float MovementIntegrationMaxStep = 0.05; //Field offset: 0x0
	[Token(Token = "0x4000AF3")]
	private const float Destruction_Shake1_Speed = 1; //Field offset: 0x0
	[Token(Token = "0x4000AF4")]
	private const float Destruction_Shake1_Time = 2; //Field offset: 0x0
	[Token(Token = "0x4000AF5")]
	private const float Destruction_SmallBombInterval = 0.2; //Field offset: 0x0
	[Token(Token = "0x4000AF6")]
	private const float Destruction_DirectionTime = 5.5; //Field offset: 0x0
	[Token(Token = "0x4000AF7")]
	private const float Destruction_FallStartTime = 3.5; //Field offset: 0x0
	[Token(Token = "0x4000AF8")]
	private const float Destruction_DeadEffectWaitTime = 2; //Field offset: 0x0
	[Token(Token = "0x4000AF9")]
	private const float Destruction_Shake2_Amount = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000AFA")]
	private const float Destruction_Shake2_Speed = 1; //Field offset: 0x0
	[Token(Token = "0x4000AFB")]
	private const float Destruction_Shake2_Time = 5; //Field offset: 0x0
	[Token(Token = "0x4000AFC")]
	private const float CannonBreak_Shake_Time = 1; //Field offset: 0x0
	[Token(Token = "0x4000AFD")]
	private const float CannonBreak_Shake_Power = 1; //Field offset: 0x0
	[Token(Token = "0x4000AF1")]
	private const int Destruction_InitialExplosionCount = 4; //Field offset: 0x0
	[Token(Token = "0x4000AFE")]
	private const float CannonBreak_Shake_Speed = 10; //Field offset: 0x0
	[Token(Token = "0x4000B00")]
	private const float InfinityLoopWidth = 10; //Field offset: 0x0
	[Token(Token = "0x4000B01")]
	private const float InfinityLoopHeight = 1; //Field offset: 0x0
	[Token(Token = "0x4000B02")]
	private const float InfinityLoopEndThreshold = 0.99; //Field offset: 0x0
	[Token(Token = "0x4000B04")]
	private const float Wing_WaitBetweenPatterns = 5; //Field offset: 0x0
	[Token(Token = "0x4000B05")]
	private const float Wing_WaitAfterLastPattern = 10; //Field offset: 0x0
	[Token(Token = "0x4000B06")]
	private const float Wing_CannonRollDuration = 1; //Field offset: 0x0
	[Token(Token = "0x4000B07")]
	private const float Wing_ResetToLaserWaitTime = 3; //Field offset: 0x0
	[Token(Token = "0x4000B08")]
	private const float Core_InitialWaitTime = 10; //Field offset: 0x0
	[Token(Token = "0x4000B09")]
	private const int Core_ShotCount = 8; //Field offset: 0x0
	[Token(Token = "0x4000B0A")]
	private const float Core_ShotInterval = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000B0B")]
	private const float Core_SequenceInterval = 10; //Field offset: 0x0
	[Token(Token = "0x4000AFF")]
	private const float MovementStopThresholdSq = 0.01; //Field offset: 0x0
	[Token(Token = "0x4000AEF")]
	private const float Destruction_FallDistance = 150; //Field offset: 0x0
	[Token(Token = "0x4000AF2")]
	private const float Destruction_Shake1_Amount = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000B13")]
	private const float DestroyedCannonColorBlendRate = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000AEE")]
	private const float Wing_CloseSpeed = 1; //Field offset: 0x0
	[Token(Token = "0x4000AE1")]
	private const float PT1_HoverSpeed = 2; //Field offset: 0x0
	[Token(Token = "0x4000AE2")]
	private const float PT1_HoverAmplitude = 5; //Field offset: 0x0
	[Token(Token = "0x4000AE4")]
	private const float PT1_TotalDuration2 = 2; //Field offset: 0x0
	[Token(Token = "0x4000AE5")]
	private const float PT1_BlendInDuration = 1.5; //Field offset: 0x0
	[Token(Token = "0x4000AE6")]
	private const float PT2_HoverSpeed = 2; //Field offset: 0x0
	[Token(Token = "0x4000AE7")]
	private const float PT2_HoverAmplitude = 5; //Field offset: 0x0
	[Token(Token = "0x4000AE3")]
	private const float PT1_TotalDuration = 5; //Field offset: 0x0
	[Token(Token = "0x4000AE9")]
	private const float PT2_FireWaitTime2 = 0.1; //Field offset: 0x0
	[Token(Token = "0x4000AEA")]
	private const float PT2_HomeArrivalDistance = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000AEB")]
	private const float PT2_HomeMoveSpeed = 0.4; //Field offset: 0x0
	[Token(Token = "0x4000AEC")]
	private const float PT2_WaitTime = 1.5; //Field offset: 0x0
	[Token(Token = "0x4000AD5")]
	private static readonly Vector3 _homePosition; //Field offset: 0x0
	[Token(Token = "0x4000AED")]
	private const float Wing_OpenSpeed = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000AE8")]
	private const float PT2_FireWaitTime1 = 1; //Field offset: 0x0
	[Token(Token = "0x4000AD6")]
	private static readonly Vector3 _rushPosition; //Field offset: 0xC
	[Token(Token = "0x4000AD7")]
	private static readonly float _homeStayTime; //Field offset: 0x18
	[Token(Token = "0x4000AD8")]
	private static readonly int _cannonMax; //Field offset: 0x1C
	[Token(Token = "0x4000AD9")]
	private static readonly float _moveSpring; //Field offset: 0x20
	[Token(Token = "0x4000ADA")]
	private static readonly float _moveDamping; //Field offset: 0x24
	[Token(Token = "0x4000ADB")]
	private static readonly String[] _btNames; //Field offset: 0x28
	[Token(Token = "0x4000ADC")]
	private static readonly String[] _asteroidEnemyClipNames; //Field offset: 0x30
	[Token(Token = "0x4000ADD")]
	private static readonly float _asteroidSpawnTime; //Field offset: 0x38
	[Token(Token = "0x4000ADE")]
	private static readonly string _bodyLaser1name; //Field offset: 0x40
	[Token(Token = "0x4000ADF")]
	private static readonly string _bodyLaser2name; //Field offset: 0x48
	[Token(Token = "0x4000AE0")]
	private static readonly string _bodyCoreMuzzle; //Field offset: 0x50
	[Token(Token = "0x4000AF0")]
	private static readonly Vector3 Destruction_Rotation; //Field offset: 0x58
	[Token(Token = "0x4000B2E")]
	private static readonly WingAttackCommand[] _pattern1; //Field offset: 0x68
	[Token(Token = "0x4000B2F")]
	private static readonly WingAttackCommand[] _pattern2; //Field offset: 0x70
	[Token(Token = "0x4000B30")]
	private static readonly WingAttackCommand[] _pattern3; //Field offset: 0x78
	[Token(Token = "0x4000B31")]
	private static readonly WingAttackCommand[] _pattern4; //Field offset: 0x80
	[Token(Token = "0x4000B32")]
	private static readonly WingAttackCommand[] _pattern5; //Field offset: 0x88
	[Token(Token = "0x4000B33")]
	private static readonly WingAttackCommand[][] _allPatterns; //Field offset: 0x90
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000AD4")]
	private int PartsCount; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	[Token(Token = "0x4000B0C")]
	private Transform _leftWingModel; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x4000B0D")]
	private Transform _rightWingModel; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x4000B0E")]
	private Transform[] _cannons; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x4000B0F")]
	private Transform[] _cannonTargets; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[SerializeField]
	[Token(Token = "0x4000B10")]
	private Transform[] _wingMuzzles; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x4000B11")]
	private Transform[] _wingMuzzlesTargets; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x4000B12")]
	private float _ShortLaserSEVolume; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000B14")]
	private CannonData[] _cannonData; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000B15")]
	private Boss01State _state; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2BC")]
	[Token(Token = "0x4000B16")]
	private float _stateWaitTime; //Field offset: 0x2BC
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000B17")]
	private float _homeStaySecond; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C4")]
	[Token(Token = "0x4000B18")]
	private float _localTime; //Field offset: 0x2C4
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000B19")]
	private Vector3 _stayVector; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D4")]
	[Token(Token = "0x4000B1A")]
	private bool _isEntry; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x2D5")]
	[Token(Token = "0x4000B1B")]
	private bool _isPhysicsMove; //Field offset: 0x2D5
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000B1C")]
	private Vector3 _velocity; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E4")]
	[Token(Token = "0x4000B1D")]
	private Vector3 _movementTarget; //Field offset: 0x2E4
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000B1E")]
	private float _pt1StartTime; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x4000B1F")]
	private float _pt1WaitTime; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000B20")]
	private float _hoverTimeOffset; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x4000B21")]
	private float _movementSpringScale; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000B22")]
	private Transform _bodyCore; //Field offset: 0x300
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000B23")]
	private Transform _bodyLaser1; //Field offset: 0x308
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000B24")]
	private Transform _bodyLaser2; //Field offset: 0x310
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000B25")]
	private CannonBit _cannonBits; //Field offset: 0x318
	[FieldOffset(Offset = "0x31C")]
	[Token(Token = "0x4000B26")]
	private CannonBit _orderBits; //Field offset: 0x31C
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000B27")]
	private CannonBit _wingLaserBits; //Field offset: 0x320
	[FieldOffset(Offset = "0x324")]
	[Token(Token = "0x4000B28")]
	private bool _isWingMove; //Field offset: 0x324
	[FieldOffset(Offset = "0x325")]
	[Token(Token = "0x4000B29")]
	private bool _isWingOpen; //Field offset: 0x325
	[FieldOffset(Offset = "0x326")]
	[Token(Token = "0x4000B2A")]
	private bool _isHomeMove; //Field offset: 0x326
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000B2B")]
	private float _wingArc; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000B2C")]
	private WingAttackPatternLogic _wingAttackLogic; //Field offset: 0x330
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000B2D")]
	private CoreAttackPatternLogic _coreAttackLogic; //Field offset: 0x338

	[Address(RVA = "0x1D7BF30", Offset = "0x1D7B330", Length = "0x11AD")]
	[Token(Token = "0x6000BE4")]
	private static Ene_Bos01() { }

	[Address(RVA = "0x1D7D0E0", Offset = "0x1D7C4E0", Length = "0x167")]
	[Token(Token = "0x6000BE3")]
	public Ene_Bos01() { }

	[Address(RVA = "0x1D78950", Offset = "0x1D77D50", Length = "0x70")]
	[Token(Token = "0x6000BD2")]
	private void ApplyDestroyedCannonColor(int parts) { }

	[Address(RVA = "0x1D789C0", Offset = "0x1D77DC0", Length = "0x7D")]
	[Token(Token = "0x6000BD1")]
	private void DisableShoulderCannon(int parts) { }

	[Address(RVA = "0x1D78A40", Offset = "0x1D77E40", Length = "0x463")]
	[Token(Token = "0x6000BD4")]
	private void FireCannons(CannonBit cannonsToFire, int param, Boss01BT laserTemplate = 0) { }

	[Address(RVA = "0x1D78EB0", Offset = "0x1D782B0", Length = "0x3A1")]
	[Token(Token = "0x6000BD5")]
	private void FireWingCannons(CannonBit cannonsToFire, Boss01BT laserTemplate) { }

	[Address(RVA = "0x1D79260", Offset = "0x1D78660", Length = "0x4F")]
	[Token(Token = "0x6000BCC")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1D792B0", Offset = "0x1D786B0", Length = "0x4F")]
	[Token(Token = "0x6000BCD")]
	protected virtual String[] GetBossCD() { }

	[Address(RVA = "0x1D79300", Offset = "0x1D78700", Length = "0x7")]
	[Token(Token = "0x6000BCF")]
	protected virtual string GetDebugString() { }

	[Address(RVA = "0x1D79310", Offset = "0x1D78710", Length = "0xDB")]
	[Token(Token = "0x6000BCA")]
	public virtual Vector3 GetHormingTarget(int targetIndex) { }

	[Address(RVA = "0x1D793F0", Offset = "0x1D787F0", Length = "0x72")]
	[Token(Token = "0x6000BCE")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1D79470", Offset = "0x1D78870", Length = "0x25")]
	[Token(Token = "0x6000BC6")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D794A0", Offset = "0x1D788A0", Length = "0x17")]
	[Token(Token = "0x6000BD6")]
	private static CannonBit GetWingCannonBitByIndex(int index) { }

	[Address(RVA = "0x1D794C0", Offset = "0x1D788C0", Length = "0x4F4")]
	[Token(Token = "0x6000BC4")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D799C0", Offset = "0x1D78DC0", Length = "0x35")]
	[Token(Token = "0x6000BC9")]
	public virtual bool IsHitEnable() { }

	[Address(RVA = "0x1D79A00", Offset = "0x1D78E00", Length = "0xF")]
	[Token(Token = "0x6000BD0")]
	private static bool IsShoulderCannonPart(int parts) { }

	[Address(RVA = "0x1D79A10", Offset = "0x1D78E10", Length = "0x159")]
	[Token(Token = "0x6000BE2")]
	protected virtual void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D79B70", Offset = "0x1D78F70", Length = "0xF5")]
	[Token(Token = "0x6000BC7")]
	public virtual void OnPartsBreak(int parts) { }

	[Address(RVA = "0x1D79C70", Offset = "0x1D79070", Length = "0x272")]
	[Token(Token = "0x6000BDE")]
	private void PatternMove1(float deltaTime) { }

	[Address(RVA = "0x1D79EF0", Offset = "0x1D792F0", Length = "0x3C4")]
	[Token(Token = "0x6000BDF")]
	private void PatternMove2(float deltaTime, bool isBodyMoving, bool isCannonRotating, bool isWingMoving) { }

	[Address(RVA = "0x1D7A2C0", Offset = "0x1D796C0", Length = "0x325")]
	[Token(Token = "0x6000BE0")]
	private void PatternMove6(float deltaTime, bool isBodyMoving, bool isCannonRotating, bool isWingMoving, bool isHomeLooping) { }

	[Address(RVA = "0x1D7A5F0", Offset = "0x1D799F0", Length = "0x640")]
	[Token(Token = "0x6000BE1")]
	private void PatternMoveDestruction(float deltaTime) { }

	[Address(RVA = "0x1D7AC40", Offset = "0x1D7A040", Length = "0x97")]
	[Token(Token = "0x6000BDD")]
	private void PatternMoveEntry(float deltaTime) { }

	[Address(RVA = "0x1D7ACE0", Offset = "0x1D7A0E0", Length = "0x512")]
	[Token(Token = "0x6000BC5")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D7B200", Offset = "0x1D7A600", Length = "0x23")]
	[Token(Token = "0x6000BD8")]
	private void SetBossState(Boss01State newState) { }

	[Address(RVA = "0x1D7B230", Offset = "0x1D7A630", Length = "0xCD")]
	[Token(Token = "0x6000BD3")]
	private void SetWingAngle(float targetAngle) { }

	[Address(RVA = "0x1D7B300", Offset = "0x1D7A700", Length = "0x27")]
	[Token(Token = "0x6000BD7")]
	private void SetWingLaserState(CannonBit wingBits, bool isLaser) { }

	[Address(RVA = "0x1D7B330", Offset = "0x1D7A730", Length = "0x370")]
	[Token(Token = "0x6000BCB")]
	protected virtual void StateExec(float deltaTime) { }

	[Address(RVA = "0x1D7B6B0", Offset = "0x1D7AAB0", Length = "0xAD")]
	[Token(Token = "0x6000BC8")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1D7B760", Offset = "0x1D7AB60", Length = "0x156")]
	[Token(Token = "0x6000BDA")]
	private bool UpdateCannonState(float deltaTime) { }

	[Address(RVA = "0x1D7B8C0", Offset = "0x1D7ACC0", Length = "0x1BD")]
	[Token(Token = "0x6000BDC")]
	private bool UpdateHomePositionInInfinityLoop(float deltaTime) { }

	[Address(RVA = "0x1D7BA80", Offset = "0x1D7AE80", Length = "0x3DF")]
	[Token(Token = "0x6000BDB")]
	private bool UpdateVelocityMovement(float deltaTime) { }

	[Address(RVA = "0x1D7BE60", Offset = "0x1D7B260", Length = "0xC1")]
	[Token(Token = "0x6000BD9")]
	private bool UpdateWingState(float deltaTime) { }

}

