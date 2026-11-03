namespace UnityEngine.Rendering;

[Token(Token = "0x20003C2")]
internal struct GPUDrivenLODGroupData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BE3")]
	public NativeArray<EntityId> lodGroupID; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BE4")]
	public NativeArray<Int32> lodOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BE5")]
	public NativeArray<Int32> lodCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BE6")]
	public NativeArray<LODFadeMode> fadeMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BE7")]
	public NativeArray<Vector3> worldSpaceReferencePoint; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BE8")]
	public NativeArray<Single> worldSpaceSize; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BE9")]
	public NativeArray<Int16> renderersCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BEA")]
	public NativeArray<Boolean> lastLODIsBillboard; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000BEB")]
	public NativeArray<Byte> forceLODMask; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000BEC")]
	public NativeArray<EntityId> invalidLODGroupID; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000BED")]
	public NativeArray<Int16> lodRenderersCount; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000BEE")]
	public NativeArray<Single> lodScreenRelativeTransitionHeight; //Field offset: 0xB0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000BEF")]
	public NativeArray<Single> lodFadeTransitionWidth; //Field offset: 0xC0

}

