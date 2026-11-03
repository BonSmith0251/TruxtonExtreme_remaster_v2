namespace InGame.Kernel.Enemy;

[Token(Token = "0x200020F")]
public class Ene_St01 : PawnEnemy
{
	[Token(Token = "0x2000210")]
	private enum ActionState : int
	{
		Start = 0,
		Blow = 1,
		Move = 2,
		Wait = 3,
		Leave = 4,
		Exit = 5,
	}

	[Token(Token = "0x4001297")]
	private static readonly float _InvincibleTime; //Field offset: 0x0
	[Token(Token = "0x4001298")]
	private static readonly float _StartSpeed; //Field offset: 0x4
	[Token(Token = "0x4001299")]
	private static readonly float _LifeTime; //Field offset: 0x8
	[Token(Token = "0x400129A")]
	private static readonly float _MoveSpeed; //Field offset: 0xC
	[Token(Token = "0x400129B")]
	private static readonly float _DeceleSpeed; //Field offset: 0x10
	[Token(Token = "0x400129C")]
	private static readonly float _AcceleSpeed; //Field offset: 0x14
	[Token(Token = "0x400129D")]
	private static readonly float _DecelerationDistance; //Field offset: 0x18
	[Token(Token = "0x400129E")]
	private static readonly float _KeepDistance; //Field offset: 0x1C
	[Token(Token = "0x400129F")]
	private static readonly float _WaitTime; //Field offset: 0x20
	[Token(Token = "0x40012A0")]
	private static readonly string _BulletName; //Field offset: 0x28
	[Token(Token = "0x40012A1")]
	private static readonly float _ShotInterval; //Field offset: 0x30
	[Token(Token = "0x40012A2")]
	private static readonly Quaternion StartAngle; //Field offset: 0x34
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40012A3")]
	public Transform _Muzzle; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40012A4")]
	private ActionState _state; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x40012A5")]
	private float _moveSpeed; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40012A6")]
	private float _nohitTime; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x40012A7")]
	private float _lifeTime; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40012A8")]
	private float _waitTime; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x40012A9")]
	private int _targetPlayerIndex; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40012AA")]
	private Vector3 _moveVector; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x40012AB")]
	private Quaternion _selfAngle; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x40012AC")]
	private Vector3 _wayPoint; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x40012AD")]
	private List<BulletTemplate> _bulletTemplates; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x40012AE")]
	private float _shotTime; //Field offset: 0x200

	[Address(RVA = "0x1D085B0", Offset = "0x1D079B0", Length = "0x1CD")]
	[Token(Token = "0x6000F8B")]
	private static Ene_St01() { }

	[Address(RVA = "0x1D08780", Offset = "0x1D07B80", Length = "0x106")]
	[Token(Token = "0x6000F8A")]
	public Ene_St01() { }

	[Address(RVA = "0x1D066C0", Offset = "0x1D05AC0", Length = "0x19A0")]
	[Token(Token = "0x6000F89")]
	private void ActionMove(float dt) { }

	[Address(RVA = "0x1D08080", Offset = "0x1D07480", Length = "0xD9")]
	[Token(Token = "0x6000F87")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D08160", Offset = "0x1D07560", Length = "0x2A1")]
	[Token(Token = "0x6000F85")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1D08410", Offset = "0x1D07810", Length = "0x31")]
	[Token(Token = "0x6000F88")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D08450", Offset = "0x1D07850", Length = "0x159")]
	[Token(Token = "0x6000F86")]
	public virtual void ReStart(bool withPlay) { }

}

