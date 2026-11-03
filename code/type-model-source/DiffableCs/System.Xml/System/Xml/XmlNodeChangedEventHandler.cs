namespace System.Xml;

[Token(Token = "0x20000A6")]
public sealed class XmlNodeChangedEventHandler : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000925")]
	public XmlNodeChangedEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000926")]
	public override void Invoke(object sender, XmlNodeChangedEventArgs e) { }

}

