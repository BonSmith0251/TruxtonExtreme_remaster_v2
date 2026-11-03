namespace System;

[Token(Token = "0x200014F")]
public sealed class UnhandledExceptionEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000BAA")]
	public UnhandledExceptionEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000BAB")]
	public override void Invoke(object sender, UnhandledExceptionEventArgs e) { }

}

