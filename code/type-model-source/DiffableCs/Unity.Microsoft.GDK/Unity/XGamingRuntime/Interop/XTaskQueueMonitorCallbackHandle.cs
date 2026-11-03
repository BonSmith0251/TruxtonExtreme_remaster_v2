namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200039C")]
internal class XTaskQueueMonitorCallbackHandle : XRegistrationToken<XTaskQueueMonitorCallback>
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A5E")]
	private XTaskQueueHandle queue; //Field offset: 0x38

	[Address(RVA = "0x2BA4B90", Offset = "0x2BA3F90", Length = "0x134")]
	[Token(Token = "0x6001238")]
	public XTaskQueueMonitorCallbackHandle(XTaskQueueHandle queue, XTaskQueueMonitorCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA48D0", Offset = "0x2BA3CD0", Length = "0xB7")]
	[Token(Token = "0x600123B")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA4990", Offset = "0x2BA3D90", Length = "0x13C")]
	[MonoPInvokeCallback(typeof(XTaskQueueMonitorCallback))]
	[Token(Token = "0x6001237")]
	private static void OnMonitor(IntPtr context, IntPtr queue, XTaskQueuePort port) { }

	[Address(RVA = "0x2BA4AD0", Offset = "0x2BA3ED0", Length = "0xB3")]
	[Token(Token = "0x6001239")]
	public void Unregister(XTaskQueueHandle queue) { }

	[Address(RVA = "0x2BA48D0", Offset = "0x2BA3CD0", Length = "0xB7")]
	[Token(Token = "0x600123A")]
	public void Unregister() { }

}

