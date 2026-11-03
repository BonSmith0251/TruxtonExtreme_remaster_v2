namespace System;

[Token(Token = "0x200009B")]
public sealed class Action : MulticastDelegate
{

	[Address(RVA = "0x10AAF90", Offset = "0x10AA390", Length = "0xA6")]
	[Token(Token = "0x60003A2")]
	public Action`1(object object, IntPtr method) { }

	[Address(RVA = "0xE2BBB0", Offset = "0xE2AFB0", Length = "0x24")]
	[Token(Token = "0x60003A3")]
	public override void Invoke(T obj) { }

}

