namespace System.Runtime.Remoting.Proxies;

[ComVisible(True)]
[Token(Token = "0x2000368")]
public abstract class RealProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E30")]
	private Type class_to_proxy; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E31")]
	internal Context _targetContext; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E32")]
	internal MarshalByRefObject _server; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E33")]
	private int _targetDomainId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E34")]
	internal string _targetUri; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E35")]
	internal Identity _objectIdentity; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E36")]
	private object _objTP; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E37")]
	private object _stubData; //Field offset: 0x48

	[Token(Token = "0x170002E6")]
	internal Identity ObjectIdentity
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001B5F")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6001B60")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x1EE6C80", Offset = "0x1EE6080", Length = "0xE")]
	[Token(Token = "0x6001B58")]
	protected RealProxy() { }

	[Address(RVA = "0x1EE6DA0", Offset = "0x1EE61A0", Length = "0xA8")]
	[Token(Token = "0x6001B59")]
	protected RealProxy(Type classToProxy) { }

	[Address(RVA = "0x1EE6BB0", Offset = "0x1EE5FB0", Length = "0xC4")]
	[Token(Token = "0x6001B5A")]
	internal RealProxy(Type classToProxy, ClientIdentity identity) { }

	[Address(RVA = "0x1EE6C90", Offset = "0x1EE6090", Length = "0x107")]
	[Token(Token = "0x6001B5B")]
	protected RealProxy(Type classToProxy, IntPtr stub, object stubData) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6001B65")]
	protected void AttachServer(MarshalByRefObject s) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001B5F")]
	internal Identity get_ObjectIdentity() { }

	[Address(RVA = "0x1EE5950", Offset = "0x1EE4D50", Length = "0x120")]
	[Token(Token = "0x6001B67")]
	internal object GetAppDomainTarget() { }

	[Address(RVA = "0x1EE5A80", Offset = "0x1EE4E80", Length = "0x6B")]
	[Token(Token = "0x6001B5E")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EE5AF0", Offset = "0x1EE4EF0", Length = "0x88")]
	[Token(Token = "0x6001B5D")]
	public Type GetProxiedType() { }

	[Address(RVA = "0x1EE5B80", Offset = "0x1EE4F80", Length = "0x12C")]
	[Token(Token = "0x6001B64")]
	public override object GetTransparentProxy() { }

	[Address(RVA = "0x1EE5CB0", Offset = "0x1EE50B0", Length = "0x5")]
	[Token(Token = "0x6001B5C")]
	private static Type InternalGetProxyType(object transparentProxy) { }

	[Address(RVA = "0x1EE5CC0", Offset = "0x1EE50C0", Length = "0x5")]
	[Token(Token = "0x6001B63")]
	internal override object InternalGetTransparentProxy(string className) { }

	[Token(Token = "0x6001B61")]
	public abstract IMessage Invoke(IMessage msg) { }

	[Address(RVA = "0x1EE5CD0", Offset = "0x1EE50D0", Length = "0x8A7")]
	[Token(Token = "0x6001B62")]
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out Object[] out_args) { }

	[Address(RVA = "0x1EE6580", Offset = "0x1EE5980", Length = "0x624")]
	[Token(Token = "0x6001B68")]
	private static Object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6001B60")]
	internal void set_ObjectIdentity(Identity value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6001B66")]
	internal void SetTargetDomain(int domainId) { }

}

