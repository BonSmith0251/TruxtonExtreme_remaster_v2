namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000137")]
public class ReflectionAttributeProvider : IAttributeProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005BC")]
	private readonly object _attributeProvider; //Field offset: 0x10

	[Address(RVA = "0x216D0B0", Offset = "0x216C4B0", Length = "0x62")]
	[Token(Token = "0x600098E")]
	public ReflectionAttributeProvider(object attributeProvider) { }

	[Address(RVA = "0x216D050", Offset = "0x216C450", Length = "0x60")]
	[Token(Token = "0x600098F")]
	public override IList<Attribute> GetAttributes(bool inherit) { }

	[Address(RVA = "0x216CFE0", Offset = "0x216C3E0", Length = "0x6F")]
	[Token(Token = "0x6000990")]
	public override IList<Attribute> GetAttributes(Type attributeType, bool inherit) { }

}

