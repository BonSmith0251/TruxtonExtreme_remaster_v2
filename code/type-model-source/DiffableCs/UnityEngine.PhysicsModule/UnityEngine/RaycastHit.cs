namespace UnityEngine;

[NativeHeader("Runtime/Interfaces/IPhysics.h")]
[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Physics/RaycastHit.h")]
[Token(Token = "0x200001D")]
[UsedByNativeCode]
public struct RaycastHit
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("point")]
	[Token(Token = "0x400007C")]
	internal Vector3 m_Point; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[NativeName("normal")]
	[Token(Token = "0x400007D")]
	internal Vector3 m_Normal; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[NativeName("faceID")]
	[Token(Token = "0x400007E")]
	internal uint m_FaceID; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("distance")]
	[Token(Token = "0x400007F")]
	internal float m_Distance; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("uv")]
	[Token(Token = "0x4000080")]
	internal Vector2 m_UV; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[NativeName("collider")]
	[Token(Token = "0x4000081")]
	internal EntityId m_Collider; //Field offset: 0x28

	[Token(Token = "0x1700002C")]
	public Collider collider
	{
		[Address(RVA = "0x313B5F0", Offset = "0x313A9F0", Length = "0x9E")]
		[Token(Token = "0x60000C5")]
		 get { } //Length: 158
	}

	[Token(Token = "0x1700002F")]
	public float distance
	{
		[Address(RVA = "0x2F92DC0", Offset = "0x2F921C0", Length = "0x8")]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 8
		[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
		[Token(Token = "0x60000CB")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700002E")]
	public Vector3 normal
	{
		[Address(RVA = "0x3136170", Offset = "0x3135570", Length = "0x13")]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 19
		[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
		[Token(Token = "0x60000C9")]
		 set { } //Length: 106
	}

	[Token(Token = "0x1700002D")]
	public Vector3 point
	{
		[Address(RVA = "0x3136190", Offset = "0x3135590", Length = "0x12")]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 18
		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[Token(Token = "0x60000C7")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x313B5F0", Offset = "0x313A9F0", Length = "0x9E")]
	[Token(Token = "0x60000C5")]
	public Collider get_collider() { }

	[Address(RVA = "0x2F92DC0", Offset = "0x2F921C0", Length = "0x8")]
	[Token(Token = "0x60000CA")]
	public float get_distance() { }

	[Address(RVA = "0x3136170", Offset = "0x3135570", Length = "0x13")]
	[Token(Token = "0x60000C8")]
	public Vector3 get_normal() { }

	[Address(RVA = "0x3136190", Offset = "0x3135590", Length = "0x12")]
	[Token(Token = "0x60000C6")]
	public Vector3 get_point() { }

	[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
	[Token(Token = "0x60000CB")]
	public void set_distance(float value) { }

	[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
	[Token(Token = "0x60000C9")]
	public void set_normal(Vector3 value) { }

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x60000C7")]
	public void set_point(Vector3 value) { }

}

