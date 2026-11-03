namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000159")]
public sealed class AmbientValueAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005FA")]
	private readonly object <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000190")]
	public object Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000862")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000862")]
	public object get_Value() { }

}

