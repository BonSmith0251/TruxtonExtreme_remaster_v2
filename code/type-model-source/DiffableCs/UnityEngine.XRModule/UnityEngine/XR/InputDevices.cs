namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000010")]
[UsedByNativeCode]
public class InputDevices
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000056")]
	private static Action<InputDevice> deviceConnected; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000057")]
	private static Action<InputDevice> deviceDisconnected; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000058")]
	private static Action<InputDevice> deviceConfigChanged; //Field offset: 0x10

	[Address(RVA = "0x3491B00", Offset = "0x3490F00", Length = "0xC1")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001E")]
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }

}

