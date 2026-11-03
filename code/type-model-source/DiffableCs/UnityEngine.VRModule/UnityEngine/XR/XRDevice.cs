namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[Obsolete("UnityEngine.VRModule is deprecated and will be removed in a future version. Please use the APIs in the UnityEngine.XRModule instead")]
[Token(Token = "0x2000003")]
public static class XRDevice
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static Action<String> deviceLoaded; //Field offset: 0x0

	[Address(RVA = "0x3491320", Offset = "0x3490720", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000A")]
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

}

