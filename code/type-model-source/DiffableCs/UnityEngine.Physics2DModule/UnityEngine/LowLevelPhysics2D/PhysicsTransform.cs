namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x200002A")]
public struct PhysicsTransform
{
	[Token(Token = "0x40000ED")]
	private static readonly PhysicsTransform identityTransform; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000EB")]
	public Vector2 position; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000EC")]
	public PhysicsRotate rotation; //Field offset: 0x8

	[Address(RVA = "0x312F7C0", Offset = "0x312EBC0", Length = "0x13E")]
	[Token(Token = "0x6000151")]
	private static PhysicsTransform() { }

	[Address(RVA = "0x312F900", Offset = "0x312ED00", Length = "0x57")]
	[Token(Token = "0x600014E")]
	public PhysicsTransform() { }

	[Address(RVA = "0x312F6F0", Offset = "0x312EAF0", Length = "0x23")]
	[IsReadOnly]
	[Token(Token = "0x600014F")]
	public void GetPositionAndRotation(out Vector2 position, out PhysicsRotate rotation) { }

	[Address(RVA = "0x312F720", Offset = "0x312EB20", Length = "0x9B")]
	[IsReadOnly]
	[Token(Token = "0x6000150")]
	public virtual string ToString() { }

}

