namespace System.Xml.Linq;

[Token(Token = "0x2000003")]
internal class BaseUriAnnotation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	internal string baseUri; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000003")]
	public BaseUriAnnotation(string baseUri) { }

}

