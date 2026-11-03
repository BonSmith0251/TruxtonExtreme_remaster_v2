namespace System.Threading;

[Token(Token = "0x2000246")]
internal static class NativeEventCalls
{

	[Address(RVA = "0x20B2930", Offset = "0x20B1D30", Length = "0x5")]
	[Token(Token = "0x600136A")]
	public static void CloseEvent_internal(IntPtr handle) { }

	[Address(RVA = "0x20B2940", Offset = "0x20B1D40", Length = "0x5")]
	[Token(Token = "0x6001365")]
	private static IntPtr CreateEvent_icall(bool manual, bool initial, Char* name, int name_length, out int errorCode) { }

	[Address(RVA = "0x20B2950", Offset = "0x20B1D50", Length = "0x61")]
	[Token(Token = "0x6001364")]
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	[Address(RVA = "0x20B29D0", Offset = "0x20B1DD0", Length = "0xC4")]
	[Token(Token = "0x6001368")]
	public static bool ResetEvent(SafeWaitHandle handle) { }

	[Address(RVA = "0x20B29C0", Offset = "0x20B1DC0", Length = "0x5")]
	[Token(Token = "0x6001369")]
	private static bool ResetEvent_internal(IntPtr handle) { }

	[Address(RVA = "0x20B2AB0", Offset = "0x20B1EB0", Length = "0xC4")]
	[Token(Token = "0x6001366")]
	public static bool SetEvent(SafeWaitHandle handle) { }

	[Address(RVA = "0x20B2AA0", Offset = "0x20B1EA0", Length = "0x5")]
	[Token(Token = "0x6001367")]
	private static bool SetEvent_internal(IntPtr handle) { }

}

