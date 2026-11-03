namespace UnityEngine;

[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
[RequiredByNativeCode(Optional = False, GenerateProxy = False)]
[Token(Token = "0x200000E")]
public struct ContactPoint2D
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("point")]
	[Token(Token = "0x4000038")]
	private Vector2 m_Point; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("normal")]
	[Token(Token = "0x4000039")]
	private Vector2 m_Normal; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("relativeVelocity")]
	[Token(Token = "0x400003A")]
	private Vector2 m_RelativeVelocity; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("friction")]
	[Token(Token = "0x400003B")]
	private float m_Friction; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("bounciness")]
	[Token(Token = "0x400003C")]
	private float m_Bounciness; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("separation")]
	[Token(Token = "0x400003D")]
	private float m_Separation; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[NativeName("normalImpulse")]
	[Token(Token = "0x400003E")]
	private float m_NormalImpulse; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[NativeName("tangentImpulse")]
	[Token(Token = "0x400003F")]
	private float m_TangentImpulse; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[NativeName("collider")]
	[Token(Token = "0x4000040")]
	private EntityId m_Collider; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[NativeName("otherCollider")]
	[Token(Token = "0x4000041")]
	private EntityId m_OtherCollider; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[NativeName("rigidbody")]
	[Token(Token = "0x4000042")]
	private EntityId m_Rigidbody; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[NativeName("otherRigidbody")]
	[Token(Token = "0x4000043")]
	private EntityId m_OtherRigidbody; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[NativeName("enabled")]
	[Token(Token = "0x4000044")]
	private int m_Enabled; //Field offset: 0x3C

	[Token(Token = "0x1700000E")]
	public Vector2 point
	{
		[Address(RVA = "0x31250F0", Offset = "0x31244F0", Length = "0x12")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x31250F0", Offset = "0x31244F0", Length = "0x12")]
	[Token(Token = "0x6000042")]
	public Vector2 get_point() { }

}

