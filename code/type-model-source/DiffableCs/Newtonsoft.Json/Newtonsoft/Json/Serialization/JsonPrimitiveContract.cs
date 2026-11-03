namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000122")]
public class JsonPrimitiveContract : JsonContract
{
	[Token(Token = "0x4000567")]
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000566")]
	private PrimitiveTypeCode <TypeCode>k__BackingField; //Field offset: 0x90

	[Token(Token = "0x1700012D")]
	internal PrimitiveTypeCode TypeCode
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600085E")]
		internal get { } //Length: 7
		[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600085F")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x2143A10", Offset = "0x2142E10", Length = "0x2D7")]
	[Token(Token = "0x6000861")]
	private static JsonPrimitiveContract() { }

	[Address(RVA = "0x2143CF0", Offset = "0x21430F0", Length = "0xE8")]
	[Token(Token = "0x6000860")]
	public JsonPrimitiveContract(Type underlyingType) { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600085E")]
	internal PrimitiveTypeCode get_TypeCode() { }

	[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600085F")]
	internal void set_TypeCode(PrimitiveTypeCode value) { }

}

