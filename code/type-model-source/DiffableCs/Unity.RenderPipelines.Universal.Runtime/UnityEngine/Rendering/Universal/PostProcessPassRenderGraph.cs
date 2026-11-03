namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000135")]
internal class PostProcessPassRenderGraph
{
	[CompilerGenerated]
	[Token(Token = "0x200014B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000764")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000765")]
		public static BaseRenderFunc<UpdateCameraResolutionPassData, UnsafeGraphContext> <>9__45_0; //Field offset: 0x8
		[Token(Token = "0x4000766")]
		public static BaseRenderFunc<StopNaNsPassData, RasterGraphContext> <>9__53_0; //Field offset: 0x10
		[Token(Token = "0x4000767")]
		public static BaseRenderFunc<SMAASetupPassData, RasterGraphContext> <>9__56_0; //Field offset: 0x18
		[Token(Token = "0x4000768")]
		public static BaseRenderFunc<SMAAPassData, RasterGraphContext> <>9__56_1; //Field offset: 0x20
		[Token(Token = "0x4000769")]
		public static BaseRenderFunc<SMAAPassData, RasterGraphContext> <>9__56_2; //Field offset: 0x28
		[Token(Token = "0x400076A")]
		public static BaseRenderFunc<SMAAPassData, RasterGraphContext> <>9__56_3; //Field offset: 0x30
		[Token(Token = "0x400076B")]
		public static BaseRenderFunc<BloomPassData, UnsafeGraphContext> <>9__64_0; //Field offset: 0x38
		[Token(Token = "0x400076C")]
		public static BaseRenderFunc<BloomPassData, UnsafeGraphContext> <>9__65_0; //Field offset: 0x40
		[Token(Token = "0x400076D")]
		public static BaseRenderFunc<BloomPassData, UnsafeGraphContext> <>9__66_0; //Field offset: 0x48
		[Token(Token = "0x400076E")]
		public static BaseRenderFunc<DoFGaussianPassData, UnsafeGraphContext> <>9__69_0; //Field offset: 0x50
		[Token(Token = "0x400076F")]
		public static BaseRenderFunc<DoFBokehPassData, UnsafeGraphContext> <>9__73_0; //Field offset: 0x58
		[Token(Token = "0x4000770")]
		public static BaseRenderFunc<PaniniProjectionPassData, RasterGraphContext> <>9__75_0; //Field offset: 0x60
		[Token(Token = "0x4000771")]
		public static BaseRenderFunc<MotionBlurPassData, RasterGraphContext> <>9__83_0; //Field offset: 0x68
		[Token(Token = "0x4000772")]
		public static BaseRenderFunc<LensFlarePassData, UnsafeGraphContext> <>9__86_0; //Field offset: 0x70
		[Token(Token = "0x4000773")]
		public static Func<Light, Camera, Vector3, Single> <>9__87_1; //Field offset: 0x78
		[Token(Token = "0x4000774")]
		public static Func<Light, Camera, Vector3, Single> <>9__87_2; //Field offset: 0x80
		[Token(Token = "0x4000775")]
		public static BaseRenderFunc<LensFlarePassData, UnsafeGraphContext> <>9__87_0; //Field offset: 0x88
		[Token(Token = "0x4000776")]
		public static BaseRenderFunc<LensFlareScreenSpacePassData, UnsafeGraphContext> <>9__90_0; //Field offset: 0x90
		[Token(Token = "0x4000777")]
		public static BaseRenderFunc<PostProcessingFinalSetupPassData, RasterGraphContext> <>9__95_0; //Field offset: 0x98
		[Token(Token = "0x4000778")]
		public static BaseRenderFunc<PostProcessingFinalFSRScalePassData, RasterGraphContext> <>9__97_0; //Field offset: 0xA0
		[Token(Token = "0x4000779")]
		public static BaseRenderFunc<PostProcessingFinalBlitPassData, RasterGraphContext> <>9__100_0; //Field offset: 0xA8
		[Token(Token = "0x400077A")]
		public static BaseRenderFunc<UberPostPassData, RasterGraphContext> <>9__104_0; //Field offset: 0xB0
		[Token(Token = "0x400077B")]
		public static BaseRenderFunc<PostFXSetupPassData, RasterGraphContext> <>9__106_0; //Field offset: 0xB8

		[Address(RVA = "0x2DE5220", Offset = "0x2DE4620", Length = "0x67")]
		[Token(Token = "0x6000790")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000791")]
		public <>c() { }

		[Address(RVA = "0x2DDE900", Offset = "0x2DDDD00", Length = "0x54D")]
		[Token(Token = "0x600079A")]
		internal void <BloomDual>b__66_0(BloomPassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2DDEE50", Offset = "0x2DDE250", Length = "0x66A")]
		[Token(Token = "0x6000798")]
		internal void <BloomGaussian>b__64_0(BloomPassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2DDF4C0", Offset = "0x2DDE8C0", Length = "0x3D2")]
		[Token(Token = "0x6000799")]
		internal void <BloomKawase>b__65_0(BloomPassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2DDF8A0", Offset = "0x2DDECA0", Length = "0x720")]
		[Token(Token = "0x600079F")]
		internal void <LensFlareDataDrivenComputeOcclusion>b__86_0(LensFlarePassData data, UnsafeGraphContext ctx) { }

		[Address(RVA = "0x2DE0930", Offset = "0x2DDFD30", Length = "0x8BB")]
		[Token(Token = "0x600079C")]
		internal void <RenderDoFBokeh>b__73_0(DoFBokehPassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2DE11F0", Offset = "0x2DE05F0", Length = "0xBDF")]
		[Token(Token = "0x600079B")]
		internal void <RenderDoFGaussian>b__69_0(DoFGaussianPassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2DE1DD0", Offset = "0x2DE11D0", Length = "0x6C5")]
		[Token(Token = "0x60007A6")]
		internal void <RenderFinalBlit>b__100_0(PostProcessingFinalBlitPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE24A0", Offset = "0x2DE18A0", Length = "0x22B")]
		[Token(Token = "0x60007A5")]
		internal void <RenderFinalFSRScale>b__97_0(PostProcessingFinalFSRScalePassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE26D0", Offset = "0x2DE1AD0", Length = "0x13C")]
		[Token(Token = "0x60007A4")]
		internal void <RenderFinalSetup>b__95_0(PostProcessingFinalSetupPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE2810", Offset = "0x2DE1C10", Length = "0x895")]
		[Token(Token = "0x60007A0")]
		internal void <RenderLensFlareDataDriven>b__87_0(LensFlarePassData data, UnsafeGraphContext ctx) { }

		[Address(RVA = "0x2DE30B0", Offset = "0x2DE24B0", Length = "0x32")]
		[Token(Token = "0x60007A1")]
		internal float <RenderLensFlareDataDriven>b__87_1(Light light, Camera cam, Vector3 wo) { }

		[Address(RVA = "0x2DE30B0", Offset = "0x2DE24B0", Length = "0x32")]
		[Token(Token = "0x60007A2")]
		internal float <RenderLensFlareDataDriven>b__87_2(Light light, Camera cam, Vector3 wo) { }

		[Address(RVA = "0x2DE30F0", Offset = "0x2DE24F0", Length = "0x5FC")]
		[Token(Token = "0x60007A3")]
		internal void <RenderLensFlareScreenSpace>b__90_0(LensFlareScreenSpacePassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2DE36F0", Offset = "0x2DE2AF0", Length = "0x2DB")]
		[Token(Token = "0x600079E")]
		internal void <RenderMotionBlur>b__83_0(MotionBlurPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE39D0", Offset = "0x2DE2DD0", Length = "0x22A")]
		[Token(Token = "0x600079D")]
		internal void <RenderPaniniProjection>b__75_0(PaniniProjectionPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE3C00", Offset = "0x2DE3000", Length = "0x10C")]
		[Token(Token = "0x60007A8")]
		internal void <RenderPostProcessingRenderGraph>b__106_0(PostFXSetupPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE3D10", Offset = "0x2DE3110", Length = "0x1E4")]
		[Token(Token = "0x6000794")]
		internal void <RenderSMAA>b__56_0(SMAASetupPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE3F00", Offset = "0x2DE3300", Length = "0x190")]
		[Token(Token = "0x6000795")]
		internal void <RenderSMAA>b__56_1(SMAAPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE40A0", Offset = "0x2DE34A0", Length = "0x196")]
		[Token(Token = "0x6000796")]
		internal void <RenderSMAA>b__56_2(SMAAPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE4240", Offset = "0x2DE3640", Length = "0x20F")]
		[Token(Token = "0x6000797")]
		internal void <RenderSMAA>b__56_3(SMAAPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE4450", Offset = "0x2DE3850", Length = "0x18C")]
		[Token(Token = "0x6000793")]
		internal void <RenderStopNaN>b__53_0(StopNaNsPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE4A70", Offset = "0x2DE3E70", Length = "0x3A2")]
		[Token(Token = "0x60007A7")]
		internal void <RenderUberPost>b__104_0(UberPostPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DE4E20", Offset = "0x2DE4220", Length = "0xD7")]
		[Token(Token = "0x6000792")]
		internal void <UpdateCameraResolution>b__45_0(UpdateCameraResolutionPassData data, UnsafeGraphContext ctx) { }

	}

	[Token(Token = "0x200013E")]
	public struct BloomMaterialParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006FF")]
		internal Vector4 parameters; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000700")]
		internal Vector4 parameters2; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000701")]
		internal BloomFilterMode bloomFilter; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000702")]
		internal bool highQualityFiltering; //Field offset: 0x24
		[FieldOffset(Offset = "0x25")]
		[Token(Token = "0x4000703")]
		internal bool enableAlphaOutput; //Field offset: 0x25

		[Address(RVA = "0x2DC96E0", Offset = "0x2DC8AE0", Length = "0x101")]
		[Token(Token = "0x6000783")]
		internal bool Equals(ref BloomMaterialParams other) { }

	}

	[Token(Token = "0x200013D")]
	private class BloomPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006F9")]
		internal int mipCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006FA")]
		internal Material material; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006FB")]
		internal Material[] upsampleMaterials; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006FC")]
		internal TextureHandle sourceTexture; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006FD")]
		internal TextureHandle[] bloomMipUp; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006FE")]
		internal TextureHandle[] bloomMipDown; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000782")]
		public BloomPassData() { }

	}

	[Token(Token = "0x2000137")]
	public static class Constants
	{
		[Token(Token = "0x40006DA")]
		public const int k_MaxPyramidSize = 16; //Field offset: 0x0
		[Token(Token = "0x40006DB")]
		public const int k_GaussianDoFPassComputeCoc = 0; //Field offset: 0x0
		[Token(Token = "0x40006DC")]
		public const int k_GaussianDoFPassDownscalePrefilter = 1; //Field offset: 0x0
		[Token(Token = "0x40006DD")]
		public const int k_GaussianDoFPassBlurH = 2; //Field offset: 0x0
		[Token(Token = "0x40006DE")]
		public const int k_GaussianDoFPassBlurV = 3; //Field offset: 0x0
		[Token(Token = "0x40006DF")]
		public const int k_GaussianDoFPassComposite = 4; //Field offset: 0x0
		[Token(Token = "0x40006E0")]
		public const int k_BokehDoFPassComputeCoc = 0; //Field offset: 0x0
		[Token(Token = "0x40006E1")]
		public const int k_BokehDoFPassDownscalePrefilter = 1; //Field offset: 0x0
		[Token(Token = "0x40006E2")]
		public const int k_BokehDoFPassBlur = 2; //Field offset: 0x0
		[Token(Token = "0x40006E3")]
		public const int k_BokehDoFPassPostFilter = 3; //Field offset: 0x0
		[Token(Token = "0x40006E4")]
		public const int k_BokehDoFPassComposite = 4; //Field offset: 0x0

	}

	[Token(Token = "0x2000140")]
	private class DoFBokehPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000712")]
		internal Vector4[] bokehKernel; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000713")]
		internal int downSample; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000714")]
		internal float uvMargin; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000715")]
		internal Vector4 cocParams; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000716")]
		internal bool useFastSRGBLinearConversion; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000717")]
		internal TextureHandle sourceTexture; //Field offset: 0x34
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000718")]
		internal TextureHandle depthTexture; //Field offset: 0x44
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000719")]
		internal Material material; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400071A")]
		internal Material materialCoC; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400071B")]
		internal TextureHandle halfCoCTexture; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400071C")]
		internal TextureHandle fullCoCTexture; //Field offset: 0x78
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400071D")]
		internal TextureHandle pingTexture; //Field offset: 0x88
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400071E")]
		internal TextureHandle pongTexture; //Field offset: 0x98
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400071F")]
		internal TextureHandle destination; //Field offset: 0xA8

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000785")]
		public DoFBokehPassData() { }

	}

	[Token(Token = "0x200013F")]
	private class DoFGaussianPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000704")]
		internal int downsample; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000705")]
		internal RenderingData renderingData; //Field offset: 0x18
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000706")]
		internal Vector3 cocParams; //Field offset: 0x40
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000707")]
		internal bool highQualitySamplingValue; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000708")]
		internal TextureHandle sourceTexture; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000709")]
		internal TextureHandle depthTexture; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400070A")]
		internal Material material; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400070B")]
		internal Material materialCoC; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400070C")]
		internal TextureHandle halfCoCTexture; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400070D")]
		internal TextureHandle fullCoCTexture; //Field offset: 0x90
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400070E")]
		internal TextureHandle pingTexture; //Field offset: 0xA0
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400070F")]
		internal TextureHandle pongTexture; //Field offset: 0xB0
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000710")]
		internal RenderTargetIdentifier[] multipleRenderTargets; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000711")]
		internal TextureHandle destination; //Field offset: 0xC8

		[Address(RVA = "0x2DC9820", Offset = "0x2DC8C20", Length = "0x5B")]
		[Token(Token = "0x6000784")]
		public DoFGaussianPassData() { }

	}

	[Token(Token = "0x2000148")]
	internal struct FinalBlitSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000750")]
		public bool isFxaaEnabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000751")]
		public bool isFsrEnabled; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000752")]
		public bool isTaaSharpeningEnabled; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x4000753")]
		public bool requireHDROutput; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000754")]
		public bool isAlphaOutputEnabled; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000755")]
		public Operation hdrOperations; //Field offset: 0x8

		[Address(RVA = "0x2DC98B0", Offset = "0x2DC8CB0", Length = "0xC")]
		[Token(Token = "0x600078D")]
		public static FinalBlitSettings Create() { }

	}

	[Token(Token = "0x2000143")]
	private class LensFlarePassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400072E")]
		internal TextureHandle destinationTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400072F")]
		internal UniversalCameraData cameraData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000730")]
		internal Material material; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000731")]
		internal Rect viewport; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000732")]
		internal float paniniDistance; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000733")]
		internal float paniniCropToFit; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000734")]
		internal float width; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000735")]
		internal float height; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000736")]
		internal bool usePanini; //Field offset: 0x50

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000788")]
		public LensFlarePassData() { }

	}

	[Token(Token = "0x2000144")]
	private class LensFlareScreenSpacePassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000737")]
		internal TextureHandle streakTmpTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000738")]
		internal TextureHandle streakTmpTexture2; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000739")]
		internal TextureHandle originalBloomTexture; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400073A")]
		internal TextureHandle screenSpaceLensFlareBloomMipTexture; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400073B")]
		internal TextureHandle result; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400073C")]
		internal int actualWidth; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400073D")]
		internal int actualHeight; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400073E")]
		internal Camera camera; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400073F")]
		internal Material material; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000740")]
		internal ScreenSpaceLensFlare lensFlareScreenSpace; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000741")]
		internal int downsample; //Field offset: 0x80

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000789")]
		public LensFlareScreenSpacePassData() { }

	}

	[Token(Token = "0x2000142")]
	private class MotionBlurPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000725")]
		internal TextureHandle sourceTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000726")]
		internal TextureHandle motionVectors; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000727")]
		internal Material material; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000728")]
		internal int passIndex; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000729")]
		internal Camera camera; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400072A")]
		internal XRPass xr; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400072B")]
		internal float intensity; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x400072C")]
		internal float clamp; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400072D")]
		internal bool enableAlphaOutput; //Field offset: 0x58

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000787")]
		public MotionBlurPassData() { }

	}

	[Token(Token = "0x2000141")]
	private class PaniniProjectionPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000720")]
		internal TextureHandle destinationTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000721")]
		internal TextureHandle sourceTexture; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000722")]
		internal Material material; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000723")]
		internal Vector4 paniniParams; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000724")]
		internal bool isPaniniGeneric; //Field offset: 0x48

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000786")]
		public PaniniProjectionPassData() { }

	}

	[Token(Token = "0x200014A")]
	private class PostFXSetupPassData
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600078F")]
		public PostFXSetupPassData() { }

	}

	[Token(Token = "0x2000147")]
	private class PostProcessingFinalBlitPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400074B")]
		internal TextureHandle destinationTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400074C")]
		internal TextureHandle sourceTexture; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400074D")]
		internal Material material; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400074E")]
		internal UniversalCameraData cameraData; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400074F")]
		internal FinalBlitSettings settings; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600078C")]
		public PostProcessingFinalBlitPassData() { }

	}

	[Token(Token = "0x2000146")]
	private class PostProcessingFinalFSRScalePassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000746")]
		internal TextureHandle sourceTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000747")]
		internal Material material; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000748")]
		internal bool enableAlphaOutput; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000749")]
		internal Vector2 fsrInputSize; //Field offset: 0x2C
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400074A")]
		internal Vector2 fsrOutputSize; //Field offset: 0x34

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600078B")]
		public PostProcessingFinalFSRScalePassData() { }

	}

	[Token(Token = "0x2000145")]
	private class PostProcessingFinalSetupPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000742")]
		internal TextureHandle destinationTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000743")]
		internal TextureHandle sourceTexture; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000744")]
		internal Material material; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000745")]
		internal UniversalCameraData cameraData; //Field offset: 0x38

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600078A")]
		public PostProcessingFinalSetupPassData() { }

	}

	[Token(Token = "0x2000136")]
	public static class ShaderConstants
	{
		[Token(Token = "0x40006B4")]
		public static readonly int _CameraDepthTextureID; //Field offset: 0x0
		[Token(Token = "0x40006B5")]
		public static readonly int _StencilRef; //Field offset: 0x4
		[Token(Token = "0x40006B6")]
		public static readonly int _StencilMask; //Field offset: 0x8
		[Token(Token = "0x40006B7")]
		public static readonly int _ColorTexture; //Field offset: 0xC
		[Token(Token = "0x40006B8")]
		public static readonly int _Params; //Field offset: 0x10
		[Token(Token = "0x40006B9")]
		public static readonly int _Params2; //Field offset: 0x14
		[Token(Token = "0x40006BA")]
		public static readonly int _ViewProjM; //Field offset: 0x18
		[Token(Token = "0x40006BB")]
		public static readonly int _PrevViewProjM; //Field offset: 0x1C
		[Token(Token = "0x40006BC")]
		public static readonly int _ViewProjMStereo; //Field offset: 0x20
		[Token(Token = "0x40006BD")]
		public static readonly int _PrevViewProjMStereo; //Field offset: 0x24
		[Token(Token = "0x40006BE")]
		public static readonly int _FullscreenProjMat; //Field offset: 0x28
		[Token(Token = "0x40006BF")]
		public static readonly int _FullCoCTexture; //Field offset: 0x2C
		[Token(Token = "0x40006C0")]
		public static readonly int _HalfCoCTexture; //Field offset: 0x30
		[Token(Token = "0x40006C1")]
		public static readonly int _DofTexture; //Field offset: 0x34
		[Token(Token = "0x40006C2")]
		public static readonly int _CoCParams; //Field offset: 0x38
		[Token(Token = "0x40006C3")]
		public static readonly int _BokehKernel; //Field offset: 0x3C
		[Token(Token = "0x40006C4")]
		public static readonly int _BokehConstants; //Field offset: 0x40
		[Token(Token = "0x40006C5")]
		public static readonly int _DownSampleScaleFactor; //Field offset: 0x44
		[Token(Token = "0x40006C6")]
		public static readonly int _Metrics; //Field offset: 0x48
		[Token(Token = "0x40006C7")]
		public static readonly int _AreaTexture; //Field offset: 0x4C
		[Token(Token = "0x40006C8")]
		public static readonly int _SearchTexture; //Field offset: 0x50
		[Token(Token = "0x40006C9")]
		public static readonly int _BlendTexture; //Field offset: 0x54
		[Token(Token = "0x40006CA")]
		public static readonly int _SourceTexLowMip; //Field offset: 0x58
		[Token(Token = "0x40006CB")]
		public static readonly int _Bloom_Params; //Field offset: 0x5C
		[Token(Token = "0x40006CC")]
		public static readonly int _Bloom_Texture; //Field offset: 0x60
		[Token(Token = "0x40006CD")]
		public static readonly int _LensDirt_Texture; //Field offset: 0x64
		[Token(Token = "0x40006CE")]
		public static readonly int _LensDirt_Params; //Field offset: 0x68
		[Token(Token = "0x40006CF")]
		public static readonly int _LensDirt_Intensity; //Field offset: 0x6C
		[Token(Token = "0x40006D0")]
		public static readonly int _Distortion_Params1; //Field offset: 0x70
		[Token(Token = "0x40006D1")]
		public static readonly int _Distortion_Params2; //Field offset: 0x74
		[Token(Token = "0x40006D2")]
		public static readonly int _Chroma_Params; //Field offset: 0x78
		[Token(Token = "0x40006D3")]
		public static readonly int _Vignette_Params1; //Field offset: 0x7C
		[Token(Token = "0x40006D4")]
		public static readonly int _Vignette_Params2; //Field offset: 0x80
		[Token(Token = "0x40006D5")]
		public static readonly int _Vignette_ParamsXR; //Field offset: 0x84
		[Token(Token = "0x40006D6")]
		public static readonly int _InternalLut; //Field offset: 0x88
		[Token(Token = "0x40006D7")]
		public static readonly int _Lut_Params; //Field offset: 0x8C
		[Token(Token = "0x40006D8")]
		public static readonly int _UserLut; //Field offset: 0x90
		[Token(Token = "0x40006D9")]
		public static readonly int _UserLut_Params; //Field offset: 0x94

		[Address(RVA = "0x2DDCA30", Offset = "0x2DDBE30", Length = "0x69C")]
		[Token(Token = "0x600077C")]
		private static ShaderConstants() { }

	}

	[Token(Token = "0x200013B")]
	private class SMAAPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006EF")]
		internal TextureHandle sourceTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006F0")]
		internal TextureHandle blendTexture; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006F1")]
		internal Material material; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000780")]
		public SMAAPassData() { }

	}

	[Token(Token = "0x200013A")]
	private class SMAASetupPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006E8")]
		internal Vector4 metrics; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006E9")]
		internal Texture2D areaTexture; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006EA")]
		internal Texture2D searchTexture; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006EB")]
		internal float stencilRef; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40006EC")]
		internal float stencilMask; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006ED")]
		internal AntialiasingQuality antialiasingQuality; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006EE")]
		internal Material material; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600077F")]
		public SMAASetupPassData() { }

	}

	[Token(Token = "0x2000139")]
	private class StopNaNsPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006E6")]
		internal TextureHandle sourceTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006E7")]
		internal Material stopNaN; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600077E")]
		public StopNaNsPassData() { }

	}

	[Token(Token = "0x2000149")]
	private class UberPostPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000756")]
		internal TextureHandle destinationTexture; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000757")]
		internal TextureHandle sourceTexture; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000758")]
		internal TextureHandle lutTexture; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000759")]
		internal TextureHandle bloomTexture; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400075A")]
		internal Vector4 lutParams; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400075B")]
		internal TextureHandle userLutTexture; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400075C")]
		internal Vector4 userLutParams; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400075D")]
		internal Material material; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400075E")]
		internal UniversalCameraData cameraData; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400075F")]
		internal TonemappingMode toneMappingMode; //Field offset: 0x90
		[FieldOffset(Offset = "0x94")]
		[Token(Token = "0x4000760")]
		internal bool isHdrGrading; //Field offset: 0x94
		[FieldOffset(Offset = "0x95")]
		[Token(Token = "0x4000761")]
		internal bool isBackbuffer; //Field offset: 0x95
		[FieldOffset(Offset = "0x96")]
		[Token(Token = "0x4000762")]
		internal bool enableAlphaOutput; //Field offset: 0x96
		[FieldOffset(Offset = "0x97")]
		[Token(Token = "0x4000763")]
		internal bool hasFinalPass; //Field offset: 0x97

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600078E")]
		public UberPostPassData() { }

	}

	[Token(Token = "0x200013C")]
	private class UberSetupBloomPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006F2")]
		internal Vector4 bloomParams; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006F3")]
		internal Vector4 dirtScaleOffset; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006F4")]
		internal float dirtIntensity; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006F5")]
		internal Texture dirtTexture; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006F6")]
		internal bool highQualityFilteringValue; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40006F7")]
		internal TextureHandle bloomTexture; //Field offset: 0x44
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40006F8")]
		internal Material uberMaterial; //Field offset: 0x58

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000781")]
		public UberSetupBloomPassData() { }

	}

	[Token(Token = "0x2000138")]
	private class UpdateCameraResolutionPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006E5")]
		internal Vector2Int newCameraTargetSize; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600077D")]
		public UpdateCameraResolutionPassData() { }

	}

