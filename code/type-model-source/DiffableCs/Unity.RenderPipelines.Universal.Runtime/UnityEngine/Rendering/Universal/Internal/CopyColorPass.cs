namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x200020F")]
public class CopyColorPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000211")]
	private sealed class <>c
	{
		[Token(Token = "0x4000CF0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000CF1")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__17_0; //Field offset: 0x8

		[Address(RVA = "0x2E356B0", Offset = "0x2E34AB0", Length = "0x67")]
		[Token(Token = "0x6000B7C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B7D")]
		public <>c() { }

		[Address(RVA = "0x2E342C0", Offset = "0x2E336C0", Length = "0xD2")]
		[Token(Token = "0x6000B7E")]
		internal void <AddDownsampleAndCopyColorRenderPass>b__17_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000210")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CE9")]
		internal TextureHandle source; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CEA")]
		internal TextureHandle destination; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000CEB")]
		internal bool useProceduralBlit; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000CEC")]
		internal Material samplingMaterial; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000CED")]
		internal Material copyColorMaterial; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000CEE")]
		internal Downsampling downsamplingMethod; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000CEF")]
		internal int sampleOffsetShaderHandle; //Field offset: 0x4C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B7B")]
		public PassData() { }

	}

	[Token(Token = "0x4000CE7")]
	private static readonly string k_CopyColorPassName; //Field offset: 0x0
	[Token(Token = "0x4000CE8")]
	private static readonly string k_DownsampleAndCopyPassName; //Field offset: 0x8
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000CE3")]
	private int m_SampleOffsetShaderHandle; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CE4")]
	private Material m_SamplingMaterial; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000CE5")]
	private Downsampling m_DownsamplingMethod; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000CE6")]
	private Material m_CopyColorMaterial; //Field offset: 0x78

	[Address(RVA = "0x2E21280", Offset = "0x2E20680", Length = "0xA5")]
	[Token(Token = "0x6000B7A")]
	private static CopyColorPass() { }

	[Address(RVA = "0x2E21330", Offset = "0x2E20730", Length = "0x110")]
	[Token(Token = "0x6000B71")]
	public CopyColorPass(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial = null, string customPassName = null) { }

	[Address(RVA = "0x2E20240", Offset = "0x2E1F640", Length = "0x498")]
	[Token(Token = "0x6000B79")]
	private void AddDownsampleAndCopyColorRenderPass(RenderGraph renderGraph, in TextureHandle destination, in TextureHandle source, bool useProceduralBlit, string passName) { }

	[Address(RVA = "0x2E206E0", Offset = "0x2E1FAE0", Length = "0x76")]
	[Token(Token = "0x6000B72")]
	public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B70")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E20760", Offset = "0x2E1FB60", Length = "0x47D")]
	[Token(Token = "0x6000B75")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle source, bool useDrawProceduralBlit) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B6F")]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E20FD0", Offset = "0x2E203D0", Length = "0x246")]
	[Token(Token = "0x6000B76")]
	internal TextureHandle Render(RenderGraph renderGraph, ContextContainer frameData, out TextureHandle destination, in TextureHandle source, Downsampling downsampling) { }

	[Address(RVA = "0x2E20BE0", Offset = "0x2E1FFE0", Length = "0x33B")]
	[Token(Token = "0x6000B78")]
	private void RenderInternal(RenderGraph renderGraph, in TextureHandle destination, in TextureHandle source, bool useProceduralBlit) { }

	[Address(RVA = "0x2E20F20", Offset = "0x2E20320", Length = "0xA8")]
	[Token(Token = "0x6000B77")]
	internal void RenderToExistingTexture(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle destination, in TextureHandle source, Downsampling downsampling = 0) { }

	[Address(RVA = "0x2E21230", Offset = "0x2E20630", Length = "0x4E")]
	[Obsolete("Use RTHandles for source and destination #from(2022.1) #breakingFrom(2023.1).", True)]
	[Token(Token = "0x6000B73")]
	public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling) { }

	[Address(RVA = "0x2E21220", Offset = "0x2E20620", Length = "0x5")]
	[Token(Token = "0x6000B74")]
	public void Setup(RTHandle source, RTHandle destination, Downsampling downsampling) { }

}

