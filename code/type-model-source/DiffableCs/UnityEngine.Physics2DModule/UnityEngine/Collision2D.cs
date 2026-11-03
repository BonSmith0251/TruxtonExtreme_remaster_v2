namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x200000D")]
public class Collision2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002F")]
	internal int m_Collider; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000030")]
	internal int m_OtherCollider; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000031")]
	internal int m_Rigidbody; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000032")]
	internal int m_OtherRigidbody; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000033")]
	internal Vector2 m_RelativeVelocity; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000034")]
	internal int m_Enabled; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000035")]
	internal int m_ContactCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000036")]
	internal ContactPoint2D[] m_ReusedContacts; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000037")]
	internal ContactPoint2D[] m_LegacyContacts; //Field offset: 0x38

	[Token(Token = "0x1700000A")]
	public Collider2D collider
	{
		[Address(RVA = "0x3123D60", Offset = "0x3123160", Length = "0xA7")]
		[Token(Token = "0x600003E")]
		 get { } //Length: 167
	}

	[Token(Token = "0x1700000C")]
	public GameObject gameObject
	{
		[Address(RVA = "0x3123E10", Offset = "0x3123210", Length = "0x114")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 276
	}

	[Token(Token = "0x1700000D")]
	public Vector2 relativeVelocity
	{
		[Address(RVA = "0x3123F30", Offset = "0x3123330", Length = "0x13")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700000B")]
	public Rigidbody2D rigidbody
	{
		[Address(RVA = "0x3123F50", Offset = "0x3123350", Length = "0x7F")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 127
	}

	[Address(RVA = "0x3123D60", Offset = "0x3123160", Length = "0xA7")]
	[Token(Token = "0x600003E")]
	public Collider2D get_collider() { }

	[Address(RVA = "0x3123E10", Offset = "0x3123210", Length = "0x114")]
	[Token(Token = "0x6000040")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0x3123F30", Offset = "0x3123330", Length = "0x13")]
	[Token(Token = "0x6000041")]
	public Vector2 get_relativeVelocity() { }

	[Address(RVA = "0x3123F50", Offset = "0x3123350", Length = "0x7F")]
	[Token(Token = "0x600003F")]
	public Rigidbody2D get_rigidbody() { }

}

