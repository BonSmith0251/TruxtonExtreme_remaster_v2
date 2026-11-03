namespace UnityEngine.Rendering;

[CategoryInfo(Name = "R: Adaptive Probe Volumes", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x2000134")]
internal class ProbeVolumeRuntimeResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005CE")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Header("Runtime")]
	[ResourcePath("Runtime/Lighting/ProbeVolume/ProbeVolumeBlendStates.compute", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005CF")]
	public ComputeShader probeVolumeBlendStatesCS; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Runtime/Lighting/ProbeVolume/ProbeVolumeUploadData.compute", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005D0")]
	public ComputeShader probeVolumeUploadDataCS; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Runtime/Lighting/ProbeVolume/ProbeVolumeUploadDataL2.compute", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005D1")]
	public ComputeShader probeVolumeUploadDataL2CS; //Field offset: 0x28

	[Token(Token = "0x17000135")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000A9A")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1F29D20", Offset = "0x1F29120", Length = "0xE")]
	[Token(Token = "0x6000A9B")]
	public ProbeVolumeRuntimeResources() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000A9A")]
	public override int get_version() { }

}

