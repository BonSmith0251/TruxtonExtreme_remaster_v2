namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[Token(Token = "0x2000019")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000080")]
	private Action<XRInputSubsystem> trackingOriginUpdated; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000081")]
	private Action<XRInputSubsystem> boundaryChanged; //Field offset: 0x28

	[Address(RVA = "0x3493E30", Offset = "0x3493230", Length = "0x39")]
	[Token(Token = "0x6000056")]
	public XRInputSubsystem() { }

	[Address(RVA = "0x3493CD0", Offset = "0x34930D0", Length = "0xA9")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000055")]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	[Address(RVA = "0x3493D80", Offset = "0x3493180", Length = "0xA9")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000054")]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

}

