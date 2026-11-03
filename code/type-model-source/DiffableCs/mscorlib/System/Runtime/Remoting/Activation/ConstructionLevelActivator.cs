namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000393")]
internal class ConstructionLevelActivator : IActivator
{

	[Token(Token = "0x1700030F")]
	public override IActivator NextActivator
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001C18")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001C1A")]
	public ConstructionLevelActivator() { }

	[Address(RVA = "0x1F00310", Offset = "0x1EFF710", Length = "0xA2")]
	[Token(Token = "0x6001C19")]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001C18")]
	public override IActivator get_NextActivator() { }

}

