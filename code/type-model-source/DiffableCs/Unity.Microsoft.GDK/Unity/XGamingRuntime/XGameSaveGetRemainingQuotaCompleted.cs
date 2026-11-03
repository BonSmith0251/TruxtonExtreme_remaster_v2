namespace Unity.XGamingRuntime;

[Token(Token = "0x200010B")]
public sealed class XGameSaveGetRemainingQuotaCompleted : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000664")]
	public XGameSaveGetRemainingQuotaCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x2B7CC90", Offset = "0x2B7C090", Length = "0x74")]
	[Token(Token = "0x6000666")]
	public override IAsyncResult BeginInvoke(int hr, long remainingQuota, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000667")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000665")]
	public override void Invoke(int hr, long remainingQuota) { }

}

