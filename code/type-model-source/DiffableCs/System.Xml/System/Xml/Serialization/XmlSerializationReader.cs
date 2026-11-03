namespace System.Xml.Serialization;

[MonoTODO]
[Token(Token = "0x2000123")]
public abstract class XmlSerializationReader : XmlSerializationGeneratedCode
{
	[Token(Token = "0x2000125")]
	internal class CollectionFixup
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000675")]
		private XmlSerializationCollectionFixupCallback callback; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000676")]
		private object collection; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000677")]
		private object collectionItems; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000678")]
		private string id; //Field offset: 0x28

		[Token(Token = "0x17000359")]
		public XmlSerializationCollectionFixupCallback Callback
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000D0B")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700035A")]
		public object Collection
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000D0C")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700035C")]
		public internal object CollectionItems
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000D0E")]
			 get { } //Length: 5
			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[Token(Token = "0x6000D0F")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x1700035B")]
		internal object Id
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x6000D0D")]
			internal get { } //Length: 5
		}

		[Address(RVA = "0x255E4E0", Offset = "0x255D8E0", Length = "0x6B")]
		[Token(Token = "0x6000D0A")]
		internal CollectionFixup(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D0B")]
		public XmlSerializationCollectionFixupCallback get_Callback() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D0C")]
		public object get_Collection() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D0E")]
		public object get_CollectionItems() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000D0D")]
		internal object get_Id() { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000D0F")]
		internal void set_CollectionItems(object value) { }

	}

	[Token(Token = "0x2000127")]
	private class CollectionItemFixup
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400067C")]
		private Array list; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400067D")]
		private int index; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400067E")]
		private string id; //Field offset: 0x20

		[Token(Token = "0x17000360")]
		public Array Collection
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000D15")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000362")]
		public string Id
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000D17")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000361")]
		public int Index
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x6000D16")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x20C7F80", Offset = "0x20C7380", Length = "0x5E")]
		[Token(Token = "0x6000D14")]
		public CollectionItemFixup(Array list, int index, string id) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D15")]
		public Array get_Collection() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D17")]
		public string get_Id() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000D16")]
		public int get_Index() { }

	}

	[Token(Token = "0x2000126")]
	internal class Fixup
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000679")]
		private object source; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400067A")]
		private String[] ids; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400067B")]
		private XmlSerializationFixupCallback callback; //Field offset: 0x20

		[Token(Token = "0x1700035D")]
		public XmlSerializationFixupCallback Callback
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000D11")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700035E")]
		public String[] Ids
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000D12")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700035F")]
		public object Source
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000D13")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x255E590", Offset = "0x255D990", Length = "0x98")]
		[Token(Token = "0x6000D10")]
		public Fixup(object o, XmlSerializationFixupCallback callback, int count) { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D11")]
		public XmlSerializationFixupCallback get_Callback() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D12")]
		public String[] get_Ids() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D13")]
		public object get_Source() { }

	}

	[Token(Token = "0x2000124")]
	private class WriteCallbackInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000671")]
		public Type Type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000672")]
		public string TypeName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000673")]
		public string TypeNs; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000674")]
		public XmlSerializationReadCallback Callback; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D09")]
		public WriteCallbackInfo() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000658")]
	private XmlDocument document; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000659")]
	private XmlReader reader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400065A")]
	private ArrayList fixups; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400065B")]
	private Hashtable collFixups; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400065C")]
	private ArrayList collItemFixups; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400065D")]
	private Hashtable typesCallbacks; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400065E")]
	private ArrayList noIDTargets; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400065F")]
	private Hashtable targets; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000660")]
	private Hashtable delayedListFixups; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000661")]
	private XmlSerializer eventSource; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000662")]
	private int delayedFixupId; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000663")]
	private Hashtable referencedObjects; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000664")]
	private int readCount; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000665")]
	private int whileIterationCount; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000666")]
	private string w3SchemaNS; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000667")]
	private string w3InstanceNS; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000668")]
	private string w3InstanceNS2000; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000669")]
	private string w3InstanceNS1999; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400066A")]
	private string soapNS; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400066B")]
	private string wsdlNS; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400066C")]
	private string nullX; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400066D")]
	private string nil; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400066E")]
	private string typeX; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400066F")]
	private string arrayType; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000670")]
	private XmlQualifiedName arrayQName; //Field offset: 0xC8

	[Token(Token = "0x17000357")]
	protected XmlDocument Document
	{
		[Address(RVA = "0x25760A0", Offset = "0x25754A0", Length = "0x9B")]
		[Token(Token = "0x6000CDA")]
		 get { } //Length: 155
	}

	[Token(Token = "0x17000358")]
	protected XmlReader Reader
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000CDB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000CD9")]
	protected XmlSerializationReader() { }

	[Address(RVA = "0x25710B0", Offset = "0x25704B0", Length = "0x97")]
	[Token(Token = "0x6000CDE")]
	private void AddFixup(CollectionItemFixup fixup) { }

	[Address(RVA = "0x2571150", Offset = "0x2570550", Length = "0x97")]
	[Token(Token = "0x6000CDD")]
	protected void AddFixup(Fixup fixup) { }

	[Address(RVA = "0x2570F90", Offset = "0x2570390", Length = "0x11E")]
	[Token(Token = "0x6000CDC")]
	protected void AddFixup(CollectionFixup fixup) { }

	[Address(RVA = "0x25711F0", Offset = "0x25705F0", Length = "0x165")]
	[Token(Token = "0x6000CDF")]
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	[Address(RVA = "0x2571360", Offset = "0x2570760", Length = "0x151")]
	[Token(Token = "0x6000CE0")]
	protected void AddTarget(string id, object o) { }

	[Address(RVA = "0x25714C0", Offset = "0x25708C0", Length = "0x75")]
	[Token(Token = "0x6000CE2")]
	protected Exception CreateReadOnlyCollectionException(string name) { }

	[Address(RVA = "0x2571540", Offset = "0x2570940", Length = "0x7B")]
	[Token(Token = "0x6000CE3")]
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	[Address(RVA = "0x25715C0", Offset = "0x25709C0", Length = "0x7F")]
	[Token(Token = "0x6000CE4")]
	protected Exception CreateUnknownNodeException() { }

	[Address(RVA = "0x2571640", Offset = "0x2570A40", Length = "0x17B")]
	[Token(Token = "0x6000CE5")]
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	[Address(RVA = "0x25717C0", Offset = "0x2570BC0", Length = "0x19C")]
	[Token(Token = "0x6000CE1")]
	private string CurrentTag() { }

	[Address(RVA = "0x2571980", Offset = "0x2570D80", Length = "0x9D")]
	[Token(Token = "0x6000CE6")]
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	[Address(RVA = "0x2571A20", Offset = "0x2570E20", Length = "0x4C")]
	[Token(Token = "0x6000CD7")]
	private ArrayList EnsureArrayList(ArrayList list) { }

	[Address(RVA = "0x2571A70", Offset = "0x2570E70", Length = "0x4C")]
	[Token(Token = "0x6000CD8")]
	private Hashtable EnsureHashtable(Hashtable hash) { }

	[Address(RVA = "0x25760A0", Offset = "0x25754A0", Length = "0x9B")]
	[Token(Token = "0x6000CDA")]
	protected XmlDocument get_Document() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000CDB")]
	protected XmlReader get_Reader() { }

	[Address(RVA = "0x2571AC0", Offset = "0x2570EC0", Length = "0xF7")]
	[Token(Token = "0x6000CF5")]
	private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	[Address(RVA = "0x2571BC0", Offset = "0x2570FC0", Length = "0xDD")]
	[Token(Token = "0x6000CE7")]
	protected bool GetNullAttr() { }

	[Address(RVA = "0x2571CA0", Offset = "0x25710A0", Length = "0xD5")]
	[Token(Token = "0x6000CE8")]
	protected object GetTarget(string id) { }

	[Address(RVA = "0x2571D80", Offset = "0x2571180", Length = "0x219")]
	[Token(Token = "0x6000CEA")]
	protected XmlQualifiedName GetXsiType() { }

	[Token(Token = "0x6000CEB")]
	protected abstract void InitCallbacks() { }

	[Address(RVA = "0x2571FA0", Offset = "0x25713A0", Length = "0x489")]
	[Token(Token = "0x6000CD6")]
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	[Token(Token = "0x6000CEC")]
	protected abstract void InitIDs() { }

	[Address(RVA = "0x2572430", Offset = "0x2571830", Length = "0x76")]
	[Token(Token = "0x6000CED")]
	protected bool IsXmlnsAttribute(string name) { }

	[Address(RVA = "0x25724B0", Offset = "0x25718B0", Length = "0x5D2")]
	[Token(Token = "0x6000D07")]
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	[Address(RVA = "0x2572A90", Offset = "0x2571E90", Length = "0x1AE")]
	[Token(Token = "0x6000CEE")]
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	[Address(RVA = "0x2572C40", Offset = "0x2572040", Length = "0xF3")]
	[Token(Token = "0x6000CEF")]
	protected XmlQualifiedName ReadElementQualifiedName() { }

	[Address(RVA = "0x2572D40", Offset = "0x2572140", Length = "0xC0")]
	[Token(Token = "0x6000CF0")]
	protected void ReadEndElement() { }

	[Address(RVA = "0x2572E10", Offset = "0x2572210", Length = "0x51D")]
	[Token(Token = "0x6000CF7")]
	private bool ReadList(out object resultList) { }

	[Address(RVA = "0x2573330", Offset = "0x2572730", Length = "0x1ED")]
	[Token(Token = "0x6000CF1")]
	protected bool ReadNull() { }

	[Address(RVA = "0x2573520", Offset = "0x2572920", Length = "0x2B")]
	[Token(Token = "0x6000CF2")]
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	[Address(RVA = "0x2573550", Offset = "0x2572950", Length = "0x46")]
	[Token(Token = "0x6000CF3")]
	protected string ReadNullableString() { }

	[Address(RVA = "0x25738B0", Offset = "0x2572CB0", Length = "0x69")]
	[Token(Token = "0x6000CF4")]
	protected object ReadReferencedElement() { }

	[Address(RVA = "0x25735A0", Offset = "0x25729A0", Length = "0x30F")]
	[Token(Token = "0x6000CF6")]
	protected object ReadReferencedElement(string name, string ns) { }

	[Address(RVA = "0x2573920", Offset = "0x2572D20", Length = "0xEB2")]
	[Token(Token = "0x6000CF8")]
	protected void ReadReferencedElements() { }

	[Address(RVA = "0x2574800", Offset = "0x2573C00", Length = "0x85")]
	[Token(Token = "0x6000CF9")]
	protected object ReadReferencingElement(out string fixupReference) { }

	[Address(RVA = "0x25747E0", Offset = "0x2573BE0", Length = "0x1F")]
	[Token(Token = "0x6000CFA")]
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	[Address(RVA = "0x2574890", Offset = "0x2573C90", Length = "0x39A")]
	[Token(Token = "0x6000CFB")]
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	[Address(RVA = "0x2574C30", Offset = "0x2574030", Length = "0x1F0")]
	[Token(Token = "0x6000CFC")]
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	[Address(RVA = "0x2575720", Offset = "0x2574B20", Length = "0xB")]
	[Token(Token = "0x6000CFD")]
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	[Address(RVA = "0x2574E30", Offset = "0x2574230", Length = "0x8E6")]
	[Token(Token = "0x6000CFE")]
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	[Address(RVA = "0x2575730", Offset = "0x2574B30", Length = "0x136")]
	[Token(Token = "0x6000D00")]
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	[Address(RVA = "0x2575870", Offset = "0x2574C70", Length = "0x6A")]
	[Token(Token = "0x6000CFF")]
	protected XmlNode ReadXmlNode(bool wrapped) { }

	[Address(RVA = "0x25758E0", Offset = "0x2574CE0", Length = "0xB1")]
	[Token(Token = "0x6000D01")]
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	[Address(RVA = "0x25759A0", Offset = "0x2574DA0", Length = "0x22")]
	[Token(Token = "0x6000CE9")]
	private bool TargetReady(string id) { }

	[Address(RVA = "0x25759D0", Offset = "0x2574DD0", Length = "0x24D")]
	[Token(Token = "0x6000D02")]
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	[Address(RVA = "0x2575C20", Offset = "0x2575020", Length = "0x1A7")]
	[Token(Token = "0x6000D03")]
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	[Address(RVA = "0x2575DD0", Offset = "0x25751D0", Length = "0x1A7")]
	[Token(Token = "0x6000D04")]
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	[Address(RVA = "0x256BD10", Offset = "0x256B110", Length = "0x64")]
	[Token(Token = "0x6000D05")]
	protected void UnknownNode(object o) { }

	[Address(RVA = "0x2575F80", Offset = "0x2575380", Length = "0x71")]
	[Token(Token = "0x6000D06")]
	protected void UnknownNode(object o, string qnames) { }

	[Address(RVA = "0x2576000", Offset = "0x2575400", Length = "0x93")]
	[Token(Token = "0x6000D08")]
	protected void UnreferencedObject(string id, object o) { }

}

