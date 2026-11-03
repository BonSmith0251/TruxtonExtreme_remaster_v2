namespace UnityEngine._Scripting.APIUpdating;

[Token(Token = "0x2000200")]
internal class APIUpdaterRuntimeHelpers
{

	[Address(RVA = "0x30763F0", Offset = "0x30757F0", Length = "0x176")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001707")]
	internal static bool GetMovedFromAttributeDataForType(Type sourceType, out string assembly, out string nsp, out string klass) { }

	[Address(RVA = "0x3076570", Offset = "0x3075970", Length = "0x325")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001708")]
	internal static bool GetObsoleteTypeRedirection(Type sourceType, out string assemblyName, out string nsp, out string className) { }

}

