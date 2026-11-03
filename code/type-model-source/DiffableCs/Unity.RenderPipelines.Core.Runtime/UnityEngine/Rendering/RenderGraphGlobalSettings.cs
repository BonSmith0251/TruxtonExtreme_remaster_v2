namespace UnityEngine.Rendering;

[CategoryInfo(Name = "Render Graph", Order = 50)]
[ElementInfo(Order = 0)]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x200015F")]
public class RenderGraphGlobalSettings : IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x2000160")]
	private enum Version : int
	{
		Initial = 0,
		Count = 1,
		Last = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006DC")]
	private Version m_version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[RecreatePipelineOnChange]
	[SerializeField]
	[Token(Token = "0x40006DD")]
	[Tooltip("Enable caching of render graph compilation from one frame to another.")]
	private bool m_EnableCompilationCaching; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[RecreatePipelineOnChange]
	[SerializeField]
	[Token(Token = "0x40006DE")]
	[Tooltip("Enable validity checks of render graph in Editor and Development mode. Always disabled in Release build.")]
	private bool m_EnableValidityChecks; //Field offset: 0x15

	[Token(Token = "0x17000150")]
	public bool enableCompilationCaching
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000B4D")]
		 get { } //Length: 5
		[Address(RVA = "0x2C31370", Offset = "0x2C30770", Length = "0x66")]
		[Token(Token = "0x6000B4E")]
		 set { } //Length: 102
	}

	[Token(Token = "0x17000151")]
	public bool enableValidityChecks
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x6000B4F")]
		 get { } //Length: 5
		[Address(RVA = "0x2C313E0", Offset = "0x2C307E0", Length = "0x66")]
		[Token(Token = "0x6000B50")]
		 set { } //Length: 102
	}

	[Token(Token = "0x1700014E")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000B4B")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700014F")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B4C")]
		private get { } //Length: 85
	}

	[Address(RVA = "0x2C31360", Offset = "0x2C30760", Length = "0xD")]
	[Token(Token = "0x6000B51")]
	public RenderGraphGlobalSettings() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000B4D")]
	public bool get_enableCompilationCaching() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x6000B4F")]
	public bool get_enableValidityChecks() { }

	[Address(RVA = "0x2C31370", Offset = "0x2C30770", Length = "0x66")]
	[Token(Token = "0x6000B4E")]
	public void set_enableCompilationCaching(bool value) { }

	[Address(RVA = "0x2C313E0", Offset = "0x2C307E0", Length = "0x66")]
	[Token(Token = "0x6000B50")]
	public void set_enableValidityChecks(bool value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000B4B")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B4C")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

