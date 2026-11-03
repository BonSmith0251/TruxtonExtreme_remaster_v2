namespace System.Reflection;

[Extension]
[Token(Token = "0x200050B")]
public static class CustomAttributeExtensions
{

	[Address(RVA = "0x1F53FD0", Offset = "0x1F533D0", Length = "0x8")]
	[Extension]
	[Token(Token = "0x60023C7")]
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Address(RVA = "0x1F53FE0", Offset = "0x1F533E0", Length = "0x8")]
	[Extension]
	[Token(Token = "0x60023C8")]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Address(RVA = "0x7BA530", Offset = "0x7B9930", Length = "0xA9")]
	[Extension]
	[Token(Token = "0x60023C9")]
	public static T GetCustomAttribute(Assembly element) { }

	[Address(RVA = "0x7BA5E0", Offset = "0x7B99E0", Length = "0xA9")]
	[Extension]
	[Token(Token = "0x60023CA")]
	public static T GetCustomAttribute(MemberInfo element) { }

	[Address(RVA = "0x1F53FF0", Offset = "0x1F533F0", Length = "0x8")]
	[Extension]
	[Token(Token = "0x60023CB")]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x7BA690", Offset = "0x7B9A90", Length = "0xBA")]
	[Extension]
	[Token(Token = "0x60023CC")]
	public static T GetCustomAttribute(MemberInfo element, bool inherit) { }

	[Address(RVA = "0x1F54020", Offset = "0x1F53420", Length = "0x7")]
	[Extension]
	[Token(Token = "0x60023CD")]
	public static IEnumerable<Attribute> GetCustomAttributes(Assembly element) { }

	[Address(RVA = "0x1F54010", Offset = "0x1F53410", Length = "0x7")]
	[Extension]
	[Token(Token = "0x60023CE")]
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element) { }

	[Address(RVA = "0x1F54030", Offset = "0x1F53430", Length = "0x8")]
	[Extension]
	[Token(Token = "0x60023CF")]
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[Address(RVA = "0x7BA750", Offset = "0x7B9B50", Length = "0xA9")]
	[Extension]
	[Token(Token = "0x60023D0")]
	public static IEnumerable<T> GetCustomAttributes(MemberInfo element) { }

	[Address(RVA = "0x1F54000", Offset = "0x1F53400", Length = "0x8")]
	[Extension]
	[Token(Token = "0x60023D1")]
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x7BA800", Offset = "0x7B9C00", Length = "0xBA")]
	[Extension]
	[Token(Token = "0x60023D2")]
	public static IEnumerable<T> GetCustomAttributes(MemberInfo element, bool inherit) { }

	[Address(RVA = "0x1F54040", Offset = "0x1F53440", Length = "0x8")]
	[Extension]
	[Token(Token = "0x60023D3")]
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

}

