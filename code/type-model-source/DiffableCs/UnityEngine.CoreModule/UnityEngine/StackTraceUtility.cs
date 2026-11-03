namespace UnityEngine;

[Token(Token = "0x20001C1")]
public static class StackTraceUtility
{
	[Token(Token = "0x400068E")]
	private static string projectFolder; //Field offset: 0x0

	[Address(RVA = "0x3072780", Offset = "0x3071B80", Length = "0x62")]
	[Token(Token = "0x600140A")]
	private static StackTraceUtility() { }

	[Address(RVA = "0x3071930", Offset = "0x3070D30", Length = "0x7F0")]
	[Token(Token = "0x6001409")]
	internal static string ExtractFormattedStackTrace(StackTrace stackFrames) { }

	[Address(RVA = "0x3072130", Offset = "0x3071530", Length = "0x13D")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001407")]
	public static string ExtractStackTrace() { }

	[Address(RVA = "0x3072270", Offset = "0x3071670", Length = "0x3ED")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001408")]
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	[Address(RVA = "0x3072660", Offset = "0x3071A60", Length = "0x113")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001406")]
	internal static void SetProjectFolder(string folder) { }

}

