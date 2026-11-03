namespace System;

[Token(Token = "0x20001A3")]
internal sealed class TypeNameParser
{

	[Address(RVA = "0x20909F0", Offset = "0x208FDF0", Length = "0x60")]
	[Token(Token = "0x6000F60")]
	internal static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }

}

