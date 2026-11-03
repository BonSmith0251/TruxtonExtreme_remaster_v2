namespace System.Xml;

[Token(Token = "0x200002C")]
internal interface IDtdParserAdapter
{

	[Token(Token = "0x17000034")]
	public Uri BaseUri
	{
		[Token(Token = "0x6000159")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000037")]
	public int CurrentPosition
	{
		[Token(Token = "0x600015C")]
		 get { } //Length: 0
		[Token(Token = "0x600015D")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700003B")]
	public int EntityStackLength
	{
		[Token(Token = "0x6000161")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700003C")]
	public bool IsEntityEolNormalized
	{
		[Token(Token = "0x6000162")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700003A")]
	public bool IsEof
	{
		[Token(Token = "0x6000160")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000038")]
	public int LineNo
	{
		[Token(Token = "0x600015E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000039")]
	public int LineStartPosition
	{
		[Token(Token = "0x600015F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000033")]
	public IXmlNamespaceResolver NamespaceResolver
	{
		[Token(Token = "0x6000158")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000032")]
	public XmlNameTable NameTable
	{
		[Token(Token = "0x6000157")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000035")]
	public Char[] ParsingBuffer
	{
		[Token(Token = "0x600015A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000036")]
	public int ParsingBufferLength
	{
		[Token(Token = "0x600015B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000159")]
	public Uri get_BaseUri() { }

	[Token(Token = "0x600015C")]
	public int get_CurrentPosition() { }

	[Token(Token = "0x6000161")]
	public int get_EntityStackLength() { }

	[Token(Token = "0x6000162")]
	public bool get_IsEntityEolNormalized() { }

	[Token(Token = "0x6000160")]
	public bool get_IsEof() { }

	[Token(Token = "0x600015E")]
	public int get_LineNo() { }

	[Token(Token = "0x600015F")]
	public int get_LineStartPosition() { }

	[Token(Token = "0x6000158")]
	public IXmlNamespaceResolver get_NamespaceResolver() { }

	[Token(Token = "0x6000157")]
	public XmlNameTable get_NameTable() { }

	[Token(Token = "0x600015A")]
	public Char[] get_ParsingBuffer() { }

	[Token(Token = "0x600015B")]
	public int get_ParsingBufferLength() { }

	[Token(Token = "0x6000164")]
	public void OnNewLine(int pos) { }

	[Token(Token = "0x600016E")]
	public void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	[Token(Token = "0x600016D")]
	public void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	[Token(Token = "0x6000168")]
	public void ParseComment(StringBuilder sb) { }

	[Token(Token = "0x6000166")]
	public int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	[Token(Token = "0x6000165")]
	public int ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	[Token(Token = "0x6000167")]
	public void ParsePI(StringBuilder sb) { }

	[Token(Token = "0x600016A")]
	public bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	[Token(Token = "0x6000169")]
	public bool PushEntity(IDtdEntityInfo entity, out int entityId) { }

	[Token(Token = "0x600016B")]
	public bool PushExternalSubset(string systemId, string publicId) { }

	[Token(Token = "0x600016C")]
	public void PushInternalDtd(string baseUri, string internalDtd) { }

	[Token(Token = "0x6000163")]
	public int ReadData() { }

	[Token(Token = "0x600015D")]
	public void set_CurrentPosition(int value) { }

	[Token(Token = "0x600016F")]
	public void Throw(Exception e) { }

}

