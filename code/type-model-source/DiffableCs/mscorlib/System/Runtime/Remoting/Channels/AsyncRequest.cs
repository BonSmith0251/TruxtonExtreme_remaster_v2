namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x2000388")]
internal class AsyncRequest
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E76")]
	internal IMessageSink ReplySink; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E77")]
	internal IMessage MsgRequest; //Field offset: 0x18

	[Address(RVA = "0x1EF8380", Offset = "0x1EF7780", Length = "0x4E")]
	[Token(Token = "0x6001C01")]
	public AsyncRequest(IMessage msgRequest, IMessageSink replySink) { }

}

