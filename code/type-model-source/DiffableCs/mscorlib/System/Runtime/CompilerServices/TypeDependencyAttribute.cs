namespace System.Runtime.CompilerServices;

[AttributeUsage(1036, AllowMultiple = True, Inherited = False)]
[Token(Token = "0x20004AE")]
internal sealed class TypeDependencyAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001292")]
	private string typeName; //Field offset: 0x10

	[Address(RVA = "0x1F43340", Offset = "0x1F42740", Length = "0x7E")]
	[Token(Token = "0x6002168")]
	public TypeDependencyAttribute(string typeName) { }

}

