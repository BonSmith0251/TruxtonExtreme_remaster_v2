namespace System.Runtime.Remoting;

[Token(Token = "0x200034D")]
internal class ClientIdentity : Identity
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DDA")]
	private WeakReference _proxyReference; //Field offset: 0x48

	[Token(Token = "0x170002C8")]
	public MarshalByRefObject ClientProxy
	{
		[Address(RVA = "0x1EDAC30", Offset = "0x1EDA030", Length = "0x8A")]
		[Token(Token = "0x6001A8C")]
		 get { } //Length: 138
		[Address(RVA = "0x1EDACF0", Offset = "0x1EDA0F0", Length = "0x6D")]
		[Token(Token = "0x6001A8D")]
		 set { } //Length: 109
	}

	[Token(Token = "0x170002C9")]
	public string TargetUri
	{
		[Address(RVA = "0x1EDACC0", Offset = "0x1EDA0C0", Length = "0x2A")]
		[Token(Token = "0x6001A8F")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1EDAB50", Offset = "0x1ED9F50", Length = "0xD5")]
	[Token(Token = "0x6001A8B")]
	public ClientIdentity(string objectUri, ObjRef objRef) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001A8E")]
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	[Address(RVA = "0x1EDAC30", Offset = "0x1EDA030", Length = "0x8A")]
	[Token(Token = "0x6001A8C")]
	public MarshalByRefObject get_ClientProxy() { }

	[Address(RVA = "0x1EDACC0", Offset = "0x1EDA0C0", Length = "0x2A")]
	[Token(Token = "0x6001A8F")]
	public string get_TargetUri() { }

	[Address(RVA = "0x1EDACF0", Offset = "0x1EDA0F0", Length = "0x6D")]
	[Token(Token = "0x6001A8D")]
	public void set_ClientProxy(MarshalByRefObject value) { }

}

