namespace System.Security.Principal;

[ComVisible(True)]
[Token(Token = "0x200033E")]
public class WindowsImpersonationContext : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DAC")]
	private IntPtr _token; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DAD")]
	private bool undo; //Field offset: 0x18

	[Address(RVA = "0x1EF4360", Offset = "0x1EF3760", Length = "0x86")]
	[Token(Token = "0x6001A33")]
	internal WindowsImpersonationContext(IntPtr token) { }

	[Address(RVA = "0x1EF41B0", Offset = "0x1EF35B0", Length = "0x5")]
	[Token(Token = "0x6001A36")]
	private static bool CloseToken(IntPtr token) { }

	[Address(RVA = "0x1EF41C0", Offset = "0x1EF35C0", Length = "0xBA")]
	[ComVisible(False)]
	[Token(Token = "0x6001A34")]
	public override void Dispose() { }

	[Address(RVA = "0x1EF4280", Offset = "0x1EF3680", Length = "0x5")]
	[Token(Token = "0x6001A37")]
	private static IntPtr DuplicateToken(IntPtr token) { }

	[Address(RVA = "0x1EF4290", Offset = "0x1EF3690", Length = "0x5")]
	[Token(Token = "0x6001A39")]
	private static bool RevertToSelf() { }

	[Address(RVA = "0x1EF42A0", Offset = "0x1EF36A0", Length = "0x5")]
	[Token(Token = "0x6001A38")]
	private static bool SetCurrentToken(IntPtr token) { }

	[Address(RVA = "0x1EF42B0", Offset = "0x1EF36B0", Length = "0xAE")]
	[Token(Token = "0x6001A35")]
	public void Undo() { }

}

