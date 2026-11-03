namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001EF")]
public class Ene_Mk01 : RookEnemy
{
	[Token(Token = "0x20001F0")]
	private enum MoveState : int
	{
		Entering = 0,
		Forward = 1,
		Wait = 2,
		Leaving = 3,
	}

	[Token(Token = "0x4001114")]
	private static readonly float _MoveInterval; //Field offset: 0x0
	[Token(Token = "0x4001119")]
	private const string BulletName = "mk01_fire1"; //Field offset: 0x0
	[Token(Token = "0x400111B")]
	private const float FireTime = 2; //Field offset: 0x0
	[Token(Token = "0x4001115")]
	private static readonly float _TargetTurnTime; //Field offset: 0x4
	[Token(Token = "0x4001116")]
	private static readonly List<String> _routeNamesA; //Field offset: 0x8
	[Token(Token = "0x4001117")]
	private static readonly List<String> _routeNamesB; //Field offset: 0x10
	[Token(Token = "0x4001118")]
	private static readonly List<String>[] _routeNames; //Field offset: 0x18
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400111A")]
	private BulletTemplate _bt; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400111C")]
	private float _fireTimer; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[SerializeField]
	[Token(Token = "0x400111D")]
	private Transform _muzzle; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400111E")]
	private int _targetPlayer; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x400111F")]
	private MoveState _moveState; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4001120")]
	private float _initialSpeed; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4001121")]
	private float _moveSpeed; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4001122")]
	private float _waitTime; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4001123")]
	private float _rotateTime; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4001124")]
	private float _rotateAngle; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4001125")]
	private List<SplineRouteData> _routeList; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4001126")]
	private IEnumerator<SplineRouteData> _routeData; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4001127")]
	private Vector3 _spawnPosition; //Field offset: 0x240
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4001128")]
	private float _routeOffset; //Field offset: 0x24C
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4001129")]
	private Vector3 _splineStartPosition; //Field offset: 0x250
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400112A")]
	private RouteLutAsset _routeLutAsset; //Field offset: 0x260

	[Address(RVA = "0x1DC9940", Offset = "0x1DC8D40", Length = "0x21F")]
	[Token(Token = "0x6000ED8")]
	private void _childRepulsion() { }

	[Address(RVA = "0x1DC9C00", Offset = "0x1DC9000", Length = "0xE8")]
	[Token(Token = "0x6000EDC")]
	private void _fire(float dt) { }

	[Address(RVA = "0x1DC9CF0", Offset = "0x1DC90F0", Length = "0x683")]
	[Token(Token = "0x6000ED4")]
	private void _move(float deltaTime) { }

	[Address(RVA = "0x1DC8F30", Offset = "0x1DC8330", Length = "0xA00")]
	[Token(Token = "0x6000EDE")]
	private static Ene_Mk01() { }

	[Address(RVA = "0x1DC9B60", Offset = "0x1DC8F60", Length = "0xA0")]
	[Token(Token = "0x6000EDD")]
	public Ene_Mk01() { }

	[Address(RVA = "0x1DC8180", Offset = "0x1DC7580", Length = "0xB9")]
	[Token(Token = "0x6000EDB")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1DC8240", Offset = "0x1DC7640", Length = "0x53")]
	[Token(Token = "0x6000EDA")]
	public Vector3 GetLocalPosition(Vector3 wpos) { }

	[Address(RVA = "0x1DC82A0", Offset = "0x1DC76A0", Length = "0xF4")]
	[Token(Token = "0x6000ED3")]
	public virtual List<String> GetRouteNames() { }

	[Address(RVA = "0x1DC83A0", Offset = "0x1DC77A0", Length = "0x5D")]
	[Token(Token = "0x6000ED9")]
	public virtual void HitBlink(attackType atype) { }

	[Address(RVA = "0x1DC8400", Offset = "0x1DC7800", Length = "0x3B")]
	[Token(Token = "0x6000ED2")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DC8440", Offset = "0x1DC7840", Length = "0x4D1")]
	[Token(Token = "0x6000ED1")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DC8920", Offset = "0x1DC7D20", Length = "0x27E")]
	[Token(Token = "0x6000ED5")]
	private void RotatePlayer(InGameManager gm, float deltaTime) { }

	[Address(RVA = "0x1DC8BA0", Offset = "0x1DC7FA0", Length = "0x201")]
	[Token(Token = "0x6000ED7")]
	private void SetChildTarget(int playerIndex, bool immediate) { }

	[Address(RVA = "0x1DC8DB0", Offset = "0x1DC81B0", Length = "0x17C")]
	[Token(Token = "0x6000ED6")]
	private void SetTargetPlayer(InGameManager gameManager, bool immediate) { }

}

