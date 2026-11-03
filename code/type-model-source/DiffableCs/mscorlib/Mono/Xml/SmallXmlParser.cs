namespace Mono.Xml;

[Token(Token = "0x2000047")]
internal class SmallXmlParser
{
	[Token(Token = "0x200004A")]
	private class AttrListImpl : IAttrList
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000148")]
		private List<String> attrNames; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000149")]
		private List<String> attrValues; //Field offset: 0x18

		[Token(Token = "0x17000013")]
		public override int Length
		{
			[Address(RVA = "0x1E5B8D0", Offset = "0x1E5ACD0", Length = "0x3C")]
			[Token(Token = "0x60000A2")]
			 get { } //Length: 60
		}

		[Token(Token = "0x17000014")]
		public override String[] Names
		{
			[Address(RVA = "0x1E5B910", Offset = "0x1E5AD10", Length = "0x44")]
			[Token(Token = "0x60000A6")]
			 get { } //Length: 68
		}

		[Token(Token = "0x17000015")]
		public override String[] Values
		{
			[Address(RVA = "0x1E5B960", Offset = "0x1E5AD60", Length = "0x44")]
			[Token(Token = "0x60000A7")]
			 get { } //Length: 68
		}

		[Address(RVA = "0x1E5B820", Offset = "0x1E5AC20", Length = "0xA5")]
		[Token(Token = "0x60000AA")]
		public AttrListImpl() { }

		[Address(RVA = "0x1E5B4D0", Offset = "0x1E5A8D0", Length = "0x127")]
		[Token(Token = "0x60000A9")]
		internal void Add(string name, string value) { }

		[Address(RVA = "0x1E5B600", Offset = "0x1E5AA00", Length = "0x89")]
		[Token(Token = "0x60000A8")]
		internal void Clear() { }

		[Address(RVA = "0x1E5B8D0", Offset = "0x1E5ACD0", Length = "0x3C")]
		[Token(Token = "0x60000A2")]
		public override int get_Length() { }

		[Address(RVA = "0x1E5B910", Offset = "0x1E5AD10", Length = "0x44")]
		[Token(Token = "0x60000A6")]
		public override String[] get_Names() { }

		[Address(RVA = "0x1E5B960", Offset = "0x1E5AD60", Length = "0x44")]
		[Token(Token = "0x60000A7")]
		public override String[] get_Values() { }

		[Address(RVA = "0x1E5B690", Offset = "0x1E5AA90", Length = "0x51")]
		[Token(Token = "0x60000A3")]
		public override string GetName(int i) { }

		[Address(RVA = "0x1E5B6F0", Offset = "0x1E5AAF0", Length = "0x51")]
		[Token(Token = "0x60000A4")]
		public override string GetValue(int i) { }

