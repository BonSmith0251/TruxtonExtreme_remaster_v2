namespace System.Net;

[Token(Token = "0x200022C")]
internal class ReceiveState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000848")]
	internal ResponseDescription Resp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000849")]
	internal int ValidThrough; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400084A")]
	internal Byte[] Buffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400084B")]
	internal CommandStream Connection; //Field offset: 0x28

	[Address(RVA = "0x26ABD80", Offset = "0x26AB180", Length = "0x104")]
	[Token(Token = "0x6000EAE")]
	internal ReceiveState(CommandStream connection) { }

}

