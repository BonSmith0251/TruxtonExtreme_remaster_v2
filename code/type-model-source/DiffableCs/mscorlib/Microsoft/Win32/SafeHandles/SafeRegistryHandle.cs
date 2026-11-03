namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x200007F")]
public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x1E7C790", Offset = "0x1E7BB90", Length = "0xD")]
	[Token(Token = "0x6000216")]
	internal SafeRegistryHandle() { }

	[Address(RVA = "0x1E7C710", Offset = "0x1E7BB10", Length = "0x29")]
	[Token(Token = "0x6000217")]
	public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	[Address(RVA = "0x1E7CB10", Offset = "0x1E7BF10", Length = "0x19")]
	[Token(Token = "0x6000215")]
	protected virtual bool ReleaseHandle() { }

}

