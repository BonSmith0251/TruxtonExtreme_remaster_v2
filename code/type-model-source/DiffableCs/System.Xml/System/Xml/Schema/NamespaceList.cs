namespace System.Xml.Schema;

[Token(Token = "0x20001CB")]
internal class NamespaceList
{
	[Token(Token = "0x20001CC")]
	internal enum ListType : int
	{
		Any = 0,
		Other = 1,
		Set = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000889")]
	private ListType type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400088A")]
	private Hashtable set; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400088B")]
	private string targetNamespace; //Field offset: 0x20

	[Token(Token = "0x170004D1")]
	public ICollection Enumerate
	{
		[Address(RVA = "0x2427980", Offset = "0x2426D80", Length = "0x79")]
		[Token(Token = "0x60011B6")]
		 get { } //Length: 121
	}

	[Token(Token = "0x170004D0")]
	public string Excluded
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60011B5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004CF")]
	public ListType Type
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60011B4")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60011B1")]
	public NamespaceList() { }

	[Address(RVA = "0x2427720", Offset = "0x2426B20", Length = "0x25E")]
	[Token(Token = "0x60011B2")]
	public NamespaceList(string namespaces, string targetNamespace) { }

	[Address(RVA = "0x2426410", Offset = "0x2425810", Length = "0x80")]
	[Token(Token = "0x60011B7")]
	public override bool Allows(string ns) { }

	[Address(RVA = "0x24264A0", Offset = "0x24258A0", Length = "0x2A")]
	[Token(Token = "0x60011B8")]
	public bool Allows(XmlQualifiedName qname) { }

	[Address(RVA = "0x24264D0", Offset = "0x24258D0", Length = "0x162")]
	[Token(Token = "0x60011B3")]
	public NamespaceList Clone() { }

	[Address(RVA = "0x2426640", Offset = "0x2425A40", Length = "0x161")]
	[Token(Token = "0x60011BC")]
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	[Address(RVA = "0x2427980", Offset = "0x2426D80", Length = "0x79")]
	[Token(Token = "0x60011B6")]
	public ICollection get_Enumerate() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60011B5")]
	public string get_Excluded() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60011B4")]
	public ListType get_Type() { }

	[Address(RVA = "0x24267B0", Offset = "0x2425BB0", Length = "0x44A")]
	[Token(Token = "0x60011BD")]
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	[Address(RVA = "0x2426C00", Offset = "0x2426000", Length = "0x270")]
	[Token(Token = "0x60011BA")]
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	[Address(RVA = "0x2426E80", Offset = "0x2426280", Length = "0x60")]
	[Token(Token = "0x60011BE")]
	private void RemoveNamespace(string tns) { }

	[Address(RVA = "0x2426EF0", Offset = "0x24262F0", Length = "0x3C1")]
	[Token(Token = "0x60011B9")]
	public virtual string ToString() { }

	[Address(RVA = "0x24272C0", Offset = "0x24266C0", Length = "0x45D")]
	[Token(Token = "0x60011BB")]
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

}

