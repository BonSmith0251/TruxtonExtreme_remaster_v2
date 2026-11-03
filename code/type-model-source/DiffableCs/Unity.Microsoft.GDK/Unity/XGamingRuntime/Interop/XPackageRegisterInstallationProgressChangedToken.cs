namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000379")]
internal class XPackageRegisterInstallationProgressChangedToken : XRegistrationToken<XPackageInstallationProgressCallback>
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009EB")]
	private XPackageInstallationMonitorHandle installationProgressChanged; //Field offset: 0x38

	[Address(RVA = "0x2BA3BA0", Offset = "0x2BA2FA0", Length = "0x134")]
	[Token(Token = "0x60011FA")]
	public XPackageRegisterInstallationProgressChangedToken(XPackageInstallationMonitorHandle installationProgressChanged, XPackageInstallationProgressCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA3820", Offset = "0x2BA2C20", Length = "0xBA")]
	[Token(Token = "0x60011FD")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA38E0", Offset = "0x2BA2CE0", Length = "0x11E")]
	[MonoPInvokeCallback(typeof(XPackageInstallationProgressCallback))]
	[Token(Token = "0x60011F9")]
	private static void OnInstallationProgress(IntPtr context, IntPtr monitor) { }

	[Address(RVA = "0x2BA3A00", Offset = "0x2BA2E00", Length = "0xCB")]
	[Token(Token = "0x60011FB")]
	public bool Unregister(XPackageInstallationMonitorHandle installationProgressChanged, bool wait) { }

	[Address(RVA = "0x2BA3AD0", Offset = "0x2BA2ED0", Length = "0xC1")]
	[Token(Token = "0x60011FC")]
	public bool Unregister(bool wait) { }

}

