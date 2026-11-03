namespace System;

[Token(Token = "0x200009A")]
public sealed class Action : MulticastDelegate
{

	[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
	[Token(Token = "0x60003A0")]
	public Action(object object, IntPtr method) { }

	[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
	[Token(Token = "0x60003A1")]
	public override void Invoke() { }

}

