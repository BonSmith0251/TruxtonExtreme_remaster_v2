namespace UnityEngine;

[NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
[Token(Token = "0x2000009")]
[UsedByNativeCode]
public struct PhysicsShape2D
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000017")]
	private PhysicsShapeType2D m_ShapeType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000018")]
	private float m_Radius; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000019")]
	private int m_VertexStartIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400001A")]
	private int m_VertexCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001B")]
	private int m_UseAdjacentStart; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400001C")]
	private int m_UseAdjacentEnd; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001D")]
	private Vector2 m_AdjacentStart; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001E")]
	private Vector2 m_AdjacentEnd; //Field offset: 0x20

	[Token(Token = "0x17000004")]
	public float radius
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000003")]
	public PhysicsShapeType2D shapeType
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x600002F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000006")]
	public int vertexCount
	{
		[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
		[Token(Token = "0x6000032")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000005")]
	public int vertexStartIndex
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6000031")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x6000030")]
	public float get_radius() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x600002F")]
	public PhysicsShapeType2D get_shapeType() { }

	[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
	[Token(Token = "0x6000032")]
	public int get_vertexCount() { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6000031")]
	public int get_vertexStartIndex() { }

}

