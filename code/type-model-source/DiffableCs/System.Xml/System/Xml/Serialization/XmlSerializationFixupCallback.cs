namespace System.Xml.Serialization;

[Token(Token = "0x2000120")]
public sealed class XmlSerializationFixupCallback : MulticastDelegate
{

	[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
	[Token(Token = "0x6000CD1")]
	public XmlSerializationFixupCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000CD2")]
	public override void Invoke(object fixup) { }

}

