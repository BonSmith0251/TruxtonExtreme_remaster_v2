namespace System.Data;

[Token(Token = "0x2000066")]
internal sealed class OperatorInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400022F")]
	internal Nodes _type; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000230")]
	internal int _op; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000231")]
	internal int _priority; //Field offset: 0x18

	[Address(RVA = "0x11EB3F0", Offset = "0x11EA7F0", Length = "0x44")]
	[Token(Token = "0x60005C0")]
	internal OperatorInfo(Nodes type, int op, int pri) { }

}

