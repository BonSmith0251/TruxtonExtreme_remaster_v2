namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001FA")]
public class Ene_Mn01c : PawnEnemy
{
	[Token(Token = "0x20001FB")]
	private enum STATE : int
	{
		INIT = 0,
		FREE = 1,
		SHIELD = 2,
		AWAY = 3,
		GATHER = 4,
		FALL = 5,
	}

	[Token(Token = "0x40011C9")]
	private static readonly float _DecelerationSpeed; //Field offset: 0x0
	[Token(Token = "0x40011CA")]
	private static readonly float _AccelerationSpeed; //Field offset: 0x4
	[Token(Token = "0x40011CB")]
	private static readonly float _SeparateSpeed; //Field offset: 0x8
	[Token(Token = "0x40011CC")]
	private static readonly float _MassMin; //Field offset: 0xC
	[Token(Token = "0x40011CD")]
	private static readonly float _MassMax; //Field offset: 0x10
	[Token(Token = "0x40011CE")]
	private static readonly float _ParentGapSize; //Field offset: 0x14
	[Token(Token = "0x40011CF")]
	private static readonly float _AppearTime; //Field offset: 0x18
	[Token(Token = "0x40011D0")]
	private static readonly float _RotateIn; //Field offset: 0x1C
	[Token(Token = "0x40011D1")]
	private static readonly float _RotateOut; //Field offset: 0x20
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40011D2")]
	private Transform _model; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x40011D3")]
	private ID _attachSE; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x40011D4")]
	private STATE _state; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40011D5")]
	private int _step; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x40011D6")]
	private float _stepWait; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40011D7")]
	private float _spinRate; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x40011D8")]
	private float _sepaTimer; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40011D9")]
	private bool _sepaDone; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D1")]
	[Token(Token = "0x40011DA")]
	private bool _isRanged; //Field offset: 0x1D1
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40011DB")]
	private Action<PawnEnemy> _toParentCallback; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40011DC")]
	private Transform _parentTransform; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40011DD")]
	private Vector3 _offsetFormation; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x40011DE")]
	private Vector3 _localPosition; //Field offset: 0x1F4
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x40011DF")]
	private Vector3 _vel; //Field offset: 0x200
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x40011E0")]
	private float _speed; //Field offset: 0x20C
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40011E1")]
	private float _spinSpeed; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x40011E2")]
	private float _spinAngle; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40011E3")]
	private float _mass; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x40011E4")]
	private Quaternion _localRotate; //Field offset: 0x21C
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x40011E5")]
	private Quaternion _spin; //Field offset: 0x22C

	[Address(RVA = "0x1CFAC50", Offset = "0x1CFA050", Length = "0x315")]
	[Token(Token = "0x6000F1D")]
	private bool _awayModeState(float dt) { }

	[Address(RVA = "0x1CFB130", Offset = "0x1CFA530", Length = "0x338")]
	[Token(Token = "0x6000F1C")]
	private bool _gatherModeState(float dt) { }

	[Address(RVA = "0x1CFB470", Offset = "0x1CFA870", Length = "0xB14")]
	[Token(Token = "0x6000F1B")]
	private bool _shieldModeState(float dt) { }

	[Address(RVA = "0x1CFAF70", Offset = "0x1CFA370", Length = "0xE1")]
	[Token(Token = "0x6000F21")]
	private static Ene_Mn01c() { }

	[Address(RVA = "0x1CFB060", Offset = "0x1CFA460", Length = "0xCF")]
	[Token(Token = "0x6000F20")]
	public Ene_Mn01c() { }

	[Address(RVA = "0x1CFA510", Offset = "0x1CF9910", Length = "0x21")]
	[Token(Token = "0x6000F1F")]
	public virtual void CommonEvent(int num) { }

	[Address(RVA = "0x1CFA540", Offset = "0x1CF9940", Length = "0x20")]
	[Token(Token = "0x6000F16")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1CFA560", Offset = "0x1CF9960", Length = "0x38")]
	[Token(Token = "0x6000F19")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1CFA6B0", Offset = "0x1CF9AB0", Length = "0x22C")]
	[Token(Token = "0x6000F17")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1CFA8E0", Offset = "0x1CF9CE0", Length = "0x9D")]
	[Token(Token = "0x6000F1A")]
	public void Setup(Transform parent, Vector3 offsetFormation, Vector3 startPosition) { }

	[Address(RVA = "0x1CFA980", Offset = "0x1CF9D80", Length = "0x35")]
	[Token(Token = "0x6000F18")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1CFA9C0", Offset = "0x1CF9DC0", Length = "0x287")]
	[Token(Token = "0x6000F1E")]
	private void ToSeparate() { }

}

