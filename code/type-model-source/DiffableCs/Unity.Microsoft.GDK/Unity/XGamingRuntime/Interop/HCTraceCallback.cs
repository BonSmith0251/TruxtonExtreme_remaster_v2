namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002E4")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class HCTraceCallback : MulticastDelegate
{

	[Address(RVA = "0x2B6E620", Offset = "0x2B6DA20", Length = "0xB5")]
	[Token(Token = "0x6001133")]
	public HCTraceCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B8E750", Offset = "0x2B8DB50", Length = "0xD0")]
	[Token(Token = "0x6001135")]
	public override IAsyncResult BeginInvoke(Byte[] areaName, HCTraceLevel level, ulong threadId, ulong timestamp, Byte[] message, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6001136")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
	[Token(Token = "0x6001134")]
	public override void Invoke(Byte[] areaName, HCTraceLevel level, ulong threadId, ulong timestamp, Byte[] message) { }

}