		[Address(RVA = "0x1E5B750", Offset = "0x1E5AB50", Length = "0xCA")]
		[Token(Token = "0x60000A5")]
		public override string GetValue(string name) { }

	}

	[Token(Token = "0x2000049")]
	internal interface IAttrList
	{

		[Token(Token = "0x17000010")]
		public int Length
		{
			[Token(Token = "0x600009C")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000011")]
		public String[] Names
		{
			[Token(Token = "0x60000A0")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000012")]
		public String[] Values
		{
			[Token(Token = "0x60000A1")]
			 get { } //Length: 0
		}

		[Token(Token = "0x600009C")]
		public int get_Length() { }

		[Token(Token = "0x60000A0")]
		public String[] get_Names() { }

		[Token(Token = "0x60000A1")]
		public String[] get_Values() { }

		[Token(Token = "0x600009D")]
		public string GetName(int i) { }

		[Token(Token = "0x600009E")]
		public string GetValue(int i) { }

		[Token(Token = "0x600009F")]
		public string GetValue(string name) { }

	}

	[Token(Token = "0x2000048")]
	internal interface IContentHandler
	{

		[Token(Token = "0x600009A")]
		public void OnChars(string text) { }

		[Token(Token = "0x6000098")]
		public void OnEndElement(string name) { }

		[Token(Token = "0x6000096")]
		public void OnEndParsing(SmallXmlParser parser) { }

		[Token(Token = "0x600009B")]
		public void OnIgnorableWhitespace(string text) { }

		[Token(Token = "0x6000099")]
		public void OnProcessingInstruction(string name, string text) { }

		[Token(Token = "0x6000097")]
		public void OnStartElement(string name, IAttrList attrs) { }

		[Token(Token = "0x6000095")]
		public void OnStartParsing(SmallXmlParser parser) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400013C")]
	private IContentHandler handler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400013D")]
	private TextReader reader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400013E")]
	private Stack elementNames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400013F")]
	private Stack xmlSpaces; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000140")]
	private string xmlSpace; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000141")]
	private StringBuilder buffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000142")]
	private Char[] nameBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000143")]
	private bool isWhitespace; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000144")]
	private AttrListImpl attributes; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000145")]
	private int line; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000146")]
	private int column; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000147")]
	private bool resetColumn; //Field offset: 0x60

	[Address(RVA = "0x1E6D750", Offset = "0x1E6CB50", Length = "0x1C1")]
	[Token(Token = "0x600007E")]
	public SmallXmlParser() { }

	[Address(RVA = "0x1E6B0A0", Offset = "0x1E6A4A0", Length = "0xB3")]
	[Token(Token = "0x600008C")]
	private void Cleanup() { }

	[Address(RVA = "0x1E6B160", Offset = "0x1E6A560", Length = "0xE0")]
	[Token(Token = "0x600007F")]
	private Exception Error(string msg) { }

	[Address(RVA = "0x1E6B240", Offset = "0x1E6A640", Length = "0x116")]
	[Token(Token = "0x6000088")]
	public void Expect(int c) { }

	[Address(RVA = "0x1E6B360", Offset = "0x1E6A760", Length = "0xCF")]
	[Token(Token = "0x600008E")]
	private void HandleBufferedContent() { }

	[Address(RVA = "0x1E6B430", Offset = "0x1E6A830", Length = "0x100")]
	[Token(Token = "0x6000084")]
	private void HandleWhitespaces() { }

	[Address(RVA = "0x1E6B540", Offset = "0x1E6A940", Length = "0xC0")]
	[Token(Token = "0x6000081")]
	private bool IsNameChar(char c, bool start) { }

	[Address(RVA = "0x1E6B630", Offset = "0x1E6AA30", Length = "0x17")]
	[Token(Token = "0x6000082")]
	private bool IsWhitespace(int c) { }

	[Address(RVA = "0x1E6B650", Offset = "0x1E6AA50", Length = "0x20E")]
	[Token(Token = "0x600008B")]
	public void Parse(TextReader input, IContentHandler handler) { }

	[Address(RVA = "0x1E6B860", Offset = "0x1E6AC60", Length = "0x2A")]
	[Token(Token = "0x6000086")]
	private int Peek() { }

	[Address(RVA = "0x1E6D520", Offset = "0x1E6C920", Length = "0x5A")]
	[Token(Token = "0x6000087")]
	private int Read() { }

	[Address(RVA = "0x1E6B890", Offset = "0x1E6AC90", Length = "0x267")]
	[Token(Token = "0x6000092")]
	private void ReadAttribute(AttrListImpl a) { }

	[Address(RVA = "0x1E6BB00", Offset = "0x1E6AF00", Length = "0x14C")]
	[Token(Token = "0x6000093")]
	private void ReadCDATASection() { }

	[Address(RVA = "0x1E6BC50", Offset = "0x1E6B050", Length = "0x1EB")]
	[Token(Token = "0x6000091")]
	private int ReadCharacterReference() { }

	[Address(RVA = "0x1E6BE40", Offset = "0x1E6B240", Length = "0x110")]
	[Token(Token = "0x600008F")]
	private void ReadCharacters() { }

	[Address(RVA = "0x1E6BF60", Offset = "0x1E6B360", Length = "0x14B")]
	[Token(Token = "0x6000094")]
	private void ReadComment() { }

	[Address(RVA = "0x1E6C0B0", Offset = "0x1E6B4B0", Length = "0xE8D")]
	[Token(Token = "0x600008D")]
	public void ReadContent() { }

	[Address(RVA = "0x1E6CF40", Offset = "0x1E6C340", Length = "0x22C")]
	[Token(Token = "0x600008A")]
	public string ReadName() { }

	[Address(RVA = "0x1E6D170", Offset = "0x1E6C570", Length = "0x260")]
	[Token(Token = "0x6000090")]
	private void ReadReference() { }

	[Address(RVA = "0x1E6D3E0", Offset = "0x1E6C7E0", Length = "0x133")]
	[Token(Token = "0x6000089")]
	private string ReadUntil(char until, bool handleReferences) { }

	[Address(RVA = "0x1E6D590", Offset = "0x1E6C990", Length = "0xDF")]
	[Token(Token = "0x6000085")]
	public void SkipWhitespaces(bool expected) { }

	[Address(RVA = "0x1E6D580", Offset = "0x1E6C980", Length = "0xA")]
	[Token(Token = "0x6000083")]
	public void SkipWhitespaces() { }

	[Address(RVA = "0x1E6D670", Offset = "0x1E6CA70", Length = "0xD7")]
	[Token(Token = "0x6000080")]
	private Exception UnexpectedEndError() { }

}

