namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001E9")]
public class Ene_Mg01 : RookEnemy
{
	[Token(Token = "0x20001EA")]
	private enum FireMode : int
	{
		None = 0,
		Move = 1,
		Brake = 2,
		Homing = 3,
		Shot = 4,
		Turn = 5,
		Return = 6,
	}

	[Token(Token = "0x40010E9")]
	private static readonly float _FireMoveTime; //Field offset: 0x0
	[Token(Token = "0x40010EA")]
	private static readonly float _FireBrakeTime; //Field offset: 0x4
	[Token(Token = "0x40010EB")]
	private static readonly float _FireHomingTime; //Field offset: 0x8
	[Token(Token = "0x40010EC")]
	private static readonly float _FireShotTime; //Field offset: 0xC
	[Token(Token = "0x40010ED")]
	private static readonly float _FireTurnTime; //Field offset: 0x10
	[Token(Token = "0x40010EE")]
	private static readonly float _FireReturnTime; //Field offset: 0x14
	[Token(Token = "0x40010EF")]
	private static readonly float _FireRapidTime; //Field offset: 0x18
	[Token(Token = "0x40010F0")]
	private static readonly string _BulletName; //Field offset: 0x20
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	[Token(Token = "0x40010F1")]
	private Transform _Muzzle; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x40010F2")]
	private FireMode _fireMode; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x40010F3")]
	private float _timer; //Field offset: 0x204
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x40010F4")]
	private float _fireTimer; //Field offset: 0x208
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x40010F5")]
	private float _baseSpeed; //Field offset: 0x20C
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40010F6")]
	private int _targetPlayer; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x40010F7")]
	private Quaternion _baseRotate; //Field offset: 0x214
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x40010F8")]
	private Quaternion _targetRotate; //Field offset: 0x224
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x40010F9")]
	private List<BulletTemplate> _bulletTemplates; //Field offset: 0x238

	[Address(RVA = "0x1DC69B0", Offset = "0x1DC5DB0", Length = "0xF9")]
	[Token(Token = "0x6000EB9")]
	private static Ene_Mg01() { }

	[Address(RVA = "0x1DC6AB0", Offset = "0x1DC5EB0", Length = "0x8A")]
	[Token(Token = "0x6000EB8")]
	public Ene_Mg01() { }

	[Address(RVA = "0x1DC5D70", Offset = "0x1DC5170", Length = "0x90C")]
	[Token(Token = "0x6000EB6")]
	private void CustomMove() { }

	[Address(RVA = "0x1DC66A0", Offset = "0x1DC5AA0", Length = "0xD9")]
	[Token(Token = "0x6000EB7")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1DC6780", Offset = "0x1DC5B80", Length = "0x2F")]
	[Token(Token = "0x6000EB5")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DC67B0", Offset = "0x1DC5BB0", Length = "0x1FD")]
	[Token(Token = "0x6000EB4")]
	public virtual void ReStart(bool withPlay) { }

}

