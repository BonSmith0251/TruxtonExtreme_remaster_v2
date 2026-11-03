namespace System;

[Token(Token = "0x20000BA")]
public sealed class AsyncCallback : MulticastDelegate
{

	[Address(RVA = "0x5BC6F0", Offset = "0x5BBAF0", Length = "0x124")]
	[Token(Token = "0x6000419")]
	public AsyncCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
	[Token(Token = "0x600041B")]
	public override IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x600041C")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x600041A")]
	public override void Invoke(IAsyncResult ar) { }

}

