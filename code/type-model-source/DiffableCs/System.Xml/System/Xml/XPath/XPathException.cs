namespace System.Xml.XPath;

[Token(Token = "0x20000E8")]
public class XPathException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40005B1")]
	private string res; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40005B2")]
	private String[] args; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40005B3")]
	private string message; //Field offset: 0xA0

	[Token(Token = "0x170002E5")]
	public virtual string Message
	{
		[Address(RVA = "0x254DC10", Offset = "0x254D010", Length = "0x19")]
		[Token(Token = "0x6000BAC")]
		 get { } //Length: 25
	}

	[Address(RVA = "0x254D8C0", Offset = "0x254CCC0", Length = "0x2B3")]
	[Token(Token = "0x6000BA2")]
	protected XPathException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x254D800", Offset = "0x254CC00", Length = "0xB3")]
	[Token(Token = "0x6000BA4")]
	public XPathException() { }

	[Address(RVA = "0x254D740", Offset = "0x254CB40", Length = "0xB2")]
	[Token(Token = "0x6000BA5")]
	public XPathException(string message, Exception innerException) { }

	[Address(RVA = "0x254D720", Offset = "0x254CB20", Length = "0x1A")]
	[Token(Token = "0x6000BA9")]
	private XPathException(string res, String[] args) { }

	[Address(RVA = "0x254DB80", Offset = "0x254CF80", Length = "0x86")]
	[Token(Token = "0x6000BAA")]
	private XPathException(string res, String[] args, Exception inner) { }

	[Address(RVA = "0x254D440", Offset = "0x254C840", Length = "0x60")]
	[Token(Token = "0x6000BA6")]
	internal static XPathException Create(string res) { }

	[Address(RVA = "0x254D4A0", Offset = "0x254C8A0", Length = "0xB3")]
	[Token(Token = "0x6000BA7")]
	internal static XPathException Create(string res, string arg) { }

	[Address(RVA = "0x254D560", Offset = "0x254C960", Length = "0xD6")]
	[Token(Token = "0x6000BA8")]
	internal static XPathException Create(string res, string arg, string arg2) { }

	[Address(RVA = "0x254D390", Offset = "0x254C790", Length = "0xAF")]
	[Token(Token = "0x6000BAB")]
	private static string CreateMessage(string res, String[] args) { }

	[Address(RVA = "0x254DC10", Offset = "0x254D010", Length = "0x19")]
	[Token(Token = "0x6000BAC")]
	public virtual string get_Message() { }

	[Address(RVA = "0x254D640", Offset = "0x254CA40", Length = "0xD7")]
	[Token(Token = "0x6000BA3")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

