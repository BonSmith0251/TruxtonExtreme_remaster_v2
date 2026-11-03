namespace UnityEngine;

[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = False)]
[Token(Token = "0x200000F")]
public struct RaycastHit2D
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("centroid")]
	[Token(Token = "0x4000045")]
	private Vector2 m_Centroid; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("point")]
	[Token(Token = "0x4000046")]
	private Vector2 m_Point; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("normal")]
	[Token(Token = "0x4000047")]
	private Vector2 m_Normal; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("distance")]
	[Token(Token = "0x4000048")]
	private float m_Distance; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("fraction")]
	[Token(Token = "0x4000049")]
	private float m_Fraction; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("collider")]
	[Token(Token = "0x400004A")]
	private EntityId m_Collider; //Field offset: 0x20

	[Token(Token = "0x17000012")]
	public Collider2D collider
	{
		[Address(RVA = "0x31329E0", Offset = "0x3131DE0", Length = "0x9E")]
		[Token(Token = "0x6000046")]
		 get { } //Length: 158
	}

	[Token(Token = "0x17000011")]
	public float distance
	{
		[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public Vector2 normal
	{
		[Address(RVA = "0x3132A80", Offset = "0x3131E80", Length = "0x13")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700000F")]
	public Vector2 point
	{
		[Address(RVA = "0x3132AA0", Offset = "0x3131EA0", Length = "0x13")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x31329E0", Offset = "0x3131DE0", Length = "0x9E")]
	[Token(Token = "0x6000046")]
	public Collider2D get_collider() { }

	[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
	[Token(Token = "0x6000045")]
	public float get_distance() { }

	[Address(RVA = "0x3132A80", Offset = "0x3131E80", Length = "0x13")]
	[Token(Token = "0x6000044")]
	public Vector2 get_normal() { }

	[Address(RVA = "0x3132AA0", Offset = "0x3131EA0", Length = "0x13")]
	[Token(Token = "0x6000043")]
	public Vector2 get_point() { }

}

