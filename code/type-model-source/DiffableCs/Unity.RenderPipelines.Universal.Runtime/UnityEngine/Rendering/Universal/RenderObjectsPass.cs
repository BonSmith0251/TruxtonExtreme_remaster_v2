namespace UnityEngine.Rendering.Universal;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.Universal", null, null)]
[Token(Token = "0x20000C8")]
public class RenderObjectsPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x20000CA")]
	private sealed class <>c
	{
		[Token(Token = "0x400045B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400045C")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__33_0; //Field offset: 0x8

		[Address(RVA = "0x2D92960", Offset = "0x2D91D60", Length = "0x67")]
		[Token(Token = "0x6000527")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000528")]
		public <>c() { }

		[Address(RVA = "0x2D925A0", Offset = "0x2D919A0", Length = "0xD7")]
		[Token(Token = "0x6000529")]
		internal void <RecordRenderGraph>b__33_0(PassData data, RasterGraphContext rgContext) { }

	}

	[Token(Token = "0x20000C9")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000454")]
		internal CustomCameraSettings cameraSettings; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000455")]
		internal RenderPassEvent renderPassEvent; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000456")]
		internal TextureHandle color; //Field offset: 0x1C
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000457")]
		internal RendererListHandle rendererListHdl; //Field offset: 0x2C
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000458")]
		internal DebugRendererLists debugRendererLists; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000459")]
		internal UniversalCameraData cameraData; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400045A")]
		internal RendererList rendererList; //Field offset: 0x48

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000526")]
		public PassData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400044A")]
	private RenderQueueType renderQueueType; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400044B")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x64
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400044C")]
	private CustomCameraSettings m_CameraSettings; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400044D")]
	private Material <overrideMaterial>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400044E")]
	private int <overrideMaterialPassIndex>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400044F")]
	private Shader <overrideShader>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000450")]
	private int <overrideShaderPassIndex>k__BackingField; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000451")]
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000452")]
	private PassData m_PassData; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000453")]
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0xC0

	[Token(Token = "0x1700016C")]
	public Material overrideMaterial
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000514")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000515")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700016D")]
	public int overrideMaterialPassIndex
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000516")]
		 get { } //Length: 7
		[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000517")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700016E")]
	public Shader overrideShader
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000518")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000519")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700016F")]
	public int overrideShaderPassIndex
	{
		[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600051A")]
		 get { } //Length: 7
		[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600051B")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2D920F0", Offset = "0x2D914F0", Length = "0x100")]
	[Token(Token = "0x6000520")]
	internal RenderObjectsPass(URPProfileId profileId, RenderPassEvent renderPassEvent, String[] shaderTags, RenderQueueType renderQueueType, int layerMask, CustomCameraSettings cameraSettings) { }

	[Address(RVA = "0x2D921F0", Offset = "0x2D915F0", Length = "0x10E")]
	[Token(Token = "0x600051F")]
	public RenderObjectsPass(string profilerTag, RenderPassEvent renderPassEvent, String[] shaderTags, RenderQueueType renderQueueType, int layerMask, CustomCameraSettings cameraSettings) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000513")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2D90080", Offset = "0x2D8F480", Length = "0x62F")]
	[Token(Token = "0x6000522")]
	private static void ExecutePass(PassData passData, RasterCommandBuffer cmd, RendererList rendererList, bool isYFlipped) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000514")]
	public Material get_overrideMaterial() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000516")]
	public int get_overrideMaterialPassIndex() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000518")]
	public Shader get_overrideShader() { }

	[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600051A")]
	public int get_overrideShaderPassIndex() { }

	[Address(RVA = "0x2D90EB0", Offset = "0x2D902B0", Length = "0x4A8")]
	[Token(Token = "0x6000521")]
	internal void Init(RenderPassEvent renderPassEvent, String[] shaderTags, RenderQueueType renderQueueType, int layerMask, CustomCameraSettings cameraSettings) { }

	[Address(RVA = "0x2D906B0", Offset = "0x2D8FAB0", Length = "0x6E")]
	[Token(Token = "0x6000523")]
	private void InitPassData(UniversalCameraData cameraData, ref PassData passData) { }

	[Address(RVA = "0x2D90720", Offset = "0x2D8FB20", Length = "0x780")]
	[Token(Token = "0x6000524")]
	private void InitRendererLists(UniversalRenderingData renderingData, UniversalLightData lightData, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	[Address(RVA = "0x2D91360", Offset = "0x2D90760", Length = "0xBEE")]
	[Token(Token = "0x6000525")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000515")]
	public void set_overrideMaterial(Material value) { }

	[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000517")]
	public void set_overrideMaterialPassIndex(int value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000519")]
	public void set_overrideShader(Shader value) { }

	[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600051B")]
	public void set_overrideShaderPassIndex(int value) { }

	[Address(RVA = "0x2D91F50", Offset = "0x2D91350", Length = "0x83")]
	[Token(Token = "0x600051D")]
	public void SetDepthState(bool writeEnabled, CompareFunction function = 2) { }

	[Address(RVA = "0x2D91F50", Offset = "0x2D91350", Length = "0x83")]
	[Obsolete("Use SetDepthState instead. #from(2023.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x600051C")]
	public void SetDetphState(bool writeEnabled, CompareFunction function = 2) { }

	[Address(RVA = "0x2D91FE0", Offset = "0x2D913E0", Length = "0x106")]
	[Token(Token = "0x600051E")]
	public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp) { }

}

