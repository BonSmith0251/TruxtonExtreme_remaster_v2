namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Standalone Input Module")]
[Token(Token = "0x20000C3")]
public class StandaloneInputModule : PointerInputModule
{
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	[Token(Token = "0x20000C4")]
	internal enum InputMode : int
	{
		Mouse = 0,
		Buttons = 1,
	}

	[Token(Token = "0x4000355")]
	private const float doubleClickTime = 0.3; //Field offset: 0x0
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400034E")]
	private float m_PrevActionTime; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400034F")]
	private Vector2 m_LastMoveVector; //Field offset: 0x6C
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000350")]
	private int m_ConsecutiveMoveCount; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000351")]
	private Vector2 m_LastMousePosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000352")]
	private Vector2 m_MousePosition; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000353")]
	private GameObject m_CurrentFocusedGameObject; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000354")]
	private readonly Dictionary<Int32, PointerEventData> m_InputPointerEvents; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000356")]
	private string m_HorizontalAxis; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000357")]
	private string m_VerticalAxis; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000358")]
	private string m_SubmitButton; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000359")]
	private string m_CancelButton; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x400035A")]
	private float m_InputActionsPerSecond; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	[Token(Token = "0x400035B")]
	private float m_RepeatDelay; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400035C")]
	private bool m_ForceModuleActive; //Field offset: 0xC0

	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	[Token(Token = "0x170001F4")]
	public bool allowActivationOnMobileDevice
	{
		[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
		[Token(Token = "0x600074A")]
		 get { } //Length: 8
		[Address(RVA = "0x25F8620", Offset = "0x25F7A20", Length = "0x7")]
		[Token(Token = "0x600074B")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001FB")]
	public string cancelButton
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x6000758")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[Token(Token = "0x6000759")]
		 set { } //Length: 19
	}

	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	[Token(Token = "0x170001F5")]
	public bool forceModuleActive
	{
		[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
		[Token(Token = "0x600074C")]
		 get { } //Length: 8
		[Address(RVA = "0x25F8620", Offset = "0x25F7A20", Length = "0x7")]
		[Token(Token = "0x600074D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001F8")]
	public string horizontalAxis
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6000752")]
		 get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x6000753")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001F6")]
	public float inputActionsPerSecond
	{
		[Address(RVA = "0x3473AC0", Offset = "0x3472EC0", Length = "0x9")]
		[Token(Token = "0x600074E")]
		 get { } //Length: 9
		[Address(RVA = "0x3473AD0", Offset = "0x3472ED0", Length = "0x9")]
		[Token(Token = "0x600074F")]
		 set { } //Length: 9
	}

	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	[Token(Token = "0x170001F3")]
	public InputMode inputMode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000749")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001F7")]
	public float repeatDelay
	{
		[Address(RVA = "0x2D68380", Offset = "0x2D67780", Length = "0x9")]
		[Token(Token = "0x6000750")]
		 get { } //Length: 9
		[Address(RVA = "0x3473AE0", Offset = "0x3472EE0", Length = "0x9")]
		[Token(Token = "0x6000751")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001FA")]
	public string submitButton
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x6000756")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[Token(Token = "0x6000757")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001F9")]
	public string verticalAxis
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6000754")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x6000755")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x3473970", Offset = "0x3472D70", Length = "0x145")]
	[Token(Token = "0x6000748")]
	protected StandaloneInputModule() { }

	[Address(RVA = "0x34708F0", Offset = "0x346FCF0", Length = "0x15B")]
	[Token(Token = "0x600075F")]
	public virtual void ActivateModule() { }

	[Address(RVA = "0x3470A50", Offset = "0x346FE50", Length = "0x7")]
	[Token(Token = "0x6000760")]
	public virtual void DeactivateModule() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	[Token(Token = "0x6000768")]
	protected override bool ForceAutoSelect() { }

	[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
	[Token(Token = "0x600074A")]
	public bool get_allowActivationOnMobileDevice() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x6000758")]
	public string get_cancelButton() { }

	[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
	[Token(Token = "0x600074C")]
	public bool get_forceModuleActive() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6000752")]
	public string get_horizontalAxis() { }

	[Address(RVA = "0x3473AC0", Offset = "0x3472EC0", Length = "0x9")]
	[Token(Token = "0x600074E")]
	public float get_inputActionsPerSecond() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000749")]
	public InputMode get_inputMode() { }

	[Address(RVA = "0x2D68380", Offset = "0x2D67780", Length = "0x9")]
	[Token(Token = "0x6000750")]
	public float get_repeatDelay() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x6000756")]
	public string get_submitButton() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6000754")]
	public string get_verticalAxis() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x600076C")]
	protected GameObject GetCurrentFocusedGameObject() { }

	[Address(RVA = "0x3470A60", Offset = "0x346FE60", Length = "0x166")]
	[Token(Token = "0x6000765")]
	private Vector2 GetRawMoveVector() { }

	[Address(RVA = "0x34722A0", Offset = "0x34716A0", Length = "0x1D9")]
	[Token(Token = "0x6000761")]
	public virtual void Process() { }

	[Address(RVA = "0x3470BD0", Offset = "0x346FFD0", Length = "0x2C5")]
	[Token(Token = "0x6000769")]
	protected void ProcessMouseEvent(int id) { }

	[Address(RVA = "0x3470EA0", Offset = "0x34702A0", Length = "0xA")]
	[Token(Token = "0x6000767")]
	protected void ProcessMouseEvent() { }

	[Address(RVA = "0x3470EB0", Offset = "0x34702B0", Length = "0x476")]
	[Token(Token = "0x600076B")]
	protected void ProcessMousePress(MouseButtonEventData data) { }

	[Address(RVA = "0x3471330", Offset = "0x3470730", Length = "0x805")]
	[Token(Token = "0x6000762")]
	private bool ProcessTouchEvents() { }

	[Address(RVA = "0x3471B40", Offset = "0x3470F40", Length = "0x751")]
	[Token(Token = "0x6000763")]
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	[Address(RVA = "0x3472480", Offset = "0x3471880", Length = "0x3D0")]
	[Token(Token = "0x600075D")]
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	[Address(RVA = "0x3472860", Offset = "0x3471C60", Length = "0x720")]
	[Token(Token = "0x600075C")]
	private void ReleasePointerDrags() { }

	[Address(RVA = "0x3472F90", Offset = "0x3472390", Length = "0x367")]
	[Token(Token = "0x6000766")]
	protected bool SendMoveEventToSelectedObject() { }

	[Address(RVA = "0x3473300", Offset = "0x3472700", Length = "0x24E")]
	[Token(Token = "0x6000764")]
	protected bool SendSubmitEventToSelectedObject() { }

	[Address(RVA = "0x3473550", Offset = "0x3472950", Length = "0x149")]
	[Token(Token = "0x600076A")]
	protected bool SendUpdateEventToSelectedObject() { }

	[Address(RVA = "0x25F8620", Offset = "0x25F7A20", Length = "0x7")]
	[Token(Token = "0x600074B")]
	public void set_allowActivationOnMobileDevice(bool value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[Token(Token = "0x6000759")]
	public void set_cancelButton(string value) { }

	[Address(RVA = "0x25F8620", Offset = "0x25F7A20", Length = "0x7")]
	[Token(Token = "0x600074D")]
	public void set_forceModuleActive(bool value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x6000753")]
	public void set_horizontalAxis(string value) { }

	[Address(RVA = "0x3473AD0", Offset = "0x3472ED0", Length = "0x9")]
	[Token(Token = "0x600074F")]
	public void set_inputActionsPerSecond(float value) { }

	[Address(RVA = "0x3473AE0", Offset = "0x3472EE0", Length = "0x9")]
	[Token(Token = "0x6000751")]
	public void set_repeatDelay(float value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[Token(Token = "0x6000757")]
	public void set_submitButton(string value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x6000755")]
	public void set_verticalAxis(string value) { }

	[Address(RVA = "0x34736A0", Offset = "0x3472AA0", Length = "0x233")]
	[Token(Token = "0x600075E")]
	public virtual bool ShouldActivateModule() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600075A")]
	private bool ShouldIgnoreEventsOnNoFocus() { }

	[Address(RVA = "0x34738E0", Offset = "0x3472CE0", Length = "0x8A")]
	[Token(Token = "0x600075B")]
	public virtual void UpdateModule() { }

}

