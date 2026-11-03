namespace System.Runtime.Remoting;

[Token(Token = "0x2000351")]
internal class ConfigHandler : IContentHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DF1")]
	private ArrayList typeEntries; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DF2")]
	private ArrayList channelInstances; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DF3")]
	private ChannelData currentChannel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DF4")]
	private Stack currentProviderData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DF5")]
	private string currentClientUrl; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DF6")]
	private string appName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000DF7")]
	private string currentXmlPath; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DF8")]
	private bool onlyDelayedChannels; //Field offset: 0x48

	[Address(RVA = "0x1EDE480", Offset = "0x1EDD880", Length = "0xC8")]
	[Token(Token = "0x6001AB8")]
	public ConfigHandler(bool onlyDelayedChannels) { }

	[Address(RVA = "0x1EDAD60", Offset = "0x1EDA160", Length = "0x10D")]
	[Token(Token = "0x6001ABA")]
	private bool CheckPath(string path) { }

	[Address(RVA = "0x1EDAE70", Offset = "0x1EDA270", Length = "0xD5")]
	[Token(Token = "0x6001ACD")]
	private string ExtractAssembly(ref string type) { }

	[Address(RVA = "0x1EDAF50", Offset = "0x1EDA350", Length = "0xDF")]
	[Token(Token = "0x6001ACC")]
	private string GetNotNull(IAttrList attrs, string name) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001ACE")]
	public override void OnChars(string ch) { }

	[Address(RVA = "0x1EDB030", Offset = "0x1EDA430", Length = "0xA7")]
	[Token(Token = "0x6001AC0")]
	public override void OnEndElement(string name) { }

	[Address(RVA = "0x1EDB0E0", Offset = "0x1EDA4E0", Length = "0x110")]
	[Token(Token = "0x6001ACF")]
	public override void OnEndParsing(SmallXmlParser parser) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001ABD")]
	public override void OnIgnorableWhitespace(string s) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001ABC")]
	public override void OnProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x1EDB1F0", Offset = "0x1EDA5F0", Length = "0x155")]
	[Token(Token = "0x6001ABE")]
	public override void OnStartElement(string name, IAttrList attrs) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001ABB")]
	public override void OnStartParsing(SmallXmlParser parser) { }

	[Address(RVA = "0x1EDB350", Offset = "0x1EDA750", Length = "0xDB0")]
	[Token(Token = "0x6001ABF")]
	public void ParseElement(string name, IAttrList attrs) { }

	[Address(RVA = "0x1EDC110", Offset = "0x1EDB510", Length = "0x373")]
	[Token(Token = "0x6001AC3")]
	private TimeSpan ParseTime(string s) { }

	[Address(RVA = "0x1EDC490", Offset = "0x1EDB890", Length = "0x58A")]
	[Token(Token = "0x6001AC4")]
	private void ReadChannel(IAttrList attrs, bool isTemplate) { }

	[Address(RVA = "0x1EDCA20", Offset = "0x1EDBE20", Length = "0x25C")]
	[Token(Token = "0x6001AC6")]
	private void ReadClientActivated(IAttrList attrs) { }

	[Address(RVA = "0x1EDCC80", Offset = "0x1EDC080", Length = "0x1FE")]
	[Token(Token = "0x6001AC8")]
	private void ReadClientWellKnown(IAttrList attrs) { }

	[Address(RVA = "0x1EDCE80", Offset = "0x1EDC280", Length = "0x3DE")]
	[Token(Token = "0x6001AC1")]
	private void ReadCustomProviderData(string name, IAttrList attrs) { }

	[Address(RVA = "0x1EDD260", Offset = "0x1EDC660", Length = "0x19E")]
	[Token(Token = "0x6001ACA")]
	private void ReadInteropXml(IAttrList attrs, bool isElement) { }

	[Address(RVA = "0x1EDD400", Offset = "0x1EDC800", Length = "0x344")]
	[Token(Token = "0x6001AC2")]
	private void ReadLifetine(IAttrList attrs) { }

	[Address(RVA = "0x1EDD750", Offset = "0x1EDCB50", Length = "0x281")]
	[Token(Token = "0x6001ACB")]
	private void ReadPreload(IAttrList attrs) { }

	[Address(RVA = "0x1EDD9E0", Offset = "0x1EDCDE0", Length = "0x4D4")]
	[Token(Token = "0x6001AC5")]
	private ProviderData ReadProvider(string name, IAttrList attrs, bool isTemplate) { }

	[Address(RVA = "0x1EDDEC0", Offset = "0x1EDD2C0", Length = "0x1CA")]
	[Token(Token = "0x6001AC7")]
	private void ReadServiceActivated(IAttrList attrs) { }

	[Address(RVA = "0x1EDE090", Offset = "0x1EDD490", Length = "0x2F5")]
	[Token(Token = "0x6001AC9")]
	private void ReadServiceWellKnown(IAttrList attrs) { }

	[Address(RVA = "0x1EDE390", Offset = "0x1EDD790", Length = "0xEC")]
	[Token(Token = "0x6001AB9")]
	private void ValidatePath(string element, String[] paths) { }

}

