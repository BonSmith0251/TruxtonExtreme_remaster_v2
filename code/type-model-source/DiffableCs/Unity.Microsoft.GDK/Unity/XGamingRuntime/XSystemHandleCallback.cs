namespace Unity.XGamingRuntime;

[Token(Token = "0x2000281")]
public sealed class XSystemHandleCallback : MulticastDelegate
{

	[Address(RVA = "0x2B83B40", Offset = "0x2B82F40", Length = "0xA6")]
	[Token(Token = "0x6000D41")]
	public XSystemHandleCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B83A60", Offset = "0x2B82E60", Length = "0xD1")]
	[Token(Token = "0x6000D43")]
	public override IAsyncResult BeginInvoke(IntPtr handle, XSystemHandleType type, XSystemHandleCallbackReason reason, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000D44")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x6000D42")]
	public override void Invoke(IntPtr handle, XSystemHandleType type, XSystemHandleCallbackReason reason, IntPtr context) { }

}

