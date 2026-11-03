namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000108")]
public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
{
	[Token(Token = "0x4000504")]
	internal static readonly DefaultSerializationBinder Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 2, 1, 1})]
	[Token(Token = "0x4000505")]
	private readonly ThreadSafeStore<StructMultiKey`2<String, String>, Type> _typeCache; //Field offset: 0x10

	[Address(RVA = "0x213D9A0", Offset = "0x213CDA0", Length = "0x10F")]
	[Token(Token = "0x60007AD")]
	private static DefaultSerializationBinder() { }

	[Address(RVA = "0x213DAB0", Offset = "0x213CEB0", Length = "0xC0")]
	[Token(Token = "0x60007A7")]
	public DefaultSerializationBinder() { }

	[Address(RVA = "0x213D110", Offset = "0x213C510", Length = "0x95")]
	[NullableContext(2)]
	[Token(Token = "0x60007AC")]
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	[Address(RVA = "0x213D1B0", Offset = "0x213C5B0", Length = "0xB3")]
	[Token(Token = "0x60007AB")]
	public virtual Type BindToType(string assemblyName, string typeName) { }

	[Address(RVA = "0x213D270", Offset = "0x213C670", Length = "0x28A")]
	[Token(Token = "0x60007A9")]
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	[Address(RVA = "0x213D500", Offset = "0x213C900", Length = "0x5E")]
	[Token(Token = "0x60007AA")]
	private Type GetTypeByName(StructMultiKey<String, String> typeNameKey) { }

	[Address(RVA = "0x213D560", Offset = "0x213C960", Length = "0x437")]
	[Token(Token = "0x60007A8")]
	private Type GetTypeFromTypeNameKey(StructMultiKey<String, String> typeNameKey) { }

}

