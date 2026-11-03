namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000263")]
public interface IRasterRenderGraphBuilder : IRenderAttachmentRenderGraphBuilder, IBaseRenderGraphBuilder, IDisposable
{

	[Token(Token = "0x600110C")]
	public void SetExtendedFeatureFlags(ExtendedFeatureFlags extendedFeatureFlags) { }

	[Address(RVA = "0x2C71660", Offset = "0x2C70A60", Length = "0x101")]
	[Token(Token = "0x6001107")]
	public void SetInputAttachment(TextureHandle tex, int index, AccessFlags flags = 1) { }

	[Token(Token = "0x6001108")]
	public void SetInputAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice) { }

	[Token(Token = "0x600110D")]
	public void SetRenderFunc(BaseRenderFunc<PassData, RasterGraphContext> renderFunc) { }

	[Token(Token = "0x600110B")]
	public void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Token(Token = "0x600110A")]
	public void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Token(Token = "0x6001109")]
	public void SetShadingRateImageAttachment(in TextureHandle tex) { }

}

