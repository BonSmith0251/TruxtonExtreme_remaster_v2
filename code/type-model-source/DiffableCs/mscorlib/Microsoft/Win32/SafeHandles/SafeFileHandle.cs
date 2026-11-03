namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000081")]
public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x1E7C710", Offset = "0x1E7BB10", Length = "0x29")]
	[Token(Token = "0x600021F")]
	public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	[Address(RVA = "0x1E7C6A0", Offset = "0x1E7BAA0", Length = "0x64")]
	[Token(Token = "0x6000220")]
	protected virtual bool ReleaseHandle() { }

}

