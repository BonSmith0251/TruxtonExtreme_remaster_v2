namespace System.Xml.Serialization;

[Token(Token = "0x20000FC")]
internal class ReflectionHelper
{
	[Token(Token = "0x40005E3")]
	private static readonly ParameterModifier[] empty_modifiers; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E1")]
	private Hashtable _clrTypes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E2")]
	private Hashtable _schemaTypes; //Field offset: 0x18

	[Address(RVA = "0x25433A0", Offset = "0x25427A0", Length = "0x65")]
	[Token(Token = "0x6000C04")]
	private static ReflectionHelper() { }

	[Address(RVA = "0x2543410", Offset = "0x2542810", Length = "0x8F")]
	[Token(Token = "0x6000C03")]
	public ReflectionHelper() { }

	[Address(RVA = "0x2542BD0", Offset = "0x2541FD0", Length = "0x3A4")]
	[Token(Token = "0x6000C02")]
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	[Address(RVA = "0x2542F80", Offset = "0x2542380", Length = "0x144")]
	[Token(Token = "0x6000C01")]
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	[Address(RVA = "0x25430D0", Offset = "0x25424D0", Length = "0xD0")]
	[Token(Token = "0x6000BFF")]
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	[Address(RVA = "0x25431B0", Offset = "0x25425B0", Length = "0x12A")]
	[Token(Token = "0x6000C00")]
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	[Address(RVA = "0x25432E0", Offset = "0x25426E0", Length = "0xB4")]
	[Token(Token = "0x6000BFE")]
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

}

