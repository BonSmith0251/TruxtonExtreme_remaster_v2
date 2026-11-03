namespace System.Runtime.Remoting.Proxies;

[Token(Token = "0x2000369")]
internal class RemotingProxy : RealProxy, IRemotingTypeInfo
{
	[Token(Token = "0x4000E38")]
	private static MethodInfo _cache_GetTypeMethod; //Field offset: 0x0
	[Token(Token = "0x4000E39")]
	private static MethodInfo _cache_GetHashCodeMethod; //Field offset: 0x8
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E3A")]
	private IMessageSink _sink; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E3B")]
	private bool _hasEnvoySink; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E3C")]
	private ConstructionCall _ctorCall; //Field offset: 0x60

	[Token(Token = "0x170002E7")]
	public override string TypeName
	{
		[Address(RVA = "0x1EEA3B0", Offset = "0x1EE97B0", Length = "0x11E")]
		[Token(Token = "0x6001B6E")]
		 get { } //Length: 286
	}

	[Address(RVA = "0x1EEA0A0", Offset = "0x1EE94A0", Length = "0x102")]
	[Token(Token = "0x6001B71")]
	private static RemotingProxy() { }

	[Address(RVA = "0x1EEA1B0", Offset = "0x1EE95B0", Length = "0x10E")]
	[Token(Token = "0x6001B69")]
	internal RemotingProxy(Type type, ClientIdentity identity) { }

	[Address(RVA = "0x1EEA2C0", Offset = "0x1EE96C0", Length = "0xE6")]
	[Token(Token = "0x6001B6A")]
	internal RemotingProxy(Type type, string activationUrl, Object[] activationAttributes) { }

	[Address(RVA = "0x1EE9370", Offset = "0x1EE8770", Length = "0xDD")]
	[Token(Token = "0x6001B6D")]
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	[Address(RVA = "0x1EE9450", Offset = "0x1EE8850", Length = "0x2EF")]
	[Token(Token = "0x6001B6C")]
	internal void AttachIdentity(Identity identity) { }

	[Address(RVA = "0x1EE9740", Offset = "0x1EE8B40", Length = "0x26E")]
	[Token(Token = "0x6001B6F")]
	public override bool CanCastTo(Type fromType, object o) { }

	[Address(RVA = "0x1EE99B0", Offset = "0x1EE8DB0", Length = "0xD5")]
	[Token(Token = "0x6001B70")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1EEA3B0", Offset = "0x1EE97B0", Length = "0x11E")]
	[Token(Token = "0x6001B6E")]
	public override string get_TypeName() { }

	[Address(RVA = "0x1EE9A90", Offset = "0x1EE8E90", Length = "0x600")]
	[Token(Token = "0x6001B6B")]
	public virtual IMessage Invoke(IMessage request) { }

}

