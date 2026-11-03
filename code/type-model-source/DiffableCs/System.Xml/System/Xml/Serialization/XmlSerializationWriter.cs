namespace System.Xml.Serialization;

[Token(Token = "0x200012C")]
public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode
{
	[Token(Token = "0x200012D")]
	private class WriteCallbackInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000690")]
		public Type Type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000691")]
		public string TypeName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000692")]
		public string TypeNs; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000693")]
		public XmlSerializationWriteCallback Callback; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D77")]
		public WriteCallbackInfo() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000688")]
	private ObjectIDGenerator idGenerator; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000689")]
	private int qnameCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400068A")]
	private bool topLevelElement; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400068B")]
	private ArrayList namespaces; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400068C")]
	private XmlWriter writer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400068D")]
	private Queue referencedElements; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400068E")]
	private Hashtable callbacks; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400068F")]
	private Hashtable serializedObjects; //Field offset: 0x40

	[Token(Token = "0x17000363")]
	protected XmlWriter Writer
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000D47")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x25796E0", Offset = "0x2578AE0", Length = "0x6D")]
	[Token(Token = "0x6000D45")]
	protected XmlSerializationWriter() { }

	[Address(RVA = "0x2576140", Offset = "0x2575540", Length = "0x124")]
	[Token(Token = "0x6000D48")]
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	[Address(RVA = "0x2576270", Offset = "0x2575670", Length = "0x40")]
	[Token(Token = "0x6000D4E")]
	private bool AlreadyQueued(object ob) { }

	[Address(RVA = "0x25762B0", Offset = "0x25756B0", Length = "0x7B")]
	[Token(Token = "0x6000D6A")]
	private void CheckReferenceQueue() { }

	[Address(RVA = "0x2576330", Offset = "0x2575730", Length = "0x7B")]
	[Token(Token = "0x6000D49")]
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	[Address(RVA = "0x25763B0", Offset = "0x25757B0", Length = "0x98")]
	[Token(Token = "0x6000D4A")]
	protected Exception CreateUnknownTypeException(object o) { }

	[Address(RVA = "0x2576450", Offset = "0x2575850", Length = "0x75")]
	[Token(Token = "0x6000D4B")]
	protected Exception CreateUnknownTypeException(Type type) { }

	[Address(RVA = "0x25764D0", Offset = "0x25758D0", Length = "0xBF")]
	[Token(Token = "0x6000D4C")]
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000D47")]
	protected XmlWriter get_Writer() { }

	[Address(RVA = "0x2576590", Offset = "0x2575990", Length = "0x104")]
	[Token(Token = "0x6000D4D")]
	private string GetId(object o, bool addToReferencesList) { }

	[Address(RVA = "0x25766A0", Offset = "0x2575AA0", Length = "0x117")]
	[Token(Token = "0x6000D4F")]
	private string GetNamespacePrefix(string ns) { }

	[Address(RVA = "0x25767C0", Offset = "0x2575BC0", Length = "0x19A")]
	[Token(Token = "0x6000D50")]
	private string GetQualifiedName(string name, string ns) { }

	[Token(Token = "0x6000D51")]
	protected abstract void InitCallbacks() { }

	[Address(RVA = "0x2576960", Offset = "0x2575D60", Length = "0x13F")]
	[Token(Token = "0x6000D46")]
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	[Address(RVA = "0x2576AA0", Offset = "0x2575EA0", Length = "0xD3")]
	[Token(Token = "0x6000D67")]
	private bool IsPrimitiveArray(TypeData td) { }

	[Address(RVA = "0x2576B80", Offset = "0x2575F80", Length = "0x5")]
	[Token(Token = "0x6000D52")]
	protected void TopLevelElement() { }

	[Address(RVA = "0x2576B90", Offset = "0x2575F90", Length = "0x2E2")]
	[Token(Token = "0x6000D68")]
	private void WriteArray(object o, TypeData td) { }

	[Address(RVA = "0x2576EC0", Offset = "0x25762C0", Length = "0x37")]
	[Token(Token = "0x6000D53")]
	protected void WriteAttribute(string localName, string ns, string value) { }

	[Address(RVA = "0x2576E80", Offset = "0x2576280", Length = "0x33")]
	[Token(Token = "0x6000D54")]
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	[Address(RVA = "0x2576F00", Offset = "0x2576300", Length = "0xD1")]
	[Token(Token = "0x6000D56")]
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	[Address(RVA = "0x2576FE0", Offset = "0x25763E0", Length = "0xD1")]
	[Token(Token = "0x6000D57")]
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	[Address(RVA = "0x25772C0", Offset = "0x25766C0", Length = "0x1A")]
	[Token(Token = "0x6000D58")]
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	[Address(RVA = "0x25770C0", Offset = "0x25764C0", Length = "0x1F0")]
	[Token(Token = "0x6000D59")]
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	[Address(RVA = "0x25772E0", Offset = "0x25766E0", Length = "0x1A")]
	[Token(Token = "0x6000D5A")]
	protected void WriteElementString(string localName, string ns, string value) { }

	[Address(RVA = "0x2577300", Offset = "0x2576700", Length = "0x192")]
	[Token(Token = "0x6000D5B")]
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	[Address(RVA = "0x25774A0", Offset = "0x25768A0", Length = "0x51")]
	[Token(Token = "0x6000D5D")]
	protected void WriteEndElement(object o) { }

	[Address(RVA = "0x255D1C0", Offset = "0x255C5C0", Length = "0x2A")]
	[Token(Token = "0x6000D5C")]
	protected void WriteEndElement() { }

	[Address(RVA = "0x2577500", Offset = "0x2576900", Length = "0x394")]
	[Token(Token = "0x6000D5E")]
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	[Address(RVA = "0x2577A50", Offset = "0x2576E50", Length = "0xA5")]
	[Token(Token = "0x6000D5F")]
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	[Address(RVA = "0x2577B00", Offset = "0x2576F00", Length = "0x9E")]
	[Token(Token = "0x6000D60")]
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	[Address(RVA = "0x2577BA0", Offset = "0x2576FA0", Length = "0x17")]
	[Token(Token = "0x6000D61")]
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	[Address(RVA = "0x2577BC0", Offset = "0x2576FC0", Length = "0x28")]
	[Token(Token = "0x6000D62")]
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	[Address(RVA = "0x25778A0", Offset = "0x2576CA0", Length = "0xC0")]
	[Token(Token = "0x6000D63")]
	protected void WriteNullTagEncoded(string name, string ns) { }

	[Address(RVA = "0x2577970", Offset = "0x2576D70", Length = "0xD1")]
	[Token(Token = "0x6000D64")]
	protected void WriteNullTagLiteral(string name, string ns) { }

	[Address(RVA = "0x2577BF0", Offset = "0x2576FF0", Length = "0x4A3")]
	[Token(Token = "0x6000D65")]
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	[Address(RVA = "0x25780A0", Offset = "0x25774A0", Length = "0x269")]
	[Token(Token = "0x6000D66")]
	protected void WriteReferencedElements() { }

	[Address(RVA = "0x2578310", Offset = "0x2577710", Length = "0x161")]
	[Token(Token = "0x6000D69")]
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	[Address(RVA = "0x25785D0", Offset = "0x25779D0", Length = "0x132")]
	[Token(Token = "0x6000D6B")]
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	[Address(RVA = "0x2578480", Offset = "0x2577880", Length = "0x140")]
	[Token(Token = "0x6000D6C")]
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	[Address(RVA = "0x2578710", Offset = "0x2577B10", Length = "0x56")]
	[Token(Token = "0x6000D6D")]
	protected void WriteStartDocument() { }

	[Address(RVA = "0x25787A0", Offset = "0x2577BA0", Length = "0x28")]
	[Token(Token = "0x6000D6E")]
	protected void WriteStartElement(string name, string ns) { }

	[Address(RVA = "0x2578770", Offset = "0x2577B70", Length = "0x28")]
	[Token(Token = "0x6000D6F")]
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	[Address(RVA = "0x2578E50", Offset = "0x2578250", Length = "0x25")]
	[Token(Token = "0x6000D70")]
	protected void WriteStartElement(string name, string ns, object o) { }

	[Address(RVA = "0x2578E20", Offset = "0x2578220", Length = "0x29")]
	[Token(Token = "0x6000D71")]
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	[Address(RVA = "0x25787D0", Offset = "0x2577BD0", Length = "0x64C")]
	[Token(Token = "0x6000D72")]
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	[Address(RVA = "0x2578E80", Offset = "0x2578280", Length = "0x37B")]
	[Token(Token = "0x6000D73")]
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	[Address(RVA = "0x2579200", Offset = "0x2578600", Length = "0x34")]
	[Token(Token = "0x6000D74")]
	protected void WriteValue(string value) { }

	[Address(RVA = "0x2579240", Offset = "0x2578640", Length = "0x2E4")]
	[Token(Token = "0x6000D75")]
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	[Address(RVA = "0x2579530", Offset = "0x2578930", Length = "0xC6")]
	[Token(Token = "0x6000D55")]
	private void WriteXmlNode(XmlNode node) { }

	[Address(RVA = "0x2579600", Offset = "0x2578A00", Length = "0xDA")]
	[Token(Token = "0x6000D76")]
	protected void WriteXsiType(string name, string ns) { }

}

