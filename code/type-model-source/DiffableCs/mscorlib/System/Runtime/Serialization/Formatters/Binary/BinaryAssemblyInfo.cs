namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040E")]
internal sealed class BinaryAssemblyInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001005")]
	internal string assemblyString; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001006")]
	private Assembly assembly; //Field offset: 0x18

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001E94")]
	internal BinaryAssemblyInfo(string assemblyString) { }

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6001E95")]
	internal BinaryAssemblyInfo(string assemblyString, Assembly assembly) { }

	[Address(RVA = "0x1F16680", Offset = "0x1F15A80", Length = "0x129")]
	[Token(Token = "0x6001E96")]
	internal Assembly GetAssembly() { }

}

