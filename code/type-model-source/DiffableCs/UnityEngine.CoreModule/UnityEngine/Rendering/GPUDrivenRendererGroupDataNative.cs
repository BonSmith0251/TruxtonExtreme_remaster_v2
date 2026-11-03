namespace UnityEngine.Rendering;

[Token(Token = "0x20003BC")]
[UsedByNativeCode]
internal struct GPUDrivenRendererGroupDataNative
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B89")]
	public EntityId* rendererGroupID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B8A")]
	public Bounds* localBounds; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B8B")]
	public Vector4* lightmapScaleOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B8C")]
	public Int32* gameObjectLayer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B8D")]
	public UInt32* renderingLayerMask; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B8E")]
	public UInt32* rendererUserValues; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B8F")]
	public EntityId* lodGroupID; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B90")]
	public MotionVectorGenerationMode* motionVecGenMode; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B91")]
	public GPUDrivenPackedRendererData* packedRendererData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B92")]
	public Int32* rendererPriority; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B93")]
	public Int32* meshIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B94")]
	public Int16* subMeshStartIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B95")]
	public Int32* materialsOffset; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B96")]
	public Int16* materialsCount; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B97")]
	public Int32* instancesOffset; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B98")]
	public Int32* instancesCount; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B99")]
	public GPUDrivenRendererEditorData* editorData; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B9A")]
	public int rendererGroupCount; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000B9B")]
	public EntityId* invalidRendererGroupID; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B9C")]
	public int invalidRendererGroupIDCount; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B9D")]
	public GPUDrivenRendererMeshLodData* meshLodData; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B9E")]
	public Matrix4x4* localToWorldMatrix; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000B9F")]
	public Matrix4x4* prevLocalToWorldMatrix; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000BA0")]
	public Int32* rendererGroupIndex; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000BA1")]
	public int instanceCount; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000BA2")]
	public EntityId* meshID; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000BA3")]
	public GPUDrivenMeshLodInfo* meshLodInfo; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000BA4")]
	public Int16* subMeshCount; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000BA5")]
	public Int32* subMeshDescOffset; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000BA6")]
	public int meshCount; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000BA7")]
	public SubMeshDescriptor* subMeshDesc; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000BA8")]
	public int subMeshDescCount; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000BA9")]
	public Int32* materialIndex; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000BAA")]
	public int materialIndexCount; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000BAB")]
	public EntityId* materialID; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000BAC")]
	public GPUDrivenPackedMaterialData* packedMaterialData; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000BAD")]
	public Int32* materialFilterFlags; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000BAE")]
	public int materialCount; //Field offset: 0x128

}

