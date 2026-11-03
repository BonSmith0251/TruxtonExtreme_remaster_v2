namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000012")]
internal struct MeshBuildMemoryRequirements
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000051")]
	public ulong buildScratchSizeInDwords; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000052")]
	public ulong bvhSizeInDwords; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000053")]
	public ulong bvhLeavesSizeInDwords; //Field offset: 0x10

}

