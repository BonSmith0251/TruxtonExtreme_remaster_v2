namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000082")]
internal class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x1E7C790", Offset = "0x1E7BB90", Length = "0xD")]
	[Token(Token = "0x6000221")]
	internal SafeFindHandle() { }

	[Address(RVA = "0x1E7C740", Offset = "0x1E7BB40", Length = "0x4D")]
	[Token(Token = "0x6000222")]
	protected virtual bool ReleaseHandle() { }

}

