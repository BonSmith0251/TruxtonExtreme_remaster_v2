namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200039E")]
internal class XTaskQueueTerminateCallbackHandle : XRegistrationToken<XTaskQueueTerminatedCallback>
{

	[Address(RVA = "0x2BA4E80", Offset = "0x2BA4280", Length = "0x116")]
	[Token(Token = "0x6001240")]
	public XTaskQueueTerminateCallbackHandle(XTaskQueueTerminatedCallback callback, IntPtr context) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001241")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA4D70", Offset = "0x2BA4170", Length = "0x10B")]
	[MonoPInvokeCallback(typeof(XTaskQueueTerminatedCallback))]
	[Token(Token = "0x600123F")]
	private static void OnTerminate(IntPtr context) { }

}

