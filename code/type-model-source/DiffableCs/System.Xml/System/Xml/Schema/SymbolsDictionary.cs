namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x200015E")]
internal class SymbolsDictionary
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000753")]
	private int last; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000754")]
	private Hashtable names; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000755")]
	private Hashtable wildcards; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000756")]
	private ArrayList particles; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000757")]
	private object particleLast; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000758")]
	private bool isUpaEnforced; //Field offset: 0x38

	[Token(Token = "0x170003E4")]
	public int Count
	{
		[Address(RVA = "0x258AEE0", Offset = "0x258A2E0", Length = "0x6")]
		[Token(Token = "0x6000EF5")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170003E5")]
	public bool IsUpaEnforced
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000EF6")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[Token(Token = "0x6000EF7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003E6")]
	public int Item
	{
		[Address(RVA = "0x258AEF0", Offset = "0x258A2F0", Length = "0xC7")]
		[Token(Token = "0x6000EFC")]
		 get { } //Length: 199
	}

	[Address(RVA = "0x258AE40", Offset = "0x258A240", Length = "0x9F")]
	[Token(Token = "0x6000EF4")]
	public SymbolsDictionary() { }

	[Address(RVA = "0x2589E10", Offset = "0x2589210", Length = "0x127")]
	[Token(Token = "0x6000EF8")]
	public int AddName(XmlQualifiedName name, object particle) { }

	[Address(RVA = "0x2589F40", Offset = "0x2589340", Length = "0x27F")]
	[Token(Token = "0x6000EF9")]
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	[Address(RVA = "0x258A1C0", Offset = "0x25895C0", Length = "0x16A")]
	[Token(Token = "0x6000EFA")]
	private void AddWildcard(string wildcard, object particle) { }

	[Address(RVA = "0x258A330", Offset = "0x2589730", Length = "0x30")]
	[Token(Token = "0x6000EFD")]
	public bool Exists(XmlQualifiedName name) { }

	[Address(RVA = "0x258AEE0", Offset = "0x258A2E0", Length = "0x6")]
	[Token(Token = "0x6000EF5")]
	public int get_Count() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6000EF6")]
	public bool get_IsUpaEnforced() { }

	[Address(RVA = "0x258AEF0", Offset = "0x258A2F0", Length = "0xC7")]
	[Token(Token = "0x6000EFC")]
	public int get_Item(XmlQualifiedName name) { }

	[Address(RVA = "0x258A370", Offset = "0x2589770", Length = "0x64D")]
	[Token(Token = "0x6000EFB")]
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	[Address(RVA = "0x258A9C0", Offset = "0x2589DC0", Length = "0x38")]
	[Token(Token = "0x6000EFE")]
	public object GetParticle(int symbol) { }

	[Address(RVA = "0x258AA00", Offset = "0x2589E00", Length = "0x43E")]
	[Token(Token = "0x6000EFF")]
	public string NameOf(int symbol) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x6000EF7")]
	public void set_IsUpaEnforced(bool value) { }

}

