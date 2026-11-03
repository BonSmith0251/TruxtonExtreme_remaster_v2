namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001F5")]
public class Ene_Mm01 : PawnEnemy
{
	[Token(Token = "0x20001F6")]
	private enum BehaviorType : int
	{
		Horizon = 0,
		Vertical = 1,
		Up = 2,
		Down = 3,
		Left = 4,
		Right = 5,
	}

	[Token(Token = "0x20001F7")]
	private enum STATE : int
	{
		INIT = 0,
		HORIZON_0 = 1,
		HORIZON_1 = 2,
		HORIZON_2 = 3,
		HORIZON_3 = 4,
		HORIZON_4 = 5,
		HORIZON_5 = 6,
		HORIZON_6 = 7,
		VERTICAL_0 = 8,
		VERTICAL_1 = 9,
		VERTICAL_2 = 10,
		VERTICAL_3 = 11,
		VERTICAL_4 = 12,
		VERTICAL_5 = 13,
		VERTICAL_6 = 14,
		UP = 15,
		DOWN = 16,
		LEFT = 17,
		RIGHT = 18,
		AWAY = 19,
	}

	[Token(Token = "0x4001158")]
	private static readonly List<Vector3> DefaultPosition; //Field offset: 0x0
	[Token(Token = "0x400116A")]
	private static readonly int laserPointMax; //Field offset: 0x8
	[Token(Token = "0x400116C")]
	private static readonly Quaternion rotateV; //Field offset: 0xC
	[Token(Token = "0x4001184")]
	private static readonly float InTime; //Field offset: 0x1C
	[Token(Token = "0x4001185")]
	private static readonly float InWait; //Field offset: 0x20
	[Token(Token = "0x4001186")]
	private static readonly float SafeTime; //Field offset: 0x24
	[Token(Token = "0x4001187")]
	private static readonly float CloseSECall; //Field offset: 0x28
	[Token(Token = "0x4001188")]
	private static readonly float CloseTime; //Field offset: 0x2C
	[Token(Token = "0x4001189")]
	private static readonly float WaitTime; //Field offset: 0x30
	[Token(Token = "0x400118A")]
	private static readonly float OutTime; //Field offset: 0x34
	[Token(Token = "0x400118B")]
	private static readonly float PostWaitTime; //Field offset: 0x38
	[Token(Token = "0x400118C")]
	private static readonly float AwaySpeed; //Field offset: 0x3C
	[Token(Token = "0x400118D")]
	private static readonly float InSpinCount; //Field offset: 0x40
	[Token(Token = "0x400118E")]
	private static readonly float OutSpinCount; //Field offset: 0x44
	[Token(Token = "0x400118F")]
	private static readonly float SoloAway; //Field offset: 0x48
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4001159")]
	private STATE _state; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x400115A")]
	private BehaviorType _behaviorType; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400115B")]
	private int _seID; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x400115C")]
	private bool _siblingDead; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1BD")]
	[Token(Token = "0x400115D")]
	private bool _dieEntry; //Field offset: 0x1BD
	[FieldOffset(Offset = "0x1BE")]
	[Token(Token = "0x400115E")]
	private bool _isClosed; //Field offset: 0x1BE
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400115F")]
	private float _passedTime; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4001160")]
	private Vector3 _tpos; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4001161")]
	private Vector3 _orgPos; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4001162")]
	private float _velZ; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4001163")]
	private Vector3 _leftRot; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4001164")]
	private Vector3 _rightRot; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4001165")]
	private bool _laserEnable; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x1F9")]
	[Token(Token = "0x4001166")]
	private bool _laserSubject; //Field offset: 0x1F9
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4001167")]
	private Vector2[] _laser1Points; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4001168")]
	private Vector2[] _laser2Points; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4001169")]
	private Material[] _mats; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400116B")]
	private Vector3[] _pts; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400116D")]
	private Vector3 _startOffset; //Field offset: 0x220
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x400116E")]
	private Vector3 _moveDirection; //Field offset: 0x22C
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x400116F")]
	private float _laserLength; //Field offset: 0x238
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4001170")]
	private float _entryWait; //Field offset: 0x23C
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	[Space(10)]
	[Token(Token = "0x4001171")]
	private Transform _left; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[SerializeField]
	[Token(Token = "0x4001172")]
	private Transform _right; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[SerializeField]
	[Token(Token = "0x4001173")]
	private Transform[] _leftMzls; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[SerializeField]
	[Token(Token = "0x4001174")]
	private Transform[] _rightMzls; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[SerializeField]
	[Token(Token = "0x4001175")]
	private EnemyCollisionModel _laserCollision1; //Field offset: 0x260
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	[Token(Token = "0x4001176")]
	private EnemyCollisionModel _laserCollision2; //Field offset: 0x268
	[FieldOffset(Offset = "0x270")]
	[SerializeField]
	[Token(Token = "0x4001177")]
	private LineRenderer _laser1; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	[Token(Token = "0x4001178")]
	private LineRenderer _laser2; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x4001179")]
	private ParticleSystem[] _muzzles; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x400117A")]
	private ShaderFunction_UVAnime _matAnime1; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x400117B")]
	private ShaderFunction_UVAnime _matAnime2; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400117C")]
	private float _inWidthH; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Header("H型停止位置")]
	[SerializeField]
	[Space(1)]
	[Token(Token = "0x400117D")]
	private float _outWidthH; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x400117E")]
	private float _inWidthV; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Header("V型停止位置")]
	[SerializeField]
	[Space(1)]
	[Token(Token = "0x400117F")]
	private float _outWidthV; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Header("V型中央位置補正")]
	[SerializeField]
	[Space(1)]
	[Token(Token = "0x4001180")]
	private float _offsetZ; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Header("合体の動き曲線")]
	[SerializeField]
	[Space(1)]
	[Token(Token = "0x4001181")]
	private AnimationCurve _curveIn; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	[Token(Token = "0x4001182")]
	private AnimationCurve _curveOut; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Header("バーナーエフェクト")]
	[SerializeField]
	[Space(1)]
	[Token(Token = "0x4001183")]
	private ParticleSystem[] _burner; //Field offset: 0x2C0

	[Address(RVA = "0x1DCF650", Offset = "0x1DCEA50", Length = "0xD7")]
	[Token(Token = "0x6000F04")]
	private void _awayMove(float delta) { }

	[Address(RVA = "0x1DCF730", Offset = "0x1DCEB30", Length = "0xF0")]
	[Token(Token = "0x6000F02")]
	private void _calcPos(float pt, float max, float rate, AnimationCurve cv, bool flip = false) { }

	[Address(RVA = "0x1DCFD10", Offset = "0x1DCF110", Length = "0xC0")]
	[Token(Token = "0x6000EFE")]
	private void _checkJointSE(float tsec) { }

	[Address(RVA = "0x1DCFFA0", Offset = "0x1DCF3A0", Length = "0x80")]
	[Token(Token = "0x6000EFF")]
	private void _laserNohitSubject(bool sw) { }

	[Address(RVA = "0x1DD0030", Offset = "0x1DCF430", Length = "0xD5")]
	[Token(Token = "0x6000F03")]
	private void _lerpPos(float pt, float max, float st, float ed) { }

	[Address(RVA = "0x1DD0110", Offset = "0x1DCF510", Length = "0x756")]
	[Token(Token = "0x6000F01")]
	private void _setLaserCollision() { }

	[Address(RVA = "0x1DCDE30", Offset = "0x1DCD230", Length = "0x17B4")]
	[Token(Token = "0x6000EFC")]
	private void _StateExec(float dt) { }

	[Address(RVA = "0x1DD0870", Offset = "0x1DCFC70", Length = "0xB4")]
	[Token(Token = "0x6000EFD")]
	private void _stopSE() { }

	[Address(RVA = "0x1DCF830", Offset = "0x1DCEC30", Length = "0x4DF")]
	[Token(Token = "0x6000F06")]
	private static Ene_Mm01() { }

	[Address(RVA = "0x1DCFDD0", Offset = "0x1DCF1D0", Length = "0x1C6")]
	[Token(Token = "0x6000F05")]
	public Ene_Mm01() { }

	[Address(RVA = "0x1DCDBF0", Offset = "0x1DCCFF0", Length = "0x236")]
	[CompilerGenerated]
	[Token(Token = "0x6000F09")]
	private void <_setLaserCollision>g___setArray|16_0(Vector3 _p1, Vector3 _p2) { }

	[Address(RVA = "0x1DCD830", Offset = "0x1DCCC30", Length = "0x2A3")]
	[CompilerGenerated]
	[Token(Token = "0x6000F07")]
	private void <_StateExec>g__SetupCombinedBehavior|11_0(STATE state, Vector3 moveDirection, Quaternion rotation) { }

	[Address(RVA = "0x1DCDAE0", Offset = "0x1DCCEE0", Length = "0x10D")]
	[CompilerGenerated]
	[Token(Token = "0x6000F08")]
	private void <_StateExec>g__SetupHV|11_1() { }

	[Address(RVA = "0x1DCCAD0", Offset = "0x1DCBED0", Length = "0x2C")]
	[Token(Token = "0x6000EF7")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1DCCB00", Offset = "0x1DCBF00", Length = "0x82")]
	[Token(Token = "0x6000EF9")]
	public virtual Vector3 GetHormingTarget(int nindex) { }

	[Address(RVA = "0x1DCCB90", Offset = "0x1DCBF90", Length = "0x30A")]
	[Token(Token = "0x6000EF4")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DCCEA0", Offset = "0x1DCC2A0", Length = "0x60")]
	[Token(Token = "0x6000EFA")]
	public virtual bool IsAliveDamaged(float tdamage) { }

	[Address(RVA = "0x1DCCF10", Offset = "0x1DCC310", Length = "0x8A")]
	[Token(Token = "0x6000EFB")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DCCFA0", Offset = "0x1DCC3A0", Length = "0x17B")]
	[Token(Token = "0x6000EF8")]
	public virtual void OnPartsBreak(int parts) { }

	[Address(RVA = "0x1DCD120", Offset = "0x1DCC520", Length = "0x446")]
	[Token(Token = "0x6000EF5")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DCD570", Offset = "0x1DCC970", Length = "0x1A4")]
	[Token(Token = "0x6000F00")]
	private void SetLaserEffectEnable(bool isEnable) { }

	[Address(RVA = "0x1DCD720", Offset = "0x1DCCB20", Length = "0x10F")]
	[Token(Token = "0x6000EF6")]
	public virtual void Terminate() { }

}

