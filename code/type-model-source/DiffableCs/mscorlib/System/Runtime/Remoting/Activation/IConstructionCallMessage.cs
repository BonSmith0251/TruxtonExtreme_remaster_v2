namespace System.Runtime.Remoting.Activation;

[ComVisible(True)]
[Token(Token = "0x2000396")]
public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage
{

	[Token(Token = "0x17000312")]
	public Type ActivationType
	{
		[Token(Token = "0x6001C20")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000313")]
	public string ActivationTypeName
	{
		[Token(Token = "0x6001C21")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000314")]
	public IActivator Activator
	{
		[Token(Token = "0x6001C22")]
		 get { } //Length: 0
		[Token(Token = "0x6001C23")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000315")]
	public Object[] CallSiteActivationAttributes
	{
		[Token(Token = "0x6001C24")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000316")]
	public IList ContextProperties
	{
		[Token(Token = "0x6001C25")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001C20")]
	public Type get_ActivationType() { }

	[Token(Token = "0x6001C21")]
	public string get_ActivationTypeName() { }

	[Token(Token = "0x6001C22")]
	public IActivator get_Activator() { }

	[Token(Token = "0x6001C24")]
	public Object[] get_CallSiteActivationAttributes() { }

	[Token(Token = "0x6001C25")]
	public IList get_ContextProperties() { }

	[Token(Token = "0x6001C23")]
	public void set_Activator(IActivator value) { }

}

