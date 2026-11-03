namespace System.Xml;

[Token(Token = "0x20000DD")]
public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
{
	[Token(Token = "0x20000DE")]
	private struct NamespaceDeclaration
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000586")]
		public string prefix; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000587")]
		public string uri; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000588")]
		public int scopeId; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000589")]
		public int previousNsIndex; //Field offset: 0x14

		[Address(RVA = "0x2542B50", Offset = "0x2541F50", Length = "0x4A")]
		[Token(Token = "0x6000B76")]
		public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400057E")]
	private NamespaceDeclaration[] nsdecls; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400057F")]
	private int lastDecl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000580")]
	private XmlNameTable nameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000581")]
	private int scopeId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000582")]
	private Dictionary<String, Int32> hashTable; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000583")]
	private bool useHashtable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000584")]
	private string xml; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000585")]
	private string xmlNs; //Field offset: 0x48

	[Token(Token = "0x170002DD")]
	public override string DefaultNamespace
	{
		[Address(RVA = "0x255BF90", Offset = "0x255B390", Length = "0x43")]
		[Token(Token = "0x6000B6C")]
		 get { } //Length: 67
	}

	[Token(Token = "0x170002DC")]
	public override XmlNameTable NameTable
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000B6B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B69")]
	internal XmlNamespaceManager() { }

	[Address(RVA = "0x255BD20", Offset = "0x255B120", Length = "0x26D")]
	[Token(Token = "0x6000B6A")]
	public XmlNamespaceManager(XmlNameTable nameTable) { }

	[Address(RVA = "0x255B010", Offset = "0x255A410", Length = "0x456")]
	[Token(Token = "0x6000B6F")]
	public override void AddNamespace(string prefix, string uri) { }

	[Address(RVA = "0x255BF90", Offset = "0x255B390", Length = "0x43")]
	[Token(Token = "0x6000B6C")]
	public override string get_DefaultNamespace() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000B6B")]
	public override XmlNameTable get_NameTable() { }

	[Address(RVA = "0x255B470", Offset = "0x255A870", Length = "0x163")]
	[Token(Token = "0x6000B71")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x255B5E0", Offset = "0x255A9E0", Length = "0x1AF")]
	[Token(Token = "0x6000B72")]
	public override IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x255B960", Offset = "0x255AD60", Length = "0x49")]
	[Token(Token = "0x6000B73")]
	public override string LookupNamespace(string prefix) { }

	[Address(RVA = "0x255B790", Offset = "0x255AB90", Length = "0x1C4")]
	[Token(Token = "0x6000B74")]
	private int LookupNamespaceDecl(string prefix) { }

	[Address(RVA = "0x255B9B0", Offset = "0x255ADB0", Length = "0xD0")]
	[Token(Token = "0x6000B75")]
	public override string LookupPrefix(string uri) { }

	[Address(RVA = "0x255BA90", Offset = "0x255AE90", Length = "0xE6")]
	[Token(Token = "0x6000B6E")]
	public override bool PopScope() { }

	[Address(RVA = "0x1097480", Offset = "0x1096880", Length = "0x4")]
	[Token(Token = "0x6000B6D")]
	public override void PushScope() { }

	[Address(RVA = "0x255BB80", Offset = "0x255AF80", Length = "0x19E")]
	[Token(Token = "0x6000B70")]
	public override void RemoveNamespace(string prefix, string uri) { }

}

