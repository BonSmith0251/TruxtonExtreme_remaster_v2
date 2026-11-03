namespace Unity.XGamingRuntime;

[Token(Token = "0x20001F1")]
public sealed class XblTitleStorageGetQuotaCompleted : MulticastDelegate
{

	[Address(RVA = "0x2B7E930", Offset = "0x2B7DD30", Length = "0xA6")]
	[Token(Token = "0x6000A4F")]
	public XblTitleStorageGetQuotaCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x2B8CAB0", Offset = "0x2B8BEB0", Length = "0x82")]
	[Token(Token = "0x6000A51")]
	public override IAsyncResult BeginInvoke(int hresult, ulong usedBytes, ulong quotaBytes, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000A52")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000A50")]
	public override void Invoke(int hresult, ulong usedBytes, ulong quotaBytes) { }

}

