namespace System.Xml;

[Token(Token = "0x2000030")]
internal interface IValidationEventHandling
{

	[Token(Token = "0x17000042")]
	public object EventHandler
	{
		[Token(Token = "0x6000177")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000177")]
	public object get_EventHandler() { }

	[Token(Token = "0x6000178")]
	public void SendEvent(Exception exception, XmlSeverityType severity) { }

}

