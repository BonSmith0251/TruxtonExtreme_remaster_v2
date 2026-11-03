namespace System.Xml.Linq;

[Token(Token = "0x200001E")]
public abstract class XNode : XObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004F")]
	internal XNode next; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000BE")]
	internal XNode() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C2")]
	internal override void AppendText(StringBuilder sb) { }

	[Token(Token = "0x60000C3")]
	internal abstract XNode CloneNode() { }

	[Address(RVA = "0x240E040", Offset = "0x240D440", Length = "0x2F4")]
	[Token(Token = "0x60000C4")]
	private string GetXmlString(SaveOptions o) { }

	[Address(RVA = "0x240E340", Offset = "0x240D740", Length = "0x70")]
	[Token(Token = "0x60000BF")]
	public void Remove() { }

	[Address(RVA = "0x240E3B0", Offset = "0x240D7B0", Length = "0x22")]
	[Token(Token = "0x60000C0")]
	public virtual string ToString() { }

	[Token(Token = "0x60000C1")]
	public abstract void WriteTo(XmlWriter writer) { }

}

