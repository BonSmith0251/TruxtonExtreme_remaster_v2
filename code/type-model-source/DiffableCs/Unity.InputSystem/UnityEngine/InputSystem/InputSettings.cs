namespace UnityEngine.InputSystem;

[Token(Token = "0x20000CB")]
public class InputSettings : ScriptableObject
{
	[Token(Token = "0x20000CE")]
	internal enum BackgroundBehavior : int
	{
		ResetAndDisableNonBackgroundDevices = 0,
		ResetAndDisableAllDevices = 1,
		IgnoreFocus = 2,
	}

	[Token(Token = "0x20000CF")]
	internal enum EditorInputBehaviorInPlayMode : int
	{
		PointersAndKeyboardsRespectGameViewFocus = 0,
		AllDevicesRespectGameViewFocus = 1,
		AllDeviceInputAlwaysGoesToGameView = 2,
	}

	[Token(Token = "0x20000D0")]
	internal enum InputActionPropertyDrawerMode : int
	{
		Compact = 0,
		MultilineEffective = 1,
		MultilineBoth = 2,
	}

	[Token(Token = "0x20000CD")]
	internal enum ScrollDeltaBehavior : int
	{
		UniformAcrossAllPlatforms = 0,
		KeepPlatformSpecificInputRange = 1,
	}

	[Token(Token = "0x20000CC")]
	internal enum UpdateMode : int
	{
		ProcessEventsInDynamicUpdate = 1,
		ProcessEventsInFixedUpdate = 2,
		ProcessEventsManually = 3,
	}

