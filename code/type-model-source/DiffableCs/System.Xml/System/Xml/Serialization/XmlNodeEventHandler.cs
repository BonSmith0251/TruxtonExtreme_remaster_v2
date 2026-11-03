namespace System.Xml.Serialization;

[Token(Token = "0x20000F5")]
public sealed class XmlNodeEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000BED")]
	public XmlNodeEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000BEE")]
	public override void Invoke(object sender, XmlNodeEventArgs e) { }

}

