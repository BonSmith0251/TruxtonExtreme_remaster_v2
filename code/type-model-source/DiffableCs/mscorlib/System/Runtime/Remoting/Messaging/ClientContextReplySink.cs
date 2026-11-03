namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003AF")]
internal class ClientContextReplySink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EC6")]
	private IMessageSink _replySink; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EC7")]
	private Context _context; //Field offset: 0x18

	[Address(RVA = "0x1EF8380", Offset = "0x1EF7780", Length = "0x4E")]
	[Token(Token = "0x6001C9C")]
	public ClientContextReplySink(Context ctx, IMessageSink replySink) { }

	[Address(RVA = "0x1EFECB0", Offset = "0x1EFE0B0", Length = "0x3E")]
	[Token(Token = "0x6001C9E")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EFECF0", Offset = "0x1EFE0F0", Length = "0xB4")]
	[Token(Token = "0x6001C9D")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

