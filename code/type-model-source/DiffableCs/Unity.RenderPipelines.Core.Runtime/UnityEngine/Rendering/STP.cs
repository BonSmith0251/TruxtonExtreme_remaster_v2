namespace UnityEngine.Rendering;

[Token(Token = "0x2000183")]
public static class STP
{
	[CompilerGenerated]
	[Token(Token = "0x2000193")]
	private sealed class <>c
	{
		[Token(Token = "0x40007C0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007C1")]
		public static BaseRenderFunc<SetupData, ComputeGraphContext> <>9__38_0; //Field offset: 0x8
		[Token(Token = "0x40007C2")]
		public static BaseRenderFunc<PreTaaData, ComputeGraphContext> <>9__38_1; //Field offset: 0x10
		[Token(Token = "0x40007C3")]
		public static BaseRenderFunc<TaaData, ComputeGraphContext> <>9__38_2; //Field offset: 0x18

		[Address(RVA = "0x2C39120", Offset = "0x2C38520", Length = "0x67")]
		[Token(Token = "0x6000BAB")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BAC")]
		public <>c() { }

		[Address(RVA = "0x2C382E0", Offset = "0x2C376E0", Length = "0x5F9")]
		[Token(Token = "0x6000BAD")]
		internal void <Execute>b__38_0(SetupData data, ComputeGraphContext ctx) { }

		[Address(RVA = "0x2C388E0", Offset = "0x2C37CE0", Length = "0x319")]
		[Token(Token = "0x6000BAE")]
		internal void <Execute>b__38_1(PreTaaData data, ComputeGraphContext ctx) { }

		[Address(RVA = "0x2C38C00", Offset = "0x2C38000", Length = "0x3EE")]
		[Token(Token = "0x6000BAF")]
		internal void <Execute>b__38_2(TaaData data, ComputeGraphContext ctx) { }

	}

	[Token(Token = "0x2000185")]
	internal struct Config
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000744")]
		public Texture2D noiseTexture; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000745")]
		public TextureHandle inputColor; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000746")]
		public TextureHandle inputDepth; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000747")]
		public TextureHandle inputMotion; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000748")]
		public TextureHandle inputStencil; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000749")]
		public TextureHandle debugView; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400074A")]
		public TextureHandle destination; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400074B")]
		public HistoryContext historyContext; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400074C")]
		public bool enableHwDrs; //Field offset: 0x70
		[FieldOffset(Offset = "0x71")]
		[Token(Token = "0x400074D")]
		public bool enableTexArray; //Field offset: 0x71
		[FieldOffset(Offset = "0x72")]
		[Token(Token = "0x400074E")]
		public bool enableMotionScaling; //Field offset: 0x72
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x400074F")]
		public float nearPlane; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000750")]
		public float farPlane; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000751")]
		public int frameIndex; //Field offset: 0x7C
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000752")]
		public bool hasValidHistory; //Field offset: 0x80
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4000753")]
		public int stencilMask; //Field offset: 0x84
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000754")]
		public int debugViewIndex; //Field offset: 0x88
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x4000755")]
		public float deltaTime; //Field offset: 0x8C
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000756")]
		public float lastDeltaTime; //Field offset: 0x90
		[FieldOffset(Offset = "0x94")]
		[Token(Token = "0x4000757")]
		public Vector2Int currentImageSize; //Field offset: 0x94
		[FieldOffset(Offset = "0x9C")]
		[Token(Token = "0x4000758")]
		public Vector2Int priorImageSize; //Field offset: 0x9C
		[FieldOffset(Offset = "0xA4")]
		[Token(Token = "0x4000759")]
		public Vector2Int outputImageSize; //Field offset: 0xA4
		[FieldOffset(Offset = "0xAC")]
		[Token(Token = "0x400075A")]
		public int numActiveViews; //Field offset: 0xAC
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400075B")]
		public PerViewConfig[] perViewConfigs; //Field offset: 0xB0

	}

