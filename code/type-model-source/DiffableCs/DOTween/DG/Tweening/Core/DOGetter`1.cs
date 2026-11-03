namespace DG.Tweening.Core;

[Token(Token = "0x200009F")]
public sealed class DOGetter : MulticastDelegate
{

	[Address(RVA = "0x17C9C10", Offset = "0x17C9010", Length = "0xA5")]
	[Token(Token = "0x60003AC")]
	public DOGetter`1(object object, IntPtr method) { }

	[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
	[Token(Token = "0x60003AE")]
	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	[Address(RVA = "0x17C9A40", Offset = "0x17C8E40", Length = "0x34")]
	[Token(Token = "0x60003AF")]
	public override T EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x17C9B60", Offset = "0x17C8F60", Length = "0x2B")]
	[Token(Token = "0x60003AD")]
	public override T Invoke() { }

}

