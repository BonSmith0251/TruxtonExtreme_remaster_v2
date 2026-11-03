namespace UnityEngine.Rendering;

[CategoryInfo(Name = "R : Rendering Debugger Resources", Order = 100)]
[ElementInfo(Order = 0)]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x200016C")]
internal class RenderingDebuggerRuntimeResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x200016D")]
	private enum Version : int
	{
		Initial = 0,
		Count = 1,
		Last = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006F0")]
	private Version m_version; //Field offset: 0x10

	[Token(Token = "0x17000160")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B74")]
		private get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B75")]
	public RenderingDebuggerRuntimeResources() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B74")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

