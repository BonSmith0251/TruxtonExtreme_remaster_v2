namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C9")]
internal class XMetadataPurgedToken : XRegistrationToken<XAppCaptureMetadataPurgedCallback>
{

	[Address(RVA = "0x2BA27F0", Offset = "0x2BA1BF0", Length = "0x116")]
	[Token(Token = "0x6000F9B")]
	public XMetadataPurgedToken(XAppCaptureMetadataPurgedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA2580", Offset = "0x2BA1980", Length = "0x9B")]
	[Token(Token = "0x6000F9D")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA2620", Offset = "0x2BA1A20", Length = "0x10B")]
	[MonoPInvokeCallback(typeof(XAppCaptureMetadataPurgedCallback))]
	[Token(Token = "0x6000F9A")]
	private static void OnXMetadataPurged(IntPtr context) { }

	[Address(RVA = "0x2BA2730", Offset = "0x2BA1B30", Length = "0xB7")]
	[Token(Token = "0x6000F9C")]
	public bool Unregister(bool wait) { }

}

