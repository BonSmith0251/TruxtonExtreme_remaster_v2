namespace UnityEngine.Rendering;

[CategoryInfo(Name = "R: GPU Resident Drawers", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x200002D")]
internal class GPUResidentDrawerResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x200002E")]
	internal enum Version : int
	{
		Initial = 0,
		Count = 1,
		Latest = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400008F")]
	private Version m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceDataBufferCopyKernels.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000090")]
	private ComputeShader m_InstanceDataBufferCopyKernels; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceDataBufferUploadKernels.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000091")]
	private ComputeShader m_InstanceDataBufferUploadKernels; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceTransformUpdateKernels.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000092")]
	private ComputeShader m_TransformUpdaterKernels; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceWindDataUpdateKernels.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000093")]
	public ComputeShader m_WindDataUpdaterKernels; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/OccluderDepthPyramidKernels.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000094")]
	private ComputeShader m_OccluderDepthPyramidKernels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/InstanceOcclusionCullingKernels.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000095")]
	private ComputeShader m_InstanceOcclusionCullingKernels; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/OcclusionCullingDebug.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000096")]
	private ComputeShader m_OcclusionCullingDebugKernels; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/DebugOcclusionTest.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000097")]
	private Shader m_DebugOcclusionTestPS; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[ResourcePath("Runtime/RenderPipelineResources/GPUDriven/DebugOccluder.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000098")]
	private Shader m_DebugOccluderPS; //Field offset: 0x58

	[Token(Token = "0x1700001E")]
	public Shader debugOccluderPS
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600011A")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC99A0", Offset = "0x2CC8DA0", Length = "0x65")]
		[Token(Token = "0x600011B")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700001D")]
	public Shader debugOcclusionTestPS
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000118")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC9A10", Offset = "0x2CC8E10", Length = "0x65")]
		[Token(Token = "0x6000119")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000016")]
	public ComputeShader instanceDataBufferCopyKernels
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600010A")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC9A80", Offset = "0x2CC8E80", Length = "0x65")]
		[Token(Token = "0x600010B")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000017")]
	public ComputeShader instanceDataBufferUploadKernels
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600010C")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC9AF0", Offset = "0x2CC8EF0", Length = "0x65")]
		[Token(Token = "0x600010D")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700001B")]
	public ComputeShader instanceOcclusionCullingKernels
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000114")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC9B60", Offset = "0x2CC8F60", Length = "0x65")]
		[Token(Token = "0x6000115")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700001A")]
	public ComputeShader occluderDepthPyramidKernels
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000112")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC9BD0", Offset = "0x2CC8FD0", Length = "0x65")]
		[Token(Token = "0x6000113")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700001C")]
	public ComputeShader occlusionCullingDebugKernels
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000116")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC9C40", Offset = "0x2CC9040", Length = "0x65")]
		[Token(Token = "0x6000117")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000018")]
	public ComputeShader transformUpdaterKernels
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600010E")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC9CB0", Offset = "0x2CC90B0", Length = "0x65")]
		[Token(Token = "0x600010F")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000015")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000109")]
		private get { } //Length: 85
	}

	[Token(Token = "0x17000019")]
	public ComputeShader windDataUpdaterKernels
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000110")]
		 get { } //Length: 5
		[Address(RVA = "0x2CC9D20", Offset = "0x2CC9120", Length = "0x65")]
		[Token(Token = "0x6000111")]
		 set { } //Length: 101
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600011C")]
	public GPUResidentDrawerResources() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600011A")]
	public Shader get_debugOccluderPS() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000118")]
	public Shader get_debugOcclusionTestPS() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600010A")]
	public ComputeShader get_instanceDataBufferCopyKernels() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600010C")]
	public ComputeShader get_instanceDataBufferUploadKernels() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000114")]
	public ComputeShader get_instanceOcclusionCullingKernels() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000112")]
	public ComputeShader get_occluderDepthPyramidKernels() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000116")]
	public ComputeShader get_occlusionCullingDebugKernels() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600010E")]
	public ComputeShader get_transformUpdaterKernels() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000110")]
	public ComputeShader get_windDataUpdaterKernels() { }

	[Address(RVA = "0x2CC99A0", Offset = "0x2CC8DA0", Length = "0x65")]
	[Token(Token = "0x600011B")]
	public void set_debugOccluderPS(Shader value) { }

	[Address(RVA = "0x2CC9A10", Offset = "0x2CC8E10", Length = "0x65")]
	[Token(Token = "0x6000119")]
	public void set_debugOcclusionTestPS(Shader value) { }

	[Address(RVA = "0x2CC9A80", Offset = "0x2CC8E80", Length = "0x65")]
	[Token(Token = "0x600010B")]
	public void set_instanceDataBufferCopyKernels(ComputeShader value) { }

	[Address(RVA = "0x2CC9AF0", Offset = "0x2CC8EF0", Length = "0x65")]
	[Token(Token = "0x600010D")]
	public void set_instanceDataBufferUploadKernels(ComputeShader value) { }

	[Address(RVA = "0x2CC9B60", Offset = "0x2CC8F60", Length = "0x65")]
	[Token(Token = "0x6000115")]
	public void set_instanceOcclusionCullingKernels(ComputeShader value) { }

	[Address(RVA = "0x2CC9BD0", Offset = "0x2CC8FD0", Length = "0x65")]
	[Token(Token = "0x6000113")]
	public void set_occluderDepthPyramidKernels(ComputeShader value) { }

	[Address(RVA = "0x2CC9C40", Offset = "0x2CC9040", Length = "0x65")]
	[Token(Token = "0x6000117")]
	public void set_occlusionCullingDebugKernels(ComputeShader value) { }

	[Address(RVA = "0x2CC9CB0", Offset = "0x2CC90B0", Length = "0x65")]
	[Token(Token = "0x600010F")]
	public void set_transformUpdaterKernels(ComputeShader value) { }

	[Address(RVA = "0x2CC9D20", Offset = "0x2CC9120", Length = "0x65")]
	[Token(Token = "0x6000111")]
	public void set_windDataUpdaterKernels(ComputeShader value) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000109")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

