namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001C1")]
internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
{
	[FieldOffset(Offset = "0x28")]
	[Nullable(1)]
	[Token(Token = "0x4000814")]
	private readonly XmlDeclaration _declaration; //Field offset: 0x28

	[Token(Token = "0x17000258")]
	public override string Encoding
	{
		[Address(RVA = "0x21B3940", Offset = "0x21B2D40", Length = "0x1B")]
		[Token(Token = "0x6000F17")]
		 get { } //Length: 27
		[Address(RVA = "0x21B39A0", Offset = "0x21B2DA0", Length = "0x1E")]
		[Token(Token = "0x6000F18")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000259")]
	public override string Standalone
	{
		[Address(RVA = "0x21B3960", Offset = "0x21B2D60", Length = "0x1B")]
		[Token(Token = "0x6000F19")]
		 get { } //Length: 27
		[Address(RVA = "0x21B39C0", Offset = "0x21B2DC0", Length = "0x1E")]
		[Token(Token = "0x6000F1A")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000257")]
	public override string Version
	{
		[Address(RVA = "0x21B3980", Offset = "0x21B2D80", Length = "0x1B")]
		[Token(Token = "0x6000F16")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x21B38F0", Offset = "0x21B2CF0", Length = "0x41")]
	[NullableContext(1)]
	[Token(Token = "0x6000F15")]
	public XmlDeclarationWrapper(XmlDeclaration declaration) { }

	[Address(RVA = "0x21B3940", Offset = "0x21B2D40", Length = "0x1B")]
	[Token(Token = "0x6000F17")]
	public override string get_Encoding() { }

	[Address(RVA = "0x21B3960", Offset = "0x21B2D60", Length = "0x1B")]
	[Token(Token = "0x6000F19")]
	public override string get_Standalone() { }

	[Address(RVA = "0x21B3980", Offset = "0x21B2D80", Length = "0x1B")]
	[Token(Token = "0x6000F16")]
	public override string get_Version() { }

	[Address(RVA = "0x21B39A0", Offset = "0x21B2DA0", Length = "0x1E")]
	[Token(Token = "0x6000F18")]
	public override void set_Encoding(string value) { }

	[Address(RVA = "0x21B39C0", Offset = "0x21B2DC0", Length = "0x1E")]
	[Token(Token = "0x6000F1A")]
	public override void set_Standalone(string value) { }

}

