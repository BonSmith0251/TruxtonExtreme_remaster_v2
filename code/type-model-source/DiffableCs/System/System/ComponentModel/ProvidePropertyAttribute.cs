namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
[Token(Token = "0x200018E")]
public sealed class ProvidePropertyAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065E")]
	private readonly string <PropertyName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400065F")]
	private readonly string <ReceiverTypeName>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001E8")]
	public string PropertyName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009D5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001E9")]
	public string ReceiverTypeName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009D6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009D5")]
	public string get_PropertyName() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009D6")]
	public string get_ReceiverTypeName() { }

}

