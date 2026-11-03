namespace System.Xml;

[Token(Token = "0x200002B")]
internal interface IDtdParser
{

	[Token(Token = "0x6000156")]
	public IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	[Token(Token = "0x6000155")]
	public IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

}

