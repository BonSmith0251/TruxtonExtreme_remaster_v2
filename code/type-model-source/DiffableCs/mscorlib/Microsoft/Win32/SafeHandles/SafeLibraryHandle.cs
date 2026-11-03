namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x200007E")]
internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x1E7C790", Offset = "0x1E7BB90", Length = "0xD")]
	[Token(Token = "0x6000213")]
	internal SafeLibraryHandle() { }

	[Address(RVA = "0x1E7C890", Offset = "0x1E7BC90", Length = "0xB")]
	[Token(Token = "0x6000214")]
	protected virtual bool ReleaseHandle() { }

}

