namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Property (128))]
[Token(Token = "0x200015E")]
public class AttributeProviderAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000604")]
	private readonly string <TypeName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000605")]
	private readonly string <PropertyName>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000198")]
	public string PropertyName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000878")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000197")]
	public string TypeName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000877")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000878")]
	public string get_PropertyName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000877")]
	public string get_TypeName() { }

}

