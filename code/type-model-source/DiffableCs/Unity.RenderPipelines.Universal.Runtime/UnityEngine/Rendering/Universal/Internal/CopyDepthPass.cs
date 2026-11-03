namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000212")]
public class CopyDepthPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000215")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D03")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000D04")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__28_0; //Field offset: 0x8

		[Address(RVA = "0x2E35640", Offset = "0x2E34A40", Length = "0x67")]
		[Token(Token = "0x6000B92")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B93")]
		public <>c() { }

		[Address(RVA = "0x2E34CB0", Offset = "0x2E340B0", Length = "0xE9")]
		[Token(Token = "0x6000B94")]
		internal void <Render>b__28_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000214")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CFB")]
		internal TextureHandle source; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CFC")]
		internal TextureHandle destination; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000CFD")]
		internal UniversalCameraData cameraData; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000CFE")]
		internal Material copyDepthMaterial; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000CFF")]
		internal int msaaSamples; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000D00")]
		internal bool copyResolvedDepth; //Field offset: 0x44
		[FieldOffset(Offset = "0x45")]
		[Token(Token = "0x4000D01")]
		internal bool copyToDepth; //Field offset: 0x45
		[FieldOffset(Offset = "0x46")]
		[Token(Token = "0x4000D02")]
		internal bool isDstBackbuffer; //Field offset: 0x46

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B91")]
		public PassData() { }

	}

	[Token(Token = "0x2000213")]
	private static class ShaderConstants
	{
		[Token(Token = "0x4000CF8")]
		public static readonly int _CameraDepthAttachment; //Field offset: 0x0
		[Token(Token = "0x4000CF9")]
		public static readonly int _CameraDepthTexture; //Field offset: 0x4
		[Token(Token = "0x4000CFA")]
		public static readonly int _ZWriteShaderHandle; //Field offset: 0x8

		[Address(RVA = "0x2E33DE0", Offset = "0x2E331E0", Length = "0xA5")]
		[Token(Token = "0x6000B90")]
		private static ShaderConstants() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000CF2")]
	private int <MsaaSamples>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000CF3")]
	private bool <CopyToDepth>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x4000CF4")]
	private bool <CopyToDepthXR>k__BackingField; //Field offset: 0x65
	[CompilerGenerated]
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x4000CF5")]
	private bool <CopyToBackbuffer>k__BackingField; //Field offset: 0x66
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CF6")]
	private Material m_CopyDepthMaterial; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000CF7")]
	internal bool m_CopyResolvedDepth; //Field offset: 0x70

	[Token(Token = "0x170002C8")]
	internal bool CopyToBackbuffer
	{
		[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B87")]
		internal get { } //Length: 5
		[Address(RVA = "0x2E22780", Offset = "0x2E21B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B88")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002C6")]
	internal bool CopyToDepth
	{
		[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B83")]
		internal get { } //Length: 5
		[Address(RVA = "0x1D1D7B0", Offset = "0x1D1CBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B84")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002C7")]
	internal bool CopyToDepthXR
	{
		[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B85")]
		internal get { } //Length: 5
		[Address(RVA = "0x2E22790", Offset = "0x2E21B90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B86")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002C5")]
	internal int MsaaSamples
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B81")]
		internal get { } //Length: 4
		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B82")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2E22630", Offset = "0x2E21A30", Length = "0x14A")]
	[Token(Token = "0x6000B89")]
	public CopyDepthPass(RenderPassEvent evt, Shader copyDepthShader, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false, string customPassName = null) { }

	[Address(RVA = "0x2E21450", Offset = "0x2E20850", Length = "0x4D")]
	[Token(Token = "0x6000B8B")]
	public void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B80")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E214A0", Offset = "0x2E208A0", Length = "0x629")]
	[Token(Token = "0x6000B8C")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle source, bool yflip) { }

	[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B87")]
	internal bool get_CopyToBackbuffer() { }

	[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B83")]
	internal bool get_CopyToDepth() { }

	[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B85")]
	internal bool get_CopyToDepthXR() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B81")]
	internal int get_MsaaSamples() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B8D")]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B7F")]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E21AD0", Offset = "0x2E20ED0", Length = "0xF8")]
	[Token(Token = "0x6000B8E")]
	public void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle destination, TextureHandle source, bool bindAsCameraDepth = false, string passName = "Copy Depth") { }

	[Address(RVA = "0x2E21BD0", Offset = "0x2E20FD0", Length = "0xA46")]
	[Token(Token = "0x6000B8F")]
	public void Render(RenderGraph renderGraph, TextureHandle destination, TextureHandle source, UniversalResourceData resourceData, UniversalCameraData cameraData, bool bindAsCameraDepth = false, string passName = "Copy Depth") { }

	[Address(RVA = "0x2E22780", Offset = "0x2E21B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B88")]
	internal void set_CopyToBackbuffer(bool value) { }

	[Address(RVA = "0x1D1D7B0", Offset = "0x1D1CBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B84")]
	internal void set_CopyToDepth(bool value) { }

	[Address(RVA = "0x2E22790", Offset = "0x2E21B90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B86")]
	internal void set_CopyToDepthXR(bool value) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B82")]
	internal void set_MsaaSamples(int value) { }

	[Address(RVA = "0x2E22620", Offset = "0x2E21A20", Length = "0x8")]
	[Token(Token = "0x6000B8A")]
	public void Setup(RTHandle source, RTHandle destination) { }

}

