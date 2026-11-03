namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = False)]
[Token(Token = "0x200010D")]
public class XmlChoiceIdentifierAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400062B")]
	private string memberName; //Field offset: 0x10

	[Token(Token = "0x17000338")]
	public string MemberName
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x6000C6F")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x2560A10", Offset = "0x255FE10", Length = "0x76")]
	[Token(Token = "0x6000C70")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x6000C6F")]
	public string get_MemberName() { }

}

