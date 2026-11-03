namespace InGame.Kernel.Player;

[Token(Token = "0x200011F")]
public class PlayerRescueCollisionModel : HybridCollisionModel
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400081D")]
	private bool _isNeedRescue; //Field offset: 0x70

	[Token(Token = "0x170001A7")]
	public bool IsNeedRescue
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x6000900")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D4F360", Offset = "0x1D4E760", Length = "0x49")]
	[Token(Token = "0x6000901")]
	public PlayerRescueCollisionModel() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008FF")]
	public virtual bool AddDamage(float t, int pno, bool isExboost) { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x6000900")]
	public bool get_IsNeedRescue() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008FA")]
	public virtual bool IsEnableCollision() { }

	[Address(RVA = "0x1D4F1D0", Offset = "0x1D4E5D0", Length = "0xFF")]
	[Token(Token = "0x60008FE")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x60008FB")]
	public virtual bool IsVisibleCollision() { }

	[Address(RVA = "0x1D4F2D0", Offset = "0x1D4E6D0", Length = "0x35")]
	[Token(Token = "0x60008F9")]
	public virtual void OwnerStart() { }

	[Address(RVA = "0x1D4F310", Offset = "0x1D4E710", Length = "0x2C")]
	[Token(Token = "0x60008FD")]
	public void ResetRescueParameter() { }

	[Address(RVA = "0x1D4F340", Offset = "0x1D4E740", Length = "0x1E")]
	[Token(Token = "0x60008FC")]
	public void SetWaitResucue() { }

}

