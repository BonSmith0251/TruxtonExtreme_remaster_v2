namespace System;

[Token(Token = "0x20000D1")]
public sealed class EventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x600069D")]
	public EventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x600069E")]
	public override void Invoke(object sender, EventArgs e) { }

}

