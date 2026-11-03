namespace System.Runtime.Remoting;

[Token(Token = "0x2000359")]
internal class ClientActivatedIdentity : ServerIdentity
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000E14")]
	private MarshalByRefObject _targetThis; //Field offset: 0x70

	[Address(RVA = "0x1EDAAE0", Offset = "0x1ED9EE0", Length = "0x61")]
	[Token(Token = "0x6001B13")]
	public ClientActivatedIdentity(string objectUri, Type objectType) { }

	[Address(RVA = "0x1EDA920", Offset = "0x1ED9D20", Length = "0xB2")]
	[Token(Token = "0x6001B18")]
	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001B14")]
	public MarshalByRefObject GetServerObject() { }

	[Address(RVA = "0x1EDA9E0", Offset = "0x1ED9DE0", Length = "0x53")]
	[Token(Token = "0x6001B16")]
	public virtual void OnLifetimeExpired() { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x6001B15")]
	public void SetClientProxy(MarshalByRefObject obj) { }

	[Address(RVA = "0x1EDAA40", Offset = "0x1ED9E40", Length = "0x9C")]
	[Token(Token = "0x6001B17")]
	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

