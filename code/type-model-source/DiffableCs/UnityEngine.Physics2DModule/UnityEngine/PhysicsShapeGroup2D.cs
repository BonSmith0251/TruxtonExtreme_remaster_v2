namespace UnityEngine;

[Token(Token = "0x200000A")]
public class PhysicsShapeGroup2D
{
	[NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
	[Token(Token = "0x200000B")]
	public struct GroupState
	{
		[FieldOffset(Offset = "0x0")]
		[NativeName("shapesList")]
		[Token(Token = "0x4000020")]
		public List<PhysicsShape2D> m_Shapes; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[NativeName("verticesList")]
		[Token(Token = "0x4000021")]
		public List<Vector2> m_Vertices; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[NativeName("localToWorld")]
		[Token(Token = "0x4000022")]
		public Matrix4x4 m_LocalToWorld; //Field offset: 0x10

		[Address(RVA = "0x3126300", Offset = "0x3125700", Length = "0x5E")]
		[Token(Token = "0x6000038")]
		public void ClearGeometry() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001F")]
	internal GroupState m_GroupState; //Field offset: 0x10

	[Token(Token = "0x17000008")]
	internal List<PhysicsShape2D> groupShapes
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x6000034")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000007")]
	internal List<Vector2> groupVertices
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x6000033")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000009")]
	public int shapeCount
	{
		[Address(RVA = "0x312F060", Offset = "0x312E460", Length = "0x3C")]
		[Token(Token = "0x6000035")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x312EED0", Offset = "0x312E2D0", Length = "0x18A")]
	[Token(Token = "0x6000036")]
	public PhysicsShapeGroup2D(int shapeCapacity = 1, int vertexCapacity = 8) { }

	[Address(RVA = "0x312EE20", Offset = "0x312E220", Length = "0xA9")]
	[Token(Token = "0x6000037")]
	public void Clear() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6000034")]
	internal List<PhysicsShape2D> get_groupShapes() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x6000033")]
	internal List<Vector2> get_groupVertices() { }

	[Address(RVA = "0x312F060", Offset = "0x312E460", Length = "0x3C")]
	[Token(Token = "0x6000035")]
	public int get_shapeCount() { }

}

