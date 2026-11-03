namespace System.Xml.Serialization;

[Token(Token = "0x2000130")]
public class XmlSerializer
{
	[Token(Token = "0x2000131")]
	public class SerializerData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006A4")]
		public MethodInfo ReaderMethod; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006A5")]
		public Type WriterType; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006A6")]
		public MethodInfo WriterMethod; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006A7")]
		public XmlSerializerImplementation Implementation; //Field offset: 0x28

		[Address(RVA = "0x2589A80", Offset = "0x2588E80", Length = "0xD0")]
		[Token(Token = "0x6000DA7")]
		public XmlSerializationWriter CreateWriter() { }

	}

	[Token(Token = "0x4000698")]
	private static int generationThreshold; //Field offset: 0x0
	[Token(Token = "0x4000699")]
	private static bool backgroundGeneration; //Field offset: 0x4
	[Token(Token = "0x400069A")]
	private static bool deleteTempFiles; //Field offset: 0x5
	[Token(Token = "0x400069B")]
	private static bool generatorFallback; //Field offset: 0x6
	[Token(Token = "0x400069F")]
	private static Hashtable serializerTypes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400069C")]
	private bool customSerializer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400069D")]
	private XmlMapping typeMapping; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400069E")]
	private SerializerData serializerData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006A0")]
	private UnreferencedObjectEventHandler onUnreferencedObject; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006A1")]
	private XmlAttributeEventHandler onUnknownAttribute; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006A2")]
	private XmlElementEventHandler onUnknownElement; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006A3")]
	private XmlNodeEventHandler onUnknownNode; //Field offset: 0x40

	[Token(Token = "0x17000364")]
	internal XmlMapping Mapping
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D97")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2591900", Offset = "0x2590D00", Length = "0xF3")]
	[Token(Token = "0x6000D94")]
	private static XmlSerializer() { }

	[Address(RVA = "0x2591B80", Offset = "0x2590F80", Length = "0x25")]
	[Token(Token = "0x6000D95")]
	public XmlSerializer(Type type) { }

	[Address(RVA = "0x2591A00", Offset = "0x2590E00", Length = "0x173")]
	[Token(Token = "0x6000D96")]
	public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	[Address(RVA = "0x2590B60", Offset = "0x258FF60", Length = "0x3E")]
	[Token(Token = "0x6000D9C")]
	protected override XmlSerializationReader CreateReader() { }

	[Address(RVA = "0x2590B00", Offset = "0x258FF00", Length = "0x54")]
	[Token(Token = "0x6000DA6")]
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

	[Address(RVA = "0x2590BA0", Offset = "0x258FFA0", Length = "0x2A5")]
	[Token(Token = "0x6000DA5")]
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	[Address(RVA = "0x2590E50", Offset = "0x2590250", Length = "0x3E")]
	[Token(Token = "0x6000D9D")]
	protected override XmlSerializationWriter CreateWriter() { }

	[Address(RVA = "0x2590F50", Offset = "0x2590350", Length = "0x120")]
	[Token(Token = "0x6000D9E")]
	public object Deserialize(TextReader textReader) { }

	[Address(RVA = "0x2590E90", Offset = "0x2590290", Length = "0xBE")]
	[Token(Token = "0x6000D9F")]
	public object Deserialize(XmlReader xmlReader) { }

	[Address(RVA = "0x2591080", Offset = "0x2590480", Length = "0x263")]
	[Token(Token = "0x6000DA0")]
	protected override object Deserialize(XmlSerializationReader reader) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000D97")]
	internal XmlMapping get_Mapping() { }

	[Address(RVA = "0x25912F0", Offset = "0x25906F0", Length = "0x21")]
	[Token(Token = "0x6000D98")]
	internal override void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	[Address(RVA = "0x2591320", Offset = "0x2590720", Length = "0x21")]
	[Token(Token = "0x6000D99")]
	internal override void OnUnknownElement(XmlElementEventArgs e) { }

	[Address(RVA = "0x2591350", Offset = "0x2590750", Length = "0x21")]
	[Token(Token = "0x6000D9A")]
	internal override void OnUnknownNode(XmlNodeEventArgs e) { }

	[Address(RVA = "0x2591380", Offset = "0x2590780", Length = "0x21")]
	[Token(Token = "0x6000D9B")]
	internal override void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	[Address(RVA = "0x2591450", Offset = "0x2590850", Length = "0x1ED")]
	[Token(Token = "0x6000DA1")]
	protected override void Serialize(object o, XmlSerializationWriter writer) { }

	[Address(RVA = "0x25913B0", Offset = "0x25907B0", Length = "0x9F")]
	[Token(Token = "0x6000DA2")]
	public void Serialize(TextWriter textWriter, object o) { }

	[Address(RVA = "0x25918E0", Offset = "0x2590CE0", Length = "0x1A")]
	[Token(Token = "0x6000DA3")]
	public void Serialize(XmlWriter xmlWriter, object o) { }

	[Address(RVA = "0x2591640", Offset = "0x2590A40", Length = "0x29B")]
	[Token(Token = "0x6000DA4")]
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

}

