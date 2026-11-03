namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "Render Graph", Order = 50)]
[ElementInfo(Order = -10)]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x200019D")]
public class RenderGraphSettings : IRenderPipelineGraphicsSettings
{
	[Token(Token = "0x200019E")]
	public enum Version : int
	{
		Initial = 0,
	}

	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000914")]
	private Version m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[RecreatePipelineOnChange]
	[SerializeField]
	[Token(Token = "0x4000915")]
	[Tooltip("When enabled, URP does not use the Render Graph API to construct and execute the frame. Use this option only for compatibility purposes.")]
	private bool m_EnableRenderCompatibilityMode; //Field offset: 0x14

	[Token(Token = "0x1700021D")]
	public bool enableRenderCompatibilityMode
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60008F2")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Obsolete("Compatibility Mode is being removed. This setter is not accessible without the define URP_COMPATIBILITY_MODE. #from(6000.3) #breakingFrom(6000.3)", True)]
		[Token(Token = "0x60008F3")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700021C")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60008F1")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700021B")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60008F0")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008F5")]
	public RenderGraphSettings() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008F2")]
	public bool get_enableRenderCompatibilityMode() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60008F0")]
	public override int get_version() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("Compatibility Mode is being removed. This setter is not accessible without the define URP_COMPATIBILITY_MODE. #from(6000.3) #breakingFrom(6000.3)", True)]
	[Token(Token = "0x60008F3")]
	public void set_enableRenderCompatibilityMode(bool value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[Token(Token = "0x60008F4")]
	internal void SetCompatibilityModeFromUpgrade(bool value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60008F1")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

