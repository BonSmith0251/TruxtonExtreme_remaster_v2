namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000182")]
public class Ene_Bos02 : Ene_BosBase
{
	[Token(Token = "0x2000186")]
	private enum Boss02BT : int
	{
		laser01 = 0,
		laser10 = 1,
		way8 = 2,
		b04x3 = 3,
		way16_1 = 4,
		way16_2 = 5,
		way5 = 6,
		way6_1 = 7,
		way6_2 = 8,
	}

	[Token(Token = "0x2000185")]
	private enum Boss02MZ : int
	{
		muzzle_body_front_laser = 0,
		muzzle_body_front_core = 1,
		muzzle_body_core = 2,
	}

	[Token(Token = "0x2000184")]
	private enum Boss02State : int
	{
		EntryWait = 0,
		PT1 = 1,
		PT2 = 2,
		PT3 = 3,
		PT5 = 4,
		BackWingOpen = 50,
		Destruction = 100,
	}

	[Token(Token = "0x200018B")]
	private sealed class Fire5Controller
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C26")]
		private int _mode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000C27")]
		private float _waitTimer; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C28")]
		private float _fireTimer; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000C29")]
		private bool _trigger; //Field offset: 0x1C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C54")]
		public Fire5Controller() { }

		[Address(RVA = "0x1D86C40", Offset = "0x1D86040", Length = "0xD")]
		[Token(Token = "0x6000C52")]
		public void Reset() { }

