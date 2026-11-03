namespace UnityEngine.InputSystem.UI;

[AddComponentMenu("Input/Virtual Mouse")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/UISupport.html#virtual-mouse-cursor-control")]
[Token(Token = "0x2000127")]
public class VirtualMouseInput : MonoBehaviour
{
	[Token(Token = "0x2000128")]
	internal enum CursorMode : int
	{
		SoftwareCursor = 0,
		HardwareCursorIfAvailable = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[Header("Cursor")]
	[SerializeField]
	[Token(Token = "0x40006DD")]
	[Tooltip("Whether the component should set the cursor position of the hardware mouse cursor, if one is available. If so, the software cursor pointed (to by 'Cursor Graphic') will be hidden.")]
	private CursorMode m_CursorMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40006DE")]
	[Tooltip("The graphic that represents the software cursor. This is hidden if a hardware cursor (see 'Cursor Mode') is used.")]
	private Graphic m_CursorGraphic; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40006DF")]
	[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see 'Cursor Mode'). Moving the cursor updates the anchored position of the transform.")]
	private RectTransform m_CursorTransform; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Header("Motion")]
	[SerializeField]
	[Token(Token = "0x40006E0")]
	[Tooltip("Speed in pixels per second with which to move the cursor. Scaled by the input from 'Stick Action'.")]
	private float m_CursorSpeed; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40006E1")]
	[Tooltip("Scale factor to apply to 'Scroll Wheel Action' when setting the mouse 'scrollWheel' control.")]
	private float m_ScrollSpeed; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Space(10)]
	[Token(Token = "0x40006E2")]
	[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
	private InputActionProperty m_StickAction; //Field offset: 0x40
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40006E3")]
	[Tooltip("Button action that triggers a left-click on the mouse.")]
	private InputActionProperty m_LeftButtonAction; //Field offset: 0x58
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40006E4")]
	[Tooltip("Button action that triggers a middle-click on the mouse.")]
	private InputActionProperty m_MiddleButtonAction; //Field offset: 0x70
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40006E5")]
	[Tooltip("Button action that triggers a right-click on the mouse.")]
	private InputActionProperty m_RightButtonAction; //Field offset: 0x88
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40006E6")]
	[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
	private InputActionProperty m_ForwardButtonAction; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x40006E7")]
	[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
	private InputActionProperty m_BackButtonAction; //Field offset: 0xB8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x40006E8")]
	[Tooltip("Vector2 action that feeds into the mouse 'scrollWheel' action (scaled by 'Scroll Speed').")]
	private InputActionProperty m_ScrollWheelAction; //Field offset: 0xD0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40006E9")]
	private Canvas m_Canvas; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40006EA")]
	private Mouse m_VirtualMouse; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40006EB")]
	private Mouse m_SystemMouse; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40006EC")]
	private Action m_AfterInputUpdateDelegate; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40006ED")]
	private Action<CallbackContext> m_ButtonActionTriggeredDelegate; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40006EE")]
	private double m_LastTime; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40006EF")]
	private Vector2 m_LastStickValue; //Field offset: 0x118

	[Token(Token = "0x170003C9")]
	public InputActionProperty backButtonAction
	{
		[Address(RVA = "0x16CB300", Offset = "0x16CA700", Length = "0x1B")]
		[Token(Token = "0x6000E2B")]
		 get { } //Length: 27
		[Address(RVA = "0x29E9D10", Offset = "0x29E9110", Length = "0x10C")]
		[Token(Token = "0x6000E2C")]
		 set { } //Length: 268
	}

	[Token(Token = "0x170003C1")]
	public Graphic cursorGraphic
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000E1C")]
		 get { } //Length: 5
		[Address(RVA = "0x29E9E20", Offset = "0x29E9220", Length = "0x66")]
		[Token(Token = "0x6000E1D")]
		 set { } //Length: 102
	}

	[Token(Token = "0x170003C0")]
	public CursorMode cursorMode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000E1A")]
		 get { } //Length: 4
		[Address(RVA = "0x29E9E90", Offset = "0x29E9290", Length = "0x102")]
		[Token(Token = "0x6000E1B")]
		 set { } //Length: 258
	}

	[Token(Token = "0x170003BF")]
	public float cursorSpeed
	{
		[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
		[Token(Token = "0x6000E18")]
		 get { } //Length: 6
		[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
		[Token(Token = "0x6000E19")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170003BE")]
	public RectTransform cursorTransform
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000E16")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000E17")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170003C8")]
	public InputActionProperty forwardButtonAction
	{
		[Address(RVA = "0x29E9C70", Offset = "0x29E9070", Length = "0x1B")]
		[Token(Token = "0x6000E29")]
		 get { } //Length: 27
		[Address(RVA = "0x29E9FA0", Offset = "0x29E93A0", Length = "0x10C")]
		[Token(Token = "0x6000E2A")]
		 set { } //Length: 268
	}

	[Token(Token = "0x170003C5")]
	public InputActionProperty leftButtonAction
	{
		[Address(RVA = "0x29E9C90", Offset = "0x29E9090", Length = "0x15")]
		[Token(Token = "0x6000E23")]
		 get { } //Length: 21
		[Address(RVA = "0x29EA0B0", Offset = "0x29E94B0", Length = "0xFD")]
		[Token(Token = "0x6000E24")]
		 set { } //Length: 253
	}

	[Token(Token = "0x170003C7")]
	public InputActionProperty middleButtonAction
	{
		[Address(RVA = "0x29E9CB0", Offset = "0x29E90B0", Length = "0x18")]
		[Token(Token = "0x6000E27")]
		 get { } //Length: 24
		[Address(RVA = "0x29EA1B0", Offset = "0x29E95B0", Length = "0x103")]
		[Token(Token = "0x6000E28")]
		 set { } //Length: 259
	}

	[Token(Token = "0x170003C6")]
	public InputActionProperty rightButtonAction
	{
		[Address(RVA = "0x29E9CD0", Offset = "0x29E90D0", Length = "0x1B")]
		[Token(Token = "0x6000E25")]
		 get { } //Length: 27
		[Address(RVA = "0x29EA2C0", Offset = "0x29E96C0", Length = "0x10C")]
		[Token(Token = "0x6000E26")]
		 set { } //Length: 268
	}

	[Token(Token = "0x170003C2")]
	public float scrollSpeed
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x6000E1E")]
		 get { } //Length: 6
		[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
		[Token(Token = "0x6000E1F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170003CA")]
	public InputActionProperty scrollWheelAction
	{
		[Address(RVA = "0x29E9CF0", Offset = "0x29E90F0", Length = "0x1B")]
		[Token(Token = "0x6000E2D")]
		 get { } //Length: 27
		[Address(RVA = "0x29EA3E0", Offset = "0x29E97E0", Length = "0x30")]
		[Token(Token = "0x6000E2E")]
		 set { } //Length: 48
	}

	[Token(Token = "0x170003C4")]
	public InputActionProperty stickAction
	{
		[Address(RVA = "0x1F8A780", Offset = "0x1F89B80", Length = "0x15")]
		[Token(Token = "0x6000E21")]
		 get { } //Length: 21
		[Address(RVA = "0x29EA410", Offset = "0x29E9810", Length = "0x2D")]
		[Token(Token = "0x6000E22")]
		 set { } //Length: 45
	}

	[Token(Token = "0x170003C3")]
	public Mouse virtualMouse
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[Token(Token = "0x6000E20")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x29E9C50", Offset = "0x29E9050", Length = "0x15")]
	[Token(Token = "0x6000E38")]
	public VirtualMouseInput() { }

	[Address(RVA = "0x16CB300", Offset = "0x16CA700", Length = "0x1B")]
	[Token(Token = "0x6000E2B")]
	public InputActionProperty get_backButtonAction() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000E1C")]
	public Graphic get_cursorGraphic() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000E1A")]
	public CursorMode get_cursorMode() { }

	[Address(RVA = "0x1CF2E20", Offset = "0x1CF2220", Length = "0x6")]
	[Token(Token = "0x6000E18")]
	public float get_cursorSpeed() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000E16")]
	public RectTransform get_cursorTransform() { }

	[Address(RVA = "0x29E9C70", Offset = "0x29E9070", Length = "0x1B")]
	[Token(Token = "0x6000E29")]
	public InputActionProperty get_forwardButtonAction() { }

	[Address(RVA = "0x29E9C90", Offset = "0x29E9090", Length = "0x15")]
	[Token(Token = "0x6000E23")]
	public InputActionProperty get_leftButtonAction() { }

	[Address(RVA = "0x29E9CB0", Offset = "0x29E90B0", Length = "0x18")]
	[Token(Token = "0x6000E27")]
	public InputActionProperty get_middleButtonAction() { }

	[Address(RVA = "0x29E9CD0", Offset = "0x29E90D0", Length = "0x1B")]
	[Token(Token = "0x6000E25")]
	public InputActionProperty get_rightButtonAction() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x6000E1E")]
	public float get_scrollSpeed() { }

	[Address(RVA = "0x29E9CF0", Offset = "0x29E90F0", Length = "0x1B")]
	[Token(Token = "0x6000E2D")]
	public InputActionProperty get_scrollWheelAction() { }

	[Address(RVA = "0x1F8A780", Offset = "0x1F89B80", Length = "0x15")]
	[Token(Token = "0x6000E21")]
	public InputActionProperty get_stickAction() { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[Token(Token = "0x6000E20")]
	public Mouse get_virtualMouse() { }

	[Address(RVA = "0x29E8880", Offset = "0x29E7C80", Length = "0x7")]
	[Token(Token = "0x6000E37")]
	private void OnAfterInputUpdate() { }

	[Address(RVA = "0x29E8890", Offset = "0x29E7C90", Length = "0x1F6")]
	[Token(Token = "0x6000E34")]
	private void OnButtonActionTriggered(CallbackContext context) { }

	[Address(RVA = "0x29E8A90", Offset = "0x29E7E90", Length = "0x38E")]
	[Token(Token = "0x6000E30")]
	protected void OnDisable() { }

	[Address(RVA = "0x29E8E20", Offset = "0x29E8220", Length = "0x589")]
	[Token(Token = "0x6000E2F")]
	protected void OnEnable() { }

	[Address(RVA = "0x29E9D10", Offset = "0x29E9110", Length = "0x10C")]
	[Token(Token = "0x6000E2C")]
	public void set_backButtonAction(InputActionProperty value) { }

	[Address(RVA = "0x29E9E20", Offset = "0x29E9220", Length = "0x66")]
	[Token(Token = "0x6000E1D")]
	public void set_cursorGraphic(Graphic value) { }

	[Address(RVA = "0x29E9E90", Offset = "0x29E9290", Length = "0x102")]
	[Token(Token = "0x6000E1B")]
	public void set_cursorMode(CursorMode value) { }

	[Address(RVA = "0x1E264B0", Offset = "0x1E258B0", Length = "0x6")]
	[Token(Token = "0x6000E19")]
	public void set_cursorSpeed(float value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000E17")]
	public void set_cursorTransform(RectTransform value) { }

	[Address(RVA = "0x29E9FA0", Offset = "0x29E93A0", Length = "0x10C")]
	[Token(Token = "0x6000E2A")]
	public void set_forwardButtonAction(InputActionProperty value) { }

	[Address(RVA = "0x29EA0B0", Offset = "0x29E94B0", Length = "0xFD")]
	[Token(Token = "0x6000E24")]
	public void set_leftButtonAction(InputActionProperty value) { }

	[Address(RVA = "0x29EA1B0", Offset = "0x29E95B0", Length = "0x103")]
	[Token(Token = "0x6000E28")]
	public void set_middleButtonAction(InputActionProperty value) { }

	[Address(RVA = "0x29EA2C0", Offset = "0x29E96C0", Length = "0x10C")]
	[Token(Token = "0x6000E26")]
	public void set_rightButtonAction(InputActionProperty value) { }

	[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
	[Token(Token = "0x6000E1F")]
	public void set_scrollSpeed(float value) { }

	[Address(RVA = "0x29EA3E0", Offset = "0x29E97E0", Length = "0x30")]
	[Token(Token = "0x6000E2E")]
	public void set_scrollWheelAction(InputActionProperty value) { }

	[Address(RVA = "0x29EA410", Offset = "0x29E9810", Length = "0x2D")]
	[Token(Token = "0x6000E22")]
	public void set_stickAction(InputActionProperty value) { }

	[Address(RVA = "0x29E9430", Offset = "0x29E8830", Length = "0x112")]
	[Token(Token = "0x6000E36")]
	private static void SetAction(ref InputActionProperty field, InputActionProperty value) { }

	[Address(RVA = "0x29E93B0", Offset = "0x29E87B0", Length = "0x79")]
	[Token(Token = "0x6000E35")]
	private static void SetActionCallback(InputActionProperty field, Action<CallbackContext> callback, bool install = true) { }

	[Address(RVA = "0x29E9550", Offset = "0x29E8950", Length = "0x244")]
	[Token(Token = "0x6000E32")]
	private void TryEnableHardwareCursor() { }

	[Address(RVA = "0x29E97A0", Offset = "0x29E8BA0", Length = "0x59")]
	[Token(Token = "0x6000E31")]
	private void TryFindCanvas() { }

	[Address(RVA = "0x29E9800", Offset = "0x29E8C00", Length = "0x449")]
	[Token(Token = "0x6000E33")]
	private void UpdateMotion() { }

}

