namespace UnityEngine;

[Token(Token = "0x2000002")]
public struct ContactPoint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	internal Vector3 m_Point; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000002")]
	internal Vector3 m_Normal; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000003")]
	internal Vector3 m_Impulse; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000004")]
	internal EntityId m_ThisColliderEntityId; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000005")]
	internal EntityId m_OtherColliderEntityId; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000006")]
	internal float m_Separation; //Field offset: 0x2C

	[Token(Token = "0x17000002")]
	public Vector3 normal
	{
		[Address(RVA = "0x3136170", Offset = "0x3135570", Length = "0x13")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000001")]
	public Vector3 point
	{
		[Address(RVA = "0x3136190", Offset = "0x3135590", Length = "0x12")]
		[Token(Token = "0x6000001")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x3136170", Offset = "0x3135570", Length = "0x13")]
	[Token(Token = "0x6000002")]
	public Vector3 get_normal() { }

	[Address(RVA = "0x3136190", Offset = "0x3135590", Length = "0x12")]
	[Token(Token = "0x6000001")]
	public Vector3 get_point() { }

}

