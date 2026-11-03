namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F9")]
public struct DSAParameters
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CD5")]
	public Byte[] P; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CD6")]
	public Byte[] Q; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CD7")]
	public Byte[] G; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CD8")]
	public Byte[] Y; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CD9")]
	public Byte[] J; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CDA")]
	public Byte[] X; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CDB")]
	public Byte[] Seed; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CDC")]
	public int Counter; //Field offset: 0x38

}

