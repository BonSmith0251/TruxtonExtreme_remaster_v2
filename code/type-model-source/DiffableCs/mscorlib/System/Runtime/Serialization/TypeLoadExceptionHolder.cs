namespace System.Runtime.Serialization;

[Token(Token = "0x20003F0")]
internal class TypeLoadExceptionHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F6C")]
	private string m_typeName; //Field offset: 0x10

	[Token(Token = "0x170003C8")]
	internal string TypeName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001E3F")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001E3E")]
	internal TypeLoadExceptionHolder(string typeName) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001E3F")]
	internal string get_TypeName() { }

}

