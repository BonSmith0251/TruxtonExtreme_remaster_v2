namespace UnityEngine.InputSystem;

[AddComponentMenu("Input/Player Input")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/PlayerInput.html")]
[Token(Token = "0x20000D7")]
public class PlayerInput : MonoBehaviour
{
	[Token(Token = "0x20000D8")]
	internal class ActionEvent : UnityEvent<CallbackContext>
	{
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Token(Token = "0x400053E")]
		private string m_ActionId; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Token(Token = "0x400053F")]
		private string m_ActionName; //Field offset: 0x38

		[Token(Token = "0x1700030C")]
		public string actionId
		{
			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[Token(Token = "0x6000BD0")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700030D")]
		public string actionName
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[Token(Token = "0x6000BD1")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x29B4540", Offset = "0x29B3940", Length = "0x39")]
		[Token(Token = "0x6000BD2")]
		public ActionEvent() { }

		[Address(RVA = "0x29B4580", Offset = "0x29B3980", Length = "0x23C")]
		[Token(Token = "0x6000BD3")]
		public ActionEvent(InputAction action) { }

		[Address(RVA = "0x29B47C0", Offset = "0x29B3BC0", Length = "0x7D")]
		[Token(Token = "0x6000BD4")]
		public ActionEvent(Guid actionGUID, string name = null) { }

		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000BD0")]
		public string get_actionId() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000BD1")]
		public string get_actionName() { }

	}

	[Token(Token = "0x20000DB")]
	internal class ControlsChangedEvent : UnityEvent<PlayerInput>
	{

		[Address(RVA = "0x29B4FE0", Offset = "0x29B43E0", Length = "0x39")]
		[Token(Token = "0x6000BD7")]
		public ControlsChangedEvent() { }

	}

	[Token(Token = "0x20000D9")]
	internal class DeviceLostEvent : UnityEvent<PlayerInput>
	{

		[Address(RVA = "0x29B5B20", Offset = "0x29B4F20", Length = "0x39")]
		[Token(Token = "0x6000BD5")]
		public DeviceLostEvent() { }

	}

	[Token(Token = "0x20000DA")]
	internal class DeviceRegainedEvent : UnityEvent<PlayerInput>
	{

		[Address(RVA = "0x29B5B60", Offset = "0x29B4F60", Length = "0x39")]
		[Token(Token = "0x6000BD6")]
		public DeviceRegainedEvent() { }

	}

	[Token(Token = "0x4000513")]
	public const string DeviceLostMessage = "OnDeviceLost"; //Field offset: 0x0
	[Token(Token = "0x4000514")]
	public const string DeviceRegainedMessage = "OnDeviceRegained"; //Field offset: 0x0
	[Token(Token = "0x4000515")]
	public const string ControlsChangedMessage = "OnControlsChanged"; //Field offset: 0x0
	[Token(Token = "0x4000535")]
	internal static int s_AllActivePlayersCount; //Field offset: 0x0
	[Token(Token = "0x4000536")]
	internal static PlayerInput[] s_AllActivePlayers; //Field offset: 0x8
	[Token(Token = "0x4000537")]
	private static Action<InputUser, InputUserChange, InputDevice> s_UserChangeDelegate; //Field offset: 0x10
	[Token(Token = "0x4000538")]
	private static int s_InitPairWithDevicesCount; //Field offset: 0x18
	[Token(Token = "0x4000539")]
	private static InputDevice[] s_InitPairWithDevices; //Field offset: 0x20
	[Token(Token = "0x400053A")]
	private static int s_InitPlayerIndex; //Field offset: 0x28
	[Token(Token = "0x400053B")]
	private static int s_InitSplitScreenIndex; //Field offset: 0x2C
	[Token(Token = "0x400053C")]
	private static string s_InitControlScheme; //Field offset: 0x30
	[Token(Token = "0x400053D")]
	internal static bool s_DestroyIfDeviceSetupUnsuccessful; //Field offset: 0x38
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000516")]
	private int m_AllMapsHashCode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000517")]
	[Tooltip("Input actions associated with the player.")]
	internal InputActionAsset m_Actions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000518")]
	[Tooltip("Determine how notifications should be sent when an input-related event associated with the player happens.")]
	internal PlayerNotifications m_NotificationBehavior; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000519")]
	[Tooltip("UI InputModule that should have it's input actions synchronized to this PlayerInput's actions.")]
	internal InputSystemUIInputModule m_UIInputModule; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400051A")]
	[Tooltip("Event that is triggered when the PlayerInput loses a paired device (e.g. its battery runs out).")]
	internal DeviceLostEvent m_DeviceLostEvent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400051B")]
	internal DeviceRegainedEvent m_DeviceRegainedEvent; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400051C")]
	internal ControlsChangedEvent m_ControlsChangedEvent; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400051D")]
	internal ActionEvent[] m_ActionEvents; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400051E")]
	internal bool m_NeverAutoSwitchControlSchemes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400051F")]
	internal string m_DefaultControlScheme; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000520")]
	internal string m_DefaultActionMap; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000521")]
	internal int m_SplitScreenIndex; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000522")]
	[Tooltip("Reference to the player's view camera. Note that this is only required when using split-screen and/or per-player UIs. Otherwise it is safe to leave this property uninitialized.")]
	internal Camera m_Camera; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000523")]
	private InputValue m_InputValueObject; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000524")]
	internal InputActionMap m_CurrentActionMap; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000525")]
	private int m_PlayerIndex; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000526")]
	private bool m_InputActive; //Field offset: 0x9C
	[FieldOffset(Offset = "0x9D")]
	[Token(Token = "0x4000527")]
	private bool m_Enabled; //Field offset: 0x9D
	[FieldOffset(Offset = "0x9E")]
	[Token(Token = "0x4000528")]
	internal bool m_ActionsInitialized; //Field offset: 0x9E
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000529")]
	private Dictionary<String, String> m_ActionMessageNames; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400052A")]
	private InputUser m_InputUser; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400052B")]
	private Action<CallbackContext> m_ActionTriggeredDelegate; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400052C")]
	private CallbackArray<Action`1<PlayerInput>> m_DeviceLostCallbacks; //Field offset: 0xB8
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400052D")]
	private CallbackArray<Action`1<PlayerInput>> m_DeviceRegainedCallbacks; //Field offset: 0x108
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400052E")]
	private CallbackArray<Action`1<PlayerInput>> m_ControlsChangedCallbacks; //Field offset: 0x158
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x400052F")]
	private CallbackArray<Action`1<CallbackContext>> m_ActionTriggeredCallbacks; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000530")]
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000531")]
	private Func<InputDevice, InputEventPtr, Boolean> m_PreFilterUnpairedDeviceUsedDelegate; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000532")]
	private bool m_OnUnpairedDeviceUsedHooked; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000533")]
	private Action<InputDevice, InputDeviceChange> m_DeviceChangeDelegate; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000534")]
	private bool m_OnDeviceChangeHooked; //Field offset: 0x218

	[Token(Token = "0x1400001A")]
	public event Action<CallbackContext> onActionTriggered
	{
		[Address(RVA = "0x29C95A0", Offset = "0x29C89A0", Length = "0x99")]
		[Token(Token = "0x6000B94")]
		 add { } //Length: 153
		[Address(RVA = "0x29C9E80", Offset = "0x29C9280", Length = "0x99")]
		[Token(Token = "0x6000B95")]
		 remove { } //Length: 153
	}

	[Token(Token = "0x1400001D")]
	public event Action<PlayerInput> onControlsChanged
	{
		[Address(RVA = "0x29C9640", Offset = "0x29C8A40", Length = "0x99")]
		[Token(Token = "0x6000B9A")]
		 add { } //Length: 153
		[Address(RVA = "0x29C9F20", Offset = "0x29C9320", Length = "0x99")]
		[Token(Token = "0x6000B9B")]
		 remove { } //Length: 153
	}

	[Token(Token = "0x1400001B")]
	public event Action<PlayerInput> onDeviceLost
	{
		[Address(RVA = "0x29C96E0", Offset = "0x29C8AE0", Length = "0x99")]
		[Token(Token = "0x6000B96")]
		 add { } //Length: 153
		[Address(RVA = "0x29C9FC0", Offset = "0x29C93C0", Length = "0x99")]
		[Token(Token = "0x6000B97")]
		 remove { } //Length: 153
	}

	[Token(Token = "0x1400001C")]
	public event Action<PlayerInput> onDeviceRegained
	{
		[Address(RVA = "0x29C9780", Offset = "0x29C8B80", Length = "0x99")]
		[Token(Token = "0x6000B98")]
		 add { } //Length: 153
		[Address(RVA = "0x29CA060", Offset = "0x29C9460", Length = "0x99")]
		[Token(Token = "0x6000B99")]
		 remove { } //Length: 153
	}

	[Token(Token = "0x17000301")]
	public ReadOnlyArray<ActionEvent> actionEvents
	{
		[Address(RVA = "0x29C9820", Offset = "0x29C8C20", Length = "0x57")]
		[Token(Token = "0x6000B8F")]
		 get { } //Length: 87
		[Address(RVA = "0x29CA100", Offset = "0x29C9500", Length = "0x7C")]
		[Token(Token = "0x6000B90")]
		 set { } //Length: 124
	}

	[Token(Token = "0x170002FA")]
	public InputActionAsset actions
	{
		[Address(RVA = "0x29C9880", Offset = "0x29C8C80", Length = "0x45")]
		[Token(Token = "0x6000B82")]
		 get { } //Length: 69
		[Address(RVA = "0x29CA180", Offset = "0x29C9580", Length = "0x13F")]
		[Token(Token = "0x6000B83")]
		 set { } //Length: 319
	}

	[Obsolete("Use inputIsActive instead.")]
	[Token(Token = "0x170002F7")]
	public bool active
	{
		[Address(RVA = "0x2424CE0", Offset = "0x24240E0", Length = "0x8")]
		[Token(Token = "0x6000B7F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700030A")]
	public static ReadOnlyArray<PlayerInput> all
	{
		[Address(RVA = "0x29C98D0", Offset = "0x29C8CD0", Length = "0x81")]
		[Token(Token = "0x6000BA3")]
		 get { } //Length: 129
	}

	[Token(Token = "0x17000305")]
	public Camera camera
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000B9C")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x6000B9D")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000304")]
	public ControlsChangedEvent controlsChangedEvent
	{
		[Address(RVA = "0x29C9960", Offset = "0x29C8D60", Length = "0x8A")]
		[Token(Token = "0x6000B93")]
		 get { } //Length: 138
	}

	[Token(Token = "0x170002FE")]
	public InputActionMap currentActionMap
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000B89")]
		 get { } //Length: 8
		[Address(RVA = "0x29CA2C0", Offset = "0x29C96C0", Length = "0x7D")]
		[Token(Token = "0x6000B8A")]
		 set { } //Length: 125
	}

	[Token(Token = "0x170002FB")]
	public string currentControlScheme
	{
		[Address(RVA = "0x29C99F0", Offset = "0x29C8DF0", Length = "0xB0")]
		[Token(Token = "0x6000B84")]
		 get { } //Length: 176
	}

	[Token(Token = "0x170002FF")]
	public string defaultActionMap
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000B8B")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x6000B8C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002FC")]
	public string defaultControlScheme
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6000B85")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x6000B86")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000302")]
	public DeviceLostEvent deviceLostEvent
	{
		[Address(RVA = "0x29C9AA0", Offset = "0x29C8EA0", Length = "0x8A")]
		[Token(Token = "0x6000B91")]
		 get { } //Length: 138
	}

	[Token(Token = "0x17000303")]
	public DeviceRegainedEvent deviceRegainedEvent
	{
		[Address(RVA = "0x29C9B30", Offset = "0x29C8F30", Length = "0x8A")]
		[Token(Token = "0x6000B92")]
		 get { } //Length: 138
	}

	[Token(Token = "0x17000308")]
	public ReadOnlyArray<InputDevice> devices
	{
		[Address(RVA = "0x29C9BC0", Offset = "0x29C8FC0", Length = "0xA4")]
		[Token(Token = "0x6000BA1")]
		 get { } //Length: 164
	}

	[Token(Token = "0x17000309")]
	public bool hasMissingRequiredDevices
	{
		[Address(RVA = "0x29C9C70", Offset = "0x29C9070", Length = "0xF9")]
		[Token(Token = "0x6000BA2")]
		 get { } //Length: 249
	}

	[Token(Token = "0x170002F6")]
	public bool inputIsActive
	{
		[Address(RVA = "0x2424CE0", Offset = "0x24240E0", Length = "0x8")]
		[Token(Token = "0x6000B7E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700030B")]
	public static bool isSinglePlayer
	{
		[Address(RVA = "0x29C9D70", Offset = "0x29C9170", Length = "0x105")]
		[Token(Token = "0x6000BA4")]
		 get { } //Length: 261
	}

	[Token(Token = "0x170002FD")]
	public bool neverAutoSwitchControlSchemes
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[Token(Token = "0x6000B87")]
		 get { } //Length: 5
		[Address(RVA = "0x29CA340", Offset = "0x29C9740", Length = "0x35")]
		[Token(Token = "0x6000B88")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000300")]
	public PlayerNotifications notificationBehavior
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000B8D")]
		 get { } //Length: 4
		[Address(RVA = "0x29CA380", Offset = "0x29C9780", Length = "0x45")]
		[Token(Token = "0x6000B8E")]
		 set { } //Length: 69
	}

	[Token(Token = "0x170002F8")]
	public int playerIndex
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[Token(Token = "0x6000B80")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170002F9")]
	public int splitScreenIndex
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x6000B81")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000306")]
	public InputSystemUIInputModule uiInputModule
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000B9E")]
		 get { } //Length: 5
		[Address(RVA = "0x29CA3D0", Offset = "0x29C97D0", Length = "0x175")]
		[Token(Token = "0x6000B9F")]
		 set { } //Length: 373
	}

	[Token(Token = "0x17000307")]
	public InputUser user
	{
		[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
		[Token(Token = "0x6000BA0")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x29C9530", Offset = "0x29C8930", Length = "0x4F")]
	[Token(Token = "0x6000BCF")]
	private static PlayerInput() { }

	[Address(RVA = "0x29C9580", Offset = "0x29C8980", Length = "0x18")]
	[Token(Token = "0x6000BCE")]
	public PlayerInput() { }

	[Address(RVA = "0x29C3310", Offset = "0x29C2710", Length = "0xB5")]
	[Token(Token = "0x6000BA6")]
	public void ActivateInput() { }

	[Address(RVA = "0x29C95A0", Offset = "0x29C89A0", Length = "0x99")]
	[Token(Token = "0x6000B94")]
	public void add_onActionTriggered(Action<CallbackContext> value) { }

	[Address(RVA = "0x29C9640", Offset = "0x29C8A40", Length = "0x99")]
	[Token(Token = "0x6000B9A")]
	public void add_onControlsChanged(Action<PlayerInput> value) { }

	[Address(RVA = "0x29C96E0", Offset = "0x29C8AE0", Length = "0x99")]
	[Token(Token = "0x6000B96")]
	public void add_onDeviceLost(Action<PlayerInput> value) { }

	[Address(RVA = "0x29C9780", Offset = "0x29C8B80", Length = "0x99")]
	[Token(Token = "0x6000B98")]
	public void add_onDeviceRegained(Action<PlayerInput> value) { }

	[Address(RVA = "0x29C33D0", Offset = "0x29C27D0", Length = "0x327")]
	[Token(Token = "0x6000BBE")]
	private void AssignPlayerIndex() { }

	[Address(RVA = "0x29C3700", Offset = "0x29C2B00", Length = "0xC1F")]
	[Token(Token = "0x6000BBA")]
	private void AssignUserAndDevices() { }

	[Address(RVA = "0x29C4320", Offset = "0x29C3720", Length = "0x2F0")]
	[Token(Token = "0x6000BB8")]
	private void CacheMessageNames() { }

	[Address(RVA = "0x29C4620", Offset = "0x29C3A20", Length = "0x4D")]
	[Token(Token = "0x6000BB9")]
	private void ClearCaches() { }

	[Address(RVA = "0x29C4670", Offset = "0x29C3A70", Length = "0x286")]
	[Token(Token = "0x6000BB3")]
	private void CopyActionAssetAndApplyBindingOverrides() { }

	[Address(RVA = "0x29C4900", Offset = "0x29C3D00", Length = "0x29")]
	[Token(Token = "0x6000BA8")]
	public void DeactivateInput() { }

	[Address(RVA = "0x29C4930", Offset = "0x29C3D30", Length = "0x57")]
	[Token(Token = "0x6000BC5")]
	public void DebugLogAction(CallbackContext context) { }

	[Address(RVA = "0x29C4990", Offset = "0x29C3D90", Length = "0x34C")]
	[Token(Token = "0x6000BB1")]
	private static PlayerInput DoInstantiate(GameObject prefab) { }

	[Address(RVA = "0x29C4CE0", Offset = "0x29C40E0", Length = "0x219")]
	[Token(Token = "0x6000BAE")]
	public static PlayerInput FindFirstPairedToDevice(InputDevice device) { }

	[Address(RVA = "0x29C9820", Offset = "0x29C8C20", Length = "0x57")]
	[Token(Token = "0x6000B8F")]
	public ReadOnlyArray<ActionEvent> get_actionEvents() { }

	[Address(RVA = "0x29C9880", Offset = "0x29C8C80", Length = "0x45")]
	[Token(Token = "0x6000B82")]
	public InputActionAsset get_actions() { }

	[Address(RVA = "0x2424CE0", Offset = "0x24240E0", Length = "0x8")]
	[Token(Token = "0x6000B7F")]
	public bool get_active() { }

	[Address(RVA = "0x29C98D0", Offset = "0x29C8CD0", Length = "0x81")]
	[Token(Token = "0x6000BA3")]
	public static ReadOnlyArray<PlayerInput> get_all() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000B9C")]
	public Camera get_camera() { }

	[Address(RVA = "0x29C9960", Offset = "0x29C8D60", Length = "0x8A")]
	[Token(Token = "0x6000B93")]
	public ControlsChangedEvent get_controlsChangedEvent() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000B89")]
	public InputActionMap get_currentActionMap() { }

	[Address(RVA = "0x29C99F0", Offset = "0x29C8DF0", Length = "0xB0")]
	[Token(Token = "0x6000B84")]
	public string get_currentControlScheme() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000B8B")]
	public string get_defaultActionMap() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000B85")]
	public string get_defaultControlScheme() { }

	[Address(RVA = "0x29C9AA0", Offset = "0x29C8EA0", Length = "0x8A")]
	[Token(Token = "0x6000B91")]
	public DeviceLostEvent get_deviceLostEvent() { }

	[Address(RVA = "0x29C9B30", Offset = "0x29C8F30", Length = "0x8A")]
	[Token(Token = "0x6000B92")]
	public DeviceRegainedEvent get_deviceRegainedEvent() { }

	[Address(RVA = "0x29C9BC0", Offset = "0x29C8FC0", Length = "0xA4")]
	[Token(Token = "0x6000BA1")]
	public ReadOnlyArray<InputDevice> get_devices() { }

	[Address(RVA = "0x29C9C70", Offset = "0x29C9070", Length = "0xF9")]
	[Token(Token = "0x6000BA2")]
	public bool get_hasMissingRequiredDevices() { }

	[Address(RVA = "0x2424CE0", Offset = "0x24240E0", Length = "0x8")]
	[Token(Token = "0x6000B7E")]
	public bool get_inputIsActive() { }

	[Address(RVA = "0x29C9D70", Offset = "0x29C9170", Length = "0x105")]
	[Token(Token = "0x6000BA4")]
	public static bool get_isSinglePlayer() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[Token(Token = "0x6000B87")]
	public bool get_neverAutoSwitchControlSchemes() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000B8D")]
	public PlayerNotifications get_notificationBehavior() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[Token(Token = "0x6000B80")]
	public int get_playerIndex() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x6000B81")]
	public int get_splitScreenIndex() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000B9E")]
	public InputSystemUIInputModule get_uiInputModule() { }

	[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
	[Token(Token = "0x6000BA0")]
	public InputUser get_user() { }

	[Address(RVA = "0x8B1850", Offset = "0x8B0C50", Length = "0x18D")]
	[Token(Token = "0x6000BA5")]
	public TDevice GetDevice() { }

	[Address(RVA = "0x29C4F00", Offset = "0x29C4300", Length = "0x106")]
	[Token(Token = "0x6000BAD")]
	public static PlayerInput GetPlayerByIndex(int playerIndex) { }

	[Address(RVA = "0x29C5010", Offset = "0x29C4410", Length = "0xFD")]
	[Token(Token = "0x6000BC8")]
	private void HandleControlsChanged() { }

	[Address(RVA = "0x29C5110", Offset = "0x29C4510", Length = "0xFD")]
	[Token(Token = "0x6000BC6")]
	private void HandleDeviceLost() { }

	[Address(RVA = "0x29C5210", Offset = "0x29C4610", Length = "0xFD")]
	[Token(Token = "0x6000BC7")]
	private void HandleDeviceRegained() { }

	[Address(RVA = "0x29C5310", Offset = "0x29C4710", Length = "0x10C")]
	[Token(Token = "0x6000BBB")]
	private bool HaveBindingForDevice(InputDevice device) { }

	[Address(RVA = "0x29C5420", Offset = "0x29C4820", Length = "0x3A1")]
	[Token(Token = "0x6000BB2")]
	private void InitializeActions() { }

	[Address(RVA = "0x29C57D0", Offset = "0x29C4BD0", Length = "0x1AA")]
	[Token(Token = "0x6000BB5")]
	private void InstallOnActionTriggeredHook() { }

	[Address(RVA = "0x29C5980", Offset = "0x29C4D80", Length = "0x1D8")]
	[Token(Token = "0x6000BB0")]
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, InputDevice[] pairWithDevices) { }

	[Address(RVA = "0x29C5B60", Offset = "0x29C4F60", Length = "0x1B4")]
	[Token(Token = "0x6000BAF")]
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, InputDevice pairWithDevice = null) { }

	[Address(RVA = "0x29C5D20", Offset = "0x29C5120", Length = "0x240")]
	[Token(Token = "0x6000BB7")]
	private void OnActionTriggered(CallbackContext context) { }

	[Address(RVA = "0x29C5F70", Offset = "0x29C5370", Length = "0x150")]
	[Token(Token = "0x6000BCC")]
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[Address(RVA = "0x29C60D0", Offset = "0x29C54D0", Length = "0x570")]
	[Token(Token = "0x6000BC4")]
	private void OnDisable() { }

	[Address(RVA = "0x29C6650", Offset = "0x29C5A50", Length = "0x62F")]
	[Token(Token = "0x6000BBF")]
	private void OnEnable() { }

	[Address(RVA = "0x29C6C80", Offset = "0x29C6080", Length = "0x1D7")]
	[Token(Token = "0x6000BCA")]
	private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr) { }

	[Address(RVA = "0x29C6E60", Offset = "0x29C6260", Length = "0x7B0")]
	[Token(Token = "0x6000BCB")]
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	[Address(RVA = "0x29C7620", Offset = "0x29C6A20", Length = "0x1F5")]
	[Token(Token = "0x6000BC9")]
	private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device) { }

	[Address(RVA = "0x29C4900", Offset = "0x29C3D00", Length = "0x29")]
	[Obsolete("Use DeactivateInput instead.")]
	[Token(Token = "0x6000BA9")]
	public void PassivateInput() { }

	[Address(RVA = "0x29C9E80", Offset = "0x29C9280", Length = "0x99")]
	[Token(Token = "0x6000B95")]
	public void remove_onActionTriggered(Action<CallbackContext> value) { }

	[Address(RVA = "0x29C9F20", Offset = "0x29C9320", Length = "0x99")]
	[Token(Token = "0x6000B9B")]
	public void remove_onControlsChanged(Action<PlayerInput> value) { }

	[Address(RVA = "0x29C9FC0", Offset = "0x29C93C0", Length = "0x99")]
	[Token(Token = "0x6000B97")]
	public void remove_onDeviceLost(Action<PlayerInput> value) { }

	[Address(RVA = "0x29CA060", Offset = "0x29C9460", Length = "0x99")]
	[Token(Token = "0x6000B99")]
	public void remove_onDeviceRegained(Action<PlayerInput> value) { }

	[Address(RVA = "0x29CA100", Offset = "0x29C9500", Length = "0x7C")]
	[Token(Token = "0x6000B90")]
	public void set_actionEvents(ReadOnlyArray<ActionEvent> value) { }

	[Address(RVA = "0x29CA180", Offset = "0x29C9580", Length = "0x13F")]
	[Token(Token = "0x6000B83")]
	public void set_actions(InputActionAsset value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x6000B9D")]
	public void set_camera(Camera value) { }

	[Address(RVA = "0x29CA2C0", Offset = "0x29C96C0", Length = "0x7D")]
	[Token(Token = "0x6000B8A")]
	public void set_currentActionMap(InputActionMap value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x6000B8C")]
	public void set_defaultActionMap(string value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x6000B86")]
	public void set_defaultControlScheme(string value) { }

	[Address(RVA = "0x29CA340", Offset = "0x29C9740", Length = "0x35")]
	[Token(Token = "0x6000B88")]
	public void set_neverAutoSwitchControlSchemes(bool value) { }

	[Address(RVA = "0x29CA380", Offset = "0x29C9780", Length = "0x45")]
	[Token(Token = "0x6000B8E")]
	public void set_notificationBehavior(PlayerNotifications value) { }

	[Address(RVA = "0x29CA3D0", Offset = "0x29C97D0", Length = "0x175")]
	[Token(Token = "0x6000B9F")]
	public void set_uiInputModule(InputSystemUIInputModule value) { }

	[Address(RVA = "0x29C7820", Offset = "0x29C6C20", Length = "0xC7")]
	[Token(Token = "0x6000BC2")]
	private void StartListeningForDeviceChanges() { }

	[Address(RVA = "0x29C78F0", Offset = "0x29C6CF0", Length = "0x230")]
	[Token(Token = "0x6000BC0")]
	private void StartListeningForUnpairedDeviceActivity() { }

	[Address(RVA = "0x29C7B30", Offset = "0x29C6F30", Length = "0x6B")]
	[Token(Token = "0x6000BC3")]
	private void StopListeningForDeviceChanges() { }

	[Address(RVA = "0x29C7BA0", Offset = "0x29C6FA0", Length = "0x179")]
	[Token(Token = "0x6000BC1")]
	private void StopListeningForUnpairedDeviceActivity() { }

	[Address(RVA = "0x29C7D20", Offset = "0x29C7120", Length = "0x7FE")]
	[Token(Token = "0x6000BCD")]
	private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, InputDevice[] devices) { }

	[Address(RVA = "0x29C8520", Offset = "0x29C7920", Length = "0x1E7")]
	[Token(Token = "0x6000BAC")]
	public void SwitchCurrentActionMap(string mapNameOrId) { }

	[Address(RVA = "0x29C8990", Offset = "0x29C7D90", Length = "0x142")]
	[Token(Token = "0x6000BAB")]
	public void SwitchCurrentControlScheme(string controlScheme, InputDevice[] devices) { }

	[Address(RVA = "0x29C8710", Offset = "0x29C7B10", Length = "0x274")]
	[Token(Token = "0x6000BAA")]
	public bool SwitchCurrentControlScheme(InputDevice[] devices) { }

	[Address(RVA = "0x29C8AE0", Offset = "0x29C7EE0", Length = "0x39F")]
	[Token(Token = "0x6000BBD")]
	private bool TryToActivateControlScheme(InputControlScheme controlScheme) { }

	[Address(RVA = "0x29C8E80", Offset = "0x29C8280", Length = "0x13C")]
	[Token(Token = "0x6000BBC")]
	private void UnassignUserAndDevices() { }

	[Address(RVA = "0x29C8FC0", Offset = "0x29C83C0", Length = "0x210")]
	[Token(Token = "0x6000BB4")]
	private void UninitializeActions() { }

	[Address(RVA = "0x29C91E0", Offset = "0x29C85E0", Length = "0x15A")]
	[Token(Token = "0x6000BB6")]
	private void UninstallOnActionTriggeredHook() { }

	[Address(RVA = "0x29C9340", Offset = "0x29C8740", Length = "0x1E1")]
	[Token(Token = "0x6000BA7")]
	private void UpdateDelegates() { }

}

