namespace System.Globalization;

[Token(Token = "0x200057E")]
internal class Bootstring
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400173F")]
	private readonly char delimiter; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001740")]
	private readonly int base_num; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001741")]
	private readonly int tmin; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001742")]
	private readonly int tmax; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001743")]
	private readonly int skew; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001744")]
	private readonly int damp; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001745")]
	private readonly int initial_bias; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001746")]
	private readonly int initial_n; //Field offset: 0x2C

	[Address(RVA = "0x1FBF580", Offset = "0x1FBE980", Length = "0x69")]
	[Token(Token = "0x60028C4")]
	public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	[Address(RVA = "0x1FBEE00", Offset = "0x1FBE200", Length = "0x7F")]
	[Token(Token = "0x60028C8")]
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	[Address(RVA = "0x1FBEEB0", Offset = "0x1FBE2B0", Length = "0x29C")]
	[Token(Token = "0x60028C9")]
	public string Decode(string s, int offset) { }

	[Address(RVA = "0x1FBEE80", Offset = "0x1FBE280", Length = "0x2C")]
	[Token(Token = "0x60028C7")]
	private int DecodeDigit(char c) { }

	[Address(RVA = "0x1FBF170", Offset = "0x1FBE570", Length = "0x40D")]
	[Token(Token = "0x60028C5")]
	public string Encode(string s, int offset) { }

	[Address(RVA = "0x1FBF150", Offset = "0x1FBE550", Length = "0x17")]
	[Token(Token = "0x60028C6")]
	private char EncodeDigit(int d) { }

}

