namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200009F")]
public abstract class ScriptableRenderPass : IRenderGraphRecorder
{
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x4000319")]
	public static RTHandle k_CameraTarget; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400031A")]
	private RenderPassEvent <renderPassEvent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400031B")]
	private bool <requiresIntermediateTexture>k__BackingField; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400031C")]
	private ProfilingSampler m_ProfingSampler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400031D")]
	private string m_PassName; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400031E")]
	private bool <isBlitRenderPass>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400031F")]
	private int <renderPassQueueIndex>k__BackingField; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000320")]
	internal NativeArray<Int32> m_ColorAttachmentIndices; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000321")]
	internal NativeArray<Int32> m_InputAttachmentIndices; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000322")]
	private GraphicsFormat[] <renderTargetFormat>k__BackingField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000323")]
	private ScriptableRenderPassInput m_Input; //Field offset: 0x58

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000E8")]
	public Color clearColor
	{
		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x6000390")]
		 get { } //Length: 10
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000E7")]
	public ClearFlag clearFlag
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600038F")]
		 get { } //Length: 3
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000E3")]
	public RTHandle colorAttachmentHandle
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600038B")]
		 get { } //Length: 3
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000E2")]
	public RTHandle[] colorAttachmentHandles
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600038A")]
		 get { } //Length: 3
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000E5")]
	public RenderBufferStoreAction[] colorStoreActions
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600038D")]
		 get { } //Length: 3
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000E4")]
	public RTHandle depthAttachmentHandle
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600038C")]
		 get { } //Length: 3
	}

	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x170000E6")]
	public RenderBufferStoreAction depthStoreAction
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600038E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000EA")]
	public ScriptableRenderPassInput input
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60003A3")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000EE")]
	internal bool isBlitRenderPass
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003A9")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003AA")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000ED")]
	protected private string passName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60003A8")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000EC")]
	protected private ProfilingSampler profilingSampler
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60003A6")]
		private get { } //Length: 3
		[Address(RVA = "0x2D82530", Offset = "0x2D81930", Length = "0x6C")]
		[Token(Token = "0x60003A7")]
		private set { } //Length: 108
	}

	[Token(Token = "0x170000E9")]
	public RenderPassEvent renderPassEvent
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60003A1")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003A2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000EF")]
	internal int renderPassQueueIndex
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003AB")]
		internal get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003AC")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000F0")]
	internal GraphicsFormat[] renderTargetFormat
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003AD")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60003AE")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170000EB")]
	public bool requiresIntermediateTexture
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003A4")]
		 get { } //Length: 5
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003A5")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2D823E0", Offset = "0x2D817E0", Length = "0xEF")]
	[Token(Token = "0x60003B0")]
	public ScriptableRenderPass() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60003A0")]
	public void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600039F")]
	public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600039E")]
	public void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material = null, int passIndex = 0) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600039B")]
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000399")]
	public void ConfigureClear(ClearFlag clearFlag, Color clearColor) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000391")]
	public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000392")]
	public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000393")]
	public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x60003B1")]
	public void ConfigureInput(ScriptableRenderPassInput passInput) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000395")]
	public void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000396")]
	public void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000397")]
	public void ConfigureTarget(RTHandle colorAttachment) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000398")]
	public void ConfigureTarget(RTHandle[] colorAttachments) { }

	[Address(RVA = "0x2D81FE0", Offset = "0x2D813E0", Length = "0x195")]
	[Token(Token = "0x60003B4")]
	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	[Address(RVA = "0x2D81E40", Offset = "0x2D81240", Length = "0x196")]
	[Token(Token = "0x60003B6")]
	public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	[Address(RVA = "0x2D81D20", Offset = "0x2D81120", Length = "0x118")]
	[Token(Token = "0x60003B7")]
	public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria) { }

	[Address(RVA = "0x2D81C00", Offset = "0x2D81000", Length = "0x117")]
	[Token(Token = "0x60003B5")]
	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600039D")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x29217F0", Offset = "0x2920BF0", Length = "0x14")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x6000389")]
	public override void FrameCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
	[Token(Token = "0x6000390")]
	public Color get_clearColor() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600038F")]
	public ClearFlag get_clearFlag() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600038B")]
	public RTHandle get_colorAttachmentHandle() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600038A")]
	public RTHandle[] get_colorAttachmentHandles() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600038D")]
	public RenderBufferStoreAction[] get_colorStoreActions() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600038C")]
	public RTHandle get_depthAttachmentHandle() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600038E")]
	public RenderBufferStoreAction get_depthStoreAction() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60003A3")]
	public ScriptableRenderPassInput get_input() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003A9")]
	internal bool get_isBlitRenderPass() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60003A8")]
	protected private string get_passName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60003A6")]
	protected private ProfilingSampler get_profilingSampler() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60003A1")]
	public RenderPassEvent get_renderPassEvent() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003AB")]
	internal int get_renderPassQueueIndex() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003AD")]
	internal GraphicsFormat[] get_renderTargetFormat() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003A4")]
	public bool get_requiresIntermediateTexture() { }

	[Address(RVA = "0x2D82180", Offset = "0x2D81580", Length = "0x5E")]
	[Token(Token = "0x60003AF")]
	internal static DebugHandler GetActiveDebugHandler(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D821E0", Offset = "0x2D815E0", Length = "0x151")]
	[Token(Token = "0x60003BA")]
	internal static int GetRenderPassEventRange(RenderPassEvent renderPassEvent) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003B2")]
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600039A")]
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600039C")]
	public override void OnFinishCameraStackRendering(CommandBuffer cmd) { }

	[Address(RVA = "0x2D824D0", Offset = "0x2D818D0", Length = "0x21")]
	[Token(Token = "0x60003B9")]
	public static bool op_GreaterThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	[Address(RVA = "0x2D82500", Offset = "0x2D81900", Length = "0x21")]
	[Token(Token = "0x60003B8")]
	public static bool op_LessThan(ScriptableRenderPass lhs, ScriptableRenderPass rhs) { }

	[Address(RVA = "0x2D82340", Offset = "0x2D81740", Length = "0x93")]
	[Token(Token = "0x60003B3")]
	public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000394")]
	public void ResetTarget() { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003AA")]
	internal void set_isBlitRenderPass(bool value) { }

	[Address(RVA = "0x2D82530", Offset = "0x2D81930", Length = "0x6C")]
	[Token(Token = "0x60003A7")]
	protected private void set_profilingSampler(ProfilingSampler value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003A2")]
	public void set_renderPassEvent(RenderPassEvent value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003AC")]
	internal void set_renderPassQueueIndex(int value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60003AE")]
	internal void set_renderTargetFormat(GraphicsFormat[] value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003A5")]
	public void set_requiresIntermediateTexture(bool value) { }

}

