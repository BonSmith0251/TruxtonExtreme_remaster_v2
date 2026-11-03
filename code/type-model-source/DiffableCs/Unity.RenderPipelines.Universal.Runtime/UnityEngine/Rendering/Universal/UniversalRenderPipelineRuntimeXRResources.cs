namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: Runtime XR", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000199")]
public class UniversalRenderPipelineRuntimeXRResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[ResourcePath("Shaders/XR/XROcclusionMesh.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000905")]
	private Shader m_xrOcclusionMeshPS; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Shaders/XR/XRMirrorView.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000906")]
	private Shader m_xrMirrorViewPS; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Shaders/XR/XRMotionVector.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000907")]
	private Shader m_xrMotionVector; //Field offset: 0x20

	[Token(Token = "0x17000213")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60008CA")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000217")]
	internal bool valid
	{
		[Address(RVA = "0x2DFD360", Offset = "0x2DFC760", Length = "0xC1")]
		[Token(Token = "0x60008D1")]
		internal get { } //Length: 193
	}

	[Token(Token = "0x17000212")]
	public override int version
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008C9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000215")]
	public Shader xrMirrorViewPS
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60008CD")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD430", Offset = "0x2DFC830", Length = "0x65")]
		[Token(Token = "0x60008CE")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000216")]
	public Shader xrMotionVector
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60008CF")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD4A0", Offset = "0x2DFC8A0", Length = "0x65")]
		[Token(Token = "0x60008D0")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000214")]
	public Shader xrOcclusionMeshPS
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60008CB")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD510", Offset = "0x2DFC910", Length = "0x65")]
		[Token(Token = "0x60008CC")]
		 set { } //Length: 101
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008D2")]
	public UniversalRenderPipelineRuntimeXRResources() { }

	[Address(RVA = "0x2DFD360", Offset = "0x2DFC760", Length = "0xC1")]
	[Token(Token = "0x60008D1")]
	internal bool get_valid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008C9")]
	public override int get_version() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60008CD")]
	public Shader get_xrMirrorViewPS() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60008CF")]
	public Shader get_xrMotionVector() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60008CB")]
	public Shader get_xrOcclusionMeshPS() { }

	[Address(RVA = "0x2DFD430", Offset = "0x2DFC830", Length = "0x65")]
	[Token(Token = "0x60008CE")]
	public void set_xrMirrorViewPS(Shader value) { }

	[Address(RVA = "0x2DFD4A0", Offset = "0x2DFC8A0", Length = "0x65")]
	[Token(Token = "0x60008D0")]
	public void set_xrMotionVector(Shader value) { }

	[Address(RVA = "0x2DFD510", Offset = "0x2DFC910", Length = "0x65")]
	[Token(Token = "0x60008CC")]
	public void set_xrOcclusionMeshPS(Shader value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60008CA")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

