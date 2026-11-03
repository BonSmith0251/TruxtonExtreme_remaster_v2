namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: Universal Renderer Shaders", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000195")]
public class UniversalRendererResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008ED")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Shaders/Utils/CopyDepth.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008EE")]
	private Shader m_CopyDepthPS; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Shaders/CameraMotionVectors.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008EF")]
	private Shader m_CameraMotionVector; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Shaders/Utils/StencilDeferred.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F0")]
	private Shader m_StencilDeferredPS; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[ResourcePath("Shaders/Utils/ClusterDeferred.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F1")]
	private Shader m_ClusterDeferred; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[ResourcePath("Shaders/Utils/StencilDitherMaskSeed.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F2")]
	private Shader m_StencilDitherMaskSeedPS; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Header("Decal Renderer Feature Specific")]
	[ResourcePath("Runtime/Decal/DBuffer/DBufferClear.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F3")]
	private Shader m_DBufferClear; //Field offset: 0x40

	[Token(Token = "0x170001F8")]
	public Shader cameraMotionVector
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000898")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD580", Offset = "0x2DFC980", Length = "0x65")]
		[Token(Token = "0x6000899")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001FA")]
	public Shader clusterDeferred
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600089C")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD5F0", Offset = "0x2DFC9F0", Length = "0x65")]
		[Token(Token = "0x600089D")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001F7")]
	public Shader copyDepthPS
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000896")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD660", Offset = "0x2DFCA60", Length = "0x65")]
		[Token(Token = "0x6000897")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001FC")]
	public Shader decalDBufferClear
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60008A0")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD6D0", Offset = "0x2DFCAD0", Length = "0x65")]
		[Token(Token = "0x60008A1")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001F9")]
	public Shader stencilDeferredPS
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600089A")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD740", Offset = "0x2DFCB40", Length = "0x65")]
		[Token(Token = "0x600089B")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001FB")]
	public Shader stencilDitherMaskSeedPS
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600089E")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD7B0", Offset = "0x2DFCBB0", Length = "0x65")]
		[Token(Token = "0x600089F")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001F6")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000895")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001F5")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000894")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008A2")]
	public UniversalRendererResources() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000898")]
	public Shader get_cameraMotionVector() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600089C")]
	public Shader get_clusterDeferred() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000896")]
	public Shader get_copyDepthPS() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60008A0")]
	public Shader get_decalDBufferClear() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600089A")]
	public Shader get_stencilDeferredPS() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600089E")]
	public Shader get_stencilDitherMaskSeedPS() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000894")]
	public override int get_version() { }

	[Address(RVA = "0x2DFD580", Offset = "0x2DFC980", Length = "0x65")]
	[Token(Token = "0x6000899")]
	public void set_cameraMotionVector(Shader value) { }

	[Address(RVA = "0x2DFD5F0", Offset = "0x2DFC9F0", Length = "0x65")]
	[Token(Token = "0x600089D")]
	public void set_clusterDeferred(Shader value) { }

	[Address(RVA = "0x2DFD660", Offset = "0x2DFCA60", Length = "0x65")]
	[Token(Token = "0x6000897")]
	public void set_copyDepthPS(Shader value) { }

	[Address(RVA = "0x2DFD6D0", Offset = "0x2DFCAD0", Length = "0x65")]
	[Token(Token = "0x60008A1")]
	public void set_decalDBufferClear(Shader value) { }

	[Address(RVA = "0x2DFD740", Offset = "0x2DFCB40", Length = "0x65")]
	[Token(Token = "0x600089B")]
	public void set_stencilDeferredPS(Shader value) { }

	[Address(RVA = "0x2DFD7B0", Offset = "0x2DFCBB0", Length = "0x65")]
	[Token(Token = "0x600089F")]
	public void set_stencilDitherMaskSeedPS(Shader value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000895")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

