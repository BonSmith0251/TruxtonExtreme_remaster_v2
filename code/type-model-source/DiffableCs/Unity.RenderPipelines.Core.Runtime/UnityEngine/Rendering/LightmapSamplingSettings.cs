namespace UnityEngine.Rendering;

[CategoryInfo(Name = "Lighting", Order = 20)]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x200016B")]
public class LightmapSamplingSettings : IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006EE")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40006EF")]
	[Tooltip("Use Bicubic Lightmap Sampling. Enabling this will improve the appearance of lightmaps, but may worsen performance on lower end platforms.")]
	private bool m_UseBicubicLightmapSampling; //Field offset: 0x14

	[Token(Token = "0x1700015E")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000B70")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700015D")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B6F")]
		private get { } //Length: 85
	}

	[Token(Token = "0x1700015F")]
	public bool useBicubicLightmapSampling
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000B71")]
		 get { } //Length: 5
		[Address(RVA = "0x2C2F940", Offset = "0x2C2ED40", Length = "0x66")]
		[Token(Token = "0x6000B72")]
		 set { } //Length: 102
	}

	[Address(RVA = "0x1F29D20", Offset = "0x1F29120", Length = "0xE")]
	[Token(Token = "0x6000B73")]
	public LightmapSamplingSettings() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000B71")]
	public bool get_useBicubicLightmapSampling() { }

	[Address(RVA = "0x2C2F940", Offset = "0x2C2ED40", Length = "0x66")]
	[Token(Token = "0x6000B72")]
	public void set_useBicubicLightmapSampling(bool value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000B70")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B6F")]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

