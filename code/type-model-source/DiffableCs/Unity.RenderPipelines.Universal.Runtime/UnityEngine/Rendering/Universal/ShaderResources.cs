namespace UnityEngine.Rendering.Universal;

[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
[ReloadGroup]
[Token(Token = "0x20000BA")]
public sealed class ShaderResources
{
	[FieldOffset(Offset = "0x10")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/Blit.shader", Package::Root (1))]
	[Token(Token = "0x40003BB")]
	public Shader blitPS; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/CopyDepth.shader", Package::Root (1))]
	[Token(Token = "0x40003BC")]
	public Shader copyDepthPS; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Obsolete("Obsolete, this feature will be supported by new 'ScreenSpaceShadows' renderer feature. #from(2023.3) #breakingFrom(2023.3)", True)]
	[Token(Token = "0x40003BD")]
	public Shader screenSpaceShadowPS; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/Sampling.shader", Package::Root (1))]
	[Token(Token = "0x40003BE")]
	public Shader samplingPS; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/StencilDeferred.shader", Package::Root (1))]
	[Token(Token = "0x40003BF")]
	public Shader stencilDeferredPS; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/FallbackError.shader", Package::Root (1))]
	[Token(Token = "0x40003C0")]
	public Shader fallbackErrorPS; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/FallbackLoading.shader", Package::Root (1))]
	[Token(Token = "0x40003C1")]
	public Shader fallbackLoadingPS; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Obsolete("Use fallbackErrorPS instead. #from(2023.3) #breakingFrom(2023.3)", True)]
	[Token(Token = "0x40003C2")]
	public Shader materialErrorPS; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/CoreBlit.shader", Package::Root (1))]
	[SerializeField]
	[Token(Token = "0x40003C3")]
	internal Shader coreBlitPS; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", Package::Root (1))]
	[SerializeField]
	[Token(Token = "0x40003C4")]
	internal Shader coreBlitColorAndDepthPS; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/Utils/BlitHDROverlay.shader", Package::Root (1))]
	[SerializeField]
	[Token(Token = "0x40003C5")]
	internal Shader blitHDROverlay; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/CameraMotionVectors.shader", Package::Root (1))]
	[Token(Token = "0x40003C6")]
	public Shader cameraMotionVector; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/PostProcessing/LensFlareScreenSpace.shader", Package::Root (1))]
	[Token(Token = "0x40003C7")]
	public Shader screenSpaceLensFlare; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeShaders on GraphicsSettings. #from(2023.3)")]
	[Reload("Shaders/PostProcessing/LensFlareDataDriven.shader", Package::Root (1))]
	[Token(Token = "0x40003C8")]
	public Shader dataDrivenLensFlare; //Field offset: 0x78

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000469")]
	public ShaderResources() { }

}

