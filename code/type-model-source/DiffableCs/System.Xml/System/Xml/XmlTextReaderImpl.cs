namespace System.Xml;

[Token(Token = "0x2000056")]
internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	[Token(Token = "0x2000063")]
	private class DtdDefaultAttributeInfoToNodeDataComparer : IComparer<Object>
	{
		[Token(Token = "0x400029C")]
		private static IComparer<Object> s_instance; //Field offset: 0x0

		[Token(Token = "0x17000130")]
		internal static IComparer<Object> Instance
		{
			[Address(RVA = "0x24FDAE0", Offset = "0x24FCEE0", Length = "0x4E")]
			[Token(Token = "0x6000540")]
			internal get { } //Length: 78
		}

		[Address(RVA = "0x24FDA70", Offset = "0x24FCE70", Length = "0x67")]
		[Token(Token = "0x6000543")]
		private static DtdDefaultAttributeInfoToNodeDataComparer() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000542")]
		public DtdDefaultAttributeInfoToNodeDataComparer() { }

		[Address(RVA = "0x24FD800", Offset = "0x24FCC00", Length = "0x26D")]
		[Token(Token = "0x6000541")]
		public override int Compare(object x, object y) { }

		[Address(RVA = "0x24FDAE0", Offset = "0x24FCEE0", Length = "0x4E")]
		[Token(Token = "0x6000540")]
		internal static IComparer<Object> get_Instance() { }

	}

	[Token(Token = "0x2000061")]
	public class DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000287")]
		private XmlTextReaderImpl reader; //Field offset: 0x10

		[Token(Token = "0x1700011B")]
		private override Uri System.Xml.IDtdParserAdapter.BaseUri
		{
			[Address(RVA = "0x24EA7C0", Offset = "0x24E9BC0", Length = "0x1D")]
			[Token(Token = "0x6000509")]
			private get { } //Length: 29
		}

		[Token(Token = "0x1700011F")]
		private override int System.Xml.IDtdParserAdapter.CurrentPosition
		{
			[Address(RVA = "0x24EA7E0", Offset = "0x24E9BE0", Length = "0x1D")]
			[Token(Token = "0x600050D")]
			private get { } //Length: 29
			[Address(RVA = "0x24EA920", Offset = "0x24E9D20", Length = "0x1E")]
			[Token(Token = "0x600050E")]
			private set { } //Length: 30
		}

		[Token(Token = "0x17000120")]
		private override int System.Xml.IDtdParserAdapter.EntityStackLength
		{
			[Address(RVA = "0x24EA800", Offset = "0x24E9C00", Length = "0x1D")]
			[Token(Token = "0x600050F")]
			private get { } //Length: 29
		}

		[Token(Token = "0x17000121")]
		private override bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized
		{
			[Address(RVA = "0x24EA820", Offset = "0x24E9C20", Length = "0x1D")]
			[Token(Token = "0x6000510")]
			private get { } //Length: 29
		}

		[Token(Token = "0x1700011C")]
		private override bool System.Xml.IDtdParserAdapter.IsEof
		{
			[Address(RVA = "0x24EA840", Offset = "0x24E9C40", Length = "0x1D")]
			[Token(Token = "0x600050A")]
			private get { } //Length: 29
		}

		[Token(Token = "0x17000122")]
		private override int System.Xml.IDtdParserAdapter.LineNo
		{
			[Address(RVA = "0x24EA860", Offset = "0x24E9C60", Length = "0x1D")]
			[Token(Token = "0x6000512")]
			private get { } //Length: 29
		}

		[Token(Token = "0x17000123")]
		private override int System.Xml.IDtdParserAdapter.LineStartPosition
		{
			[Address(RVA = "0x24EA880", Offset = "0x24E9C80", Length = "0x1D")]
			[Token(Token = "0x6000513")]
			private get { } //Length: 29
		}

		[Token(Token = "0x1700011A")]
		private override IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver
		{
			[Address(RVA = "0x24EA8C0", Offset = "0x24E9CC0", Length = "0x1E")]
			[Token(Token = "0x6000508")]
			private get { } //Length: 30
		}

		[Token(Token = "0x17000119")]
		private override XmlNameTable System.Xml.IDtdParserAdapter.NameTable
		{
			[Address(RVA = "0x24EA8A0", Offset = "0x24E9CA0", Length = "0x1E")]
			[Token(Token = "0x6000507")]
			private get { } //Length: 30
		}

		[Token(Token = "0x1700011D")]
		private override Char[] System.Xml.IDtdParserAdapter.ParsingBuffer
		{
			[Address(RVA = "0x24EA900", Offset = "0x24E9D00", Length = "0x1D")]
			[Token(Token = "0x600050B")]
			private get { } //Length: 29
		}

		[Token(Token = "0x1700011E")]
		private override int System.Xml.IDtdParserAdapter.ParsingBufferLength
		{
			[Address(RVA = "0x24EA8E0", Offset = "0x24E9CE0", Length = "0x1D")]
			[Token(Token = "0x600050C")]
			private get { } //Length: 29
		}

		[Token(Token = "0x17000127")]
		private override bool System.Xml.IDtdParserAdapterV1.Namespaces
		{
			[Address(RVA = "0x24EA560", Offset = "0x24E9960", Length = "0x1E")]
			[Token(Token = "0x6000523")]
			private get { } //Length: 30
		}

		[Token(Token = "0x17000126")]
		private override bool System.Xml.IDtdParserAdapterV1.Normalization
		{
			[Address(RVA = "0x24EA580", Offset = "0x24E9980", Length = "0x1E")]
			[Token(Token = "0x6000522")]
			private get { } //Length: 30
		}

		[Token(Token = "0x17000128")]
		private override bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode
		{
			[Address(RVA = "0x24EA5A0", Offset = "0x24E99A0", Length = "0x1E")]
			[Token(Token = "0x6000524")]
			private get { } //Length: 30
		}

		[Token(Token = "0x17000124")]
		private override bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation
		{
			[Address(RVA = "0x24EA5C0", Offset = "0x24E99C0", Length = "0x1D")]
			[Token(Token = "0x6000520")]
			private get { } //Length: 29
		}

		[Token(Token = "0x17000125")]
		private override IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling
		{
			[Address(RVA = "0x24EA5E0", Offset = "0x24E99E0", Length = "0x1E")]
			[Token(Token = "0x6000521")]
			private get { } //Length: 30
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000506")]
		internal DtdParserProxy(XmlTextReaderImpl reader) { }

		[Address(RVA = "0x24EA7C0", Offset = "0x24E9BC0", Length = "0x1D")]
		[Token(Token = "0x6000509")]
		private override Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

		[Address(RVA = "0x24EA7E0", Offset = "0x24E9BE0", Length = "0x1D")]
		[Token(Token = "0x600050D")]
		private override int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

		[Address(RVA = "0x24EA800", Offset = "0x24E9C00", Length = "0x1D")]
		[Token(Token = "0x600050F")]
		private override int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

		[Address(RVA = "0x24EA820", Offset = "0x24E9C20", Length = "0x1D")]
		[Token(Token = "0x6000510")]
		private override bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

		[Address(RVA = "0x24EA840", Offset = "0x24E9C40", Length = "0x1D")]
		[Token(Token = "0x600050A")]
		private override bool System.Xml.IDtdParserAdapter.get_IsEof() { }

		[Address(RVA = "0x24EA860", Offset = "0x24E9C60", Length = "0x1D")]
		[Token(Token = "0x6000512")]
		private override int System.Xml.IDtdParserAdapter.get_LineNo() { }

		[Address(RVA = "0x24EA880", Offset = "0x24E9C80", Length = "0x1D")]
		[Token(Token = "0x6000513")]
		private override int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

		[Address(RVA = "0x24EA8C0", Offset = "0x24E9CC0", Length = "0x1E")]
		[Token(Token = "0x6000508")]
		private override IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

		[Address(RVA = "0x24EA8A0", Offset = "0x24E9CA0", Length = "0x1E")]
		[Token(Token = "0x6000507")]
		private override XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

		[Address(RVA = "0x24EA900", Offset = "0x24E9D00", Length = "0x1D")]
		[Token(Token = "0x600050B")]
		private override Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

		[Address(RVA = "0x24EA8E0", Offset = "0x24E9CE0", Length = "0x1D")]
		[Token(Token = "0x600050C")]
		private override int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

		[Address(RVA = "0x24EA600", Offset = "0x24E9A00", Length = "0x1E")]
		[Token(Token = "0x6000511")]
		private override void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

		[Address(RVA = "0x24EA620", Offset = "0x24E9A20", Length = "0x24")]
		[Token(Token = "0x600051F")]
		private override void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

		[Address(RVA = "0x24EA650", Offset = "0x24E9A50", Length = "0x24")]
		[Token(Token = "0x600051E")]
		private override void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

		[Address(RVA = "0x24EA680", Offset = "0x24E9A80", Length = "0x1E")]
		[Token(Token = "0x6000518")]
		private override void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

		[Address(RVA = "0x24EA6A0", Offset = "0x24E9AA0", Length = "0x1E")]
		[Token(Token = "0x6000516")]
		private override int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

		[Address(RVA = "0x24EA6C0", Offset = "0x24E9AC0", Length = "0x1E")]
		[Token(Token = "0x6000515")]
		private override int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

		[Address(RVA = "0x24EA6E0", Offset = "0x24E9AE0", Length = "0x1E")]
		[Token(Token = "0x6000517")]
		private override void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

		[Address(RVA = "0x24EA700", Offset = "0x24E9B00", Length = "0x1E")]
		[Token(Token = "0x600051A")]
		private override bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

		[Address(RVA = "0x24EA720", Offset = "0x24E9B20", Length = "0x1E")]
		[Token(Token = "0x6000519")]
		private override bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

		[Address(RVA = "0x24EA740", Offset = "0x24E9B40", Length = "0x1E")]
		[Token(Token = "0x600051B")]
		private override bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

		[Address(RVA = "0x24EA760", Offset = "0x24E9B60", Length = "0x1E")]
		[Token(Token = "0x600051C")]
		private override void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

		[Address(RVA = "0x24EA780", Offset = "0x24E9B80", Length = "0x1D")]
		[Token(Token = "0x6000514")]
		private override int System.Xml.IDtdParserAdapter.ReadData() { }

		[Address(RVA = "0x24EA920", Offset = "0x24E9D20", Length = "0x1E")]
		[Token(Token = "0x600050E")]
		private override void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

		[Address(RVA = "0x24EA7A0", Offset = "0x24E9BA0", Length = "0x1E")]
		[Token(Token = "0x600051D")]
		private override void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

		[Address(RVA = "0x24EA560", Offset = "0x24E9960", Length = "0x1E")]
		[Token(Token = "0x6000523")]
		private override bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

		[Address(RVA = "0x24EA580", Offset = "0x24E9980", Length = "0x1E")]
		[Token(Token = "0x6000522")]
		private override bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

		[Address(RVA = "0x24EA5A0", Offset = "0x24E99A0", Length = "0x1E")]
		[Token(Token = "0x6000524")]
		private override bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

		[Address(RVA = "0x24EA5C0", Offset = "0x24E99C0", Length = "0x1D")]
		[Token(Token = "0x6000520")]
		private override bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

		[Address(RVA = "0x24EA5E0", Offset = "0x24E99E0", Length = "0x1E")]
		[Token(Token = "0x6000521")]
		private override IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	}

	[Token(Token = "0x200005A")]
	private enum EntityExpandType : int
	{
		All = 0,
		OnlyGeneral = 1,
		OnlyCharacter = 2,
	}

	[Token(Token = "0x2000059")]
	private enum EntityType : int
	{
		CharacterDec = 0,
		CharacterHex = 1,
		CharacterNamed = 2,
		Expanded = 3,
		Skipped = 4,
		FakeExpanded = 5,
		Unexpanded = 6,
		ExpandedInAttribute = 7,
	}

	[Token(Token = "0x200005B")]
	private enum IncrementalReadState : int
	{
		Text = 0,
		StartTag = 1,
		PI = 2,
		CDATA = 3,
		Comment = 4,
		Attributes = 5,
		AttributeValue = 6,
		ReadData = 7,
		EndElement = 8,
		End = 9,
		ReadValueChunk_OnCachedValue = 10,
		ReadValueChunk_OnPartialValue = 11,
		ReadContentAsBinary_OnCachedValue = 12,
		ReadContentAsBinary_OnPartialValue = 13,
		ReadContentAsBinary_End = 14,
	}

	[Token(Token = "0x200005D")]
	private enum InitInputType : int
	{
		UriString = 0,
		Stream = 1,
		TextReader = 2,
		Invalid = 3,
	}

	[Token(Token = "0x200005C")]
	private class LaterInitParam
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400025F")]
		public bool useAsync; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000260")]
		public Stream inputStream; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000261")]
		public Byte[] inputBytes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000262")]
		public int inputByteCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000263")]
		public Uri inputbaseUri; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000264")]
		public string inputUriStr; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000265")]
		public XmlResolver inputUriResolver; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000266")]
		public XmlParserContext inputContext; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000267")]
		public TextReader inputTextReader; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000268")]
		public InitInputType initType; //Field offset: 0x58

		[Address(RVA = "0x24EB0F0", Offset = "0x24EA4F0", Length = "0xE")]
		[Token(Token = "0x60004F5")]
		public LaterInitParam() { }

	}

	[Token(Token = "0x2000062")]
	private class NodeData : IComparable
	{
		[Token(Token = "0x4000288")]
		private static NodeData s_None; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000289")]
		internal XmlNodeType type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400028A")]
		internal string localName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400028B")]
		internal string prefix; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400028C")]
		internal string ns; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400028D")]
		internal string nameWPrefix; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400028E")]
		private string value; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400028F")]
		private Char[] chars; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000290")]
		private int valueStartPos; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000291")]
		private int valueLength; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000292")]
		internal LineInfo lineInfo; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000293")]
		internal LineInfo lineInfo2; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000294")]
		internal char quoteChar; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4000295")]
		internal int depth; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000296")]
		private bool isEmptyOrDefault; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000297")]
		internal int entityId; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000298")]
		internal bool xmlContextPushed; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000299")]
		internal NodeData nextAttrValueChunk; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400029A")]
		internal object schemaType; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400029B")]
		internal object typedValue; //Field offset: 0x88

		[Token(Token = "0x1700012D")]
		internal bool IsDefaultAttribute
		{
			[Address(RVA = "0x24EB940", Offset = "0x24EAD40", Length = "0xE")]
			[Token(Token = "0x600052B")]
			internal get { } //Length: 14
			[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
			[Token(Token = "0x600052C")]
			internal set { } //Length: 4
		}

		[Token(Token = "0x1700012C")]
		internal bool IsEmptyElement
		{
			[Address(RVA = "0x24EB950", Offset = "0x24EAD50", Length = "0xE")]
			[Token(Token = "0x6000529")]
			internal get { } //Length: 14
			[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
			[Token(Token = "0x600052A")]
			internal set { } //Length: 4
		}

		[Token(Token = "0x1700012A")]
		internal int LineNo
		{
			[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
			[Token(Token = "0x6000527")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x1700012B")]
		internal int LinePos
		{
			[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
			[Token(Token = "0x6000528")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x17000129")]
		internal static NodeData None
		{
			[Address(RVA = "0x24EB960", Offset = "0x24EAD60", Length = "0x12F")]
			[Token(Token = "0x6000525")]
			internal get { } //Length: 303
		}

		[Token(Token = "0x1700012F")]
		internal string StringValue
		{
			[Address(RVA = "0x24EBA90", Offset = "0x24EAE90", Length = "0x50")]
			[Token(Token = "0x600052E")]
			internal get { } //Length: 80
		}

		[Token(Token = "0x1700012E")]
		internal bool ValueBuffered
		{
			[Address(RVA = "0x24EBAE0", Offset = "0x24EAEE0", Length = "0x9")]
			[Token(Token = "0x600052D")]
			internal get { } //Length: 9
		}

		[Address(RVA = "0x24EB8A0", Offset = "0x24EACA0", Length = "0xA0")]
		[Token(Token = "0x6000526")]
		internal NodeData() { }

		[Address(RVA = "0x24EB190", Offset = "0x24EA590", Length = "0x8D")]
		[Token(Token = "0x6000530")]
		internal void Clear(XmlNodeType type) { }

		[Address(RVA = "0x24EB100", Offset = "0x24EA500", Length = "0x86")]
		[Token(Token = "0x6000531")]
		internal void ClearName() { }

		[Address(RVA = "0x24EB220", Offset = "0x24EA620", Length = "0x6C")]
		[Token(Token = "0x600053C")]
		internal int CopyTo(int valueOffset, Char[] buffer, int offset, int length) { }

		[Address(RVA = "0x24EB290", Offset = "0x24EA690", Length = "0x89")]
		[Token(Token = "0x600053B")]
		internal void CopyTo(int valueOffset, StringBuilder sb) { }

		[Address(RVA = "0x24EB320", Offset = "0x24EA720", Length = "0x97")]
		[Token(Token = "0x600053E")]
		internal string CreateNameWPrefix(XmlNameTable nt) { }

		[Address(RVA = "0x24EB940", Offset = "0x24EAD40", Length = "0xE")]
		[Token(Token = "0x600052B")]
		internal bool get_IsDefaultAttribute() { }

		[Address(RVA = "0x24EB950", Offset = "0x24EAD50", Length = "0xE")]
		[Token(Token = "0x6000529")]
		internal bool get_IsEmptyElement() { }

		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x6000527")]
		internal int get_LineNo() { }

		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x6000528")]
		internal int get_LinePos() { }

		[Address(RVA = "0x24EB960", Offset = "0x24EAD60", Length = "0x12F")]
		[Token(Token = "0x6000525")]
		internal static NodeData get_None() { }

		[Address(RVA = "0x24EBA90", Offset = "0x24EAE90", Length = "0x50")]
		[Token(Token = "0x600052E")]
		internal string get_StringValue() { }

		[Address(RVA = "0x24EBAE0", Offset = "0x24EAEE0", Length = "0x9")]
		[Token(Token = "0x600052D")]
		internal bool get_ValueBuffered() { }

		[Address(RVA = "0x24EB3C0", Offset = "0x24EA7C0", Length = "0xB1")]
		[Token(Token = "0x600053D")]
		internal string GetNameWPrefix(XmlNameTable nt) { }

		[Address(RVA = "0x24EB480", Offset = "0x24EA880", Length = "0x56")]
		[Token(Token = "0x600053A")]
		internal void OnBufferInvalidated() { }

		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[Token(Token = "0x600052C")]
		internal void set_IsDefaultAttribute(bool value) { }

		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[Token(Token = "0x600052A")]
		internal void set_IsEmptyElement(bool value) { }

		[Address(RVA = "0x24EB4F0", Offset = "0x24EA8F0", Length = "0xC")]
		[Token(Token = "0x6000532")]
		internal void SetLineInfo(int lineNo, int linePos) { }

		[Address(RVA = "0x24EB4E0", Offset = "0x24EA8E0", Length = "0xC")]
		[Token(Token = "0x6000533")]
		internal void SetLineInfo2(int lineNo, int linePos) { }

		[Address(RVA = "0x24EB5B0", Offset = "0x24EA9B0", Length = "0x93")]
		[Token(Token = "0x6000537")]
		internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

		[Address(RVA = "0x24EB500", Offset = "0x24EA900", Length = "0xAC")]
		[Token(Token = "0x6000536")]
		internal void SetNamedNode(XmlNodeType type, string localName) { }

		[Address(RVA = "0x24EB6F0", Offset = "0x24EAAF0", Length = "0x14")]
		[Token(Token = "0x6000538")]
		internal void SetValue(string value) { }

		[Address(RVA = "0x24EB710", Offset = "0x24EAB10", Length = "0x5E")]
		[Token(Token = "0x6000539")]
		internal void SetValue(Char[] chars, int startPos, int len) { }

		[Address(RVA = "0x24EB690", Offset = "0x24EAA90", Length = "0x5F")]
		[Token(Token = "0x6000535")]
		internal void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

		[Address(RVA = "0x24EB650", Offset = "0x24EAA50", Length = "0x3C")]
		[Token(Token = "0x6000534")]
		internal void SetValueNode(XmlNodeType type, string value) { }

		[Address(RVA = "0x24EB770", Offset = "0x24EAB70", Length = "0xD6")]
		[Token(Token = "0x600053F")]
		private override int System.IComparable.CompareTo(object obj) { }

		[Address(RVA = "0x24EB850", Offset = "0x24EAC50", Length = "0x48")]
		[Token(Token = "0x600052F")]
		internal void TrimSpacesInValue() { }

	}

	[Token(Token = "0x2000060")]
	private class NoNamespaceManager : XmlNamespaceManager
	{

		[Token(Token = "0x17000118")]
		public virtual string DefaultNamespace
		{
			[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
			[Token(Token = "0x60004FD")]
			 get { } //Length: 18
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60004FC")]
		public NoNamespaceManager() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000500")]
		public virtual void AddNamespace(string prefix, string uri) { }

		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x60004FD")]
		public virtual string get_DefaultNamespace() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000502")]
		public virtual IEnumerator GetEnumerator() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000503")]
		public virtual IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000504")]
		public virtual string LookupNamespace(string prefix) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000505")]
		public virtual string LookupPrefix(string uri) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60004FF")]
		public virtual bool PopScope() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60004FE")]
		public virtual void PushScope() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000501")]
		public virtual void RemoveNamespace(string prefix, string uri) { }

	}

	[Token(Token = "0x2000064")]
	public sealed class OnDefaultAttributeUseDelegate : MulticastDelegate
	{

		[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
		[Token(Token = "0x6000544")]
		public OnDefaultAttributeUseDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000545")]
		public override void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	}

	[Token(Token = "0x2000057")]
	private enum ParsingFunction : int
	{
		ElementContent = 0,
		NoData = 1,
		OpenUrl = 2,
		SwitchToInteractive = 3,
		SwitchToInteractiveXmlDecl = 4,
		DocumentContent = 5,
		MoveToElementContent = 6,
		PopElementContext = 7,
		PopEmptyElementContext = 8,
		ResetAttributesRootLevel = 9,
		Error = 10,
		Eof = 11,
		ReaderClosed = 12,
		EntityReference = 13,
		InIncrementalRead = 14,
		FragmentAttribute = 15,
		ReportEndEntity = 16,
		AfterResolveEntityInContent = 17,
		AfterResolveEmptyEntityInContent = 18,
		XmlDeclarationFragment = 19,
		GoToEof = 20,
		PartialTextValue = 21,
		InReadAttributeValue = 22,
		InReadValueChunk = 23,
		InReadContentAsBinary = 24,
		InReadElementContentAsBinary = 25,
	}

	[Token(Token = "0x2000058")]
	private enum ParsingMode : int
	{
		Full = 0,
		SkipNode = 1,
		SkipContent = 2,
	}

	[Token(Token = "0x200005E")]
	private struct ParsingState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026E")]
		internal Char[] chars; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400026F")]
		internal int charPos; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000270")]
		internal int charsUsed; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000271")]
		internal Encoding encoding; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000272")]
		internal bool appendMode; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000273")]
		internal Stream stream; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000274")]
		internal Decoder decoder; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000275")]
		internal Byte[] bytes; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000276")]
		internal int bytePos; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000277")]
		internal int bytesUsed; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000278")]
		internal TextReader textReader; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000279")]
		internal int lineNo; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x400027A")]
		internal int lineStartPos; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400027B")]
		internal string baseUriStr; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400027C")]
		internal Uri baseUri; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400027D")]
		internal bool isEof; //Field offset: 0x60
		[FieldOffset(Offset = "0x61")]
		[Token(Token = "0x400027E")]
		internal bool isStreamEof; //Field offset: 0x61
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400027F")]
		internal IDtdEntityInfo entity; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000280")]
		internal int entityId; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4000281")]
		internal bool eolNormalized; //Field offset: 0x74
		[FieldOffset(Offset = "0x75")]
		[Token(Token = "0x4000282")]
		internal bool entityResolvedManually; //Field offset: 0x75

		[Token(Token = "0x17000116")]
		internal int LineNo
		{
			[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
			[Token(Token = "0x60004F8")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x17000117")]
		internal int LinePos
		{
			[Address(RVA = "0x24EBC10", Offset = "0x24EB010", Length = "0x7")]
			[Token(Token = "0x60004F9")]
			internal get { } //Length: 7
		}

		[Address(RVA = "0x24EBAF0", Offset = "0x24EAEF0", Length = "0xBC")]
		[Token(Token = "0x60004F6")]
		internal void Clear() { }

		[Address(RVA = "0x24EBBB0", Offset = "0x24EAFB0", Length = "0x5D")]
		[Token(Token = "0x60004F7")]
		internal void Close(bool closeInput) { }

		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60004F8")]
		internal int get_LineNo() { }

		[Address(RVA = "0x24EBC10", Offset = "0x24EB010", Length = "0x7")]
		[Token(Token = "0x60004F9")]
		internal int get_LinePos() { }

	}

	[Token(Token = "0x200005F")]
	private class XmlContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000283")]
		internal XmlSpace xmlSpace; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000284")]
		internal string xmlLang; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000285")]
		internal string defaultNamespace; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000286")]
		internal XmlContext previousContext; //Field offset: 0x28

		[Address(RVA = "0x24F0D40", Offset = "0x24F0140", Length = "0x6B")]
		[Token(Token = "0x60004FA")]
		internal XmlContext() { }

		[Address(RVA = "0x24F0DB0", Offset = "0x24F01B0", Length = "0x63")]
		[Token(Token = "0x60004FB")]
		internal XmlContext(XmlContext previousContext) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D6")]
	private readonly bool useAsync; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D7")]
	private LaterInitParam laterInitParam; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D8")]
	private XmlCharType xmlCharType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D9")]
	private ParsingState ps; //Field offset: 0x28
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001DA")]
	private ParsingFunction parsingFunction; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40001DB")]
	private ParsingFunction nextParsingFunction; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40001DC")]
	private ParsingFunction nextNextParsingFunction; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001DD")]
	private NodeData[] nodes; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001DE")]
	private NodeData curNode; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001DF")]
	private int index; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40001E0")]
	private int curAttrIndex; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40001E1")]
	private int attrCount; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40001E2")]
	private int attrHashtable; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40001E3")]
	private int attrDuplWalkCount; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40001E4")]
	private bool attrNeedNamespaceLookup; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD5")]
	[Token(Token = "0x40001E5")]
	private bool fullAttrCleanup; //Field offset: 0xD5
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40001E6")]
	private NodeData[] attrDuplSortingArray; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40001E7")]
	private XmlNameTable nameTable; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40001E8")]
	private bool nameTableFromSettings; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40001E9")]
	private XmlResolver xmlResolver; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40001EA")]
	private string url; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40001EB")]
	private bool normalize; //Field offset: 0x100
	[FieldOffset(Offset = "0x101")]
	[Token(Token = "0x40001EC")]
	private bool supportNamespaces; //Field offset: 0x101
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x40001ED")]
	private WhitespaceHandling whitespaceHandling; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40001EE")]
	private DtdProcessing dtdProcessing; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x40001EF")]
	private EntityHandling entityHandling; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40001F0")]
	private bool ignorePIs; //Field offset: 0x110
	[FieldOffset(Offset = "0x111")]
	[Token(Token = "0x40001F1")]
	private bool ignoreComments; //Field offset: 0x111
	[FieldOffset(Offset = "0x112")]
	[Token(Token = "0x40001F2")]
	private bool checkCharacters; //Field offset: 0x112
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40001F3")]
	private int lineNumberOffset; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40001F4")]
	private int linePositionOffset; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40001F5")]
	private bool closeInput; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40001F6")]
	private long maxCharactersInDocument; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001F7")]
	private long maxCharactersFromEntities; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40001F8")]
	private bool v1Compat; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40001F9")]
	private XmlNamespaceManager namespaceManager; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40001FA")]
	private string lastPrefix; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40001FB")]
	private XmlContext xmlContext; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40001FC")]
	private ParsingState[] parsingStatesStack; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40001FD")]
	private int parsingStatesStackTop; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40001FE")]
	private string reportedBaseUri; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40001FF")]
	private Encoding reportedEncoding; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000200")]
	private IDtdInfo dtdInfo; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000201")]
	private XmlNodeType fragmentType; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000202")]
	private XmlParserContext fragmentParserContext; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000203")]
	private bool fragment; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000204")]
	private IncrementalReadDecoder incReadDecoder; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000205")]
	private IncrementalReadState incReadState; //Field offset: 0x198
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4000206")]
	private LineInfo incReadLineInfo; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4000207")]
	private int incReadDepth; //Field offset: 0x1A4
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000208")]
	private int incReadLeftStartPos; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x4000209")]
	private int incReadLeftEndPos; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400020A")]
	private int attributeValueBaseEntityId; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x400020B")]
	private bool emptyEntityInAttributeResolved; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400020C")]
	private IValidationEventHandling validationEventHandling; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400020D")]
	private OnDefaultAttributeUseDelegate onDefaultAttributeUse; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400020E")]
	private bool validatingReaderCompatFlag; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1C9")]
	[Token(Token = "0x400020F")]
	private bool addDefaultAttributesAndNormalize; //Field offset: 0x1C9
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000210")]
	private StringBuilder stringBuilder; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000211")]
	private bool rootElementParsed; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1D9")]
	[Token(Token = "0x4000212")]
	private bool standalone; //Field offset: 0x1D9
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000213")]
	private int nextEntityId; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000214")]
	private ParsingMode parsingMode; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x4000215")]
	private ReadState readState; //Field offset: 0x1E4
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000216")]
	private IDtdEntityInfo lastEntity; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000217")]
	private bool afterResetState; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4000218")]
	private int documentStartBytePos; //Field offset: 0x1F4
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000219")]
	private int readValueOffset; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400021A")]
	private long charactersInDocument; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400021B")]
	private long charactersFromEntities; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400021C")]
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400021D")]
	private bool disableUndeclaredEntityCheck; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400021E")]
	private XmlReader outerReader; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400021F")]
	private bool xmlResolverIsSet; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000220")]
	private string Xml; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000221")]
	private string XmlNs; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000222")]
	private Task<Tuple`4<Int32, Int32, Int32, Boolean>> parseText_dummyTask; //Field offset: 0x240

	[Token(Token = "0x170000EC")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
		[Token(Token = "0x6000408")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000E2")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x1D4E410", Offset = "0x1D4D810", Length = "0x8")]
		[Token(Token = "0x60003FE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000EE")]
	public virtual bool CanReadValueChunk
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600041B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000EB")]
	public virtual bool CanResolveEntity
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000407")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000E1")]
	public virtual int Depth
	{
		[Address(RVA = "0x2424BD0", Offset = "0x2423FD0", Length = "0x1D")]
		[Token(Token = "0x60003FD")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000115")]
	internal bool DisableUndeclaredEntityCheck
	{
		[Address(RVA = "0x24252E0", Offset = "0x24246E0", Length = "0x7")]
		[Token(Token = "0x60004EE")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700010B")]
	internal virtual IDtdInfo DtdInfo
	{
		[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
		[Token(Token = "0x60004DD")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000FD")]
	internal Uri DtdParserProxy_BaseUri
	{
		[Address(RVA = "0x2424BF0", Offset = "0x2423FF0", Length = "0xC1")]
		[Token(Token = "0x6000433")]
		internal get { } //Length: 193
	}

	[Token(Token = "0x17000101")]
	internal int DtdParserProxy_CurrentPosition
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000437")]
		internal get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6000438")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000F9")]
	internal bool DtdParserProxy_DtdValidation
	{
		[Address(RVA = "0x2424CC0", Offset = "0x24240C0", Length = "0xC")]
		[Token(Token = "0x600042F")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x17000102")]
	internal int DtdParserProxy_EntityStackLength
	{
		[Address(RVA = "0x2424CD0", Offset = "0x24240D0", Length = "0x9")]
		[Token(Token = "0x6000439")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x17000103")]
	internal bool DtdParserProxy_IsEntityEolNormalized
	{
		[Address(RVA = "0x2424CE0", Offset = "0x24240E0", Length = "0x8")]
		[Token(Token = "0x600043A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000FE")]
	internal bool DtdParserProxy_IsEof
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[Token(Token = "0x6000434")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000105")]
	internal int DtdParserProxy_LineNo
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x600043D")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000106")]
	internal int DtdParserProxy_LineStartPosition
	{
		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[Token(Token = "0x600043E")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170000F8")]
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[Token(Token = "0x600042E")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000FB")]
	internal bool DtdParserProxy_Namespaces
	{
		[Address(RVA = "0x2424D00", Offset = "0x2424100", Length = "0x8")]
		[Token(Token = "0x6000431")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000F7")]
	internal XmlNameTable DtdParserProxy_NameTable
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x600042D")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000FA")]
	internal bool DtdParserProxy_Normalization
	{
		[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
		[Token(Token = "0x6000430")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000FF")]
	internal Char[] DtdParserProxy_ParsingBuffer
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000435")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000100")]
	internal int DtdParserProxy_ParsingBufferLength
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000436")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170000FC")]
	internal bool DtdParserProxy_V1CompatibilityMode
	{
		[Address(RVA = "0x2424D10", Offset = "0x2424110", Length = "0x8")]
		[Token(Token = "0x6000432")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000104")]
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling
	{
		[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
		[Token(Token = "0x600043B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000109")]
	private bool DtdValidation
	{
		[Address(RVA = "0x2424CC0", Offset = "0x24240C0", Length = "0xC")]
		[Token(Token = "0x6000462")]
		private get { } //Length: 12
	}

	[Token(Token = "0x170000F4")]
	internal EntityHandling EntityHandling
	{
		[Address(RVA = "0x24252F0", Offset = "0x24246F0", Length = "0x85")]
		[Token(Token = "0x600042A")]
		internal set { } //Length: 133
	}

	[Token(Token = "0x170000E9")]
	public virtual bool EOF
	{
		[Address(RVA = "0x2424D30", Offset = "0x2424130", Length = "0xB")]
		[Token(Token = "0x6000405")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700010F")]
	internal XmlNodeType FragmentType
	{
		[Address(RVA = "0x2424D40", Offset = "0x2424140", Length = "0x7")]
		[Token(Token = "0x60004E2")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000108")]
	private bool InAttributeValueIterator
	{
		[Address(RVA = "0x2424D50", Offset = "0x2424150", Length = "0x17")]
		[Token(Token = "0x6000460")]
		private get { } //Length: 23
	}

	[Token(Token = "0x1700010A")]
	private bool InEntity
	{
		[Address(RVA = "0x2424D70", Offset = "0x2424170", Length = "0xC")]
		[Token(Token = "0x6000497")]
		private get { } //Length: 12
	}

	[Token(Token = "0x17000110")]
	internal object InternalSchemaType
	{
		[Address(RVA = "0x2425380", Offset = "0x2424780", Length = "0x29")]
		[Token(Token = "0x60004E5")]
		internal set { } //Length: 41
	}

	[Token(Token = "0x17000111")]
	internal object InternalTypedValue
	{
		[Address(RVA = "0x2424D80", Offset = "0x2424180", Length = "0x21")]
		[Token(Token = "0x60004E6")]
		internal get { } //Length: 33
		[Address(RVA = "0x24253B0", Offset = "0x24247B0", Length = "0x2C")]
		[Token(Token = "0x60004E7")]
		internal set { } //Length: 44
	}

	[Token(Token = "0x170000E4")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x2424DB0", Offset = "0x24241B0", Length = "0x20")]
		[Token(Token = "0x6000400")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170000E3")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x2424DE0", Offset = "0x24241E0", Length = "0x20")]
		[Token(Token = "0x60003FF")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000107")]
	private bool IsResolverNull
	{
		[Address(RVA = "0x2424E10", Offset = "0x2424210", Length = "0x3C")]
		[Token(Token = "0x6000444")]
		private get { } //Length: 60
	}

	[Token(Token = "0x170000F5")]
	internal bool IsResolverSet
	{
		[Address(RVA = "0x2424E50", Offset = "0x2424250", Length = "0x8")]
		[Token(Token = "0x600042B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000EF")]
	public override int LineNumber
	{
		[Address(RVA = "0x2424E60", Offset = "0x2424260", Length = "0x20")]
		[Token(Token = "0x600041E")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170000F0")]
	public override int LinePosition
	{
		[Address(RVA = "0x2424E90", Offset = "0x2424290", Length = "0x20")]
		[Token(Token = "0x600041F")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170000DD")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2424EC0", Offset = "0x24242C0", Length = "0x1E")]
		[Token(Token = "0x60003F9")]
		 get { } //Length: 30
	}

	[Token(Token = "0x170000DC")]
	public virtual string Name
	{
		[Address(RVA = "0x2424EE0", Offset = "0x24242E0", Length = "0x2B")]
		[Token(Token = "0x60003F8")]
		 get { } //Length: 43
	}

	[Token(Token = "0x17000113")]
	internal virtual XmlNamespaceManager NamespaceManager
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[Token(Token = "0x60004E9")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000F1")]
	internal bool Namespaces
	{
		[Address(RVA = "0x2424D00", Offset = "0x2424100", Length = "0x8")]
		[Token(Token = "0x6000425")]
		internal get { } //Length: 8
		[Address(RVA = "0x24253E0", Offset = "0x24247E0", Length = "0x248")]
		[Token(Token = "0x6000426")]
		internal set { } //Length: 584
	}

	[Token(Token = "0x170000DE")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x2424F10", Offset = "0x2424310", Length = "0x1E")]
		[Token(Token = "0x60003FA")]
		 get { } //Length: 30
	}

	[Token(Token = "0x170000EA")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x6000406")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000DB")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2424F30", Offset = "0x2424330", Length = "0x1D")]
		[Token(Token = "0x60003F7")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170000F2")]
	internal bool Normalization
	{
		[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
		[Token(Token = "0x6000427")]
		internal get { } //Length: 8
		[Address(RVA = "0x2425630", Offset = "0x2424A30", Length = "0xCD")]
		[Token(Token = "0x6000428")]
		internal set { } //Length: 205
	}

	[Token(Token = "0x1700010D")]
	internal OnDefaultAttributeUseDelegate OnDefaultAttributeUse
	{
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[Token(Token = "0x60004E0")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170000ED")]
	internal XmlReader OuterReader
	{
		[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
		[Token(Token = "0x6000418")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170000DF")]
	public virtual string Prefix
	{
		[Address(RVA = "0x2424F50", Offset = "0x2424350", Length = "0x1E")]
		[Token(Token = "0x60003FB")]
		 get { } //Length: 30
	}

	[Token(Token = "0x170000E5")]
	public virtual char QuoteChar
	{
		[Address(RVA = "0x2424F70", Offset = "0x2424370", Length = "0x2E")]
		[Token(Token = "0x6000401")]
		 get { } //Length: 46
	}

	[Token(Token = "0x170000E8")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x2424FA0", Offset = "0x24243A0", Length = "0x7")]
		[Token(Token = "0x6000404")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000DA")]
	public virtual XmlReaderSettings Settings
	{
		[Address(RVA = "0x2424FB0", Offset = "0x24243B0", Length = "0x183")]
		[Token(Token = "0x60003F6")]
		 get { } //Length: 387
	}

	[Token(Token = "0x17000112")]
	internal bool StandAlone
	{
		[Address(RVA = "0x2425140", Offset = "0x2424540", Length = "0x8")]
		[Token(Token = "0x60004E8")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000114")]
	internal bool V1Compat
	{
		[Address(RVA = "0x2424D10", Offset = "0x2424110", Length = "0x8")]
		[Token(Token = "0x60004EA")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700010C")]
	internal IValidationEventHandling ValidationEventHandling
	{
		[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
		[Token(Token = "0x60004DF")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170000E0")]
	public virtual string Value
	{
		[Address(RVA = "0x2425150", Offset = "0x2424550", Length = "0x145")]
		[Token(Token = "0x60003FC")]
		 get { } //Length: 325
	}

	[Token(Token = "0x170000F3")]
	internal WhitespaceHandling WhitespaceHandling
	{
		[Address(RVA = "0x2425740", Offset = "0x2424B40", Length = "0xD9")]
		[Token(Token = "0x6000429")]
		internal set { } //Length: 217
	}

	[Token(Token = "0x170000E7")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x24252A0", Offset = "0x24246A0", Length = "0x1E")]
		[Token(Token = "0x6000403")]
		 get { } //Length: 30
	}

	[Token(Token = "0x170000F6")]
	internal XmlResolver XmlResolver
	{
		[Address(RVA = "0x2425820", Offset = "0x2424C20", Length = "0xB1")]
		[Token(Token = "0x600042C")]
		internal set { } //Length: 177
	}

	[Token(Token = "0x170000E6")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x24252C0", Offset = "0x24246C0", Length = "0x1D")]
		[Token(Token = "0x6000402")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700010E")]
	internal bool XmlValidatingReaderCompatibilityMode
	{
		[Address(RVA = "0x24258E0", Offset = "0x2424CE0", Length = "0x28E")]
		[Token(Token = "0x60004E1")]
		internal set { } //Length: 654
	}

	[Address(RVA = "0x2423AE0", Offset = "0x2422EE0", Length = "0x48B")]
	[Token(Token = "0x60003E7")]
	internal XmlTextReaderImpl(XmlNameTable nt) { }

	[Address(RVA = "0x2424830", Offset = "0x2423C30", Length = "0x9D")]
	[Token(Token = "0x60003F5")]
	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	[Address(RVA = "0x24248D0", Offset = "0x2423CD0", Length = "0x2FD")]
	[Token(Token = "0x60003F1")]
	internal XmlTextReaderImpl(Stream stream, Byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	[Address(RVA = "0x2423F70", Offset = "0x2423370", Length = "0x140")]
	[Token(Token = "0x60003EF")]
	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context) { }

	[Address(RVA = "0x24235D0", Offset = "0x24229D0", Length = "0x129")]
	[Token(Token = "0x60003EE")]
	internal XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	[Address(RVA = "0x24239E0", Offset = "0x2422DE0", Length = "0xFE")]
	[Token(Token = "0x60003ED")]
	internal XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt) { }

	[Address(RVA = "0x2423700", Offset = "0x2422B00", Length = "0x145")]
	[Token(Token = "0x60003F3")]
	internal XmlTextReaderImpl(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	[Address(RVA = "0x2424690", Offset = "0x2423A90", Length = "0x8F")]
	[Token(Token = "0x60003EB")]
	internal XmlTextReaderImpl(TextReader input) { }

	[Address(RVA = "0x2424720", Offset = "0x2423B20", Length = "0x10C")]
	[Token(Token = "0x60003EA")]
	internal XmlTextReaderImpl(string url, Stream input, XmlNameTable nt) { }

	[Address(RVA = "0x2423850", Offset = "0x2422C50", Length = "0x14C")]
	[Token(Token = "0x60003E9")]
	internal XmlTextReaderImpl(Stream input) { }

	[Address(RVA = "0x24240C0", Offset = "0x24234C0", Length = "0x5C6")]
	[Token(Token = "0x60003E8")]
	private XmlTextReaderImpl(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	[Address(RVA = "0x24239A0", Offset = "0x2422DA0", Length = "0x31")]
	[Token(Token = "0x60003EC")]
	internal XmlTextReaderImpl(TextReader input, XmlNameTable nt) { }

	[Address(RVA = "0x240FCA0", Offset = "0x240F0A0", Length = "0x16B")]
	[Token(Token = "0x60004B6")]
	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	[Address(RVA = "0x240FA90", Offset = "0x240EE90", Length = "0x20E")]
	[Token(Token = "0x60004B5")]
	private NodeData AddAttribute(int endNamePos, int colonPos) { }

	[Address(RVA = "0x240F980", Offset = "0x240ED80", Length = "0x70")]
	[Token(Token = "0x600048A")]
	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, ref NodeData lastChunk) { }

	[Address(RVA = "0x240FA00", Offset = "0x240EE00", Length = "0x8C")]
	[Token(Token = "0x60004B4")]
	private NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	[Address(RVA = "0x240FE10", Offset = "0x240F210", Length = "0x595")]
	[Token(Token = "0x60004EB")]
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	[Address(RVA = "0x24103B0", Offset = "0x240F7B0", Length = "0x2BE")]
	[Token(Token = "0x60004ED")]
	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	[Address(RVA = "0x2410670", Offset = "0x240FA70", Length = "0x2A0")]
	[Token(Token = "0x60004EC")]
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	[Address(RVA = "0x2410920", Offset = "0x240FD20", Length = "0x623")]
	[Token(Token = "0x600047F")]
	private void AddDefaultAttributesAndNormalize() { }

	[Address(RVA = "0x2410F50", Offset = "0x2410350", Length = "0x266")]
	[Token(Token = "0x60004BB")]
	private void AddNamespace(string prefix, string uri, NodeData attr) { }

	[Address(RVA = "0x24111C0", Offset = "0x24105C0", Length = "0x1A4")]
	[Token(Token = "0x60004B2")]
	private NodeData AddNode(int nodeIndex, int nodeDepth) { }

	[Address(RVA = "0x2411370", Offset = "0x2410770", Length = "0x179")]
	[Token(Token = "0x60004B3")]
	private NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	[Address(RVA = "0x24114F0", Offset = "0x24108F0", Length = "0x423")]
	[Token(Token = "0x6000485")]
	private void AttributeDuplCheck() { }

	[Address(RVA = "0x2411920", Offset = "0x2410D20", Length = "0xC5")]
	[Token(Token = "0x6000484")]
	private void AttributeNamespaceLookup() { }

	[Address(RVA = "0x24119F0", Offset = "0x2410DF0", Length = "0xE")]
	[Token(Token = "0x60004F4")]
	internal static void BlockCopy(Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count) { }

	[Address(RVA = "0x20D94B0", Offset = "0x20D88B0", Length = "0x1D")]
	[Token(Token = "0x60004F3")]
	internal static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	[Address(RVA = "0x2411A00", Offset = "0x2410E00", Length = "0x1D")]
	[Token(Token = "0x60004E3")]
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	[Address(RVA = "0x2411A20", Offset = "0x2410E20", Length = "0x34E")]
	[Token(Token = "0x6000472")]
	private Encoding CheckEncoding(string newEncodingName) { }

	[Address(RVA = "0x2411D70", Offset = "0x2411170", Length = "0xED")]
	[Token(Token = "0x6000478")]
	internal void Close(bool closeInput) { }

	[Address(RVA = "0x2411E60", Offset = "0x2411260", Length = "0xF7")]
	[Token(Token = "0x6000413")]
	public virtual void Close() { }

	[Address(RVA = "0x2411F60", Offset = "0x2411360", Length = "0x1FB")]
	[Token(Token = "0x600046F")]
	private Encoding DetectEncoding() { }

	[Address(RVA = "0x2412160", Offset = "0x2411560", Length = "0xA")]
	[Token(Token = "0x600043C")]
	internal void DtdParserProxy_OnNewLine(int pos) { }

	[Address(RVA = "0x2412170", Offset = "0x2411570", Length = "0xE7")]
	[Token(Token = "0x600044C")]
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	[Address(RVA = "0x2412260", Offset = "0x2411660", Length = "0xE7")]
	[Token(Token = "0x600044B")]
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	[Address(RVA = "0x2412350", Offset = "0x2411750", Length = "0x3BF")]
	[Token(Token = "0x6000443")]
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	[Address(RVA = "0x2412710", Offset = "0x2411B10", Length = "0x8")]
	[Token(Token = "0x6000441")]
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	[Address(RVA = "0x2412720", Offset = "0x2411B20", Length = "0xAC")]
	[Token(Token = "0x6000440")]
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	[Address(RVA = "0x24127D0", Offset = "0x2411BD0", Length = "0x48")]
	[Token(Token = "0x6000442")]
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	[Address(RVA = "0x2412820", Offset = "0x2411C20", Length = "0x71")]
	[Token(Token = "0x6000447")]
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	[Address(RVA = "0x24128A0", Offset = "0x2411CA0", Length = "0xC8")]
	[Token(Token = "0x6000446")]
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	[Address(RVA = "0x2412970", Offset = "0x2411D70", Length = "0x171")]
	[Token(Token = "0x6000448")]
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	[Address(RVA = "0x2412AF0", Offset = "0x2411EF0", Length = "0x96")]
	[Token(Token = "0x6000449")]
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	[Address(RVA = "0x2412B90", Offset = "0x2411F90", Length = "0x7")]
	[Token(Token = "0x600043F")]
	internal int DtdParserProxy_ReadData() { }

	[Address(RVA = "0x2412BA0", Offset = "0x2411FA0", Length = "0xC")]
	[Token(Token = "0x600044A")]
	internal void DtdParserProxy_Throw(Exception e) { }

	[Address(RVA = "0x2412BB0", Offset = "0x2411FB0", Length = "0x235")]
	[Token(Token = "0x60004A7")]
	private int EatWhitespaces(StringBuilder sb) { }

	[Address(RVA = "0x2412DF0", Offset = "0x24121F0", Length = "0x81")]
	[Token(Token = "0x6000483")]
	private void ElementNamespaceLookup() { }

	[Address(RVA = "0x2412E80", Offset = "0x2412280", Length = "0x178")]
	[Token(Token = "0x6000461")]
	private void FinishAttributeValueIterator() { }

	[Address(RVA = "0x2413000", Offset = "0x2412400", Length = "0x85")]
	[Token(Token = "0x60004CC")]
	private void FinishIncrementalRead() { }

	[Address(RVA = "0x24135A0", Offset = "0x24129A0", Length = "0x49")]
	[Token(Token = "0x6000411")]
	private void FinishInit() { }

	[Address(RVA = "0x2413090", Offset = "0x2412490", Length = "0xD5")]
	[Token(Token = "0x60003F2")]
	private void FinishInitStream() { }

	[Address(RVA = "0x2413170", Offset = "0x2412570", Length = "0x9D")]
	[Token(Token = "0x60003F4")]
	private void FinishInitTextReader() { }

	[Address(RVA = "0x2413210", Offset = "0x2412610", Length = "0x38B")]
	[Token(Token = "0x60003F0")]
	private void FinishInitUriString() { }

	[Address(RVA = "0x24135F0", Offset = "0x24129F0", Length = "0x120")]
	[Token(Token = "0x600048E")]
	private void FinishOtherValueIterator() { }

	[Address(RVA = "0x2413720", Offset = "0x2412B20", Length = "0x130")]
	[Token(Token = "0x600048D")]
	private void FinishPartialValue() { }

	[Address(RVA = "0x2413860", Offset = "0x2412C60", Length = "0x118")]
	[Token(Token = "0x6000491")]
	private void FinishReadContentAsBinary() { }

	[Address(RVA = "0x24139C0", Offset = "0x2412DC0", Length = "0xC3")]
	[Token(Token = "0x6000492")]
	private void FinishReadElementContentAsBinary() { }

	[Address(RVA = "0x2413A90", Offset = "0x2412E90", Length = "0x33")]
	[Token(Token = "0x6000490")]
	private void FinishReadValueChunk() { }

	[Address(RVA = "0x2413AD0", Offset = "0x2412ED0", Length = "0xB6")]
	[Token(Token = "0x60004BD")]
	private void FullAttributeCleanup() { }

	[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
	[Token(Token = "0x6000408")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x1D4E410", Offset = "0x1D4D810", Length = "0x8")]
	[Token(Token = "0x60003FE")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600041B")]
	public virtual bool get_CanReadValueChunk() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000407")]
	public virtual bool get_CanResolveEntity() { }

	[Address(RVA = "0x2424BD0", Offset = "0x2423FD0", Length = "0x1D")]
	[Token(Token = "0x60003FD")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
	[Token(Token = "0x60004DD")]
	internal virtual IDtdInfo get_DtdInfo() { }

	[Address(RVA = "0x2424BF0", Offset = "0x2423FF0", Length = "0xC1")]
	[Token(Token = "0x6000433")]
	internal Uri get_DtdParserProxy_BaseUri() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000437")]
	internal int get_DtdParserProxy_CurrentPosition() { }

	[Address(RVA = "0x2424CC0", Offset = "0x24240C0", Length = "0xC")]
	[Token(Token = "0x600042F")]
	internal bool get_DtdParserProxy_DtdValidation() { }

	[Address(RVA = "0x2424CD0", Offset = "0x24240D0", Length = "0x9")]
	[Token(Token = "0x6000439")]
	internal int get_DtdParserProxy_EntityStackLength() { }

	[Address(RVA = "0x2424CE0", Offset = "0x24240E0", Length = "0x8")]
	[Token(Token = "0x600043A")]
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[Token(Token = "0x6000434")]
	internal bool get_DtdParserProxy_IsEof() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x600043D")]
	internal int get_DtdParserProxy_LineNo() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[Token(Token = "0x600043E")]
	internal int get_DtdParserProxy_LineStartPosition() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[Token(Token = "0x600042E")]
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	[Address(RVA = "0x2424D00", Offset = "0x2424100", Length = "0x8")]
	[Token(Token = "0x6000431")]
	internal bool get_DtdParserProxy_Namespaces() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x600042D")]
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
	[Token(Token = "0x6000430")]
	internal bool get_DtdParserProxy_Normalization() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000435")]
	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000436")]
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	[Address(RVA = "0x2424D10", Offset = "0x2424110", Length = "0x8")]
	[Token(Token = "0x6000432")]
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	[Address(RVA = "0x2424D20", Offset = "0x2424120", Length = "0x8")]
	[Token(Token = "0x600043B")]
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	[Address(RVA = "0x2424CC0", Offset = "0x24240C0", Length = "0xC")]
	[Token(Token = "0x6000462")]
	private bool get_DtdValidation() { }

	[Address(RVA = "0x2424D30", Offset = "0x2424130", Length = "0xB")]
	[Token(Token = "0x6000405")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x2424D40", Offset = "0x2424140", Length = "0x7")]
	[Token(Token = "0x60004E2")]
	internal XmlNodeType get_FragmentType() { }

	[Address(RVA = "0x2424D50", Offset = "0x2424150", Length = "0x17")]
	[Token(Token = "0x6000460")]
	private bool get_InAttributeValueIterator() { }

	[Address(RVA = "0x2424D70", Offset = "0x2424170", Length = "0xC")]
	[Token(Token = "0x6000497")]
	private bool get_InEntity() { }

	[Address(RVA = "0x2424D80", Offset = "0x2424180", Length = "0x21")]
	[Token(Token = "0x60004E6")]
	internal object get_InternalTypedValue() { }

	[Address(RVA = "0x2424DB0", Offset = "0x24241B0", Length = "0x20")]
	[Token(Token = "0x6000400")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x2424DE0", Offset = "0x24241E0", Length = "0x20")]
	[Token(Token = "0x60003FF")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x2424E10", Offset = "0x2424210", Length = "0x3C")]
	[Token(Token = "0x6000444")]
	private bool get_IsResolverNull() { }

	[Address(RVA = "0x2424E50", Offset = "0x2424250", Length = "0x8")]
	[Token(Token = "0x600042B")]
	internal bool get_IsResolverSet() { }

	[Address(RVA = "0x2424E60", Offset = "0x2424260", Length = "0x20")]
	[Token(Token = "0x600041E")]
	public override int get_LineNumber() { }

	[Address(RVA = "0x2424E90", Offset = "0x2424290", Length = "0x20")]
	[Token(Token = "0x600041F")]
	public override int get_LinePosition() { }

	[Address(RVA = "0x2424EC0", Offset = "0x24242C0", Length = "0x1E")]
	[Token(Token = "0x60003F9")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2424EE0", Offset = "0x24242E0", Length = "0x2B")]
	[Token(Token = "0x60003F8")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[Token(Token = "0x60004E9")]
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	[Address(RVA = "0x2424D00", Offset = "0x2424100", Length = "0x8")]
	[Token(Token = "0x6000425")]
	internal bool get_Namespaces() { }

	[Address(RVA = "0x2424F10", Offset = "0x2424310", Length = "0x1E")]
	[Token(Token = "0x60003FA")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x6000406")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2424F30", Offset = "0x2424330", Length = "0x1D")]
	[Token(Token = "0x60003F7")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
	[Token(Token = "0x6000427")]
	internal bool get_Normalization() { }

	[Address(RVA = "0x2424F50", Offset = "0x2424350", Length = "0x1E")]
	[Token(Token = "0x60003FB")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x2424F70", Offset = "0x2424370", Length = "0x2E")]
	[Token(Token = "0x6000401")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x2424FA0", Offset = "0x24243A0", Length = "0x7")]
	[Token(Token = "0x6000404")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x2424FB0", Offset = "0x24243B0", Length = "0x183")]
	[Token(Token = "0x60003F6")]
	public virtual XmlReaderSettings get_Settings() { }

	[Address(RVA = "0x2425140", Offset = "0x2424540", Length = "0x8")]
	[Token(Token = "0x60004E8")]
	internal bool get_StandAlone() { }

	[Address(RVA = "0x2424D10", Offset = "0x2424110", Length = "0x8")]
	[Token(Token = "0x60004EA")]
	internal bool get_V1Compat() { }

	[Address(RVA = "0x2425150", Offset = "0x2424550", Length = "0x145")]
	[Token(Token = "0x60003FC")]
	public virtual string get_Value() { }

	[Address(RVA = "0x24252A0", Offset = "0x24246A0", Length = "0x1E")]
	[Token(Token = "0x6000403")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x24252C0", Offset = "0x24246C0", Length = "0x1D")]
	[Token(Token = "0x6000402")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x2413B90", Offset = "0x2412F90", Length = "0xA6")]
	[Token(Token = "0x600040B")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x2413CD0", Offset = "0x24130D0", Length = "0x18D")]
	[Token(Token = "0x600040A")]
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	[Address(RVA = "0x2413C40", Offset = "0x2413040", Length = "0x89")]
	[Token(Token = "0x6000409")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x2413E60", Offset = "0x2413260", Length = "0xDC")]
	[Token(Token = "0x6000476")]
	private int GetChars(int maxCharsCount) { }

	[Address(RVA = "0x2414030", Offset = "0x2413430", Length = "0x10F")]
	[Token(Token = "0x60004D7")]
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	[Address(RVA = "0x2413F40", Offset = "0x2413340", Length = "0xEC")]
	[Token(Token = "0x60004D8")]
	private int GetIndexOfAttributeWithPrefix(string name) { }

	[Address(RVA = "0x2414140", Offset = "0x2413540", Length = "0x2D")]
	[Token(Token = "0x6000423")]
	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x2414170", Offset = "0x2413570", Length = "0x3C")]
	[Token(Token = "0x60004E4")]
	internal XmlResolver GetResolver() { }

	[Address(RVA = "0x24141B0", Offset = "0x24135B0", Length = "0x5E")]
	[Token(Token = "0x6000445")]
	private XmlResolver GetTempResolver() { }

	[Address(RVA = "0x2414210", Offset = "0x2413610", Length = "0x57")]
	[Token(Token = "0x60004C1")]
	private XmlNodeType GetTextNodeType(int orChars) { }

	[Address(RVA = "0x2414270", Offset = "0x2413670", Length = "0x4A")]
	[Token(Token = "0x60004C0")]
	private XmlNodeType GetWhitespaceType() { }

	[Address(RVA = "0x24142C0", Offset = "0x24136C0", Length = "0x191")]
	[Token(Token = "0x6000498")]
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	[Address(RVA = "0x2414460", Offset = "0x2413860", Length = "0x28B")]
	[Token(Token = "0x6000495")]
	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, out int charRefEndPos) { }

	[Address(RVA = "0x24146F0", Offset = "0x2413AF0", Length = "0x47D")]
	[Token(Token = "0x6000496")]
	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600041D")]
	public override bool HasLineInfo() { }

	[Address(RVA = "0x2414B70", Offset = "0x2413F70", Length = "0xA40")]
	[Token(Token = "0x60004CB")]
	private int IncrementalRead() { }

	[Address(RVA = "0x24155E0", Offset = "0x24149E0", Length = "0x2BE")]
	[Token(Token = "0x600046B")]
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	[Address(RVA = "0x24158A0", Offset = "0x2414CA0", Length = "0x2A1")]
	[Token(Token = "0x6000467")]
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	[Address(RVA = "0x2415C40", Offset = "0x2415040", Length = "0x2A")]
	[Token(Token = "0x6000466")]
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	[Address(RVA = "0x2415B90", Offset = "0x2414F90", Length = "0x7B")]
	[Token(Token = "0x6000465")]
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	[Address(RVA = "0x2415C10", Offset = "0x2415010", Length = "0x2B")]
	[Token(Token = "0x6000464")]
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	[Address(RVA = "0x2415B50", Offset = "0x2414F50", Length = "0x3C")]
	[Token(Token = "0x6000463")]
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x2415C70", Offset = "0x2415070", Length = "0x113")]
	[Token(Token = "0x600046A")]
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	[Address(RVA = "0x2415D90", Offset = "0x2415190", Length = "0x1D")]
	[Token(Token = "0x6000468")]
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	[Address(RVA = "0x2415DB0", Offset = "0x24151B0", Length = "0xF9")]
	[Token(Token = "0x6000469")]
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	[Address(RVA = "0x2415EB0", Offset = "0x24152B0", Length = "0x16D")]
	[Token(Token = "0x6000477")]
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	[Address(RVA = "0x2416060", Offset = "0x2415460", Length = "0xD9")]
	[Token(Token = "0x60004BA")]
	private string LookupNamespace(NodeData node) { }

	[Address(RVA = "0x2416020", Offset = "0x2415420", Length = "0x3D")]
	[Token(Token = "0x6000415")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x2416140", Offset = "0x2415540", Length = "0x2D")]
	[Token(Token = "0x6000424")]
	internal string LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x2416170", Offset = "0x2415570", Length = "0xC7")]
	[Token(Token = "0x6000419")]
	internal void MoveOffEntityReference() { }

	[Address(RVA = "0x2416310", Offset = "0x2415710", Length = "0xD2")]
	[Token(Token = "0x600040D")]
	public virtual void MoveToAttribute(int i) { }

	[Address(RVA = "0x2416240", Offset = "0x2415640", Length = "0xC6")]
	[Token(Token = "0x600040C")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x24163F0", Offset = "0x24157F0", Length = "0x8B")]
	[Token(Token = "0x6000410")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x2416480", Offset = "0x2415880", Length = "0x7C")]
	[Token(Token = "0x600040E")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x2416500", Offset = "0x2415900", Length = "0x91")]
	[Token(Token = "0x600040F")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x24165A0", Offset = "0x24159A0", Length = "0x40")]
	[Token(Token = "0x60004DB")]
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	[Address(RVA = "0x24166B0", Offset = "0x2415AB0", Length = "0x12E")]
	[Token(Token = "0x6000486")]
	private void OnDefaultNamespaceDecl(NodeData attr) { }

	[Address(RVA = "0x24167E0", Offset = "0x2415BE0", Length = "0xCA")]
	[Token(Token = "0x60004B9")]
	private void OnEof() { }

	[Address(RVA = "0x24168B0", Offset = "0x2415CB0", Length = "0xE9")]
	[Token(Token = "0x6000487")]
	private void OnNamespaceDecl(NodeData attr) { }

	[Address(RVA = "0x2412160", Offset = "0x2411560", Length = "0xA")]
	[Token(Token = "0x60004B8")]
	private void OnNewLine(int pos) { }

	[Address(RVA = "0x24169A0", Offset = "0x2415DA0", Length = "0x221")]
	[Token(Token = "0x6000488")]
	private void OnXmlReservedAttribute(NodeData attr) { }

	[Address(RVA = "0x2416BD0", Offset = "0x2415FD0", Length = "0x294")]
	[Token(Token = "0x60004C3")]
	private bool OpenAndPush(Uri uri) { }

	[Address(RVA = "0x2417000", Offset = "0x2416400", Length = "0x32F")]
	[Token(Token = "0x600046D")]
	private void OpenUrl() { }

	[Address(RVA = "0x2416E70", Offset = "0x2416270", Length = "0x181")]
	[Token(Token = "0x600046E")]
	private void OpenUrlDelegate(object xmlResolver) { }

	[Address(RVA = "0x2418400", Offset = "0x2417800", Length = "0x666")]
	[Token(Token = "0x6000482")]
	private void ParseAttributes() { }

	[Address(RVA = "0x2417340", Offset = "0x2416740", Length = "0x5F6")]
	[Token(Token = "0x60004CE")]
	private bool ParseAttributeValueChunk() { }

	[Address(RVA = "0x2417940", Offset = "0x2416D40", Length = "0xA98")]
	[Token(Token = "0x6000489")]
	private void ParseAttributeValueSlow(int curPos, char quoteChar, NodeData attr) { }

	[Address(RVA = "0x2419060", Offset = "0x2418460", Length = "0xD")]
	[Token(Token = "0x600049F")]
	private void ParseCData() { }

	[Address(RVA = "0x2418EA0", Offset = "0x24182A0", Length = "0x1BA")]
	[Token(Token = "0x60004A0")]
	private void ParseCDataOrComment(XmlNodeType type) { }

	[Address(RVA = "0x2418A70", Offset = "0x2417E70", Length = "0x421")]
	[Token(Token = "0x60004A1")]
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	[Address(RVA = "0x2419070", Offset = "0x2418470", Length = "0x76")]
	[Token(Token = "0x60004A8")]
	private int ParseCharRefInline(int startPos, out int charCount, out EntityType entityType) { }

	[Address(RVA = "0x24190F0", Offset = "0x24184F0", Length = "0x225")]
	[Token(Token = "0x600049E")]
	private bool ParseComment() { }

	[Address(RVA = "0x2419320", Offset = "0x2418720", Length = "0x2C3")]
	[Token(Token = "0x60004A2")]
	private bool ParseDoctypeDecl() { }

	[Address(RVA = "0x24195F0", Offset = "0x24189F0", Length = "0x58A")]
	[Token(Token = "0x600047B")]
	private bool ParseDocumentContent() { }

	[Address(RVA = "0x2419D80", Offset = "0x2419180", Length = "0x2A1")]
	[Token(Token = "0x60004A3")]
	private void ParseDtd() { }

	[Address(RVA = "0x2419B80", Offset = "0x2418F80", Length = "0x1F6")]
	[Token(Token = "0x60004DA")]
	private void ParseDtdFromParserContext() { }

	[Address(RVA = "0x241A3B0", Offset = "0x24197B0", Length = "0x52F")]
	[Token(Token = "0x600047E")]
	private void ParseElement() { }

	[Address(RVA = "0x241A030", Offset = "0x2419430", Length = "0x37F")]
	[Token(Token = "0x600047C")]
	private bool ParseElementContent() { }

	[Address(RVA = "0x241A8E0", Offset = "0x2419CE0", Length = "0x40F")]
	[Token(Token = "0x6000480")]
	private void ParseEndElement() { }

	[Address(RVA = "0x241ACF0", Offset = "0x241A0F0", Length = "0xEC")]
	[Token(Token = "0x60004B1")]
	private string ParseEntityName() { }

	[Address(RVA = "0x241ADE0", Offset = "0x241A1E0", Length = "0x7C")]
	[Token(Token = "0x6000494")]
	private void ParseEntityReference() { }

	[Address(RVA = "0x241AE60", Offset = "0x241A260", Length = "0x98")]
	[Token(Token = "0x60004CD")]
	private bool ParseFragmentAttribute() { }

	[Address(RVA = "0x241AF00", Offset = "0x241A300", Length = "0x23")]
	[Token(Token = "0x60004AD")]
	private int ParseName() { }

	[Address(RVA = "0x241B240", Offset = "0x241A640", Length = "0x79")]
	[Token(Token = "0x60004AB")]
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	[Address(RVA = "0x241AF30", Offset = "0x241A330", Length = "0x30E")]
	[Token(Token = "0x60004AC")]
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	[Address(RVA = "0x241BA70", Offset = "0x241AE70", Length = "0xC0")]
	[Token(Token = "0x60004A9")]
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out EntityType entityType) { }

	[Address(RVA = "0x241B2C0", Offset = "0x241A6C0", Length = "0x7A0")]
	[Token(Token = "0x60004AA")]
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out EntityType entityType) { }

	[Address(RVA = "0x241BEC0", Offset = "0x241B2C0", Length = "0x3FB")]
	[Token(Token = "0x600049C")]
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	[Address(RVA = "0x241C2C0", Offset = "0x241B6C0", Length = "0xA")]
	[Token(Token = "0x600049B")]
	private bool ParsePI() { }

	[Address(RVA = "0x241BB40", Offset = "0x241AF40", Length = "0x371")]
	[Token(Token = "0x600049D")]
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	[Address(RVA = "0x241C2D0", Offset = "0x241B6D0", Length = "0x27F")]
	[Token(Token = "0x60004AF")]
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	[Address(RVA = "0x241C550", Offset = "0x241B950", Length = "0x1F")]
	[Token(Token = "0x60004AE")]
	private int ParseQName(out int colonPos) { }

	[Address(RVA = "0x241C570", Offset = "0x241B970", Length = "0x231")]
	[Token(Token = "0x6000493")]
	private bool ParseRootLevelWhitespace() { }

	[Address(RVA = "0x241C7B0", Offset = "0x241BBB0", Length = "0x487")]
	[Token(Token = "0x600048B")]
	private bool ParseText() { }

	[Address(RVA = "0x241CC40", Offset = "0x241C040", Length = "0x6E8")]
	[Token(Token = "0x600048C")]
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	[Address(RVA = "0x241D350", Offset = "0x241C750", Length = "0xA")]
	[Token(Token = "0x60004D4")]
	private string ParseUnexpectedToken(int pos) { }

	[Address(RVA = "0x241D360", Offset = "0x241C760", Length = "0xEE")]
	[Token(Token = "0x60004D5")]
	private string ParseUnexpectedToken() { }

	[Address(RVA = "0x241D4E0", Offset = "0x241C8E0", Length = "0xF80")]
	[Token(Token = "0x600047A")]
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	[Address(RVA = "0x241D450", Offset = "0x241C850", Length = "0x88")]
	[Token(Token = "0x60004CF")]
	private void ParseXmlDeclarationFragment() { }

	[Address(RVA = "0x241E470", Offset = "0x241D870", Length = "0x78")]
	[Token(Token = "0x60004B7")]
	private void PopElementContext() { }

	[Address(RVA = "0x241E4F0", Offset = "0x241D8F0", Length = "0x96")]
	[Token(Token = "0x60004C6")]
	private void PopEntity() { }

	[Address(RVA = "0x241E590", Offset = "0x241D990", Length = "0xC9")]
	[Token(Token = "0x60004CA")]
	private void PopParsingState() { }

	[Address(RVA = "0x241E660", Offset = "0x241DA60", Length = "0x47")]
	[Token(Token = "0x60004BF")]
	private void PopXmlContext() { }

	[Address(RVA = "0x241E6B0", Offset = "0x241DAB0", Length = "0x60")]
	[Token(Token = "0x600046C")]
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	[Address(RVA = "0x241EA60", Offset = "0x241DE60", Length = "0x200")]
	[Token(Token = "0x60004C4")]
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	[Address(RVA = "0x241E720", Offset = "0x241DB20", Length = "0x332")]
	[Token(Token = "0x60004C2")]
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	[Address(RVA = "0x241EC70", Offset = "0x241E070", Length = "0x15D")]
	[Token(Token = "0x60004C5")]
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	[Address(RVA = "0x241EDD0", Offset = "0x241E1D0", Length = "0x18E")]
	[Token(Token = "0x60004C9")]
	private void PushParsingState() { }

	[Address(RVA = "0x241EF60", Offset = "0x241E360", Length = "0x8D")]
	[Token(Token = "0x60004BE")]
	private void PushXmlContext() { }

	[Address(RVA = "0x241FEB0", Offset = "0x241F2B0", Length = "0x6A4")]
	[Token(Token = "0x6000412")]
	public virtual bool Read() { }

	[Address(RVA = "0x241F090", Offset = "0x241E490", Length = "0x35E")]
	[Token(Token = "0x6000416")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x241F430", Offset = "0x241E830", Length = "0x48E")]
	[Token(Token = "0x6000475")]
	private int ReadData() { }

	[Address(RVA = "0x241F3F0", Offset = "0x241E7F0", Length = "0x40")]
	[Token(Token = "0x60004B0")]
	private bool ReadDataInName(ref int pos) { }

	[Address(RVA = "0x241F8C0", Offset = "0x241ECC0", Length = "0xCD")]
	[Token(Token = "0x600041A")]
	public virtual string ReadString() { }

	[Address(RVA = "0x241F990", Offset = "0x241ED90", Length = "0x516")]
	[Token(Token = "0x600041C")]
	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24205C0", Offset = "0x241F9C0", Length = "0x124")]
	[Token(Token = "0x60004F0")]
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	[Address(RVA = "0x24206F0", Offset = "0x241FAF0", Length = "0x227")]
	[Token(Token = "0x60004C7")]
	private void RegisterEntity(IDtdEntityInfo entity) { }

	[Address(RVA = "0x2420920", Offset = "0x241FD20", Length = "0xD9")]
	[Token(Token = "0x60004BC")]
	private void ResetAttributes() { }

	[Address(RVA = "0x2420A00", Offset = "0x241FE00", Length = "0x2A0")]
	[Token(Token = "0x6000417")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x241EFF0", Offset = "0x241E3F0", Length = "0x9D")]
	[Token(Token = "0x6000458")]
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	[Address(RVA = "0x2420CB0", Offset = "0x24200B0", Length = "0xD4")]
	[Token(Token = "0x600045F")]
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	[Address(RVA = "0x2420D90", Offset = "0x2420190", Length = "0x143")]
	[Token(Token = "0x600045E")]
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	[Address(RVA = "0x24252E0", Offset = "0x24246E0", Length = "0x7")]
	[Token(Token = "0x60004EE")]
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6000438")]
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	[Address(RVA = "0x24252F0", Offset = "0x24246F0", Length = "0x85")]
	[Token(Token = "0x600042A")]
	internal void set_EntityHandling(EntityHandling value) { }

	[Address(RVA = "0x2425380", Offset = "0x2424780", Length = "0x29")]
	[Token(Token = "0x60004E5")]
	internal void set_InternalSchemaType(object value) { }

	[Address(RVA = "0x24253B0", Offset = "0x24247B0", Length = "0x2C")]
	[Token(Token = "0x60004E7")]
	internal void set_InternalTypedValue(object value) { }

	[Address(RVA = "0x24253E0", Offset = "0x24247E0", Length = "0x248")]
	[Token(Token = "0x6000426")]
	internal void set_Namespaces(bool value) { }

	[Address(RVA = "0x2425630", Offset = "0x2424A30", Length = "0xCD")]
	[Token(Token = "0x6000428")]
	internal void set_Normalization(bool value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[Token(Token = "0x60004E0")]
	internal void set_OnDefaultAttributeUse(OnDefaultAttributeUseDelegate value) { }

	[Address(RVA = "0x2425700", Offset = "0x2424B00", Length = "0x13")]
	[Token(Token = "0x6000418")]
	internal void set_OuterReader(XmlReader value) { }

	[Address(RVA = "0x2425720", Offset = "0x2424B20", Length = "0x13")]
	[Token(Token = "0x60004DF")]
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	[Address(RVA = "0x2425740", Offset = "0x2424B40", Length = "0xD9")]
	[Token(Token = "0x6000429")]
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	[Address(RVA = "0x2425820", Offset = "0x2424C20", Length = "0xB1")]
	[Token(Token = "0x600042C")]
	internal void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x24258E0", Offset = "0x2424CE0", Length = "0x28E")]
	[Token(Token = "0x60004E1")]
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	[Address(RVA = "0x2420EE0", Offset = "0x24202E0", Length = "0xB2")]
	[Token(Token = "0x60004DE")]
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	[Address(RVA = "0x2420FA0", Offset = "0x24203A0", Length = "0x15")]
	[Token(Token = "0x600045D")]
	private void SetErrorState() { }

	[Address(RVA = "0x2420FC0", Offset = "0x24203C0", Length = "0x188")]
	[Token(Token = "0x6000470")]
	private void SetupEncoding(Encoding encoding) { }

	[Address(RVA = "0x2421150", Offset = "0x2420550", Length = "0x82")]
	[Token(Token = "0x600049A")]
	private void SetupEndEntityNodeInAttribute() { }

	[Address(RVA = "0x24211E0", Offset = "0x24205E0", Length = "0x131")]
	[Token(Token = "0x6000499")]
	private void SetupEndEntityNodeInContent() { }

	[Address(RVA = "0x2421320", Offset = "0x2420720", Length = "0x2B2")]
	[Token(Token = "0x60004DC")]
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	[Address(RVA = "0x24215E0", Offset = "0x24209E0", Length = "0x2C")]
	[Token(Token = "0x6000479")]
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	[Address(RVA = "0x2421F20", Offset = "0x2421320", Length = "0x1BE")]
	[Token(Token = "0x6000414")]
	public virtual void Skip() { }

	[Address(RVA = "0x2421610", Offset = "0x2420A10", Length = "0x38B")]
	[Token(Token = "0x60004A4")]
	private void SkipDtd() { }

	[Address(RVA = "0x24219A0", Offset = "0x2420DA0", Length = "0x5B")]
	[Token(Token = "0x600048F")]
	private void SkipPartialTextValue() { }

	[Address(RVA = "0x2421A00", Offset = "0x2420E00", Length = "0x8F")]
	[Token(Token = "0x60004A5")]
	private void SkipPublicOrSystemIdLiteral() { }

	[Address(RVA = "0x2421A90", Offset = "0x2420E90", Length = "0x485")]
	[Token(Token = "0x60004A6")]
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	[Address(RVA = "0x24222C0", Offset = "0x24216C0", Length = "0x151")]
	[Token(Token = "0x60004F2")]
	internal static void StripSpaces(Char[] value, int index, ref int len) { }

	[Address(RVA = "0x24220E0", Offset = "0x24214E0", Length = "0x1DA")]
	[Token(Token = "0x60004F1")]
	internal static string StripSpaces(string value) { }

	[Address(RVA = "0x2422490", Offset = "0x2421890", Length = "0x191")]
	[Token(Token = "0x6000471")]
	private void SwitchEncoding(Encoding newEncoding) { }

	[Address(RVA = "0x2422420", Offset = "0x2421820", Length = "0x62")]
	[Token(Token = "0x6000474")]
	private void SwitchEncodingToUTF8() { }

	[Address(RVA = "0x2414140", Offset = "0x2413540", Length = "0x2D")]
	[Token(Token = "0x6000420")]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x2422630", Offset = "0x2421A30", Length = "0x14")]
	[Token(Token = "0x6000421")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x2416140", Offset = "0x2415540", Length = "0x2D")]
	[Token(Token = "0x6000422")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x24232B0", Offset = "0x24226B0", Length = "0xA6")]
	[Token(Token = "0x6000456")]
	private void Throw(string res, String[] args, Exception innerException) { }

	[Address(RVA = "0x2423100", Offset = "0x2422500", Length = "0xA3")]
	[Token(Token = "0x6000457")]
	private void Throw(Exception e) { }

	[Address(RVA = "0x2422EC0", Offset = "0x24222C0", Length = "0xA1")]
	[Token(Token = "0x6000454")]
	private void Throw(string res, String[] args) { }

	[Address(RVA = "0x2422E30", Offset = "0x2422230", Length = "0x85")]
	[Token(Token = "0x6000455")]
	private void Throw(string res, string arg, Exception innerException) { }

	[Address(RVA = "0x2423050", Offset = "0x2422450", Length = "0xA1")]
	[Token(Token = "0x6000452")]
	private void Throw(string res, string arg) { }

	[Address(RVA = "0x24231B0", Offset = "0x24225B0", Length = "0x1B")]
	[Token(Token = "0x600044D")]
	private void Throw(int pos, string res, string arg) { }

	[Address(RVA = "0x2422F70", Offset = "0x2422370", Length = "0x9A")]
	[Token(Token = "0x6000451")]
	private void Throw(string res, int lineNo, int linePos) { }

	[Address(RVA = "0x2423290", Offset = "0x2422690", Length = "0x1B")]
	[Token(Token = "0x600044E")]
	private void Throw(int pos, string res, String[] args) { }

	[Address(RVA = "0x2423200", Offset = "0x2422600", Length = "0x8B")]
	[Token(Token = "0x6000453")]
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	[Address(RVA = "0x24231D0", Offset = "0x24225D0", Length = "0x2D")]
	[Token(Token = "0x6000450")]
	private void Throw(string res) { }

	[Address(RVA = "0x2423010", Offset = "0x2422410", Length = "0x30")]
	[Token(Token = "0x600044F")]
	private void Throw(int pos, string res) { }

	[Address(RVA = "0x2422650", Offset = "0x2421A50", Length = "0x76")]
	[Token(Token = "0x60004D6")]
	private void ThrowExpectingWhitespace(int pos) { }

	[Address(RVA = "0x24226D0", Offset = "0x2421AD0", Length = "0x69")]
	[Token(Token = "0x600045C")]
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	[Address(RVA = "0x2422740", Offset = "0x2421B40", Length = "0x1C4")]
	[Token(Token = "0x6000481")]
	private void ThrowTagMismatch(NodeData startTag) { }

	[Address(RVA = "0x2422910", Offset = "0x2421D10", Length = "0x1DA")]
	[Token(Token = "0x600047D")]
	private void ThrowUnclosedElements() { }

	[Address(RVA = "0x2422B40", Offset = "0x2421F40", Length = "0x14F")]
	[Token(Token = "0x60004D3")]
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	[Address(RVA = "0x2422AF0", Offset = "0x2421EF0", Length = "0x1B")]
	[Token(Token = "0x60004D2")]
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	[Address(RVA = "0x2422B10", Offset = "0x2421F10", Length = "0xF")]
	[Token(Token = "0x60004D1")]
	private void ThrowUnexpectedToken(string expectedToken1) { }

	[Address(RVA = "0x2422B20", Offset = "0x2421F20", Length = "0x15")]
	[Token(Token = "0x60004D0")]
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	[Address(RVA = "0x2422D10", Offset = "0x2422110", Length = "0x86")]
	[Token(Token = "0x600045B")]
	private void ThrowWithoutLineInfo(string res, String[] args, Exception innerException) { }

	[Address(RVA = "0x2422C90", Offset = "0x2422090", Length = "0x7A")]
	[Token(Token = "0x600045A")]
	private void ThrowWithoutLineInfo(string res, string arg) { }

	[Address(RVA = "0x2422DA0", Offset = "0x24221A0", Length = "0x86")]
	[Token(Token = "0x6000459")]
	private void ThrowWithoutLineInfo(string res) { }

	[Address(RVA = "0x2423360", Offset = "0x2422760", Length = "0xAB")]
	[Token(Token = "0x6000473")]
	private void UnDecodeChars() { }

	[Address(RVA = "0x2423410", Offset = "0x2422810", Length = "0x5E")]
	[Token(Token = "0x60004C8")]
	private void UnregisterEntity() { }

	[Address(RVA = "0x2423470", Offset = "0x2422870", Length = "0xEF")]
	[Token(Token = "0x60004EF")]
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	[Address(RVA = "0x2423560", Offset = "0x2422960", Length = "0x68")]
	[Token(Token = "0x60004D9")]
	private bool ZeroEndingStream(int pos) { }

}

