namespace Unity.Mathematics.Geometry;

[Token(Token = "0x2000064")]
public static class Math
{

	[Address(RVA = "0x2A96F80", Offset = "0x2A96380", Length = "0x616")]
	[Token(Token = "0x60024C0")]
	public static MinMaxAABB Transform(RigidTransform transform, MinMaxAABB aabb) { }

	[Address(RVA = "0x2A96E40", Offset = "0x2A96240", Length = "0x135")]
	[Token(Token = "0x60024C1")]
	public static MinMaxAABB Transform(float4x4 transform, MinMaxAABB aabb) { }

	[Address(RVA = "0x2A95CD0", Offset = "0x2A950D0", Length = "0x2B0")]
	[Token(Token = "0x60024C2")]
	public static MinMaxAABB Transform(float3x3 transform, MinMaxAABB aabb) { }

}

