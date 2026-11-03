namespace System;

[Token(Token = "0x20001A2")]
internal class MonoTypeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006B9")]
	public string full_name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006BA")]
	public RuntimeConstructorInfo default_ctor; //Field offset: 0x18

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F5F")]
	public MonoTypeInfo() { }

}

