namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003CD")]
internal class ServerObjectReplySink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F1A")]
	private IMessageSink _replySink; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F1B")]
	private ServerIdentity _identity; //Field offset: 0x18

	[Address(RVA = "0x1EF8380", Offset = "0x1EF7780", Length = "0x4E")]
	[Token(Token = "0x6001D70")]
	public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink) { }

	[Address(RVA = "0x1F143F0", Offset = "0x1F137F0", Length = "0x3E")]
	[Token(Token = "0x6001D72")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1F14430", Offset = "0x1F13830", Length = "0x79")]
	[Token(Token = "0x6001D71")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

