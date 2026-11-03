namespace UnityEngine.Rendering;

[CategoryInfo(Name = "R: Adaptive Probe Volumes", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x2000135")]
internal class ProbeVolumeDebugResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005D2")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Header("Debug")]
	[ResourcePath("Runtime/Debug/ProbeVolumeDebug.shader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005D3")]
	public Shader probeVolumeDebugShader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Runtime/Debug/ProbeVolumeFragmentationDebug.shader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005D4")]
	public Shader probeVolumeFragmentationDebugShader; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Runtime/Debug/ProbeVolumeSamplingDebug.shader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005D5")]
	public Shader probeVolumeSamplingDebugShader; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[ResourcePath("Runtime/Debug/ProbeVolumeOffsetDebug.shader", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005D6")]
	public Shader probeVolumeOffsetDebugShader; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[ResourcePath("Runtime/Debug/ProbeSamplingDebugMesh.fbx", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005D7")]
	public Mesh probeSamplingDebugMesh; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[ResourcePath("Runtime/Debug/ProbeVolumeNumbersDisplayTex.png", SearchType::ProjectPath (0))]
	[Token(Token = "0x40005D8")]
	public Texture2D numbersDisplayTex; //Field offset: 0x40

	[Token(Token = "0x17000136")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000A9C")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1F29D20", Offset = "0x1F29120", Length = "0xE")]
	[Token(Token = "0x6000A9D")]
	public ProbeVolumeDebugResources() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000A9C")]
	public override int get_version() { }

}

