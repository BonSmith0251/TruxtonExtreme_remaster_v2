namespace System.Xml.Linq;

[Token(Token = "0x2000017")]
internal struct NamespaceResolver
{
	[Token(Token = "0x2000018")]
	private class NamespaceDeclaration
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000033")]
		public string prefix; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000034")]
		public XNamespace ns; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000035")]
		public int scope; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000036")]
		public NamespaceDeclaration prev; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600009D")]
		public NamespaceDeclaration() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000030")]
	private int _scope; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000031")]
	private NamespaceDeclaration _declaration; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000032")]
	private NamespaceDeclaration _rover; //Field offset: 0x10

	[Address(RVA = "0x2406420", Offset = "0x2405820", Length = "0xEE")]
	[Token(Token = "0x600009A")]
	public void Add(string prefix, XNamespace ns) { }

	[Address(RVA = "0x2406320", Offset = "0x2405720", Length = "0xFA")]
	[Token(Token = "0x600009B")]
	public void AddFirst(string prefix, XNamespace ns) { }

	[Address(RVA = "0x2406510", Offset = "0x2405910", Length = "0x100")]
	[Token(Token = "0x600009C")]
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	[Address(RVA = "0x2406620", Offset = "0x2405A20", Length = "0x96")]
	[Token(Token = "0x6000099")]
	public void PopScope() { }

	[Address(RVA = "0x24066C0", Offset = "0x2405AC0", Length = "0x3")]
	[Token(Token = "0x6000098")]
	public void PushScope() { }

}

