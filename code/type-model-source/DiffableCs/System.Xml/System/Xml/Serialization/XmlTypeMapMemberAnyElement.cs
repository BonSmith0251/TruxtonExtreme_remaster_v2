namespace System.Xml.Serialization;

[Token(Token = "0x200013E")]
internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
{

	[Token(Token = "0x1700038D")]
	public bool IsDefaultAny
	{
		[Address(RVA = "0x2592410", Offset = "0x2591810", Length = "0x211")]
		[Token(Token = "0x6000E09")]
		 get { } //Length: 529
	}

	[Address(RVA = "0x25921A0", Offset = "0x25915A0", Length = "0x7")]
	[Token(Token = "0x6000E0A")]
	public XmlTypeMapMemberAnyElement() { }

	[Address(RVA = "0x2592410", Offset = "0x2591810", Length = "0x211")]
	[Token(Token = "0x6000E09")]
	public bool get_IsDefaultAny() { }

	[Address(RVA = "0x25921B0", Offset = "0x25915B0", Length = "0x256")]
	[Token(Token = "0x6000E08")]
	public bool IsElementDefined(string name, string ns) { }

}

