namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200009F")]
internal class TypeInformation
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003CC")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003CD")]
	private readonly PrimitiveTypeCode <TypeCode>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000B4")]
	public Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000533")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B5")]
	public PrimitiveTypeCode TypeCode
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000534")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x6000535")]
	public TypeInformation(Type type, PrimitiveTypeCode typeCode) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000533")]
	public Type get_Type() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000534")]
	public PrimitiveTypeCode get_TypeCode() { }

}

