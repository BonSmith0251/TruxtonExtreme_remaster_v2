namespace System.Runtime.Remoting.Proxies;

[AttributeUsage(AttributeTargets::Class (4))]
[ComVisible(True)]
[Token(Token = "0x2000366")]
public class ProxyAttribute : Attribute, IContextAttribute
{

	[Address(RVA = "0x1EE57D0", Offset = "0x1EE4BD0", Length = "0x114")]
	[Token(Token = "0x6001B4D")]
	public override MarshalByRefObject CreateInstance(Type serverType) { }

	[Address(RVA = "0x1EE58F0", Offset = "0x1EE4CF0", Length = "0x50")]
	[Token(Token = "0x6001B4E")]
	public override RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[ComVisible(True)]
	[Token(Token = "0x6001B4F")]
	public override void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[ComVisible(True)]
	[Token(Token = "0x6001B50")]
	public override bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }

}

