namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000004")]
internal static class ILSupport
{

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000003")]
	public static Void* AddressOf(in T thing) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000004")]
	public static T AsRef(in T thing) { }

}

