namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000139")]
internal class SerializationBinderAdapter : ISerializationBinder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005BE")]
	public readonly SerializationBinder SerializationBinder; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000994")]
	public SerializationBinderAdapter(SerializationBinder serializationBinder) { }

	[Address(RVA = "0x216D520", Offset = "0x216C920", Length = "0x2F")]
	[NullableContext(2)]
	[Token(Token = "0x6000996")]
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	[Address(RVA = "0x216D550", Offset = "0x216C950", Length = "0x2A")]
	[Token(Token = "0x6000995")]
	public override Type BindToType(string assemblyName, string typeName) { }

}