	[Token(Token = "0x40006B3")]
	private const string _UpscaledColorTargetName = "_CameraColorUpscaledSTP"; //Field offset: 0x0
	[Token(Token = "0x40006B2")]
	private const string _TemporalAATargetName = "_TemporalAATarget"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400068F")]
	private PostProcessMaterialLibrary m_Materials; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000690")]
	private DepthOfField m_DepthOfField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000691")]
	private MotionBlur m_MotionBlur; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000692")]
	private PaniniProjection m_PaniniProjection; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000693")]
	private Bloom m_Bloom; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000694")]
	private ScreenSpaceLensFlare m_LensFlareScreenSpace; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000695")]
	private LensDistortion m_LensDistortion; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000696")]
	private ChromaticAberration m_ChromaticAberration; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000697")]
	private Vignette m_Vignette; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000698")]
	private ColorLookup m_ColorLookup; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000699")]
	private ColorAdjustments m_ColorAdjustments; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400069A")]
	private Tonemapping m_Tonemapping; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400069B")]
	private FilmGrain m_FilmGrain; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400069C")]
	private String[] m_BloomMipDownName; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400069D")]
	private String[] m_BloomMipUpName; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400069E")]
	private TextureHandle[] _BloomMipUp; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400069F")]
	private TextureHandle[] _BloomMipDown; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40006A0")]
	private RTHandle m_UserLut; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40006A1")]
	private RTHandle m_InternalLut; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40006A2")]
	private readonly GraphicsFormat m_SMAAEdgeFormat; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40006A3")]
	private readonly GraphicsFormat m_BloomColorFormat; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40006A4")]
	private BloomMaterialParams m_BloomParamsPrev; //Field offset: 0xB0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40006A5")]
	private readonly GraphicsFormat m_GaussianCoCFormat; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40006A6")]
	private readonly GraphicsFormat m_GaussianDoFColorFormat; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40006A7")]
	private Vector4[] m_BokehKernel; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40006A8")]
	private int m_BokehHash; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x40006A9")]
	private float m_BokehMaxRadius; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40006AA")]
	private float m_BokehRCPAspect; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x40006AB")]
	private readonly GraphicsFormat m_LensFlareScreenSpaceColorFormat; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40006AC")]
	private int m_DitheringTextureIndex; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x40006AD")]
	private bool m_HasFinalPass; //Field offset: 0xFC
	[FieldOffset(Offset = "0xFD")]
	[Token(Token = "0x40006AE")]
	private bool m_EnableColorEncodingIfNeeded; //Field offset: 0xFD
	[FieldOffset(Offset = "0xFE")]
	[Token(Token = "0x40006AF")]
	private bool m_UseFastSRGBLinearConversion; //Field offset: 0xFE
	[FieldOffset(Offset = "0xFF")]
	[Token(Token = "0x40006B0")]
	private bool m_SupportScreenSpaceLensFlare; //Field offset: 0xFF
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40006B1")]
	private bool m_SupportDataDrivenLensFlare; //Field offset: 0x100

