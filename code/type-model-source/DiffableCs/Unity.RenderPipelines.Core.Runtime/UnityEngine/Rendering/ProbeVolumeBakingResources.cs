namespace UnityEngine.Rendering;

[CategoryInfo(Name = "R: Adaptive Probe Volumes", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x2000136")]
internal class ProbeVolumeBakingResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005D9")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Header("Baking")]
	[ResourcePath("Editor/Lighting/ProbeVolume/ProbeVolumeCellDilation.compute", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005DA")]
	public ComputeShader dilationShader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Editor/Lighting/ProbeVolume/ProbeVolumeSubdivide.compute", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005DB")]
	public ComputeShader subdivideSceneCS; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Editor/Lighting/ProbeVolume/VoxelizeScene.shader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005DC")]
	public Shader voxelizeSceneShader; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[ResourcePath("Editor/Lighting/ProbeVolume/VirtualOffset/TraceVirtualOffset.urtshader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005DD")]
	public ComputeShader traceVirtualOffsetCS; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[ResourcePath("Editor/Lighting/ProbeVolume/VirtualOffset/TraceVirtualOffset.urtshader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005DE")]
	public RayTracingShader traceVirtualOffsetRT; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[ResourcePath("Editor/Lighting/ProbeVolume/DynamicGI/DynamicGISkyOcclusion.urtshader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005DF")]
	public ComputeShader skyOcclusionCS; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[ResourcePath("Editor/Lighting/ProbeVolume/DynamicGI/DynamicGISkyOcclusion.urtshader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005E0")]
	public RayTracingShader skyOcclusionRT; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[ResourcePath("Editor/Lighting/ProbeVolume/RenderingLayerMask/TraceRenderingLayerMask.urtshader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005E1")]
	public ComputeShader renderingLayerCS; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[ResourcePath("Editor/Lighting/ProbeVolume/RenderingLayerMask/TraceRenderingLayerMask.urtshader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005E2")]
	public RayTracingShader renderingLayerRT; //Field offset: 0x58

	[Token(Token = "0x17000137")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000A9E")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1F29D20", Offset = "0x1F29120", Length = "0xE")]
	[Token(Token = "0x6000A9F")]
	public ProbeVolumeBakingResources() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000A9E")]
	public override int get_version() { }

}

