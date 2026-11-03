namespace Unity.XGamingRuntime;

[Token(Token = "0x200027A")]
public sealed class XStoreGameLicenseChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
	[Token(Token = "0x6000D21")]
	public XStoreGameLicenseChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
	[Token(Token = "0x6000D23")]
	public override IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000D24")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000D22")]
	public override void Invoke(IntPtr context) { }

}

