namespace System;

[Token(Token = "0x20000B9")]
public sealed class AssemblyLoadEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000417")]
	public AssemblyLoadEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000418")]
	public override void Invoke(object sender, AssemblyLoadEventArgs args) { }

}

