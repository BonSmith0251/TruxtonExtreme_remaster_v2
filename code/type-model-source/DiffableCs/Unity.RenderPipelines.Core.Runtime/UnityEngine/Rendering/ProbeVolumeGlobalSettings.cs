namespace UnityEngine.Rendering;

[CategoryInfo(Name = "Lighting", Order = 20)]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x2000137")]
internal class ProbeVolumeGlobalSettings : IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005E3")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40005E4")]
	[Tooltip("Enabling this will make APV baked data assets compatible with Addressables and Asset Bundles. This will also make Disk Streaming unavailable. After changing this setting, a clean rebuild may be required for data assets to be included in Adressables and Asset Bundles.")]
	private bool m_ProbeVolumeDisableStreamingAssets; //Field offset: 0x14

	[Token(Token = "0x17000139")]
	public bool probeVolumeDisableStreamingAssets
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000AA1")]
		 get { } //Length: 5
		[Address(RVA = "0x2C1B580", Offset = "0x2C1A980", Length = "0x66")]
		[Token(Token = "0x6000AA2")]
		 set { } //Length: 102
	}

	[Token(Token = "0x17000138")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000AA0")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1F29D20", Offset = "0x1F29120", Length = "0xE")]
	[Token(Token = "0x6000AA3")]
	public ProbeVolumeGlobalSettings() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x6000AA1")]
	public bool get_probeVolumeDisableStreamingAssets() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000AA0")]
	public override int get_version() { }

	[Address(RVA = "0x2C1B580", Offset = "0x2C1A980", Length = "0x66")]
	[Token(Token = "0x6000AA2")]
	public void set_probeVolumeDisableStreamingAssets(bool value) { }

}

