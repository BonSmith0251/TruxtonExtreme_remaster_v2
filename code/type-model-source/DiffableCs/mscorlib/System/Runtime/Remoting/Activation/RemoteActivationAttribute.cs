namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000398")]
internal class RemoteActivationAttribute : Attribute, IContextAttribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E7F")]
	private IList _contextProperties; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6001C26")]
	public RemoteActivationAttribute(IList contextProperties) { }

	[Address(RVA = "0x1F12040", Offset = "0x1F11440", Length = "0x300")]
	[Token(Token = "0x6001C28")]
	public override void GetPropertiesForNewContext(IConstructionCallMessage ctor) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001C27")]
	public override bool IsContextOK(Context ctx, IConstructionCallMessage ctor) { }

}

