namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
[Token(Token = "0x200019B")]
public sealed class TypeDescriptionProviderAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400066E")]
	private readonly string <TypeName>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001EE")]
	public string TypeName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A10")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2678BF0", Offset = "0x2677FF0", Length = "0x7E")]
	[Token(Token = "0x6000A0F")]
	public TypeDescriptionProviderAttribute(string typeName) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A10")]
	public string get_TypeName() { }

}