	[Token(Token = "0x2000188")]
	internal sealed class HistoryContext : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000766")]
		private RTHandle[] m_textures; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000767")]
		private Hash128 m_hash; //Field offset: 0x18

		[Address(RVA = "0x2C24960", Offset = "0x2C23D60", Length = "0x6B")]
		[Token(Token = "0x6000B9D")]
		public HistoryContext() { }

		[Address(RVA = "0x2C24240", Offset = "0x2C23640", Length = "0xC1")]
		[Token(Token = "0x6000B9C")]
		public override void Dispose() { }

		[Address(RVA = "0x2C24310", Offset = "0x2C23710", Length = "0x32")]
		[Token(Token = "0x6000B9A")]
		internal RTHandle GetCurrentHistoryTexture(HistoryTextureType historyType, int frameIndex) { }

		[Address(RVA = "0x2C24350", Offset = "0x2C23750", Length = "0x35")]
		[Token(Token = "0x6000B9B")]
		internal RTHandle GetPreviousHistoryTexture(HistoryTextureType historyType, int frameIndex) { }

		[Address(RVA = "0x2C24390", Offset = "0x2C23790", Length = "0x5CE")]
		[Token(Token = "0x6000B99")]
		public bool Update(ref HistoryUpdateInfo info) { }

	}

	[Token(Token = "0x2000186")]
	public enum HistoryTextureType : int
	{
		DepthMotion = 0,
		Luma = 1,
		Convergence = 2,
		Feedback = 3,
		Count = 4,
	}

	[Token(Token = "0x2000187")]
	internal struct HistoryUpdateInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000762")]
		public Vector2Int preUpscaleSize; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000763")]
		public Vector2Int postUpscaleSize; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000764")]
		public bool useHwDrs; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000765")]
		public bool useTexArray; //Field offset: 0x11

	}

	[Token(Token = "0x2000184")]
	internal struct PerViewConfig
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400073E")]
		public Matrix4x4 currentProj; //Field offset: 0x0
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400073F")]
		public Matrix4x4 lastProj; //Field offset: 0x40
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000740")]
		public Matrix4x4 lastLastProj; //Field offset: 0x80
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000741")]
		public Matrix4x4 currentView; //Field offset: 0xC0
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4000742")]
		public Matrix4x4 lastView; //Field offset: 0x100
		[FieldOffset(Offset = "0x140")]
		[Token(Token = "0x4000743")]
		public Matrix4x4 lastLastView; //Field offset: 0x140

	}

	[Token(Token = "0x2000191")]
	private class PreTaaData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007A9")]
		public ComputeShader cs; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007AA")]
		public int kernelIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40007AB")]
		public int viewCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007AC")]
		public Vector2Int dispatchSize; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007AD")]
		public TextureHandle noiseTexture; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40007AE")]
		public TextureHandle debugView; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40007AF")]
		public TextureHandle intermediateConvergence; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40007B0")]
		public TextureHandle intermediateWeights; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40007B1")]
		public TextureHandle luma; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40007B2")]
		public TextureHandle convergence; //Field offset: 0x78

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BA9")]
		public PreTaaData() { }

	}

	[Token(Token = "0x200018F")]
	private enum ProfileId : int
	{
		StpSetup = 0,
		StpPreTaa = 1,
		StpTaa = 2,
	}

	[CategoryInfo(Name = "R: STP", Order = 1000)]
	[ElementInfo(Order = 0)]
	[HideInInspector]
	[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
	[Token(Token = "0x200018E")]
	public class RuntimeResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[FieldOffset(Offset = "0x10")]
		[ResourcePath("Runtime/STP/StpSetup.compute", SearchType::ProjectPath (0))]
		[SerializeField]
		[Token(Token = "0x400078F")]
		private ComputeShader m_setupCS; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[ResourcePath("Runtime/STP/StpPreTaa.compute", SearchType::ProjectPath (0))]
		[SerializeField]
		[Token(Token = "0x4000790")]
		private ComputeShader m_preTaaCS; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[ResourcePath("Runtime/STP/StpTaa.compute", SearchType::ProjectPath (0))]
		[SerializeField]
		[Token(Token = "0x4000791")]
		private ComputeShader m_taaCS; //Field offset: 0x20

		[Token(Token = "0x1700016C")]
		public ComputeShader preTaaCS
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000BA3")]
			 get { } //Length: 5
			[Address(RVA = "0x2C314C0", Offset = "0x2C308C0", Length = "0x65")]
			[Token(Token = "0x6000BA4")]
			 set { } //Length: 101
		}

		[Token(Token = "0x1700016B")]
		public ComputeShader setupCS
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000BA1")]
			 get { } //Length: 5
			[Address(RVA = "0x2C31530", Offset = "0x2C30930", Length = "0x65")]
			[Token(Token = "0x6000BA2")]
			 set { } //Length: 101
		}

		[Token(Token = "0x1700016D")]
		public ComputeShader taaCS
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000BA5")]
			 get { } //Length: 5
			[Address(RVA = "0x2C315A0", Offset = "0x2C309A0", Length = "0x65")]
			[Token(Token = "0x6000BA6")]
			 set { } //Length: 101
		}

		[Token(Token = "0x1700016A")]
		public override int version
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x6000BA0")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BA7")]
		public RuntimeResources() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000BA3")]
		public ComputeShader get_preTaaCS() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000BA1")]
		public ComputeShader get_setupCS() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000BA5")]
		public ComputeShader get_taaCS() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000BA0")]
		public override int get_version() { }

		[Address(RVA = "0x2C314C0", Offset = "0x2C308C0", Length = "0x65")]
		[Token(Token = "0x6000BA4")]
		public void set_preTaaCS(ComputeShader value) { }

		[Address(RVA = "0x2C31530", Offset = "0x2C30930", Length = "0x65")]
		[Token(Token = "0x6000BA2")]
		public void set_setupCS(ComputeShader value) { }

		[Address(RVA = "0x2C315A0", Offset = "0x2C309A0", Length = "0x65")]
		[Token(Token = "0x6000BA6")]
		public void set_taaCS(ComputeShader value) { }

	}

	[Token(Token = "0x2000190")]
	private class SetupData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000796")]
		public ComputeShader cs; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000797")]
		public int kernelIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000798")]
		public int viewCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000799")]
		public Vector2Int dispatchSize; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400079A")]
		public StpConstantBufferData constantBufferData; //Field offset: 0x28
		[FieldOffset(Offset = "0x1E8")]
		[Token(Token = "0x400079B")]
		public TextureHandle noiseTexture; //Field offset: 0x1E8
		[FieldOffset(Offset = "0x1F8")]
		[Token(Token = "0x400079C")]
		public TextureHandle debugView; //Field offset: 0x1F8
		[FieldOffset(Offset = "0x208")]
		[Token(Token = "0x400079D")]
		public TextureHandle inputColor; //Field offset: 0x208
		[FieldOffset(Offset = "0x218")]
		[Token(Token = "0x400079E")]
		public TextureHandle inputDepth; //Field offset: 0x218
		[FieldOffset(Offset = "0x228")]
		[Token(Token = "0x400079F")]
		public TextureHandle inputMotion; //Field offset: 0x228
		[FieldOffset(Offset = "0x238")]
		[Token(Token = "0x40007A0")]
		public TextureHandle inputStencil; //Field offset: 0x238
		[FieldOffset(Offset = "0x248")]
		[Token(Token = "0x40007A1")]
		public TextureHandle intermediateColor; //Field offset: 0x248
		[FieldOffset(Offset = "0x258")]
		[Token(Token = "0x40007A2")]
		public TextureHandle intermediateConvergence; //Field offset: 0x258
		[FieldOffset(Offset = "0x268")]
		[Token(Token = "0x40007A3")]
		public TextureHandle priorDepthMotion; //Field offset: 0x268
		[FieldOffset(Offset = "0x278")]
		[Token(Token = "0x40007A4")]
		public TextureHandle depthMotion; //Field offset: 0x278
		[FieldOffset(Offset = "0x288")]
		[Token(Token = "0x40007A5")]
		public TextureHandle priorLuma; //Field offset: 0x288
		[FieldOffset(Offset = "0x298")]
		[Token(Token = "0x40007A6")]
		public TextureHandle luma; //Field offset: 0x298
		[FieldOffset(Offset = "0x2A8")]
		[Token(Token = "0x40007A7")]
		public TextureHandle priorFeedback; //Field offset: 0x2A8
		[FieldOffset(Offset = "0x2B8")]
		[Token(Token = "0x40007A8")]
		public TextureHandle priorConvergence; //Field offset: 0x2B8

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BA8")]
		public SetupData() { }

	}

	[Token(Token = "0x200018D")]
	private static class ShaderKeywords
	{
		[Token(Token = "0x400078B")]
		public static readonly string EnableDebugMode; //Field offset: 0x0
		[Token(Token = "0x400078C")]
		public static readonly string EnableLargeKernel; //Field offset: 0x8
		[Token(Token = "0x400078D")]
		public static readonly string EnableStencilResponsive; //Field offset: 0x10
		[Token(Token = "0x400078E")]
		public static readonly string DisableTexture2DXArray; //Field offset: 0x18

		[Address(RVA = "0x2C36A60", Offset = "0x2C35E60", Length = "0x12B")]
		[Token(Token = "0x6000B9F")]
		private static ShaderKeywords() { }

	}

	[Token(Token = "0x200018C")]
	private static class ShaderResources
	{
		[Token(Token = "0x4000778")]
		public static readonly int _StpConstantBufferData; //Field offset: 0x0
		[Token(Token = "0x4000779")]
		public static readonly int _StpBlueNoiseIn; //Field offset: 0x4
		[Token(Token = "0x400077A")]
		public static readonly int _StpDebugOut; //Field offset: 0x8
		[Token(Token = "0x400077B")]
		public static readonly int _StpInputColor; //Field offset: 0xC
		[Token(Token = "0x400077C")]
		public static readonly int _StpInputDepth; //Field offset: 0x10
		[Token(Token = "0x400077D")]
		public static readonly int _StpInputMotion; //Field offset: 0x14
		[Token(Token = "0x400077E")]
		public static readonly int _StpInputStencil; //Field offset: 0x18
		[Token(Token = "0x400077F")]
		public static readonly int _StpIntermediateColor; //Field offset: 0x1C
		[Token(Token = "0x4000780")]
		public static readonly int _StpIntermediateConvergence; //Field offset: 0x20
		[Token(Token = "0x4000781")]
		public static readonly int _StpIntermediateWeights; //Field offset: 0x24
		[Token(Token = "0x4000782")]
		public static readonly int _StpPriorLuma; //Field offset: 0x28
		[Token(Token = "0x4000783")]
		public static readonly int _StpLuma; //Field offset: 0x2C
		[Token(Token = "0x4000784")]
		public static readonly int _StpPriorDepthMotion; //Field offset: 0x30
		[Token(Token = "0x4000785")]
		public static readonly int _StpDepthMotion; //Field offset: 0x34
		[Token(Token = "0x4000786")]
		public static readonly int _StpPriorFeedback; //Field offset: 0x38
		[Token(Token = "0x4000787")]
		public static readonly int _StpFeedback; //Field offset: 0x3C
		[Token(Token = "0x4000788")]
		public static readonly int _StpPriorConvergence; //Field offset: 0x40
		[Token(Token = "0x4000789")]
		public static readonly int _StpConvergence; //Field offset: 0x44
		[Token(Token = "0x400078A")]
		public static readonly int _StpOutput; //Field offset: 0x48

		[Address(RVA = "0x2C36B90", Offset = "0x2C35F90", Length = "0x359")]
		[Token(Token = "0x6000B9E")]
		private static ShaderResources() { }

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\STP\\STP.cs", needAccessors = False, generateCBuffer = True)]
	[Token(Token = "0x200018A")]
	private struct StpConstantBufferData
	{
		[CompilerGenerated]
		[Token(Token = "0x200018B")]
		[UnsafeValueType]
		internal struct <_StpSetupPerViewConstants>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000777")]
			public float FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400076A")]
		public Vector4 _StpCommonConstant; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400076B")]
		public Vector4 _StpSetupConstants0; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400076C")]
		public Vector4 _StpSetupConstants1; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400076D")]
		public Vector4 _StpSetupConstants2; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400076E")]
		public Vector4 _StpSetupConstants3; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400076F")]
		public Vector4 _StpSetupConstants4; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000770")]
		public Vector4 _StpSetupConstants5; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[FixedBuffer(typeof(float), 64)]
		[HLSLArray(16, typeof(Vector4))]
		[Token(Token = "0x4000771")]
		public <_StpSetupPerViewConstants>e__FixedBuffer _StpSetupPerViewConstants; //Field offset: 0x70
		[FieldOffset(Offset = "0x170")]
		[Token(Token = "0x4000772")]
		public Vector4 _StpDilConstants0; //Field offset: 0x170
		[FieldOffset(Offset = "0x180")]
		[Token(Token = "0x4000773")]
		public Vector4 _StpTaaConstants0; //Field offset: 0x180
		[FieldOffset(Offset = "0x190")]
		[Token(Token = "0x4000774")]
		public Vector4 _StpTaaConstants1; //Field offset: 0x190
		[FieldOffset(Offset = "0x1A0")]
		[Token(Token = "0x4000775")]
		public Vector4 _StpTaaConstants2; //Field offset: 0x1A0
		[FieldOffset(Offset = "0x1B0")]
		[Token(Token = "0x4000776")]
		public Vector4 _StpTaaConstants3; //Field offset: 0x1B0

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\STP\\STP.cs")]
	[Token(Token = "0x2000189")]
	private enum StpSetupPerViewConstants : int
	{
		Count = 8,
	}

	[Token(Token = "0x2000192")]
	private class TaaData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007B3")]
		public ComputeShader cs; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007B4")]
		public int kernelIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40007B5")]
		public int viewCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007B6")]
		public Vector2Int dispatchSize; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007B7")]
		public TextureHandle noiseTexture; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40007B8")]
		public TextureHandle debugView; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40007B9")]
		public TextureHandle intermediateColor; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40007BA")]
		public TextureHandle intermediateWeights; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40007BB")]
		public TextureHandle priorFeedback; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40007BC")]
		public TextureHandle depthMotion; //Field offset: 0x78
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40007BD")]
		public TextureHandle convergence; //Field offset: 0x88
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40007BE")]
		public TextureHandle feedback; //Field offset: 0x98
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40007BF")]
		public TextureHandle output; //Field offset: 0xA8

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BAA")]
		public TaaData() { }

	}

	[Token(Token = "0x4000736")]
	private const int kNumDebugViews = 6; //Field offset: 0x0
	[Token(Token = "0x4000737")]
	private static readonly GUIContent[] s_DebugViewDescriptions; //Field offset: 0x0
	[Token(Token = "0x4000739")]
	private const int kMaxPerViewConfigs = 2; //Field offset: 0x0
	[Token(Token = "0x400073B")]
	private const int kNumHistoryTextureTypes = 4; //Field offset: 0x0
	[Token(Token = "0x400073C")]
	private const int kTotalSetupViewConstantsCount = 16; //Field offset: 0x0
	[Token(Token = "0x4000738")]
	private static readonly Int32[] s_DebugViewIndices; //Field offset: 0x8
	[Token(Token = "0x400073A")]
	private static PerViewConfig[] s_PerViewConfigs; //Field offset: 0x10
	[Token(Token = "0x400073D")]
	private static readonly int kQualcommVendorId; //Field offset: 0x18

	[Token(Token = "0x17000167")]
	public static GUIContent[] debugViewDescriptions
	{
		[Address(RVA = "0x2C363C0", Offset = "0x2C357C0", Length = "0x4E")]
		[Token(Token = "0x6000B8C")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000168")]
	public static Int32[] debugViewIndices
	{
		[Address(RVA = "0x2C36410", Offset = "0x2C35810", Length = "0x4F")]
		[Token(Token = "0x6000B8D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000169")]
	public static PerViewConfig[] perViewConfigs
	{
		[Address(RVA = "0x2C36460", Offset = "0x2C35860", Length = "0x4F")]
		[Token(Token = "0x6000B8E")]
		 get { } //Length: 79
		[Address(RVA = "0x2C364B0", Offset = "0x2C358B0", Length = "0x6E")]
		[Token(Token = "0x6000B8F")]
		 set { } //Length: 110
	}

	[Address(RVA = "0x2C35F30", Offset = "0x2C35330", Length = "0x48E")]
	[Token(Token = "0x6000B98")]
	private static STP() { }

	[Address(RVA = "0x2C31610", Offset = "0x2C30A10", Length = "0x71")]
	[Token(Token = "0x6000B91")]
	private static Vector2Int CalculateConvergenceTextureSize(Vector2Int historyTextureSize) { }

	[Address(RVA = "0x2C31690", Offset = "0x2C30A90", Length = "0xAA")]
	[Token(Token = "0x6000B92")]
	private static float CalculateMotionScale(float deltaTime, float lastDeltaTime) { }

	[Address(RVA = "0x2C31740", Offset = "0x2C30B40", Length = "0x9D")]
	[Token(Token = "0x6000B90")]
	private static Hash128 ComputeHistoryHash(ref HistoryUpdateInfo info) { }

	[Address(RVA = "0x2C317E0", Offset = "0x2C30BE0", Length = "0x3075")]
	[Token(Token = "0x6000B97")]
	public static TextureHandle Execute(RenderGraph renderGraph, ref Config config) { }

	[Address(RVA = "0x2C34860", Offset = "0x2C33C60", Length = "0xA3")]
	[Token(Token = "0x6000B93")]
	private static Matrix4x4 ExtractRotation(Matrix4x4 input) { }

	[Address(RVA = "0x2C363C0", Offset = "0x2C357C0", Length = "0x4E")]
	[Token(Token = "0x6000B8C")]
	public static GUIContent[] get_debugViewDescriptions() { }

	[Address(RVA = "0x2C36410", Offset = "0x2C35810", Length = "0x4F")]
	[Token(Token = "0x6000B8D")]
	public static Int32[] get_debugViewIndices() { }

	[Address(RVA = "0x2C36460", Offset = "0x2C35860", Length = "0x4F")]
	[Token(Token = "0x6000B8E")]
	public static PerViewConfig[] get_perViewConfigs() { }

	[Address(RVA = "0x2C34910", Offset = "0x2C33D10", Length = "0x28")]
	[Token(Token = "0x6000B8A")]
	public static bool IsSupported() { }

	[Address(RVA = "0x2C34940", Offset = "0x2C33D40", Length = "0x4F")]
	[Token(Token = "0x6000B8B")]
	public static Vector2 Jit16(int frameIndex) { }

	[Address(RVA = "0x2C34990", Offset = "0x2C33D90", Length = "0x36")]
	[Token(Token = "0x6000B94")]
	private static int PackVector2ToInt(Vector2 value) { }

	[Address(RVA = "0x2C349D0", Offset = "0x2C33DD0", Length = "0x146E")]
	[Token(Token = "0x6000B95")]
	private static void PopulateConstantData(ref Config config, ref StpConstantBufferData constants) { }

	[Address(RVA = "0x2C364B0", Offset = "0x2C358B0", Length = "0x6E")]
	[Token(Token = "0x6000B8F")]
	public static void set_perViewConfigs(PerViewConfig[] value) { }

	[Address(RVA = "0x2C35E40", Offset = "0x2C35240", Length = "0xE2")]
	[Token(Token = "0x6000B96")]
	private static TextureHandle UseTexture(IBaseRenderGraphBuilder builder, in TextureHandle texture, AccessFlags flags = 1) { }

}

