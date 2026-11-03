namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Decal")]
[SupportedOnRenderer(typeof(UniversalRendererData))]
[Token(Token = "0x20000C1")]
[Tooltip("With this Renderer Feature, Unity can project specific Materials (decals) onto other objects in the Scene.")]
public class DecalRendererFeature : ScriptableRendererFeature
{
	[CompilerGenerated]
	[Token(Token = "0x4000426")]
	private static readonly SharedDecalEntityManager <sharedDecalEntityManager>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000427")]
	private DecalSettings m_Settings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000428")]
	private DecalTechnique m_Technique; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000429")]
	private DBufferSettings m_DBufferSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400042A")]
	private DecalScreenSpaceSettings m_ScreenSpaceSettings; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400042B")]
	private bool m_RecreateSystems; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400042C")]
	private DecalPreviewPass m_DecalPreviewPass; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400042D")]
	private DecalEntityManager m_DecalEntityManager; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400042E")]
	private DecalUpdateCachedSystem m_DecalUpdateCachedSystem; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400042F")]
	private DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000430")]
	private DecalUpdateCulledSystem m_DecalUpdateCulledSystem; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000431")]
	private DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000432")]
	private DecalDrawErrorSystem m_DrawErrorSystem; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000433")]
	private DBufferCopyDepthPass m_CopyDepthPass; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000434")]
	private DBufferRenderPass m_DBufferRenderPass; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000435")]
	private DecalForwardEmissivePass m_ForwardEmissivePass; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000436")]
	private DecalDrawDBufferSystem m_DecalDrawDBufferSystem; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000437")]
	private DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000438")]
	private Material m_DBufferClearMaterial; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000439")]
	private DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400043A")]
	private DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400043B")]
	private DecalSkipCulledSystem m_DecalSkipCulledSystem; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400043C")]
	private DecalGBufferRenderPass m_GBufferRenderPass; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400043D")]
	private DecalDrawGBufferSystem m_DrawGBufferSystem; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400043E")]
	private DeferredLights m_DeferredLights; //Field offset: 0xD8

	[Token(Token = "0x1700012D")]
	internal bool intermediateRendering
	{
		[Address(RVA = "0x1D71770", Offset = "0x1D70B70", Length = "0x8")]
		[Token(Token = "0x60004A1")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700012F")]
	internal static bool isGLDevice
	{
		[Address(RVA = "0x2D8EEE0", Offset = "0x2D8E2E0", Length = "0x29")]
		[Token(Token = "0x60004A3")]
		internal get { } //Length: 41
	}

	[Token(Token = "0x1700012E")]
	internal bool requiresDecalLayers
	{
		[Address(RVA = "0x2D8EF10", Offset = "0x2D8E310", Length = "0x1B")]
		[Token(Token = "0x60004A2")]
		internal get { } //Length: 27
	}

	[Token(Token = "0x1700012C")]
	internal DecalSettings settings
	{
		[Address(RVA = "0x2815D60", Offset = "0x2815160", Length = "0x5")]
		[Token(Token = "0x60004A0")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700012B")]
	private static SharedDecalEntityManager sharedDecalEntityManager
	{
		[Address(RVA = "0x2D8EF30", Offset = "0x2D8E330", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x600049F")]
		private get { } //Length: 78
	}

	[Address(RVA = "0x2D8EDF0", Offset = "0x2D8E1F0", Length = "0x73")]
	[Token(Token = "0x60004B2")]
	private static DecalRendererFeature() { }

	[Address(RVA = "0x2D8EE70", Offset = "0x2D8E270", Length = "0x6A")]
	[Token(Token = "0x60004B1")]
	public DecalRendererFeature() { }

	[Address(RVA = "0x2D8D6C0", Offset = "0x2D8CAC0", Length = "0x33A")]
	[Token(Token = "0x60004AE")]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Address(RVA = "0x2D8DA00", Offset = "0x2D8CE00", Length = "0xD6")]
	[Conditional("ENABLE_ADAPTIVE_PERFORMANCE")]
	[Token(Token = "0x60004B0")]
	private void ChangeAdaptivePerformanceDrawDistances() { }

	[Address(RVA = "0x2D8DAE0", Offset = "0x2D8CEE0", Length = "0x61")]
	[Token(Token = "0x60004A4")]
	public virtual void Create() { }

	[Address(RVA = "0x2D8DB50", Offset = "0x2D8CF50", Length = "0x100")]
	[Token(Token = "0x60004AF")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1D71770", Offset = "0x1D70B70", Length = "0x8")]
	[Token(Token = "0x60004A1")]
	internal bool get_intermediateRendering() { }

	[Address(RVA = "0x2D8EEE0", Offset = "0x2D8E2E0", Length = "0x29")]
	[Token(Token = "0x60004A3")]
	internal static bool get_isGLDevice() { }

	[Address(RVA = "0x2D8EF10", Offset = "0x2D8E310", Length = "0x1B")]
	[Token(Token = "0x60004A2")]
	internal bool get_requiresDecalLayers() { }

	[Address(RVA = "0x2815D60", Offset = "0x2815160", Length = "0x5")]
	[Token(Token = "0x60004A0")]
	internal DecalSettings get_settings() { }

	[Address(RVA = "0x2D8EF30", Offset = "0x2D8E330", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x600049F")]
	private static SharedDecalEntityManager get_sharedDecalEntityManager() { }

	[Address(RVA = "0x2D8DC60", Offset = "0x2D8D060", Length = "0x71")]
	[Token(Token = "0x60004A6")]
	internal DBufferSettings GetDBufferSettings() { }

	[Address(RVA = "0x2D8DCE0", Offset = "0x2D8D0E0", Length = "0x71")]
	[Token(Token = "0x60004A7")]
	internal DecalScreenSpaceSettings GetScreenSpaceSettings() { }

	[Address(RVA = "0x2D8E0E0", Offset = "0x2D8D4E0", Length = "0x13B")]
	[Token(Token = "0x60004A8")]
	internal DecalTechnique GetTechnique(ScriptableRendererData renderer) { }

	[Address(RVA = "0x2D8DD60", Offset = "0x2D8D160", Length = "0x27B")]
	[Token(Token = "0x60004AA")]
	internal DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = true) { }

	[Address(RVA = "0x2D8DFE0", Offset = "0x2D8D3E0", Length = "0xFB")]
	[Token(Token = "0x60004A9")]
	internal DecalTechnique GetTechnique(ScriptableRenderer renderer) { }

	[Address(RVA = "0x2D8E220", Offset = "0x2D8D620", Length = "0xB4")]
	[Token(Token = "0x60004AB")]
	private bool IsAutomaticDBuffer() { }

	[Address(RVA = "0x2D8E2E0", Offset = "0x2D8D6E0", Length = "0x1FD")]
	[Token(Token = "0x60004AD")]
	public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData) { }

	[Address(RVA = "0x2D8E4E0", Offset = "0x2D8D8E0", Length = "0x841")]
	[Token(Token = "0x60004AC")]
	private bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData) { }

	[Address(RVA = "0x2D8ED30", Offset = "0x2D8E130", Length = "0xB2")]
	[Token(Token = "0x60004A5")]
	internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out Event atEvent, out MaskSize maskSize) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600049E")]
	public virtual void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData) { }

}

