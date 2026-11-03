namespace UnityEngineInternal;

[Token(Token = "0x2000005")]
internal class DisplayInternal
{

	[Address(RVA = "0x2FE0100", Offset = "0x2FDF500", Length = "0x9A")]
	[Token(Token = "0x6000005")]
	internal static bool IsASecondaryDisplayIndex(int displayIndex) { }

	[Address(RVA = "0x2FE01A0", Offset = "0x2FDF5A0", Length = "0x2A")]
	[FreeFunction("UnityDisplayManager_PrimaryDisplayIndex")]
	[Token(Token = "0x6000004")]
	internal static int PrimaryDisplayIndex() { }

}

