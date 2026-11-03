namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x200020B")]
public class ColorGradingLutPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200020E")]
	private sealed class <>c
	{
		[Token(Token = "0x4000CE1")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000CE2")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__12_0; //Field offset: 0x8

		[Address(RVA = "0x2E35A30", Offset = "0x2E34E30", Length = "0x67")]
		[Token(Token = "0x6000B6C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B6D")]
		public <>c() { }

		[Address(RVA = "0x2E343A0", Offset = "0x2E337A0", Length = "0x87")]
		[Token(Token = "0x6000B6E")]
		internal void <Render>b__12_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x200020C")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CC3")]
		internal UniversalCameraData cameraData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CC4")]
		internal UniversalPostProcessingData postProcessingData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CC5")]
		internal Material lutBuilderLdr; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000CC6")]
		internal Material lutBuilderHdr; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000CC7")]
		internal bool allowColorGradingACESHDR; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000CC8")]
		internal TextureHandle internalLut; //Field offset: 0x34

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B6A")]
		public PassData() { }

	}

	[Token(Token = "0x200020D")]
	private static class ShaderConstants
	{
		[Token(Token = "0x4000CC9")]
		public static readonly int _Lut_Params; //Field offset: 0x0
		[Token(Token = "0x4000CCA")]
		public static readonly int _ColorBalance; //Field offset: 0x4
		[Token(Token = "0x4000CCB")]
		public static readonly int _ColorFilter; //Field offset: 0x8
		[Token(Token = "0x4000CCC")]
		public static readonly int _ChannelMixerRed; //Field offset: 0xC
		[Token(Token = "0x4000CCD")]
		public static readonly int _ChannelMixerGreen; //Field offset: 0x10
		[Token(Token = "0x4000CCE")]
		public static readonly int _ChannelMixerBlue; //Field offset: 0x14
		[Token(Token = "0x4000CCF")]
		public static readonly int _HueSatCon; //Field offset: 0x18
		[Token(Token = "0x4000CD0")]
		public static readonly int _Lift; //Field offset: 0x1C
		[Token(Token = "0x4000CD1")]
		public static readonly int _Gamma; //Field offset: 0x20
		[Token(Token = "0x4000CD2")]
		public static readonly int _Gain; //Field offset: 0x24
		[Token(Token = "0x4000CD3")]
		public static readonly int _Shadows; //Field offset: 0x28
		[Token(Token = "0x4000CD4")]
		public static readonly int _Midtones; //Field offset: 0x2C
		[Token(Token = "0x4000CD5")]
		public static readonly int _Highlights; //Field offset: 0x30
		[Token(Token = "0x4000CD6")]
		public static readonly int _ShaHiLimits; //Field offset: 0x34
		[Token(Token = "0x4000CD7")]
		public static readonly int _SplitShadows; //Field offset: 0x38
		[Token(Token = "0x4000CD8")]
		public static readonly int _SplitHighlights; //Field offset: 0x3C
		[Token(Token = "0x4000CD9")]
		public static readonly int _CurveMaster; //Field offset: 0x40
		[Token(Token = "0x4000CDA")]
		public static readonly int _CurveRed; //Field offset: 0x44
		[Token(Token = "0x4000CDB")]
		public static readonly int _CurveGreen; //Field offset: 0x48
		[Token(Token = "0x4000CDC")]
		public static readonly int _CurveBlue; //Field offset: 0x4C
		[Token(Token = "0x4000CDD")]
		public static readonly int _CurveHueVsHue; //Field offset: 0x50
		[Token(Token = "0x4000CDE")]
		public static readonly int _CurveHueVsSat; //Field offset: 0x54
		[Token(Token = "0x4000CDF")]
		public static readonly int _CurveLumVsSat; //Field offset: 0x58
		[Token(Token = "0x4000CE0")]
		public static readonly int _CurveSatVsSat; //Field offset: 0x5C

		[Address(RVA = "0x2E33E90", Offset = "0x2E33290", Length = "0x430")]
		[Token(Token = "0x6000B6B")]
		private static ShaderConstants() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000CBE")]
	private readonly Material m_LutBuilderLdr; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CBF")]
	private readonly Material m_LutBuilderHdr; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000CC0")]
	internal readonly GraphicsFormat m_HdrLutFormat; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000CC1")]
	internal readonly GraphicsFormat m_LdrLutFormat; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000CC2")]
	private bool m_AllowColorGradingACESHDR; //Field offset: 0x78

	[Address(RVA = "0x2E20090", Offset = "0x2E1F490", Length = "0x1A5")]
	[Token(Token = "0x6000B61")]
	public ColorGradingLutPass(RenderPassEvent evt, PostProcessData data) { }

	[Address(RVA = "0x2E1FFD0", Offset = "0x2E1F3D0", Length = "0xBE")]
	[CompilerGenerated]
	[Token(Token = "0x6000B69")]
	internal static Material <.ctor>g__Load|6_0(Shader shader) { }

	[Address(RVA = "0x2E1E190", Offset = "0x2E1D590", Length = "0x61")]
	[Token(Token = "0x6000B68")]
	public void Cleanup() { }

	[Address(RVA = "0x2E1E2B0", Offset = "0x2E1D6B0", Length = "0xC2")]
	[Token(Token = "0x6000B63")]
	public void ConfigureDescriptor(in PostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	[Address(RVA = "0x2E1E200", Offset = "0x2E1D600", Length = "0xA9")]
	[Token(Token = "0x6000B64")]
	public void ConfigureDescriptor(in UniversalPostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B60")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E1E380", Offset = "0x2E1D780", Length = "0x15D7")]
	[Token(Token = "0x6000B65")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle internalLutTarget) { }

	[Address(RVA = "0x2E1F960", Offset = "0x2E1ED60", Length = "0xAE")]
	[Token(Token = "0x6000B67")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x2E1FA10", Offset = "0x2E1EE10", Length = "0x5BE")]
	[Token(Token = "0x6000B66")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, out TextureHandle internalColorLut) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B62")]
	public void Setup(in RTHandle internalLut) { }

}

