namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1))]
[Token(Token = "0x20004A8")]
public sealed class DefaultDependencyAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400128A")]
	private LoadHint loadHint; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6002160")]
	public DefaultDependencyAttribute(LoadHint loadHintArgument) { }

}

