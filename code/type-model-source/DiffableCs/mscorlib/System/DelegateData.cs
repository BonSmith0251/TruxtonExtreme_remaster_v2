namespace System;

[Token(Token = "0x20001AA")]
internal sealed class DelegateData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E5")]
	public Type target_type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006E6")]
	public string method_name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006E7")]
	public bool curried_first_arg; //Field offset: 0x20

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F87")]
	public DelegateData() { }

}

