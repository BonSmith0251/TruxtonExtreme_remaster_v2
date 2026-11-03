namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000395")]
internal sealed class XStoreGameLicenseChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
	[Token(Token = "0x6001226")]
	public XStoreGameLicenseChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
	[Token(Token = "0x6001228")]
	public override IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6001229")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6001227")]
	public override void Invoke(IntPtr context) { }

}

