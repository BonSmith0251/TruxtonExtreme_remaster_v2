namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200037C")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XPackageFeatureEnumerationCallbackInterop : MulticastDelegate
{

	[Address(RVA = "0x2BA35A0", Offset = "0x2BA29A0", Length = "0xA6")]
	[Token(Token = "0x6001206")]
	public XPackageFeatureEnumerationCallbackInterop(object object, IntPtr method) { }

	[Address(RVA = "0x2BA34C0", Offset = "0x2BA28C0", Length = "0x97")]
	[Token(Token = "0x6001208")]
	public override IAsyncResult BeginInvoke(IntPtr context, XPackageFeature feature, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x6001209")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x2BA3560", Offset = "0x2BA2960", Length = "0x3B")]
	[Token(Token = "0x6001207")]
	public override bool Invoke(IntPtr context, XPackageFeature feature) { }

}

