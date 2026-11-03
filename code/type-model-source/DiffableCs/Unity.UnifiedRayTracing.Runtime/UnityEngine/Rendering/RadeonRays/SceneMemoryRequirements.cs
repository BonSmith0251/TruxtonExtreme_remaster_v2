namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000014")]
internal class SceneMemoryRequirements
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000055")]
	public ulong buildScratchSizeInDwords; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000056")]
	public UInt64[] bottomLevelBvhSizeInNodes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000057")]
	public UInt32[] bottomLevelBvhOffsetInNodes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000058")]
	public UInt64[] bottomLevelBvhLeavesSizeInNodes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000059")]
	public UInt32[] bottomLevelBvhLeavesOffsetInNodes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400005A")]
	public ulong totalBottomLevelBvhSizeInNodes; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400005B")]
	public ulong totalBottomLevelBvhLeavesSizeInNodes; //Field offset: 0x40

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000030")]
	public SceneMemoryRequirements() { }

}

