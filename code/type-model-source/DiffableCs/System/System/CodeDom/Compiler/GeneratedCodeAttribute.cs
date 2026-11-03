namespace System.CodeDom.Compiler;

[AttributeUsage(AttributeTargets::All (32767), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x20000F7")]
public sealed class GeneratedCodeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000453")]
	private readonly string tool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000454")]
	private readonly string version; //Field offset: 0x18

	[Address(RVA = "0x1F319D0", Offset = "0x1F30DD0", Length = "0x4E")]
	[Token(Token = "0x6000615")]
	public GeneratedCodeAttribute(string tool, string version) { }

}

