namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003CC")]
internal class ServerObjectTerminatorSink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F19")]
	private IMessageSink _nextSink; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001D6D")]
	public ServerObjectTerminatorSink(IMessageSink nextSink) { }

	[Address(RVA = "0x1F144B0", Offset = "0x1F138B0", Length = "0x19E")]
	[Token(Token = "0x6001D6F")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1F14650", Offset = "0x1F13A50", Length = "0x11D")]
	[Token(Token = "0x6001D6E")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

