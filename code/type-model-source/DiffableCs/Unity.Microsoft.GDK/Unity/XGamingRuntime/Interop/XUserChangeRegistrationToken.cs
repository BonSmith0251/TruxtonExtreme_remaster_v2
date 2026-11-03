namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003AC")]
internal class XUserChangeRegistrationToken : XRegistrationToken<XUserChangeEventCallback>
{

	[Address(RVA = "0x2BA56D0", Offset = "0x2BA4AD0", Length = "0x116")]
	[Token(Token = "0x600125D")]
	public XUserChangeRegistrationToken(XUserChangeEventCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA5430", Offset = "0x2BA4830", Length = "0x9B")]
	[Token(Token = "0x600125F")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA54D0", Offset = "0x2BA48D0", Length = "0x13C")]
	[MonoPInvokeCallback(typeof(XUserChangeEventCallback))]
	[Token(Token = "0x600125C")]
	private static void OnChangeEvent(IntPtr context, XUserLocalId userLocalId, XUserChangeEvent changeEvent) { }

	[Address(RVA = "0x2BA5610", Offset = "0x2BA4A10", Length = "0xB7")]
	[Token(Token = "0x600125E")]
	public bool Unregister(bool wait) { }

}

