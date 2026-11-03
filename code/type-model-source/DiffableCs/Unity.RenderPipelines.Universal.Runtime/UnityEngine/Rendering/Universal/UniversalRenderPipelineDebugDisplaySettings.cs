namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200006E")]
public class UniversalRenderPipelineDebugDisplaySettings : DebugDisplaySettings<UniversalRenderPipelineDebugDisplaySettings>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000221")]
	private DebugDisplaySettingsCommon <commonSettings>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000222")]
	private DebugDisplaySettingsMaterial <materialSettings>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000223")]
	private DebugDisplaySettingsRendering <renderingSettings>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000224")]
	private DebugDisplaySettingsLighting <lightingSettings>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000225")]
	private DebugDisplaySettingsVolume <volumeSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000226")]
	private DebugDisplaySettingsStats<URPProfileId> <displayStats>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000227")]
	private DebugDisplayGPUResidentDrawer <gpuResidentDrawerSettings>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170000B9")]
	private DebugDisplaySettingsCommon commonSettings
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000291")]
		private get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000292")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BE")]
	internal DebugDisplaySettingsStats<URPProfileId> displayStats
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600029B")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600029C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BF")]
	internal DebugDisplayGPUResidentDrawer gpuResidentDrawerSettings
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600029D")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600029E")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000C0")]
	public virtual bool IsPostProcessingAllowed
	{
		[Address(RVA = "0x2D8A060", Offset = "0x2D89460", Length = "0x289")]
		[Token(Token = "0x600029F")]
		 get { } //Length: 649
	}

	[Token(Token = "0x170000BC")]
	public private DebugDisplaySettingsLighting lightingSettings
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000297")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000298")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BA")]
	public private DebugDisplaySettingsMaterial materialSettings
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000293")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000294")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BB")]
	public private DebugDisplaySettingsRendering renderingSettings
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000295")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000296")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BD")]
	public private DebugDisplaySettingsVolume volumeSettings
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000299")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600029A")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2D8A000", Offset = "0x2D89400", Length = "0x5A")]
	[Token(Token = "0x60002A0")]
	public UniversalRenderPipelineDebugDisplaySettings() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000291")]
	private DebugDisplaySettingsCommon get_commonSettings() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600029B")]
	internal DebugDisplaySettingsStats<URPProfileId> get_displayStats() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600029D")]
	internal DebugDisplayGPUResidentDrawer get_gpuResidentDrawerSettings() { }

	[Address(RVA = "0x2D8A060", Offset = "0x2D89460", Length = "0x289")]
	[Token(Token = "0x600029F")]
	public virtual bool get_IsPostProcessingAllowed() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000297")]
	public DebugDisplaySettingsLighting get_lightingSettings() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000293")]
	public DebugDisplaySettingsMaterial get_materialSettings() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000295")]
	public DebugDisplaySettingsRendering get_renderingSettings() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000299")]
	public DebugDisplaySettingsVolume get_volumeSettings() { }

	[Address(RVA = "0x2D89B40", Offset = "0x2D88F40", Length = "0x3B5")]
	[Token(Token = "0x60002A1")]
	public virtual void Reset() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000292")]
	private void set_commonSettings(DebugDisplaySettingsCommon value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600029C")]
	private void set_displayStats(DebugDisplaySettingsStats<URPProfileId> value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600029E")]
	private void set_gpuResidentDrawerSettings(DebugDisplayGPUResidentDrawer value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000298")]
	private void set_lightingSettings(DebugDisplaySettingsLighting value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000294")]
	private void set_materialSettings(DebugDisplaySettingsMaterial value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000296")]
	private void set_renderingSettings(DebugDisplaySettingsRendering value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600029A")]
	private void set_volumeSettings(DebugDisplaySettingsVolume value) { }

	[Address(RVA = "0x2D89F00", Offset = "0x2D89300", Length = "0x5D")]
	[Token(Token = "0x60002A2")]
	internal void UpdateDisplayStats() { }

	[Address(RVA = "0x2D89F60", Offset = "0x2D89360", Length = "0x92")]
	[Token(Token = "0x60002A3")]
	internal void UpdateMaterials() { }

}

