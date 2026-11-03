namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200003A")]
public class IAdaptivePerformanceSettings : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200003B")]
	private sealed class <>c__DisplayClass41_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000101")]
		public PropertyInfo property; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001ED")]
		public <>c__DisplayClass41_0() { }

		[Address(RVA = "0x2F99FC0", Offset = "0x2F993C0", Length = "0x7D")]
		[Token(Token = "0x60001EE")]
		internal bool <ApplyScalerProfileToAllScalers>b__0(AdaptivePerformanceScaler s) { }

	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000F5")]
	[Tooltip("Enable Logging in Devmode")]
	private bool m_Logging; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Token(Token = "0x40000F6")]
	[Tooltip("Automatic Performance Mode")]
	private bool m_AutomaticPerformanceModeEnabled; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[SerializeField]
	[Token(Token = "0x40000F7")]
	[Tooltip("Automatic Game Mode")]
	private bool m_AutomaticGameModeEnabled; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1B")]
	[SerializeField]
	[Token(Token = "0x40000F8")]
	[Tooltip("Enables the CPU and GPU boost mode before engine startup to decrease startup time.")]
	private bool m_EnableBoostOnStartup; //Field offset: 0x1B
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40000F9")]
	[Tooltip("Logging Frequency (Development mode only)")]
	private int m_StatsLoggingFrequencyInFrames; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000FA")]
	[Tooltip("Indexer Settings")]
	private AdaptivePerformanceIndexerSettings m_IndexerSettings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000FB")]
	[Tooltip("Scaler Settings")]
	private AdaptivePerformanceScalerSettings m_ScalerSettings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000FC")]
	private List<AdaptivePerformanceScaler> m_AddedScalerViaScan; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000FD")]
	private AdaptivePerformanceScalerProfile m_ActiveScalerProfile; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000FE")]
	private AdaptivePerformanceScalerProfile[] m_scalerProfileList; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000FF")]
	internal int m_DefaultScalerProfilerIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000100")]
	private int k_AssetVersion; //Field offset: 0x4C

	[Token(Token = "0x170000AB")]
	public AdaptivePerformanceScalerProfile ActiveScalerProfile
	{
		[Address(RVA = "0x2F98AA0", Offset = "0x2F97EA0", Length = "0x31")]
		[Token(Token = "0x60001E0")]
		 get { } //Length: 49
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60001E1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000AC")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.AdaptivePerformanceModule"})]
	internal List<AdaptivePerformanceScaler> AddedScalerViaScan
	{
		[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
		[Token(Token = "0x60001E2")]
		internal get { } //Length: 7
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60001E3")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170000A5")]
	public bool automaticGameMode
	{
		[Address(RVA = "0x2F8BCA0", Offset = "0x2F8B0A0", Length = "0x7")]
		[Token(Token = "0x60001D5")]
		 get { } //Length: 7
		[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
		[Token(Token = "0x60001D6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A4")]
	public bool automaticPerformanceMode
	{
		[Address(RVA = "0x2F8BC90", Offset = "0x2F8B090", Length = "0x7")]
		[Token(Token = "0x60001D3")]
		 get { } //Length: 7
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[Token(Token = "0x60001D4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000AD")]
	public int defaultScalerProfilerIndex
	{
		[Address(RVA = "0x2F98AE0", Offset = "0x2F97EE0", Length = "0x6")]
		[Token(Token = "0x60001E9")]
		 get { } //Length: 6
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x60001EA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A6")]
	public bool enableBoostOnStartup
	{
		[Address(RVA = "0x2F98AF0", Offset = "0x2F97EF0", Length = "0x7")]
		[Token(Token = "0x60001D7")]
		 get { } //Length: 7
		[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
		[Token(Token = "0x60001D8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A8")]
	public AdaptivePerformanceIndexerSettings indexerSettings
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x60001DB")]
		 get { } //Length: 7
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60001DC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000A3")]
	public bool logging
	{
		[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
		[Token(Token = "0x60001D1")]
		 get { } //Length: 7
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x60001D2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000AA")]
	public AdaptivePerformanceScalerProfile[] ScalerProfiles
	{
		[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
		[Token(Token = "0x60001DF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000A9")]
	public AdaptivePerformanceScalerSettings scalerSettings
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 7
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60001DE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000A7")]
	public int statsLoggingFrequencyInFrames
	{
		[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
		[Token(Token = "0x60001D9")]
		 get { } //Length: 6
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x60001DA")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2F98950", Offset = "0x2F97D50", Length = "0x141")]
	[Token(Token = "0x60001EC")]
	public IAdaptivePerformanceSettings() { }

	[Address(RVA = "0x2F97A20", Offset = "0x2F96E20", Length = "0x1EB")]
	[Token(Token = "0x60001E4")]
	public void AddScalerProfileWithDefaultScalers(string name = "") { }

	[Address(RVA = "0x2F97C10", Offset = "0x2F97010", Length = "0x664")]
	[Token(Token = "0x60001E7")]
	private bool ApplyScalerProfileToAllScalers() { }

	[Address(RVA = "0x2F98280", Offset = "0x2F97680", Length = "0x17F")]
	[Token(Token = "0x60001E5")]
	public void DeleteScalerProfileAt(int index) { }

	[Address(RVA = "0x2F98AA0", Offset = "0x2F97EA0", Length = "0x31")]
	[Token(Token = "0x60001E0")]
	public AdaptivePerformanceScalerProfile get_ActiveScalerProfile() { }

	[Address(RVA = "0x2F94490", Offset = "0x2F93890", Length = "0x7")]
	[Token(Token = "0x60001E2")]
	internal List<AdaptivePerformanceScaler> get_AddedScalerViaScan() { }

	[Address(RVA = "0x2F8BCA0", Offset = "0x2F8B0A0", Length = "0x7")]
	[Token(Token = "0x60001D5")]
	public bool get_automaticGameMode() { }

	[Address(RVA = "0x2F8BC90", Offset = "0x2F8B090", Length = "0x7")]
	[Token(Token = "0x60001D3")]
	public bool get_automaticPerformanceMode() { }

	[Address(RVA = "0x2F98AE0", Offset = "0x2F97EE0", Length = "0x6")]
	[Token(Token = "0x60001E9")]
	public int get_defaultScalerProfilerIndex() { }

	[Address(RVA = "0x2F98AF0", Offset = "0x2F97EF0", Length = "0x7")]
	[Token(Token = "0x60001D7")]
	public bool get_enableBoostOnStartup() { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x60001DB")]
	public AdaptivePerformanceIndexerSettings get_indexerSettings() { }

	[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
	[Token(Token = "0x60001D1")]
	public bool get_logging() { }

	[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
	[Token(Token = "0x60001DF")]
	public AdaptivePerformanceScalerProfile[] get_ScalerProfiles() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x60001DD")]
	public AdaptivePerformanceScalerSettings get_scalerSettings() { }

	[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
	[Token(Token = "0x60001D9")]
	public int get_statsLoggingFrequencyInFrames() { }

	[Address(RVA = "0x2F98400", Offset = "0x2F97800", Length = "0x12C")]
	[Token(Token = "0x60001E8")]
	public String[] GetAvailableScalerProfiles() { }

	[Address(RVA = "0x2F98530", Offset = "0x2F97930", Length = "0x407")]
	[Token(Token = "0x60001E6")]
	public void LoadScalerProfile(string scalerProfileName) { }

	[Address(RVA = "0x2F98940", Offset = "0x2F97D40", Length = "0xE")]
	[Token(Token = "0x60001EB")]
	public void OnEnable() { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x60001E1")]
	public void set_ActiveScalerProfile(AdaptivePerformanceScalerProfile value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60001E3")]
	internal void set_AddedScalerViaScan(List<AdaptivePerformanceScaler> value) { }

	[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
	[Token(Token = "0x60001D6")]
	public void set_automaticGameMode(bool value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[Token(Token = "0x60001D4")]
	public void set_automaticPerformanceMode(bool value) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x60001EA")]
	public void set_defaultScalerProfilerIndex(int value) { }

	[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
	[Token(Token = "0x60001D8")]
	public void set_enableBoostOnStartup(bool value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60001DC")]
	public void set_indexerSettings(AdaptivePerformanceIndexerSettings value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x60001D2")]
	public void set_logging(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60001DE")]
	public void set_scalerSettings(AdaptivePerformanceScalerSettings value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x60001DA")]
	public void set_statsLoggingFrequencyInFrames(int value) { }

}

