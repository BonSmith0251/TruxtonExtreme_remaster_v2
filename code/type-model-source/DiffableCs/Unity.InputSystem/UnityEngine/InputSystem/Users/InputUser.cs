namespace UnityEngine.InputSystem.Users;

[Token(Token = "0x2000109")]
public struct InputUser : IEquatable<InputUser>
{
	[CompilerGenerated]
	[Token(Token = "0x2000110")]
	private sealed class <>c
	{
		[Token(Token = "0x4000641")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000642")]
		public static TypedRestore<GlobalState> <>9__88_0; //Field offset: 0x8
		[Token(Token = "0x4000643")]
		public static Action <>9__88_1; //Field offset: 0x10

		[Address(RVA = "0x29E8760", Offset = "0x29E7B60", Length = "0x67")]
		[Token(Token = "0x6000D1A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D1B")]
		public <>c() { }

		[Address(RVA = "0x29E84A0", Offset = "0x29E78A0", Length = "0x1B2")]
		[Token(Token = "0x6000D1C")]
		internal void <SaveAndResetState>b__88_0(ref GlobalState state) { }

		[Address(RVA = "0x29E8660", Offset = "0x29E7A60", Length = "0x40")]
		[Token(Token = "0x6000D1D")]
		internal void <SaveAndResetState>b__88_1() { }

	}

	[Token(Token = "0x200010D")]
	private struct CompareDevicesByUserAccount : IComparer<InputDevice>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062A")]
		public InputUserAccountHandle platformUserAccountHandle; //Field offset: 0x0

		[Address(RVA = "0x29D52B0", Offset = "0x29D46B0", Length = "0x26E")]
		[Token(Token = "0x6000D18")]
		public override int Compare(InputDevice x, InputDevice y) { }

		[Address(RVA = "0xA53C40", Offset = "0xA53040", Length = "0x10")]
		[Token(Token = "0x6000D19")]
		private static Nullable<InputUserAccountHandle> GetUserAccountHandleForDevice(InputDevice device) { }

	}

	[Token(Token = "0x200010A")]
	internal struct ControlSchemeChangeSyntax
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400061B")]
		internal int m_UserIndex; //Field offset: 0x0

