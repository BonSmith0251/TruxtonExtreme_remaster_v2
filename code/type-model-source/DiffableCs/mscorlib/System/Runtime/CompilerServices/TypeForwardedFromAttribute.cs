namespace System.Runtime.CompilerServices;

[AttributeUsage(5148, Inherited = False, AllowMultiple = False)]
[Token(Token = "0x200048F")]
public sealed class TypeForwardedFromAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400125D")]
	private readonly string <AssemblyFullName>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000406")]
	public string AssemblyFullName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60020F9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F433C0", Offset = "0x1F427C0", Length = "0x87")]
	[Token(Token = "0x60020F8")]
	public TypeForwardedFromAttribute(string assemblyFullName) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60020F9")]
	public string get_AssemblyFullName() { }

}

