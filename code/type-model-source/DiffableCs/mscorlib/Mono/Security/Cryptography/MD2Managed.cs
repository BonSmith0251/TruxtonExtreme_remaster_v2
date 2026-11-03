namespace Mono.Security.Cryptography;

[Token(Token = "0x2000062")]
internal class MD2Managed : MD2
{
	[Token(Token = "0x40001C9")]
	private static readonly Byte[] PI_SUBST; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C4")]
	private Byte[] state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001C5")]
	private Byte[] checksum; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001C6")]
	private Byte[] buffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001C7")]
	private int count; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001C8")]
	private Byte[] x; //Field offset: 0x48

	[Address(RVA = "0x1E60700", Offset = "0x1E5FB00", Length = "0x8C")]
	[Token(Token = "0x6000148")]
	private static MD2Managed() { }

	[Address(RVA = "0x1E60790", Offset = "0x1E5FB90", Length = "0xD6")]
	[Token(Token = "0x6000143")]
	public MD2Managed() { }

	[Address(RVA = "0x1E60150", Offset = "0x1E5F550", Length = "0xF7")]
	[Token(Token = "0x6000145")]
	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	[Address(RVA = "0x1E60250", Offset = "0x1E5F650", Length = "0x159")]
	[Token(Token = "0x6000146")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1E4EFB0", Offset = "0x1E4E3B0", Length = "0x65")]
	[Token(Token = "0x6000144")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1E603B0", Offset = "0x1E5F7B0", Length = "0x2C2")]
	[Token(Token = "0x6000147")]
	private void MD2Transform(Byte[] state, Byte[] checksum, Byte[] block, int index) { }

	[Address(RVA = "0x1E60680", Offset = "0x1E5FA80", Length = "0x7B")]
	[Token(Token = "0x6000142")]
	private Byte[] Padding(int nLength) { }

}

