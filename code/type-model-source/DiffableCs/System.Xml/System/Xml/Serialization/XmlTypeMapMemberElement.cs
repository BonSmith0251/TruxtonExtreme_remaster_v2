namespace System.Xml.Serialization;

[Token(Token = "0x200013A")]
internal class XmlTypeMapMemberElement : XmlTypeMapMember
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006C8")]
	private XmlTypeMapElementInfoList _elementInfo; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006C9")]
	private string _choiceMember; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006CA")]
	private bool _isTextCollector; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006CB")]
	private TypeData _choiceTypeData; //Field offset: 0x70

	[Token(Token = "0x17000388")]
	public string ChoiceMember
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000DF9")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6000DFA")]
		 set { } //Length: 995
	}

	[Token(Token = "0x17000389")]
	public TypeData ChoiceTypeData
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000DFB")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x6000DFC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000387")]
	public XmlTypeMapElementInfoList ElementInfo
	{
		[Address(RVA = "0x2592D40", Offset = "0x2592140", Length = "0x69")]
		[Token(Token = "0x6000DF7")]
		 get { } //Length: 105
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6000DF8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700038A")]
	public bool IsXmlTextCollector
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x6000DFF")]
		 get { } //Length: 5
		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[Token(Token = "0x6000E00")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x25921A0", Offset = "0x25915A0", Length = "0x7")]
	[Token(Token = "0x6000DF6")]
	public XmlTypeMapMemberElement() { }

	[Address(RVA = "0x2592680", Offset = "0x2591A80", Length = "0x4FD")]
	[Token(Token = "0x6000DFD")]
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000DF9")]
	public string get_ChoiceMember() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000DFB")]
	public TypeData get_ChoiceTypeData() { }

	[Address(RVA = "0x2592D40", Offset = "0x2592140", Length = "0x69")]
	[Token(Token = "0x6000DF7")]
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x6000DFF")]
	public bool get_IsXmlTextCollector() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6000DFA")]
	public void set_ChoiceMember(string value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x6000DFC")]
	public void set_ChoiceTypeData(TypeData value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6000DF8")]
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
	[Token(Token = "0x6000E00")]
	public void set_IsXmlTextCollector(bool value) { }

	[Address(RVA = "0x2592B80", Offset = "0x2591F80", Length = "0x1B4")]
	[Token(Token = "0x6000DFE")]
	public void SetChoice(object ob, object choice) { }

}

