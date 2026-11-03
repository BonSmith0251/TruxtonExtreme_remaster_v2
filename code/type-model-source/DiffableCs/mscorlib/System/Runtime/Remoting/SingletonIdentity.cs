namespace System.Runtime.Remoting;

[Token(Token = "0x200035A")]
internal class SingletonIdentity : ServerIdentity
{

	[Address(RVA = "0x1EEF280", Offset = "0x1EEE680", Length = "0x6B")]
	[Token(Token = "0x6001B19")]
	public SingletonIdentity(string objectUri, Context context, Type objectType) { }

	[Address(RVA = "0x1EEF610", Offset = "0x1EEEA10", Length = "0xA3")]
	[Token(Token = "0x6001B1C")]
	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EEF6C0", Offset = "0x1EEEAC0", Length = "0x11D")]
	[Token(Token = "0x6001B1A")]
	public MarshalByRefObject GetServerObject() { }

	[Address(RVA = "0x1EEF7E0", Offset = "0x1EEEBE0", Length = "0x8D")]
	[Token(Token = "0x6001B1B")]
	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

