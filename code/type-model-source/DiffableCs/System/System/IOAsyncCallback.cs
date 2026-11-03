namespace System;

[Token(Token = "0x20000D0")]
internal sealed class IOAsyncCallback : MulticastDelegate
{

	[Address(RVA = "0x1C4A150", Offset = "0x1C49550", Length = "0x124")]
	[Token(Token = "0x6000432")]
	public IOAsyncCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000433")]
	public override void Invoke(IOAsyncResult ioares) { }

}

