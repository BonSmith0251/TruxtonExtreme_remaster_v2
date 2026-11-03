namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x20000AB")]
public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[Token(Token = "0x4000201")]
	internal static SafeProcessHandle InvalidHandle; //Field offset: 0x0

	[Address(RVA = "0x260CAD0", Offset = "0x260BED0", Length = "0x72")]
	[Token(Token = "0x6000336")]
	private static SafeProcessHandle() { }

	[Address(RVA = "0x260CB50", Offset = "0x260BF50", Length = "0x29")]
	[Token(Token = "0x6000333")]
	internal SafeProcessHandle(IntPtr handle) { }

	[Address(RVA = "0x260CB80", Offset = "0x260BF80", Length = "0x2E")]
	[Token(Token = "0x6000334")]
	public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle) { }

	[Address(RVA = "0x260CAC0", Offset = "0x260BEC0", Length = "0x9")]
	[Token(Token = "0x6000335")]
	protected virtual bool ReleaseHandle() { }

}

