namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200032A")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XblPresenceTitlePresenceChangedHandler : MulticastDelegate
{

	[Address(RVA = "0x2BB7E30", Offset = "0x2BB7230", Length = "0xA6")]
	[Token(Token = "0x6001192")]
	public XblPresenceTitlePresenceChangedHandler(object object, IntPtr method) { }

	[Address(RVA = "0x2BB7D60", Offset = "0x2BB7160", Length = "0xC5")]
	[Token(Token = "0x6001194")]
	public override IAsyncResult BeginInvoke(IntPtr context, ulong xuid, uint titleId, XblPresenceTitleState titleState, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6001195")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x6001193")]
	public override void Invoke(IntPtr context, ulong xuid, uint titleId, XblPresenceTitleState titleState) { }

}

