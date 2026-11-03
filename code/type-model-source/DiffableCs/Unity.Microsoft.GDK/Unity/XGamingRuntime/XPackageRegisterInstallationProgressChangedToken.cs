namespace Unity.XGamingRuntime;

[Token(Token = "0x2000252")]
public class XPackageRegisterInstallationProgressChangedToken
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065D")]
	private XPackageRegisterInstallationProgressChangedToken <interop>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000265")]
	internal XPackageRegisterInstallationProgressChangedToken interop
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C0B")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C0C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000267")]
	public bool IsValid
	{
		[Address(RVA = "0x2B822A0", Offset = "0x2B816A0", Length = "0x44")]
		[Token(Token = "0x6000C10")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000266")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000C0E")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000C0F")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B82200", Offset = "0x2B81600", Length = "0x9F")]
	[Token(Token = "0x6000C0D")]
	internal XPackageRegisterInstallationProgressChangedToken(XPackageInstallationMonitorHandle handle, XPackageInstallationProgressCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B82190", Offset = "0x2B81590", Length = "0x44")]
	[Token(Token = "0x6000C12")]
	public void Dispose() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C0B")]
	internal XPackageRegisterInstallationProgressChangedToken get_interop() { }

	[Address(RVA = "0x2B822A0", Offset = "0x2B816A0", Length = "0x44")]
	[Token(Token = "0x6000C10")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000C0E")]
	public ulong get_Token() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C0C")]
	private void set_interop(XPackageRegisterInstallationProgressChangedToken value) { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000C0F")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B821E0", Offset = "0x2B815E0", Length = "0x1E")]
	[Token(Token = "0x6000C11")]
	public bool Unregister(XPackageInstallationMonitorHandle installationMonitor, bool wait) { }

}

