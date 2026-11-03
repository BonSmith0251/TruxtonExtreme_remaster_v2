namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000019")]
internal struct BvhNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000068")]
	public uint child0; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000069")]
	public uint child1; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400006A")]
	public uint parent; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400006B")]
	public uint update; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006C")]
	public float3 aabb0_min; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400006D")]
	public float3 aabb0_max; //Field offset: 0x1C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400006E")]
	public float3 aabb1_min; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400006F")]
	public float3 aabb1_max; //Field offset: 0x34

}

