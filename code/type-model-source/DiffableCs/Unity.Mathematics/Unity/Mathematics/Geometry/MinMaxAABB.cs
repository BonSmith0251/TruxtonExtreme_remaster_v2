namespace Unity.Mathematics.Geometry;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000063")]
public struct MinMaxAABB : IEquatable<MinMaxAABB>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400017B")]
	public float3 Min; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400017C")]
	public float3 Max; //Field offset: 0xC

	[Token(Token = "0x17000B8C")]
	public float3 Center
	{
		[Address(RVA = "0x2A97C40", Offset = "0x2A97040", Length = "0x53")]
		[Token(Token = "0x60024B5")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000B8A")]
	public float3 Extents
	{
		[Address(RVA = "0x2A97CA0", Offset = "0x2A970A0", Length = "0x3F")]
		[Token(Token = "0x60024B3")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000B8B")]
	public float3 HalfExtents
	{
		[Address(RVA = "0x2A97CE0", Offset = "0x2A970E0", Length = "0x53")]
		[Token(Token = "0x60024B4")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000B8D")]
	public bool IsValid
	{
		[Address(RVA = "0x2A97D40", Offset = "0x2A97140", Length = "0x3D")]
		[Token(Token = "0x60024B6")]
		 get { } //Length: 61
	}

	[Token(Token = "0x17000B8E")]
	public float SurfaceArea
	{
		[Address(RVA = "0x2A97D80", Offset = "0x2A97180", Length = "0x4B")]
		[Token(Token = "0x60024B7")]
		 get { } //Length: 75
	}

	[Address(RVA = "0x665C80", Offset = "0x665080", Length = "0x20")]
	[Token(Token = "0x60024B0")]
	public MinMaxAABB(float3 min, float3 max) { }

	[Address(RVA = "0x2A975A0", Offset = "0x2A969A0", Length = "0x8C")]
	[Token(Token = "0x60024B8")]
	public bool Contains(float3 point) { }

	[Address(RVA = "0x2A97630", Offset = "0x2A96A30", Length = "0x92")]
	[Token(Token = "0x60024B9")]
	public bool Contains(MinMaxAABB aabb) { }

	[Address(RVA = "0x2A976D0", Offset = "0x2A96AD0", Length = "0x9C")]
	[Token(Token = "0x60024B1")]
	public static MinMaxAABB CreateFromCenterAndExtents(float3 center, float3 extents) { }

	[Address(RVA = "0x2A97770", Offset = "0x2A96B70", Length = "0x8C")]
	[Token(Token = "0x60024B2")]
	public static MinMaxAABB CreateFromCenterAndHalfExtents(float3 center, float3 halfExtents) { }

	[Address(RVA = "0x2A97800", Offset = "0x2A96C00", Length = "0x110")]
	[Token(Token = "0x60024BC")]
	public void Encapsulate(MinMaxAABB aabb) { }

	[Address(RVA = "0x2A97910", Offset = "0x2A96D10", Length = "0x10F")]
	[Token(Token = "0x60024BD")]
	public void Encapsulate(float3 point) { }

	[Address(RVA = "0x2A97A20", Offset = "0x2A96E20", Length = "0x75")]
	[Token(Token = "0x60024BE")]
	public override bool Equals(MinMaxAABB other) { }

	[Address(RVA = "0x2A97AA0", Offset = "0x2A96EA0", Length = "0x5A")]
	[Token(Token = "0x60024BB")]
	public void Expand(float signedDistance) { }

	[Address(RVA = "0x2A97C40", Offset = "0x2A97040", Length = "0x53")]
	[Token(Token = "0x60024B5")]
	public float3 get_Center() { }

	[Address(RVA = "0x2A97CA0", Offset = "0x2A970A0", Length = "0x3F")]
	[Token(Token = "0x60024B3")]
	public float3 get_Extents() { }

	[Address(RVA = "0x2A97CE0", Offset = "0x2A970E0", Length = "0x53")]
	[Token(Token = "0x60024B4")]
	public float3 get_HalfExtents() { }

	[Address(RVA = "0x2A97D40", Offset = "0x2A97140", Length = "0x3D")]
	[Token(Token = "0x60024B6")]
	public bool get_IsValid() { }

	[Address(RVA = "0x2A97D80", Offset = "0x2A97180", Length = "0x4B")]
	[Token(Token = "0x60024B7")]
	public float get_SurfaceArea() { }

	[Address(RVA = "0x2A97B00", Offset = "0x2A96F00", Length = "0x92")]
	[Token(Token = "0x60024BA")]
	public bool Overlaps(MinMaxAABB aabb) { }

	[Address(RVA = "0x2A97BA0", Offset = "0x2A96FA0", Length = "0x9D")]
	[Token(Token = "0x60024BF")]
	public virtual string ToString() { }

}

