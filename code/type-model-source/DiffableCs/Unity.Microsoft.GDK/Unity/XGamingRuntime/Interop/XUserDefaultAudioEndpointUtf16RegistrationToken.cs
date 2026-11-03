namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003AD")]
internal class XUserDefaultAudioEndpointUtf16RegistrationToken : XRegistrationToken<XUserDefaultAudioEndpointUtf16ChangedCallback>
{

	[Address(RVA = "0x2BA5B80", Offset = "0x2BA4F80", Length = "0x116")]
	[Token(Token = "0x6001261")]
	public XUserDefaultAudioEndpointUtf16RegistrationToken(XUserDefaultAudioEndpointUtf16ChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA58C0", Offset = "0x2BA4CC0", Length = "0x9B")]
	[Token(Token = "0x6001263")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA5960", Offset = "0x2BA4D60", Length = "0x152")]
	[MonoPInvokeCallback(typeof(XUserDefaultAudioEndpointUtf16ChangedCallback))]
	[Token(Token = "0x6001260")]
	private static void OnDefaultAudioEndpointUtf16Changed(IntPtr context, XUserLocalId user, XUserDefaultAudioEndpointKind defaultAudioEndpointKind, string endpointIdUtf16) { }

	[Address(RVA = "0x2BA5AC0", Offset = "0x2BA4EC0", Length = "0xB7")]
	[Token(Token = "0x6001262")]
	public bool Unregister(bool wait) { }

}

