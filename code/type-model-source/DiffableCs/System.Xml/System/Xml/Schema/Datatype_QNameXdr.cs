namespace System.Xml.Schema;

[Token(Token = "0x20001B3")]
internal class Datatype_QNameXdr : Datatype_anySimpleType
{
	[Token(Token = "0x4000849")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400084A")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x170004BC")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x259FD80", Offset = "0x259F180", Length = "0x4F")]
		[Token(Token = "0x60010F5")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004BA")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
		[Token(Token = "0x60010F2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004BB")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x259FDD0", Offset = "0x259F1D0", Length = "0x4E")]
		[Token(Token = "0x60010F4")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x259FC30", Offset = "0x259F030", Length = "0xC6")]
	[Token(Token = "0x60010F7")]
	private static Datatype_QNameXdr() { }

	[Address(RVA = "0x259FD00", Offset = "0x259F100", Length = "0x7A")]
	[Token(Token = "0x60010F6")]
	public Datatype_QNameXdr() { }

	[Address(RVA = "0x259FD80", Offset = "0x259F180", Length = "0x4F")]
	[Token(Token = "0x60010F5")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x60010F2")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x259FDD0", Offset = "0x259F1D0", Length = "0x4E")]
	[Token(Token = "0x60010F4")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x259FA20", Offset = "0x259EE20", Length = "0x20C")]
	[Token(Token = "0x60010F3")]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

}

