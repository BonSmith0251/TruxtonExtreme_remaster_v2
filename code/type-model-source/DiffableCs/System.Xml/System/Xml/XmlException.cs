namespace System.Xml;

[Token(Token = "0x20000DA")]
public class XmlException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000574")]
	private string res; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000575")]
	private String[] args; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000576")]
	private int lineNumber; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000577")]
	private int linePosition; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[OptionalField]
	[Token(Token = "0x4000578")]
	private string sourceUri; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000579")]
	private string message; //Field offset: 0xB0

	[Token(Token = "0x170002D8")]
	public int LineNumber
	{
		[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
		[Token(Token = "0x6000B61")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170002D9")]
	public int LinePosition
	{
		[Address(RVA = "0x240F970", Offset = "0x240ED70", Length = "0x7")]
		[Token(Token = "0x6000B62")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170002DA")]
	public virtual string Message
	{
		[Address(RVA = "0x255AFF0", Offset = "0x255A3F0", Length = "0x19")]
		[Token(Token = "0x6000B63")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170002DB")]
	internal string ResString
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000B64")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x255A270", Offset = "0x2559670", Length = "0x48D")]
	[Token(Token = "0x6000B49")]
	protected XmlException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x255AC30", Offset = "0x255A030", Length = "0xCE")]
	[Token(Token = "0x6000B5B")]
	internal XmlException(string res, String[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	[Address(RVA = "0x255A760", Offset = "0x2559B60", Length = "0x2A")]
	[Token(Token = "0x6000B5A")]
	internal XmlException(string res, String[] args, Exception innerException, int lineNumber, int linePosition) { }

	[Address(RVA = "0x255A9B0", Offset = "0x2559DB0", Length = "0x31")]
	[Token(Token = "0x6000B59")]
	internal XmlException(string res, String[] args, int lineNumber, int linePosition, string sourceUri) { }

	[Address(RVA = "0x255A860", Offset = "0x2559C60", Length = "0x2A")]
	[Token(Token = "0x6000B58")]
	internal XmlException(string res, String[] args, int lineNumber, int linePosition) { }

	[Address(RVA = "0x255A790", Offset = "0x2559B90", Length = "0xC7")]
	[Token(Token = "0x6000B57")]
	internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	[Address(RVA = "0x255AF30", Offset = "0x255A330", Length = "0xC0")]
	[Token(Token = "0x6000B55")]
	internal XmlException(string res, String[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	[Address(RVA = "0x255AD00", Offset = "0x255A100", Length = "0xBD")]
	[Token(Token = "0x6000B54")]
	internal XmlException(string res, String[] args, IXmlLineInfo lineInfo) { }

	[Address(RVA = "0x255A890", Offset = "0x2559C90", Length = "0x11B")]
	[Token(Token = "0x6000B53")]
	internal XmlException(string res, string arg, IXmlLineInfo lineInfo) { }

	[Address(RVA = "0x255A170", Offset = "0x2559570", Length = "0xC0")]
	[Token(Token = "0x6000B56")]
	internal XmlException(string res, string arg, int lineNumber, int linePosition) { }

	[Address(RVA = "0x255AE80", Offset = "0x255A280", Length = "0xAD")]
	[Token(Token = "0x6000B51")]
	internal XmlException(string res, string arg) { }

	[Address(RVA = "0x255AC00", Offset = "0x255A000", Length = "0x25")]
	[Token(Token = "0x6000B50")]
	internal XmlException(string res, String[] args) { }

	[Address(RVA = "0x255A9F0", Offset = "0x2559DF0", Length = "0x206")]
	[Token(Token = "0x6000B4F")]
	internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	[Address(RVA = "0x255A140", Offset = "0x2559540", Length = "0x22")]
	[Token(Token = "0x6000B4E")]
	public XmlException(string message, Exception innerException, int lineNumber, int linePosition) { }

	[Address(RVA = "0x255A240", Offset = "0x2559640", Length = "0x21")]
	[Token(Token = "0x6000B4D")]
	public XmlException(string message, Exception innerException) { }

	[Address(RVA = "0x255A700", Offset = "0x2559B00", Length = "0x24")]
	[Token(Token = "0x6000B4C")]
	public XmlException(string message) { }

	[Address(RVA = "0x255A730", Offset = "0x2559B30", Length = "0x26")]
	[Token(Token = "0x6000B4B")]
	public XmlException() { }

	[Address(RVA = "0x255ADC0", Offset = "0x255A1C0", Length = "0xBC")]
	[Token(Token = "0x6000B52")]
	internal XmlException(string res, string arg, string sourceUri) { }

	[Address(RVA = "0x25599C0", Offset = "0x2558DC0", Length = "0x62")]
	[Token(Token = "0x6000B5E")]
	internal static String[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	[Address(RVA = "0x2559CC0", Offset = "0x25590C0", Length = "0x5D")]
	[Token(Token = "0x6000B5F")]
	internal static String[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	[Address(RVA = "0x2559A30", Offset = "0x2558E30", Length = "0x287")]
	[Token(Token = "0x6000B60")]
	internal static String[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	[Address(RVA = "0x2559D20", Offset = "0x2559120", Length = "0x1B1")]
	[Token(Token = "0x6000B5D")]
	private static string CreateMessage(string res, String[] args, int lineNumber, int linePosition) { }

	[Address(RVA = "0x2559EE0", Offset = "0x25592E0", Length = "0x10E")]
	[Token(Token = "0x6000B5C")]
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
	[Token(Token = "0x6000B61")]
	public int get_LineNumber() { }

	[Address(RVA = "0x240F970", Offset = "0x240ED70", Length = "0x7")]
	[Token(Token = "0x6000B62")]
	public int get_LinePosition() { }

	[Address(RVA = "0x255AFF0", Offset = "0x255A3F0", Length = "0x19")]
	[Token(Token = "0x6000B63")]
	public virtual string get_Message() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000B64")]
	internal string get_ResString() { }

	[Address(RVA = "0x2559FF0", Offset = "0x25593F0", Length = "0x14A")]
	[Token(Token = "0x6000B4A")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

