namespace Unity.XGamingRuntime;

[Token(Token = "0x200013C")]
public sealed class XAsyncProvider : MulticastDelegate
{

	[Address(RVA = "0x1C157E0", Offset = "0x1C14BE0", Length = "0xA6")]
	[Token(Token = "0x600072D")]
	public XAsyncProvider(object object, IntPtr method) { }

	[Address(RVA = "0x2B7C990", Offset = "0x2B7BD90", Length = "0x87")]
	[Token(Token = "0x600072F")]
	public override IAsyncResult BeginInvoke(XAsyncOp op, XAsyncProviderData data, AsyncCallback callback, object object) { }

	[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
	[Token(Token = "0x6000730")]
	public override int EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x600072E")]
	public override int Invoke(XAsyncOp op, XAsyncProviderData data) { }

}