		[Address(RVA = "0x1D86C50", Offset = "0x1D86050", Length = "0xC8")]
		[Token(Token = "0x6000C53")]
		public void Update(float deltaTime, float playFactor, bool isMoveStart, Action fireAction) { }

	}

	[Token(Token = "0x200018C")]
	private sealed class Fire6Controller
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C2A")]
		private int _mode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000C2B")]
		private float _waitTimer; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C2C")]
		private float _pattern6Timeline; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C57")]
		public Fire6Controller() { }

		[Address(RVA = "0x1D86D20", Offset = "0x1D86120", Length = "0xA")]
		[Token(Token = "0x6000C55")]
		public void Reset() { }

		[Address(RVA = "0x1D86D30", Offset = "0x1D86130", Length = "0x1C0")]
		[Token(Token = "0x6000C56")]
		public void Update(float deltaTime, float playFactor, bool isMoveStart, Action<Int32> fireAction) { }

	}

	[Token(Token = "0x2000187")]
	private struct Fire6Table
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C06")]
		public float time; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000C07")]
		public int battery; //Field offset: 0x4

	}

	[Token(Token = "0x200018D")]
	private sealed class Fire7Controller
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C2D")]
		private int _mode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000C2E")]
		private float _waitTimer; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C2F")]
		private float _rollTimer; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000C30")]
		private float _fireTimer; //Field offset: 0x1C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C5A")]
		public Fire7Controller() { }

		[Address(RVA = "0x1D86F00", Offset = "0x1D86300", Length = "0xB")]
		[Token(Token = "0x6000C58")]
		public void Reset() { }

		[Address(RVA = "0x1D86F10", Offset = "0x1D86310", Length = "0xF5")]
		[Token(Token = "0x6000C59")]
		public void Update(float deltaTime, float playFactor, bool isMoveStart, Action<Single> fireAction) { }

	}

	[Token(Token = "0x2000188")]
	private struct Fire7Table
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C08")]
		public int battery; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000C09")]
		public float start; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C0A")]
		public float move; //Field offset: 0x8

	}

	[Token(Token = "0x2000183")]
	private enum PartsKind : int
	{
		MainBody = 0,
		Upper06 = 1,
		Upper04 = 2,
		Under06 = 3,
		Under04 = 4,
	}

	[Token(Token = "0x2000189")]
	private sealed class PatrolMovementController
	{
		[Token(Token = "0x200018A")]
		private enum Phase : int
		{
			Straight = 0,
			Orbit = 1,
			Stop = 2,
		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C0B")]
		private readonly Ene_Bos02 _owner; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C0C")]
		private bool _initialized; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000C0D")]
		private bool _hasReachedContact; //Field offset: 0x19
		[FieldOffset(Offset = "0x1A")]
		[Token(Token = "0x4000C0E")]
		private bool _orbitAdvanceRequested; //Field offset: 0x1A
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000C0F")]
		private int _sequenceIndex; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C10")]
		private Vector3 _linearPosition; //Field offset: 0x20
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000C11")]
		private Vector3 _velocity; //Field offset: 0x2C
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C12")]
		private Vector3 _currentStart; //Field offset: 0x38
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000C13")]
		private Vector3 _currentTarget; //Field offset: 0x44
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C14")]
		private float _orbitAngle; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000C15")]
		private float _orbitRadius; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C16")]
		private int _orbitDirection; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000C17")]
		private Vector3 _contactPoint; //Field offset: 0x5C
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000C18")]
		private float _contactAngle; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000C19")]
		private float _orbitTimer; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000C1A")]
		private float _currentSpeed; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4000C1B")]
		private float _constantSpeed; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000C1C")]
		private bool _hasReachedCruiseSpeed; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000C1D")]
		private float _speedStart; //Field offset: 0x7C
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000C1E")]
		private float _speedTarget; //Field offset: 0x80
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4000C1F")]
		private float _speedTransitionTimer; //Field offset: 0x84
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000C20")]
		private float _speedTransitionDuration; //Field offset: 0x88
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x4000C21")]
		private Phase _phase; //Field offset: 0x8C

		[Token(Token = "0x170001EB")]
		private float CurrentMaxSpeed
		{
			[Address(RVA = "0x1D88BF0", Offset = "0x1D87FF0", Length = "0x1B")]
			[Token(Token = "0x6000C40")]
			private get { } //Length: 27
		}

		[Token(Token = "0x170001E9")]
		internal bool HasReachedContact
		{
			[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
			[Token(Token = "0x6000C3A")]
			internal get { } //Length: 5
		}

		[Token(Token = "0x170001EA")]
		public bool IsStraightPhase
		{
			[Address(RVA = "0x1D88C20", Offset = "0x1D88020", Length = "0xB")]
			[Token(Token = "0x6000C3B")]
			 get { } //Length: 11
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000C39")]
		internal PatrolMovementController(Ene_Bos02 owner) { }

		[Address(RVA = "0x1D87010", Offset = "0x1D86410", Length = "0xFA")]
		[Token(Token = "0x6000C4A")]
		private void AdvanceSpeed(float deltaTime, float playFactor) { }

		[Address(RVA = "0x1D87110", Offset = "0x1D86510", Length = "0x17D")]
		[Token(Token = "0x6000C49")]
		private void BeginSpeedTransition(float targetSpeed, float duration) { }

		[Address(RVA = "0x1D87290", Offset = "0x1D86690", Length = "0x5E")]
		[Token(Token = "0x6000C48")]
		private void ClampMoveSpeed() { }

		[Address(RVA = "0x1D872F0", Offset = "0x1D866F0", Length = "0x1E2")]
		[Token(Token = "0x6000C50")]
		private Vector3 ComputeOrbitContactPoint(Vector3 startPosition, Vector3 center, float radius, int direction, out float contactAngle) { }

		[Address(RVA = "0x1D874E0", Offset = "0x1D868E0", Length = "0x222")]
		[Token(Token = "0x6000C41")]
		private void EnsureInitialized() { }

		[Address(RVA = "0x1D87710", Offset = "0x1D86B10", Length = "0x138")]
		[Token(Token = "0x6000C51")]
		private static int FindNearestPatrolPointIndex(Vector3 position) { }

		[Address(RVA = "0x1D88BF0", Offset = "0x1D87FF0", Length = "0x1B")]
		[Token(Token = "0x6000C40")]
		private float get_CurrentMaxSpeed() { }

		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[Token(Token = "0x6000C3A")]
		internal bool get_HasReachedContact() { }

		[Address(RVA = "0x1D88C20", Offset = "0x1D88020", Length = "0xB")]
		[Token(Token = "0x6000C3B")]
		public bool get_IsStraightPhase() { }

		[Address(RVA = "0x1D87850", Offset = "0x1D86C50", Length = "0x6B")]
		[Token(Token = "0x6000C4B")]
		private int GetNextSequenceIndex() { }

		[Address(RVA = "0x1D878C0", Offset = "0x1D86CC0", Length = "0xBE")]
		[Token(Token = "0x6000C4E")]
		private Vector3 GetOrbitPosition(float angle) { }

		[Address(RVA = "0x1D87980", Offset = "0x1D86D80", Length = "0x9A")]
		[Token(Token = "0x6000C4F")]
		private Vector3 GetOrbitTangent(int direction, float angle) { }

		[Address(RVA = "0x1D87A20", Offset = "0x1D86E20", Length = "0x47")]
		[Token(Token = "0x6000C4D")]
		private static Vector3 GetPlanarDelta(Vector3 target, Vector3 origin) { }

		[Address(RVA = "0x1D87C90", Offset = "0x1D87090", Length = "0xCE")]
		[Token(Token = "0x6000C46")]
		private void PrepareStraightSegment(Vector3 startPosition) { }

		[Address(RVA = "0x1D87A70", Offset = "0x1D86E70", Length = "0x21C")]
		[Token(Token = "0x6000C47")]
		private void PrepareStraightSegment(Vector3 startPosition, Vector3 contactPoint, float contactAngle, int orbitDirection) { }

		[Address(RVA = "0x1D87D60", Offset = "0x1D87160", Length = "0xA6")]
		[Token(Token = "0x6000C4C")]
		private void RefreshCurrentTarget() { }

		[Address(RVA = "0x1D87E10", Offset = "0x1D87210", Length = "0x5")]
		[Token(Token = "0x6000C3F")]
		internal void RequestOrbitAdvance() { }

		[Address(RVA = "0x1D87E20", Offset = "0x1D87220", Length = "0x17F")]
		[Token(Token = "0x6000C3C")]
		internal void Reset() { }

		[Address(RVA = "0x1D87FA0", Offset = "0x1D873A0", Length = "0x7")]
		[Token(Token = "0x6000C3D")]
		internal void StartMovement() { }

		[Address(RVA = "0x1D87FB0", Offset = "0x1D873B0", Length = "0x27F")]
		[Token(Token = "0x6000C44")]
		private void StartOrbitPhase() { }

		[Address(RVA = "0x1D88230", Offset = "0x1D87630", Length = "0x83")]
		[Token(Token = "0x6000C45")]
		private void TransitionToNextStraightSegment(int nextSequenceIndex, Vector3 currentPosition, Vector3 nextContact, float nextContactAngle, int nextOrbitDirection) { }

		[Address(RVA = "0x1D88B70", Offset = "0x1D87F70", Length = "0x78")]
		[Token(Token = "0x6000C3E")]
		internal void Update(float deltaTime, float playFactor) { }

		[Address(RVA = "0x1D882C0", Offset = "0x1D876C0", Length = "0x5A6")]
		[Token(Token = "0x6000C43")]
		private void UpdateOrbitPhase(float deltaTime, float playFactor) { }

		[Address(RVA = "0x1D88870", Offset = "0x1D87C70", Length = "0x2F5")]
		[Token(Token = "0x6000C42")]
		private void UpdateStraightPhase(float deltaTime, float playFactor) { }

	}

	[Token(Token = "0x4000B98")]
	private const float _coreMuzzleArc = -60; //Field offset: 0x0
	[Token(Token = "0x4000BBE")]
	private const float PatternAttackMinimumDuration = 1; //Field offset: 0x0
	[Token(Token = "0x4000BBF")]
	private const float PatternAttackCooldown = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000BC1")]
	private const float Pattern2FireInterval = 0.1; //Field offset: 0x0
	[Token(Token = "0x4000BC2")]
	private const float Pattern3FireInterval = 0.05; //Field offset: 0x0
	[Token(Token = "0x4000BC3")]
	private const int PatrolStartIndex = 0; //Field offset: 0x0
	[Token(Token = "0x4000BC4")]
	private const float PatrolArrivalRadius = 5; //Field offset: 0x0
	[Token(Token = "0x4000BC5")]
	private const float PatrolMoveSpeedMax = 20; //Field offset: 0x0
	[Token(Token = "0x4000BC6")]
	private const float PatrolMoveSpeedMin = 10; //Field offset: 0x0
	[Token(Token = "0x4000BC7")]
	private const float PatrolOrbitSpeedMax = 8; //Field offset: 0x0
	[Token(Token = "0x4000BC8")]
	private const float PatrolOrbitMinDuration = 3; //Field offset: 0x0
	[Token(Token = "0x4000BC9")]
	private const float PatrolAccelerationDuration = 3; //Field offset: 0x0
	[Token(Token = "0x4000BCA")]
	private const float PatrolDecelerationDuration = 2; //Field offset: 0x0
	[Token(Token = "0x4000BCB")]
	private const float OrbitAlignmentThreshold = 0.95; //Field offset: 0x0
	[Token(Token = "0x4000BCC")]
	private const float PatrolDistanceEpsilon = 0.001; //Field offset: 0x0
	[Token(Token = "0x4000BCD")]
	private const float PatrolPostArrivalDelay = 5; //Field offset: 0x0
	[Token(Token = "0x4000BCE")]
	private const float PatrolBackLine = 50; //Field offset: 0x0
	[Token(Token = "0x4000BCF")]
	private const float PatrolFrontLine = 30; //Field offset: 0x0
	[Token(Token = "0x4000BD2")]
	private const float Pattern5StartDelay = 0; //Field offset: 0x0
	[Token(Token = "0x4000BD3")]
	private const float Pattern5PostFireDelay = 5; //Field offset: 0x0
	[Token(Token = "0x4000BD4")]
	private const float Pattern5Interval = 0; //Field offset: 0x0
	[Token(Token = "0x4000BD5")]
	private const float Pattern6StartDelay = 5; //Field offset: 0x0
	[Token(Token = "0x4000BD6")]
	private const float Pattern6Interval = 10; //Field offset: 0x0
	[Token(Token = "0x4000BD7")]
	private const float Pattern7StartDelay = 1; //Field offset: 0x0
	[Token(Token = "0x4000BD8")]
	private const float Pattern7Interval = 10; //Field offset: 0x0
	[Token(Token = "0x4000BD9")]
	private const float Pattern7FireInterval = 0.1; //Field offset: 0x0
	[Token(Token = "0x4000BDA")]
	private const float Pattern7FireInitial = 2; //Field offset: 0x0
	[Token(Token = "0x4000BDB")]
	private const float Pattern7FireMiddle = 2; //Field offset: 0x0
	[Token(Token = "0x4000BDC")]
	private const float Pattern7FireFinal = 1; //Field offset: 0x0
	[Token(Token = "0x4000BDD")]
	private const int Pattern7RollRange = 25; //Field offset: 0x0
	[Token(Token = "0x4000BBD")]
	private const float PatternAttackDurationDecrement = 1; //Field offset: 0x0
	[Token(Token = "0x4000BBC")]
	private const float PatternAttackInitialDuration = 5; //Field offset: 0x0
	[Token(Token = "0x4000BC0")]
	private const float Pattern1FireInterval = 0.2; //Field offset: 0x0
	[Token(Token = "0x4000B99")]
	private const float HorizontalLimitRange = 80; //Field offset: 0x0
	[Token(Token = "0x4000B9B")]
	private const float MoveSpeedMin = 10; //Field offset: 0x0
	[Token(Token = "0x4000B9C")]
	private const float MoveAcceleration = 6; //Field offset: 0x0
	[Token(Token = "0x4000B9D")]
	private const float MoveDeceleration = 4; //Field offset: 0x0
	[Token(Token = "0x4000B9E")]
	private const float PositionDeadZone = 1.5; //Field offset: 0x0
	[Token(Token = "0x4000B9F")]
	private const float PositionSpeedRange = 60; //Field offset: 0x0
	[Token(Token = "0x4000BA0")]
	private const float RollTargetScale = 1.5; //Field offset: 0x0
	[Token(Token = "0x4000BA1")]
	private const float RollResponse = 20; //Field offset: 0x0
	[Token(Token = "0x4000BA2")]
	private const float RollDamping = 3; //Field offset: 0x0
	[Token(Token = "0x4000BA3")]
	private const float MaxRollAngle = 4; //Field offset: 0x0
	[Token(Token = "0x4000BA4")]
	private static readonly Quaternion _coreRot; //Field offset: 0x0
	[Token(Token = "0x4000B9A")]
	private const float MoveSpeedMax = 20; //Field offset: 0x0
	[Token(Token = "0x4000BA5")]
	private static readonly Quaternion _modelTopRotateStart; //Field offset: 0x10
	[Token(Token = "0x4000BA6")]
	private static readonly Single[] _underLaserMuzzleDir; //Field offset: 0x20
	[Token(Token = "0x4000BA7")]
	private static readonly Vector3 _callLSide; //Field offset: 0x28
	[Token(Token = "0x4000BA8")]
	private static readonly Vector3 _callRSide; //Field offset: 0x34
	[Token(Token = "0x4000BA9")]
	private static readonly Vector3 lastHomePosition; //Field offset: 0x40
	[Token(Token = "0x4000BAA")]
	private static readonly String[] btNames; //Field offset: 0x50
	[Token(Token = "0x4000BAB")]
	private static readonly String[] _boss02ClipDatas; //Field offset: 0x58
	[Token(Token = "0x4000BAC")]
	private static readonly int MuzzleCount; //Field offset: 0x60
	[Token(Token = "0x4000BBB")]
	private static readonly float _EntryNoHitTime; //Field offset: 0x64
	[Token(Token = "0x4000BD0")]
	private static readonly Vector3[] PatrolPoints; //Field offset: 0x68
	[Token(Token = "0x4000BD1")]
	private static readonly Int32[] PatrolOrder; //Field offset: 0x70
	[Token(Token = "0x4000BDE")]
	private static readonly Fire6Table[] _Pattern6TimeTable; //Field offset: 0x78
	[Token(Token = "0x4000BDF")]
	private static readonly Fire7Table[] _Pattern7Table; //Field offset: 0x80
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000BAD")]
	private Boss02State _bos02state; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4000BAE")]
	private Vector3 _moveStep; //Field offset: 0x274
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000BAF")]
	private float _localTime; //Field offset: 0x280
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4000BB0")]
	private float _moveSpeed; //Field offset: 0x284
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000BB1")]
	private int _moveDirHold; //Field offset: 0x288
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x4000BB2")]
	private float _rotateZ; //Field offset: 0x28C
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000BB3")]
	private bool _backWingMode; //Field offset: 0x290
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x4000BB4")]
	private float _rollSmoothAngle; //Field offset: 0x294
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000BB5")]
	private float _lastTargetVelocity; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x4000BB6")]
	private Transform _bodyFront; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	[Token(Token = "0x4000BB7")]
	private Transform _backWingL; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x4000BB8")]
	private Transform _backWingR; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	[Token(Token = "0x4000BB9")]
	private Transform[] _backCores; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000BBA")]
	private Transform[] _muzzles; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000BE0")]
	private int _turnCount; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2CC")]
	[Token(Token = "0x4000BE1")]
	private float _attackDuration; //Field offset: 0x2CC
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000BE2")]
	private float _cooldownTimer; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D4")]
	[Token(Token = "0x4000BE3")]
	private float _fireTimer; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000BE4")]
	private bool _fire1NextAimPlayer; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x4000BE5")]
	private int _fire1Count; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000BE6")]
	private PatrolMovementController _patrolMovement; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000BE7")]
	private Fire5Controller _fire5Controller; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000BE8")]
	private Fire6Controller _fire6Controller; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000BE9")]
	private Fire7Controller _fire7Controller; //Field offset: 0x2F8

	[Token(Token = "0x170001E8")]
	private InGameManager GameManager
	{
		[Address(RVA = "0x1D81F80", Offset = "0x1D81380", Length = "0x73")]
		[Token(Token = "0x6000C0A")]
		private get { } //Length: 115
	}

	[Address(RVA = "0x1D812B0", Offset = "0x1D806B0", Length = "0xC3F")]
	[Token(Token = "0x6000C37")]
	private static Ene_Bos02() { }

	[Address(RVA = "0x1D81EF0", Offset = "0x1D812F0", Length = "0x8F")]
	[Token(Token = "0x6000C36")]
	public Ene_Bos02() { }

	[Address(RVA = "0x1D81110", Offset = "0x1D80510", Length = "0x2E")]
	[CompilerGenerated]
	[Token(Token = "0x6000C38")]
	private void <PatternMove1>b__110_0() { }

	[Address(RVA = "0x1D7D250", Offset = "0x1D7C650", Length = "0x5D")]
	[Token(Token = "0x6000C27")]
	private void ActivateUnderWingCores() { }

	[Address(RVA = "0x1D7D2B0", Offset = "0x1D7C6B0", Length = "0x13")]
	[Token(Token = "0x6000C23")]
	private void AdvanceTurnCounter() { }

	[Address(RVA = "0x1D7D2D0", Offset = "0x1D7C6D0", Length = "0x6C")]
	[Token(Token = "0x6000C11")]
	private void CheckNextState() { }

	[Address(RVA = "0x1D7D340", Offset = "0x1D7C740", Length = "0x10F")]
	[Token(Token = "0x6000C17")]
	private void DampHorizontalVelocity(float stepDelta, float stepPlayFactor) { }

	[Address(RVA = "0x1D7D450", Offset = "0x1D7C850", Length = "0x3E1")]
	[Token(Token = "0x6000C16")]
	private void ExecuteHorizontalChaseStep(InGameManager manager, float stepDelta, float stepPlayFactor) { }

	[Address(RVA = "0x1D7D840", Offset = "0x1D7CC40", Length = "0x16F")]
	[Token(Token = "0x6000C29")]
	private bool ExecutePatrolPattern(float deltaTime, float playFactor) { }

	[Address(RVA = "0x1D7D9B0", Offset = "0x1D7CDB0", Length = "0xAA")]
	[Token(Token = "0x6000C25")]
	private void ExecutePatternFireLoop(float deltaTime, float fireInterval, Action fireAction) { }

	[Address(RVA = "0x1D7DA60", Offset = "0x1D7CE60", Length = "0xC2")]
	[Token(Token = "0x6000C30")]
	private void Fire1(bool isAimPlayer) { }

	[Address(RVA = "0x1D7DB30", Offset = "0x1D7CF30", Length = "0xA0")]
	[Token(Token = "0x6000C31")]
	private void Fire2() { }

	[Address(RVA = "0x1D7DBE0", Offset = "0x1D7CFE0", Length = "0xC1")]
	[Token(Token = "0x6000C32")]
	private void Fire3() { }

	[Address(RVA = "0x1D7DCB0", Offset = "0x1D7D0B0", Length = "0xBA")]
	[Token(Token = "0x6000C33")]
	private void Fire5() { }

	[Address(RVA = "0x1D7DD70", Offset = "0x1D7D170", Length = "0x190")]
	[Token(Token = "0x6000C34")]
	private void Fire6(int muzzleIndex) { }

	[Address(RVA = "0x1D7DF10", Offset = "0x1D7D310", Length = "0x3AF")]
	[Token(Token = "0x6000C35")]
	private void Fire7(float rate) { }

	[Address(RVA = "0x1D81F80", Offset = "0x1D81380", Length = "0x73")]
	[Token(Token = "0x6000C0A")]
	private InGameManager get_GameManager() { }

	[Address(RVA = "0x1D7E2C0", Offset = "0x1D7D6C0", Length = "0x4F")]
	[Token(Token = "0x6000C19")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1D7E310", Offset = "0x1D7D710", Length = "0x4F")]
	[Token(Token = "0x6000C1A")]
	protected virtual String[] GetBossCD() { }

	[Address(RVA = "0x1D7E360", Offset = "0x1D7D760", Length = "0x22")]
	[Token(Token = "0x6000C22")]
	private float GetCurrentTurnDuration() { }

	[Address(RVA = "0x1D7E390", Offset = "0x1D7D790", Length = "0x2E")]
	[Token(Token = "0x6000C12")]
	private Transform GetMuzzle(Boss02MZ mz) { }

	[Address(RVA = "0x1D7E3C0", Offset = "0x1D7D7C0", Length = "0xEC")]
	[Token(Token = "0x6000C2F")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1D7E4B0", Offset = "0x1D7D8B0", Length = "0x25")]
	[Token(Token = "0x6000C0D")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D7E4E0", Offset = "0x1D7D8E0", Length = "0x4A")]
	[Token(Token = "0x6000C1D")]
	private void HandleBackWingNextState() { }

	[Address(RVA = "0x1D7E530", Offset = "0x1D7D930", Length = "0x1EC")]
	[Token(Token = "0x6000C1C")]
	private void HandleFrontModeNextState() { }

	[Address(RVA = "0x1D7E760", Offset = "0x1D7DB60", Length = "0x47B")]
	[Token(Token = "0x6000C0B")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D7E720", Offset = "0x1D7DB20", Length = "0x33")]
	[Token(Token = "0x6000C24")]
	private void InitializePatternState() { }

	[Address(RVA = "0x1D7EBE0", Offset = "0x1D7DFE0", Length = "0x4D")]
	[Token(Token = "0x6000C0F")]
	public virtual void OnPartsBreak(int parts) { }

	[Address(RVA = "0x1D7EC30", Offset = "0x1D7E030", Length = "0x573")]
	[Token(Token = "0x6000C2D")]
	private void OpenBackWing() { }

	[Address(RVA = "0x1D7F1B0", Offset = "0x1D7E5B0", Length = "0x252")]
	[Token(Token = "0x6000C1E")]
	private void PatternEntry() { }

	[Address(RVA = "0x1D7F410", Offset = "0x1D7E810", Length = "0x204")]
	[Token(Token = "0x6000C1F")]
	private void PatternMove1() { }

	[Address(RVA = "0x1D7F620", Offset = "0x1D7EA20", Length = "0x202")]
	[Token(Token = "0x6000C20")]
	private void PatternMove2() { }

	[Address(RVA = "0x1D7F830", Offset = "0x1D7EC30", Length = "0x202")]
	[Token(Token = "0x6000C21")]
	private void PatternMove3() { }

	[Address(RVA = "0x1D7FA40", Offset = "0x1D7EE40", Length = "0x5E4")]
	[Token(Token = "0x6000C2A")]
	private void PatternMove5() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000C2B")]
	private void PatternMove6() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000C2C")]
	private void PatternMove7() { }

	[Address(RVA = "0x1D80030", Offset = "0x1D7F430", Length = "0x69B")]
	[Token(Token = "0x6000C2E")]
	private void PatternMoveDestruction(float deltaTime) { }

	[Address(RVA = "0x1D806D0", Offset = "0x1D7FAD0", Length = "0x35")]
	[Token(Token = "0x6000C26")]
	private bool ProcessCooldown(float deltaTime) { }

	[Address(RVA = "0x1D80A10", Offset = "0x1D7FE10", Length = "0xC1")]
	[Token(Token = "0x6000C1B")]
	private void ResetBackCoresRotation() { }

	[Address(RVA = "0x1D80AE0", Offset = "0x1D7FEE0", Length = "0x169")]
	[Token(Token = "0x6000C18")]
	private float ResolveTargetVelocity(float distanceAbs, float horizontalDelta) { }

	[Address(RVA = "0x1D80710", Offset = "0x1D7FB10", Length = "0x2F9")]
	[Token(Token = "0x6000C0C")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D80C50", Offset = "0x1D80050", Length = "0xF6")]
	[Token(Token = "0x6000C28")]
	private void RotateBackCorePair(int patternIndex, float localTime) { }

	[Address(RVA = "0x1D80D50", Offset = "0x1D80150", Length = "0x39")]
	[Token(Token = "0x6000C10")]
	private void SetState(Boss02State nextState) { }

	[Address(RVA = "0x1D80D90", Offset = "0x1D80190", Length = "0x124")]
	[Token(Token = "0x6000C13")]
	protected virtual void StateExec(float deltaTime) { }

	[Address(RVA = "0x1D80EC0", Offset = "0x1D802C0", Length = "0xB6")]
	[Token(Token = "0x6000C0E")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1D80F80", Offset = "0x1D80380", Length = "0x182")]
	[Token(Token = "0x6000C15")]
	private void TrackPlayerHorizontally(float deltaTime, float playFactor, bool allowMovement) { }

	[Address(RVA = "0x1D81140", Offset = "0x1D80540", Length = "0x162")]
	[Token(Token = "0x6000C14")]
	private void UpdateRollAngle(float moveSpeed, float playFactor) { }

}

