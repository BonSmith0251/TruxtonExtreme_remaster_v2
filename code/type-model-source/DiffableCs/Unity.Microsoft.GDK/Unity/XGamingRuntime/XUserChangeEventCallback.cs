namespace Unity.XGamingRuntime;

[Token(Token = "0x20002A0")]
public sealed class XUserChangeEventCallback : MulticastDelegate
{

	[Address(RVA = "0x2B81150", Offset = "0x2B80550", Length = "0xA6")]
	[Token(Token = "0x6000DA7")]
	public XUserChangeEventCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B844B0", Offset = "0x2B838B0", Length = "0x96")]
	[Token(Token = "0x6000DA9")]
	public override IAsyncResult BeginInvoke(IntPtr context, XUserLocalId userLocalId, XUserChangeEvent changeEvent, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000DAA")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000DA8")]
	public override void Invoke(IntPtr context, XUserLocalId userLocalId, XUserChangeEvent changeEvent) { }

}

