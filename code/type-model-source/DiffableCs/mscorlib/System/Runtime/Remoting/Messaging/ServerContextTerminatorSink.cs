namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003CB")]
internal class ServerContextTerminatorSink : IMessageSink
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001D6C")]
	public ServerContextTerminatorSink() { }

	[Address(RVA = "0x1F14210", Offset = "0x1F13610", Length = "0xBA")]
	[Token(Token = "0x6001D6B")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1F142D0", Offset = "0x1F136D0", Length = "0x113")]
	[Token(Token = "0x6001D6A")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

