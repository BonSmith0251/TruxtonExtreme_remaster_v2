namespace System.Xml.Schema;

[Token(Token = "0x2000212")]
public class XmlSchemaException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000B5E")]
	private string res; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B5F")]
	private String[] args; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B60")]
	private string sourceUri; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B61")]
	private int lineNumber; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000B62")]
	private int linePosition; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000B63")]
	private XmlSchemaObject sourceSchemaObject; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000B64")]
	private string message; //Field offset: 0xB8

	[Token(Token = "0x170005E2")]
	internal String[] Args
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6001571")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170005E1")]
	internal string GetRes
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6001570")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170005E4")]
	public int LineNumber
	{
		[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
		[Token(Token = "0x6001573")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005E5")]
	public int LinePosition
	{
		[Address(RVA = "0x1F7B610", Offset = "0x1F7AA10", Length = "0x7")]
		[Token(Token = "0x6001574")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005E7")]
	public virtual string Message
	{
		[Address(RVA = "0x248EA10", Offset = "0x248DE10", Length = "0x19")]
		[Token(Token = "0x6001579")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170005E6")]
	public XmlSchemaObject SourceSchemaObject
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x6001575")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005E3")]
	public string SourceUri
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6001572")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x248E090", Offset = "0x248D490", Length = "0x440")]
	[Token(Token = "0x6001560")]
	protected XmlSchemaException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x248E6C0", Offset = "0x248DAC0", Length = "0xCA")]
	[Token(Token = "0x600156E")]
	internal XmlSchemaException(string res, String[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	[Address(RVA = "0x248E7B0", Offset = "0x248DBB0", Length = "0x42")]
	[Token(Token = "0x600156D")]
	internal XmlSchemaException(string res, String[] args, XmlSchemaObject source) { }

	[Address(RVA = "0x248E040", Offset = "0x248D440", Length = "0x45")]
	[Token(Token = "0x600156B")]
	internal XmlSchemaException(string res, XmlSchemaObject source) { }

	[Address(RVA = "0x248DFC0", Offset = "0x248D3C0", Length = "0x38")]
	[Token(Token = "0x600156A")]
	internal XmlSchemaException(string res, String[] args, string sourceUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x248E000", Offset = "0x248D400", Length = "0x35")]
	[Token(Token = "0x6001569")]
	internal XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x248E4E0", Offset = "0x248D8E0", Length = "0xCF")]
	[Token(Token = "0x6001568")]
	internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x248E930", Offset = "0x248DD30", Length = "0xD2")]
	[Token(Token = "0x600156C")]
	internal XmlSchemaException(string res, string arg, XmlSchemaObject source) { }

	[Address(RVA = "0x248E900", Offset = "0x248DD00", Length = "0x2A")]
	[Token(Token = "0x6001566")]
	internal XmlSchemaException(string res, String[] args) { }

	[Address(RVA = "0x248E800", Offset = "0x248DC00", Length = "0xF1")]
	[Token(Token = "0x6001565")]
	public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition) { }

	[Address(RVA = "0x248E5E0", Offset = "0x248D9E0", Length = "0x1C")]
	[Token(Token = "0x6001564")]
	public XmlSchemaException(string message, Exception innerException) { }

	[Address(RVA = "0x248E790", Offset = "0x248DB90", Length = "0x1F")]
	[Token(Token = "0x6001563")]
	public XmlSchemaException(string message) { }

	[Address(RVA = "0x248E5B0", Offset = "0x248D9B0", Length = "0x21")]
	[Token(Token = "0x6001562")]
	public XmlSchemaException() { }

	[Address(RVA = "0x248E600", Offset = "0x248DA00", Length = "0xB2")]
	[Token(Token = "0x6001567")]
	internal XmlSchemaException(string res, string arg) { }

	[Address(RVA = "0x248DD60", Offset = "0x248D160", Length = "0x49")]
	[Token(Token = "0x600156F")]
	internal static string CreateMessage(string res, String[] args) { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6001571")]
	internal String[] get_Args() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6001570")]
	internal string get_GetRes() { }

	[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
	[Token(Token = "0x6001573")]
	public int get_LineNumber() { }

	[Address(RVA = "0x1F7B610", Offset = "0x1F7AA10", Length = "0x7")]
	[Token(Token = "0x6001574")]
	public int get_LinePosition() { }

	[Address(RVA = "0x248EA10", Offset = "0x248DE10", Length = "0x19")]
	[Token(Token = "0x6001579")]
	public virtual string get_Message() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x6001575")]
	public XmlSchemaObject get_SourceSchemaObject() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6001572")]
	public string get_SourceUri() { }

	[Address(RVA = "0x248DDB0", Offset = "0x248D1B0", Length = "0x14A")]
	[Token(Token = "0x6001561")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[Token(Token = "0x6001577")]
	internal void SetSchemaObject(XmlSchemaObject source) { }

	[Address(RVA = "0x248DF50", Offset = "0x248D350", Length = "0x61")]
	[Token(Token = "0x6001578")]
	internal void SetSource(XmlSchemaObject source) { }

	[Address(RVA = "0x248DF00", Offset = "0x248D300", Length = "0x47")]
	[Token(Token = "0x6001576")]
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

}

