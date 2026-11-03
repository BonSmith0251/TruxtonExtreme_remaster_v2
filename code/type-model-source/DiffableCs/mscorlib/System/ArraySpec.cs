namespace System;

[Token(Token = "0x20001D7")]
internal class ArraySpec : ModifierSpec
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400090E")]
	private int dimensions; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400090F")]
	private bool bound; //Field offset: 0x14

	[Address(RVA = "0x20933F0", Offset = "0x20927F0", Length = "0x36")]
	[Token(Token = "0x6001094")]
	internal ArraySpec(int dimensions, bool bound) { }

	[Address(RVA = "0x20931D0", Offset = "0x20925D0", Length = "0x9D")]
	[Token(Token = "0x6001096")]
	public override StringBuilder Append(StringBuilder sb) { }

	[Address(RVA = "0x2093270", Offset = "0x2092670", Length = "0x80")]
	[Token(Token = "0x6001095")]
	public override Type Resolve(Type type) { }

	[Address(RVA = "0x2093300", Offset = "0x2092700", Length = "0xE3")]
	[Token(Token = "0x6001097")]
	public virtual string ToString() { }

}

