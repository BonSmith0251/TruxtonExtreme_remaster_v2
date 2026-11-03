namespace UnityEngine.InputSystem;

[Token(Token = "0x20000D1")]
public class DefaultInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x20000D4")]
	internal interface IPlayerActions
	{

		[Token(Token = "0x6000B6F")]
		public void OnFire(CallbackContext context) { }

		[Token(Token = "0x6000B6E")]
		public void OnLook(CallbackContext context) { }

		[Token(Token = "0x6000B6D")]
		public void OnMove(CallbackContext context) { }

	}

	[Token(Token = "0x20000D5")]
	internal interface IUIActions
	{

		[Token(Token = "0x6000B72")]
		public void OnCancel(CallbackContext context) { }

		[Token(Token = "0x6000B74")]
		public void OnClick(CallbackContext context) { }

		[Token(Token = "0x6000B76")]
		public void OnMiddleClick(CallbackContext context) { }

		[Token(Token = "0x6000B70")]
		public void OnNavigate(CallbackContext context) { }

		[Token(Token = "0x6000B73")]
		public void OnPoint(CallbackContext context) { }

		[Token(Token = "0x6000B77")]
		public void OnRightClick(CallbackContext context) { }

		[Token(Token = "0x6000B75")]
		public void OnScrollWheel(CallbackContext context) { }

		[Token(Token = "0x6000B71")]
		public void OnSubmit(CallbackContext context) { }

		[Token(Token = "0x6000B79")]
		public void OnTrackedDeviceOrientation(CallbackContext context) { }

		[Token(Token = "0x6000B78")]
		public void OnTrackedDevicePosition(CallbackContext context) { }

	}

	[Token(Token = "0x20000D2")]
	internal struct PlayerActions
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000510")]
		private DefaultInputActions m_Wrapper; //Field offset: 0x0

		[Token(Token = "0x170002E9")]
		public bool enabled
		{
			[Address(RVA = "0x29C0A70", Offset = "0x29BFE70", Length = "0x25")]
			[Token(Token = "0x6000B59")]
			 get { } //Length: 37
		}

		[Token(Token = "0x170002E8")]
		public InputAction Fire
		{
			[Address(RVA = "0x24DA9C0", Offset = "0x24D9DC0", Length = "0x1A")]
			[Token(Token = "0x6000B55")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002E7")]
		public InputAction Look
		{
			[Address(RVA = "0x29C0A30", Offset = "0x29BFE30", Length = "0x1A")]
			[Token(Token = "0x6000B54")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002E6")]
		public InputAction Move
		{
			[Address(RVA = "0x29C0A50", Offset = "0x29BFE50", Length = "0x1A")]
			[Token(Token = "0x6000B53")]
			 get { } //Length: 26
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000B52")]
		public PlayerActions(DefaultInputActions wrapper) { }

		[Address(RVA = "0x29BFBF0", Offset = "0x29BEFF0", Length = "0x25")]
		[Token(Token = "0x6000B58")]
		public void Disable() { }

		[Address(RVA = "0x29BFC20", Offset = "0x29BF020", Length = "0x25")]
		[Token(Token = "0x6000B57")]
		public void Enable() { }

		[Address(RVA = "0x24DAB20", Offset = "0x24D9F20", Length = "0x1A")]
		[Token(Token = "0x6000B56")]
		public InputActionMap Get() { }

		[Address(RVA = "0x29C0A70", Offset = "0x29BFE70", Length = "0x25")]
		[Token(Token = "0x6000B59")]
		public bool get_enabled() { }

		[Address(RVA = "0x24DA9C0", Offset = "0x24D9DC0", Length = "0x1A")]
		[Token(Token = "0x6000B55")]
		public InputAction get_Fire() { }

		[Address(RVA = "0x29C0A30", Offset = "0x29BFE30", Length = "0x1A")]
		[Token(Token = "0x6000B54")]
		public InputAction get_Look() { }

		[Address(RVA = "0x29C0A50", Offset = "0x29BFE50", Length = "0x1A")]
		[Token(Token = "0x6000B53")]
		public InputAction get_Move() { }

		[Address(RVA = "0xF48BF0", Offset = "0xF47FF0", Length = "0x17")]
		[Token(Token = "0x6000B5A")]
		public static InputActionMap op_Implicit(PlayerActions set) { }

		[Address(RVA = "0x29BFC50", Offset = "0x29BF050", Length = "0xDD1")]
		[Token(Token = "0x6000B5B")]
		public void SetCallbacks(IPlayerActions instance) { }

	}

	[Token(Token = "0x20000D3")]
	internal struct UIActions
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000511")]
		private DefaultInputActions m_Wrapper; //Field offset: 0x0

		[Token(Token = "0x170002EC")]
		public InputAction Cancel
		{
			[Address(RVA = "0x29D13C0", Offset = "0x29D07C0", Length = "0x1A")]
			[Token(Token = "0x6000B5F")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002EE")]
		public InputAction Click
		{
			[Address(RVA = "0x29D13E0", Offset = "0x29D07E0", Length = "0x1A")]
			[Token(Token = "0x6000B61")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002F4")]
		public bool enabled
		{
			[Address(RVA = "0x29D1500", Offset = "0x29D0900", Length = "0x25")]
			[Token(Token = "0x6000B6A")]
			 get { } //Length: 37
		}

		[Token(Token = "0x170002F0")]
		public InputAction MiddleClick
		{
			[Address(RVA = "0x29D1400", Offset = "0x29D0800", Length = "0x1D")]
			[Token(Token = "0x6000B63")]
			 get { } //Length: 29
		}

		[Token(Token = "0x170002EA")]
		public InputAction Navigate
		{
			[Address(RVA = "0x29D1420", Offset = "0x29D0820", Length = "0x1A")]
			[Token(Token = "0x6000B5D")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002ED")]
		public InputAction Point
		{
			[Address(RVA = "0x29D1440", Offset = "0x29D0840", Length = "0x1A")]
			[Token(Token = "0x6000B60")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002F1")]
		public InputAction RightClick
		{
			[Address(RVA = "0x29D1460", Offset = "0x29D0860", Length = "0x1D")]
			[Token(Token = "0x6000B64")]
			 get { } //Length: 29
		}

		[Token(Token = "0x170002EF")]
		public InputAction ScrollWheel
		{
			[Address(RVA = "0x29D1480", Offset = "0x29D0880", Length = "0x1A")]
			[Token(Token = "0x6000B62")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002EB")]
		public InputAction Submit
		{
			[Address(RVA = "0x29D14A0", Offset = "0x29D08A0", Length = "0x1A")]
			[Token(Token = "0x6000B5E")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002F3")]
		public InputAction TrackedDeviceOrientation
		{
			[Address(RVA = "0x29D14C0", Offset = "0x29D08C0", Length = "0x1D")]
			[Token(Token = "0x6000B66")]
			 get { } //Length: 29
		}

		[Token(Token = "0x170002F2")]
		public InputAction TrackedDevicePosition
		{
			[Address(RVA = "0x29D14E0", Offset = "0x29D08E0", Length = "0x1D")]
			[Token(Token = "0x6000B65")]
			 get { } //Length: 29
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000B5C")]
		public UIActions(DefaultInputActions wrapper) { }

		[Address(RVA = "0x29CE4C0", Offset = "0x29CD8C0", Length = "0x25")]
		[Token(Token = "0x6000B69")]
		public void Disable() { }

		[Address(RVA = "0x29CE4F0", Offset = "0x29CD8F0", Length = "0x25")]
		[Token(Token = "0x6000B68")]
		public void Enable() { }

		[Address(RVA = "0x29CE520", Offset = "0x29CD920", Length = "0x1A")]
		[Token(Token = "0x6000B67")]
		public InputActionMap Get() { }

		[Address(RVA = "0x29D13C0", Offset = "0x29D07C0", Length = "0x1A")]
		[Token(Token = "0x6000B5F")]
		public InputAction get_Cancel() { }

		[Address(RVA = "0x29D13E0", Offset = "0x29D07E0", Length = "0x1A")]
		[Token(Token = "0x6000B61")]
		public InputAction get_Click() { }

		[Address(RVA = "0x29D1500", Offset = "0x29D0900", Length = "0x25")]
		[Token(Token = "0x6000B6A")]
		public bool get_enabled() { }

		[Address(RVA = "0x29D1400", Offset = "0x29D0800", Length = "0x1D")]
		[Token(Token = "0x6000B63")]
		public InputAction get_MiddleClick() { }

		[Address(RVA = "0x29D1420", Offset = "0x29D0820", Length = "0x1A")]
		[Token(Token = "0x6000B5D")]
		public InputAction get_Navigate() { }

		[Address(RVA = "0x29D1440", Offset = "0x29D0840", Length = "0x1A")]
		[Token(Token = "0x6000B60")]
		public InputAction get_Point() { }

		[Address(RVA = "0x29D1460", Offset = "0x29D0860", Length = "0x1D")]
		[Token(Token = "0x6000B64")]
		public InputAction get_RightClick() { }

		[Address(RVA = "0x29D1480", Offset = "0x29D0880", Length = "0x1A")]
		[Token(Token = "0x6000B62")]
		public InputAction get_ScrollWheel() { }

		[Address(RVA = "0x29D14A0", Offset = "0x29D08A0", Length = "0x1A")]
		[Token(Token = "0x6000B5E")]
		public InputAction get_Submit() { }

		[Address(RVA = "0x29D14C0", Offset = "0x29D08C0", Length = "0x1D")]
		[Token(Token = "0x6000B66")]
		public InputAction get_TrackedDeviceOrientation() { }

		[Address(RVA = "0x29D14E0", Offset = "0x29D08E0", Length = "0x1D")]
		[Token(Token = "0x6000B65")]
		public InputAction get_TrackedDevicePosition() { }

		[Address(RVA = "0x29D1530", Offset = "0x29D0930", Length = "0x17")]
		[Token(Token = "0x6000B6B")]
		public static InputActionMap op_Implicit(UIActions set) { }

		[Address(RVA = "0x29CE540", Offset = "0x29CD940", Length = "0x2E75")]
		[Token(Token = "0x6000B6C")]
		public void SetCallbacks(IUIActions instance) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004F9")]
	private readonly InputActionAsset <asset>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004FA")]
	private readonly InputActionMap m_Player; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004FB")]
	private IPlayerActions m_PlayerActionsCallbackInterface; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004FC")]
	private readonly InputAction m_Player_Move; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004FD")]
	private readonly InputAction m_Player_Look; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004FE")]
	private readonly InputAction m_Player_Fire; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004FF")]
	private readonly InputActionMap m_UI; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000500")]
	private IUIActions m_UIActionsCallbackInterface; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000501")]
	private readonly InputAction m_UI_Navigate; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000502")]
	private readonly InputAction m_UI_Submit; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000503")]
	private readonly InputAction m_UI_Cancel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000504")]
	private readonly InputAction m_UI_Point; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000505")]
	private readonly InputAction m_UI_Click; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000506")]
	private readonly InputAction m_UI_ScrollWheel; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000507")]
	private readonly InputAction m_UI_MiddleClick; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000508")]
	private readonly InputAction m_UI_RightClick; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000509")]
	private readonly InputAction m_UI_TrackedDevicePosition; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400050A")]
	private readonly InputAction m_UI_TrackedDeviceOrientation; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400050B")]
	private int m_KeyboardMouseSchemeIndex; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x400050C")]
	private int m_GamepadSchemeIndex; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400050D")]
	private int m_TouchSchemeIndex; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400050E")]
	private int m_JoystickSchemeIndex; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400050F")]
	private int m_XRSchemeIndex; //Field offset: 0xB0

	[Token(Token = "0x170002DA")]
	public InputActionAsset asset
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B3B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002DB")]
	public override Nullable<InputBinding> bindingMask
	{
		[Address(RVA = "0x29B5990", Offset = "0x29B4D90", Length = "0x4C")]
		[Token(Token = "0x6000B3E")]
		 get { } //Length: 76
		[Address(RVA = "0x29B5A80", Offset = "0x29B4E80", Length = "0x5B")]
		[Token(Token = "0x6000B3F")]
		 set { } //Length: 91
	}

	[Token(Token = "0x170002DE")]
	public override IEnumerable<InputBinding> bindings
	{
		[Address(RVA = "0x29B59E0", Offset = "0x29B4DE0", Length = "0x1D")]
		[Token(Token = "0x6000B48")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170002DD")]
	public override ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Address(RVA = "0x29B5A00", Offset = "0x29B4E00", Length = "0x33")]
		[Token(Token = "0x6000B42")]
		 get { } //Length: 51
	}

	[Token(Token = "0x170002DC")]
	public override Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		[Address(RVA = "0x29B5A40", Offset = "0x29B4E40", Length = "0x3D")]
		[Token(Token = "0x6000B40")]
		 get { } //Length: 61
		[Address(RVA = "0x29B5AE0", Offset = "0x29B4EE0", Length = "0x37")]
		[Token(Token = "0x6000B41")]
		 set { } //Length: 55
	}

	[Token(Token = "0x170002E2")]
	public InputControlScheme GamepadScheme
	{
		[Address(RVA = "0x29B5580", Offset = "0x29B4980", Length = "0xC8")]
		[Token(Token = "0x6000B4E")]
		 get { } //Length: 200
	}

	[Token(Token = "0x170002E4")]
	public InputControlScheme JoystickScheme
	{
		[Address(RVA = "0x29B5650", Offset = "0x29B4A50", Length = "0xC8")]
		[Token(Token = "0x6000B50")]
		 get { } //Length: 200
	}

	[Token(Token = "0x170002E1")]
	public InputControlScheme KeyboardMouseScheme
	{
		[Address(RVA = "0x29B5720", Offset = "0x29B4B20", Length = "0xC8")]
		[Token(Token = "0x6000B4D")]
		 get { } //Length: 200
	}

	[Token(Token = "0x170002DF")]
	public PlayerActions Player
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000B4B")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170002E3")]
	public InputControlScheme TouchScheme
	{
		[Address(RVA = "0x29B57F0", Offset = "0x29B4BF0", Length = "0xC8")]
		[Token(Token = "0x6000B4F")]
		 get { } //Length: 200
	}

	[Token(Token = "0x170002E0")]
	public UIActions UI
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000B4C")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170002E5")]
	public InputControlScheme XRScheme
	{
		[Address(RVA = "0x29B58C0", Offset = "0x29B4CC0", Length = "0xC8")]
		[Token(Token = "0x6000B51")]
		 get { } //Length: 200
	}

	[Address(RVA = "0x29B5170", Offset = "0x29B4570", Length = "0x400")]
	[Token(Token = "0x6000B3C")]
	public DefaultInputActions() { }

	[Address(RVA = "0x29B5020", Offset = "0x29B4420", Length = "0x1E")]
	[Token(Token = "0x6000B43")]
	public override bool Contains(InputAction action) { }

	[Address(RVA = "0x29B5040", Offset = "0x29B4440", Length = "0x1D")]
	[Token(Token = "0x6000B47")]
	public override void Disable() { }

	[Address(RVA = "0x29B5060", Offset = "0x29B4460", Length = "0x4D")]
	[Token(Token = "0x6000B3D")]
	public override void Dispose() { }

	[Address(RVA = "0x29B50B0", Offset = "0x29B44B0", Length = "0x1D")]
	[Token(Token = "0x6000B46")]
	public override void Enable() { }

	[Address(RVA = "0x29B50D0", Offset = "0x29B44D0", Length = "0x1E")]
	[Token(Token = "0x6000B49")]
	public override InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	[Address(RVA = "0x29B50F0", Offset = "0x29B44F0", Length = "0x5D")]
	[Token(Token = "0x6000B4A")]
	public override int FindBinding(InputBinding bindingMask, out InputAction action) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B3B")]
	public InputActionAsset get_asset() { }

	[Address(RVA = "0x29B5990", Offset = "0x29B4D90", Length = "0x4C")]
	[Token(Token = "0x6000B3E")]
	public override Nullable<InputBinding> get_bindingMask() { }

	[Address(RVA = "0x29B59E0", Offset = "0x29B4DE0", Length = "0x1D")]
	[Token(Token = "0x6000B48")]
	public override IEnumerable<InputBinding> get_bindings() { }

	[Address(RVA = "0x29B5A00", Offset = "0x29B4E00", Length = "0x33")]
	[Token(Token = "0x6000B42")]
	public override ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	[Address(RVA = "0x29B5A40", Offset = "0x29B4E40", Length = "0x3D")]
	[Token(Token = "0x6000B40")]
	public override Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	[Address(RVA = "0x29B5580", Offset = "0x29B4980", Length = "0xC8")]
	[Token(Token = "0x6000B4E")]
	public InputControlScheme get_GamepadScheme() { }

	[Address(RVA = "0x29B5650", Offset = "0x29B4A50", Length = "0xC8")]
	[Token(Token = "0x6000B50")]
	public InputControlScheme get_JoystickScheme() { }

	[Address(RVA = "0x29B5720", Offset = "0x29B4B20", Length = "0xC8")]
	[Token(Token = "0x6000B4D")]
	public InputControlScheme get_KeyboardMouseScheme() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000B4B")]
	public PlayerActions get_Player() { }

	[Address(RVA = "0x29B57F0", Offset = "0x29B4BF0", Length = "0xC8")]
	[Token(Token = "0x6000B4F")]
	public InputControlScheme get_TouchScheme() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000B4C")]
	public UIActions get_UI() { }

	[Address(RVA = "0x29B58C0", Offset = "0x29B4CC0", Length = "0xC8")]
	[Token(Token = "0x6000B51")]
	public InputControlScheme get_XRScheme() { }

	[Address(RVA = "0x29B5150", Offset = "0x29B4550", Length = "0x1D")]
	[Token(Token = "0x6000B44")]
	public override IEnumerator<InputAction> GetEnumerator() { }

	[Address(RVA = "0x29B5A80", Offset = "0x29B4E80", Length = "0x5B")]
	[Token(Token = "0x6000B3F")]
	public override void set_bindingMask(Nullable<InputBinding> value) { }

	[Address(RVA = "0x29B5AE0", Offset = "0x29B4EE0", Length = "0x37")]
	[Token(Token = "0x6000B41")]
	public override void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

	[Address(RVA = "0x29B5150", Offset = "0x29B4550", Length = "0x1D")]
	[Token(Token = "0x6000B45")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

