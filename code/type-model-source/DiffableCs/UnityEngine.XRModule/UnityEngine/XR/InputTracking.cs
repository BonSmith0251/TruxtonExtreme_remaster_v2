namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000002")]
public static class InputTracking
{
	[Token(Token = "0x2000003")]
	private enum TrackingStateEventType : int
	{
		NodeAdded = 0,
		NodeRemoved = 1,
		TrackingAcquired = 2,
		TrackingLost = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static Action<XRNodeState> trackingAcquired; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000002")]
	private static Action<XRNodeState> trackingLost; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000003")]
	private static Action<XRNodeState> nodeAdded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000004")]
	private static Action<XRNodeState> nodeRemoved; //Field offset: 0x18

	[Address(RVA = "0x3491D40", Offset = "0x3491140", Length = "0x1B4")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000001")]
	private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

}

