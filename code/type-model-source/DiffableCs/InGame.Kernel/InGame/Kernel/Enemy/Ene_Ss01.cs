namespace InGame.Kernel.Enemy;

[Token(Token = "0x200020D")]
public class Ene_Ss01 : RookEnemy
{
	[Token(Token = "0x200020E")]
	private enum ActionState : int
	{
		Starting = 0,
		Forward = 1,
		Rolling = 2,
		StopFire = 3,
		Turn = 4,
		Back = 5,
		Done = 6,
	}

	[Token(Token = "0x400127E")]
	private static readonly float maxDistance; //Field offset: 0x0
	[Token(Token = "0x400127F")]
	private static readonly float minDistance; //Field offset: 0x4
	[Token(Token = "0x4001280")]
	private static readonly float rollSpeed; //Field offset: 0x8
	[Token(Token = "0x4001281")]
	private static readonly float rollSeconds; //Field offset: 0xC
	[Token(Token = "0x4001282")]
	private static readonly float stopSeconds; //Field offset: 0x10
	[Token(Token = "0x4001283")]
	private static readonly float turnSeconds; //Field offset: 0x14
	[Token(Token = "0x4001284")]
	private static readonly Quaternion turnRotate; //Field offset: 0x18
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	[Token(Token = "0x4001285")]
	private Transform _muzzle; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[SerializeField]
	[Token(Token = "0x4001286")]
	private string _bulletName; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4001287")]
	private BulletTemplate _bt; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4001288")]
	private float _offsetAngle; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x4001289")]
	private float _rotateAngle; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400128A")]
	private float _length; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x400128B")]
	private float _rollSeconds; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400128C")]
	private int _targetPlayer; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x400128D")]
	private bool _isFired; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400128E")]
	private ActionState _actstate; //Field offset: 0x228

	[Token(Token = "0x17000211")]
	private float currentAngle
	{
		[Address(RVA = "0x1D066A0", Offset = "0x1D05AA0", Length = "0x11")]
		[Token(Token = "0x6000F82")]
		private get { } //Length: 17
	}

	[Address(RVA = "0x1D06570", Offset = "0x1D05970", Length = "0xDA")]
	[Token(Token = "0x6000F84")]
	private static Ene_Ss01() { }

	[Address(RVA = "0x1D06650", Offset = "0x1D05A50", Length = "0x46")]
	[Token(Token = "0x6000F83")]
	public Ene_Ss01() { }

	[Address(RVA = "0x1D05840", Offset = "0x1D04C40", Length = "0x6D4")]
	[Token(Token = "0x6000F7E")]
	private void ActionMove(float dt) { }

	[Address(RVA = "0x1D066A0", Offset = "0x1D05AA0", Length = "0x11")]
	[Token(Token = "0x6000F82")]
	private float get_currentAngle() { }

	[Address(RVA = "0x1D05F30", Offset = "0x1D05330", Length = "0xBB")]
	[Token(Token = "0x6000F81")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D05FF0", Offset = "0x1D053F0", Length = "0xB1")]
	[Token(Token = "0x6000F7B")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1D060B0", Offset = "0x1D054B0", Length = "0x31")]
	[Token(Token = "0x6000F7D")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D060F0", Offset = "0x1D054F0", Length = "0x454")]
	[Token(Token = "0x6000F7C")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D06550", Offset = "0x1D05950", Length = "0x9")]
	[Token(Token = "0x6000F7F")]
	private void SetOffsetAngle(float rangle) { }

	[Address(RVA = "0x1D06560", Offset = "0x1D05960", Length = "0x7")]
	[Token(Token = "0x6000F80")]
	private void SetTargetPlayer(int pno) { }

}

