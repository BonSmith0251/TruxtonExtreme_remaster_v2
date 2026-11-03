namespace System.Runtime.Remoting;

[Token(Token = "0x200035B")]
internal class SingleCallIdentity : ServerIdentity
{

	[Address(RVA = "0x1EEF280", Offset = "0x1EEE680", Length = "0x6B")]
	[Token(Token = "0x6001B1D")]
	public SingleCallIdentity(string objectUri, Context context, Type objectType) { }

	[Address(RVA = "0x1EEF2F0", Offset = "0x1EEE6F0", Length = "0x19B")]
	[Token(Token = "0x6001B1F")]
	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EEF490", Offset = "0x1EEE890", Length = "0x173")]
	[Token(Token = "0x6001B1E")]
	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

