namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: Debug Shaders", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000196")]
public class UniversalRenderPipelineDebugShaders : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[ResourcePath("Shaders/Debug/DebugReplacement.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F4")]
	private Shader m_DebugReplacementPS; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Shaders/Debug/HDRDebugView.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F5")]
	private Shader m_HdrDebugViewPS; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Shaders/Debug/ProbeVolumeSamplingDebugPositionNormal.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F6")]
	private ComputeShader m_ProbeVolumeSamplingDebugComputeShader; //Field offset: 0x20

	[Token(Token = "0x170001FF")]
	public Shader debugReplacementPS
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60008A5")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCBA0", Offset = "0x2DFBFA0", Length = "0x65")]
		[Token(Token = "0x60008A6")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000200")]
	public Shader hdrDebugViewPS
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60008A7")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCC10", Offset = "0x2DFC010", Length = "0x65")]
		[Token(Token = "0x60008A8")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000201")]
	public ComputeShader probeVolumeSamplingDebugComputeShader
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60008A9")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCC80", Offset = "0x2DFC080", Length = "0x65")]
		[Token(Token = "0x60008AA")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001FE")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60008A4")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001FD")]
	public override int version
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008A3")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008AB")]
	public UniversalRenderPipelineDebugShaders() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60008A5")]
	public Shader get_debugReplacementPS() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60008A7")]
	public Shader get_hdrDebugViewPS() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60008A9")]
	public ComputeShader get_probeVolumeSamplingDebugComputeShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008A3")]
	public override int get_version() { }

	[Address(RVA = "0x2DFCBA0", Offset = "0x2DFBFA0", Length = "0x65")]
	[Token(Token = "0x60008A6")]
	public void set_debugReplacementPS(Shader value) { }

	[Address(RVA = "0x2DFCC10", Offset = "0x2DFC010", Length = "0x65")]
	[Token(Token = "0x60008A8")]
	public void set_hdrDebugViewPS(Shader value) { }

	[Address(RVA = "0x2DFCC80", Offset = "0x2DFC080", Length = "0x65")]
	[Token(Token = "0x60008AA")]
	public void set_probeVolumeSamplingDebugComputeShader(ComputeShader value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008A4")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

