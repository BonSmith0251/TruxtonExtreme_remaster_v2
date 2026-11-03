namespace System.Data;

[Token(Token = "0x2000094")]
internal class XMLSchema
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600078F")]
	public XMLSchema() { }

	[Address(RVA = "0x23574B0", Offset = "0x23568B0", Length = "0x8D")]
	[Token(Token = "0x600078C")]
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	[Address(RVA = "0x2357540", Offset = "0x2356940", Length = "0x126")]
	[Token(Token = "0x600078E")]
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	[Address(RVA = "0x2357670", Offset = "0x2356A70", Length = "0x13B")]
	[Token(Token = "0x600078D")]
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	[Address(RVA = "0x23577B0", Offset = "0x2356BB0", Length = "0x49")]
	[Token(Token = "0x600078A")]
	internal static TypeConverter GetConverter(Type type) { }

	[Address(RVA = "0x2357800", Offset = "0x2356C00", Length = "0x3F7")]
	[Token(Token = "0x600078B")]
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

}

