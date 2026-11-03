namespace System;

[Token(Token = "0x200012C")]
public sealed class ResolveEventHandler : MulticastDelegate
{

	[Address(RVA = "0xD0F0A0", Offset = "0xD0E4A0", Length = "0x125")]
	[Token(Token = "0x60009A2")]
	public ResolveEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60009A3")]
	public override Assembly Invoke(object sender, ResolveEventArgs args) { }

}

