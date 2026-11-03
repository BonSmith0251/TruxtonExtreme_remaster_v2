namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000392")]
internal class PackageLicenseLostCallbackToken : XRegistrationToken<XStorePackageLicenseLostCallback>
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A51")]
	private XStoreLicense licenseHandle; //Field offset: 0x38

	[Address(RVA = "0x2B9E9D0", Offset = "0x2B9DDD0", Length = "0x134")]
	[Token(Token = "0x600121B")]
	public PackageLicenseLostCallbackToken(XStoreLicense licenseHandle, XStorePackageLicenseLostCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B9E730", Offset = "0x2B9DB30", Length = "0xBA")]
	[Token(Token = "0x600121D")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2B9E7F0", Offset = "0x2B9DBF0", Length = "0x10B")]
	[MonoPInvokeCallback(typeof(XStorePackageLicenseLostCallback))]
	[Token(Token = "0x600121A")]
	private static void OnPackageLicenseLostCallback(IntPtr context) { }

	[Address(RVA = "0x2B9E900", Offset = "0x2B9DD00", Length = "0xCE")]
	[Token(Token = "0x600121C")]
	public bool Unregister(bool wait) { }

}

