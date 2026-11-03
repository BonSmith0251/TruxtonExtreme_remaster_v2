namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001CA")]
internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Nullable(1)]
	[Token(Token = "0x400081A")]
	private readonly XDocumentType _documentType; //Field offset: 0x18

	[Token(Token = "0x17000282")]
	public override string InternalSubset
	{
		[Address(RVA = "0x21B19B0", Offset = "0x21B0DB0", Length = "0x1B")]
		[Token(Token = "0x6000F5E")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000283")]
	public virtual string LocalName
	{
		[Address(RVA = "0x21B19D0", Offset = "0x21B0DD0", Length = "0x2C")]
		[Token(Token = "0x6000F5F")]
		 get { } //Length: 44
	}

	[Nullable(1)]
	[Token(Token = "0x1700027F")]
	public override string Name
	{
		[Address(RVA = "0x21B1A00", Offset = "0x21B0E00", Length = "0x1B")]
		[NullableContext(1)]
		[Token(Token = "0x6000F5B")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000281")]
	public override string Public
	{
		[Address(RVA = "0x21B1A20", Offset = "0x21B0E20", Length = "0x1B")]
		[Token(Token = "0x6000F5D")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000280")]
	public override string System
	{
		[Address(RVA = "0x21B1A40", Offset = "0x21B0E40", Length = "0x1B")]
		[Token(Token = "0x6000F5C")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x21B1960", Offset = "0x21B0D60", Length = "0x41")]
	[NullableContext(1)]
	[Token(Token = "0x6000F5A")]
	public XDocumentTypeWrapper(XDocumentType documentType) { }

	[Address(RVA = "0x21B19B0", Offset = "0x21B0DB0", Length = "0x1B")]
	[Token(Token = "0x6000F5E")]
	public override string get_InternalSubset() { }

	[Address(RVA = "0x21B19D0", Offset = "0x21B0DD0", Length = "0x2C")]
	[Token(Token = "0x6000F5F")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x21B1A00", Offset = "0x21B0E00", Length = "0x1B")]
	[NullableContext(1)]
	[Token(Token = "0x6000F5B")]
	public override string get_Name() { }

	[Address(RVA = "0x21B1A20", Offset = "0x21B0E20", Length = "0x1B")]
	[Token(Token = "0x6000F5D")]
	public override string get_Public() { }

	[Address(RVA = "0x21B1A40", Offset = "0x21B0E40", Length = "0x1B")]
	[Token(Token = "0x6000F5C")]
	public override string get_System() { }

}

