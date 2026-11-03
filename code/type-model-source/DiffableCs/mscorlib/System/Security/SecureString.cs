namespace System.Security;

[MonoTODO("work in progress - encryption is missing")]
[Token(Token = "0x20002D0")]
public sealed class SecureString : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C16")]
	private int length; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C17")]
	private bool disposed; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C18")]
	private Byte[] data; //Field offset: 0x18

	[Token(Token = "0x17000252")]
	public int Length
	{
		[Address(RVA = "0x1EAAAC0", Offset = "0x1EA9EC0", Length = "0x64")]
		[Token(Token = "0x60017AF")]
		 get { } //Length: 100
	}

	[Address(RVA = "0x1EAAA60", Offset = "0x1EA9E60", Length = "0x5E")]
	[Token(Token = "0x60017AD")]
	public SecureString() { }

	[Address(RVA = "0x1EAA8E0", Offset = "0x1EA9CE0", Length = "0x177")]
	[CLSCompliant(False)]
	[Token(Token = "0x60017AE")]
	public SecureString(Char* value, int length) { }

	[Address(RVA = "0x1EAA610", Offset = "0x1EA9A10", Length = "0x1B3")]
	[Token(Token = "0x60017B3")]
	private void Alloc(int length, bool realloc) { }

	[Address(RVA = "0x945130", Offset = "0x944530", Length = "0x3")]
	[Token(Token = "0x60017B2")]
	private void Decrypt() { }

	[Address(RVA = "0x1EAA7D0", Offset = "0x1EA9BD0", Length = "0x57")]
	[Token(Token = "0x60017B0")]
	public override void Dispose() { }

	[Address(RVA = "0x945130", Offset = "0x944530", Length = "0x3")]
	[Token(Token = "0x60017B1")]
	private void Encrypt() { }

	[Address(RVA = "0x1EAAAC0", Offset = "0x1EA9EC0", Length = "0x64")]
	[Token(Token = "0x60017AF")]
	public int get_Length() { }

	[Address(RVA = "0x1EAA830", Offset = "0x1EA9C30", Length = "0xA3")]
	[Token(Token = "0x60017B4")]
	internal Byte[] GetBuffer() { }

}

