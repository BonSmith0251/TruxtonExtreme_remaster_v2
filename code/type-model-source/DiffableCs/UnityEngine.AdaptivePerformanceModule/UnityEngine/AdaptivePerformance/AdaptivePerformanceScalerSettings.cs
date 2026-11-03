namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000038")]
public class AdaptivePerformanceScalerSettings
{
	[Token(Token = "0x40000EC")]
	internal static readonly List<Type> k_DefaultScalerNames; //Field offset: 0x0
	[Token(Token = "0x40000E1")]
	private const string obsoleteMsg = "AdaptiveShadowCascades has been renamed. Please use AdaptiveShadowCascade. (UnityUpgradable) -> AdaptiveShadowCascade"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000DA")]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the application update rate using Application.TargetFramerate")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveFramerate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000DB")]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the resolution of all render targets that allow dynamic resolution.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveResolution; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	[Tooltip("Settings for a scaler used by the Indexer to control if dynamic batching is enabled.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveBatching; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000DD")]
	[Tooltip("Settings for a scaler used by the Indexer for adjusting at what distance LODs are switched.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveLOD; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000DE")]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the size of the palette used for color grading in URP.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveLut; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000DF")]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the level of antialiasing.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveMSAA; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000E0")]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the number of shadow cascades to be used.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowCascade; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000E2")]
	[Tooltip("Settings for a scaler used by the Indexer to change the distance at which shadows are rendered.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowDistance; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40000E3")]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the resolution of shadow maps.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowmapResolution; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40000E4")]
	[Tooltip("Settings for a scaler used by the Indexer to adjust the quality of shadows.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveShadowQuality; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40000E5")]
	[Tooltip("Settings for a scaler used by the Indexer to change if objects in the scene are sorted by depth before rendering to reduce overdraw.")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveSorting; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40000E6")]
	[Tooltip("Settings for a scaler used by the Indexer to disable transparent objects rendering")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveTransparency; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40000E7")]
	[Tooltip("Settings for a scaler used by the Indexer to change the view distance")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveViewDistance; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40000E8")]
	[Tooltip("Settings for a scaler used by the Indexer to change physics properties")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptivePhysics; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40000E9")]
	[Tooltip("Settings for a scaler used by the Indexer to change decal properties")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveDecals; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40000EA")]
	[Tooltip("Settings for a scaler used by the Indexer to change the layer culling distance")]
	private AdaptivePerformanceScalerSettingsBase m_AdaptiveLayerCulling; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000EB")]
	private List<AdaptivePerformanceScalerSettingsBase> m_DefaultScalerSettings; //Field offset: 0x90

	[Token(Token = "0x1700008B")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveBatching
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 7
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60001A1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000098")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveDecals
	{
		[Address(RVA = "0x2F94460", Offset = "0x2F93860", Length = "0xA")]
		[Token(Token = "0x60001B9")]
		 get { } //Length: 10
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x60001BA")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000089")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveFramerate
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x600019C")]
		 get { } //Length: 7
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x600019D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000099")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveLayerCulling
	{
		[Address(RVA = "0x2F94480", Offset = "0x2F93880", Length = "0xA")]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 10
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x60001BC")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700008C")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveLOD
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x60001A2")]
		 get { } //Length: 7
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60001A3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008D")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveLut
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 7
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60001A5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008E")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveMSAA
	{
		[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 7
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60001A7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000097")]
	public AdaptivePerformanceScalerSettingsBase AdaptivePhysics
	{
		[Address(RVA = "0x2F944B0", Offset = "0x2F938B0", Length = "0x7")]
		[Token(Token = "0x60001B7")]
		 get { } //Length: 7
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[Token(Token = "0x60001B8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008A")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveResolution
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x600019E")]
		 get { } //Length: 7
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600019F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000090")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowCascade
	{
		[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
		[Token(Token = "0x60001A9")]
		 get { } //Length: 7
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x60001AA")]
		 set { } //Length: 13
	}

	[Obsolete("AdaptiveShadowCascades has been renamed. Please use AdaptiveShadowCascade. (UnityUpgradable) -> AdaptiveShadowCascade", False)]
	[Token(Token = "0x1700008F")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowCascades
	{
		[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000091")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowDistance
	{
		[Address(RVA = "0x2F944D0", Offset = "0x2F938D0", Length = "0x7")]
		[Token(Token = "0x60001AB")]
		 get { } //Length: 7
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60001AC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000092")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowmapResolution
	{
		[Address(RVA = "0x2F944F0", Offset = "0x2F938F0", Length = "0x7")]
		[Token(Token = "0x60001AD")]
		 get { } //Length: 7
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60001AE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000093")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveShadowQuality
	{
		[Address(RVA = "0x2F944E0", Offset = "0x2F938E0", Length = "0x7")]
		[Token(Token = "0x60001AF")]
		 get { } //Length: 7
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x60001B0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000094")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveSorting
	{
		[Address(RVA = "0x2F94500", Offset = "0x2F93900", Length = "0x7")]
		[Token(Token = "0x60001B1")]
		 get { } //Length: 7
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x60001B2")]
		 set { } //Length: 995
	}

	[Token(Token = "0x17000095")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveTransparency
	{
		[Address(RVA = "0x2F94510", Offset = "0x2F93910", Length = "0x7")]
		[Token(Token = "0x60001B3")]
		 get { } //Length: 7
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x60001B4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000096")]
	public AdaptivePerformanceScalerSettingsBase AdaptiveViewDistance
	{
		[Address(RVA = "0x2F94520", Offset = "0x2F93920", Length = "0x7")]
		[Token(Token = "0x60001B5")]
		 get { } //Length: 7
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x60001B6")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700009A")]
	public List<AdaptivePerformanceScalerSettingsBase> DefaultScalerSettings
	{
		[Address(RVA = "0x2F94530", Offset = "0x2F93930", Length = "0x1F3")]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 499
	}

	[Address(RVA = "0x2F93380", Offset = "0x2F92780", Length = "0x891")]
	[Token(Token = "0x60001BF")]
	private static AdaptivePerformanceScalerSettings() { }

	[Address(RVA = "0x2F93C20", Offset = "0x2F93020", Length = "0x831")]
	[Token(Token = "0x60001BE")]
	public AdaptivePerformanceScalerSettings() { }

	[Address(RVA = "0x2F92E30", Offset = "0x2F92230", Length = "0x544")]
	[Token(Token = "0x600019A")]
	public void ApplySettings(AdaptivePerformanceScalerSettings settings) { }

	[Address(RVA = "0x2F92DE0", Offset = "0x2F921E0", Length = "0x4A")]
	[Token(Token = "0x600019B")]
	private void ApplySettingsBase(AdaptivePerformanceScalerSettingsBase destination, AdaptivePerformanceScalerSettingsBase sources) { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x60001A0")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveBatching() { }

	[Address(RVA = "0x2F94460", Offset = "0x2F93860", Length = "0xA")]
	[Token(Token = "0x60001B9")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveDecals() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x600019C")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveFramerate() { }

	[Address(RVA = "0x2F94480", Offset = "0x2F93880", Length = "0xA")]
	[Token(Token = "0x60001BB")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveLayerCulling() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x60001A2")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveLOD() { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x60001A4")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveLut() { }

	[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
	[Token(Token = "0x60001A6")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveMSAA() { }

	[Address(RVA = "0x2F944B0", Offset = "0x2F938B0", Length = "0x7")]
	[Token(Token = "0x60001B7")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptivePhysics() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x600019E")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveResolution() { }

	[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
	[Token(Token = "0x60001A9")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowCascade() { }

	[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
	[Token(Token = "0x60001A8")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowCascades() { }

	[Address(RVA = "0x2F944D0", Offset = "0x2F938D0", Length = "0x7")]
	[Token(Token = "0x60001AB")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowDistance() { }

	[Address(RVA = "0x2F944F0", Offset = "0x2F938F0", Length = "0x7")]
	[Token(Token = "0x60001AD")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowmapResolution() { }

	[Address(RVA = "0x2F944E0", Offset = "0x2F938E0", Length = "0x7")]
	[Token(Token = "0x60001AF")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveShadowQuality() { }

	[Address(RVA = "0x2F94500", Offset = "0x2F93900", Length = "0x7")]
	[Token(Token = "0x60001B1")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveSorting() { }

	[Address(RVA = "0x2F94510", Offset = "0x2F93910", Length = "0x7")]
	[Token(Token = "0x60001B3")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveTransparency() { }

	[Address(RVA = "0x2F94520", Offset = "0x2F93920", Length = "0x7")]
	[Token(Token = "0x60001B5")]
	public AdaptivePerformanceScalerSettingsBase get_AdaptiveViewDistance() { }

	[Address(RVA = "0x2F94530", Offset = "0x2F93930", Length = "0x1F3")]
	[Token(Token = "0x60001BD")]
	public List<AdaptivePerformanceScalerSettingsBase> get_DefaultScalerSettings() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60001A1")]
	public void set_AdaptiveBatching(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x60001BA")]
	public void set_AdaptiveDecals(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x600019D")]
	public void set_AdaptiveFramerate(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x60001BC")]
	public void set_AdaptiveLayerCulling(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60001A3")]
	public void set_AdaptiveLOD(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60001A5")]
	public void set_AdaptiveLut(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x60001A7")]
	public void set_AdaptiveMSAA(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x60001B8")]
	public void set_AdaptivePhysics(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600019F")]
	public void set_AdaptiveResolution(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x60001AA")]
	public void set_AdaptiveShadowCascade(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60001AC")]
	public void set_AdaptiveShadowDistance(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60001AE")]
	public void set_AdaptiveShadowmapResolution(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60001B0")]
	public void set_AdaptiveShadowQuality(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60001B2")]
	public void set_AdaptiveSorting(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60001B4")]
	public void set_AdaptiveTransparency(AdaptivePerformanceScalerSettingsBase value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x60001B6")]
	public void set_AdaptiveViewDistance(AdaptivePerformanceScalerSettingsBase value) { }

}

