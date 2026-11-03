namespace System.Xml.Linq;

[Token(Token = "0x200001F")]
public abstract class XObject : IXmlLineInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000050")]
	internal XContainer parent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000051")]
	internal object annotations; //Field offset: 0x18

	[Token(Token = "0x17000024")]
	public string BaseUri
	{
		[Address(RVA = "0x240EFF0", Offset = "0x240E3F0", Length = "0x72")]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000029")]
	internal bool HasBaseUri
	{
		[Address(RVA = "0x240F070", Offset = "0x240E470", Length = "0x40")]
		[Token(Token = "0x60000CF")]
		internal get { } //Length: 64
	}

	[Token(Token = "0x17000025")]
	public abstract XmlNodeType NodeType
	{
		[Token(Token = "0x60000C7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000026")]
	public XElement Parent
	{
		[Address(RVA = "0x240F0B0", Offset = "0x240E4B0", Length = "0x72")]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000027")]
	private override int System.Xml.IXmlLineInfo.LineNumber
	{
		[Address(RVA = "0x240EF50", Offset = "0x240E350", Length = "0x48")]
		[Token(Token = "0x60000CD")]
		private get { } //Length: 72
	}

	[Token(Token = "0x17000028")]
	private override int System.Xml.IXmlLineInfo.LinePosition
	{
		[Address(RVA = "0x240EFA0", Offset = "0x240E3A0", Length = "0x48")]
		[Token(Token = "0x60000CE")]
		private get { } //Length: 72
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000C5")]
	internal XObject() { }

	[Address(RVA = "0x240E660", Offset = "0x240DA60", Length = "0x2BA")]
	[Token(Token = "0x60000C9")]
	public void AddAnnotation(object annotation) { }

	[Address(RVA = "0x9E6B90", Offset = "0x9E5F90", Length = "0xFD")]
	[Token(Token = "0x60000CB")]
	public T Annotation() { }

	[Address(RVA = "0x240E920", Offset = "0x240DD20", Length = "0x138")]
	[Token(Token = "0x60000CA")]
	private object AnnotationForSealedType(Type type) { }

	[Address(RVA = "0x240EFF0", Offset = "0x240E3F0", Length = "0x72")]
	[Token(Token = "0x60000C6")]
	public string get_BaseUri() { }

	[Address(RVA = "0x240F070", Offset = "0x240E470", Length = "0x40")]
	[Token(Token = "0x60000CF")]
	internal bool get_HasBaseUri() { }

	[Token(Token = "0x60000C7")]
	public abstract XmlNodeType get_NodeType() { }

	[Address(RVA = "0x240F0B0", Offset = "0x240E4B0", Length = "0x72")]
	[Token(Token = "0x60000C8")]
	public XElement get_Parent() { }

	[Address(RVA = "0x240EA60", Offset = "0x240DE60", Length = "0x1D4")]
	[Token(Token = "0x60000D5")]
	internal SaveOptions GetSaveOptionsFromAnnotations() { }

	[Address(RVA = "0x240EC40", Offset = "0x240E040", Length = "0xA7")]
	[Token(Token = "0x60000D0")]
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	[Address(RVA = "0x240ECF0", Offset = "0x240E0F0", Length = "0xA7")]
	[Token(Token = "0x60000D1")]
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	[Address(RVA = "0x240EDA0", Offset = "0x240E1A0", Length = "0x77")]
	[Token(Token = "0x60000D2")]
	internal void SetBaseUri(string baseUri) { }

	[Address(RVA = "0x240EE20", Offset = "0x240E220", Length = "0x79")]
	[Token(Token = "0x60000D3")]
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	[Address(RVA = "0x240EEA0", Offset = "0x240E2A0", Length = "0x61")]
	[Token(Token = "0x60000D4")]
	internal bool SkipNotify() { }

	[Address(RVA = "0x240EF50", Offset = "0x240E350", Length = "0x48")]
	[Token(Token = "0x60000CD")]
	private override int System.Xml.IXmlLineInfo.get_LineNumber() { }

	[Address(RVA = "0x240EFA0", Offset = "0x240E3A0", Length = "0x48")]
	[Token(Token = "0x60000CE")]
	private override int System.Xml.IXmlLineInfo.get_LinePosition() { }

	[Address(RVA = "0x240EF10", Offset = "0x240E310", Length = "0x40")]
	[Token(Token = "0x60000CC")]
	private override bool System.Xml.IXmlLineInfo.HasLineInfo() { }

}

