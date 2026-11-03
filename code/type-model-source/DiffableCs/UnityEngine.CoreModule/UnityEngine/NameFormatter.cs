namespace UnityEngine;

[NativeHeader("Runtime/NameFormatter/NameFormatter.h")]
[Token(Token = "0x20001F5")]
[VisibleToOtherModules]
internal sealed class NameFormatter
{

	[Address(RVA = "0x307A080", Offset = "0x3079480", Length = "0x19B")]
	[FreeFunction]
	[Token(Token = "0x600160D")]
	public static string FormatVariableName(string name) { }

	[Address(RVA = "0x307A030", Offset = "0x3079430", Length = "0x42")]
	[Token(Token = "0x600160E")]
	private static void FormatVariableName_Injected(ref ManagedSpanWrapper name, out ManagedSpanWrapper ret) { }

}

