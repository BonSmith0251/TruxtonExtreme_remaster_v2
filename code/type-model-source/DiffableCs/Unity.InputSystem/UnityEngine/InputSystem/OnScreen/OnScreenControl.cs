namespace UnityEngine.InputSystem.OnScreen;

[Token(Token = "0x2000137")]
public abstract class OnScreenControl : MonoBehaviour
{
	[Token(Token = "0x2000138")]
	private struct OnScreenDeviceInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074E")]
		public InputEventPtr eventPtr; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400074F")]
		public NativeArray<Byte> buffer; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000750")]
		public InputDevice device; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000751")]
		public OnScreenControl firstControl; //Field offset: 0x20

		[Address(RVA = "0x29E2560", Offset = "0x29E1960", Length = "0x6E")]
		[Token(Token = "0x6000E69")]
		public OnScreenDeviceInfo AddControl(OnScreenControl control) { }

		[Address(RVA = "0x29E25D0", Offset = "0x29E19D0", Length = "0xA8")]
		[Token(Token = "0x6000E6B")]
		public void Destroy() { }

		[Address(RVA = "0x29E2680", Offset = "0x29E1A80", Length = "0x179")]
		[Token(Token = "0x6000E6A")]
		public OnScreenDeviceInfo RemoveControl(OnScreenControl control) { }

	}

	[Token(Token = "0x400074C")]
	private static int s_nbActiveInstances; //Field offset: 0x0
	[Token(Token = "0x400074D")]
	private static InlinedArray<OnScreenDeviceInfo> s_OnScreenDevices; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000749")]
	private InputControl m_Control; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400074A")]
	private OnScreenControl m_NextControlOnDevice; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400074B")]
	private InputEventPtr m_InputEventPtr; //Field offset: 0x30

	[Token(Token = "0x170003D5")]
	public InputControl control
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000E5E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003D4")]
	public string controlPath
	{
		[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
		[Token(Token = "0x6000E5C")]
		 get { } //Length: 20
		[Address(RVA = "0x29E2520", Offset = "0x29E1920", Length = "0x3F")]
		[Token(Token = "0x6000E5D")]
		 set { } //Length: 63
	}

	[Token(Token = "0x170003D6")]
	protected abstract string controlPathInternal
	{
		[Token(Token = "0x6000E5F")]
		 get { } //Length: 0
		[Token(Token = "0x6000E60")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170003D7")]
	internal static bool HasAnyActive
	{
		[Address(RVA = "0x29E24E0", Offset = "0x29E18E0", Length = "0x39")]
		[Token(Token = "0x6000E64")]
		internal get { } //Length: 57
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000E68")]
	protected OnScreenControl() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000E5E")]
	public InputControl get_control() { }

	[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
	[Token(Token = "0x6000E5C")]
	public string get_controlPath() { }

	[Token(Token = "0x6000E5F")]
	protected abstract string get_controlPathInternal() { }

	[Address(RVA = "0x29E24E0", Offset = "0x29E18E0", Length = "0x39")]
	[Token(Token = "0x6000E64")]
	internal static bool get_HasAnyActive() { }

	[Address(RVA = "0x29E1540", Offset = "0x29E0940", Length = "0x46")]
	[Token(Token = "0x6000E67")]
	internal string GetWarningMessage() { }

	[Address(RVA = "0x29E1590", Offset = "0x29E0990", Length = "0x2A1")]
	[Token(Token = "0x6000E66")]
	protected override void OnDisable() { }

	[Address(RVA = "0x29E1840", Offset = "0x29E0C40", Length = "0x2EA")]
	[Token(Token = "0x6000E65")]
	protected override void OnEnable() { }

	[Address(RVA = "0x89DAF0", Offset = "0x89CEF0", Length = "0x2DB")]
	[Token(Token = "0x6000E62")]
	protected void SendValueToControl(TValue value) { }

	[Address(RVA = "0x29E1B30", Offset = "0x29E0F30", Length = "0xBD")]
	[Token(Token = "0x6000E63")]
	protected void SentDefaultValueToControl() { }

	[Address(RVA = "0x29E2520", Offset = "0x29E1920", Length = "0x3F")]
	[Token(Token = "0x6000E5D")]
	public void set_controlPath(string value) { }

	[Token(Token = "0x6000E60")]
	protected abstract void set_controlPathInternal(string value) { }

	[Address(RVA = "0x29E1BF0", Offset = "0x29E0FF0", Length = "0x8E9")]
	[Token(Token = "0x6000E61")]
	private void SetupInputControl() { }

}

