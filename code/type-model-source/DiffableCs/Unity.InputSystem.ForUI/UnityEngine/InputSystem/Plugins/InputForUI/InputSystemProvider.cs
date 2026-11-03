namespace UnityEngine.InputSystem.Plugins.InputForUI;

[Token(Token = "0x2000004")]
internal class InputSystemProvider : IEventProviderImpl
{
	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <>c
	{
		[Token(Token = "0x4000026")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000027")]
		public static Comparison<Event> <>9__33_0; //Field offset: 0x8

		[Address(RVA = "0x28F8140", Offset = "0x28F7540", Length = "0x67")]
		[Token(Token = "0x600002E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600002F")]
		public <>c() { }

		[Address(RVA = "0x28F7FD0", Offset = "0x28F73D0", Length = "0x165")]
		[Token(Token = "0x6000030")]
		internal int <Update>b__33_0(Event a, Event b) { }

	}

	[Token(Token = "0x2000005")]
	internal static class Actions
	{
		[Token(Token = "0x400001E")]
		public static readonly string PointAction; //Field offset: 0x0
		[Token(Token = "0x400001F")]
		public static readonly string MoveAction; //Field offset: 0x8
		[Token(Token = "0x4000020")]
		public static readonly string SubmitAction; //Field offset: 0x10
		[Token(Token = "0x4000021")]
		public static readonly string CancelAction; //Field offset: 0x18
		[Token(Token = "0x4000022")]
		public static readonly string LeftClickAction; //Field offset: 0x20
		[Token(Token = "0x4000023")]
		public static readonly string MiddleClickAction; //Field offset: 0x28
		[Token(Token = "0x4000024")]
		public static readonly string RightClickAction; //Field offset: 0x30
		[Token(Token = "0x4000025")]
		public static readonly string ScrollWheelAction; //Field offset: 0x38

		[Address(RVA = "0x28F3570", Offset = "0x28F2970", Length = "0x237")]
		[Token(Token = "0x600002D")]
		private static Actions() { }

	}

	[Token(Token = "0x400001D")]
	private const uint k_DefaultPlayerId = 0; //Field offset: 0x0
	[Token(Token = "0x400001B")]
	private const float kScrollUGUIScaleFactor = 3; //Field offset: 0x0
	[Token(Token = "0x4000018")]
	private const float k_SmallestReportedMovementSqrDist = 0.01; //Field offset: 0x0
	[Token(Token = "0x400001C")]
	private static Action<InputActionAsset> s_OnRegisterActions; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	private InputEventPartialProvider m_InputEventPartialProvider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000007")]
	private DefaultInputActions m_DefaultInputActions; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000008")]
	private InputActionAsset m_InputActionAsset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000009")]
	private InputAction m_PointAction; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000A")]
	private InputAction m_MoveAction; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000B")]
	private InputAction m_SubmitAction; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000C")]
	private InputAction m_CancelAction; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400000D")]
	private InputAction m_LeftClickAction; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400000E")]
	private InputAction m_MiddleClickAction; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400000F")]
	private InputAction m_RightClickAction; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000010")]
	private InputAction m_ScrollWheelAction; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000011")]
	private InputAction m_NextPreviousAction; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000012")]
	private List<Event> m_Events; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000013")]
	private PointerState m_MouseState; //Field offset: 0x78
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000014")]
	private PointerState m_PenState; //Field offset: 0xA0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000015")]
	private bool m_SeenPenEvents; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000016")]
	private PointerState m_TouchState; //Field offset: 0xD0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000017")]
	private bool m_SeenTouchEvents; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000019")]
	private NavigationEventRepeatHelper m_RepeatHelper; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400001A")]
	private bool m_ResetSeenEventsOnUpdate; //Field offset: 0x108

	[Token(Token = "0x17000002")]
	private DiscreteTime m_CurrentTime
	{
		[Address(RVA = "0x28F7F80", Offset = "0x28F7380", Length = "0x29")]
		[Token(Token = "0x6000006")]
		private get { } //Length: 41
	}

	[Token(Token = "0x17000001")]
	private EventModifiers m_EventModifiers
	{
		[Address(RVA = "0x28F7FB0", Offset = "0x28F73B0", Length = "0x1A")]
		[Token(Token = "0x6000005")]
		private get { } //Length: 26
	}

	[Token(Token = "0x17000003")]
	public override uint playerCount
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x28F7DB0", Offset = "0x28F71B0", Length = "0x105")]
	[Token(Token = "0x6000003")]
	private static InputSystemProvider() { }

	[Address(RVA = "0x28F7EC0", Offset = "0x28F72C0", Length = "0xB2")]
	[Token(Token = "0x600002C")]
	public InputSystemProvider() { }

	[Address(RVA = "0x28F37B0", Offset = "0x28F2BB0", Length = "0x50")]
	[Token(Token = "0x600000C")]
	public bool ActionAssetIsNotNull() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	[Token(Token = "0x6000004")]
	private static void Bootstrap() { }

	[Address(RVA = "0x28F3800", Offset = "0x28F2C00", Length = "0x48C")]
	[Token(Token = "0x600000D")]
	private void DirectionNavigation(DiscreteTime currentTime) { }

	[Address(RVA = "0x28F3CB0", Offset = "0x28F30B0", Length = "0x193")]
	[Token(Token = "0x600001A")]
	private void DispatchFromCallback(in Event ev) { }

	[Address(RVA = "0x28F3E50", Offset = "0x28F3250", Length = "0x50")]
	[Token(Token = "0x6000026")]
	private InputAction FindActionAndRegisterCallback(string actionNameOrId, Action<CallbackContext> callback = null) { }

	[Address(RVA = "0x28F3EB0", Offset = "0x28F32B0", Length = "0x2FC")]
	[Token(Token = "0x600001B")]
	private static int FindTouchFingerIndex(Touchscreen touchscreen, CallbackContext ctx) { }

	[Address(RVA = "0x28F7F80", Offset = "0x28F7380", Length = "0x29")]
	[Token(Token = "0x6000006")]
	private DiscreteTime get_m_CurrentTime() { }

	[Address(RVA = "0x28F7FB0", Offset = "0x28F73B0", Length = "0x1A")]
	[Token(Token = "0x6000005")]
	private EventModifiers get_m_EventModifiers() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000014")]
	public override uint get_playerCount() { }

	[Address(RVA = "0x28F41B0", Offset = "0x28F35B0", Length = "0x88")]
	[Token(Token = "0x600000E")]
	private InputDevice GetActiveDeviceFromDirection(Direction direction) { }

	[Address(RVA = "0x28F42A0", Offset = "0x28F36A0", Length = "0x168")]
	[Token(Token = "0x6000018")]
	private EventSource GetEventSource(InputDevice device) { }

	[Address(RVA = "0x28F4260", Offset = "0x28F3660", Length = "0x35")]
	[Token(Token = "0x6000017")]
	private EventSource GetEventSource(CallbackContext ctx) { }

	[Address(RVA = "0x28F4410", Offset = "0x28F3810", Length = "0x21")]
	[Token(Token = "0x6000019")]
	private PointerState GetPointerStateForSource(EventSource eventSource) { }

	[Address(RVA = "0x28F4440", Offset = "0x28F3840", Length = "0x245")]
	[Token(Token = "0x6000007")]
	public override void Initialize() { }

	[Address(RVA = "0x28F4690", Offset = "0x28F3A90", Length = "0x29")]
	[Token(Token = "0x6000009")]
	public void OnActionsChange() { }

	[Address(RVA = "0x28F46C0", Offset = "0x28F3AC0", Length = "0x183")]
	[Token(Token = "0x600001E")]
	private void OnCancelPerformed(CallbackContext ctx) { }

	[Address(RVA = "0x28F4850", Offset = "0x28F3C50", Length = "0x506")]
	[Token(Token = "0x600001F")]
	private void OnClickPerformed(CallbackContext ctx, EventSource eventSource, Button button) { }

	[Address(RVA = "0x28F4D60", Offset = "0x28F4160", Length = "0x1E")]
	[Token(Token = "0x6000012")]
	public override void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x28F4D80", Offset = "0x28F4180", Length = "0x6F")]
	[Token(Token = "0x6000020")]
	private void OnLeftClickPerformed(CallbackContext ctx) { }

	[Address(RVA = "0x28F4DF0", Offset = "0x28F41F0", Length = "0x6F")]
	[Token(Token = "0x6000021")]
	private void OnMiddleClickPerformed(CallbackContext ctx) { }

	[Address(RVA = "0x28F4E60", Offset = "0x28F4260", Length = "0xA3D")]
	[Token(Token = "0x600001C")]
	private void OnPointerPerformed(CallbackContext ctx) { }

	[Address(RVA = "0x28F58A0", Offset = "0x28F4CA0", Length = "0x6F")]
	[Token(Token = "0x6000022")]
	private void OnRightClickPerformed(CallbackContext ctx) { }

	[Address(RVA = "0x28F5910", Offset = "0x28F4D10", Length = "0x576")]
	[Token(Token = "0x6000023")]
	private void OnScrollWheelPerformed(CallbackContext ctx) { }

	[Address(RVA = "0x28F5E90", Offset = "0x28F5290", Length = "0x183")]
	[Token(Token = "0x600001D")]
	private void OnSubmitPerformed(CallbackContext ctx) { }

	[Address(RVA = "0x28F6020", Offset = "0x28F5420", Length = "0xD0")]
	[Token(Token = "0x600000F")]
	private ValueTuple<Vector2, Boolean> ReadCurrentNavigationMoveVector() { }

	[Address(RVA = "0x28F6100", Offset = "0x28F5500", Length = "0x143")]
	[Token(Token = "0x6000010")]
	private Direction ReadNextPreviousDirection() { }

	[Address(RVA = "0x28F6250", Offset = "0x28F5650", Length = "0x550")]
	[Token(Token = "0x6000027")]
	private void RegisterActions() { }

	[Address(RVA = "0x28F67B0", Offset = "0x28F5BB0", Length = "0xDE")]
	[Token(Token = "0x6000024")]
	private void RegisterFixedActions() { }

	[Address(RVA = "0x28F6890", Offset = "0x28F5C90", Length = "0x5D4")]
	[Token(Token = "0x6000013")]
	public override bool RequestCurrentState(Type type) { }

	[Address(RVA = "0x28F6E70", Offset = "0x28F6270", Length = "0xF")]
	[Token(Token = "0x600000B")]
	private void ResetSeenEvents() { }

	[Address(RVA = "0x28F6E80", Offset = "0x28F6280", Length = "0xDB")]
	[Token(Token = "0x6000015")]
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[Address(RVA = "0x28F6F60", Offset = "0x28F6360", Length = "0x144")]
	[Token(Token = "0x600002A")]
	private void SelectInputActionAsset() { }

	[Address(RVA = "0x28F70B0", Offset = "0x28F64B0", Length = "0x69")]
	[Token(Token = "0x600002B")]
	internal static void SetOnRegisterActions(Action<InputActionAsset> callback) { }

	[Address(RVA = "0x28F7120", Offset = "0x28F6520", Length = "0x102")]
	[Token(Token = "0x6000008")]
	public override void Shutdown() { }

	[Address(RVA = "0x28F7230", Offset = "0x28F6630", Length = "0x134")]
	[Token(Token = "0x6000011")]
	private static int SortEvents(Event a, Event b) { }

	[Address(RVA = "0x28F7370", Offset = "0x28F6770", Length = "0x16D")]
	[Token(Token = "0x6000016")]
	private PointerEvent ToPointerStateEvent(DiscreteTime currentTime, in PointerState state, EventSource eventSource) { }

	[Address(RVA = "0x28F74E0", Offset = "0x28F68E0", Length = "0x3B")]
	[Token(Token = "0x6000028")]
	private void UnregisterAction(ref InputAction action, Action<CallbackContext> callback = null) { }

	[Address(RVA = "0x28F7520", Offset = "0x28F6920", Length = "0x312")]
	[Token(Token = "0x6000029")]
	private void UnregisterActions() { }

	[Address(RVA = "0x28F7840", Offset = "0x28F6C40", Length = "0x39")]
	[Token(Token = "0x6000025")]
	private void UnregisterFixedActions() { }

	[Address(RVA = "0x28F7880", Offset = "0x28F6C80", Length = "0x52A")]
	[Token(Token = "0x600000A")]
	public override void Update() { }

}

