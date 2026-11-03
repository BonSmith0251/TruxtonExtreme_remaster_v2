namespace UnityEngine.InputSystem.UI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/UISupport.html#setting-up-ui-input")]
[Token(Token = "0x200011C")]
public class InputSystemUIInputModule : BaseInputModule
{
	[Token(Token = "0x200011E")]
	internal enum CursorLockBehavior : int
	{
		OutsideScreen = 0,
		ScreenCenter = 1,
	}

	[Token(Token = "0x200011D")]
	private struct InputActionReferenceState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A4")]
		public int refCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40006A5")]
		public bool enabledByInputModule; //Field offset: 0x4

	}

	[Token(Token = "0x4000679")]
	private const float kClickSpeed = 0.3; //Field offset: 0x0
	[Token(Token = "0x400067F")]
	private const float kSmallestScrollDeltaPerTick = 1E-05; //Field offset: 0x0
	[Token(Token = "0x400067E")]
	private static DefaultInputActions defaultActions; //Field offset: 0x0
	[Token(Token = "0x400068F")]
	private static Dictionary<InputAction, InputActionReferenceState> s_InputActionReferenceCounts; //Field offset: 0x8
	[FieldOffset(Offset = "0x58")]
	[FormerlySerializedAs("m_RepeatDelay")]
	[SerializeField]
	[Token(Token = "0x400067A")]
	[Tooltip("The Initial delay (in seconds) between an initial move action and a repeated move action.")]
	private float m_MoveRepeatDelay; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[FormerlySerializedAs("m_RepeatRate")]
	[SerializeField]
	[Token(Token = "0x400067B")]
	[Tooltip("The speed (in seconds) that the move action repeats itself once repeating (max 1 per frame).")]
	private float m_MoveRepeatRate; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400067C")]
	[Tooltip("Scales the Eventsystem.DragThreshold, for tracked devices, to make selection easier.")]
	private float m_TrackedDeviceDragThresholdMultiplier; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400067D")]
	[Tooltip("Transform representing the real world origin for tracking devices. When using the XR Interaction Toolkit, this should be pointing to the XR Rig's Transform.")]
	private Transform m_XRTrackingOrigin; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000680")]
	private InputActionAsset m_ActionsAsset; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000681")]
	private InputActionReference m_PointAction; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000682")]
	private InputActionReference m_MoveAction; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000683")]
	private InputActionReference m_SubmitAction; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000684")]
	private InputActionReference m_CancelAction; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000685")]
	private InputActionReference m_LeftClickAction; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000686")]
	private InputActionReference m_MiddleClickAction; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000687")]
	private InputActionReference m_RightClickAction; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000688")]
	private InputActionReference m_ScrollWheelAction; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000689")]
	private InputActionReference m_TrackedDevicePositionAction; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400068A")]
	private InputActionReference m_TrackedDeviceOrientationAction; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x400068B")]
	private bool m_DeselectOnBackgroundClick; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	[Token(Token = "0x400068C")]
	private UIPointerBehavior m_PointerBehavior; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400068D")]
	internal CursorLockBehavior m_CursorLockBehavior; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	[Token(Token = "0x400068E")]
	private float m_ScrollDeltaPerTick; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000690")]
	private bool m_ActionsHooked; //Field offset: 0xD8
	[FieldOffset(Offset = "0xD9")]
	[Token(Token = "0x4000691")]
	private bool m_NeedToPurgeStalePointers; //Field offset: 0xD9
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000692")]
	private Action<CallbackContext> m_OnPointDelegate; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000693")]
	private Action<CallbackContext> m_OnMoveDelegate; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000694")]
	private Action<CallbackContext> m_OnSubmitCancelDelegate; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000695")]
	private Action<CallbackContext> m_OnLeftClickDelegate; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000696")]
	private Action<CallbackContext> m_OnRightClickDelegate; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000697")]
	private Action<CallbackContext> m_OnMiddleClickDelegate; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000698")]
	private Action<CallbackContext> m_OnScrollWheelDelegate; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000699")]
	private Action<CallbackContext> m_OnTrackedDevicePositionDelegate; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400069A")]
	private Action<CallbackContext> m_OnTrackedDeviceOrientationDelegate; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400069B")]
	private Action<Object> m_OnControlsChangedDelegate; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400069C")]
	private int m_CurrentPointerId; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x400069D")]
	private int m_CurrentPointerIndex; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400069E")]
	internal UIPointerType m_CurrentPointerType; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400069F")]
	internal InlinedArray<Int32> m_PointerIds; //Field offset: 0x140
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40006A0")]
	internal InlinedArray<PointerModel> m_PointerStates; //Field offset: 0x150
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x40006A1")]
	private NavigationModel m_NavigationState; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x40006A2")]
	private SubmitCancelModel m_SubmitCancelState; //Field offset: 0x408
	[FieldOffset(Offset = "0x418")]
	[Token(Token = "0x40006A3")]
	private GameObject m_LocalMultiPlayerRoot; //Field offset: 0x418

	[Token(Token = "0x170003A0")]
	public InputActionAsset actionsAsset
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000DC9")]
		 get { } //Length: 5
		[Address(RVA = "0x29E0390", Offset = "0x29DF790", Length = "0x6B5")]
		[Token(Token = "0x6000DCA")]
		 set { } //Length: 1717
	}

	[Token(Token = "0x1700039C")]
	public InputActionReference cancel
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000D94")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0A50", Offset = "0x29DFE50", Length = "0x35")]
		[Token(Token = "0x6000D95")]
		 set { } //Length: 53
	}

	[Token(Token = "0x1700038A")]
	public CursorLockBehavior cursorLockBehavior
	{
		[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
		[Token(Token = "0x6000D64")]
		 get { } //Length: 7
		[Address(RVA = "0x29E0A90", Offset = "0x29DFE90", Length = "0x7")]
		[Token(Token = "0x6000D65")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000388")]
	public bool deselectOnBackgroundClick
	{
		[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
		[Token(Token = "0x6000D60")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0AA0", Offset = "0x29DFEA0", Length = "0x7")]
		[Token(Token = "0x6000D61")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700038F")]
	private bool explictlyIgnoreFocus
	{
		[Address(RVA = "0x29E0230", Offset = "0x29DF630", Length = "0x52")]
		[Token(Token = "0x6000D7B")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000397")]
	public InputActionReference leftClick
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6000D8A")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0AB0", Offset = "0x29DFEB0", Length = "0x35")]
		[Token(Token = "0x6000D8B")]
		 set { } //Length: 53
	}

	[Token(Token = "0x1700038B")]
	internal GameObject localMultiPlayerRoot
	{
		[Address(RVA = "0x29E0290", Offset = "0x29DF690", Length = "0x8")]
		[Token(Token = "0x6000D66")]
		internal get { } //Length: 8
		[Address(RVA = "0x29E0AF0", Offset = "0x29DFEF0", Length = "0x13")]
		[Token(Token = "0x6000D67")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000398")]
	public InputActionReference middleClick
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6000D8C")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0B10", Offset = "0x29DFF10", Length = "0x35")]
		[Token(Token = "0x6000D8D")]
		 set { } //Length: 53
	}

	[Token(Token = "0x1700039A")]
	public InputActionReference move
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000D90")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0B60", Offset = "0x29DFF60", Length = "0x35")]
		[Token(Token = "0x6000D91")]
		 set { } //Length: 53
	}

	[Token(Token = "0x1700038D")]
	public float moveRepeatDelay
	{
		[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
		[Token(Token = "0x6000D77")]
		 get { } //Length: 6
		[Address(RVA = "0x29E0B50", Offset = "0x29DFF50", Length = "0x6")]
		[Token(Token = "0x6000D78")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700038E")]
	public float moveRepeatRate
	{
		[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
		[Token(Token = "0x6000D79")]
		 get { } //Length: 6
		[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
		[Token(Token = "0x6000D7A")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000395")]
	public InputActionReference point
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000D86")]
		 get { } //Length: 5
		[Address(RVA = "0x29E0BA0", Offset = "0x29DFFA0", Length = "0x32")]
		[Token(Token = "0x6000D87")]
		 set { } //Length: 50
	}

	[Token(Token = "0x17000389")]
	public UIPointerBehavior pointerBehavior
	{
		[Address(RVA = "0x1CCEF20", Offset = "0x1CCE320", Length = "0x7")]
		[Token(Token = "0x6000D62")]
		 get { } //Length: 7
		[Address(RVA = "0x29E0BE0", Offset = "0x29DFFE0", Length = "0x7")]
		[Token(Token = "0x6000D63")]
		 set { } //Length: 7
	}

	[Obsolete("'repeatDelay' has been obsoleted; use 'moveRepeatDelay' instead. (UnityUpgradable) -> moveRepeatDelay", False)]
	[Token(Token = "0x17000392")]
	public float repeatDelay
	{
		[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
		[Token(Token = "0x6000D7F")]
		 get { } //Length: 6
		[Address(RVA = "0x29E0B50", Offset = "0x29DFF50", Length = "0x6")]
		[Token(Token = "0x6000D80")]
		 set { } //Length: 6
	}

	[Obsolete("'repeatRate' has been obsoleted; use 'moveRepeatRate' instead. (UnityUpgradable) -> moveRepeatRate", False)]
	[Token(Token = "0x17000391")]
	public float repeatRate
	{
		[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
		[Token(Token = "0x6000D7D")]
		 get { } //Length: 6
		[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
		[Token(Token = "0x6000D7E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000399")]
	public InputActionReference rightClick
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x6000D8E")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0BF0", Offset = "0x29DFFF0", Length = "0x35")]
		[Token(Token = "0x6000D8F")]
		 set { } //Length: 53
	}

	[Token(Token = "0x1700038C")]
	public float scrollDeltaPerTick
	{
		[Address(RVA = "0x1D43820", Offset = "0x1D42C20", Length = "0x9")]
		[Token(Token = "0x6000D68")]
		 get { } //Length: 9
		[Address(RVA = "0x29E0C30", Offset = "0x29E0030", Length = "0x9")]
		[Token(Token = "0x6000D69")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000396")]
	public InputActionReference scrollWheel
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x6000D88")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0C40", Offset = "0x29E0040", Length = "0x35")]
		[Token(Token = "0x6000D89")]
		 set { } //Length: 53
	}

	[Token(Token = "0x170003A1")]
	internal bool sendPointerHoverToParent
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000DCB")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000DCC")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000390")]
	private bool shouldIgnoreFocus
	{
		[Address(RVA = "0x29E02A0", Offset = "0x29DF6A0", Length = "0xA6")]
		[Token(Token = "0x6000D7C")]
		private get { } //Length: 166
	}

	[Token(Token = "0x1700039B")]
	public InputActionReference submit
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6000D92")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0C80", Offset = "0x29E0080", Length = "0x35")]
		[Token(Token = "0x6000D93")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000394")]
	public float trackedDeviceDragThresholdMultiplier
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x6000D83")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
		[Token(Token = "0x6000D84")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700039D")]
	public InputActionReference trackedDeviceOrientation
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x6000D96")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0CC0", Offset = "0x29E00C0", Length = "0x35")]
		[Token(Token = "0x6000D97")]
		 set { } //Length: 53
	}

	[Token(Token = "0x1700039E")]
	public InputActionReference trackedDevicePosition
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x6000D98")]
		 get { } //Length: 8
		[Address(RVA = "0x29E0D00", Offset = "0x29E0100", Length = "0x35")]
		[Token(Token = "0x6000D99")]
		 set { } //Length: 53
	}

	[Obsolete("'trackedDeviceSelect' has been obsoleted; use 'leftClick' instead.", True)]
	[Token(Token = "0x1700039F")]
	public InputActionReference trackedDeviceSelect
	{
		[Address(RVA = "0x29E0350", Offset = "0x29DF750", Length = "0x3E")]
		[Token(Token = "0x6000D9D")]
		 get { } //Length: 62
		[Address(RVA = "0x29E0D40", Offset = "0x29E0140", Length = "0x3E")]
		[Token(Token = "0x6000D9E")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000393")]
	public Transform xrTrackingOrigin
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6000D81")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x6000D82")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x29E0160", Offset = "0x29DF560", Length = "0x89")]
	[Token(Token = "0x6000DCE")]
	private static InputSystemUIInputModule() { }

	[Address(RVA = "0x29E01F0", Offset = "0x29DF5F0", Length = "0x38")]
	[Token(Token = "0x6000DCD")]
	public InputSystemUIInputModule() { }

	[Address(RVA = "0x29D88D0", Offset = "0x29D7CD0", Length = "0xBC")]
	[Token(Token = "0x6000D6A")]
	public virtual void ActivateModule() { }

	[Address(RVA = "0x29D8990", Offset = "0x29D7D90", Length = "0x252")]
	[Token(Token = "0x6000DAE")]
	private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, InputControl touchControl = null) { }

	[Address(RVA = "0x29D8BF0", Offset = "0x29D7FF0", Length = "0x50D")]
	[Token(Token = "0x6000D9B")]
	public void AssignDefaultActions() { }

	[Address(RVA = "0x29D9100", Offset = "0x29D8500", Length = "0x59")]
	[Token(Token = "0x6000D9F")]
	protected virtual void Awake() { }

	[Address(RVA = "0x29D9160", Offset = "0x29D8560", Length = "0x67")]
	[Token(Token = "0x6000DB8")]
	private bool CheckForRemovedDevice(ref CallbackContext context) { }

	[Address(RVA = "0x29D91D0", Offset = "0x29D85D0", Length = "0x8E")]
	[Token(Token = "0x6000DC2")]
	public virtual Vector2 ConvertPointerEventScrollDeltaToTicks(Vector2 scrollDelta) { }

	[Address(RVA = "0x29D9260", Offset = "0x29D8660", Length = "0xCE")]
	[Token(Token = "0x6000DC1")]
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	[Address(RVA = "0x29D9330", Offset = "0x29D8730", Length = "0xDA")]
	[Token(Token = "0x6000DA6")]
	private void DisableAllActions() { }

	[Address(RVA = "0x29D9410", Offset = "0x29D8810", Length = "0xBC")]
	[Token(Token = "0x6000DA5")]
	private void EnableAllActions() { }

	[Address(RVA = "0x29D94D0", Offset = "0x29D88D0", Length = "0x196")]
	[Token(Token = "0x6000DA7")]
	private void EnableInputAction(InputActionReference inputActionReference) { }

	[Address(RVA = "0x29D9670", Offset = "0x29D8A70", Length = "0x1EB")]
	[Token(Token = "0x6000DBF")]
	private void FilterPointerStatesByType() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000DC9")]
	public InputActionAsset get_actionsAsset() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000D94")]
	public InputActionReference get_cancel() { }

	[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
	[Token(Token = "0x6000D64")]
	public CursorLockBehavior get_cursorLockBehavior() { }

	[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
	[Token(Token = "0x6000D60")]
	public bool get_deselectOnBackgroundClick() { }

	[Address(RVA = "0x29E0230", Offset = "0x29DF630", Length = "0x52")]
	[Token(Token = "0x6000D7B")]
	private bool get_explictlyIgnoreFocus() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6000D8A")]
	public InputActionReference get_leftClick() { }

	[Address(RVA = "0x29E0290", Offset = "0x29DF690", Length = "0x8")]
	[Token(Token = "0x6000D66")]
	internal GameObject get_localMultiPlayerRoot() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6000D8C")]
	public InputActionReference get_middleClick() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000D90")]
	public InputActionReference get_move() { }

	[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
	[Token(Token = "0x6000D77")]
	public float get_moveRepeatDelay() { }

	[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
	[Token(Token = "0x6000D79")]
	public float get_moveRepeatRate() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000D86")]
	public InputActionReference get_point() { }

	[Address(RVA = "0x1CCEF20", Offset = "0x1CCE320", Length = "0x7")]
	[Token(Token = "0x6000D62")]
	public UIPointerBehavior get_pointerBehavior() { }

	[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
	[Token(Token = "0x6000D7F")]
	public float get_repeatDelay() { }

	[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
	[Token(Token = "0x6000D7D")]
	public float get_repeatRate() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x6000D8E")]
	public InputActionReference get_rightClick() { }

	[Address(RVA = "0x1D43820", Offset = "0x1D42C20", Length = "0x9")]
	[Token(Token = "0x6000D68")]
	public float get_scrollDeltaPerTick() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x6000D88")]
	public InputActionReference get_scrollWheel() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000DCB")]
	internal bool get_sendPointerHoverToParent() { }

	[Address(RVA = "0x29E02A0", Offset = "0x29DF6A0", Length = "0xA6")]
	[Token(Token = "0x6000D7C")]
	private bool get_shouldIgnoreFocus() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6000D92")]
	public InputActionReference get_submit() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x6000D83")]
	public float get_trackedDeviceDragThresholdMultiplier() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x6000D96")]
	public InputActionReference get_trackedDeviceOrientation() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x6000D98")]
	public InputActionReference get_trackedDevicePosition() { }

	[Address(RVA = "0x29E0350", Offset = "0x29DF750", Length = "0x3E")]
	[Token(Token = "0x6000D9D")]
	public InputActionReference get_trackedDeviceSelect() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000D81")]
	public Transform get_xrTrackingOrigin() { }

	[Address(RVA = "0x29D9860", Offset = "0x29D8C60", Length = "0x97")]
	[Token(Token = "0x6000DAB")]
	private int GetDisplayIndexFor(InputControl control) { }

	[Address(RVA = "0x29D9900", Offset = "0x29D8D00", Length = "0xED")]
	[Token(Token = "0x6000D6C")]
	public RaycastResult GetLastRaycastResult(int pointerOrTouchId) { }

	[Address(RVA = "0x29D99F0", Offset = "0x29D8DF0", Length = "0x105")]
	[Token(Token = "0x6000DC3")]
	public virtual NavigationDeviceType GetNavigationEventDeviceType(BaseEventData eventData) { }

	[Address(RVA = "0x29D9B00", Offset = "0x29D8F00", Length = "0x4A")]
	[Token(Token = "0x6000DAA")]
	private PointerModel GetPointerStateForIndex(int index) { }

	[Address(RVA = "0x29D9BF0", Offset = "0x29D8FF0", Length = "0x149")]
	[Token(Token = "0x6000DA9")]
	private int GetPointerStateIndexFor(int pointerOrTouchId) { }

	[Address(RVA = "0x29D9B50", Offset = "0x29D8F50", Length = "0x9C")]
	[Token(Token = "0x6000DAC")]
	private int GetPointerStateIndexFor(ref CallbackContext context) { }

	[Address(RVA = "0x29D9D40", Offset = "0x29D9140", Length = "0x93C")]
	[Token(Token = "0x6000DAD")]
	private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = true) { }

	[Address(RVA = "0x29DA680", Offset = "0x29D9A80", Length = "0x168")]
	[Token(Token = "0x6000DA4")]
	private bool HasNoActions() { }

	[Address(RVA = "0x29DA7F0", Offset = "0x29D9BF0", Length = "0xC5")]
	[Token(Token = "0x6000DB2")]
	private static bool HaveControlForDevice(InputDevice device, InputActionReference actionReference) { }

	[Address(RVA = "0x29DA8C0", Offset = "0x29D9CC0", Length = "0x31F")]
	[Token(Token = "0x6000DC4")]
	private void HookActions() { }

	[Address(RVA = "0x29DABE0", Offset = "0x29D9FE0", Length = "0x10A")]
	[Token(Token = "0x6000DB4")]
	private bool IgnoreNextClick(ref CallbackContext context, bool wasPressed) { }

	[Address(RVA = "0x29DACF0", Offset = "0x29DA0F0", Length = "0x214")]
	[Token(Token = "0x6000D76")]
	private bool IsMoveAllowed(AxisEventData eventData) { }

	[Address(RVA = "0x29DAF10", Offset = "0x29DA310", Length = "0x14B")]
	[Token(Token = "0x6000D6B")]
	public virtual bool IsPointerOverGameObject(int pointerOrTouchId) { }

	[Address(RVA = "0x29DB060", Offset = "0x29DA460", Length = "0x8")]
	[Token(Token = "0x6000DBE")]
	private void OnControlsChanged(object obj) { }

	[Address(RVA = "0x29DB070", Offset = "0x29DA470", Length = "0x31")]
	[Token(Token = "0x6000DA0")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x29DB0B0", Offset = "0x29DA4B0", Length = "0x223")]
	[Token(Token = "0x6000DA2")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x29DB2E0", Offset = "0x29DA6E0", Length = "0x1C0")]
	[Token(Token = "0x6000DA1")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x29DB4A0", Offset = "0x29DA8A0", Length = "0x121")]
	[Token(Token = "0x6000DB5")]
	private void OnLeftClickCallback(CallbackContext context) { }

	[Address(RVA = "0x29DB5D0", Offset = "0x29DA9D0", Length = "0x13C")]
	[Token(Token = "0x6000DB7")]
	private void OnMiddleClickCallback(CallbackContext context) { }

	[Address(RVA = "0x29DB710", Offset = "0x29DAB10", Length = "0x92")]
	[Token(Token = "0x6000DBA")]
	private void OnMoveCallback(CallbackContext context) { }

	[Address(RVA = "0x29DB7B0", Offset = "0x29DABB0", Length = "0x11B")]
	[Token(Token = "0x6000DB3")]
	private void OnPointCallback(CallbackContext context) { }

	[Address(RVA = "0x29DB8D0", Offset = "0x29DACD0", Length = "0x13C")]
	[Token(Token = "0x6000DB6")]
	private void OnRightClickCallback(CallbackContext context) { }

	[Address(RVA = "0x29DBA10", Offset = "0x29DAE10", Length = "0x171")]
	[Token(Token = "0x6000DB9")]
	private void OnScrollCallback(CallbackContext context) { }

	[Address(RVA = "0x29DBB90", Offset = "0x29DAF90", Length = "0x3D")]
	[Token(Token = "0x6000DBB")]
	private void OnSubmitCancelCallback(CallbackContext context) { }

	[Address(RVA = "0x29DBBD0", Offset = "0x29DAFD0", Length = "0x146")]
	[Token(Token = "0x6000DBC")]
	private void OnTrackedDeviceOrientationCallback(CallbackContext context) { }

	[Address(RVA = "0x29DBD20", Offset = "0x29DB120", Length = "0x153")]
	[Token(Token = "0x6000DBD")]
	private void OnTrackedDevicePositionCallback(CallbackContext context) { }

	[Address(RVA = "0x29DBE80", Offset = "0x29DB280", Length = "0x39E")]
	[Token(Token = "0x6000D6D")]
	private RaycastResult PerformRaycast(ExtendedPointerEventData eventData) { }

	[Address(RVA = "0x29DC220", Offset = "0x29DB620", Length = "0xE9")]
	[Token(Token = "0x6000D6F")]
	private bool PointerShouldIgnoreTransform(Transform t) { }

	[Address(RVA = "0x29DE770", Offset = "0x29DDB70", Length = "0x382")]
	[Token(Token = "0x6000DC0")]
	public virtual void Process() { }

	[Address(RVA = "0x29DC310", Offset = "0x29DB710", Length = "0x6F5")]
	[Token(Token = "0x6000D75")]
	internal void ProcessNavigation(ref NavigationModel navigationState) { }

	[Address(RVA = "0x29DE000", Offset = "0x29DD400", Length = "0x76C")]
	[Token(Token = "0x6000D6E")]
	private void ProcessPointer(ref PointerModel state) { }

	[Address(RVA = "0x29DCD20", Offset = "0x29DC120", Length = "0x8B5")]
	[Token(Token = "0x6000D72")]
	private void ProcessPointerButton(ref ButtonState button, PointerEventData eventData) { }

	[Address(RVA = "0x29DCA10", Offset = "0x29DBE10", Length = "0x30F")]
	[Token(Token = "0x6000D73")]
	private void ProcessPointerButtonDrag(ref ButtonState button, ExtendedPointerEventData eventData) { }

	[Address(RVA = "0x29DD640", Offset = "0x29DCA40", Length = "0x875")]
	[Token(Token = "0x6000D71")]
	private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) { }

	[Address(RVA = "0x29DD5E0", Offset = "0x29DC9E0", Length = "0x5B")]
	[Token(Token = "0x6000D70")]
	private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData) { }

	[Address(RVA = "0x29DDEC0", Offset = "0x29DD2C0", Length = "0x13A")]
	[Token(Token = "0x6000D74")]
	private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData) { }

	[Address(RVA = "0x29DEB00", Offset = "0x29DDF00", Length = "0x17F")]
	[Token(Token = "0x6000DB1")]
	private void PurgeStalePointers() { }

	[Address(RVA = "0x29DEC80", Offset = "0x29DE080", Length = "0x2A6")]
	[Token(Token = "0x6000DB0")]
	private bool RemovePointerAtIndex(int index) { }

	[Address(RVA = "0x29DEF30", Offset = "0x29DE330", Length = "0xAC")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	[Token(Token = "0x6000D9A")]
	private static void ResetDefaultActions() { }

	[Address(RVA = "0x29DEFE0", Offset = "0x29DE3E0", Length = "0x11B")]
	[Token(Token = "0x6000DA3")]
	private void ResetPointers() { }

	[Address(RVA = "0x29DF100", Offset = "0x29DE500", Length = "0xD8")]
	[Token(Token = "0x6000DAF")]
	private bool SendPointerExitEventsAndRemovePointer(int index) { }

	[Address(RVA = "0x29E0390", Offset = "0x29DF790", Length = "0x6B5")]
	[Token(Token = "0x6000DCA")]
	public void set_actionsAsset(InputActionAsset value) { }

	[Address(RVA = "0x29E0A50", Offset = "0x29DFE50", Length = "0x35")]
	[Token(Token = "0x6000D95")]
	public void set_cancel(InputActionReference value) { }

	[Address(RVA = "0x29E0A90", Offset = "0x29DFE90", Length = "0x7")]
	[Token(Token = "0x6000D65")]
	public void set_cursorLockBehavior(CursorLockBehavior value) { }

	[Address(RVA = "0x29E0AA0", Offset = "0x29DFEA0", Length = "0x7")]
	[Token(Token = "0x6000D61")]
	public void set_deselectOnBackgroundClick(bool value) { }

	[Address(RVA = "0x29E0AB0", Offset = "0x29DFEB0", Length = "0x35")]
	[Token(Token = "0x6000D8B")]
	public void set_leftClick(InputActionReference value) { }

	[Address(RVA = "0x29E0AF0", Offset = "0x29DFEF0", Length = "0x13")]
	[Token(Token = "0x6000D67")]
	internal void set_localMultiPlayerRoot(GameObject value) { }

	[Address(RVA = "0x29E0B10", Offset = "0x29DFF10", Length = "0x35")]
	[Token(Token = "0x6000D8D")]
	public void set_middleClick(InputActionReference value) { }

	[Address(RVA = "0x29E0B60", Offset = "0x29DFF60", Length = "0x35")]
	[Token(Token = "0x6000D91")]
	public void set_move(InputActionReference value) { }

	[Address(RVA = "0x29E0B50", Offset = "0x29DFF50", Length = "0x6")]
	[Token(Token = "0x6000D78")]
	public void set_moveRepeatDelay(float value) { }

	[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
	[Token(Token = "0x6000D7A")]
	public void set_moveRepeatRate(float value) { }

	[Address(RVA = "0x29E0BA0", Offset = "0x29DFFA0", Length = "0x32")]
	[Token(Token = "0x6000D87")]
	public void set_point(InputActionReference value) { }

	[Address(RVA = "0x29E0BE0", Offset = "0x29DFFE0", Length = "0x7")]
	[Token(Token = "0x6000D63")]
	public void set_pointerBehavior(UIPointerBehavior value) { }

	[Address(RVA = "0x29E0B50", Offset = "0x29DFF50", Length = "0x6")]
	[Token(Token = "0x6000D80")]
	public void set_repeatDelay(float value) { }

	[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
	[Token(Token = "0x6000D7E")]
	public void set_repeatRate(float value) { }

	[Address(RVA = "0x29E0BF0", Offset = "0x29DFFF0", Length = "0x35")]
	[Token(Token = "0x6000D8F")]
	public void set_rightClick(InputActionReference value) { }

	[Address(RVA = "0x29E0C30", Offset = "0x29E0030", Length = "0x9")]
	[Token(Token = "0x6000D69")]
	public void set_scrollDeltaPerTick(float value) { }

	[Address(RVA = "0x29E0C40", Offset = "0x29E0040", Length = "0x35")]
	[Token(Token = "0x6000D89")]
	public void set_scrollWheel(InputActionReference value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000DCC")]
	internal void set_sendPointerHoverToParent(bool value) { }

	[Address(RVA = "0x29E0C80", Offset = "0x29E0080", Length = "0x35")]
	[Token(Token = "0x6000D93")]
	public void set_submit(InputActionReference value) { }

	[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
	[Token(Token = "0x6000D84")]
	public void set_trackedDeviceDragThresholdMultiplier(float value) { }

	[Address(RVA = "0x29E0CC0", Offset = "0x29E00C0", Length = "0x35")]
	[Token(Token = "0x6000D97")]
	public void set_trackedDeviceOrientation(InputActionReference value) { }

	[Address(RVA = "0x29E0D00", Offset = "0x29E0100", Length = "0x35")]
	[Token(Token = "0x6000D99")]
	public void set_trackedDevicePosition(InputActionReference value) { }

	[Address(RVA = "0x29E0D40", Offset = "0x29E0140", Length = "0x3E")]
	[Token(Token = "0x6000D9E")]
	public void set_trackedDeviceSelect(InputActionReference value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x6000D82")]
	public void set_xrTrackingOrigin(Transform value) { }

	[Address(RVA = "0x29DF1E0", Offset = "0x29DE5E0", Length = "0xD4")]
	[Token(Token = "0x6000DC7")]
	private static void SetActionCallback(InputActionReference actionReference, Action<CallbackContext> callback, bool install) { }

	[Address(RVA = "0x29DF2C0", Offset = "0x29DE6C0", Length = "0x6FE")]
	[Token(Token = "0x6000DC6")]
	private void SetActionCallbacks(bool install) { }

	[Address(RVA = "0x29DF9C0", Offset = "0x29DEDC0", Length = "0x2CE")]
	[Token(Token = "0x6000D85")]
	private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<CallbackContext> actionCallback) { }

	[Address(RVA = "0x29DFC90", Offset = "0x29DF090", Length = "0x1AA")]
	[Token(Token = "0x6000DA8")]
	private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = false) { }

	[Address(RVA = "0x29DFE40", Offset = "0x29DF240", Length = "0x25E")]
	[Token(Token = "0x6000D9C")]
	public void UnassignActions() { }

	[Address(RVA = "0x29E00A0", Offset = "0x29DF4A0", Length = "0x14")]
	[Token(Token = "0x6000DC5")]
	private void UnhookActions() { }

	[Address(RVA = "0x29E00C0", Offset = "0x29DF4C0", Length = "0x90")]
	[Token(Token = "0x6000DC8")]
	private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) { }

}

