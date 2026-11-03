namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000312")]
public struct RSAParameters
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D19")]
	public Byte[] Exponent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D1A")]
	public Byte[] Modulus; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D1B")]
	public Byte[] P; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D1C")]
	public Byte[] Q; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D1D")]
	public Byte[] DP; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D1E")]
	public Byte[] DQ; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D1F")]
	public Byte[] InverseQ; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D20")]
	public Byte[] D; //Field offset: 0x38

}

