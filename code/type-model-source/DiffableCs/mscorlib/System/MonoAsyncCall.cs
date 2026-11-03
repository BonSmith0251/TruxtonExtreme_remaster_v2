namespace System;

[Token(Token = "0x20001BB")]
internal class MonoAsyncCall
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000709")]
	private object msg; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400070A")]
	private IntPtr cb_method; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400070B")]
	private object cb_target; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400070C")]
	private object state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400070D")]
	private object res; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400070E")]
	private object out_args; //Field offset: 0x38

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000FD4")]
	public MonoAsyncCall() { }

}

