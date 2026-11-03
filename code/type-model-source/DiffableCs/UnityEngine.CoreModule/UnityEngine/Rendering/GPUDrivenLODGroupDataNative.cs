namespace UnityEngine.Rendering;

[Token(Token = "0x20003BD")]
[UsedByNativeCode]
internal struct GPUDrivenLODGroupDataNative
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BAF")]
	public EntityId* lodGroupID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BB0")]
	public Int32* lodOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BB1")]
	public Int32* lodCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BB2")]
	public LODFadeMode* fadeMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BB3")]
	public Vector3* worldSpaceReferencePoint; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BB4")]
	public Single* worldSpaceSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BB5")]
	public Int16* renderersCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BB6")]
	public Boolean* lastLODIsBillboard; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BB7")]
	public Byte* forceLODMask; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BB8")]
	public int lodGroupCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BB9")]
	public EntityId* invalidLODGroupID; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BBA")]
	public int invalidLODGroupCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BBB")]
	public Int16* lodRenderersCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BBC")]
	public Single* lodScreenRelativeTransitionHeight; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BBD")]
	public Single* lodFadeTransitionWidth; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BBE")]
	public int lodDataCount; //Field offset: 0x78

}

