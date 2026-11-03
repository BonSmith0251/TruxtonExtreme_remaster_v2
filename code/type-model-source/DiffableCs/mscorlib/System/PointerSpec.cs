namespace System;

[Token(Token = "0x20001D8")]
internal class PointerSpec : ModifierSpec
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000910")]
	private int pointer_level; //Field offset: 0x10

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6001098")]
	internal PointerSpec(int pointer_level) { }

	[Address(RVA = "0x20A29A0", Offset = "0x20A1DA0", Length = "0x29")]
	[Token(Token = "0x600109A")]
	public override StringBuilder Append(StringBuilder sb) { }

	[Address(RVA = "0x20A29D0", Offset = "0x20A1DD0", Length = "0x4A")]
	[Token(Token = "0x6001099")]
	public override Type Resolve(Type type) { }

	[Address(RVA = "0x20A2A20", Offset = "0x20A1E20", Length = "0x86")]
	[Token(Token = "0x600109B")]
	public virtual string ToString() { }

}

