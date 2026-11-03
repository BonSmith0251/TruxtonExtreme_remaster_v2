namespace Unity.XGamingRuntime;

[Token(Token = "0x2000286")]
public sealed class XTaskQueueMonitorCallback : MulticastDelegate
{

	[Address(RVA = "0x2B81150", Offset = "0x2B80550", Length = "0xA6")]
	[Token(Token = "0x6000D4F")]
	public XTaskQueueMonitorCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B84150", Offset = "0x2B83550", Length = "0x9F")]
	[Token(Token = "0x6000D51")]
	public override IAsyncResult BeginInvoke(IntPtr context, IntPtr queue, XTaskQueuePort port, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000D52")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000D50")]
	public override void Invoke(IntPtr context, IntPtr queue, XTaskQueuePort port) { }

}

