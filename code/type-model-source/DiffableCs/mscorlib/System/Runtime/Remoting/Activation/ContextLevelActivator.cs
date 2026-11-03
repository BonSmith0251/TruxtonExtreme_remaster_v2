namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000394")]
internal class ContextLevelActivator : IActivator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E7E")]
	private IActivator m_NextActivator; //Field offset: 0x10

	[Token(Token = "0x17000310")]
	public override IActivator NextActivator
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001C1C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001C1B")]
	public ContextLevelActivator(IActivator next) { }

	[Address(RVA = "0x1F005F0", Offset = "0x1EFF9F0", Length = "0x20D")]
	[Token(Token = "0x6001C1D")]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001C1C")]
	public override IActivator get_NextActivator() { }

}

