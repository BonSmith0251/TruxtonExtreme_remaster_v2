namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x200011F")]
public class JsonISerializableContract : JsonContainerContract
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000557")]
	private ObjectConstructor<Object> <ISerializableCreator>k__BackingField; //Field offset: 0xC0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x1700011F")]
	public ObjectConstructor<Object> ISerializableCreator
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000841")]
		 get { } //Length: 8
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000842")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x2143370", Offset = "0x2142770", Length = "0x1E")]
	[NullableContext(1)]
	[Token(Token = "0x6000843")]
	public JsonISerializableContract(Type underlyingType) { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000841")]
	public ObjectConstructor<Object> get_ISerializableCreator() { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000842")]
	public void set_ISerializableCreator(ObjectConstructor<Object> value) { }

}

