namespace InGame.Kernel.Player;

[Token(Token = "0x200010D")]
public class PlayerControll : InGameObject, IPrefabBankObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000113")]
	private struct <_autoPilot>d__186 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007D4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007D5")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007D6")]
		public PlayerControll <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007D7")]
		public AnimationClip clip; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007D8")]
		public string label; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007D9")]
		private AnimationClipPlayable <p>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40007DA")]
		private AnimationPlayableOutput <o>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40007DB")]
		private float <remainTime>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40007DC")]
		private Awaiter <>u__1; //Field offset: 0x54

		[Address(RVA = "0x1D55330", Offset = "0x1D54730", Length = "0x3E0")]
		[Token(Token = "0x60008D7")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60008D8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000114")]
	private struct <_playerBombAsync>d__35 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007DD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007DE")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007DF")]
		public PlayerControll <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007E0")]
		private InGameManager <gm>5__2; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007E1")]
		private PlayerControll <p2>5__3; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007E2")]
		private float <rolls>5__4; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40007E3")]
		private float <ttime>5__5; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007E4")]
		private Transform <ttrns>5__6; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40007E5")]
		private Awaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x1D55720", Offset = "0x1D54B20", Length = "0x672")]
		[Token(Token = "0x60008D9")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60008DA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000115")]
	private struct <_playerRescueDelayAsync>d__187 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007E6")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007E7")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007E8")]
		public PlayerControll <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007E9")]
		private float <shakeTime>5__2; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40007EA")]
		private float <passTime>5__3; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007EB")]
		private Vector3 <lpos>5__4; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40007EC")]
		private InGameManager <gm>5__5; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40007ED")]
		private Awaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x1D55DA0", Offset = "0x1D551A0", Length = "0x983")]
		[Token(Token = "0x60008DB")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60008DC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000116")]
	private sealed class <_setupWeapons>d__47 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007EE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007EF")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007F0")]
		public PlayerControll <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007F1")]
		private Transform <poolRoot>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007F2")]
		private Transform <gameRoot>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40007F3")]
		private AsyncInstantiateOperation<GameObject> <tobjs>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40007F4")]
		private int <i>5__5; //Field offset: 0x40

		[Token(Token = "0x170001A5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60008E0")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001A6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60008E2")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60008DD")]
		public <_setupWeapons>d__47(int <>1__state) { }

		[Address(RVA = "0x1D56730", Offset = "0x1D55B30", Length = "0x642")]
		[Token(Token = "0x60008DF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60008E0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60008E2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D56D80", Offset = "0x1D56180", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60008E1")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60008DE")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000110")]
	private struct <PlayerEntryAsync>d__181 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007C4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007C5")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007C6")]
		public PlayerControll <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007C7")]
		private float <ttime>5__2; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40007C8")]
		private Awaiter <>u__1; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007C9")]
		private Awaiter <>u__2; //Field offset: 0x28

		[Address(RVA = "0x1D54430", Offset = "0x1D53830", Length = "0x981")]
		[Token(Token = "0x60008CD")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60008CE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000111")]
	private struct <PlayerExitAsync>d__185 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007CA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007CB")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007CC")]
		public PlayerControll <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007CD")]
		private Sequence <eveseq>5__2; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007CE")]
		private Awaiter <>u__1; //Field offset: 0x20

		[Address(RVA = "0x1D54DC0", Offset = "0x1D541C0", Length = "0x43C")]
		[Token(Token = "0x60008CF")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60008D0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000112")]
	private sealed class <SetupOwner>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007CF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007D0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007D1")]
		public PlayerControll <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007D2")]
		public int pno; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007D3")]
		public PlayerInformation pinfo; //Field offset: 0x30

		[Token(Token = "0x170001A3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60008D4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001A4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60008D6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60008D1")]
		public <SetupOwner>d__1(int <>1__state) { }

		[Address(RVA = "0x1D55200", Offset = "0x1D54600", Length = "0xE1")]
		[Token(Token = "0x60008D3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60008D4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60008D6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D552F0", Offset = "0x1D546F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60008D5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60008D2")]
		private override void System.IDisposable.Dispose() { }

	}

	[Flags]
	[Token(Token = "0x200010F")]
	internal enum PFlag : int
	{
		None = 0,
		DisableMove = 1,
		DisableShot = 2,
		DisableCtrl = 4,
		DisableFire = 8,
		DisableExShot = 16,
		DisableBomb = 32,
		Bombering = 256,
		RightTurn = 512,
		AutoPilot = 1024,
		Deading = 2048,
		RescueWait = 4096,
		ReStartClear = 6454,
		DisablePause = 524288,
		TeamPlay = 1048576,
		AutoBomb = 2097152,
	}

	[Token(Token = "0x200010E")]
	internal enum TutorailType : int
	{
		None = 0,
		Learning = 1,
		Practice = 2,
	}

	[Token(Token = "0x400079A")]
	public const float ClearPlayTime = 1.5; //Field offset: 0x0
	[Token(Token = "0x400079C")]
	private const float DamageEffectTime = 6; //Field offset: 0x0
	[Token(Token = "0x400079D")]
	private const float AutoRescueTime = 2; //Field offset: 0x0
	[Token(Token = "0x400079B")]
	private static readonly Vector3 ClearRotateAngle; //Field offset: 0x0
	[Token(Token = "0x400079F")]
	private static readonly float ExboostChageTime; //Field offset: 0xC
	[Token(Token = "0x40007A0")]
	private static readonly float BombVibrationTime; //Field offset: 0x10
	[Token(Token = "0x40007A1")]
	private static readonly float BombVibrationLow; //Field offset: 0x14
	[Token(Token = "0x40007A2")]
	private static readonly float BombVibrationHigh; //Field offset: 0x18
	[Token(Token = "0x40007A3")]
	private static readonly float DeadVibrationTime; //Field offset: 0x1C
	[Token(Token = "0x40007A4")]
	private static readonly float DeadVibrationLow; //Field offset: 0x20
	[Token(Token = "0x40007A5")]
	private static readonly float DeadVibrationHigh; //Field offset: 0x24
	[Token(Token = "0x40007A6")]
	private static readonly Vector3 _slowSpeedVector; //Field offset: 0x28
	[Token(Token = "0x40007A7")]
	private static readonly int DeadEffectCode; //Field offset: 0x34
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000759")]
	private superFighterCollision _collision; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400075A")]
	private int _playerNo; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400075B")]
	private PlayerInformation _pinfo; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400075C")]
	private bool _isRStick; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400075D")]
	private int _padNo; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400075E")]
	private int _currentWeaponIndex; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400075F")]
	private int _optionCount; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000760")]
	private int _weaponCount; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000761")]
	private float _moveSpeed; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000762")]
	private float _rotateYaw; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000763")]
	private float _previousDeltaX; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000764")]
	private float _yawRotateTarget; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000765")]
	private float _yawRequiredTime; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000766")]
	private float _yawRotateTime; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000767")]
	private float _yawRotateStart; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000768")]
	private float _clampZMin; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000769")]
	private float _clampZMax; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400076A")]
	private Vector3 _startPosition; //Field offset: 0xC0
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x400076B")]
	private Vector3 _targetPosition; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400076C")]
	private Vector3 _normalSpeedBurner; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x400076D")]
	private Transform _yawModel; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x400076E")]
	private GameObject _renderModel; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x400076F")]
	private Transform _modelRoot; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000770")]
	private Transform[] _burners; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000771")]
	private GameObject _modelTop; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000772")]
	private GameObject _muzzleEffect; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000773")]
	private superFighterCollisionModel _collisionModel; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000774")]
	private PlayerRescueCollisionModel _rescueModel; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000775")]
	private SuperFighterOptions[] _leftSideOptions; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x4000776")]
	private SuperFighterOptions[] _rightSideOptions; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x4000777")]
	private Transform[] _emitters; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000778")]
	private Transform[] _muzzles; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x4000779")]
	private GameObject _playerEffects; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400077A")]
	private List<PlayerMuzzle> _playerMuzzles; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400077B")]
	private Transform _targetPlayerModel; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400077C")]
	private IWeapons _currentWeapon; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400077D")]
	private SuperFighterOptionClamp[] _optionsClamp; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400077E")]
	private IWeapons[] _weaponLists; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400077F")]
	private WeaponNormalBomb _bomb; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000780")]
	private PlayerEffects _effects; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000781")]
	private CancellationToken _token; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000782")]
	private Animator _animator; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000783")]
	private PlayableGraph _graph; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000784")]
	private TutorailType _tutorialType; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x4000785")]
	private PlayerDefinedSpeeds _playerDefinedParams; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x4000786")]
	private PlayerDefinedFighter _playerDefined2D; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x4000787")]
	private PlayerDefinedFighterOptions _playerDefinedFighgterOptions; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x4000788")]
	private GameObject[] _upgradeParts; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000789")]
	private Buttons _fireButtons; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x400078A")]
	private Buttons _exboostButtons; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400078B")]
	private Buttons _speedChangeButtons; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x400078C")]
	private Buttons _speedUpButtons; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400078D")]
	private Buttons _speedDownButtons; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x400078E")]
	private Buttons _speedSlowButtons; //Field offset: 0x1E4
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400078F")]
	private Buttons _fireKeys; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000790")]
	private Buttons _exboostKeys; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000791")]
	private Buttons _speedChangeKeys; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4000792")]
	private Buttons _speedUpKeys; //Field offset: 0x1F4
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000793")]
	private Buttons _speedDownKeys; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x4000794")]
	private Buttons _speedSlowKeys; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000795")]
	private Buttons _bombButtons; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x4000796")]
	private Buttons _bombKeys; //Field offset: 0x204
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000797")]
	private int _vibrationType; //Field offset: 0x208
	[CompilerGenerated]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000798")]
	private PadAssign <CustomKeys>k__BackingField; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000799")]
	private PFlag _pflag; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x400079E")]
	private float _rescueTime; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40007A8")]
	private bool _isExboostMode; //Field offset: 0x220
	[FieldOffset(Offset = "0x221")]
	[Token(Token = "0x40007A9")]
	private bool _isCaptured; //Field offset: 0x221
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x40007AA")]
	private float _exboostCharge; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40007AB")]
	private int _exboostSECh; //Field offset: 0x228
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x40007AC")]
	private int _playerShotCount; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x40007AD")]
	private int _playerExShotCount; //Field offset: 0x230
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x40007AE")]
	private bool _speedChangeReverse; //Field offset: 0x234

	[Token(Token = "0x17000187")]
	public IWeapons CurrentWeapon
	{
		[Address(RVA = "0x1D4E410", Offset = "0x1D4D810", Length = "0x8")]
		[Token(Token = "0x600089C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000185")]
	public int CurrentWeaponIndex
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x600089A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700018C")]
	public private PadAssign CustomKeys
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60008A1")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60008A2")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170001A0")]
	private ID GetDeadEffectSE
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008C1")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700019D")]
	public bool IsAutoBomb
	{
		[Address(RVA = "0x1D4E430", Offset = "0x1D4D830", Length = "0xE")]
		[Token(Token = "0x60008B6")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000193")]
	public bool IsAutoPilot
	{
		[Address(RVA = "0x1D4E440", Offset = "0x1D4D840", Length = "0xE")]
		[Token(Token = "0x60008AC")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000197")]
	public bool IsBombering
	{
		[Address(RVA = "0x1D4E450", Offset = "0x1D4D850", Length = "0xE")]
		[Token(Token = "0x60008B0")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000194")]
	public bool IsDeading
	{
		[Address(RVA = "0x1D4E480", Offset = "0x1D4D880", Length = "0xE")]
		[Token(Token = "0x60008AD")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000195")]
	public bool IsDeadingNoAction
	{
		[Address(RVA = "0x1D4E460", Offset = "0x1D4D860", Length = "0x1D")]
		[Token(Token = "0x60008AE")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000192")]
	public bool IsDisableBomb
	{
		[Address(RVA = "0x1D4E490", Offset = "0x1D4D890", Length = "0xE")]
		[Token(Token = "0x60008AB")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700018D")]
	public bool IsDisableCtrl
	{
		[Address(RVA = "0x1D4E4A0", Offset = "0x1D4D8A0", Length = "0xB")]
		[Token(Token = "0x60008A6")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000190")]
	public bool IsDisableExShot
	{
		[Address(RVA = "0x1D4E4B0", Offset = "0x1D4D8B0", Length = "0xB")]
		[Token(Token = "0x60008A9")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000191")]
	public bool IsDisableFire
	{
		[Address(RVA = "0x1D4E4C0", Offset = "0x1D4D8C0", Length = "0xB")]
		[Token(Token = "0x60008AA")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700018E")]
	public bool IsDisablePause
	{
		[Address(RVA = "0x1D4E4D0", Offset = "0x1D4D8D0", Length = "0xE")]
		[Token(Token = "0x60008A7")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700018F")]
	public bool IsDisableShot
	{
		[Address(RVA = "0x1D4E4E0", Offset = "0x1D4D8E0", Length = "0xE")]
		[Token(Token = "0x60008A8")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000199")]
	public bool IsItemTaken
	{
		[Address(RVA = "0x1D4E4F0", Offset = "0x1D4D8F0", Length = "0x26")]
		[Token(Token = "0x60008B2")]
		 get { } //Length: 38
	}

	[Token(Token = "0x17000189")]
	private bool IsRecoverly
	{
		[Address(RVA = "0x1D4E520", Offset = "0x1D4D920", Length = "0xB")]
		[Token(Token = "0x600089E")]
		private get { } //Length: 11
	}

	[Token(Token = "0x1700019A")]
	public bool IsRescueOK
	{
		[Address(RVA = "0x1D4E530", Offset = "0x1D4D930", Length = "0x1D")]
		[Token(Token = "0x60008B3")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000196")]
	public bool IsRescueWait
	{
		[Address(RVA = "0x1D4E550", Offset = "0x1D4D950", Length = "0xE")]
		[Token(Token = "0x60008AF")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000198")]
	public bool IsRightMove
	{
		[Address(RVA = "0x1D4E560", Offset = "0x1D4D960", Length = "0xE")]
		[Token(Token = "0x60008B1")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000184")]
	public bool IsTeamDouble
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[Token(Token = "0x6000899")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700019C")]
	public bool IsTeamMode
	{
		[Address(RVA = "0x1D4E580", Offset = "0x1D4D980", Length = "0xE")]
		[Token(Token = "0x60008B5")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700018A")]
	private bool IsTutorialLearn
	{
		[Address(RVA = "0x1D4E590", Offset = "0x1D4D990", Length = "0xB")]
		[Token(Token = "0x600089F")]
		private get { } //Length: 11
	}

	[Token(Token = "0x1700019B")]
	public bool IsUpdatePosition
	{
		[Address(RVA = "0x1D4E610", Offset = "0x1D4DA10", Length = "0x1D")]
		[Token(Token = "0x60008B4")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700018B")]
	public bool IsUpGradeModel
	{
		[Address(RVA = "0x1D4E5A0", Offset = "0x1D4D9A0", Length = "0x6D")]
		[Token(Token = "0x60008A0")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000182")]
	public superFighterCollision playerBody
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000897")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001A2")]
	public int PlayerExShotCount
	{
		[Address(RVA = "0x1D4E630", Offset = "0x1D4DA30", Length = "0x7")]
		[Token(Token = "0x60008CA")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000183")]
	public int PlayerNo
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x6000898")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001A1")]
	public int PlayerShotCount
	{
		[Address(RVA = "0x1D4E640", Offset = "0x1D4DA40", Length = "0x7")]
		[Token(Token = "0x60008C9")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700019E")]
	public float RemainRescueTime
	{
		[Address(RVA = "0x1D4E650", Offset = "0x1D4DA50", Length = "0x9")]
		[Token(Token = "0x60008BD")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700019F")]
	public float RescueTimeRate
	{
		[Address(RVA = "0x1D4E660", Offset = "0x1D4DA60", Length = "0x2D")]
		[Token(Token = "0x60008BE")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000188")]
	public IWeapons[] WeaponLists
	{
		[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
		[Token(Token = "0x600089D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000186")]
	public Transform YawModel
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[Token(Token = "0x600089B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1D4BD10", Offset = "0x1D4B110", Length = "0x110")]
	[AsyncStateMachine(typeof(<_autoPilot>d__186))]
	[Token(Token = "0x60008BB")]
	private UniTask _autoPilot(AnimationClip clip, string label) { }

	[Address(RVA = "0x1D4C060", Offset = "0x1D4B460", Length = "0x27E")]
	[Token(Token = "0x60008C0")]
	private float _moveYaw(float deltaX) { }

	[Address(RVA = "0x1D4C2E0", Offset = "0x1D4B6E0", Length = "0x8D")]
	[AsyncStateMachine(typeof(<_playerBombAsync>d__35))]
	[Token(Token = "0x6000885")]
	private UniTaskVoid _playerBombAsync() { }

	[Address(RVA = "0x1D4CA40", Offset = "0x1D4BE40", Length = "0x995")]
	[Token(Token = "0x60008BF")]
	private void _playerControll(float deltaTime) { }

	[Address(RVA = "0x1D4C370", Offset = "0x1D4B770", Length = "0x3E2")]
	[Token(Token = "0x60008C6")]
	private void _playerControllFire(UIGamePad pad, float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60008B7")]
	private void _playerControllForDebug() { }

	[Address(RVA = "0x1D4C760", Offset = "0x1D4BB60", Length = "0x2D2")]
	[Token(Token = "0x60008C8")]
	private void _playerControllSpeedChange(UIGamePad pad) { }

	[Address(RVA = "0x1D4D3E0", Offset = "0x1D4C7E0", Length = "0x2A2")]
	[Token(Token = "0x6000887")]
	private void _playerDead() { }

	[Address(RVA = "0x1D4D690", Offset = "0x1D4CA90", Length = "0x7A")]
	[Token(Token = "0x6000895")]
	private void _playerOptionDisplay(int optionLevel) { }

	[Address(RVA = "0x1D4D710", Offset = "0x1D4CB10", Length = "0x2A3")]
	[Token(Token = "0x6000893")]
	private void _playerOptionDisplay(int optionLevel, Vector3 playerDeltaPosition, float deltaTime, bool isMoveX, bool isInitialize = false) { }

	[Address(RVA = "0x1D4D9C0", Offset = "0x1D4CDC0", Length = "0x1FD")]
	[Token(Token = "0x6000894")]
	private void _playerOptionProgress(Vector3 playerDeltaPosition, float deltaTime) { }

	[Address(RVA = "0x1D4DBC0", Offset = "0x1D4CFC0", Length = "0xD1")]
	[AsyncStateMachine(typeof(<_playerRescueDelayAsync>d__187))]
	[Token(Token = "0x60008BC")]
	private UniTask _playerRescueDelayAsync() { }

	[Address(RVA = "0x1D4DCA0", Offset = "0x1D4D0A0", Length = "0x67")]
	[IteratorStateMachine(typeof(<_setupWeapons>d__47))]
	[Token(Token = "0x6000891")]
	private IEnumerator _setupWeapons() { }

	[Address(RVA = "0x1D4DD10", Offset = "0x1D4D110", Length = "0x84")]
	[Token(Token = "0x6000883")]
	private void _stopVibration() { }

	[Address(RVA = "0x1D4DDA0", Offset = "0x1D4D1A0", Length = "0x290")]
	[Token(Token = "0x6000882")]
	private void _stopWeapon() { }

	[Address(RVA = "0x1D4E040", Offset = "0x1D4D440", Length = "0x34C")]
	[Token(Token = "0x6000892")]
	private void _terminateWeapons() { }

	[Address(RVA = "0x1D4E390", Offset = "0x1D4D790", Length = "0x7D")]
	[Token(Token = "0x6000881")]
	private void _updateSpeed() { }

	[Address(RVA = "0x1D4BE20", Offset = "0x1D4B220", Length = "0x141")]
	[Token(Token = "0x60008CC")]
	private static PlayerControll() { }

	[Address(RVA = "0x1D4BF70", Offset = "0x1D4B370", Length = "0xEB")]
	[Token(Token = "0x60008CB")]
	public PlayerControll() { }

	[Address(RVA = "0x1D48820", Offset = "0x1D47C20", Length = "0xB7")]
	[Token(Token = "0x6000877")]
	public bool AddSpeedCapacity(int nStep) { }

	[Address(RVA = "0x1D488E0", Offset = "0x1D47CE0", Length = "0x21")]
	[Token(Token = "0x6000871")]
	public bool BomberStockCountUp(int n) { }

	[Address(RVA = "0x1D48910", Offset = "0x1D47D10", Length = "0xE3")]
	[Token(Token = "0x6000878")]
	public bool ChangeSpeed(int nStep, bool withSound = true) { }

	[Address(RVA = "0x1D48D70", Offset = "0x1D48170", Length = "0xB2")]
	[Token(Token = "0x600086E")]
	public bool ChangeWeapon(ArmsKind akind) { }

	[Address(RVA = "0x1D48A00", Offset = "0x1D47E00", Length = "0x36E")]
	[Token(Token = "0x600086F")]
	public bool ChangeWeaponByIndex(int index) { }

	[Address(RVA = "0x1D48E30", Offset = "0x1D48230", Length = "0x365")]
	[Token(Token = "0x6000865")]
	public virtual void EntryInGame() { }

	[Address(RVA = "0x1D491A0", Offset = "0x1D485A0", Length = "0x1E")]
	[Token(Token = "0x60008C7")]
	private float ExternalFactorSpeedRate() { }

	[Address(RVA = "0x1D491C0", Offset = "0x1D485C0", Length = "0x1D3")]
	[Token(Token = "0x6000884")]
	public void FireBomber() { }

	[Address(RVA = "0x1D493A0", Offset = "0x1D487A0", Length = "0x216")]
	[Token(Token = "0x60008C2")]
	public void FireWeapon(bool isFire, bool isExBoost, float dt) { }

	[Address(RVA = "0x1D4E410", Offset = "0x1D4D810", Length = "0x8")]
	[Token(Token = "0x600089C")]
	public IWeapons get_CurrentWeapon() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x600089A")]
	public int get_CurrentWeaponIndex() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60008A1")]
	public PadAssign get_CustomKeys() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008C1")]
	private ID get_GetDeadEffectSE() { }

	[Address(RVA = "0x1D4E430", Offset = "0x1D4D830", Length = "0xE")]
	[Token(Token = "0x60008B6")]
	public bool get_IsAutoBomb() { }

	[Address(RVA = "0x1D4E440", Offset = "0x1D4D840", Length = "0xE")]
	[Token(Token = "0x60008AC")]
	public bool get_IsAutoPilot() { }

	[Address(RVA = "0x1D4E450", Offset = "0x1D4D850", Length = "0xE")]
	[Token(Token = "0x60008B0")]
	public bool get_IsBombering() { }

	[Address(RVA = "0x1D4E480", Offset = "0x1D4D880", Length = "0xE")]
	[Token(Token = "0x60008AD")]
	public bool get_IsDeading() { }

	[Address(RVA = "0x1D4E460", Offset = "0x1D4D860", Length = "0x1D")]
	[Token(Token = "0x60008AE")]
	public bool get_IsDeadingNoAction() { }

	[Address(RVA = "0x1D4E490", Offset = "0x1D4D890", Length = "0xE")]
	[Token(Token = "0x60008AB")]
	public bool get_IsDisableBomb() { }

	[Address(RVA = "0x1D4E4A0", Offset = "0x1D4D8A0", Length = "0xB")]
	[Token(Token = "0x60008A6")]
	public bool get_IsDisableCtrl() { }

	[Address(RVA = "0x1D4E4B0", Offset = "0x1D4D8B0", Length = "0xB")]
	[Token(Token = "0x60008A9")]
	public bool get_IsDisableExShot() { }

	[Address(RVA = "0x1D4E4C0", Offset = "0x1D4D8C0", Length = "0xB")]
	[Token(Token = "0x60008AA")]
	public bool get_IsDisableFire() { }

	[Address(RVA = "0x1D4E4D0", Offset = "0x1D4D8D0", Length = "0xE")]
	[Token(Token = "0x60008A7")]
	public bool get_IsDisablePause() { }

	[Address(RVA = "0x1D4E4E0", Offset = "0x1D4D8E0", Length = "0xE")]
	[Token(Token = "0x60008A8")]
	public bool get_IsDisableShot() { }

	[Address(RVA = "0x1D4E4F0", Offset = "0x1D4D8F0", Length = "0x26")]
	[Token(Token = "0x60008B2")]
	public bool get_IsItemTaken() { }

	[Address(RVA = "0x1D4E520", Offset = "0x1D4D920", Length = "0xB")]
	[Token(Token = "0x600089E")]
	private bool get_IsRecoverly() { }

	[Address(RVA = "0x1D4E530", Offset = "0x1D4D930", Length = "0x1D")]
	[Token(Token = "0x60008B3")]
	public bool get_IsRescueOK() { }

	[Address(RVA = "0x1D4E550", Offset = "0x1D4D950", Length = "0xE")]
	[Token(Token = "0x60008AF")]
	public bool get_IsRescueWait() { }

	[Address(RVA = "0x1D4E560", Offset = "0x1D4D960", Length = "0xE")]
	[Token(Token = "0x60008B1")]
	public bool get_IsRightMove() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[Token(Token = "0x6000899")]
	public bool get_IsTeamDouble() { }

	[Address(RVA = "0x1D4E580", Offset = "0x1D4D980", Length = "0xE")]
	[Token(Token = "0x60008B5")]
	public bool get_IsTeamMode() { }

	[Address(RVA = "0x1D4E590", Offset = "0x1D4D990", Length = "0xB")]
	[Token(Token = "0x600089F")]
	private bool get_IsTutorialLearn() { }

	[Address(RVA = "0x1D4E610", Offset = "0x1D4DA10", Length = "0x1D")]
	[Token(Token = "0x60008B4")]
	public bool get_IsUpdatePosition() { }

	[Address(RVA = "0x1D4E5A0", Offset = "0x1D4D9A0", Length = "0x6D")]
	[Token(Token = "0x60008A0")]
	public bool get_IsUpGradeModel() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000897")]
	public superFighterCollision get_playerBody() { }

	[Address(RVA = "0x1D4E630", Offset = "0x1D4DA30", Length = "0x7")]
	[Token(Token = "0x60008CA")]
	public int get_PlayerExShotCount() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x6000898")]
	public int get_PlayerNo() { }

	[Address(RVA = "0x1D4E640", Offset = "0x1D4DA40", Length = "0x7")]
	[Token(Token = "0x60008C9")]
	public int get_PlayerShotCount() { }

	[Address(RVA = "0x1D4E650", Offset = "0x1D4DA50", Length = "0x9")]
	[Token(Token = "0x60008BD")]
	public float get_RemainRescueTime() { }

	[Address(RVA = "0x1D4E660", Offset = "0x1D4DA60", Length = "0x2D")]
	[Token(Token = "0x60008BE")]
	public float get_RescueTimeRate() { }

	[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
	[Token(Token = "0x600089D")]
	public IWeapons[] get_WeaponLists() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[Token(Token = "0x600089B")]
	public Transform get_YawModel() { }

	[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
	[Token(Token = "0x600086B")]
	public int GetPadNo() { }

	[Address(RVA = "0x1D495C0", Offset = "0x1D489C0", Length = "0x20")]
	[Token(Token = "0x6000896")]
	private string GetRenderModelName() { }

	[Address(RVA = "0x1D495F0", Offset = "0x1D489F0", Length = "0xA")]
	[Token(Token = "0x60008A5")]
	public bool HasAttribute(PFlag tflag) { }

	[Address(RVA = "0x1D49600", Offset = "0x1D48A00", Length = "0x7C2")]
	[Token(Token = "0x6000862")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D49DD0", Offset = "0x1D491D0", Length = "0x5B")]
	[Token(Token = "0x600087F")]
	public bool IsAwakenLv1() { }

	[Address(RVA = "0x1D49E30", Offset = "0x1D49230", Length = "0x5B")]
	[Token(Token = "0x6000880")]
	public bool IsAwakenLv2() { }

	[Address(RVA = "0x1D49E90", Offset = "0x1D49290", Length = "0x101")]
	[Token(Token = "0x6000879")]
	public bool IsDisableControll() { }

	[Address(RVA = "0x1D49FA0", Offset = "0x1D493A0", Length = "0x8")]
	[Token(Token = "0x60008C3")]
	public bool IsExboost() { }

	[Address(RVA = "0x1D49FB0", Offset = "0x1D493B0", Length = "0x1E")]
	[Token(Token = "0x600087E")]
	public bool IsFullBoost() { }

	[Address(RVA = "0x1D49FD0", Offset = "0x1D493D0", Length = "0x7E")]
	[Token(Token = "0x600088F")]
	private bool IsInputOn(UIGamePad pad, Buttons buttons, Buttons keys) { }

	[Address(RVA = "0x1D4A050", Offset = "0x1D49450", Length = "0x7E")]
	[Token(Token = "0x6000890")]
	private bool IsInputPresent(UIGamePad pad, Buttons buttons, Buttons keys) { }

	[Address(RVA = "0x1D4A0D0", Offset = "0x1D494D0", Length = "0x7D")]
	[Token(Token = "0x600087C")]
	public bool IsPipiruCleanup() { }

	[Address(RVA = "0x1D4A150", Offset = "0x1D49550", Length = "0x7E")]
	[Token(Token = "0x600087B")]
	public bool IsPlayerInvincible() { }

	[Address(RVA = "0x1D4A1D0", Offset = "0x1D495D0", Length = "0x456")]
	[Token(Token = "0x6000869")]
	public void LocalLateUpdater(float dt) { }

	[Address(RVA = "0x1D4A630", Offset = "0x1D49A30", Length = "0x21")]
	[Token(Token = "0x6000872")]
	public void PipilCountUp(float n) { }

	[Address(RVA = "0x1D4A660", Offset = "0x1D49A60", Length = "0x5C")]
	[Token(Token = "0x60008C4")]
	public void PlayCaptureSE() { }

	[Address(RVA = "0x1D4A6C0", Offset = "0x1D49AC0", Length = "0xC3")]
	[AsyncStateMachine(typeof(<PlayerEntryAsync>d__181))]
	[Token(Token = "0x60008B8")]
	public UniTask PlayerEntryAsync() { }

	[Address(RVA = "0x1D4A790", Offset = "0x1D49B90", Length = "0x87")]
	[AsyncStateMachine(typeof(<PlayerExitAsync>d__185))]
	[Token(Token = "0x60008BA")]
	public UniTaskVoid PlayerExitAsync() { }

	[Address(RVA = "0x1D4A820", Offset = "0x1D49C20", Length = "0x1CF")]
	[Token(Token = "0x60008B9")]
	public void PlayerTutorialEntry() { }

	[Address(RVA = "0x1D4A9F0", Offset = "0x1D49DF0", Length = "0xCE")]
	[Token(Token = "0x6000874")]
	public void PowerDownWeapon() { }

	[Address(RVA = "0x1D4AAC0", Offset = "0x1D49EC0", Length = "0x14F")]
	[Token(Token = "0x6000873")]
	public int PowerUpWeapon() { }

	[Address(RVA = "0x1D4AC60", Offset = "0x1D4A060", Length = "0x2FA")]
	[Token(Token = "0x6000866")]
	public virtual void RemoveInGame() { }

	[Address(RVA = "0x1D4AF60", Offset = "0x1D4A360", Length = "0x9")]
	[Token(Token = "0x60008A4")]
	public void ResetAttribute(PFlag tflag) { }

	[Address(RVA = "0x1D4AF70", Offset = "0x1D4A370", Length = "0x139")]
	[Token(Token = "0x6000876")]
	public void ResetBullets() { }

	[Address(RVA = "0x1D4AC10", Offset = "0x1D4A010", Length = "0x49")]
	[Token(Token = "0x6000875")]
	public void ReStartPlayer() { }

	[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60008A2")]
	private void set_CustomKeys(PadAssign value) { }

	[Address(RVA = "0x1D4B0B0", Offset = "0x1D4A4B0", Length = "0x7")]
	[Token(Token = "0x60008A3")]
	public void SetAttribute(PFlag tflag) { }

	[Address(RVA = "0x1D4B0C0", Offset = "0x1D4A4C0", Length = "0x11")]
	[Token(Token = "0x600086C")]
	public void SetClampZ(float zmin, float zmax) { }

	[Address(RVA = "0x1D4B0E0", Offset = "0x1D4A4E0", Length = "0x201")]
	[Token(Token = "0x600088C")]
	public void SetCustomButtons(PadAssign pa, bool keyboardAssign) { }

	[Address(RVA = "0x1D4B2F0", Offset = "0x1D4A6F0", Length = "0x7")]
	[Token(Token = "0x60008C5")]
	private void SetExboostFlag(bool tflag) { }

	[Address(RVA = "0x1D4B300", Offset = "0x1D4A700", Length = "0x13A")]
	[Token(Token = "0x600088D")]
	public void SetGameRoot(Transform gameRoot) { }

	[Address(RVA = "0x1D4B440", Offset = "0x1D4A840", Length = "0x1AD")]
	[Token(Token = "0x6000888")]
	public void SetOutPosition() { }

	[Address(RVA = "0x1D4B5F0", Offset = "0x1D4A9F0", Length = "0xE")]
	[Token(Token = "0x600086A")]
	public void SetPadNo(int n, bool isRstick = false) { }

	[Address(RVA = "0x1D4B600", Offset = "0x1D4AA00", Length = "0x10")]
	[Token(Token = "0x600087D")]
	public void SetPlayerFullBoost(bool isFullBoost) { }

	[Address(RVA = "0x1D4B610", Offset = "0x1D4AA10", Length = "0x10")]
	[Token(Token = "0x600087A")]
	public void SetPlayerInvincible(bool isInvincible) { }

	[Address(RVA = "0x1D4B620", Offset = "0x1D4AA20", Length = "0x5D")]
	[Token(Token = "0x600086D")]
	public void SetStartPosition(Vector3 tpos, Vector3 hpos) { }

	[Address(RVA = "0x1D4B680", Offset = "0x1D4AA80", Length = "0x7")]
	[Token(Token = "0x600088B")]
	public void SetTutorial(TutorailType ttype) { }

	[Address(RVA = "0x1D4B7F0", Offset = "0x1D4ABF0", Length = "0x93")]
	[IteratorStateMachine(typeof(<SetupOwner>d__1))]
	[Token(Token = "0x6000863")]
	public IEnumerator SetupOwner(int pno, PlayerInformation pinfo) { }

	[Address(RVA = "0x1D4B690", Offset = "0x1D4AA90", Length = "0x15E")]
	[Token(Token = "0x600088E")]
	public void SetVibration(float lowpow, float highpow, float nsecond) { }

	[Address(RVA = "0x1D4B890", Offset = "0x1D4AC90", Length = "0x1BE")]
	[Token(Token = "0x6000886")]
	private void StartDeadEffect(int hcode) { }

	[Address(RVA = "0x1D4BA50", Offset = "0x1D4AE50", Length = "0x21")]
	[Token(Token = "0x600088A")]
	public void StartEffect(EffectKind tkind) { }

	[Address(RVA = "0x1D4BA80", Offset = "0x1D4AE80", Length = "0x47")]
	[Token(Token = "0x6000889")]
	public void StartOneEffect(EffectKind tkind) { }

	[Address(RVA = "0x1D4BAD0", Offset = "0x1D4AED0", Length = "0x21")]
	[Token(Token = "0x6000870")]
	public bool StockCountUp(int n) { }

	[Address(RVA = "0x1D4BB00", Offset = "0x1D4AF00", Length = "0x15E")]
	[Token(Token = "0x6000864")]
	public virtual void Terminate() { }

	[Address(RVA = "0x1D4BC60", Offset = "0x1D4B060", Length = "0x8")]
	[Token(Token = "0x6000868")]
	public void UpdateControll(float dt) { }

	[Address(RVA = "0x1D4BC70", Offset = "0x1D4B070", Length = "0x9B")]
	[Token(Token = "0x6000867")]
	public void UpdateParameters() { }

}