	[Address(RVA = "0x2DC4930", Offset = "0x2DC3D30", Length = "0x377")]
	[Token(Token = "0x6000745")]
	public PostProcessPassRenderGraph(PostProcessData data, GraphicsFormat requestPostProColorFormat) { }

	[Address(RVA = "0x2DB53C0", Offset = "0x2DB47C0", Length = "0x5C3")]
	[Token(Token = "0x600075B")]
	private TextureHandle BloomDual(RenderGraph renderGraph, TextureHandle source, int mipCount) { }

	[Address(RVA = "0x2DB5990", Offset = "0x2DB4D90", Length = "0x5C3")]
	[Token(Token = "0x6000759")]
	private TextureHandle BloomGaussian(RenderGraph renderGraph, TextureHandle source, int mipCount) { }

	[Address(RVA = "0x2DB5F60", Offset = "0x2DB5360", Length = "0x4AF")]
	[Token(Token = "0x600075A")]
	private TextureHandle BloomKawase(RenderGraph renderGraph, TextureHandle source, int mipCount) { }

	[Address(RVA = "0x2DB6410", Offset = "0x2DB5810", Length = "0x118")]
	[Token(Token = "0x6000757")]
	public int CalcBloomMipCount(Bloom bloom, Vector2Int bloomResolution) { }

