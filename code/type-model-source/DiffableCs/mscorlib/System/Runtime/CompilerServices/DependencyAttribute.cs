namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
[Token(Token = "0x20004A9")]
public sealed class DependencyAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400128B")]
	private string dependentAssembly; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400128C")]
	private LoadHint loadHint; //Field offset: 0x18

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x6002161")]
	public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument) { }

}

