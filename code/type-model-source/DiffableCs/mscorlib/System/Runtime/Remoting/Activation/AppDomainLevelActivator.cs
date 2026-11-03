namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000392")]
internal class AppDomainLevelActivator : IActivator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E7C")]
	private string _activationUrl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E7D")]
	private IActivator _next; //Field offset: 0x18

	[Token(Token = "0x1700030E")]
	public override IActivator NextActivator
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001C16")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6001C15")]
	public AppDomainLevelActivator(string activationUrl, IActivator next) { }

	[Address(RVA = "0x1EF7D70", Offset = "0x1EF7170", Length = "0x2E2")]
	[Token(Token = "0x6001C17")]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001C16")]
	public override IActivator get_NextActivator() { }

}

