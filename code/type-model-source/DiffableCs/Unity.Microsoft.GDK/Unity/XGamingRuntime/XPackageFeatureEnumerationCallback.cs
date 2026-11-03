namespace Unity.XGamingRuntime;

[Token(Token = "0x2000255")]
public sealed class XPackageFeatureEnumerationCallback : MulticastDelegate
{

	[Address(RVA = "0x2B81FE0", Offset = "0x2B813E0", Length = "0xA6")]
	[Token(Token = "0x6000C1B")]
	public XPackageFeatureEnumerationCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60DBA0", Offset = "0x60CFA0", Length = "0x6C")]
	[Token(Token = "0x6000C1D")]
	public override IAsyncResult BeginInvoke(IntPtr context, XPackageFeature feature, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x6000C1E")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000C1C")]
	public override bool Invoke(IntPtr context, XPackageFeature feature) { }

}

