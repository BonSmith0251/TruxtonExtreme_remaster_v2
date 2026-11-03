namespace Unity.XGamingRuntime;

[Token(Token = "0x2000106")]
public sealed class XAsyncWork : MulticastDelegate
{

	[Address(RVA = "0x1C132B0", Offset = "0x1C126B0", Length = "0x124")]
	[Token(Token = "0x6000652")]
	public XAsyncWork(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
	[Token(Token = "0x6000654")]
	public override IAsyncResult BeginInvoke(XAsyncBlock asyncBlock, AsyncCallback callback, object object) { }

	[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
	[Token(Token = "0x6000655")]
	public override int EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000653")]
	public override int Invoke(XAsyncBlock asyncBlock) { }

}

