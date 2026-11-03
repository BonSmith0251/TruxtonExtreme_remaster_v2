namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003B3")]
internal class EnvoyTerminatorSink : IMessageSink
{
	[Token(Token = "0x4000ED0")]
	public static EnvoyTerminatorSink Instance; //Field offset: 0x0

	[Address(RVA = "0x1F01F50", Offset = "0x1F01350", Length = "0x67")]
	[Token(Token = "0x6001CBB")]
	private static EnvoyTerminatorSink() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001CBA")]
	public EnvoyTerminatorSink() { }

	[Address(RVA = "0x1F01E70", Offset = "0x1F01270", Length = "0x73")]
	[Token(Token = "0x6001CB9")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1F01EF0", Offset = "0x1F012F0", Length = "0x5E")]
	[Token(Token = "0x6001CB8")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

