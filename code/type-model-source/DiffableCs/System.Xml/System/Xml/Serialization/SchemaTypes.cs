namespace System.Xml.Serialization;

[Token(Token = "0x20000FD")]
internal enum SchemaTypes : int
{
	NotSet = 0,
	Primitive = 1,
	Enum = 2,
	Array = 3,
	Class = 4,
	XmlSerializable = 5,
	XmlNode = 6,
	Void = 7,
}

