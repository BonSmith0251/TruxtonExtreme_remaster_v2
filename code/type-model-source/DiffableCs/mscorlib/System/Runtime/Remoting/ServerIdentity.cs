namespace System.Runtime.Remoting;

[Token(Token = "0x2000358")]
internal abstract class ServerIdentity : Identity
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E0F")]
	protected Type _objectType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E10")]
	protected MarshalByRefObject _serverObject; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E11")]
	protected IMessageSink _serverSink; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E12")]
	protected Context _context; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E13")]
	protected Lease _lease; //Field offset: 0x68

	[Token(Token = "0x170002D7")]
	public Context Context
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001B0E")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6001B0F")]
		 set { } //Length: 995
	}

	[Token(Token = "0x170002D6")]
	public Lease Lease
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001B0D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002D5")]
	public Type ObjectType
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001B08")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1EEF280", Offset = "0x1EEE680", Length = "0x6B")]
	[Token(Token = "0x6001B07")]
	public ServerIdentity(string objectUri, Context context, Type objectType) { }

	[Token(Token = "0x6001B11")]
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[Address(RVA = "0x1EEEC40", Offset = "0x1EEE040", Length = "0x74")]
	[Token(Token = "0x6001B0C")]
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	[Address(RVA = "0x1EEECC0", Offset = "0x1EEE0C0", Length = "0x1EA")]
	[Token(Token = "0x6001B0B")]
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	[Address(RVA = "0x1EEEEB0", Offset = "0x1EEE2B0", Length = "0x92")]
	[Token(Token = "0x6001B12")]
	protected void DisposeServerObject() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001B0E")]
	public Context get_Context() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001B0D")]
	public Lease get_Lease() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001B08")]
	public Type get_ObjectType() { }

	[Address(RVA = "0x1EEEF50", Offset = "0x1EEE350", Length = "0x7")]
	[Token(Token = "0x6001B0A")]
	public override void OnLifetimeExpired() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6001B0F")]
	public void set_Context(Context value) { }

	[Address(RVA = "0x1EEEF60", Offset = "0x1EEE360", Length = "0x31B")]
	[Token(Token = "0x6001B09")]
	public void StartTrackingLifetime(ILease lease) { }

	[Token(Token = "0x6001B10")]
	public abstract IMessage SyncObjectProcessMessage(IMessage msg) { }

}

