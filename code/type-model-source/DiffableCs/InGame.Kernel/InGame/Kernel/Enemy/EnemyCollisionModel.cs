namespace InGame.Kernel.Enemy;

[Token(Token = "0x200015C")]
public class EnemyCollisionModel : HybridCollisionModel
{
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40009D0")]
	private EnemyCollisionAttribute _attribute; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40009D1")]
	private EnemyCollisionAttribute _attributeCopy; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40009D2")]
	private Vector3 _lockOnPosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x40009D3")]
	private Color _lineColor; //Field offset: 0x84
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40009D4")]
	private PawnEnemy _enemyRoot; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40009D5")]
	private int _partsNumber; //Field offset: 0xA0

	[Token(Token = "0x170001C6")]
	public int PartsNumber
	{
		[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
		[Token(Token = "0x6000A8E")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1D63B40", Offset = "0x1D62F40", Length = "0x54")]
	[Token(Token = "0x6000A82")]
	private static EnemyCollisionAttribute _getAttributeFlag(attackType at) { }

	[Address(RVA = "0x1D63AA0", Offset = "0x1D62EA0", Length = "0x9E")]
	[Token(Token = "0x6000A8F")]
	public EnemyCollisionModel() { }

	[Address(RVA = "0x1D63450", Offset = "0x1D62850", Length = "0xA4")]
	[Token(Token = "0x6000A86")]
	public virtual bool AddDamage(float tdamage, int pno, bool isExboost) { }

	[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
	[Token(Token = "0x6000A8E")]
	public int get_PartsNumber() { }

	[Address(RVA = "0x1D63500", Offset = "0x1D62900", Length = "0x58")]
	[Token(Token = "0x6000A85")]
	public virtual Vector3 GetHitPosition() { }

	[Address(RVA = "0x1D63560", Offset = "0x1D62960", Length = "0xE")]
	[Token(Token = "0x6000A84")]
	public virtual Color GetLineColor() { }

	[Address(RVA = "0x1D63570", Offset = "0x1D62970", Length = "0x13")]
	[Token(Token = "0x6000A7C")]
	public virtual bool IsBomberHit() { }

	[Address(RVA = "0x1D63590", Offset = "0x1D62990", Length = "0x1A4")]
	[Token(Token = "0x6000A7B")]
	public virtual bool IsBulletHit(HybridCollisions hitsubject) { }

	[Address(RVA = "0x1D63750", Offset = "0x1D62B50", Length = "0x10")]
	[Token(Token = "0x6000A7E")]
	public virtual bool IsEnableCollision() { }

	[Address(RVA = "0x1D63760", Offset = "0x1D62B60", Length = "0xB")]
	[Token(Token = "0x6000A7F")]
	public virtual bool IsEnableDamage() { }

	[Address(RVA = "0x1D63770", Offset = "0x1D62B70", Length = "0xC9")]
	[Token(Token = "0x6000A81")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

	[Address(RVA = "0x1D63840", Offset = "0x1D62C40", Length = "0xE5")]
	[Token(Token = "0x6000A80")]
	public virtual bool IsIndependent() { }

	[Address(RVA = "0x1D63930", Offset = "0x1D62D30", Length = "0x8")]
	[Token(Token = "0x6000A89")]
	public virtual bool IsLaserBlockModel() { }

	[Address(RVA = "0x1D63940", Offset = "0x1D62D40", Length = "0x10")]
	[Token(Token = "0x6000A88")]
	public virtual bool IsNoLockOnModel() { }

	[Address(RVA = "0x1D63950", Offset = "0x1D62D50", Length = "0x9")]
	[Token(Token = "0x6000A83")]
	public virtual bool IsSkipClip() { }

	[Address(RVA = "0x1D63960", Offset = "0x1D62D60", Length = "0xD")]
	[Token(Token = "0x6000A87")]
	public virtual void OwnerStart() { }

	[Address(RVA = "0x1D63970", Offset = "0x1D62D70", Length = "0x6")]
	[Token(Token = "0x6000A8B")]
	public void ResetAttribute(EnemyCollisionAttribute tattribute) { }

	[Address(RVA = "0x1D63980", Offset = "0x1D62D80", Length = "0x4")]
	[Token(Token = "0x6000A8A")]
	public void SetAttribute(EnemyCollisionAttribute tattribute) { }

	[Address(RVA = "0x1D63990", Offset = "0x1D62D90", Length = "0x19")]
	[Token(Token = "0x6000A8C")]
	public void SetHitSwitch(bool isHit) { }

	[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
	[Token(Token = "0x6000A8D")]
	public void SetPartsNumber(int n) { }

	[Address(RVA = "0x1D639C0", Offset = "0x1D62DC0", Length = "0xDF")]
	[Token(Token = "0x6000A7D")]
	public virtual void SetRootOwner(HybridCollisions _root) { }

}

