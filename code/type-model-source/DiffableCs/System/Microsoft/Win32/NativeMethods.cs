namespace Microsoft.Win32;

[Token(Token = "0x20000AA")]
internal static class NativeMethods
{

	[Address(RVA = "0x260A100", Offset = "0x2609500", Length = "0x5")]
	[Token(Token = "0x6000332")]
	public static bool CloseProcess(IntPtr handle) { }

	[Address(RVA = "0x260A110", Offset = "0x2609510", Length = "0x150")]
	[Token(Token = "0x600032D")]
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	[Address(RVA = "0x260A280", Offset = "0x2609680", Length = "0x5")]
	[Token(Token = "0x600032E")]
	public static IntPtr GetCurrentProcess() { }

	[Address(RVA = "0x260A270", Offset = "0x2609670", Length = "0x5")]
	[Token(Token = "0x6000331")]
	public static int GetCurrentProcessId() { }

	[Address(RVA = "0x260A360", Offset = "0x2609760", Length = "0x5")]
	[Token(Token = "0x600032F")]
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	[Address(RVA = "0x260A290", Offset = "0x2609690", Length = "0xCA")]
	[Token(Token = "0x6000330")]
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

}

