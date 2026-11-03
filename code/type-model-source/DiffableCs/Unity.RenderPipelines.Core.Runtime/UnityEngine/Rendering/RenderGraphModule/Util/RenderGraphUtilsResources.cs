namespace UnityEngine.Rendering.RenderGraphModule.Util;

[Category("Resources/Render Graph Helper Function Resources")]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x20002AE")]
internal class RenderGraphUtilsResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x20002AF")]
	internal enum Version : int
	{
		Initial = 0,
		Count = 1,
		Latest = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000C25")]
	private Version m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Shaders/CoreCopy.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000C26")]
	internal Shader m_CoreCopyPS; //Field offset: 0x18

	[Token(Token = "0x17000260")]
	public Shader coreCopyPS
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001323")]
		 get { } //Length: 5
		[Address(RVA = "0x2CA6EC0", Offset = "0x2CA62C0", Length = "0x65")]
		[Token(Token = "0x6001324")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700025F")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001322")]
		private get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001325")]
	public RenderGraphUtilsResources() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001323")]
	public Shader get_coreCopyPS() { }

	[Address(RVA = "0x2CA6EC0", Offset = "0x2CA62C0", Length = "0x65")]
	[Token(Token = "0x6001324")]
	public void set_coreCopyPS(Shader value) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6001322")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

