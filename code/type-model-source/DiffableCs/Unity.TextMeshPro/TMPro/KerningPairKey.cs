namespace TMPro;

[Token(Token = "0x2000050")]
public struct KerningPairKey
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024B")]
	public uint ascii_Left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400024C")]
	public uint ascii_Right; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400024D")]
	public uint key; //Field offset: 0x8

	[Address(RVA = "0x2EC5740", Offset = "0x2EC4B40", Length = "0x12")]
	[Token(Token = "0x600029C")]
	public KerningPairKey(uint ascii_left, uint ascii_right) { }

}

