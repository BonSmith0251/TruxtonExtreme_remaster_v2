namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000DF")]
public class UniversalShadowData : ContextItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400051F")]
	public bool supportsMainLightShadows; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000520")]
	internal bool mainLightShadowsEnabled; //Field offset: 0x11
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000521")]
	public int mainLightShadowmapWidth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000522")]
	public int mainLightShadowmapHeight; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000523")]
	public int mainLightShadowCascadesCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000524")]
	public Vector3 mainLightShadowCascadesSplit; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000525")]
	public float mainLightShadowCascadeBorder; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000526")]
	public bool supportsAdditionalLightShadows; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000527")]
	internal bool additionalLightShadowsEnabled; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000528")]
	public int additionalLightsShadowmapWidth; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000529")]
	public int additionalLightsShadowmapHeight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400052A")]
	public bool supportsSoftShadows; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400052B")]
	public int shadowmapDepthBufferBits; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400052C")]
	public List<Vector4> bias; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400052D")]
	public List<Int32> resolution; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400052E")]
	internal bool isKeywordAdditionalLightShadowsEnabled; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x400052F")]
	internal bool isKeywordSoftShadowsEnabled; //Field offset: 0x59
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000530")]
	internal int mainLightShadowResolution; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000531")]
	internal int mainLightRenderTargetWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000532")]
	internal int mainLightRenderTargetHeight; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000533")]
	internal NativeArray<URPLightShadowCullingInfos> visibleLightsShadowCullingInfos; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000534")]
	internal AdditionalLightsShadowAtlasLayout shadowAtlasLayout; //Field offset: 0x78

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600060E")]
	public UniversalShadowData() { }

	[Address(RVA = "0x2DC8F30", Offset = "0x2DC8330", Length = "0xE6")]
	[Token(Token = "0x600060D")]
	public virtual void Reset() { }

}