	[Address(RVA = "0x2DB6530", Offset = "0x2DB5930", Length = "0xB0")]
	[Token(Token = "0x6000756")]
	public Vector2Int CalcBloomResolution(Bloom bloom, in TextureDesc bloomSourceDesc) { }

	[Address(RVA = "0x2DB65F0", Offset = "0x2DB59F0", Length = "0xE3")]
	[Token(Token = "0x6000763")]
	private static Vector2 CalcCropExtents(Camera camera, float d, int width, int height) { }

	[Address(RVA = "0x2DB66E0", Offset = "0x2DB5AE0", Length = "0x5E")]
	[Token(Token = "0x6000762")]
	private static Vector2 CalcViewExtents(Camera camera, int width, int height) { }

	[Address(RVA = "0x2DB6740", Offset = "0x2DB5B40", Length = "0x3C")]
	[Token(Token = "0x6000746")]
	public void Cleanup() { }

	[Address(RVA = "0x2DB6890", Offset = "0x2DB5C90", Length = "0x15D")]
	[Token(Token = "0x600074D")]
	internal static TextureHandle CreateCompatibleTexture(RenderGraph renderGraph, in TextureHandle source, string name, bool clear, FilterMode filterMode) { }

	[Address(RVA = "0x2DB6780", Offset = "0x2DB5B80", Length = "0x104")]
	[Token(Token = "0x600074E")]
	internal static TextureHandle CreateCompatibleTexture(RenderGraph renderGraph, in TextureDesc desc, string name, bool clear, FilterMode filterMode) { }

