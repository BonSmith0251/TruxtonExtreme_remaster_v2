namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200037D")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XPackageInstalledCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA3770", Offset = "0x2BA2B70", Length = "0xA6")]
	[Token(Token = "0x600120A")]
	public XPackageInstalledCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA36D0", Offset = "0x2BA2AD0", Length = "0x97")]
	[Token(Token = "0x600120C")]
	public override IAsyncResult BeginInvoke(IntPtr context, XPackageDetails details, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x600120D")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x2BA33C0", Offset = "0x2BA27C0", Length = "0x43")]
	[Token(Token = "0x600120B")]
	public override void Invoke(IntPtr context, XPackageDetails details) { }

}

