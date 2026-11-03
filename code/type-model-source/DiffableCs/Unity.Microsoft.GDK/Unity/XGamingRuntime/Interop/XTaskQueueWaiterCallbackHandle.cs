namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200039B")]
internal class XTaskQueueWaiterCallbackHandle : XRegistrationToken<XTaskQueueCallback>
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A5D")]
	private XTaskQueueHandle queue; //Field offset: 0x38

	[Address(RVA = "0x2BA5240", Offset = "0x2BA4640", Length = "0x134")]
	[Token(Token = "0x6001233")]
	public XTaskQueueWaiterCallbackHandle(XTaskQueueHandle queue, XTaskQueueCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA4FA0", Offset = "0x2BA43A0", Length = "0xB7")]
	[Token(Token = "0x6001236")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA5060", Offset = "0x2BA4460", Length = "0x11F")]
	[MonoPInvokeCallback(typeof(XTaskQueueCallback))]
	[Token(Token = "0x6001232")]
	private static void OnWaiter(IntPtr context, bool canceled) { }

	[Address(RVA = "0x2BA5180", Offset = "0x2BA4580", Length = "0xB3")]
	[Token(Token = "0x6001234")]
	public void Unregister(XTaskQueueHandle queue) { }

	[Address(RVA = "0x2BA4FA0", Offset = "0x2BA43A0", Length = "0xB7")]
	[Token(Token = "0x6001235")]
	public void Unregister() { }

}

