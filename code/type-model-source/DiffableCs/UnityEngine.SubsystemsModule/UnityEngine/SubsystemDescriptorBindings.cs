namespace UnityEngine;

[Token(Token = "0x2000007")]
internal static class SubsystemDescriptorBindings
{

	[Address(RVA = "0x3166800", Offset = "0x3165C00", Length = "0xAC")]
	[Token(Token = "0x600000D")]
	public static string GetId(IntPtr descriptorPtr) { }

	[Address(RVA = "0x31667B0", Offset = "0x3165BB0", Length = "0x42")]
	[Token(Token = "0x600000E")]
	private static void GetId_Injected(IntPtr descriptorPtr, out ManagedSpanWrapper ret) { }

}

