namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000378")]
internal class XPackageRegisterPackageInstalledToken : XRegistrationToken<XPackageInstalledCallback>
{

	[Address(RVA = "0x2BA3F90", Offset = "0x2BA3390", Length = "0x116")]
	[Token(Token = "0x60011F6")]
	public XPackageRegisterPackageInstalledToken(XPackageInstalledCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA3CE0", Offset = "0x2BA30E0", Length = "0x9B")]
	[Token(Token = "0x60011F8")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA3D80", Offset = "0x2BA3180", Length = "0x14F")]
	[MonoPInvokeCallback(typeof(XPackageInstalledCallback))]
	[Token(Token = "0x60011F5")]
	private static void OnPackageInstalled(IntPtr context, XPackageDetails details) { }

	[Address(RVA = "0x2BA3ED0", Offset = "0x2BA32D0", Length = "0xB7")]
	[Token(Token = "0x60011F7")]
	public bool Unregister(bool wait) { }

}

