namespace UnityEngine.Rendering;

[Token(Token = "0x20003A7")]
public struct BatchCullingOutputDrawCommands
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B3E")]
	public BatchDrawCommand* drawCommands; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B3F")]
	public BatchDrawCommandIndirect* indirectDrawCommands; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B40")]
	public BatchDrawCommandProcedural* proceduralDrawCommands; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B41")]
	public BatchDrawCommandProceduralIndirect* proceduralIndirectDrawCommands; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B42")]
	public Int32* visibleInstances; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B43")]
	public BatchDrawRange* drawRanges; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B44")]
	public Single* instanceSortingPositions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B45")]
	public EntityId* drawCommandPickingEntityIds; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B46")]
	public int drawCommandCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000B47")]
	public int indirectDrawCommandCount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B48")]
	public int proceduralDrawCommandCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000B49")]
	public int proceduralIndirectDrawCommandCount; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B4A")]
	public int visibleInstanceCount; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000B4B")]
	public int drawRangeCount; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B4C")]
	public int instanceSortingPositionFloatCount; //Field offset: 0x58

}

