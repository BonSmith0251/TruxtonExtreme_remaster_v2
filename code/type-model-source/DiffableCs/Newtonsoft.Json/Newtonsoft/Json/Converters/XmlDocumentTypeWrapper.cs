namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001C2")]
internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
{
	[FieldOffset(Offset = "0x28")]
	[Nullable(1)]
	[Token(Token = "0x4000815")]
	private readonly XmlDocumentType _documentType; //Field offset: 0x28

	[Token(Token = "0x1700025D")]
	public override string InternalSubset
	{
		[Address(RVA = "0x21B39E0", Offset = "0x21B2DE0", Length = "0x1B")]
		[Token(Token = "0x6000F1F")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700025E")]
	public virtual string LocalName
	{
		[Address(RVA = "0x21B3A00", Offset = "0x21B2E00", Length = "0x2C")]
		[Token(Token = "0x6000F20")]
		 get { } //Length: 44
	}

	[Nullable(1)]
	[Token(Token = "0x1700025A")]
	public override string Name
	{
		[Address(RVA = "0x21B3A30", Offset = "0x21B2E30", Length = "0x2A")]
		[NullableContext(1)]
		[Token(Token = "0x6000F1C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700025C")]
	public override string Public
	{
		[Address(RVA = "0x21B3940", Offset = "0x21B2D40", Length = "0x1B")]
		[Token(Token = "0x6000F1E")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700025B")]
	public override string System
	{
		[Address(RVA = "0x21B3960", Offset = "0x21B2D60", Length = "0x1B")]
		[Token(Token = "0x6000F1D")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x21B38F0", Offset = "0x21B2CF0", Length = "0x41")]
	[NullableContext(1)]
	[Token(Token = "0x6000F1B")]
	public XmlDocumentTypeWrapper(XmlDocumentType documentType) { }

	[Address(RVA = "0x21B39E0", Offset = "0x21B2DE0", Length = "0x1B")]
	[Token(Token = "0x6000F1F")]
	public override string get_InternalSubset() { }

	[Address(RVA = "0x21B3A00", Offset = "0x21B2E00", Length = "0x2C")]
	[Token(Token = "0x6000F20")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x21B3A30", Offset = "0x21B2E30", Length = "0x2A")]
	[NullableContext(1)]
	[Token(Token = "0x6000F1C")]
	public override string get_Name() { }

	[Address(RVA = "0x21B3940", Offset = "0x21B2D40", Length = "0x1B")]
	[Token(Token = "0x6000F1E")]
	public override string get_Public() { }

	[Address(RVA = "0x21B3960", Offset = "0x21B2D60", Length = "0x1B")]
	[Token(Token = "0x6000F1D")]
	public override string get_System() { }

}

