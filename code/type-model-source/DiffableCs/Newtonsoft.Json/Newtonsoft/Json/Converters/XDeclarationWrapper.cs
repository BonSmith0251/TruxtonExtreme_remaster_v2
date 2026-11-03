namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001C9")]
internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Nullable(1)]
	[Token(Token = "0x4000819")]
	private readonly XDeclaration <Declaration>k__BackingField; //Field offset: 0x18

	[Nullable(1)]
	[Token(Token = "0x1700027A")]
	internal XDeclaration Declaration
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[NullableContext(1)]
		[Token(Token = "0x6000F52")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700027D")]
	public override string Encoding
	{
		[Address(RVA = "0x21B18A0", Offset = "0x21B0CA0", Length = "0x1B")]
		[Token(Token = "0x6000F56")]
		 get { } //Length: 27
		[Address(RVA = "0x21B1900", Offset = "0x21B0D00", Length = "0x23")]
		[Token(Token = "0x6000F57")]
		 set { } //Length: 35
	}

	[Token(Token = "0x1700027B")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
		[Token(Token = "0x6000F54")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700027E")]
	public override string Standalone
	{
		[Address(RVA = "0x21B18C0", Offset = "0x21B0CC0", Length = "0x1B")]
		[Token(Token = "0x6000F58")]
		 get { } //Length: 27
		[Address(RVA = "0x21B1930", Offset = "0x21B0D30", Length = "0x23")]
		[Token(Token = "0x6000F59")]
		 set { } //Length: 35
	}

	[Token(Token = "0x1700027C")]
	public override string Version
	{
		[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
		[Token(Token = "0x6000F55")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x21B1850", Offset = "0x21B0C50", Length = "0x44")]
	[NullableContext(1)]
	[Token(Token = "0x6000F53")]
	public XDeclarationWrapper(XDeclaration declaration) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[NullableContext(1)]
	[Token(Token = "0x6000F52")]
	internal XDeclaration get_Declaration() { }

	[Address(RVA = "0x21B18A0", Offset = "0x21B0CA0", Length = "0x1B")]
	[Token(Token = "0x6000F56")]
	public override string get_Encoding() { }

	[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
	[Token(Token = "0x6000F54")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x21B18C0", Offset = "0x21B0CC0", Length = "0x1B")]
	[Token(Token = "0x6000F58")]
	public override string get_Standalone() { }

	[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
	[Token(Token = "0x6000F55")]
	public override string get_Version() { }

	[Address(RVA = "0x21B1900", Offset = "0x21B0D00", Length = "0x23")]
	[Token(Token = "0x6000F57")]
	public override void set_Encoding(string value) { }

	[Address(RVA = "0x21B1930", Offset = "0x21B0D30", Length = "0x23")]
	[Token(Token = "0x6000F59")]
	public override void set_Standalone(string value) { }

}

