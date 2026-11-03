namespace UnityEngine.Rendering;

[Token(Token = "0x20003E4")]
public abstract class RenderPipeline
{
	[Token(Token = "0x20003E5")]
	internal class StandardRequest
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CC8")]
		public RenderTexture destination; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CC9")]
		public int mipLevel; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000CCA")]
		public CubemapFace face; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000CCB")]
		public int slice; //Field offset: 0x20

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CC7")]
	private bool <disposed>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700043C")]
	public override RenderPipelineGlobalSettings defaultSettings
	{
		[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
		[Token(Token = "0x6001DE4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700043B")]
	public private bool disposed
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001DE0")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001DE1")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001DE5")]
	protected RenderPipeline() { }

	[Address(RVA = "0x30C3DB0", Offset = "0x30C31B0", Length = "0x62")]
	[Token(Token = "0x6001DDA")]
	protected static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x30C3E20", Offset = "0x30C3220", Length = "0xBD")]
	[Token(Token = "0x6001DD9")]
	protected static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[Address(RVA = "0x30C5390", Offset = "0x30C4790", Length = "0x66")]
	[Token(Token = "0x6001DE2")]
	internal void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001DE3")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x30C4430", Offset = "0x30C3830", Length = "0x62")]
	[Token(Token = "0x6001DDC")]
	protected static void EndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x30C44A0", Offset = "0x30C38A0", Length = "0xBD")]
	[Token(Token = "0x6001DDB")]
	protected static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x6001DE4")]
	public override RenderPipelineGlobalSettings get_defaultSettings() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001DE0")]
	public bool get_disposed() { }

	[Address(RVA = "0x8E8510", Offset = "0x8E7910", Length = "0xDE")]
	[Token(Token = "0x6001DDF")]
	internal void InternalProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	[Address(RVA = "0x30C5400", Offset = "0x30C4800", Length = "0x8B")]
	[Token(Token = "0x6001DDE")]
	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x6001DD8")]
	protected private override bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001DD7")]
	protected override void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("Render with an array parameter is deprecated. Use Render with a list parameter instead. If you're extending the RenderPipeline class, override the Render method with a List parameter to perform rendering in order to avoid unnecessary allocations and copies. #from 6000.1", False)]
	[Token(Token = "0x6001DD6")]
	protected override void Render(ScriptableRenderContext context, Camera[] cameras) { }

	[Address(RVA = "0x30C5490", Offset = "0x30C4890", Length = "0x79")]
	[Token(Token = "0x6001DDD")]
	protected override void Render(ScriptableRenderContext context, List<Camera> cameras) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001DE1")]
	private void set_disposed(bool value) { }

}

