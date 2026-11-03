namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000080")]
internal sealed class SafePasswordHandle : SafeHandle
{

	[Token(Token = "0x1700002F")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x1E7CAE0", Offset = "0x1E7BEE0", Length = "0x22")]
		[Token(Token = "0x600021D")]
		 get { } //Length: 34
	}

	[Address(RVA = "0x1E7CA70", Offset = "0x1E7BE70", Length = "0x6C")]
	[Token(Token = "0x600021A")]
	public SafePasswordHandle(string password) { }

	[Address(RVA = "0x1E7C8A0", Offset = "0x1E7BCA0", Length = "0x49")]
	[Token(Token = "0x6000218")]
	private IntPtr CreateHandle(string password) { }

	[Address(RVA = "0x1E7C8F0", Offset = "0x1E7BCF0", Length = "0x5C")]
	[Token(Token = "0x600021C")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1E7C950", Offset = "0x1E7BD50", Length = "0x4D")]
	[Token(Token = "0x6000219")]
	private void FreeHandle() { }

	[Address(RVA = "0x1E7CAE0", Offset = "0x1E7BEE0", Length = "0x22")]
	[Token(Token = "0x600021D")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x1E7C9A0", Offset = "0x1E7BDA0", Length = "0x4D")]
	[Token(Token = "0x600021E")]
	internal string Mono_DangerousGetString() { }

	[Address(RVA = "0x1E7C9F0", Offset = "0x1E7BDF0", Length = "0x71")]
	[Token(Token = "0x600021B")]
	protected virtual bool ReleaseHandle() { }

}