		[Address(RVA = "0x29D5520", Offset = "0x29D4920", Length = "0x59")]
		[Token(Token = "0x6000D17")]
		public ControlSchemeChangeSyntax AndPairRemainingDevices() { }

	}

	[Token(Token = "0x200010F")]
	private struct GlobalState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062D")]
		internal int pairingStateVersion; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400062E")]
		internal uint lastUserId; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400062F")]
		internal int allUserCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000630")]
		internal int allPairedDeviceCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000631")]
		internal int allLostDeviceCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000632")]
		internal InputUser[] allUsers; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000633")]
		internal UserData[] allUserData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000634")]
		internal InputDevice[] allPairedDevices; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000635")]
		internal InputDevice[] allLostDevices; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000636")]
		internal InlinedArray<OngoingAccountSelection> ongoingAccountSelections; //Field offset: 0x38
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000637")]
		internal CallbackArray<Action`3<InputUser, InputUserChange, InputDevice>> onChange; //Field offset: 0x58
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000638")]
		internal CallbackArray<Action`2<InputControl, InputEventPtr>> onUnpairedDeviceUsed; //Field offset: 0xA8
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4000639")]
		internal CallbackArray<Func`3<InputDevice, InputEventPtr, Boolean>> onPreFilterUnpairedDeviceUsed; //Field offset: 0xF8
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x400063A")]
		internal Action<Object, InputActionChange> actionChangeDelegate; //Field offset: 0x148
		[FieldOffset(Offset = "0x150")]
		[Token(Token = "0x400063B")]
		internal Action<InputDevice, InputDeviceChange> onDeviceChangeDelegate; //Field offset: 0x150
		[FieldOffset(Offset = "0x158")]
		[Token(Token = "0x400063C")]
		internal Action<InputEventPtr, InputDevice> onEventDelegate; //Field offset: 0x158
		[FieldOffset(Offset = "0x160")]
		[Token(Token = "0x400063D")]
		internal bool onActionChangeHooked; //Field offset: 0x160
		[FieldOffset(Offset = "0x161")]
		[Token(Token = "0x400063E")]
		internal bool onDeviceChangeHooked; //Field offset: 0x161
		[FieldOffset(Offset = "0x162")]
		[Token(Token = "0x400063F")]
		internal bool onEventHooked; //Field offset: 0x162
		[FieldOffset(Offset = "0x164")]
		[Token(Token = "0x4000640")]
		internal int listenForUnpairedDeviceActivity; //Field offset: 0x164

	}

	[Token(Token = "0x200010E")]
	private struct OngoingAccountSelection
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062B")]
		public InputDevice device; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400062C")]
		public uint userId; //Field offset: 0x8

	}

	[Token(Token = "0x200010C")]
	private struct UserData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400061F")]
		public Nullable<InputUserAccountHandle> platformUserAccountHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000620")]
		public string platformUserAccountName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000621")]
		public string platformUserAccountId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000622")]
		public int deviceCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000623")]
		public int deviceStartIndex; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000624")]
		public IInputActionCollection actions; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000625")]
		public Nullable<InputControlScheme> controlScheme; //Field offset: 0x38
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000626")]
		public MatchResult controlSchemeMatch; //Field offset: 0x58
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000627")]
		public int lostDeviceCount; //Field offset: 0xA8
		[FieldOffset(Offset = "0xAC")]
		[Token(Token = "0x4000628")]
		public int lostDeviceStartIndex; //Field offset: 0xAC
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000629")]
		public UserFlags flags; //Field offset: 0xB0

	}

	[Flags]
	[Token(Token = "0x200010B")]
	public enum UserFlags : int
	{
		BindToAllDevices = 1,
		UserAccountSelectionInProgress = 2,
	}

	[Token(Token = "0x4000616")]
	public const uint InvalidId = 0; //Field offset: 0x0
	[Token(Token = "0x4000617")]
	private static readonly ProfilerMarker k_InputUserOnChangeMarker; //Field offset: 0x0
	[Token(Token = "0x4000618")]
	private static readonly ProfilerMarker k_InputCheckForUnpairMarker; //Field offset: 0x8
	[Token(Token = "0x400061A")]
	private static GlobalState s_GlobalState; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000619")]
	private uint m_Id; //Field offset: 0x0

	[Token(Token = "0x14000020")]
	public static event Action<InputUser, InputUserChange, InputDevice> onChange
	{
		[Address(RVA = "0x29BEB10", Offset = "0x29BDF10", Length = "0xB9")]
		[Token(Token = "0x6000CDE")]
		 add { } //Length: 185
		[Address(RVA = "0x29BF740", Offset = "0x29BEB40", Length = "0xB9")]
		[Token(Token = "0x6000CDF")]
		 remove { } //Length: 185
	}

	[Token(Token = "0x14000022")]
	public static event Func<InputDevice, InputEventPtr, Boolean> onPrefilterUnpairedDeviceActivity
	{
		[Address(RVA = "0x29BEBD0", Offset = "0x29BDFD0", Length = "0xBC")]
		[Token(Token = "0x6000CE2")]
		 add { } //Length: 188
		[Address(RVA = "0x29BF800", Offset = "0x29BEC00", Length = "0xBC")]
		[Token(Token = "0x6000CE3")]
		 remove { } //Length: 188
	}

	[Token(Token = "0x14000021")]
	public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed
	{
		[Address(RVA = "0x29BEC90", Offset = "0x29BE090", Length = "0xEE")]
		[Token(Token = "0x6000CE0")]
		 add { } //Length: 238
		[Address(RVA = "0x29BF8C0", Offset = "0x29BECC0", Length = "0x112")]
		[Token(Token = "0x6000CE1")]
		 remove { } //Length: 274
	}

	[Token(Token = "0x17000369")]
	public IInputActionCollection actions
	{
		[Address(RVA = "0x29BED80", Offset = "0x29BE180", Length = "0x8C")]
		[Token(Token = "0x6000CD9")]
		 get { } //Length: 140
	}

	[Token(Token = "0x1700036D")]
	public static ReadOnlyArray<InputUser> all
	{
		[Address(RVA = "0x29BEE10", Offset = "0x29BE210", Length = "0x82")]
		[Token(Token = "0x6000CDD")]
		 get { } //Length: 130
	}

	[Token(Token = "0x1700036A")]
	public Nullable<InputControlScheme> controlScheme
	{
		[Address(RVA = "0x29BEF70", Offset = "0x29BE370", Length = "0xA7")]
		[Token(Token = "0x6000CDA")]
		 get { } //Length: 167
	}

	[Token(Token = "0x1700036B")]
	public MatchResult controlSchemeMatch
	{
		[Address(RVA = "0x29BEEA0", Offset = "0x29BE2A0", Length = "0xCE")]
		[Token(Token = "0x6000CDB")]
		 get { } //Length: 206
	}

	[Token(Token = "0x1700036C")]
	public bool hasMissingRequiredDevices
	{
		[Address(RVA = "0x29BF020", Offset = "0x29BE420", Length = "0x93")]
		[Token(Token = "0x6000CDC")]
		 get { } //Length: 147
	}

	[Token(Token = "0x17000363")]
	public uint id
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000CD3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000362")]
	public int index
	{
		[Address(RVA = "0x29BF0C0", Offset = "0x29BE4C0", Length = "0x1D8")]
		[Token(Token = "0x6000CD2")]
		 get { } //Length: 472
	}

	[Token(Token = "0x1700036E")]
	public static int listenForUnpairedDeviceActivity
	{
		[Address(RVA = "0x29BF2A0", Offset = "0x29BE6A0", Length = "0x51")]
		[Token(Token = "0x6000CE4")]
		 get { } //Length: 81
		[Address(RVA = "0x29BF9E0", Offset = "0x29BEDE0", Length = "0x148")]
		[Token(Token = "0x6000CE5")]
		 set { } //Length: 328
	}

	[Token(Token = "0x17000368")]
	public ReadOnlyArray<InputDevice> lostDevices
	{
		[Address(RVA = "0x29BF300", Offset = "0x29BE700", Length = "0xCC")]
		[Token(Token = "0x6000CD8")]
		 get { } //Length: 204
	}

	[Token(Token = "0x17000367")]
	public ReadOnlyArray<InputDevice> pairedDevices
	{
		[Address(RVA = "0x29BF3D0", Offset = "0x29BE7D0", Length = "0xC6")]
		[Token(Token = "0x6000CD7")]
		 get { } //Length: 198
	}

	[Token(Token = "0x17000364")]
	public Nullable<InputUserAccountHandle> platformUserAccountHandle
	{
		[Address(RVA = "0x29BF4A0", Offset = "0x29BE8A0", Length = "0xA9")]
		[Token(Token = "0x6000CD4")]
		 get { } //Length: 169
	}

	[Token(Token = "0x17000366")]
	public string platformUserAccountId
	{
		[Address(RVA = "0x29BF550", Offset = "0x29BE950", Length = "0x8C")]
		[Token(Token = "0x6000CD6")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000365")]
	public string platformUserAccountName
	{
		[Address(RVA = "0x29BF5E0", Offset = "0x29BE9E0", Length = "0x8C")]
		[Token(Token = "0x6000CD5")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000361")]
	public bool valid
	{
		[Address(RVA = "0x29BF670", Offset = "0x29BEA70", Length = "0xCB")]
		[Token(Token = "0x6000CD1")]
		 get { } //Length: 203
	}

	[Address(RVA = "0x29BEA70", Offset = "0x29BDE70", Length = "0x98")]
	[Token(Token = "0x6000D16")]
	private static InputUser() { }

	[Address(RVA = "0x29B7CB0", Offset = "0x29B70B0", Length = "0xD8")]
	[Token(Token = "0x6000CE8")]
	public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) { }

	[Address(RVA = "0x29B7AB0", Offset = "0x29B6EB0", Length = "0x1F4")]
	[Token(Token = "0x6000CEB")]
	public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) { }

	[Address(RVA = "0x29B75C0", Offset = "0x29B69C0", Length = "0x4EE")]
	[Token(Token = "0x6000CEC")]
	private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) { }

	[Address(RVA = "0x29BEB10", Offset = "0x29BDF10", Length = "0xB9")]
	[Token(Token = "0x6000CDE")]
	public static void add_onChange(Action<InputUser, InputUserChange, InputDevice> value) { }

	[Address(RVA = "0x29BEBD0", Offset = "0x29BDFD0", Length = "0xBC")]
	[Token(Token = "0x6000CE2")]
	public static void add_onPrefilterUnpairedDeviceActivity(Func<InputDevice, InputEventPtr, Boolean> value) { }

	[Address(RVA = "0x29BEC90", Offset = "0x29BE090", Length = "0xEE")]
	[Token(Token = "0x6000CE0")]
	public static void add_onUnpairedDeviceUsed(Action<InputControl, InputEventPtr> value) { }

	[Address(RVA = "0x29B7D90", Offset = "0x29B7190", Length = "0x89B")]
	[Token(Token = "0x6000D03")]
	private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice = false, bool dontUpdateControlScheme = false) { }

	[Address(RVA = "0x29B8630", Offset = "0x29B7A30", Length = "0x1A5")]
	[Token(Token = "0x6000CFD")]
	private static int AddUser() { }

	[Address(RVA = "0x29B87E0", Offset = "0x29B7BE0", Length = "0x658")]
	[Token(Token = "0x6000CE7")]
	public void AssociateActionsWithUser(IInputActionCollection actions) { }

	[Address(RVA = "0x29B8E40", Offset = "0x29B8240", Length = "0x6E")]
	[Token(Token = "0x6000CF5")]
	public static InputUser CreateUserWithoutPairedDevices() { }

	[Address(RVA = "0x29B8EB0", Offset = "0x29B82B0", Length = "0xF9")]
	[Token(Token = "0x6000D14")]
	private static void DisposeAndResetGlobalState() { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x6000CF8")]
	public override bool Equals(InputUser other) { }

	[Address(RVA = "0x29B8FB0", Offset = "0x29B83B0", Length = "0x97")]
	[Token(Token = "0x6000CF9")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x29B9050", Offset = "0x29B8450", Length = "0x11A")]
	[Token(Token = "0x6000CEA")]
	internal void FindControlScheme(string schemeName, out InputControlScheme scheme) { }

	[Address(RVA = "0x29B9170", Offset = "0x29B8570", Length = "0xE6")]
	[Token(Token = "0x6000D0B")]
	private static int FindLostDevice(InputDevice device, int startIndex = 0) { }

	[Address(RVA = "0x29B9260", Offset = "0x29B8660", Length = "0x280")]
	[Token(Token = "0x6000CF4")]
	public static Nullable<InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) { }

	[Address(RVA = "0x29B94F0", Offset = "0x29B88F0", Length = "0x25F")]
	[Token(Token = "0x6000CF3")]
	public static Nullable<InputUser> FindUserPairedToDevice(InputDevice device) { }

	[Address(RVA = "0x29BED80", Offset = "0x29BE180", Length = "0x8C")]
	[Token(Token = "0x6000CD9")]
	public IInputActionCollection get_actions() { }

	[Address(RVA = "0x29BEE10", Offset = "0x29BE210", Length = "0x82")]
	[Token(Token = "0x6000CDD")]
	public static ReadOnlyArray<InputUser> get_all() { }

	[Address(RVA = "0x29BEF70", Offset = "0x29BE370", Length = "0xA7")]
	[Token(Token = "0x6000CDA")]
	public Nullable<InputControlScheme> get_controlScheme() { }

	[Address(RVA = "0x29BEEA0", Offset = "0x29BE2A0", Length = "0xCE")]
	[Token(Token = "0x6000CDB")]
	public MatchResult get_controlSchemeMatch() { }

	[Address(RVA = "0x29BF020", Offset = "0x29BE420", Length = "0x93")]
	[Token(Token = "0x6000CDC")]
	public bool get_hasMissingRequiredDevices() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000CD3")]
	public uint get_id() { }

	[Address(RVA = "0x29BF0C0", Offset = "0x29BE4C0", Length = "0x1D8")]
	[Token(Token = "0x6000CD2")]
	public int get_index() { }

	[Address(RVA = "0x29BF2A0", Offset = "0x29BE6A0", Length = "0x51")]
	[Token(Token = "0x6000CE4")]
	public static int get_listenForUnpairedDeviceActivity() { }

	[Address(RVA = "0x29BF300", Offset = "0x29BE700", Length = "0xCC")]
	[Token(Token = "0x6000CD8")]
	public ReadOnlyArray<InputDevice> get_lostDevices() { }

	[Address(RVA = "0x29BF3D0", Offset = "0x29BE7D0", Length = "0xC6")]
	[Token(Token = "0x6000CD7")]
	public ReadOnlyArray<InputDevice> get_pairedDevices() { }

	[Address(RVA = "0x29BF4A0", Offset = "0x29BE8A0", Length = "0xA9")]
	[Token(Token = "0x6000CD4")]
	public Nullable<InputUserAccountHandle> get_platformUserAccountHandle() { }

	[Address(RVA = "0x29BF550", Offset = "0x29BE950", Length = "0x8C")]
	[Token(Token = "0x6000CD6")]
	public string get_platformUserAccountId() { }

	[Address(RVA = "0x29BF5E0", Offset = "0x29BE9E0", Length = "0x8C")]
	[Token(Token = "0x6000CD5")]
	public string get_platformUserAccountName() { }

	[Address(RVA = "0x29BF670", Offset = "0x29BEA70", Length = "0xCB")]
	[Token(Token = "0x6000CD1")]
	public bool get_valid() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000CFA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x29B9950", Offset = "0x29B8D50", Length = "0x7A")]
	[Token(Token = "0x6000CF1")]
	public static InputControlList<InputDevice> GetUnpairedInputDevices() { }

	[Address(RVA = "0x29B9750", Offset = "0x29B8B50", Length = "0x1F1")]
	[Token(Token = "0x6000CF2")]
	public static int GetUnpairedInputDevices(ref InputControlList<InputDevice>& list) { }

	[Address(RVA = "0x29B99D0", Offset = "0x29B8DD0", Length = "0x17B")]
	[Token(Token = "0x6000D0E")]
	private static void HookIntoActionChange() { }

	[Address(RVA = "0x29B9B50", Offset = "0x29B8F50", Length = "0x16A")]
	[Token(Token = "0x6000D10")]
	private static void HookIntoDeviceChange() { }

	[Address(RVA = "0x29B9CC0", Offset = "0x29B90C0", Length = "0x182")]
	[Token(Token = "0x6000D12")]
	private static void HookIntoEvents() { }

	[Address(RVA = "0x29B9F10", Offset = "0x29B9310", Length = "0x242")]
	[Token(Token = "0x6000CF7")]
	private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options) { }

	[Address(RVA = "0x29B9E50", Offset = "0x29B9250", Length = "0xB4")]
	[Token(Token = "0x6000D08")]
	private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device) { }

	[Address(RVA = "0x29BA160", Offset = "0x29B9560", Length = "0x2CB")]
	[Token(Token = "0x6000CFF")]
	private static void Notify(int userIndex, InputUserChange change, InputDevice device) { }

	[Address(RVA = "0x29BA430", Offset = "0x29B9830", Length = "0x164")]
	[Token(Token = "0x6000D09")]
	private static void OnActionChange(object obj, InputActionChange change) { }

	[Address(RVA = "0x29BA5A0", Offset = "0x29B99A0", Length = "0x793")]
	[Token(Token = "0x6000D0A")]
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[Address(RVA = "0x29BAD40", Offset = "0x29BA140", Length = "0x594")]
	[Token(Token = "0x6000D0C")]
	private static void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000CFB")]
	public static bool op_Equality(InputUser left, InputUser right) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000CFC")]
	public static bool op_Inequality(InputUser left, InputUser right) { }

	[Address(RVA = "0x29BB2E0", Offset = "0x29BA6E0", Length = "0x2E8")]
	[Token(Token = "0x6000CF6")]
	public static InputUser PerformPairingWithDevice(InputDevice device, InputUser user = null, InputUserPairingOptions options = 0) { }

	[Address(RVA = "0x29BB5D0", Offset = "0x29BA9D0", Length = "0x258")]
	[Token(Token = "0x6000D07")]
	private static long QueryPairedPlatformUserAccount(InputDevice device, out Nullable<InputUserAccountHandle>& platformAccountHandle, out string platformAccountName, out string platformAccountId) { }

	[Address(RVA = "0x29BF740", Offset = "0x29BEB40", Length = "0xB9")]
	[Token(Token = "0x6000CDF")]
	public static void remove_onChange(Action<InputUser, InputUserChange, InputDevice> value) { }

	[Address(RVA = "0x29BF800", Offset = "0x29BEC00", Length = "0xBC")]
	[Token(Token = "0x6000CE3")]
	public static void remove_onPrefilterUnpairedDeviceActivity(Func<InputDevice, InputEventPtr, Boolean> value) { }

	[Address(RVA = "0x29BF8C0", Offset = "0x29BECC0", Length = "0x112")]
	[Token(Token = "0x6000CE1")]
	public static void remove_onUnpairedDeviceUsed(Action<InputControl, InputEventPtr> value) { }

	[Address(RVA = "0x29BB830", Offset = "0x29BAC30", Length = "0x7FC")]
	[Token(Token = "0x6000D04")]
	private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice = false) { }

	[Address(RVA = "0x29BC030", Offset = "0x29BB430", Length = "0x228")]
	[Token(Token = "0x6000CEF")]
	private static void RemoveLostDevicesForUser(int userIndex) { }

	[Address(RVA = "0x29BC260", Offset = "0x29BB660", Length = "0x39F")]
	[Token(Token = "0x6000CFE")]
	private static void RemoveUser(int userIndex) { }

	[Address(RVA = "0x29BC600", Offset = "0x29BBA00", Length = "0x139")]
	[Token(Token = "0x6000D15")]
	internal static void ResetGlobals() { }

	[Address(RVA = "0x29BC740", Offset = "0x29BBB40", Length = "0x25E")]
	[Token(Token = "0x6000D0D")]
	internal static ISavedState SaveAndResetState() { }

	[Address(RVA = "0x29BF9E0", Offset = "0x29BEDE0", Length = "0x148")]
	[Token(Token = "0x6000CE5")]
	public static void set_listenForUnpairedDeviceActivity(int value) { }

	[Address(RVA = "0x29BC9A0", Offset = "0x29BBDA0", Length = "0x2DD")]
	[Token(Token = "0x6000CE6")]
	public virtual string ToString() { }

	[Address(RVA = "0x29BCC80", Offset = "0x29BC080", Length = "0x316")]
	[Token(Token = "0x6000CE9")]
	private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme) { }

	[Address(RVA = "0x29BD080", Offset = "0x29BC480", Length = "0x14E")]
	[Token(Token = "0x6000D02")]
	private static int TryFindUserIndex(InputDevice device) { }

	[Address(RVA = "0x29BCFA0", Offset = "0x29BC3A0", Length = "0xD0")]
	[Token(Token = "0x6000D00")]
	private static int TryFindUserIndex(uint userId) { }

	[Address(RVA = "0x29BD1D0", Offset = "0x29BC5D0", Length = "0x13B")]
	[Token(Token = "0x6000D01")]
	private static int TryFindUserIndex(InputUserAccountHandle platformHandle) { }

	[Address(RVA = "0x29BD310", Offset = "0x29BC710", Length = "0xF1")]
	[Token(Token = "0x6000D0F")]
	private static void UnhookFromActionChange() { }

	[Address(RVA = "0x29BD410", Offset = "0x29BC810", Length = "0xBE")]
	[Token(Token = "0x6000D11")]
	private static void UnhookFromDeviceChange() { }

	[Address(RVA = "0x29BD4D0", Offset = "0x29BC8D0", Length = "0xE4")]
	[Token(Token = "0x6000D13")]
	private static void UnhookFromDeviceStateChange() { }

	[Address(RVA = "0x29BD5C0", Offset = "0x29BC9C0", Length = "0x114")]
	[Token(Token = "0x6000CED")]
	public void UnpairDevice(InputDevice device) { }

	[Address(RVA = "0x29BD750", Offset = "0x29BCB50", Length = "0x28E")]
	[Token(Token = "0x6000CEE")]
	public void UnpairDevices() { }

	[Address(RVA = "0x29BD6E0", Offset = "0x29BCAE0", Length = "0x63")]
	[Token(Token = "0x6000CF0")]
	public void UnpairDevicesAndRemoveUser() { }

	[Address(RVA = "0x29BD9E0", Offset = "0x29BCDE0", Length = "0xA08")]
	[Token(Token = "0x6000D05")]
	private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false) { }

	[Address(RVA = "0x29BE3F0", Offset = "0x29BD7F0", Length = "0x671")]
	[Token(Token = "0x6000D06")]
	private static long UpdatePlatformUserAccount(int userIndex, InputDevice device) { }

}

