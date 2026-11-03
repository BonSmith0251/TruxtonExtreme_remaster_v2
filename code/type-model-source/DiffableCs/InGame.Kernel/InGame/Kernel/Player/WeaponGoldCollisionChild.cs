namespace InGame.Kernel.Player;

[Token(Token = "0x200012E")]
public class WeaponGoldCollisionChild : WeaponLaserCollision
{
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000874")]
	private HybridCollisions _skipEnemy; //Field offset: 0x1E8

	[Address(RVA = "0x1D59430", Offset = "0x1D58830", Length = "0x49")]
	[Token(Token = "0x6000966")]
	public WeaponGoldCollisionChild() { }

	[Address(RVA = "0x1D59160", Offset = "0x1D58560", Length = "0x40")]
	[Token(Token = "0x6000965")]
	protected virtual void ClearLockOnTarget() { }

	[Address(RVA = "0x1D591A0", Offset = "0x1D585A0", Length = "0x262")]
	[Token(Token = "0x6000964")]
	protected virtual bool IsLockOnTarget(HybridCollisionBridge tbridge) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[Token(Token = "0x6000963")]
	public void SetParentLockOnTarget(HybridCollisions tenemy) { }

}

