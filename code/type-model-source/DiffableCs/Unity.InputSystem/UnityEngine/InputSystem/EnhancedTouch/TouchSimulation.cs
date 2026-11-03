namespace UnityEngine.InputSystem.EnhancedTouch;

[AddComponentMenu("Input/Debug/Touch Simulation")]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/Touch.html#touch-simulation")]
[Token(Token = "0x200015B")]
public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor
{
	[Token(Token = "0x40008B3")]
	internal static TouchSimulation s_Instance; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008A9")]
	private Touchscreen <simulatedTouchscreen>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008AA")]
	private int m_NumPointers; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008AB")]
	private Pointer[] m_Pointers; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008AC")]
	private Vector2[] m_CurrentPositions; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008AD")]
	private Int32[] m_CurrentDisplayIndices; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008AE")]
	private ButtonControl[] m_Touches; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008AF")]
	private Int32[] m_TouchIds; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008B0")]
	private int m_LastTouchId; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008B1")]
	private Action<InputDevice, InputDeviceChange> m_OnDeviceChange; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008B2")]
	private Action<InputEventPtr, InputDevice> m_OnEvent; //Field offset: 0x68

	[Token(Token = "0x17000416")]
	public static TouchSimulation instance
	{
		[Address(RVA = "0x29FE560", Offset = "0x29FD960", Length = "0x36")]
		[Token(Token = "0x6000F24")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000415")]
	public private Touchscreen simulatedTouchscreen
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000F22")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000F23")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000F34")]
	public TouchSimulation() { }

	[Address(RVA = "0x29FCE60", Offset = "0x29FC260", Length = "0x141")]
	[Token(Token = "0x6000F28")]
	protected void AddPointer(Pointer pointer) { }

	[Address(RVA = "0x29FCFB0", Offset = "0x29FC3B0", Length = "0xE5")]
	[Token(Token = "0x6000F27")]
	public static void Destroy() { }

	[Address(RVA = "0x29FD0A0", Offset = "0x29FC4A0", Length = "0xC1")]
	[Token(Token = "0x6000F26")]
	public static void Disable() { }

	[Address(RVA = "0x29FD170", Offset = "0x29FC570", Length = "0x1A3")]
	[Token(Token = "0x6000F25")]
	public static void Enable() { }

	[Address(RVA = "0x29FE560", Offset = "0x29FD960", Length = "0x36")]
	[Token(Token = "0x6000F24")]
	public static TouchSimulation get_instance() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000F22")]
	public Touchscreen get_simulatedTouchscreen() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F31")]
	protected void InstallStateChangeMonitors(int startIndex = 0) { }

	[Address(RVA = "0x29FD320", Offset = "0x29FC720", Length = "0x20C")]
	[Token(Token = "0x6000F2B")]
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[Address(RVA = "0x29FD530", Offset = "0x29FC930", Length = "0x167")]
	[Token(Token = "0x6000F2D")]
	protected void OnDisable() { }

	[Address(RVA = "0x29FD6A0", Offset = "0x29FCAA0", Length = "0x413")]
	[Token(Token = "0x6000F2C")]
	protected void OnEnable() { }

	[Address(RVA = "0x29FDAC0", Offset = "0x29FCEC0", Length = "0x614")]
	[Token(Token = "0x6000F2A")]
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F32")]
	protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex) { }

	[Address(RVA = "0x29FE0E0", Offset = "0x29FD4E0", Length = "0x1E8")]
	[Token(Token = "0x6000F29")]
	protected void RemovePointer(Pointer pointer) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000F23")]
	private void set_simulatedTouchscreen(Touchscreen value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F33")]
	protected void UninstallStateChangeMonitors(int startIndex = 0) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F2F")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F30")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) { }

	[Address(RVA = "0x29FE2D0", Offset = "0x29FD6D0", Length = "0x28B")]
	[Token(Token = "0x6000F2E")]
	private void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, InputEventPtr eventPtr = null) { }

}

