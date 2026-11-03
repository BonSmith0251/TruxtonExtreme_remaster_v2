namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x2000011")]
public struct XRPassCreateInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000048")]
	internal RenderTargetIdentifier renderTarget; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000049")]
	internal RenderTextureDescriptor renderTargetDesc; //Field offset: 0x28
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400004A")]
	internal RenderTargetIdentifier motionVectorRenderTarget; //Field offset: 0x60
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400004B")]
	internal RenderTextureDescriptor motionVectorRenderTargetDesc; //Field offset: 0x88
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400004C")]
	internal ScriptableCullingParameters cullingParameters; //Field offset: 0xC0
	[FieldOffset(Offset = "0x6F8")]
	[Token(Token = "0x400004D")]
	internal Material occlusionMeshMaterial; //Field offset: 0x6F8
	[FieldOffset(Offset = "0x700")]
	[Token(Token = "0x400004E")]
	internal float occlusionMeshScale; //Field offset: 0x700
	[FieldOffset(Offset = "0x704")]
	[Token(Token = "0x400004F")]
	internal int renderTargetScaledWidth; //Field offset: 0x704
	[FieldOffset(Offset = "0x708")]
	[Token(Token = "0x4000050")]
	internal int renderTargetScaledHeight; //Field offset: 0x708
	[FieldOffset(Offset = "0x710")]
	[Token(Token = "0x4000051")]
	internal IntPtr foveatedRenderingInfo; //Field offset: 0x710
	[FieldOffset(Offset = "0x718")]
	[Token(Token = "0x4000052")]
	internal int multipassId; //Field offset: 0x718
	[FieldOffset(Offset = "0x71C")]
	[Token(Token = "0x4000053")]
	internal int cullingPassId; //Field offset: 0x71C
	[FieldOffset(Offset = "0x720")]
	[Token(Token = "0x4000054")]
	internal bool copyDepth; //Field offset: 0x720
	[FieldOffset(Offset = "0x721")]
	[Token(Token = "0x4000055")]
	internal bool hasMotionVectorPass; //Field offset: 0x721
	[FieldOffset(Offset = "0x722")]
	[Token(Token = "0x4000056")]
	internal bool spaceWarpRightHandedNDC; //Field offset: 0x722
	[FieldOffset(Offset = "0x723")]
	[Token(Token = "0x4000057")]
	internal bool isLastCameraPass; //Field offset: 0x723
	[FieldOffset(Offset = "0x728")]
	[Token(Token = "0x4000058")]
	internal XRRenderPass xrSdkRenderPass; //Field offset: 0x728

}

