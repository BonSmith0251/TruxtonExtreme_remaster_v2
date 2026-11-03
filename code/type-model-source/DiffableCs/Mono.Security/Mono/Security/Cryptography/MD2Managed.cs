namespace Mono.Security.Cryptography;

[Token(Token = "0x200004A")]
public class MD2Managed : MD2
{
	[Token(Token = "0x4000212")]
	private static readonly Byte[] PI_SUBST; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400020D")]
	private Byte[] state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400020E")]
	private Byte[] checksum; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400020F")]
	private Byte[] buffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000210")]
	private int count; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000211")]
	private Byte[] x; //Field offset: 0x48

	[Address(RVA = "0x1E4F370", Offset = "0x1E4E770", Length = "0x8C")]
	[Token(Token = "0x600018A")]
	private static MD2Managed() { }

	[Address(RVA = "0x1E4F400", Offset = "0x1E4E800", Length = "0xD6")]
	[Token(Token = "0x6000185")]
	public MD2Managed() { }

	[Address(RVA = "0x1E4ED50", Offset = "0x1E4E150", Length = "0xF7")]
	[Token(Token = "0x6000187")]
	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	[Address(RVA = "0x1E4EE50", Offset = "0x1E4E250", Length = "0x159")]
	[Token(Token = "0x6000188")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1E4EFB0", Offset = "0x1E4E3B0", Length = "0x65")]
	[Token(Token = "0x6000186")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1E4F020", Offset = "0x1E4E420", Length = "0x2C2")]
	[Token(Token = "0x6000189")]
	private void MD2Transform(Byte[] state, Byte[] checksum, Byte[] block, int index) { }

	[Address(RVA = "0x1E4F2F0", Offset = "0x1E4E6F0", Length = "0x7B")]
	[Token(Token = "0x6000184")]
	private Byte[] Padding(int nLength) { }

}

