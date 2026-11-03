namespace System.Runtime.Serialization;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x2000004")]
public sealed class EnumMemberAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	private string value; //Field offset: 0x10

	[Token(Token = "0x17000006")]
	public string Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000006")]
	public string get_Value() { }

}

