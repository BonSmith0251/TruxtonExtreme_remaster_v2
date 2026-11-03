namespace System.Runtime.Remoting;

[Token(Token = "0x200035C")]
internal class DisposerReplySink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E15")]
	private IMessageSink _next; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E16")]
	private IDisposable _disposable; //Field offset: 0x18

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6001B20")]
	public DisposerReplySink(IMessageSink next, IDisposable disposable) { }

	[Address(RVA = "0x1EE12F0", Offset = "0x1EE06F0", Length = "0x3E")]
	[Token(Token = "0x6001B22")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EE1330", Offset = "0x1EE0730", Length = "0x78")]
	[Token(Token = "0x6001B21")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

