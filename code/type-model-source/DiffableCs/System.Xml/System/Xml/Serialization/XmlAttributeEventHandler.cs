namespace System.Xml.Serialization;

[Token(Token = "0x20000F1")]
public sealed class XmlAttributeEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000BE7")]
	public XmlAttributeEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000BE8")]
	public override void Invoke(object sender, XmlAttributeEventArgs e) { }

}