	[Token(Token = "0x40004E5")]
	internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40004D0")]
	[Tooltip("Determine which type of devices are used by the application. By default, this is empty meaning that all devices recognized by Unity will be used. Restricting the set of supported devices will make only those devices appear in the input system.")]
	private String[] m_SupportedDevices; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004D1")]
	[Tooltip("Determine when Unity processes events. By default, accumulated input events are flushed out before each fixed update and before each dynamic update. This setting can be used to restrict event processing to only where the application needs it.")]
	private UpdateMode m_UpdateMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40004D2")]
	private ScrollDeltaBehavior m_ScrollDeltaBehavior; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004D3")]
	private int m_MaxEventBytesPerUpdate; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40004D4")]
	private int m_MaxQueuedEventsPerUpdate; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004D5")]
	private bool m_CompensateForScreenOrientation; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40004D6")]
	private BackgroundBehavior m_BackgroundBehavior; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004D7")]
	private EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40004D8")]
	private InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40004D9")]
	private float m_DefaultDeadzoneMin; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40004DA")]
	private float m_DefaultDeadzoneMax; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Min(0.0001)]
	[SerializeField]
	[Token(Token = "0x40004DB")]
	private float m_DefaultButtonPressPoint; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40004DC")]
	private float m_ButtonReleaseThreshold; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40004DD")]
	private float m_DefaultTapTime; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40004DE")]
	private float m_DefaultSlowTapTime; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40004DF")]
	private float m_DefaultHoldTime; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40004E0")]
	private float m_TapRadius; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40004E1")]
	private float m_MultiTapDelayTime; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40004E2")]
	private bool m_DisableRedundantEventsMerging; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[SerializeField]
	[Token(Token = "0x40004E3")]
	private bool m_ShortcutKeysConsumeInputs; //Field offset: 0x65
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004E4")]
	internal HashSet<String> m_FeatureFlags; //Field offset: 0x68

	[Token(Token = "0x170002D2")]
	public BackgroundBehavior backgroundBehavior
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000B23")]
		 get { } //Length: 4
		[Address(RVA = "0x29B7260", Offset = "0x29B6660", Length = "0x10")]
		[Token(Token = "0x6000B24")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002CC")]
	public float buttonReleaseThreshold
	{
		[Address(RVA = "0x21F3FC0", Offset = "0x21F33C0", Length = "0x6")]
		[Token(Token = "0x6000B17")]
		 get { } //Length: 6
		[Address(RVA = "0x29B7270", Offset = "0x29B6670", Length = "0x19")]
		[Token(Token = "0x6000B18")]
		 set { } //Length: 25
	}

	[Token(Token = "0x170002C7")]
	public bool compensateForScreenOrientation
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000B0D")]
		 get { } //Length: 5
		[Address(RVA = "0x29B7290", Offset = "0x29B6690", Length = "0x10")]
		[Token(Token = "0x6000B0E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002CB")]
	public float defaultButtonPressPoint
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x6000B15")]
		 get { } //Length: 6
		[Address(RVA = "0x29B72A0", Offset = "0x29B66A0", Length = "0x36")]
		[Token(Token = "0x6000B16")]
		 set { } //Length: 54
	}

	[Token(Token = "0x170002CA")]
	public float defaultDeadzoneMax
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x6000B13")]
		 get { } //Length: 6
		[Address(RVA = "0x29B72E0", Offset = "0x29B66E0", Length = "0x19")]
		[Token(Token = "0x6000B14")]
		 set { } //Length: 25
	}

	[Token(Token = "0x170002C9")]
	public float defaultDeadzoneMin
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x6000B11")]
		 get { } //Length: 6
		[Address(RVA = "0x29B7300", Offset = "0x29B6700", Length = "0x19")]
		[Token(Token = "0x6000B12")]
		 set { } //Length: 25
	}

	[Token(Token = "0x170002CF")]
	public float defaultHoldTime
	{
		[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
		[Token(Token = "0x6000B1D")]
		 get { } //Length: 6
		[Address(RVA = "0x29B7320", Offset = "0x29B6720", Length = "0x19")]
		[Token(Token = "0x6000B1E")]
		 set { } //Length: 25
	}

	[Token(Token = "0x170002CE")]
	public float defaultSlowTapTime
	{
		[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
		[Token(Token = "0x6000B1B")]
		 get { } //Length: 6
		[Address(RVA = "0x29B7340", Offset = "0x29B6740", Length = "0x19")]
		[Token(Token = "0x6000B1C")]
		 set { } //Length: 25
	}

	[Token(Token = "0x170002CD")]
	public float defaultTapTime
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[Token(Token = "0x6000B19")]
		 get { } //Length: 6
		[Address(RVA = "0x29B7360", Offset = "0x29B6760", Length = "0x19")]
		[Token(Token = "0x6000B1A")]
		 set { } //Length: 25
	}

	[Token(Token = "0x170002D8")]
	public bool disableRedundantEventsMerging
	{
		[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
		[Token(Token = "0x6000B2F")]
		 get { } //Length: 5
		[Address(RVA = "0x29B7380", Offset = "0x29B6780", Length = "0x10")]
		[Token(Token = "0x6000B30")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002D3")]
	public EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000B25")]
		 get { } //Length: 4
		[Address(RVA = "0x29B7390", Offset = "0x29B6790", Length = "0x10")]
		[Token(Token = "0x6000B26")]
		 set { } //Length: 16
	}

	[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", False)]
	[Token(Token = "0x170002C8")]
	public bool filterNoiseOnCurrent
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B0F")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000B10")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170002D4")]
	public InputActionPropertyDrawerMode inputActionPropertyDrawerMode
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x6000B27")]
		 get { } //Length: 4
		[Address(RVA = "0x29B73A0", Offset = "0x29B67A0", Length = "0x10")]
		[Token(Token = "0x6000B28")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002D5")]
	public int maxEventBytesPerUpdate
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000B29")]
		 get { } //Length: 4
		[Address(RVA = "0x29B73B0", Offset = "0x29B67B0", Length = "0x10")]
		[Token(Token = "0x6000B2A")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002D6")]
	public int maxQueuedEventsPerUpdate
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000B2B")]
		 get { } //Length: 4
		[Address(RVA = "0x29B73C0", Offset = "0x29B67C0", Length = "0x10")]
		[Token(Token = "0x6000B2C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002D1")]
	public float multiTapDelayTime
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x6000B21")]
		 get { } //Length: 6
		[Address(RVA = "0x29B73D0", Offset = "0x29B67D0", Length = "0x19")]
		[Token(Token = "0x6000B22")]
		 set { } //Length: 25
	}

	[Token(Token = "0x170002C6")]
	public ScrollDeltaBehavior scrollDeltaBehavior
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000B0B")]
		 get { } //Length: 4
		[Address(RVA = "0x29B73F0", Offset = "0x29B67F0", Length = "0x10")]
		[Token(Token = "0x6000B0C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002D9")]
	public bool shortcutKeysConsumeInput
	{
		[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
		[Token(Token = "0x6000B31")]
		 get { } //Length: 5
		[Address(RVA = "0x29B7400", Offset = "0x29B6800", Length = "0x10")]
		[Token(Token = "0x6000B32")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002D7")]
	public ReadOnlyArray<String> supportedDevices
	{
		[Address(RVA = "0x29B7200", Offset = "0x29B6600", Length = "0x53")]
		[Token(Token = "0x6000B2D")]
		 get { } //Length: 83
		[Address(RVA = "0x29B7410", Offset = "0x29B6810", Length = "0x17E")]
		[Token(Token = "0x6000B2E")]
		 set { } //Length: 382
	}

	[Token(Token = "0x170002D0")]
	public float tapRadius
	{
		[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
		[Token(Token = "0x6000B1F")]
		 get { } //Length: 6
		[Address(RVA = "0x29B7590", Offset = "0x29B6990", Length = "0x19")]
		[Token(Token = "0x6000B20")]
		 set { } //Length: 25
	}

	[Token(Token = "0x170002C5")]
	public UpdateMode updateMode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000B09")]
		 get { } //Length: 4
		[Address(RVA = "0x29B75B0", Offset = "0x29B69B0", Length = "0x10")]
		[Token(Token = "0x6000B0A")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x29B7190", Offset = "0x29B6590", Length = "0x5F")]
	[Token(Token = "0x6000B3A")]
	public InputSettings() { }

	[Address(RVA = "0x29B6670", Offset = "0x29B5A70", Length = "0x6C5")]
	[Token(Token = "0x6000B39")]
	internal static bool AreEqual(InputSettings a, InputSettings b) { }

	[Address(RVA = "0x29B6D40", Offset = "0x29B6140", Length = "0xE5")]
	[Token(Token = "0x6000B38")]
	private static bool CompareFeatureFlag(InputSettings a, InputSettings b, string featureName) { }

	[Address(RVA = "0x29B6E30", Offset = "0x29B6230", Length = "0x13")]
	[Token(Token = "0x6000B36")]
	private static bool CompareFloats(float a, float b) { }

	[Address(RVA = "0x848960", Offset = "0x847D60", Length = "0xBD")]
	[Token(Token = "0x6000B37")]
	private static bool CompareSets(ReadOnlyArray<T> a, ReadOnlyArray<T> b) { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000B23")]
	public BackgroundBehavior get_backgroundBehavior() { }

	[Address(RVA = "0x21F3FC0", Offset = "0x21F33C0", Length = "0x6")]
	[Token(Token = "0x6000B17")]
	public float get_buttonReleaseThreshold() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000B0D")]
	public bool get_compensateForScreenOrientation() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x6000B15")]
	public float get_defaultButtonPressPoint() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x6000B13")]
	public float get_defaultDeadzoneMax() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x6000B11")]
	public float get_defaultDeadzoneMin() { }

	[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
	[Token(Token = "0x6000B1D")]
	public float get_defaultHoldTime() { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[Token(Token = "0x6000B1B")]
	public float get_defaultSlowTapTime() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[Token(Token = "0x6000B19")]
	public float get_defaultTapTime() { }

	[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
	[Token(Token = "0x6000B2F")]
	public bool get_disableRedundantEventsMerging() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000B25")]
	public EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000B0F")]
	public bool get_filterNoiseOnCurrent() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x6000B27")]
	public InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000B29")]
	public int get_maxEventBytesPerUpdate() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000B2B")]
	public int get_maxQueuedEventsPerUpdate() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x6000B21")]
	public float get_multiTapDelayTime() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000B0B")]
	public ScrollDeltaBehavior get_scrollDeltaBehavior() { }

	[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
	[Token(Token = "0x6000B31")]
	public bool get_shortcutKeysConsumeInput() { }

	[Address(RVA = "0x29B7200", Offset = "0x29B6600", Length = "0x53")]
	[Token(Token = "0x6000B2D")]
	public ReadOnlyArray<String> get_supportedDevices() { }

	[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
	[Token(Token = "0x6000B1F")]
	public float get_tapRadius() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000B09")]
	public UpdateMode get_updateMode() { }

	[Address(RVA = "0x29B6E50", Offset = "0x29B6250", Length = "0x74")]
	[Token(Token = "0x6000B34")]
	internal bool IsFeatureEnabled(string featureName) { }

	[Address(RVA = "0x29B6ED0", Offset = "0x29B62D0", Length = "0xC1")]
	[Token(Token = "0x6000B35")]
	internal void OnChange() { }

	[Address(RVA = "0x29B7260", Offset = "0x29B6660", Length = "0x10")]
	[Token(Token = "0x6000B24")]
	public void set_backgroundBehavior(BackgroundBehavior value) { }

	[Address(RVA = "0x29B7270", Offset = "0x29B6670", Length = "0x19")]
	[Token(Token = "0x6000B18")]
	public void set_buttonReleaseThreshold(float value) { }

	[Address(RVA = "0x29B7290", Offset = "0x29B6690", Length = "0x10")]
	[Token(Token = "0x6000B0E")]
	public void set_compensateForScreenOrientation(bool value) { }

	[Address(RVA = "0x29B72A0", Offset = "0x29B66A0", Length = "0x36")]
	[Token(Token = "0x6000B16")]
	public void set_defaultButtonPressPoint(float value) { }

	[Address(RVA = "0x29B72E0", Offset = "0x29B66E0", Length = "0x19")]
	[Token(Token = "0x6000B14")]
	public void set_defaultDeadzoneMax(float value) { }

	[Address(RVA = "0x29B7300", Offset = "0x29B6700", Length = "0x19")]
	[Token(Token = "0x6000B12")]
	public void set_defaultDeadzoneMin(float value) { }

	[Address(RVA = "0x29B7320", Offset = "0x29B6720", Length = "0x19")]
	[Token(Token = "0x6000B1E")]
	public void set_defaultHoldTime(float value) { }

	[Address(RVA = "0x29B7340", Offset = "0x29B6740", Length = "0x19")]
	[Token(Token = "0x6000B1C")]
	public void set_defaultSlowTapTime(float value) { }

	[Address(RVA = "0x29B7360", Offset = "0x29B6760", Length = "0x19")]
	[Token(Token = "0x6000B1A")]
	public void set_defaultTapTime(float value) { }

	[Address(RVA = "0x29B7380", Offset = "0x29B6780", Length = "0x10")]
	[Token(Token = "0x6000B30")]
	public void set_disableRedundantEventsMerging(bool value) { }

	[Address(RVA = "0x29B7390", Offset = "0x29B6790", Length = "0x10")]
	[Token(Token = "0x6000B26")]
	public void set_editorInputBehaviorInPlayMode(EditorInputBehaviorInPlayMode value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B10")]
	public void set_filterNoiseOnCurrent(bool value) { }

	[Address(RVA = "0x29B73A0", Offset = "0x29B67A0", Length = "0x10")]
	[Token(Token = "0x6000B28")]
	public void set_inputActionPropertyDrawerMode(InputActionPropertyDrawerMode value) { }

	[Address(RVA = "0x29B73B0", Offset = "0x29B67B0", Length = "0x10")]
	[Token(Token = "0x6000B2A")]
	public void set_maxEventBytesPerUpdate(int value) { }

	[Address(RVA = "0x29B73C0", Offset = "0x29B67C0", Length = "0x10")]
	[Token(Token = "0x6000B2C")]
	public void set_maxQueuedEventsPerUpdate(int value) { }

	[Address(RVA = "0x29B73D0", Offset = "0x29B67D0", Length = "0x19")]
	[Token(Token = "0x6000B22")]
	public void set_multiTapDelayTime(float value) { }

	[Address(RVA = "0x29B73F0", Offset = "0x29B67F0", Length = "0x10")]
	[Token(Token = "0x6000B0C")]
	public void set_scrollDeltaBehavior(ScrollDeltaBehavior value) { }

	[Address(RVA = "0x29B7400", Offset = "0x29B6800", Length = "0x10")]
	[Token(Token = "0x6000B32")]
	public void set_shortcutKeysConsumeInput(bool value) { }

	[Address(RVA = "0x29B7410", Offset = "0x29B6810", Length = "0x17E")]
	[Token(Token = "0x6000B2E")]
	public void set_supportedDevices(ReadOnlyArray<String> value) { }

	[Address(RVA = "0x29B7590", Offset = "0x29B6990", Length = "0x19")]
	[Token(Token = "0x6000B20")]
	public void set_tapRadius(float value) { }

	[Address(RVA = "0x29B75B0", Offset = "0x29B69B0", Length = "0x10")]
	[Token(Token = "0x6000B0A")]
	public void set_updateMode(UpdateMode value) { }

	[Address(RVA = "0x29B6FA0", Offset = "0x29B63A0", Length = "0x1E3")]
	[Token(Token = "0x6000B33")]
	public void SetInternalFeatureFlag(string featureName, bool enabled) { }

}

