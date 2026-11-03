namespace System.Reflection;

[AttributeUsage(1036)]
[Token(Token = "0x20004DD")]
public sealed class DefaultMemberAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400131E")]
	private readonly string <MemberName>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000420")]
	public string MemberName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002224")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6002223")]
	public DefaultMemberAttribute(string memberName) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002224")]
	public string get_MemberName() { }

}

