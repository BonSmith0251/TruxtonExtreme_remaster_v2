namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003CE")]
internal class StackBuilderSink : IMessageSink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F1C")]
	private MarshalByRefObject _target; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F1D")]
	private RealProxy _rp; //Field offset: 0x18

	[Address(RVA = "0x1F15520", Offset = "0x1F14920", Length = "0xB6")]
	[Token(Token = "0x6001D73")]
	public StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute) { }

	[Address(RVA = "0x1F15500", Offset = "0x1F14900", Length = "0x14")]
	[CompilerGenerated]
	[Token(Token = "0x6001D78")]
	private void <AsyncProcessMessage>b__4_0(object data) { }

	[Address(RVA = "0x1F14D10", Offset = "0x1F14110", Length = "0x148")]
	[Token(Token = "0x6001D75")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1F14E60", Offset = "0x1F14260", Length = "0x3DB")]
	[Token(Token = "0x6001D77")]
	private void CheckParameters(IMessage msg) { }

	[Address(RVA = "0x1F15240", Offset = "0x1F14640", Length = "0x1CB")]
	[Token(Token = "0x6001D76")]
	private void ExecuteAsyncMessage(object ob) { }

	[Address(RVA = "0x1F15410", Offset = "0x1F14810", Length = "0xE3")]
	[Token(Token = "0x6001D74")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