	[Address(RVA = "0x2DB69F0", Offset = "0x2DB5DF0", Length = "0x14")]
	[Token(Token = "0x6000747")]
	public void Dispose() { }

	[Address(RVA = "0x2DB6A80", Offset = "0x2DB5E80", Length = "0x5E")]
	[Token(Token = "0x6000752")]
	internal static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, GraphicsFormat depthStencilFormat = 0) { }

	[Address(RVA = "0x2DB6AE0", Offset = "0x2DB5EE0", Length = "0x5A")]
	[Token(Token = "0x6000750")]
	internal static TextureDesc GetCompatibleDescriptor(TextureDesc desc) { }

	[Address(RVA = "0x2DB6A10", Offset = "0x2DB5E10", Length = "0x69")]
	[Token(Token = "0x600074F")]
	internal static TextureDesc GetCompatibleDescriptor(TextureDesc desc, int width, int height, GraphicsFormat format) { }

	[Address(RVA = "0x2DB6B40", Offset = "0x2DB5F40", Length = "0x236")]
	[Token(Token = "0x600076A")]
	private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo) { }

	[Address(RVA = "0x2DB6D80", Offset = "0x2DB6180", Length = "0x1B")]
	[Token(Token = "0x600075F")]
	private static float GetMaxBokehRadiusInPixels(float viewportHeight) { }

	[Address(RVA = "0x2DB6DA0", Offset = "0x2DB61A0", Length = "0x47")]
	[Token(Token = "0x6000749")]
	private static bool IsAlphaFormat(GraphicsFormat format) { }

	[Address(RVA = "0x2DB6DF0", Offset = "0x2DB61F0", Length = "0x76")]
	[Token(Token = "0x6000748")]
	private static bool IsHDRFormat(GraphicsFormat format) { }

	[Address(RVA = "0x2DB6E70", Offset = "0x2DB6270", Length = "0x649")]
	[Token(Token = "0x6000768")]
	private void LensFlareDataDrivenComputeOcclusion(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureDesc srcDesc) { }

	[Address(RVA = "0x2DB74C0", Offset = "0x2DB68C0", Length = "0x19")]
	[Token(Token = "0x6000751")]
	internal static void MakeCompatible(ref TextureDesc desc) { }

	[Address(RVA = "0x2DB74E0", Offset = "0x2DB68E0", Length = "0x3EF")]
	[Token(Token = "0x600075E")]
	private void PrepareBokehKernel(float maxRadius, float rcpAspect) { }

	[Address(RVA = "0x2DB78D0", Offset = "0x2DB6CD0", Length = "0xF56")]
	[Token(Token = "0x6000758")]
	public void RenderBloomTexture(RenderGraph renderGraph, in TextureHandle source, out TextureHandle destination, bool enableAlphaOutput) { }

	[Address(RVA = "0x2DBA690", Offset = "0x2DB9A90", Length = "0x240")]
	[Token(Token = "0x600075C")]
	public void RenderDoF(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, out TextureHandle destination) { }

	[Address(RVA = "0x2DB8830", Offset = "0x2DB7C30", Length = "0xEBE")]
	[Token(Token = "0x6000760")]
	public void RenderDoFBokeh(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle destination, ref Material dofMaterial) { }

	[Address(RVA = "0x2DB96F0", Offset = "0x2DB8AF0", Length = "0xF9D")]
	[Token(Token = "0x600075D")]
	public void RenderDoFGaussian(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, TextureHandle destination, ref Material dofMaterial) { }

	[Address(RVA = "0x2DBA8E0", Offset = "0x2DB9CE0", Length = "0x653")]
	[Token(Token = "0x6000771")]
	public void RenderFinalBlit(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, ref FinalBlitSettings settings) { }

	[Address(RVA = "0x2DBAF40", Offset = "0x2DBA340", Length = "0x4F8")]
	[Token(Token = "0x6000770")]
	public void RenderFinalFSRScale(RenderGraph renderGraph, in TextureHandle source, in TextureDesc srcDesc, in TextureHandle destination, in TextureDesc dstDesc, bool enableAlphaOutput) { }

	[Address(RVA = "0x2DBB440", Offset = "0x2DBA840", Length = "0x903")]
	[Token(Token = "0x6000772")]
	public void RenderFinalPassRenderGraph(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle source, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, bool enableColorEncodingIfNeeded) { }

	[Address(RVA = "0x2DBBD50", Offset = "0x2DBB150", Length = "0x638")]
	[Token(Token = "0x600076F")]
	public void RenderFinalSetup(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle destination, ref FinalBlitSettings settings) { }

	[Address(RVA = "0x2DBC390", Offset = "0x2DBB790", Length = "0x711")]
	[Token(Token = "0x6000769")]
	public void RenderLensFlareDataDriven(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle destination, in TextureDesc srcDesc) { }

	[Address(RVA = "0x2DBCAB0", Offset = "0x2DBBEB0", Length = "0xAC8")]
	[Token(Token = "0x600076B")]
	public TextureHandle RenderLensFlareScreenSpace(RenderGraph renderGraph, Camera camera, in TextureDesc srcDesc, TextureHandle originalBloomTexture, TextureHandle screenSpaceLensFlareBloomMipTexture, bool sameBloomInputOutputTex) { }

	[Address(RVA = "0x2DBD580", Offset = "0x2DBC980", Length = "0x88D")]
	[Token(Token = "0x6000766")]
	public void RenderMotionBlur(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, out TextureHandle destination) { }

	[Address(RVA = "0x2DBDE10", Offset = "0x2DBD210", Length = "0x724")]
	[Token(Token = "0x6000761")]
	public void RenderPaniniProjection(RenderGraph renderGraph, Camera camera, in TextureHandle source, out TextureHandle destination) { }

	[Address(RVA = "0x2DBE540", Offset = "0x2DBD940", Length = "0x1710")]
	[Token(Token = "0x6000775")]
	public void RenderPostProcessingRenderGraph(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle activeCameraColorTexture, in TextureHandle lutTexture, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, bool hasFinalPass, bool resolveToDebugScreen, bool enableColorEndingIfNeeded) { }

	[Address(RVA = "0x2DBFC60", Offset = "0x2DBF060", Length = "0x161F")]
	[Token(Token = "0x6000754")]
	public void RenderSMAA(RenderGraph renderGraph, UniversalResourceData resourceData, AntialiasingQuality antialiasingQuality, in TextureHandle source, out TextureHandle SMAATarget) { }

	[Address(RVA = "0x2DC16C0", Offset = "0x2DC0AC0", Length = "0x454")]
	[Token(Token = "0x6000753")]
	public void RenderStopNaN(RenderGraph renderGraph, in TextureHandle activeCameraColor, out TextureHandle stopNaNTarget) { }

	[Address(RVA = "0x2DC1280", Offset = "0x2DC0680", Length = "0x435")]
	[Token(Token = "0x6000765")]
	private void RenderSTP(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, ref TextureHandle source, out TextureHandle destination) { }

	[Address(RVA = "0x2DC1B20", Offset = "0x2DC0F20", Length = "0x152")]
	[Token(Token = "0x6000764")]
	private void RenderTemporalAA(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, ref TextureHandle source, out TextureHandle destination) { }

	[Address(RVA = "0x2DC1C80", Offset = "0x2DC1080", Length = "0xC1C")]
	[Token(Token = "0x6000774")]
	public void RenderUberPost(RenderGraph renderGraph, ContextContainer frameData, UniversalCameraData cameraData, UniversalPostProcessingData postProcessingData, in TextureHandle sourceTexture, in TextureHandle destTexture, in TextureHandle lutTexture, in TextureHandle bloomTexture, in TextureHandle overlayUITexture, bool requireHDROutput, bool enableAlphaOutput, bool hasFinalPass) { }

	[Address(RVA = "0x2DC28A0", Offset = "0x2DC1CA0", Length = "0x35")]
	[Token(Token = "0x600074B")]
	private static bool RequireHDROutput(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DC28E0", Offset = "0x2DC1CE0", Length = "0xF")]
	[Token(Token = "0x600074A")]
	private bool RequireSRGBConversionBlitToBackBuffer(bool requireSrgbConversion) { }

	[Address(RVA = "0x2DC2D10", Offset = "0x2DC2110", Length = "0x25B")]
	[Token(Token = "0x600076C")]
	private static void ScaleViewport(RasterCommandBuffer cmd, RTHandle sourceTextureHdl, RTHandle dest, UniversalCameraData cameraData, bool hasFinalPass) { }

	[Address(RVA = "0x2DC28F0", Offset = "0x2DC1CF0", Length = "0x184")]
	[Token(Token = "0x600076D")]
	private static void ScaleViewportAndBlit(in RasterGraphContext context, in TextureHandle source, in TextureHandle destination, UniversalCameraData cameraData, Material material, bool hasFinalPass) { }

	[Address(RVA = "0x2DC2A80", Offset = "0x2DC1E80", Length = "0x288")]
	[Token(Token = "0x600076E")]
	private static void ScaleViewportAndDrawVisibilityMesh(in RasterGraphContext context, in TextureHandle source, in TextureHandle destination, UniversalCameraData cameraData, Material material, bool hasFinalPass) { }

	[Address(RVA = "0x2DC2F70", Offset = "0x2DC2370", Length = "0x100")]
	[Token(Token = "0x6000777")]
	private void SetupChromaticAberration(Material material) { }

	[Address(RVA = "0x2DC3080", Offset = "0x2DC2480", Length = "0xB4")]
	[Token(Token = "0x600077A")]
	private void SetupDithering(UniversalCameraData cameraData, Material material) { }

	[Address(RVA = "0x2DC3140", Offset = "0x2DC2540", Length = "0xB7")]
	[Token(Token = "0x6000779")]
	private void SetupGrain(UniversalCameraData cameraData, Material material) { }

	[Address(RVA = "0x2DC3200", Offset = "0x2DC2600", Length = "0x156")]
	[Token(Token = "0x600077B")]
	private void SetupHDROutput(HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, Operation hdrOperations, bool rendersOverlayUI) { }

	[Address(RVA = "0x2DC3360", Offset = "0x2DC2760", Length = "0x3E0")]
	[Token(Token = "0x6000776")]
	private void SetupLensDistortion(Material material, bool isSceneView) { }

	[Address(RVA = "0x2DC3750", Offset = "0x2DC2B50", Length = "0x354")]
	[Token(Token = "0x6000778")]
	private void SetupVignette(Material material, XRPass xrPass, int width, int height) { }

	[Address(RVA = "0x2DC3AB0", Offset = "0x2DC2EB0", Length = "0x25B")]
	[Token(Token = "0x6000773")]
	private TextureHandle TryGetCachedUserLutTextureHandle(RenderGraph renderGraph) { }

	[Address(RVA = "0x2DC3D10", Offset = "0x2DC3110", Length = "0x63F")]
	[Token(Token = "0x6000755")]
	public void UberPostSetupBloomPass(RenderGraph rendergraph, Material uberMaterial, in TextureDesc srcDesc) { }

	[Address(RVA = "0x2DC4350", Offset = "0x2DC3750", Length = "0x2E8")]
	[Token(Token = "0x600074C")]
	private void UpdateCameraResolution(RenderGraph renderGraph, UniversalCameraData cameraData, Vector2Int newCameraTargetSize) { }

	[Address(RVA = "0x2DC4640", Offset = "0x2DC3A40", Length = "0x2E8")]
	[Token(Token = "0x6000767")]
	internal static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr) { }

}

