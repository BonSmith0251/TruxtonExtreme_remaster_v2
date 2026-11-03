namespace UnityEngine.InputSystem.OnScreen;

[AddComponentMenu("Input/On-Screen Stick")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/OnScreen.html#on-screen-sticks")]
[Token(Token = "0x200013A")]
public class OnScreenStick : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[Token(Token = "0x200013B")]
	internal enum Behaviour : int
	{
		RelativePositionWithStaticOrigin = 0,
		ExactPositionWithStaticOrigin = 1,
		ExactPositionWithDynamicOrigin = 2,
	}

	[Token(Token = "0x4000752")]
	private const string kDynamicOriginClickable = "DynamicOriginClickable"; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("movementRange")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000753")]
	private float m_MovementRange; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000754")]
	[Tooltip("Defines the circular region where the onscreen control may have it's origin placed.")]
	private float m_DynamicOriginRange; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[InputControl(layout = "Vector2")]
	[SerializeField]
	[Token(Token = "0x4000755")]
	private string m_ControlPath; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000756")]
	[Tooltip("Choose how the onscreen stick will move relative to it's origin and the press position.\n\nRelativePositionWithStaticOrigin: The control's center of origin is fixed. The control will begin un-actuated at it's centered position and then move relative to the pointer or finger motion.\n\nExactPositionWithStaticOrigin: The control's center of origin is fixed. The stick will immediately jump to the exact position of the click or touch and begin tracking motion from there.\n\nExactPositionWithDynamicOrigin: The control's center of origin is determined by the initial press position. The stick will begin un-actuated at this center position and then track the current pointer or finger position.")]
	private Behaviour m_Behaviour; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000757")]
	[Tooltip("Set this to true to prevent cancellation of pointer events due to device switching. Cancellation will appear as the stick jumping back and forth between the pointer position and the stick center.")]
	private bool m_UseIsolatedInputActions; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000758")]
	[Tooltip("The action that will be used to detect pointer down events on the stick control. Note that if no bindings are set, default ones will be provided.")]
	private InputAction m_PointerDownAction; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000759")]
	[Tooltip("The action that will be used to detect pointer movement on the stick control. Note that if no bindings are set, default ones will be provided.")]
	private InputAction m_PointerMoveAction; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400075A")]
	private Vector3 m_StartPos; //Field offset: 0x60
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400075B")]
	private Vector2 m_PointerDownPos; //Field offset: 0x6C
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400075C")]
	private List<RaycastResult> m_RaycastResults; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400075D")]
	private PointerEventData m_PointerEventData; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400075E")]
	private TouchControl m_TouchControl; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400075F")]
	private bool m_IsIsolationActive; //Field offset: 0x90

	[Token(Token = "0x170003DC")]
	public Behaviour behaviour
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x6000E85")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x6000E86")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003DB")]
	protected virtual string controlPathInternal
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000E83")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6000E84")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170003D9")]
	public float dynamicOriginRange
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x6000E7F")]
		 get { } //Length: 6
		[Address(RVA = "0x29E4790", Offset = "0x29E3B90", Length = "0x10E")]
		[Token(Token = "0x6000E80")]
		 set { } //Length: 270
	}

	[Token(Token = "0x170003D8")]
	public float movementRange
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x6000E7D")]
		 get { } //Length: 6
		[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
		[Token(Token = "0x6000E7E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170003DA")]
	public bool useIsolatedInputActions
	{
		[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
		[Token(Token = "0x6000E81")]
		 get { } //Length: 5
		[Address(RVA = "0x29E48A0", Offset = "0x29E3CA0", Length = "0x4")]
		[Token(Token = "0x6000E82")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x29E4770", Offset = "0x29E3B70", Length = "0x15")]
	[Token(Token = "0x6000E87")]
	public OnScreenStick() { }

	[Address(RVA = "0x29E2800", Offset = "0x29E1C00", Length = "0x263")]
	[Token(Token = "0x6000E72")]
	private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera) { }

	[Address(RVA = "0x29E2A70", Offset = "0x29E1E70", Length = "0x189")]
	[Token(Token = "0x6000E7B")]
	private void DrawGizmoCircle(Vector2 center, float radius) { }

	[Address(RVA = "0x29E2C00", Offset = "0x29E2000", Length = "0xE9")]
	[Token(Token = "0x6000E74")]
	private void EndInteraction() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x6000E85")]
	public Behaviour get_behaviour() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000E83")]
	protected virtual string get_controlPathInternal() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x6000E7F")]
	public float get_dynamicOriginRange() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x6000E7D")]
	public float get_movementRange() { }

	[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
	[Token(Token = "0x6000E81")]
	public bool get_useIsolatedInputActions() { }

	[Address(RVA = "0x29E2CF0", Offset = "0x29E20F0", Length = "0x12B")]
	[Token(Token = "0x6000E79")]
	private Camera GetCameraFromCanvas() { }

	[Address(RVA = "0x29E2E20", Offset = "0x29E2220", Length = "0x36D")]
	[Token(Token = "0x6000E73")]
	private void MoveStick(Vector2 pointerPosition, Camera uiCamera) { }

	[Address(RVA = "0x29E3190", Offset = "0x29E2590", Length = "0x91")]
	[Token(Token = "0x6000E71")]
	private void OnDestroy() { }

	[Address(RVA = "0x29E3230", Offset = "0x29E2630", Length = "0xA9")]
	[Token(Token = "0x6000E6E")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x29E32E0", Offset = "0x29E26E0", Length = "0x2E8")]
	[Token(Token = "0x6000E7A")]
	private void OnDrawGizmosSelected() { }

	[Address(RVA = "0x29E35D0", Offset = "0x29E29D0", Length = "0x14A")]
	[Token(Token = "0x6000E76")]
	private void OnPointerChanged(CallbackContext ctx) { }

	[Address(RVA = "0x29E3720", Offset = "0x29E2B20", Length = "0x519")]
	[Token(Token = "0x6000E75")]
	private void OnPointerDown(CallbackContext ctx) { }

	[Address(RVA = "0x29E3C40", Offset = "0x29E3040", Length = "0xA9")]
	[Token(Token = "0x6000E6D")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x29E3CF0", Offset = "0x29E30F0", Length = "0x11A")]
	[Token(Token = "0x6000E77")]
	private void OnPointerMove(CallbackContext ctx) { }

	[Address(RVA = "0x29E3E10", Offset = "0x29E3210", Length = "0x106")]
	[Token(Token = "0x6000E78")]
	private void OnPointerUp(CallbackContext ctx) { }

	[Address(RVA = "0x29E3F20", Offset = "0x29E3320", Length = "0xE")]
	[Token(Token = "0x6000E6F")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x6000E86")]
	public void set_behaviour(Behaviour value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000E84")]
	protected virtual void set_controlPathInternal(string value) { }

	[Address(RVA = "0x29E4790", Offset = "0x29E3B90", Length = "0x10E")]
	[Token(Token = "0x6000E80")]
	public void set_dynamicOriginRange(float value) { }

	[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
	[Token(Token = "0x6000E7E")]
	public void set_movementRange(float value) { }

	[Address(RVA = "0x29E48A0", Offset = "0x29E3CA0", Length = "0x4")]
	[Token(Token = "0x6000E82")]
	public void set_useIsolatedInputActions(bool value) { }

	[Address(RVA = "0x29E3F30", Offset = "0x29E3330", Length = "0x733")]
	[Token(Token = "0x6000E70")]
	private void Start() { }

	[Address(RVA = "0x29E4670", Offset = "0x29E3A70", Length = "0xF9")]
	[Token(Token = "0x6000E7C")]
	private void UpdateDynamicOriginClickableArea() { }

}

