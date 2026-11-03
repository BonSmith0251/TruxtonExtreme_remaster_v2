namespace System.Runtime.Remoting.Lifetime;

[Token(Token = "0x200036F")]
internal class LeaseSink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E47")]
	private IMessageSink _nextSink; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001B8B")]
	public LeaseSink(IMessageSink nextSink) { }

	[Address(RVA = "0x1EE2E10", Offset = "0x1EE2210", Length = "0x79")]
	[Token(Token = "0x6001B8D")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EE2E90", Offset = "0x1EE2290", Length = "0x1BB")]
	[Token(Token = "0x6001B8E")]
	private void RenewLease(IMessage msg) { }

	[Address(RVA = "0x1EE3050", Offset = "0x1EE2450", Length = "0x63")]
	[Token(Token = "0x6001B8C")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

