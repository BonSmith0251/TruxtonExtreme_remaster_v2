namespace Unity.XGamingRuntime;

[Token(Token = "0x2000157")]
public sealed class HCTraceCallback : MulticastDelegate
{

	[Address(RVA = "0x2B6E620", Offset = "0x2B6DA20", Length = "0xB5")]
	[Token(Token = "0x60007A8")]
	public HCTraceCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B6E550", Offset = "0x2B6D950", Length = "0xD0")]
	[Token(Token = "0x60007AA")]
	public override IAsyncResult BeginInvoke(Byte[] areaName, HCTraceLevel level, ulong threadId, ulong timestamp, Byte[] message, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60007AB")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
	[Token(Token = "0x60007A9")]
	public override void Invoke(Byte[] areaName, HCTraceLevel level, ulong threadId, ulong timestamp, Byte[] message) { }

}

