namespace System.Xml.Schema;

[Token(Token = "0x20001D4")]
internal abstract class SchemaBuilder
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001229")]
	protected SchemaBuilder() { }

	[Token(Token = "0x6001228")]
	internal abstract void EndChildren() { }

	[Token(Token = "0x6001224")]
	internal abstract bool IsContentParsed() { }

	[Token(Token = "0x6001223")]
	internal abstract void ProcessAttribute(string prefix, string name, string ns, string value) { }

	[Token(Token = "0x6001226")]
	internal abstract void ProcessCData(string value) { }

	[Token(Token = "0x6001222")]
	internal abstract bool ProcessElement(string prefix, string name, string ns) { }

	[Token(Token = "0x6001225")]
	internal abstract void ProcessMarkup(XmlNode[] markup) { }

	[Token(Token = "0x6001227")]
	internal abstract void StartChildren() { }

}

