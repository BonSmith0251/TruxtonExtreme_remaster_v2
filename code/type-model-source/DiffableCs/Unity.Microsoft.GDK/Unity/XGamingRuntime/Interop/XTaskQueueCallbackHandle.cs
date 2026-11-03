namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200039D")]
internal class XTaskQueueCallbackHandle : XRegistrationToken<XTaskQueueCallback>
{

	[Address(RVA = "0x2BA47B0", Offset = "0x2BA3BB0", Length = "0x116")]
	[Token(Token = "0x600123D")]
	public XTaskQueueCallbackHandle(XTaskQueueCallback callback, IntPtr context) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600123E")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA4690", Offset = "0x2BA3A90", Length = "0x11F")]
	[MonoPInvokeCallback(typeof(XTaskQueueCallback))]
	[Token(Token = "0x600123C")]
	private static void OnCallback(IntPtr context, bool canceled) { }

}

