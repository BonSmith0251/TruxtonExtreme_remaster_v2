namespace UnityEngine;

[Token(Token = "0x20001BE")]
internal class ScriptingUtility
{
	[Token(Token = "0x20001BF")]
	private struct TestClass
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400068D")]
		public int value; //Field offset: 0x0

	}


	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001403")]
	private static bool IsManagedCodeWorking() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001404")]
	private static void SetupCallbacks(IntPtr p) { }

}

