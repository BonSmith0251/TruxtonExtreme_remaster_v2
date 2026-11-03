namespace System.Xml.Linq;

[Token(Token = "0x2000006")]
public class XAttribute : XObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000004")]
	internal XAttribute next; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000005")]
	internal XName name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000006")]
	internal string value; //Field offset: 0x30

	[Token(Token = "0x17000001")]
	public bool IsNamespaceDeclaration
	{
		[Address(RVA = "0x24078C0", Offset = "0x2406CC0", Length = "0x83")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 131
	}

	[Token(Token = "0x17000002")]
	public XName Name
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000003")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000004")]
	public string Value
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 5
		[Address(RVA = "0x2407950", Offset = "0x2406D50", Length = "0x12A")]
		[Token(Token = "0x600000C")]
		 set { } //Length: 298
	}

	[Address(RVA = "0x2407710", Offset = "0x2406B10", Length = "0x108")]
	[Token(Token = "0x6000006")]
	public XAttribute(XName name, object value) { }

	[Address(RVA = "0x2407820", Offset = "0x2406C20", Length = "0x90")]
	[Token(Token = "0x6000007")]
	public XAttribute(XAttribute other) { }

	[Address(RVA = "0x24078C0", Offset = "0x2406CC0", Length = "0x83")]
	[Token(Token = "0x6000008")]
	public bool get_IsNamespaceDeclaration() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000009")]
	public XName get_Name() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600000A")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600000B")]
	public string get_Value() { }

	[Address(RVA = "0x2406EA0", Offset = "0x24062A0", Length = "0x12E")]
	[Token(Token = "0x600000E")]
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	[Address(RVA = "0x2407950", Offset = "0x2406D50", Length = "0x12A")]
	[Token(Token = "0x600000C")]
	public void set_Value(string value) { }

	[Address(RVA = "0x2406FD0", Offset = "0x24063D0", Length = "0x38A")]
	[Token(Token = "0x600000D")]
	public virtual string ToString() { }

	[Address(RVA = "0x2407360", Offset = "0x2406760", Length = "0x3A4")]
	[Token(Token = "0x600000F")]
	private static void ValidateAttribute(XName name, string value) { }

}

