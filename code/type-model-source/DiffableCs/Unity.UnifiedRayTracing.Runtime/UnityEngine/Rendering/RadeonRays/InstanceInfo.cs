namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200001C")]
internal struct InstanceInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000081")]
	public int blasOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000082")]
	public int instanceMask; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000083")]
	public int vertexOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000084")]
	public int indexOffset; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000085")]
	public uint disableTriangleCulling; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000086")]
	public uint invertTriangleCulling; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000087")]
	public uint userInstanceID; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000088")]
	public int isOpaque; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000089")]
	public Transform worldToLocalTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400008A")]
	public Transform localToWorldTransform; //Field offset: 0x50

}

