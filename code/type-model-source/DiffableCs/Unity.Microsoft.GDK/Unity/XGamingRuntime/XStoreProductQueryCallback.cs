namespace Unity.XGamingRuntime;

[Token(Token = "0x2000278")]
public sealed class XStoreProductQueryCallback : MulticastDelegate
{

	[Address(RVA = "0x1F5EE30", Offset = "0x1F5E230", Length = "0x125")]
	[Token(Token = "0x6000D19")]
	public XStoreProductQueryCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B80E70", Offset = "0x2B80270", Length = "0x59")]
	[Token(Token = "0x6000D1B")]
	public override IAsyncResult BeginInvoke(XStoreProduct product, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x6000D1C")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000D1A")]
	public override bool Invoke(XStoreProduct product, IntPtr context) { }

}

