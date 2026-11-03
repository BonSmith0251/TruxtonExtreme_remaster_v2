namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001B0")]
public static class TemporalAA
{
	[CompilerGenerated]
	[Token(Token = "0x20001B6")]
	private sealed class <>c
	{
		[Token(Token = "0x4000970")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000971")]
		public static BaseRenderFunc<TaaPassData, RasterGraphContext> <>9__17_0; //Field offset: 0x8
		[Token(Token = "0x4000972")]
		public static BaseRenderFunc<TaaPassData, RasterGraphContext> <>9__17_1; //Field offset: 0x10

		[Address(RVA = "0x2DFB130", Offset = "0x2DFA530", Length = "0x67")]
		[Token(Token = "0x6000971")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000972")]
		public <>c() { }

		[Address(RVA = "0x2DFAC60", Offset = "0x2DFA060", Length = "0x37B")]
		[Token(Token = "0x6000973")]
		internal void <Render>b__17_0(TaaPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DFAFE0", Offset = "0x2DFA3E0", Length = "0x12E")]
		[Token(Token = "0x6000974")]
		internal void <Render>b__17_1(TaaPassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x20001B4")]
	public sealed class JitterFunc : MulticastDelegate
	{

		[Address(RVA = "0x2B7E930", Offset = "0x2B7DD30", Length = "0xA6")]
		[Token(Token = "0x600096C")]
		public JitterFunc(object object, IntPtr method) { }

		[Address(RVA = "0x2DE81C0", Offset = "0x2DE75C0", Length = "0xAA")]
		[Token(Token = "0x600096E")]
		public override IAsyncResult BeginInvoke(int frameIndex, out Vector2 jitter, out bool allowScaling, AsyncCallback callback, object object) { }

		[Address(RVA = "0x1BB00A0", Offset = "0x1BAF4A0", Length = "0x20")]
		[Token(Token = "0x600096F")]
		public override void EndInvoke(out Vector2 jitter, out bool allowScaling, IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x600096D")]
		public override void Invoke(int frameIndex, out Vector2 jitter, out bool allowScaling) { }

	}

	[Token(Token = "0x20001B3")]
	internal struct Settings
	{
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("quality")]
		[SerializeField]
		[Token(Token = "0x400095C")]
		internal TemporalAAQuality m_Quality; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[FormerlySerializedAs("frameInfluence")]
		[SerializeField]
		[Token(Token = "0x400095D")]
		internal float m_FrameInfluence; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("jitterScale")]
		[SerializeField]
		[Token(Token = "0x400095E")]
		internal float m_JitterScale; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[FormerlySerializedAs("mipBias")]
		[SerializeField]
		[Token(Token = "0x400095F")]
		internal float m_MipBias; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("varianceClampScale")]
		[SerializeField]
		[Token(Token = "0x4000960")]
		internal float m_VarianceClampScale; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("contrastAdaptiveSharpening")]
		[SerializeField]
		[Token(Token = "0x4000961")]
		internal float m_ContrastAdaptiveSharpening; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000962")]
		internal int resetHistoryFrames; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000963")]
		internal int jitterFrameCountOffset; //Field offset: 0x1C

		[Token(Token = "0x1700022C")]
		public float baseBlendFactor
		{
			[Address(RVA = "0x2DEB0B0", Offset = "0x2DEA4B0", Length = "0xE")]
			[Token(Token = "0x6000961")]
			 get { } //Length: 14
			[Address(RVA = "0x2DEB0C0", Offset = "0x2DEA4C0", Length = "0x2E")]
			[Token(Token = "0x6000962")]
			 set { } //Length: 46
		}

		[Token(Token = "0x17000230")]
		public float contrastAdaptiveSharpening
		{
			[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
			[Token(Token = "0x6000969")]
			 get { } //Length: 6
			[Address(RVA = "0x2DEB0F0", Offset = "0x2DEA4F0", Length = "0x21")]
			[Token(Token = "0x600096A")]
			 set { } //Length: 33
		}

		[Token(Token = "0x1700022D")]
		public float jitterScale
		{
			[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
			[Token(Token = "0x6000963")]
			 get { } //Length: 229
			[Address(RVA = "0x2DEB120", Offset = "0x2DEA520", Length = "0x21")]
			[Token(Token = "0x6000964")]
			 set { } //Length: 33
		}

		[Token(Token = "0x1700022E")]
		public float mipBias
		{
			[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
			[Token(Token = "0x6000965")]
			 get { } //Length: 6
			[Address(RVA = "0x2DEB150", Offset = "0x2DEA550", Length = "0x21")]
			[Token(Token = "0x6000966")]
			 set { } //Length: 33
		}

		[Token(Token = "0x1700022B")]
		public TemporalAAQuality quality
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x600095F")]
			 get { } //Length: 3
			[Address(RVA = "0x2DEB180", Offset = "0x2DEA580", Length = "0x1A")]
			[Token(Token = "0x6000960")]
			 set { } //Length: 26
		}

		[Token(Token = "0x1700022F")]
		public float varianceClampScale
		{
			[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
			[Token(Token = "0x6000967")]
			 get { } //Length: 6
			[Address(RVA = "0x2DEB1A0", Offset = "0x2DEA5A0", Length = "0x26")]
			[Token(Token = "0x6000968")]
			 set { } //Length: 38
		}

		[Address(RVA = "0x2DEB080", Offset = "0x2DEA480", Length = "0x27")]
		[Token(Token = "0x600096B")]
		public static Settings Create() { }

		[Address(RVA = "0x2DEB0B0", Offset = "0x2DEA4B0", Length = "0xE")]
		[Token(Token = "0x6000961")]
		public float get_baseBlendFactor() { }

		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[Token(Token = "0x6000969")]
		public float get_contrastAdaptiveSharpening() { }

		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x6000963")]
		public float get_jitterScale() { }

		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x6000965")]
		public float get_mipBias() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x600095F")]
		public TemporalAAQuality get_quality() { }

		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000967")]
		public float get_varianceClampScale() { }

		[Address(RVA = "0x2DEB0C0", Offset = "0x2DEA4C0", Length = "0x2E")]
		[Token(Token = "0x6000962")]
		public void set_baseBlendFactor(float value) { }

		[Address(RVA = "0x2DEB0F0", Offset = "0x2DEA4F0", Length = "0x21")]
		[Token(Token = "0x600096A")]
		public void set_contrastAdaptiveSharpening(float value) { }

		[Address(RVA = "0x2DEB120", Offset = "0x2DEA520", Length = "0x21")]
		[Token(Token = "0x6000964")]
		public void set_jitterScale(float value) { }

		[Address(RVA = "0x2DEB150", Offset = "0x2DEA550", Length = "0x21")]
		[Token(Token = "0x6000966")]
		public void set_mipBias(float value) { }

		[Address(RVA = "0x2DEB180", Offset = "0x2DEA580", Length = "0x1A")]
		[Token(Token = "0x6000960")]
		public void set_quality(TemporalAAQuality value) { }

		[Address(RVA = "0x2DEB1A0", Offset = "0x2DEA5A0", Length = "0x26")]
		[Token(Token = "0x6000968")]
		public void set_varianceClampScale(float value) { }

	}

	[Token(Token = "0x20001B1")]
	public static class ShaderConstants
	{
		[Token(Token = "0x4000955")]
		public static readonly int _TaaAccumulationTex; //Field offset: 0x0
		[Token(Token = "0x4000956")]
		public static readonly int _TaaMotionVectorTex; //Field offset: 0x4
		[Token(Token = "0x4000957")]
		public static readonly int _TaaFilterWeights; //Field offset: 0x8
		[Token(Token = "0x4000958")]
		public static readonly int _TaaFrameInfluence; //Field offset: 0xC
		[Token(Token = "0x4000959")]
		public static readonly int _TaaVarianceClampScale; //Field offset: 0x10
		[Token(Token = "0x400095A")]
		public static readonly int _CameraDepthTexture; //Field offset: 0x14

		[Address(RVA = "0x2DEB590", Offset = "0x2DEA990", Length = "0x126")]
		[Token(Token = "0x600095D")]
		private static ShaderConstants() { }

	}

	[Token(Token = "0x20001B2")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x400095B")]
		public static readonly string TAA_LOW_PRECISION_SOURCE; //Field offset: 0x0

		[Address(RVA = "0x2DEB980", Offset = "0x2DEAD80", Length = "0x62")]
		[Token(Token = "0x600095E")]
		private static ShaderKeywords() { }

	}

	[Token(Token = "0x20001B5")]
	private class TaaPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000964")]
		internal TextureHandle dstTex; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000965")]
		internal TextureHandle srcColorTex; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000966")]
		internal TextureHandle srcDepthTex; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000967")]
		internal TextureHandle srcMotionVectorTex; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000968")]
		internal TextureHandle srcTaaAccumTex; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000969")]
		internal Material material; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400096A")]
		internal int passIndex; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400096B")]
		internal float taaFrameInfluence; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400096C")]
		internal float taaVarianceClampScale; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400096D")]
		internal Single[] taaFilterWeights; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400096E")]
		internal bool taaLowPrecisionSource; //Field offset: 0x80
		[FieldOffset(Offset = "0x81")]
		[Token(Token = "0x400096F")]
		internal bool taaAlphaOutput; //Field offset: 0x81

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000970")]
		public TaaPassData() { }

	}

	[Token(Token = "0x4000950")]
	internal static JitterFunc s_JitterFunc; //Field offset: 0x0
	[Token(Token = "0x4000951")]
	private static readonly Vector2[] taaFilterOffsets; //Field offset: 0x8
	[Token(Token = "0x4000952")]
	private static readonly Single[] taaFilterWeights; //Field offset: 0x10
	[Token(Token = "0x4000953")]
	internal static GraphicsFormat[] AccumulationFormatList; //Field offset: 0x18
	[Token(Token = "0x4000954")]
	private static uint s_warnCounter; //Field offset: 0x20

	[Address(RVA = "0x2DF3590", Offset = "0x2DF2990", Length = "0x309")]
	[Token(Token = "0x600095C")]
	private static TemporalAA() { }

	[Address(RVA = "0x2DF1B00", Offset = "0x2DF0F00", Length = "0x25F")]
	[Token(Token = "0x6000957")]
	internal static Single[] CalculateFilterWeights(ref Settings settings) { }

	[Address(RVA = "0x2DF1F90", Offset = "0x2DF1390", Length = "0x74")]
	[Token(Token = "0x6000956")]
	internal static void CalculateJitter(int frameIndex, out Vector2 jitter, out bool allowScaling) { }

	[Address(RVA = "0x2DF1D60", Offset = "0x2DF1160", Length = "0x221")]
	[Token(Token = "0x6000955")]
	internal static Matrix4x4 CalculateJitterMatrix(UniversalCameraData cameraData, JitterFunc jitterFunc) { }

	[Address(RVA = "0x2DF2010", Offset = "0x2DF1410", Length = "0x18")]
	[Token(Token = "0x6000954")]
	internal static int CalculateTaaFrameIndex(ref Settings settings) { }

	[Address(RVA = "0x2DF2030", Offset = "0x2DF1430", Length = "0x4BC")]
	[Token(Token = "0x600095A")]
	internal static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors) { }

	[Address(RVA = "0x2DF24F0", Offset = "0x2DF18F0", Length = "0xBA5")]
	[Token(Token = "0x600095B")]
	internal static void Render(RenderGraph renderGraph, Material taaMaterial, UniversalCameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor) { }

	[Address(RVA = "0x2DF30A0", Offset = "0x2DF24A0", Length = "0x21C")]
	[Token(Token = "0x6000958")]
	internal static RenderTextureDescriptor TemporalAADescFromCameraDesc(ref RenderTextureDescriptor cameraDesc) { }

	[Address(RVA = "0x2DF32C0", Offset = "0x2DF26C0", Length = "0x2C9")]
	[Token(Token = "0x6000959")]
	internal static string ValidateAndWarn(UniversalCameraData cameraData, bool isSTPRequested = false) { }

}

