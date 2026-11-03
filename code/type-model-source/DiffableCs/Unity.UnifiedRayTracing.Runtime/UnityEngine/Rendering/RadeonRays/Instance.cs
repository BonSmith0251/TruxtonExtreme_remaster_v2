namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200001B")]
internal struct Instance
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000078")]
	public uint meshAccelStructOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000079")]
	public uint instanceMask; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007A")]
	public uint vertexOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400007B")]
	public uint meshAccelStructLeavesOffset; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007C")]
	public bool triangleCullingEnabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400007D")]
	public bool invertTriangleCulling; //Field offset: 0x11
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400007E")]
	public uint userInstanceID; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007F")]
	public bool isOpaque; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000080")]
	public Transform localToWorldTransform; //Field offset: 0x1C

}

