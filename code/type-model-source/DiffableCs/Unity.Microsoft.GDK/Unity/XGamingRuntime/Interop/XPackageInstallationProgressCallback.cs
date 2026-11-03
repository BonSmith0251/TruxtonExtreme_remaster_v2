namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200037E")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XPackageInstallationProgressCallback : MulticastDelegate
{

	[Address(RVA = "0x60DC10", Offset = "0x60D010", Length = "0xA6")]
	[Token(Token = "0x600120E")]
	public XPackageInstallationProgressCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA3650", Offset = "0x2BA2A50", Length = "0x75")]
	[Token(Token = "0x6001210")]
	public override IAsyncResult BeginInvoke(IntPtr context, IntPtr monitor, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6001211")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x600120F")]
	public override void Invoke(IntPtr context, IntPtr monitor) { }

}

