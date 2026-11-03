namespace InGame.Kernel.Player;

[Token(Token = "0x200010C")]
public class PlayerBallCollisionModel : HybridCollisionModel
{
	[Token(Token = "0x4000758")]
	private static readonly Vector3 lockOnPosition; //Field offset: 0x0
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000756")]
	private int _indexNumber; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000757")]
	private bool _isEnable; //Field offset: 0x74

	[Token(Token = "0x17000181")]
	public int IndexNumber
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x600085F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1D48780", Offset = "0x1D47B80", Length = "0x4D")]
	[Token(Token = "0x6000861")]
	private static PlayerBallCollisionModel() { }

	[Address(RVA = "0x1D487D0", Offset = "0x1D47BD0", Length = "0x49")]
	[Token(Token = "0x6000860")]
	public PlayerBallCollisionModel() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600085E")]
	public virtual bool AddDamage(float t, int pno, bool isExboost) { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x600085F")]
	public int get_IndexNumber() { }

	[Address(RVA = "0x1D483E0", Offset = "0x1D477E0", Length = "0xA2")]
	[Token(Token = "0x600085C")]
	public virtual Vector3 GetHitPosition() { }

	[Address(RVA = "0x1D48490", Offset = "0x1D47890", Length = "0x99")]
	[Token(Token = "0x600085A")]
	public virtual bool IsBulletHit(HybridCollisions owner) { }

	[Address(RVA = "0x1D48530", Offset = "0x1D47930", Length = "0x5")]
	[Token(Token = "0x6000859")]
	public virtual bool IsEnableCollision() { }

	[Address(RVA = "0x1D48540", Offset = "0x1D47940", Length = "0x158")]
	[Token(Token = "0x600085D")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600085B")]
	public virtual bool IsNoLockOnModel() { }

	[Address(RVA = "0x1D486A0", Offset = "0x1D47AA0", Length = "0xDF")]
	[Token(Token = "0x6000858")]
	public virtual void OwnerStart() { }

}

