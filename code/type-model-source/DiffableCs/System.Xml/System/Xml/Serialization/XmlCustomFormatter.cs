namespace System.Xml.Serialization;

[Token(Token = "0x200010E")]
internal class XmlCustomFormatter
{
	[Token(Token = "0x400062C")]
	private static String[] allTimeFormats; //Field offset: 0x0

	[Address(RVA = "0x2562490", Offset = "0x2561890", Length = "0x4B6")]
	[Token(Token = "0x6000C76")]
	private static XmlCustomFormatter() { }

	[Address(RVA = "0x2560A90", Offset = "0x255FE90", Length = "0x30D")]
	[Token(Token = "0x6000C71")]
	internal static string FromEnum(long value, String[] values, Int64[] ids, string typeName) { }

	[Address(RVA = "0x2560DF0", Offset = "0x25601F0", Length = "0x49")]
	[Token(Token = "0x6000C72")]
	internal static string FromXmlName(string name) { }

	[Address(RVA = "0x2560DA0", Offset = "0x25601A0", Length = "0x49")]
	[Token(Token = "0x6000C73")]
	internal static string FromXmlNCName(string ncName) { }

	[Address(RVA = "0x2560E40", Offset = "0x2560240", Length = "0x971")]
	[Token(Token = "0x6000C75")]
	internal static object FromXmlString(TypeData type, string value) { }

	[Address(RVA = "0x25617C0", Offset = "0x2560BC0", Length = "0xCC2")]
	[Token(Token = "0x6000C74")]
	internal static string ToXmlString(TypeData type, object value) { }

}

