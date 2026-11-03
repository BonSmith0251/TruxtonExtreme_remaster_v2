namespace System.Runtime.Remoting.Activation;

[ComVisible(True)]
[Token(Token = "0x2000395")]
public interface IActivator
{

	[Token(Token = "0x17000311")]
	public IActivator NextActivator
	{
		[Token(Token = "0x6001C1E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001C1F")]
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	[Token(Token = "0x6001C1E")]
	public IActivator get_NextActivator() { }

}

