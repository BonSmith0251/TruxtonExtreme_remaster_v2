namespace Newtonsoft.Json;

[AttributeUsage(3484, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200001D")]
public sealed class JsonConverterAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003F")]
	private readonly Type _converterType; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000040")]
	private readonly Object[] <ConverterParameters>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x17000016")]
	public Object[] ConverterParameters
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600008F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000015")]
	public Type ConverterType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600008E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x20CCE20", Offset = "0x20CC220", Length = "0x9F")]
	[Token(Token = "0x6000090")]
	public JsonConverterAttribute(Type converterType) { }

	[Address(RVA = "0x20CCD60", Offset = "0x20CC160", Length = "0xBC")]
	[Token(Token = "0x6000091")]
	public JsonConverterAttribute(Type converterType, Object[] converterParameters) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600008F")]
	public Object[] get_ConverterParameters() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600008E")]
	public Type get_ConverterType() { }

}

