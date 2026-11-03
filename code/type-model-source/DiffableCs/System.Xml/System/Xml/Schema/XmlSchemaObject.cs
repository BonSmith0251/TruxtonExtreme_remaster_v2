namespace System.Xml.Schema;

[Token(Token = "0x2000230")]
public abstract class XmlSchemaObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B9F")]
	private int lineNum; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000BA0")]
	private int linePos; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BA1")]
	private string sourceUri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BA2")]
	private XmlSerializerNamespaces namespaces; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BA3")]
	private XmlSchemaObject parent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BA4")]
	private bool isProcessing; //Field offset: 0x30

	[Token(Token = "0x1700061A")]
	[XmlIgnore]
	internal override string IdAttribute
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60015FE")]
		internal get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60015FF")]
		internal set { } //Length: 3
	}

	[Token(Token = "0x1700061C")]
	[XmlIgnore]
	internal bool IsProcessing
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6001604")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[Token(Token = "0x6001605")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000615")]
	[XmlIgnore]
	public int LineNumber
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60015F1")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x60015F2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000616")]
	[XmlIgnore]
	public int LinePosition
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60015F3")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x60015F4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700061B")]
	[XmlIgnore]
	internal override string NameAttribute
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001602")]
		internal get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6001603")]
		internal set { } //Length: 3
	}

	[Token(Token = "0x17000619")]
	[XmlNamespaceDeclarations]
	public XmlSerializerNamespaces Namespaces
	{
		[Address(RVA = "0x248FB70", Offset = "0x248EF70", Length = "0x69")]
		[Token(Token = "0x60015F9")]
		 get { } //Length: 105
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60015FA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000618")]
	[XmlIgnore]
	public XmlSchemaObject Parent
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60015F7")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60015F8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000617")]
	[XmlIgnore]
	public string SourceUri
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60015F5")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60015F6")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001607")]
	protected XmlSchemaObject() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001601")]
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[Address(RVA = "0x248FAF0", Offset = "0x248EEF0", Length = "0x71")]
	[Token(Token = "0x6001606")]
	internal override XmlSchemaObject Clone() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60015FE")]
	internal override string get_IdAttribute() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6001604")]
	internal bool get_IsProcessing() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60015F1")]
	public int get_LineNumber() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x60015F3")]
	public int get_LinePosition() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001602")]
	internal override string get_NameAttribute() { }

	[Address(RVA = "0x248FB70", Offset = "0x248EF70", Length = "0x69")]
	[Token(Token = "0x60015F9")]
	public XmlSerializerNamespaces get_Namespaces() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60015F7")]
	public XmlSchemaObject get_Parent() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60015F5")]
	public string get_SourceUri() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60015FB")]
	internal override void OnAdd(XmlSchemaObjectCollection container, object item) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60015FD")]
	internal override void OnClear(XmlSchemaObjectCollection container) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60015FC")]
	internal override void OnRemove(XmlSchemaObjectCollection container, object item) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60015FF")]
	internal override void set_IdAttribute(string value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[Token(Token = "0x6001605")]
	internal void set_IsProcessing(bool value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x60015F2")]
	public void set_LineNumber(int value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x60015F4")]
	public void set_LinePosition(int value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001603")]
	internal override void set_NameAttribute(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60015FA")]
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60015F8")]
	public void set_Parent(XmlSchemaObject value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60015F6")]
	public void set_SourceUri(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001600")]
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

