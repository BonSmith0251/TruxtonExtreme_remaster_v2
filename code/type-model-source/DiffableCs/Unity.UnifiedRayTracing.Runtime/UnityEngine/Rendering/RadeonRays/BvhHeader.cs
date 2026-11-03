namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200001A")]
internal struct BvhHeader
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000070")]
	public uint internalNodeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000071")]
	public uint leafNodeCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000072")]
	public uint root; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000073")]
	public uint unused; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000074")]
	public float3 globalAabbMin; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000075")]
	public float3 globalAabbMax; //Field offset: 0x1C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000076")]
	public uint3 unused3; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000077")]
	public uint3 unused4; //Field offset: 0x34

}

