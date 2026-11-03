namespace System.Runtime.Remoting;

[Token(Token = "0x200034C")]
internal abstract class Identity
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DD3")]
	protected string _objectUri; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DD4")]
	protected IMessageSink _channelSink; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DD5")]
	protected IMessageSink _envoySink; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DD6")]
	private DynamicPropertyCollection _clientDynamicProperties; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DD7")]
	private DynamicPropertyCollection _serverDynamicProperties; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DD8")]
	protected ObjRef _objRef; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000DD9")]
	private bool _disposed; //Field offset: 0x40

	[Token(Token = "0x170002C1")]
	public IMessageSink ChannelSink
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001A7F")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001A80")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002C6")]
	public DynamicPropertyCollection ClientDynamicProperties
	{
		[Address(RVA = "0x1EE1F10", Offset = "0x1EE1310", Length = "0xBC")]
		[Token(Token = "0x6001A87")]
		 get { } //Length: 188
	}

	[Token(Token = "0x170002C5")]
	public bool Disposed
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6001A85")]
		 get { } //Length: 5
		[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
		[Token(Token = "0x6001A86")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002C2")]
	public IMessageSink EnvoySink
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001A81")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002C7")]
	public bool HasServerDynamicSinks
	{
		[Address(RVA = "0x1EE1FD0", Offset = "0x1EE13D0", Length = "0x41")]
		[Token(Token = "0x6001A88")]
		 get { } //Length: 65
	}

	[Token(Token = "0x170002C4")]
	public bool IsConnected
	{
		[Address(RVA = "0x17A5210", Offset = "0x17A4610", Length = "0x9")]
		[Token(Token = "0x6001A84")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170002C3")]
	public string ObjectUri
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001A82")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6001A83")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001A7D")]
	public Identity(string objectUri) { }

	[Token(Token = "0x6001A7E")]
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001A7F")]
	public IMessageSink get_ChannelSink() { }

	[Address(RVA = "0x1EE1F10", Offset = "0x1EE1310", Length = "0xBC")]
	[Token(Token = "0x6001A87")]
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6001A85")]
	public bool get_Disposed() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001A81")]
	public IMessageSink get_EnvoySink() { }

	[Address(RVA = "0x1EE1FD0", Offset = "0x1EE13D0", Length = "0x41")]
	[Token(Token = "0x6001A88")]
	public bool get_HasServerDynamicSinks() { }

	[Address(RVA = "0x17A5210", Offset = "0x17A4610", Length = "0x9")]
	[Token(Token = "0x6001A84")]
	public bool get_IsConnected() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001A82")]
	public string get_ObjectUri() { }

	[Address(RVA = "0x1EE1DD0", Offset = "0x1EE11D0", Length = "0x91")]
	[Token(Token = "0x6001A89")]
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[Address(RVA = "0x1EE1E70", Offset = "0x1EE1270", Length = "0x91")]
	[Token(Token = "0x6001A8A")]
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001A80")]
	public void set_ChannelSink(IMessageSink value) { }

	[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
	[Token(Token = "0x6001A86")]
	public void set_Disposed(bool value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6001A83")]
	public void set_ObjectUri(string value) { }

}

