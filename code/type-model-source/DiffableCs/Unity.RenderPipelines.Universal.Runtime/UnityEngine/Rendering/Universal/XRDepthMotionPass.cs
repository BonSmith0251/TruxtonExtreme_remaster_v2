namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200015E")]
public class XRDepthMotionPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000160")]
	private sealed class <>c__DisplayClass22_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000813")]
		public XRDepthMotionPass <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000814")]
		public PassData passData; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007DA")]
		public <>c__DisplayClass22_0() { }

		[Address(RVA = "0x2DE4F00", Offset = "0x2DE4300", Length = "0x233")]
		[Token(Token = "0x60007DB")]
		internal void <Render>b__0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x200015F")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400080F")]
		internal RendererListHandle objMotionRendererList; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000810")]
		internal Matrix4x4[] previousViewProjectionStereo; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000811")]
		internal Matrix4x4[] viewProjectionStereo; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000812")]
		internal Material xrMotionVector; //Field offset: 0x30

		[Address(RVA = "0x2DCB420", Offset = "0x2DCA820", Length = "0x76")]
		[Token(Token = "0x60007D9")]
		public PassData() { }

	}

	[Token(Token = "0x40007FF")]
	public const string k_MotionOnlyShaderTagIdName = "XRMotionVectors"; //Field offset: 0x0
	[Token(Token = "0x4000800")]
	private static readonly ShaderTagId k_MotionOnlyShaderTagId; //Field offset: 0x0
	[Token(Token = "0x4000807")]
	private const int k_XRViewCountPerPass = 2; //Field offset: 0x0
	[Token(Token = "0x400080A")]
	private const int k_XRViewCount = 4; //Field offset: 0x0
	[Token(Token = "0x4000801")]
	private static readonly int k_SpaceWarpNDCModifier; //Field offset: 0x4
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000802")]
	private RTHandle m_XRMotionVectorColor; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000803")]
	private TextureHandle xrMotionVectorColor; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000804")]
	private RTHandle m_XRMotionVectorDepth; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000805")]
	private TextureHandle xrMotionVectorDepth; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000806")]
	private bool m_XRSpaceWarpRightHandedNDC; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000808")]
	private Matrix4x4[] m_StagingMatrixArray; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000809")]
	private Matrix4x4[] m_PreviousStagingMatrixArray; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400080B")]
	private Matrix4x4[] m_ViewProjection; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400080C")]
	private Matrix4x4[] m_PreviousViewProjection; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400080D")]
	private int m_LastFrameIndex; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400080E")]
	private Material m_XRMotionVectorMaterial; //Field offset: 0xC0

	[Address(RVA = "0x2DE7270", Offset = "0x2DE6670", Length = "0x8C")]
	[Token(Token = "0x60007D8")]
	private static XRDepthMotionPass() { }

	[Address(RVA = "0x2DE7300", Offset = "0x2DE6700", Length = "0x362")]
	[Token(Token = "0x60007CF")]
	public XRDepthMotionPass(RenderPassEvent evt, Shader xrMotionVector) { }

	[Address(RVA = "0x2DE5450", Offset = "0x2DE4850", Length = "0x70")]
	[Token(Token = "0x60007D7")]
	public void Dispose() { }

	[Address(RVA = "0x2DE54C0", Offset = "0x2DE48C0", Length = "0x243")]
	[Token(Token = "0x60007D0")]
	private static DrawingSettings GetObjectMotionDrawingSettings(Camera camera) { }

	[Address(RVA = "0x2DE5710", Offset = "0x2DE4B10", Length = "0x628")]
	[Token(Token = "0x60007D3")]
	private void ImportXRMotionColorAndDepth(RenderGraph renderGraph, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DE5D40", Offset = "0x2DE5140", Length = "0x5A7")]
	[Token(Token = "0x60007D1")]
	private void InitObjectMotionRendererLists(ref PassData passData, ref CullingResults cullResults, RenderGraph renderGraph, Camera camera) { }

	[Address(RVA = "0x2DE62F0", Offset = "0x2DE56F0", Length = "0x12A")]
	[Token(Token = "0x60007D2")]
	private void InitPassData(ref PassData passData, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DE6420", Offset = "0x2DE5820", Length = "0x82C")]
	[Token(Token = "0x60007D4")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x2DE6C50", Offset = "0x2DE6050", Length = "0x123")]
	[Token(Token = "0x60007D5")]
	private void ResetMotionData() { }

	[Address(RVA = "0x2DE6D80", Offset = "0x2DE6180", Length = "0x4E3")]
	[Token(Token = "0x60007D6")]
	public void Update(ref UniversalCameraData cameraData) { }

}

