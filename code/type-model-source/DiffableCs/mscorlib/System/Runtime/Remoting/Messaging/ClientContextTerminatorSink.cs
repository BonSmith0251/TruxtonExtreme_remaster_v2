namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003AE")]
internal class ClientContextTerminatorSink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EC5")]
	private Context _context; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001C99")]
	public ClientContextTerminatorSink(Context ctx) { }

	[Address(RVA = "0x1EFEDB0", Offset = "0x1EFE1B0", Length = "0x235")]
	[Token(Token = "0x6001C9B")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EFEFF0", Offset = "0x1EFE3F0", Length = "0x1A9")]
	[Token(Token = "0x6001C9A")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

