namespace System.Xml.Schema;

[Token(Token = "0x200016C")]
internal class ContentValidator
{
	[Token(Token = "0x400076C")]
	public static readonly ContentValidator Empty; //Field offset: 0x0
	[Token(Token = "0x400076D")]
	public static readonly ContentValidator TextOnly; //Field offset: 0x8
	[Token(Token = "0x400076E")]
	public static readonly ContentValidator Mixed; //Field offset: 0x10
	[Token(Token = "0x400076F")]
	public static readonly ContentValidator Any; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000769")]
	private XmlSchemaContentType contentType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400076A")]
	private bool isOpen; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x400076B")]
	private bool isEmptiable; //Field offset: 0x15

	[Token(Token = "0x170003F9")]
	public XmlSchemaContentType ContentType
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000F39")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170003FB")]
	public override bool IsEmptiable
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x6000F3B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003FC")]
	public bool IsOpen
	{
		[Address(RVA = "0x2581F70", Offset = "0x2581370", Length = "0x14")]
		[Token(Token = "0x6000F3C")]
		 get { } //Length: 20
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[Token(Token = "0x6000F3D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003FA")]
	public bool PreserveWhitespace
	{
		[Address(RVA = "0x2581F90", Offset = "0x2581390", Length = "0x11")]
		[Token(Token = "0x6000F3A")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x2581D80", Offset = "0x2581180", Length = "0x166")]
	[Token(Token = "0x6000F45")]
	private static ContentValidator() { }

	[Address(RVA = "0x2581EF0", Offset = "0x25812F0", Length = "0x28")]
	[Token(Token = "0x6000F37")]
	public ContentValidator(XmlSchemaContentType contentType) { }

	[Address(RVA = "0x2581F20", Offset = "0x2581320", Length = "0x48")]
	[Token(Token = "0x6000F38")]
	protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	[Address(RVA = "0x2581CD0", Offset = "0x25810D0", Length = "0x73")]
	[Token(Token = "0x6000F43")]
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	[Address(RVA = "0x2581A30", Offset = "0x2580E30", Length = "0x294")]
	[Token(Token = "0x6000F44")]
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000F40")]
	public override bool CompleteValidation(ValidationState context) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F41")]
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F42")]
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000F39")]
	public XmlSchemaContentType get_ContentType() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x6000F3B")]
	public override bool get_IsEmptiable() { }

	[Address(RVA = "0x2581F70", Offset = "0x2581370", Length = "0x14")]
	[Token(Token = "0x6000F3C")]
	public bool get_IsOpen() { }

	[Address(RVA = "0x2581F90", Offset = "0x2581390", Length = "0x11")]
	[Token(Token = "0x6000F3A")]
	public bool get_PreserveWhitespace() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F3E")]
	public override void InitValidation(ValidationState context) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[Token(Token = "0x6000F3D")]
	public void set_IsOpen(bool value) { }

	[Address(RVA = "0x2581D50", Offset = "0x2581150", Length = "0x2D")]
	[Token(Token = "0x6000F3F")]
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

