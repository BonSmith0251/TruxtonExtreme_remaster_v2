namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001D3")]
public class XmlNodeConverter : JsonConverter
{
	[Token(Token = "0x400081E")]
	internal static readonly List<IXmlNode> EmptyChildNodes; //Field offset: 0x0
	[Token(Token = "0x400081F")]
	private const string TextName = "#text"; //Field offset: 0x0
	[Token(Token = "0x4000820")]
	private const string CommentName = "#comment"; //Field offset: 0x0
	[Token(Token = "0x4000821")]
	private const string CDataName = "#cdata-section"; //Field offset: 0x0
	[Token(Token = "0x4000822")]
	private const string WhitespaceName = "#whitespace"; //Field offset: 0x0
	[Token(Token = "0x4000823")]
	private const string SignificantWhitespaceName = "#significant-whitespace"; //Field offset: 0x0
	[Token(Token = "0x4000824")]
	private const string DeclarationName = "?xml"; //Field offset: 0x0
	[Token(Token = "0x4000825")]
	private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json"; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Nullable(2)]
	[Token(Token = "0x4000826")]
	private string <DeserializeRootElementName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000827")]
	private bool <WriteArrayAttribute>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000828")]
	private bool <OmitRootObject>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000829")]
	private bool <EncodeSpecialCharacters>k__BackingField; //Field offset: 0x1A

	[Nullable(2)]
	[Token(Token = "0x170002A8")]
	public string DeserializeRootElementName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000FA6")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000FA7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002AB")]
	public bool EncodeSpecialCharacters
	{
		[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FAC")]
		 get { } //Length: 5
		[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FAD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002AA")]
	public bool OmitRootObject
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FAA")]
		 get { } //Length: 5
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FAB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002A9")]
	public bool WriteArrayAttribute
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FA8")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FA9")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x21BAB70", Offset = "0x21B9F70", Length = "0x84")]
	[Token(Token = "0x6000FCD")]
	private static XmlNodeConverter() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000FCC")]
	public XmlNodeConverter() { }

	[Address(RVA = "0x21B4400", Offset = "0x21B3800", Length = "0x22F")]
	[Token(Token = "0x6000FBD")]
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	[Address(RVA = "0x21B4630", Offset = "0x21B3A30", Length = "0x1FB")]
	[Token(Token = "0x6000FC0")]
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	[Address(RVA = "0x21B4830", Offset = "0x21B3C30", Length = "0x19D")]
	[Token(Token = "0x6000FB8")]
	private static bool AllSameName(IXmlNode node) { }

	[Address(RVA = "0x21B49D0", Offset = "0x21B3DD0", Length = "0xA5")]
	[Token(Token = "0x6000FC9")]
	public virtual bool CanConvert(Type valueType) { }

	[Address(RVA = "0x21B4A80", Offset = "0x21B3E80", Length = "0x6AC")]
	[Token(Token = "0x6000FBE")]
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	[Address(RVA = "0x21B5160", Offset = "0x21B4560", Length = "0x3CA")]
	[Token(Token = "0x6000FC4")]
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	[Address(RVA = "0x21B5A30", Offset = "0x21B4E30", Length = "0x138")]
	[Token(Token = "0x6000FC5")]
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	[Address(RVA = "0x21B5530", Offset = "0x21B4930", Length = "0x374")]
	[Token(Token = "0x6000FBC")]
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<String, String> attributeNameValues) { }

	[Address(RVA = "0x21B5B70", Offset = "0x21B4F70", Length = "0x399")]
	[Token(Token = "0x6000FC3")]
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	[Address(RVA = "0x21B5F10", Offset = "0x21B5310", Length = "0x901")]
	[Token(Token = "0x6000FC6")]
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	[Address(RVA = "0x21B6820", Offset = "0x21B5C20", Length = "0x303")]
	[Token(Token = "0x6000FBA")]
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000FA6")]
	public string get_DeserializeRootElementName() { }

	[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FAC")]
	public bool get_EncodeSpecialCharacters() { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FAA")]
	public bool get_OmitRootObject() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FA8")]
	public bool get_WriteArrayAttribute() { }

	[Address(RVA = "0x21B6B30", Offset = "0x21B5F30", Length = "0x32C")]
	[Token(Token = "0x6000FB2")]
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	[Address(RVA = "0x21B6EC0", Offset = "0x21B62C0", Length = "0x20C")]
	[Token(Token = "0x6000FB3")]
	private bool IsArray(IXmlNode node) { }

	[Address(RVA = "0x21B70D0", Offset = "0x21B64D0", Length = "0xD9")]
	[Token(Token = "0x6000FC7")]
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	[Address(RVA = "0x21B7230", Offset = "0x21B6630", Length = "0x7D")]
	[Token(Token = "0x6000FCB")]
	private bool IsXmlNode(Type valueType) { }

	[Address(RVA = "0x21B71B0", Offset = "0x21B65B0", Length = "0x7D")]
	[Token(Token = "0x6000FCA")]
	private bool IsXObject(Type valueType) { }

	[Address(RVA = "0x21B72B0", Offset = "0x21B66B0", Length = "0x4B3")]
	[Token(Token = "0x6000FB0")]
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	[Address(RVA = "0x21B7770", Offset = "0x21B6B70", Length = "0x2C0")]
	[Token(Token = "0x6000FBF")]
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	[Address(RVA = "0x21B7A40", Offset = "0x21B6E40", Length = "0x6AB")]
	[Token(Token = "0x6000FC2")]
	private Dictionary<String, String> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	[Address(RVA = "0x21B80F0", Offset = "0x21B74F0", Length = "0x384")]
	[Token(Token = "0x6000FBB")]
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	[Address(RVA = "0x21B84F0", Offset = "0x21B78F0", Length = "0x779")]
	[Token(Token = "0x6000FB9")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x21B8C70", Offset = "0x21B8070", Length = "0x1AD")]
	[Token(Token = "0x6000FB1")]
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	[Address(RVA = "0x21B8E20", Offset = "0x21B8220", Length = "0x6FB")]
	[Token(Token = "0x6000FB4")]
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	[Address(RVA = "0x21B9520", Offset = "0x21B8920", Length = "0xDEC")]
	[Token(Token = "0x6000FB7")]
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000FA7")]
	public void set_DeserializeRootElementName(string value) { }

	[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FAD")]
	public void set_EncodeSpecialCharacters(bool value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FAB")]
	public void set_OmitRootObject(bool value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FA9")]
	public void set_WriteArrayAttribute(bool value) { }

	[Address(RVA = "0x21BA350", Offset = "0x21B9750", Length = "0x54")]
	[Token(Token = "0x6000FC1")]
	private bool ShouldReadInto(JsonReader reader) { }

	[Address(RVA = "0x21BA3E0", Offset = "0x21B97E0", Length = "0x1DF")]
	[Token(Token = "0x6000FC8")]
	private bool ValueAttributes(List<IXmlNode> c) { }

	[Address(RVA = "0x21BA5C0", Offset = "0x21B99C0", Length = "0x10B")]
	[Token(Token = "0x6000FAF")]
	private IXmlNode WrapXml(object value) { }

	[Address(RVA = "0x21BA840", Offset = "0x21B9C40", Length = "0xE7")]
	[Token(Token = "0x6000FB6")]
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	[Address(RVA = "0x21BA6D0", Offset = "0x21B9AD0", Length = "0x167")]
	[Token(Token = "0x6000FB5")]
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) { }

	[Address(RVA = "0x21BA930", Offset = "0x21B9D30", Length = "0x233")]
	[Token(Token = "0x6000FAE")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

