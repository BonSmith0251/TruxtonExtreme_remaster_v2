namespace System.Xml.Schema;

[Flags]
[Token(Token = "0x200020F")]
public enum XmlSchemaDerivationMethod : int
{
	Empty = 0,
	Substitution = 1,
	Extension = 2,
	Restriction = 4,
	List = 8,
	Union = 16,
	All = 255,
	None = 256,
}

