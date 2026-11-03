namespace System.Runtime.Remoting.Contexts;

[Token(Token = "0x2000376")]
internal class CrossContextChannel : IMessageSink
{
	[Token(Token = "0x2000377")]
	private class ContextRestoreSink : IMessageSink
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E65")]
		private IMessageSink _next; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E66")]
		private Context _context; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000E67")]
		private IMessage _call; //Field offset: 0x20

		[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
		[Token(Token = "0x6001BC9")]
		public ContextRestoreSink(IMessageSink next, Context context, IMessage call) { }

		[Address(RVA = "0x1F00800", Offset = "0x1EFFC00", Length = "0x3E")]
		[Token(Token = "0x6001BCB")]
		public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

		[Address(RVA = "0x1F00840", Offset = "0x1EFFC40", Length = "0x1D9")]
		[Token(Token = "0x6001BCA")]
		public override IMessage SyncProcessMessage(IMessage msg) { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001BC8")]
	public CrossContextChannel() { }

	[Address(RVA = "0x1EE09E0", Offset = "0x1EDFDE0", Length = "0x39D")]
	[Token(Token = "0x6001BC7")]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EE0D80", Offset = "0x1EE0180", Length = "0x518")]
	[Token(Token = "0x6001BC6")]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

