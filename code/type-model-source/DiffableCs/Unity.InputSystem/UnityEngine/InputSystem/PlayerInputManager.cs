namespace UnityEngine.InputSystem;

[AddComponentMenu("Input/Player Input Manager")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/PlayerInputManager.html")]
[Token(Token = "0x20000DC")]
public class PlayerInputManager : MonoBehaviour
{
	[Token(Token = "0x20000DD")]
	internal class PlayerJoinedEvent : UnityEvent<PlayerInput>
	{

		[Address(RVA = "0x29CA550", Offset = "0x29C9950", Length = "0x39")]
		[Token(Token = "0x6000C02")]
		public PlayerJoinedEvent() { }

	}

	[Token(Token = "0x20000DE")]
	internal class PlayerLeftEvent : UnityEvent<PlayerInput>
	{

		[Address(RVA = "0x29CA590", Offset = "0x29C9990", Length = "0x39")]
		[Token(Token = "0x6000C03")]
		public PlayerLeftEvent() { }

	}

	[Token(Token = "0x4000540")]
	public const string PlayerJoinedMessage = "OnPlayerJoined"; //Field offset: 0x0
	[Token(Token = "0x4000541")]
	public const string PlayerLeftMessage = "OnPlayerLeft"; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000542")]
	private static PlayerInputManager <instance>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000543")]
	internal PlayerNotifications m_NotificationBehavior; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000544")]
	[Tooltip("Set a limit for the maximum number of players who are able to join.")]
	internal int m_MaxPlayerCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000545")]
	internal bool m_AllowJoining; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000546")]
	internal PlayerJoinBehavior m_JoinBehavior; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000547")]
	internal PlayerJoinedEvent m_PlayerJoinedEvent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000548")]
	internal PlayerLeftEvent m_PlayerLeftEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000549")]
	internal InputActionProperty m_JoinAction; //Field offset: 0x40
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400054A")]
	internal GameObject m_PlayerPrefab; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400054B")]
	internal bool m_SplitScreen; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[SerializeField]
	[Token(Token = "0x400054C")]
	internal bool m_MaintainAspectRatioInSplitScreen; //Field offset: 0x61
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400054D")]
	[Tooltip("Explicitly set a fixed number of screens or otherwise allow the screen to be divided automatically to best fit the number of players.")]
	internal int m_FixedNumberOfSplitScreens; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400054E")]
	internal Rect m_SplitScreenRect; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400054F")]
	private bool m_JoinActionDelegateHooked; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000550")]
	private bool m_UnpairedDeviceUsedDelegateHooked; //Field offset: 0x79
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000551")]
	private Action<CallbackContext> m_JoinActionDelegate; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000552")]
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000553")]
	private CallbackArray<Action`1<PlayerInput>> m_PlayerJoinedCallbacks; //Field offset: 0x90
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000554")]
	private CallbackArray<Action`1<PlayerInput>> m_PlayerLeftCallbacks; //Field offset: 0xE0

	[Token(Token = "0x1400001E")]
	public event Action<PlayerInput> onPlayerJoined
	{
		[Address(RVA = "0x29C2A50", Offset = "0x29C1E50", Length = "0x99")]
		[Token(Token = "0x6000BE8")]
		 add { } //Length: 153
		[Address(RVA = "0x29C2DE0", Offset = "0x29C21E0", Length = "0x99")]
		[Token(Token = "0x6000BE9")]
		 remove { } //Length: 153
	}

	[Token(Token = "0x1400001F")]
	public event Action<PlayerInput> onPlayerLeft
	{
		[Address(RVA = "0x29C2AF0", Offset = "0x29C1EF0", Length = "0x99")]
		[Token(Token = "0x6000BEA")]
		 add { } //Length: 153
		[Address(RVA = "0x29C2E80", Offset = "0x29C2280", Length = "0x99")]
		[Token(Token = "0x6000BEB")]
		 remove { } //Length: 153
	}

	[Token(Token = "0x17000310")]
	public int fixedNumberOfSplitScreens
	{
		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[Token(Token = "0x6000BDB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700031B")]
	public private static PlayerInputManager instance
	{
		[Address(RVA = "0x29C2B90", Offset = "0x29C1F90", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000BEE")]
		 get { } //Length: 54
		[Address(RVA = "0x29C2F20", Offset = "0x29C2320", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000BEF")]
		private set { } //Length: 81
	}

	[Token(Token = "0x17000316")]
	public InputActionProperty joinAction
	{
		[Address(RVA = "0x1F8A780", Offset = "0x1F89B80", Length = "0x15")]
		[Token(Token = "0x6000BE2")]
		 get { } //Length: 21
		[Address(RVA = "0x29C2F80", Offset = "0x29C2380", Length = "0xA7")]
		[Token(Token = "0x6000BE3")]
		 set { } //Length: 167
	}

	[Token(Token = "0x17000315")]
	public PlayerJoinBehavior joinBehavior
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000BE0")]
		 get { } //Length: 4
		[Address(RVA = "0x29C3030", Offset = "0x29C2430", Length = "0x47")]
		[Token(Token = "0x6000BE1")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000314")]
	public bool joiningEnabled
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000BDF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700030F")]
	public bool maintainAspectRatioInSplitScreen
	{
		[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
		[Token(Token = "0x6000BDA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000313")]
	public int maxPlayerCount
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000BDE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700031C")]
	internal static String[] messages
	{
		[Address(RVA = "0x29C2BD0", Offset = "0x29C1FD0", Length = "0x9B")]
		[Token(Token = "0x6000BF7")]
		internal get { } //Length: 155
	}

	[Token(Token = "0x17000317")]
	public PlayerNotifications notificationBehavior
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000BE4")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000BE5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000312")]
	public int playerCount
	{
		[Address(RVA = "0x29C2C70", Offset = "0x29C2070", Length = "0x4D")]
		[Token(Token = "0x6000BDD")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000318")]
	public PlayerJoinedEvent playerJoinedEvent
	{
		[Address(RVA = "0x29C2CC0", Offset = "0x29C20C0", Length = "0x8A")]
		[Token(Token = "0x6000BE6")]
		 get { } //Length: 138
	}

	[Token(Token = "0x17000319")]
	public PlayerLeftEvent playerLeftEvent
	{
		[Address(RVA = "0x29C2D50", Offset = "0x29C2150", Length = "0x8A")]
		[Token(Token = "0x6000BE7")]
		 get { } //Length: 138
	}

	[Token(Token = "0x1700031A")]
	public GameObject playerPrefab
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000BEC")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6000BED")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700030E")]
	public bool splitScreen
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[Token(Token = "0x6000BD8")]
		 get { } //Length: 5
		[Address(RVA = "0x29C3080", Offset = "0x29C2480", Length = "0x286")]
		[Token(Token = "0x6000BD9")]
		 set { } //Length: 646
	}

	[Token(Token = "0x17000311")]
	public Rect splitScreenArea
	{
		[Address(RVA = "0x121E520", Offset = "0x121D920", Length = "0xB")]
		[Token(Token = "0x6000BDC")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x29C2A20", Offset = "0x29C1E20", Length = "0x25")]
	[Token(Token = "0x6000C01")]
	public PlayerInputManager() { }

	[Address(RVA = "0x29C2A50", Offset = "0x29C1E50", Length = "0x99")]
	[Token(Token = "0x6000BE8")]
	public void add_onPlayerJoined(Action<PlayerInput> value) { }

	[Address(RVA = "0x29C2AF0", Offset = "0x29C1EF0", Length = "0x99")]
	[Token(Token = "0x6000BEA")]
	public void add_onPlayerLeft(Action<PlayerInput> value) { }

	[Address(RVA = "0x29C0AA0", Offset = "0x29BFEA0", Length = "0x2E4")]
	[Token(Token = "0x6000BF8")]
	private bool CheckIfPlayerCanJoin(int playerIndex = -1) { }

	[Address(RVA = "0x29C0D90", Offset = "0x29C0190", Length = "0x131")]
	[Token(Token = "0x6000BF1")]
	public void DisableJoining() { }

	[Address(RVA = "0x29C0ED0", Offset = "0x29C02D0", Length = "0x23C")]
	[Token(Token = "0x6000BF0")]
	public void EnableJoining() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x6000BDB")]
	public int get_fixedNumberOfSplitScreens() { }

	[Address(RVA = "0x29C2B90", Offset = "0x29C1F90", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000BEE")]
	public static PlayerInputManager get_instance() { }

	[Address(RVA = "0x1F8A780", Offset = "0x1F89B80", Length = "0x15")]
	[Token(Token = "0x6000BE2")]
	public InputActionProperty get_joinAction() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000BE0")]
	public PlayerJoinBehavior get_joinBehavior() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000BDF")]
	public bool get_joiningEnabled() { }

	[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
	[Token(Token = "0x6000BDA")]
	public bool get_maintainAspectRatioInSplitScreen() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000BDE")]
	public int get_maxPlayerCount() { }

	[Address(RVA = "0x29C2BD0", Offset = "0x29C1FD0", Length = "0x9B")]
	[Token(Token = "0x6000BF7")]
	internal static String[] get_messages() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000BE4")]
	public PlayerNotifications get_notificationBehavior() { }

	[Address(RVA = "0x29C2C70", Offset = "0x29C2070", Length = "0x4D")]
	[Token(Token = "0x6000BDD")]
	public int get_playerCount() { }

	[Address(RVA = "0x29C2CC0", Offset = "0x29C20C0", Length = "0x8A")]
	[Token(Token = "0x6000BE6")]
	public PlayerJoinedEvent get_playerJoinedEvent() { }

	[Address(RVA = "0x29C2D50", Offset = "0x29C2150", Length = "0x8A")]
	[Token(Token = "0x6000BE7")]
	public PlayerLeftEvent get_playerLeftEvent() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000BEC")]
	public GameObject get_playerPrefab() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[Token(Token = "0x6000BD8")]
	public bool get_splitScreen() { }

	[Address(RVA = "0x121E520", Offset = "0x121D920", Length = "0xB")]
	[Token(Token = "0x6000BDC")]
	public Rect get_splitScreenArea() { }

	[Address(RVA = "0x29C1110", Offset = "0x29C0510", Length = "0x430")]
	[Token(Token = "0x6000BFD")]
	private bool IsDeviceUsableWithPlayerActions(InputDevice device) { }

	[Address(RVA = "0x29C1710", Offset = "0x29C0B10", Length = "0x218")]
	[Token(Token = "0x6000BF5")]
	public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, InputDevice pairWithDevice = null) { }

	[Address(RVA = "0x29C1930", Offset = "0x29C0D30", Length = "0x24A")]
	[Token(Token = "0x6000BF6")]
	public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, InputDevice[] pairWithDevices) { }

	[Address(RVA = "0x29C1640", Offset = "0x29C0A40", Length = "0x65")]
	[Token(Token = "0x6000BF3")]
	public void JoinPlayerFromAction(CallbackContext context) { }

	[Address(RVA = "0x29C1550", Offset = "0x29C0950", Length = "0xEA")]
	[Token(Token = "0x6000BF4")]
	public void JoinPlayerFromActionIfNotAlreadyJoined(CallbackContext context) { }

	[Address(RVA = "0x29C16B0", Offset = "0x29C0AB0", Length = "0x5C")]
	[Token(Token = "0x6000BF2")]
	internal void JoinPlayerFromUI() { }

	[Address(RVA = "0x29C1B80", Offset = "0x29C0F80", Length = "0x122")]
	[Token(Token = "0x6000BFF")]
	internal void NotifyPlayerJoined(PlayerInput player) { }

	[Address(RVA = "0x29C1CB0", Offset = "0x29C10B0", Length = "0x122")]
	[Token(Token = "0x6000C00")]
	internal void NotifyPlayerLeft(PlayerInput player) { }

	[Address(RVA = "0x29C1DE0", Offset = "0x29C11E0", Length = "0xDE")]
	[Token(Token = "0x6000BFB")]
	private void OnDisable() { }

	[Address(RVA = "0x29C1EC0", Offset = "0x29C12C0", Length = "0x40E")]
	[Token(Token = "0x6000BFA")]
	private void OnEnable() { }

	[Address(RVA = "0x29C22D0", Offset = "0x29C16D0", Length = "0xAB")]
	[Token(Token = "0x6000BF9")]
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	[Address(RVA = "0x29C2DE0", Offset = "0x29C21E0", Length = "0x99")]
	[Token(Token = "0x6000BE9")]
	public void remove_onPlayerJoined(Action<PlayerInput> value) { }

	[Address(RVA = "0x29C2E80", Offset = "0x29C2280", Length = "0x99")]
	[Token(Token = "0x6000BEB")]
	public void remove_onPlayerLeft(Action<PlayerInput> value) { }

	[Address(RVA = "0x29C2F20", Offset = "0x29C2320", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000BEF")]
	private static void set_instance(PlayerInputManager value) { }

	[Address(RVA = "0x29C2F80", Offset = "0x29C2380", Length = "0xA7")]
	[Token(Token = "0x6000BE3")]
	public void set_joinAction(InputActionProperty value) { }

	[Address(RVA = "0x29C3030", Offset = "0x29C2430", Length = "0x47")]
	[Token(Token = "0x6000BE1")]
	public void set_joinBehavior(PlayerJoinBehavior value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000BE5")]
	public void set_notificationBehavior(PlayerNotifications value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6000BED")]
	public void set_playerPrefab(GameObject value) { }

	[Address(RVA = "0x29C3080", Offset = "0x29C2480", Length = "0x286")]
	[Token(Token = "0x6000BD9")]
	public void set_splitScreen(bool value) { }

	[Address(RVA = "0x29C2380", Offset = "0x29C1780", Length = "0x699")]
	[Token(Token = "0x6000BFC")]
	private void UpdateSplitScreen() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BFE")]
	private void ValidateInputActionAsset() { }

}

