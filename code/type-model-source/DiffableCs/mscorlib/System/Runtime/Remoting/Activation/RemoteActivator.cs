namespace System.Runtime.Remoting.Activation;

[Token(Token = "0x2000399")]
internal class RemoteActivator : MarshalByRefObject, IActivator
{

	[Token(Token = "0x17000317")]
	public override IActivator NextActivator
	{
		[Address(RVA = "0x1F12660", Offset = "0x1F11A60", Length = "0x3E")]
		[Token(Token = "0x6001C2A")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1F12350", Offset = "0x1F11750", Length = "0x30F")]
	[Token(Token = "0x6001C29")]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	[Address(RVA = "0x1F12660", Offset = "0x1F11A60", Length = "0x3E")]
	[Token(Token = "0x6001C2A")]
	public override IActivator get_NextActivator() { }

}

