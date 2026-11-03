namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x200007D")]
internal static class SafeHandleCache
{
	[Token(Token = "0x4000237")]
	private static T s_invalidHandle; //Field offset: 0x0

	[Address(RVA = "0xF54BA0", Offset = "0xF53FA0", Length = "0x5E")]
	[Token(Token = "0x6000212")]
	internal static bool IsCachedInvalidHandle(SafeHandle handle) { }

}

