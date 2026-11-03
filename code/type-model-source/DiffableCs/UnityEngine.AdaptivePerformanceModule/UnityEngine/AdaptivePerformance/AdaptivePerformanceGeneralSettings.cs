namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000032")]
public class AdaptivePerformanceGeneralSettings : ScriptableObject
{
	[Token(Token = "0x40000C2")]
	public static string k_SettingsKey; //Field offset: 0x0
	[Token(Token = "0x40000C3")]
	internal static AdaptivePerformanceGeneralSettings s_RuntimeSettingsInstance; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000C4")]
	internal AdaptivePerformanceManagerSettings m_LoaderManagerInstance; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000C5")]
	[Tooltip("Enable this to automatically start up Adaptive Performance at runtime.")]
	internal bool m_InitManagerOnStart; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000C6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.AdaptivePerformanceModule"})]
	internal string m_LastSelectedProvider; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C7")]
	private AdaptivePerformanceManagerSettings m_AdaptivePerformanceManager; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C8")]
	private bool m_ProviderIntialized; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x40000C9")]
	private bool m_ProviderStarted; //Field offset: 0x39

	[Token(Token = "0x17000079")]
	public AdaptivePerformanceManagerSettings AssignedSettings
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x600015E")]
		 get { } //Length: 7
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600015F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700007A")]
	public bool InitManagerOnStart
	{
		[Address(RVA = "0x2F895D0", Offset = "0x2F889D0", Length = "0x7")]
		[Token(Token = "0x6000160")]
		 get { } //Length: 7
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6000161")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000078")]
	public static AdaptivePerformanceGeneralSettings Instance
	{
		[Address(RVA = "0x2F895E0", Offset = "0x2F889E0", Length = "0x4F")]
		[Token(Token = "0x600015C")]
		 get { } //Length: 79
		[Address(RVA = "0x2F89650", Offset = "0x2F88A50", Length = "0x6E")]
		[Token(Token = "0x600015D")]
		 set { } //Length: 110
	}

	[Token(Token = "0x17000076")]
	public bool IsProviderInitialized
	{
		[Address(RVA = "0x2F89630", Offset = "0x2F88A30", Length = "0x7")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000077")]
	public bool IsProviderStarted
	{
		[Address(RVA = "0x2F89640", Offset = "0x2F88A40", Length = "0x7")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000075")]
	public AdaptivePerformanceManagerSettings Manager
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 7
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000159")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2F894B0", Offset = "0x2F888B0", Length = "0x91")]
	[Token(Token = "0x600016C")]
	private static AdaptivePerformanceGeneralSettings() { }

	[Address(RVA = "0x2F89550", Offset = "0x2F88950", Length = "0x7F")]
	[Token(Token = "0x600016B")]
	public AdaptivePerformanceGeneralSettings() { }

	[Address(RVA = "0x2F88A90", Offset = "0x2F87E90", Length = "0xD0")]
	[RequiredByNativeCode(True)]
	[Token(Token = "0x6000165")]
	internal static void AttemptInitializeAdaptivePerformanceGeneralSettingsOnLoad() { }

	[Address(RVA = "0x2F88B70", Offset = "0x2F87F70", Length = "0xD0")]
	[RequiredByNativeCode(True)]
	[Token(Token = "0x6000166")]
	internal static void AttemptStartAdaptivePerformanceGeneralSettingsOnBeforeSplashScreen() { }

	[Address(RVA = "0x2F88C50", Offset = "0x2F88050", Length = "0x111")]
	[Token(Token = "0x6000162")]
	private void Awake() { }

	[Address(RVA = "0x2F88D70", Offset = "0x2F88170", Length = "0xA1")]
	[Token(Token = "0x600016A")]
	internal void DeInitAdaptivePerformance() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x600015E")]
	public AdaptivePerformanceManagerSettings get_AssignedSettings() { }

	[Address(RVA = "0x2F895D0", Offset = "0x2F889D0", Length = "0x7")]
	[Token(Token = "0x6000160")]
	public bool get_InitManagerOnStart() { }

	[Address(RVA = "0x2F895E0", Offset = "0x2F889E0", Length = "0x4F")]
	[Token(Token = "0x600015C")]
	public static AdaptivePerformanceGeneralSettings get_Instance() { }

	[Address(RVA = "0x2F89630", Offset = "0x2F88A30", Length = "0x7")]
	[Token(Token = "0x600015A")]
	public bool get_IsProviderInitialized() { }

	[Address(RVA = "0x2F89640", Offset = "0x2F88A40", Length = "0x7")]
	[Token(Token = "0x600015B")]
	public bool get_IsProviderStarted() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x6000158")]
	public AdaptivePerformanceManagerSettings get_Manager() { }

	[Address(RVA = "0x2F88E20", Offset = "0x2F88220", Length = "0x24F")]
	[Token(Token = "0x6000167")]
	internal void InitAdaptivePerformance() { }

	[Address(RVA = "0x2F89070", Offset = "0x2F88470", Length = "0x7B")]
	[Token(Token = "0x6000164")]
	private void OnDestroy() { }

	[Address(RVA = "0x2F890F0", Offset = "0x2F884F0", Length = "0xCB")]
	[Token(Token = "0x6000163")]
	private static void Quit() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600015F")]
	public void set_AssignedSettings(AdaptivePerformanceManagerSettings value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6000161")]
	public void set_InitManagerOnStart(bool value) { }

	[Address(RVA = "0x2F89650", Offset = "0x2F88A50", Length = "0x6E")]
	[Token(Token = "0x600015D")]
	public static void set_Instance(AdaptivePerformanceGeneralSettings value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000159")]
	public void set_Manager(AdaptivePerformanceManagerSettings value) { }

	[Address(RVA = "0x2F891C0", Offset = "0x2F885C0", Length = "0x1F4")]
	[Token(Token = "0x6000168")]
	internal void StartAdaptivePerformance() { }

	[Address(RVA = "0x2F893C0", Offset = "0x2F887C0", Length = "0xE5")]
	[Token(Token = "0x6000169")]
	internal void StopAdaptivePerformance() { }

}

