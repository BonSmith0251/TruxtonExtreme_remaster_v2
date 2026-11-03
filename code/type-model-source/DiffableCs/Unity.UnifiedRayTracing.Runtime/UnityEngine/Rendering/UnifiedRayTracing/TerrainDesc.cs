namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000027")]
internal struct TerrainDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F2")]
	public Terrain terrain; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000F3")]
	public Matrix4x4 localToWorldMatrix; //Field offset: 0x8
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000F4")]
	public uint mask; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40000F5")]
	public uint renderingLayerMask; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000F6")]
	public uint materialID; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000F7")]
	public bool enableTriangleCulling; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x40000F8")]
	public bool frontTriangleCounterClockwise; //Field offset: 0x55

	[Address(RVA = "0x2F60670", Offset = "0x2F5FA70", Length = "0x76")]
	[Token(Token = "0x600006D")]
	public TerrainDesc(Terrain terrain) { }

}

