namespace System.Xml.Serialization;

[Token(Token = "0x20000F0")]
public class XmlSerializerNamespaces
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D0")]
	private Hashtable namespaces; //Field offset: 0x10

	[Token(Token = "0x170002FE")]
	public int Count
	{
		[Address(RVA = "0x255D830", Offset = "0x255CC30", Length = "0x8D")]
		[Token(Token = "0x6000BE3")]
		 get { } //Length: 141
	}

	[Token(Token = "0x170002FF")]
	internal ArrayList NamespaceList
	{
		[Address(RVA = "0x255D8C0", Offset = "0x255CCC0", Length = "0x3E8")]
		[Token(Token = "0x6000BE4")]
		internal get { } //Length: 1000
	}

	[Token(Token = "0x17000300")]
	internal Hashtable Namespaces
	{
		[Address(RVA = "0x255DCB0", Offset = "0x255D0B0", Length = "0x69")]
		[Token(Token = "0x6000BE5")]
		internal get { } //Length: 105
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000BE6")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000BDF")]
	public XmlSerializerNamespaces() { }

	[Address(RVA = "0x255D620", Offset = "0x255CA20", Length = "0x115")]
	[Token(Token = "0x6000BE0")]
	public void Add(string prefix, string ns) { }

	[Address(RVA = "0x255D570", Offset = "0x255C970", Length = "0xA5")]
	[Token(Token = "0x6000BE1")]
	internal void AddInternal(string prefix, string ns) { }

	[Address(RVA = "0x255D830", Offset = "0x255CC30", Length = "0x8D")]
	[Token(Token = "0x6000BE3")]
	public int get_Count() { }

	[Address(RVA = "0x255D8C0", Offset = "0x255CCC0", Length = "0x3E8")]
	[Token(Token = "0x6000BE4")]
	internal ArrayList get_NamespaceList() { }

	[Address(RVA = "0x255DCB0", Offset = "0x255D0B0", Length = "0x69")]
	[Token(Token = "0x6000BE5")]
	internal Hashtable get_Namespaces() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000BE6")]
	internal void set_Namespaces(Hashtable value) { }

	[Address(RVA = "0x255D740", Offset = "0x255CB40", Length = "0xEB")]
	[Token(Token = "0x6000BE2")]
	public XmlQualifiedName[] ToArray() { }

}

