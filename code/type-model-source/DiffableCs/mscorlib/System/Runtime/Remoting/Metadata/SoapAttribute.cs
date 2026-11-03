namespace System.Runtime.Remoting.Metadata;

[ComVisible(True)]
[Token(Token = "0x200039A")]
public class SoapAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E80")]
	private bool _useAttribute; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E81")]
	protected string ProtXmlNamespace; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E82")]
	protected object ReflectInfo; //Field offset: 0x20

	[Token(Token = "0x17000318")]
	public override bool UseAttribute
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6001C2C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000319")]
	public override string XmlNamespace
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001C2D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001C2B")]
	public SoapAttribute() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6001C2C")]
	public override bool get_UseAttribute() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001C2D")]
	public override string get_XmlNamespace() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6001C2E")]
	internal override void SetReflectionObject(object reflectionObject) { }

}

