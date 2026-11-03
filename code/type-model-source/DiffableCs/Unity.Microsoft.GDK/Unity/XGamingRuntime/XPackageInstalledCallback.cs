namespace Unity.XGamingRuntime;

[Token(Token = "0x2000256")]
public sealed class XPackageInstalledCallback : MulticastDelegate
{

	[Address(RVA = "0x60DC10", Offset = "0x60D010", Length = "0xA6")]
	[Token(Token = "0x6000C1F")]
	public XPackageInstalledCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60DBA0", Offset = "0x60CFA0", Length = "0x6C")]
	[Token(Token = "0x6000C21")]
	public override IAsyncResult BeginInvoke(IntPtr context, XPackageDetails details, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000C22")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000C20")]
	public override void Invoke(IntPtr context, XPackageDetails details) { }

}

