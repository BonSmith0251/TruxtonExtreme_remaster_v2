namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200000A")]
internal struct BottomLevelLevelAccelStruct
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000017")]
	public GraphicsBuffer bvh; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000018")]
	public uint bvhOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000019")]
	public GraphicsBuffer bvhLeaves; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001A")]
	public uint bvhLeavesOffset; //Field offset: 0x18

}

